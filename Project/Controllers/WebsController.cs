using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsController : ControllerBase
    {
        private readonly DataContext _context;

        public WebsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Web> Get()
        {
            return _context.Web;
        }

        // GET api/<WebController>/5
        [HttpGet("{id}")]
        public ActionResult<Web> GetByid(int id)
        {
            var Web = _context.Web.Find(x => x.id == id);
            if (Web != null)
            {
                return Ok(Web);
            }
            return NotFound();
        }

        // POST 
        [HttpPost]
        public Web Post([FromBody] Web value)
        {
            _context.Web.Add(new Web { id = value.id, name = value.name, link = value.link });
            return value;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Web value)
        {
            var index = _context.Web.FindIndex(e => e.id == id);
            if (index >= 0)
            {
                _context.Web[index].name = value.name;
                _context.Web[index].link = value.link;
                return Ok(_context.Web[index]);
            }
            return NotFound();
        }
    }
}
