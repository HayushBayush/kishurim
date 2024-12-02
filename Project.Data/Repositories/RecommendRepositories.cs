using Microsoft.EntityFrameworkCore;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class RecommendRepositories
    {
        private readonly DataContext _context;

        public RecommendRepositories(DataContext context)
        {
            _context = context;
        }
        public DbSet<Recommend> GetAll()
        {    //פונק'
            return _context.recommends;
        }
    }
}
