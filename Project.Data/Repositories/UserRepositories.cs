using Microsoft.EntityFrameworkCore;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class UserRepositories
    {

        private readonly DataContext _context;

        public UserRepositories(DataContext context)
        {
            _context = context;
        }
        public DbSet<User> GetAll()
        {    //פונק'
            return _context.Users;
        }
    }
}
