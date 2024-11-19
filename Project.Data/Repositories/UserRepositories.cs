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
        private readonly DataContext context = new DataContext();


        public List<User> GetAll()
        {    //פונק'
            return context.User;
        }
    }
}
