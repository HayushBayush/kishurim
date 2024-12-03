using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Core.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User { id = 1, name = "John Doe", Email = "john@example.com", PhoneNamber = 1234567890 },
                
            };
        }

        public List<User> GetList()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.id == id);
        }

        public User Add(User user)
        {
            _users.Add(user);
            return user;
        }

        public User Update(int id, User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.id == id);
            if (existingUser != null)
            {
                existingUser.name = user.name;
                existingUser.Email = user.Email;
                existingUser.PhoneNamber = user.PhoneNamber;
                return existingUser;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.id == id);
            if (user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
