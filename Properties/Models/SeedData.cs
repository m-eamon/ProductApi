using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ProductApi.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProductContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProductContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Title = "When Harry Met Sally",                        
                        Category = "Romantic Comedy",
                        Description = "",
                        Price = 7.99M,
                        Retailer="HMV"
                    },

                    new Product
                    {
                        Title = "Ghostbusters ",
                        Category = "Comedy",
                        Description="",
                        Price = 8.99M,
                        Retailer="Tower Records"
                    },

                    new Product
                    {
                        Title = "Ghostbusters 2",
                        Category = "Comedy",
                        Description="",
                        Price = 9.99M,
                        Retailer="Tower Records"
                    },

                    new Product
                    {
                        Title = "Rio Bravo",
                        Category = "Western",
                        Price = 3.99M,
                        Description="",
                        Retailer="Tower Records"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}