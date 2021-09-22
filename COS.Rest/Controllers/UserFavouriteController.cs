using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

using COS.Data.Services;
using COS.Core.DTOs;
using COS.Rest.Helpers;
using COS.Core.Models;

[Route("api/[controller]")]
[ApiController]
public class UserFavouriteController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public UserFavouriteController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    } 

    [HttpGet("user/{id}")]
    [Authorize]
    public IActionResult FavouritesList(int id)
    {
        var favourites = _service.GetFavourites(id);
        if(favourites == null)
        {
            return NotFound(new ErrorResponse { Message = $"User favourites {id} not found" });
        }

        List<ItemDto> itemlist = new List<ItemDto>();

        foreach(var item in favourites)
        {
            var item2 = _service.GetItemById(item.ItemId).ToDto();
            itemlist.Add(item2);
        }

        return Ok(itemlist);
    }   

    [HttpDelete("{userId}/{itemId}")]
    [Authorize]   
    public IActionResult delete(int userId, int itemId)
    {
        var ok = _service.RemoveItemFromUserFavourites(userId, itemId);
        if (ok)
        {
            return Ok();
        }
        return NotFound( new ErrorResponse { Message = $"Userfavourite could not be deleted" });
    }

    [HttpPost]
    [Authorize]
    public IActionResult Create(UserFavouriteDto f)
    {
        var userfavourite = _service.AddItemToFavourites(f.UserId, f.ItemId);
        if(userfavourite == null)
        {
            return BadRequest(new ErrorResponse { Message = "Item could not be added to favourites. This item may already be in your favourites" } );

        }
        
        return Ok(userfavourite.ToDto());

    }

}
