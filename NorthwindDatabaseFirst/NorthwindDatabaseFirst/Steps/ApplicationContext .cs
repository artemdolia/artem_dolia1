using Microsoft.EntityFrameworkCore;
using NorthwindDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabaseFirst
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Brand> Brands { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=a-dolia\MSSQLSERVER3;Database=MyTestDb;Trusted_Connection=True;");
        }
    }
}
