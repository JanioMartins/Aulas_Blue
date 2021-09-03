using BlueFashionRetailer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BFRContext(
                serviceProvider.GetRequiredService<DbContextOptions<BFRContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }

                //context.Product.Add(new Product { Name = "Camisa Polo", Price = 250, Description = "Lacoste Braba", createBy = "System" });
                //context.Product.Add(new Product { Name = "Bone", Price = 200, Description = "Oakley", createBy = "System" });
                //context.Product.Add(new Product { Name = "Chinelo", Price = 100, Description = "Adidas", createBy = "System" });
                //context.Product.Add(new Product { Name = "Camisa Social ML", Price = 200, Description = "Tommy Hilfiger", createBy = "System" });
                //context.Product.Add(new Product { Name = "Camisa MM", Price = 150, Description = "Camisa do Slayer", createBy = "System" });
                //context.Product.Add(new Product { Name = "Oculos Escuros", Price = 1200, Description = "Juliet encontrado", createBy = "System" });
                //context.Product.Add(new Product { Name = "Bermuda", Price = 220, Description = "Lost chavosa", createBy = "System" });
                
                context.SaveChanges();
            }
        }
    }
}
