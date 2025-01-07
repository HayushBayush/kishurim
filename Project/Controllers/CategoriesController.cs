using Microsoft.AspNetCore.Mvc;
using Project.Core.services;
using Project.Entities;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService; // תלות בשירות הקטגוריות
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_categoryService.GetList()); // מחזיר את כל הקטגוריות
    }

    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var category = _categoryService.GetById(id);
        if (category != null)
        {
            return Ok(category); // מחזיר קטגוריה לפי מזהה אם קיימת
        }
        return NotFound(); // מחזיר שלא נמצא
    }

    [HttpPost]
    public ActionResult Post([FromBody] Category category)
    {
        if (category == null || string.IsNullOrWhiteSpace(category.Name))
        {
            return BadRequest(); // בדיקה שהקטגוריה תקינה
        }

        var createdCategory = _categoryService.Add(category);
        return CreatedAtAction(nameof(GetById), new { id = createdCategory.Id }, createdCategory);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Category value)
    {
        if (value == null || value.Id != id)
        {
            return BadRequest(); // בדיקה שהנתונים תואמים
        }

        var updatedCategory = _categoryService.Update(id, value);
        if (updatedCategory != null)
        {
            return Ok(updatedCategory);
        }
        return NotFound(); // אם הקטגוריה לא קיימת
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var exists = _categoryService.GetById(id) != null;
        if (!exists)
        {
            return NotFound(); // אם הקטגוריה לא קיימת
        }

        _categoryService.Deletecategory(id);
        return NoContent(); // מחזיר הצלחה ללא תוכן
    }
}
