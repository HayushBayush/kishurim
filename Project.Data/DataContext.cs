using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Project.Entities;

namespace Project.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
      
        public DbSet<Web> Webs { get; set; }
        public DbSet<Category> Categories { get;  set; }
        public DbSet<Recommend> recommends { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}
