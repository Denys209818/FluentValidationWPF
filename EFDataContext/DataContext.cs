using EFDataEntities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFDataContext
{
    public class DataContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
        public DbSet<CatPrice> CatPrices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=denysdb;Username=denys;Password=qwerty1*");
        }
    }
}
