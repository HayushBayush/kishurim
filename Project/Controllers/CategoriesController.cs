
using Microsoft.AspNetCore.Mvc;
using Project;
using Project.Core.services;
using Project.Entities;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _CategoryService;
    public CategoriesController(ICategoryService categoryService)
    {
        _CategoryService = categoryService;

    }
    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_CategoryService.GetList());
    }

    // GET api/<categoriesController>/5
    [HttpGet("{id}")]
    public ActionResult GetByid(int id)
    {
        var category = _CategoryService.GetByid(id);
        if (category != null)
        {
            return Ok(category);
        }
        return NotFound();
    }

    
    // POST api/<categoriesController>
    [HttpPost]
    public ActionResult Post([FromBody] Category category)
    {
        if (category == null)
        {
            return BadRequest();
        }

        var createdCategory = _CategoryService.Add(category);
        return CreatedAtAction(nameof(GetByid), new { id = createdCategory.Id }, createdCategory);
    }


    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Category value)
    {
        if (value == null)
        {
            return BadRequest();
        }

        var updatedCategory = _CategoryService.Update(id, value);
        if (updatedCategory != null)
        {
            return Ok(updatedCategory);
        }
        return NotFound();
    }
}

