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
    public class RecommendRepository: IRecommendRepository
    {
        private readonly DataContext _context;

        public RecommendRepository(DataContext context)
        {
            _context = context;
        }
        public DbSet<Recommend> GetAll()
        {    //פונק'
            return _context.recommends;
        }

        void IRecommendRepository.Add(User user)
        {
            throw new NotImplementedException();
        }

        void IRecommendRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IRecommendRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        User IRecommendRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRecommendRepository.Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
