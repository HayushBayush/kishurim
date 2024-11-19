using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendsController : ControllerBase
    {
        private readonly DataContext _context;

        public RecommendsController(DataContext context)
        {
            _context = context;
        }

        //// אתחול של הרשימה עם ערכים ריקים
        //private static List<string> _Recommend = new List<string>();

        // GET: api/<RecommendController>
        [HttpGet]
        public IEnumerable<Recommend> Get()
        {
            // כאן אפשר להחזיר את כל ההמלצות שנמצאות ברשימה
            return _context.Recommend;
        }

        //GET api/<RecommendController>/5
        //[HttpGet("{id}")]
        public ActionResult <Recommend> Getid(int id)
        {
            // כאן אפשר להחזיר המלצה לפי מזהה
            if (id >= 0 && id < _context.Recommend.Count())
            {
                return _context.Recommend[id];
            }
            if (User != null)
            {
                return Ok(User);
            }
            return NotFound();
        }// במקרה שהמזהה לא קיים ברשימה
        

        // POST api/<RecommendController>
        [HttpPost]
        public Recommend Post([FromBody] Recommend value)
        {
            _context.Recommend.Add(new Recommend { Id = value.Id, Description = value.Description, Name = value.Name });
            return value;
        }

        //// PUT api/<RecommendController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //    // עדכון המלצה לפי מזהה
        //    if (id >= 0 && id < _Recommend.Count)
        //    {
        //        _Recommend[id] = value;
        //    }
        //}

        // DELETE api/<RecommendController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // מחיקת המלצה לפי מזהה
            if (id >= 0 && id < _context.Recommend.Count()) 
            {
                _context.Recommend.RemoveAt(id);
            }
        }
    }
}
