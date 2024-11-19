
using Microsoft.AspNetCore.Mvc;
using Project;
using Project.Entities;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }


    [HttpGet]
    public IEnumerable<User> Get()
    {
        return _context.User;
    }

    // GET api/<categoriesController>/5
    [HttpGet("{id}")]
    public ActionResult<User> GetByid(int id)
    {
        var User = _context.User.Find(x => x.id == id);
        if (User != null)
        {
            return Ok(User);
        }
        return NotFound();
    }

    // POST 
    [HttpPost]
    public User Post([FromBody] User value)
    {
        _context.User.Add(new User { id = value.id, name = value.name,Email=value.Email,PhoneNamber=value.PhoneNamber });
        return value;
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] User value)
    {
        var index = _context.User.FindIndex(e => e.id == id);
        if (index >= 0)
        {
            _context.User[index].Email = value.Email;
            _context.User[index].name = value.name;
            _context.User[index].PhoneNamber = value.PhoneNamber;
            return Ok(_context.User[index]);
        }
        return NotFound();
    }
}
