using Project.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categories = new List<Category>(); // רשימה שמחזיקה את הקטגוריות

        public List<Category> GetAll()
        {
            return _categories; // מחזיר את כל הקטגוריות
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id); // מחזיר קטגוריה לפי מזהה
        }

        public void Add(Category category)
        {
            if (!_categories.Any(c => c.Id == category.Id))
            {
                _categories.Add(category); // מוסיף קטגוריה חדשה אם המזהה לא קיים
            }
        }

        public void Update(Category category)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory != null)
            {
                existingCategory.Name = category.Name; // מעדכן שם קטגוריה
            }
        }

        public void Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _categories.Remove(category); // מוחק קטגוריה מהרשימה
            }
        }
    }
}
