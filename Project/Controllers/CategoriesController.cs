
using Microsoft.AspNetCore.Mvc;
using Project;
using Project.Entities;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly DataContext _context;

    public CategoriesController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Category> Get()
    {
        return _context.Category;
    }

    // GET api/<categoriesController>/5
    [HttpGet("{id}")]
    public ActionResult<Category> GetByid(int id)
    {
        var category = _context.Category.Find(x => x.id == id);
        if (category != null)
        {
            return Ok(category);
        }
        return NotFound();
    }

    // POST api/<categoriesController>
    [HttpPost]
    public Category Post([FromBody] Category value)
    {
        _context.Category.Add(new Category { id = value.id, name = value.name });
        return value;
    }
    // PUT api
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Category value)
    {
        var index = _context.Category.FindIndex(e => e.id == id);
        if (index >= 0)
        {
            _context.Category[index].name = value.name;
            return Ok(_context.Category[index]);
        }
        return NotFound();
    }
}
