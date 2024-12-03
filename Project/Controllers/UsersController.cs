using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Core.Services;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_userService.GetList());
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        // POST api/Users
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var createdUser = _userService.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = createdUser.id }, createdUser);
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            var updatedUser = _userService.Update(id, value);
            if (updatedUser != null)
            {
                return Ok(updatedUser);
            }
            return NotFound();
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _userService.Delete(id);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
