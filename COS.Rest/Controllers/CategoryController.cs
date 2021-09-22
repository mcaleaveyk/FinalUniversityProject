using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

using COS.Data.Services;
using COS.Core.DTOs;
using COS.Rest.Helpers;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly ICafeService _service;

    // Inject Services
    public CategoryController(ICafeService service, IConfiguration configuration)
    {
        _configuration = configuration;
        _service = service;
    }

    [HttpGet]
    [Authorize(Roles="Admin")]
    public IActionResult CategoryList()
    {
        var categories = _service.GetAllCategories();
        var categorydtos = new List<CategoryDto>();
        foreach(var v in categories)
        {
            var dto = v.ToDto();
            categorydtos.Add(dto);
        }

        return Ok(categorydtos);

    }  

    [HttpGet("foruser")]
    [Authorize]
    public IActionResult CategoryListForUser()
    {
        var categories = _service.GetAllCategoriesForUser();
        var categorydtos = new List<CategoryDto>();
        foreach(var v in categories)
        {
            var dto = v.ToDto();
            categorydtos.Add(dto);
        }

        return Ok(categorydtos);

    }   

    [HttpGet("{id}")]       
    public IActionResult Get(int id)
    {
        var category =  _service.GetCategoryById(id); 
        var dto = category.ToDto();
        if (category == null)
        {
            return NotFound(new ErrorResponse { Message = $"category {id} not found" });
        }
        return Ok(dto);
    }

    [HttpPost] 
    [Authorize(Roles="Admin")]
    public IActionResult Create(CategoryDto c)
    {
        var category = _service.AddCategory(c.Name);
        if (category == null)
        {
            return BadRequest(new ErrorResponse { Message = "Category could not be created" } );
            
        }
        return CreatedAtAction(
            nameof(Get), 
            new { Id = category.Id, 
            Items = category.Items}, 
            category.ToDto()
            );
    }

    [HttpDelete("{id}")]
    [Authorize(Roles="Admin")]   
    public IActionResult Delete(int id)
    {
        var ok = _service.DeleteCategory(id);
        if (ok)
        {
            return Ok();
        }
        return NotFound( new ErrorResponse { Message = $"Category {id} could not be deleted" });
    }

    [HttpPut("{id}")]
    [Authorize(Roles="Admin")]
    public IActionResult update(int id, CategoryDto c)
    {
        var category = c.ToCategory();
        var updatedCategory = _service.ChangeCategoryName(id, category); 
        if (updatedCategory == null)
        {  
            return BadRequest( new ErrorResponse { Message = $"Problem updating category {id}" });
        }          
        return Ok(updatedCategory.ToDto());
    }

}
