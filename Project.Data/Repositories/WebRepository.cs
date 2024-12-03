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
    public class WebRepository : IWebRepository
    {
        

        private readonly DataContext _context;

        public WebRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Web web)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DbSet<Web> GetAll()
        {    //פונק'
            return _context.Webs;
        }

        public Web GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Web web)
        {
            throw new NotImplementedException();
        }

        List<Web> IWebRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
