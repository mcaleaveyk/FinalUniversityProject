using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

using COS.Data.Services;
using COS.Core.DTOs;
using COS.Rest.Helpers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public UserController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    } 

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetUser(int id)
    {
        var user = _service.GetUser(id);
        var dto = user.ToDto();
        if (user == null)
        {
            return NotFound(new ErrorResponse { Message = $"user id {id} not found" });
        }
        return Ok(dto);
    } 

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginDto login)
    {
        var user = _service.Authenticate(login.Email, login.Password);            
        if (user == null)
        {          
            return Unauthorized( new ErrorResponse { Message = "Username and/or password are invalid."} );
        }
        var dto = user.ToDto();
        dto.Token = JwtHelper.SignJwtToken(user, _configuration);
        return Ok( dto );
    }
    
    [HttpPost("register")]
    public IActionResult Post([FromBody]RegisterDto model)
    {
        var user = _service.RegisterUser(model.FirstName, model.LastName, model.Email ,model.Password, model.Role);       
        if (user == null)
        {  
            return BadRequest(new ErrorResponse { Message = "Error creating user" } );
        }
        return CreatedAtAction(nameof(Login), user);
     }

    [HttpGet("verify/{email}/{id?}")]
    public IActionResult VerifyEmailAvailable(string email, int? id)
    {
        return Ok(_service.GetUserByEmailAddress(email, id)==null);
    }
}