using Microsoft.AspNetCore.Mvc;
using Project.Core.services;
using Project.Entities;
using System.Collections.Generic;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendController : ControllerBase
    {
        private readonly IRecommendService _recommendService;

        public RecommendController(IRecommendService recommendService)
        {
            _recommendService = recommendService;
        }

        // GET: api/recommend
        [HttpGet]
        public ActionResult<IEnumerable<Recommend>> Get()
        {
            return Ok(_recommendService.GetList());
        }

        // GET api/recommend/5
        [HttpGet("{id}")]
        public ActionResult<Recommend> GetById(int id)
        {
            var recommend = _recommendService.GetById(id);
            if (recommend == null)
            {
                return NotFound();
            }
            return Ok(recommend);
        }

        // POST api/recommend
        [HttpPost]
        public ActionResult Post([FromBody] Recommend recommend)
        {
            _recommendService.AddRecommend(recommend);
            return CreatedAtAction(nameof(GetById), new { id = recommend.Id }, recommend);
        }

        // PUT api/recommend/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Recommend recommend)
        {
            if (id != recommend.Id)
            {
                return BadRequest();
            }

            _recommendService.UpdateRecommend(recommend);
            return NoContent();
        }

        // DELETE api/recommend/5 
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _recommendService.DeleteRecommend(id);
            return NoContent();
        }
    }
}
