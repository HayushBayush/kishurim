using Project.Entities;
using System.Collections.Generic;

namespace Project.Core.Services
{
    public interface IUserService
    {
        List<User> GetList();  // מקבל את כל המשתמשים
        User GetById(int id);  // מקבל משתמש לפי מזהה
        User Add(User user);  // מוסיף משתמש חדש
        User Update(int id, User user);  // מעדכן את פרטי המשתמש
        bool Delete(int id);  // מוחק משתמש
    }
}
