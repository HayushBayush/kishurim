using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class CategoryService
    {
        private readonly ICategoryRepositories _CategoryRepositories;
         
        public CategoryService(ICategoryRepositories categoryRepositories)
        {
            _CategoryRepositories = categoryRepositories;
        }   
    }
}
