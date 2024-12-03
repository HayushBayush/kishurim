using Microsoft.EntityFrameworkCore;
using Project.Core.Repositories;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public DbSet<User> GetAll()
        {    //פונק'
            return _context.Users;
        }

        void IUserRepository.Add(User user)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
