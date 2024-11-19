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
        private readonly DataContext context = new DataContext();


        public List<Web> GetAll()
        {    //פונק'
            return context.Web;
        }
    }
}
