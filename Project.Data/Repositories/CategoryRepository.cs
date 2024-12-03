using Project.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, name = "Technology" },
                new Category { Id = 2, name = "Science" }
            };
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Update(Category category)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                existingCategory.name = category.name;
            }
        }

        public void Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }

        public Category GetById()
        {
            throw new NotImplementedException();
        }
    }
}
