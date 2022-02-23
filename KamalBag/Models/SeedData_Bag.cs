using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KamalBag.Data;
using System;
using System.Linq;

namespace KamalBag.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KamalBagContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KamalBagContext>>()))
            {
                // Look for any movies.
                if (context.Bag.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bag.AddRange(
                    new Bag
                    {
                        Type = "When Harry Met Sally",
                        Packingdate = DateTime.Parse("1989-2-12"),
                        Color = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Bag
                    {
                        Type = "When Harry Met Sally",
                        Packingdate = DateTime.Parse("1989-2-12"),
                        Color = "Romantic Comedy",
                        Price = 7.99M
                    },
                    

                   new Bag
                    {
                        Type = "When Harry Met Sally",
                        Packingdate = DateTime.Parse("1989-2-12"),
                        Color = "Romantic Comedy",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}