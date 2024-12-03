using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Repositories
{
        public interface IRecommendRepository
        {
            List<User> GetAll();
            User GetById(int id);
            void Add(User user);
            void Update(User user);
            void Delete(int id);
        }
    

}

