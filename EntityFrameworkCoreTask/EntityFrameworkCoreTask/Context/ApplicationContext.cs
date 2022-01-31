using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLOCALDB;Database=MyTestDb;Trusted_Connection=True;");
        }
    }
}
