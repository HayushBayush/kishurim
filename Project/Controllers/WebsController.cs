using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Core.Services;
using Project.Core.services;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebController : ControllerBase
    {
        private readonly IWebService _webService;

        public WebController(IWebService webService)
        {
            _webService = webService;
        }

        // GET: api/Web
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_webService.GetList());
        }

        // GET api/Web/5
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var web = _webService.GetById(id);
            if (web != null)
            {
                return Ok(web);
            }
            return NotFound();
        }

        // POST api/Web
        [HttpPost]
        public ActionResult Post([FromBody] Web web)
        {
            if (web == null)
            {
                return BadRequest();
            }

            var createdWeb = _webService.Add(web);
            return CreatedAtAction(nameof(GetById), new { id = createdWeb.id }, createdWeb);
        }

        // PUT api/Web/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Web value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            var updatedWeb = _webService.Update(id, value);
            if (updatedWeb != null)
            {
                return Ok(updatedWeb);
            }
            return NotFound();
        }

        // DELETE api/Web/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _webService.Delete(id);
            if (success)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
