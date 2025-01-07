using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.services
{
    public interface ICategoryService
    {
        public List<User> GetList();
        public User GetById(int id);
        public Category Add(Category category);
        public Category Update(int id, Category value);
        public void Deletecategory(int id);
        
        //public void Delete(int id);
        //public void GetByid(int id);
    }
}
