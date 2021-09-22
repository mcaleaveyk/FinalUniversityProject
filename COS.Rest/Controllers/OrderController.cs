using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

using COS.Data.Services;
using COS.Core.DTOs;
using COS.Rest.Helpers;
using COS.Core.Models;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public OrderController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    }

    [HttpGet("active")]
    [Authorize(Roles="Admin, Manager")]
    public IActionResult ActiveOrderList()
    {
        return Ok( _service.GetAllActiveOrders());
    }  

    [HttpGet]
    [Authorize(Roles="Admin, Manager")]
    public IActionResult OrderList()
    {
        return Ok( _service.GetAllOrders());
    }  

    [HttpGet("recent/{id}")]
    [Authorize]      
    public IActionResult RecentOrderList(int id)
    {
        var recentOrders =  _service.GetThreeMostRecentOrders(id); 

        if (recentOrders == null)
        {
            return NotFound(new ErrorResponse { Message = $"recent orders for user {id} not found" });
        }

        List<OrderDto> RecentsList = new List<OrderDto>();

        foreach(var order in recentOrders)
        {
            var item2 = _service.GetOrder(order.Id).ToDto();
            RecentsList.Add(item2);
        }

        return Ok(RecentsList);
    }

    [HttpGet("submitted/{id}")]
    [Authorize]      
    public IActionResult SubmittedOrderList(int id)
    {
        var recentOrders =  _service.GetUsersSubmittedOrders(id); 

        if (recentOrders == null)
        {
            return NotFound(new ErrorResponse { Message = $"recent orders for user {id} not found" });
        }

        List<OrderDto> RecentsList = new List<OrderDto>();

        foreach(var order in recentOrders)
        {
            var item2 = _service.GetOrder(order.Id).ToDto();
            RecentsList.Add(item2);
        }

        return Ok(RecentsList);
    }        

    [HttpGet("{id}")]
    [Authorize]       
    public IActionResult Get(int id)
    {
        var order =  _service.GetOrder(id); 
        var dto = order.ToDto();
        if (order == null)
        {
            return NotFound(new ErrorResponse { Message = $"order id {id} not found" });
        }
        return Ok(dto);
    }

    [HttpGet("recentunsubmitted/{id}")]
    [Authorize]
    public IActionResult GetRecentUnsubmitted(int id)
    {
        var order = _service.GetUsersRecentUnsubmittedOrder(id);
        var dto = order.ToDto();
        if (order == null)
        {
            return NotFound(new ErrorResponse { Message = $"order id {id} not found" });
        }
        return Ok(dto);
    }

    [HttpPatch("{id}/foodready")]   
    [Authorize(Roles="Admin")]
    public IActionResult MarkFoodAsReady(int id)
    {
        var order = _service.GetOrder(id);
        var dto = order.ToDto();

        _service.MarkFoodAsReady(order.Id);

        return Ok(order);
    }

    [HttpPatch("{id}/orderfulfilled")]
    [Authorize(Roles="Admin")]
    public IActionResult MarkOrderAsFulfilled(int id)
    {
        var order = _service.GetOrder(id);

        _service.MarkOrderAsFulfilled(order.Id);

        return Ok(order);
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult update(int id, OrderDto o)
    {
        var order = o.ToOrder();
        var updatedOrder = _service.UpdateOrder(id, order); 
        if (updatedOrder == null)
        {  
            return BadRequest( new ErrorResponse { Message = $"Problem updating order {id}" });
        }          
        return Ok(updatedOrder.ToDto());
    }

    [HttpPost]
    [Authorize] 
    public IActionResult Create(CreateOrderDto o)
    {
        var order = _service.CreateOrder(o.UserId);
        if (order == null)
        {
            return BadRequest(new ErrorResponse { Message = "Order could not be created" } ); 
        }

        return CreatedAtAction(nameof(Get), new { Id = order.Id}, order);
    }

    [HttpDelete("{id}")]
    [Authorize]   
    public IActionResult DeleteOrder(int id)
    {
        var ok = _service.DeleteOrder(id);
        if (ok)
        {
            return Ok();
        }
        return NotFound( new ErrorResponse { Message = $"Order could not be deleted" });
    }

}
