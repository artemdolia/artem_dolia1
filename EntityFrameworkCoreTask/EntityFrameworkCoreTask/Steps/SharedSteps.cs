using EntityFrameworkCoreTask.Models;
using NorthwindDatabaseFirst;
using System;
using System.Linq;


namespace EntityFrameworkCoreTask.Steps
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
        public string CheckThatTheRecordHasBeenAdded()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var brands = context.Brands.ToList();
                Console.WriteLine("Данные после добавления:");
                foreach (Brand b in brands)
                {
                    return b.BrandName;
                }
                return brands.ToString();
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
        }
        public string CheckThatRecordHasBeenDeleted()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var brands = context.Brands.ToList();
                foreach (Brand b in brands)
                {
                    if (brands == null)
                    {
                        Console.WriteLine("The record has not been found");
                        return null;
                    }
                }
                    return null;
                }
            }
            public void UpdateRecord()
            {
                using (ApplicationContext context = new ApplicationContext())
                {
                    var brands = context.Brands.ToList();
                    foreach (Brand b in brands)
                    {
                        Console.WriteLine($"{b.BrandName}");
                        if (b.BrandName != null)
                        {
                            b.BrandName = "Adidas";
                        }
                        context.SaveChanges();
                    }
                }
            }
            public string CheckThatRecordHasBeenUpdated()
            {
                using (ApplicationContext context = new ApplicationContext())
                {
                    var brands = context.Brands.ToList();
                    foreach (Brand b in brands)
                    {
                        Console.WriteLine(b.BrandName);
                        return b.BrandName;
                    }
                    return brands.ToString();
                }
            }
            public void AddBrandsInTable()
            {
                using (ApplicationContext dbContext = new ApplicationContext())
                {
                    dbContext.Database.EnsureDeleted();
                    dbContext.Database.EnsureCreated();
                    Brand brand1 = new Brand { BrandName = "Adidas" };
                    Brand brand2 = new Brand { BrandName = "Puma" };
                    Brand brand3 = new Brand { BrandName = "Nike" };
                    Brand brand4 = new Brand { BrandName = "Nike" };
                    dbContext.AddRange(brand1, brand2, brand3, brand4);
                    dbContext.SaveChanges();
                }
            }
            public string GetRecordsWithBrandNameNike()
            {
                using (ApplicationContext dbContext = new ApplicationContext())
                {
                    var brands = dbContext.Brands.Where(p => p.BrandName == "Nike").ToList();
                    foreach (Brand brand in brands)
                    {
                        Console.WriteLine($"{brand.BrandName}");
                        return brand.BrandName;
                    }
                    return brands.ToString();
                }
            }
            public string GetDataFromDB()
            {
                using (NorthwindContext context = new NorthwindContext())
                {
                    context.Database.EnsureCreated();
                    var customers = context.Customers.Where(p => p.CompanyName == "Cactus Comidas para llevar").ToList();
                    foreach (Customer customer in customers)
                    {
                        return customer.CompanyName;
                    }
                    return customers.ToString();
                }
            }
        }
    }
