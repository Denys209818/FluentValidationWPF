using EFDataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFDataContext.Services
{
    public static class Seeder
    {
        public static void SeedAll(DataContext context) 
        {
            SeedCat(context);
            SeedCatPrice(context);
        }

        private static void SeedCat(DataContext context) 
        {
            if (!context.Cats.Any()) 
            {
                context.Cats.Add(new EFDataEntities.Cat { 
                    Name = "Манул",
                    Details = "Кіт Манул",
                    Birthday = new DateTime(2020, 3, 12),
                    Gender = true,
                    imgPath = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Manoel.jpg/275px-Manoel.jpg", 
                });

                context.SaveChanges();
            }
        }

        private static void SeedCatPrice(DataContext context) 
        {
            if (!context.CatPrices.Any()) 
            {
                Cat cat = context.Cats.FirstOrDefault();
                context.CatPrices.Add(new EFDataEntities.CatPrice { 
                DateCreate = DateTime.Now,
                Price = 200,
                CatId = cat.Id
                });

                context.SaveChanges();
            }
        }
    }
}
