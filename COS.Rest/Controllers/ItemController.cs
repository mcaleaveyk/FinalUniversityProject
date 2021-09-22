using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

using COS.Data.Services;
using COS.Core.DTOs;
using COS.Rest.Helpers;
using COS.Core.Models;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public ItemController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    }

    [HttpGet]
    [Authorize]
    public IActionResult ItemList()
    {
        return Ok( _service.GetAllItems());
    }  

    [HttpGet("fillings")]
    [Authorize]
    public IActionResult GetAllFillings()
    {
        return Ok(_service.GetAllFillings());
    }

    [HttpGet("{id}")]       
    public IActionResult Get(int id)
    {
        var item =  _service.GetItemById(id); 
        var dto = item.ToDto();
        if (item == null)
        {
            return NotFound(new ErrorResponse { Message = $"item {id} not found" });
        }
        return Ok(dto);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles="Admin")]   
    public IActionResult Delete(int id)
    {
        var ok = _service.DeleteItemFromMenu(id);
        if (ok)
        {
            return Ok();
        }
        return NotFound( new ErrorResponse { Message = $"Item {id} could not be deleted" });
    }

    [HttpPut("{id}")]
    [Authorize(Roles="Admin")]
    public IActionResult update(int id, ItemDto i)
    {
        var item = i.ToItem();
        var updatedItem = _service.UpdateItem(id, item); 
        if (updatedItem == null)
        {  
            return BadRequest( new ErrorResponse { Message = $"Problem updating item {id}" });
        }          
        return Ok(updatedItem);
    }

    [HttpPost] 
    [Authorize(Roles="Admin")]
    public IActionResult Create(Item i)
    {
        var item = _service.AddItemToMenu(i.Name, i.Price, i.Description, i.InStock, i.CategoryId, (Size)i.Size);
        if (item == null)
        {
            return BadRequest(new ErrorResponse { Message = "Item could not be created" } ); 
        }

        return CreatedAtAction(nameof(Get), new { Id = item.Id}, item);
    }
}