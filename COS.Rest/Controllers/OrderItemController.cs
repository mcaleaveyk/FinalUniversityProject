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
public class OrderItemController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public OrderItemController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    } 

    [HttpGet]
    [Authorize]
    public IActionResult Get([FromBody]OrderItem oi)
    {
        var orderItem =  _service.GetOrderItem(oi.OrderId, oi.ItemId); 
        var dto = orderItem.ToDto();
        if (orderItem == null)
        {
            return NotFound(new ErrorResponse { Message = $"orderItem not found" });
        }
        return Ok(dto);
    }

    [HttpDelete("{orderId}/{itemId}")]
    [Authorize]   
    public IActionResult DeleteItemFromOrder(int orderId, int itemId)
    {
        var ok = _service.RemoveItemFromOrder(orderId, itemId);
        if (ok)
        {
            return Ok();
        }
        return NotFound( new ErrorResponse { Message = $"OrderItem could not be deleted" });
    }

    [HttpPost]
    [Authorize]
    public IActionResult AddItemToOrder(AddItemToOrderDto dto)
    {
        var orderItem = _service.AddItemToOrder(dto.OrderId, dto.ItemId);
        if(orderItem == null)
        {
            return BadRequest(new ErrorResponse { Message = "Item could not be added to order. It may be temporarily out of stock" } );

        }
         return Ok(orderItem.ToDto());
    }

}
