using Microsoft.EntityFrameworkCore;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class WebRepositories
    {
        

        private readonly DataContext _context;

        public WebRepositories(DataContext context)
        {
            _context = context;
        }
        public DbSet<Web> GetAll()
        {    //פונק'
            return _context.Webs;
        }
    }
}
