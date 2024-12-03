using Project.Core.Repositories;
using Project.Entities;

namespace Project.Service
{
    public class CategoryService
    {
        private readonly ICategoryRepository _CategoryRepositories;

        public CategoryService(ICategoryRepository categoryRepositories)
        {
            _CategoryRepositories = categoryRepositories;
        }
        public List<Category> GetList()
        {
            return _CategoryRepositories.GetAll();
        }

        public Category GetById(int id) {
            return _CategoryRepositories.GetById();
        }
        
    }
}


