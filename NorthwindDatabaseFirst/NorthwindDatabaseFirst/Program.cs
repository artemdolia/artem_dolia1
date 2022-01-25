//using System;
//using System.Linq;

//namespace NorthwindDatabaseFirst
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            using (ApplicationContext context = new ApplicationContext())
//            {
//                context.Database.EnsureDeleted();
//                context.Database.EnsureCreated();
//                Brand brand = new Brand { BrandName = "Nike" };
//                context.AddRange(brand);
//                context.SaveChanges();

//                var brands = context.Brands.ToList();
//                Console.WriteLine("Данные после добавления:");
//                foreach (Brand b in brands)
//                {
//                    Console.WriteLine($"{ b.BrandId} {b.BrandName }");
//                }
//            }
//            using (ApplicationContext context = new ApplicationContext())
//            {
//                Brand brand = context.Brands.FirstOrDefault();
//                if (brand != null)
//                {
//                    context.Brands.Remove(brand);
//                    context.SaveChanges();
//                }

//                Console.WriteLine("\nДанные после удаления:");
//                var brands = context.Brands.ToList();
//                foreach (Brand b in brands)
//                {
//                    Console.WriteLine($"{b.BrandId}.{b.BrandName}");
//                }
//            }
//            Console.Read();
//        }
//    }
//}




