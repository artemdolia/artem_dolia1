using System;
using System.Linq;


namespace NorthwindDatabaseFirst.Steps
{
    public class SharedSteps
    {
        public void AddRecordInTheTable()
        {
            using (ApplicationContext context = new ApplicationContext())
            {

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Brand brand = new Brand { BrandName = "Nike" };
                context.Add(brand);
                context.SaveChanges();
            }
        }
        public void CheckThatTheRecordHasBeenAdded()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                if (context != null)
                {
                    Console.WriteLine(context.Database);
                }
            }
        }
        public void DeleteRecordFromTable()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                Brand brand = context.Brands.FirstOrDefault();
                if (brand != null)
                {
                    context.Brands.Remove(brand);
                    context.SaveChanges();
                }
            }
            Console.Read();
        }
        public void CheckThatRecordHasBeenDeleted()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var brands = context.Brands.ToList();
                foreach (Brand b in brands)
                {
                    Console.WriteLine($"{b.BrandId}, {b.BrandName}");
                }
            }
        }
    }
}


