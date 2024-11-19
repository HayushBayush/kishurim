using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Project.Entities;

namespace Project
{
    public class DataContext
    {
        public List<User> User { get; set; }
        public List<Category> Category { get; set; }
        public List<Web> Web { get; set; }
        public List<Recommend> Recommend { get; set; }

        public DataContext()
        {
            User = new List<User>
            {
                new User { id = 1, name = "noa"  , Email = "n0583257552", PhoneNamber = 0583257552},
                new User{ id = 2, name = "riki", Email = "riki107297", PhoneNamber = 0587845156 }
            };

            Category = new List<Category>
            {
                new Category{ id = 1, name = "fashion" },
                new Category { id = 2, name = "food" }

            };
            Recommend = new List<Recommend>
            {
                new Recommend  {Id= 1 , Description ="אתר מטורף עוזר לי המון ביום יום!" , Name= " shira levi"},
                new Recommend { Id = 2, Description = "עם כזה המון קישורים אני חוסכת לעצמי זמן ומספיקה כל מה שרציתי", Name = " tali moonk" }
            };
            Web = new List<Web>
            {
                new Web { id = 1, name = "Shein", link = "https://m.shein.com/il/?lang=il" },
                new Web { id = 2, name = "yellow", link = "https://www.yellow.co.il/" }
            };
        }



    }
}
