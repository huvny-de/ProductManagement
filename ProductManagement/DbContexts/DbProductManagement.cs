using Microsoft.EntityFrameworkCore;
using ProductManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.DbContexts
{
    public class DbProductManagement : DbContext
    {

        public DbProductManagement(DbContextOptions<DbProductManagement> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        // Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
              new Category() { CategoryId = 1, Name = "Drink" },
              new Category() { CategoryId = 2, Name = "Snack" },
              new Category() { CategoryId = 3, Name = "Candy" }
              );

            modelBuilder.Entity<Product>().HasData(
                  new Product() { ProductId = 1, Name = "Coconut", Price = 25000, Amount = 10, CategoryId = 1 },
                  new Product() { ProductId = 2, Name = "Tonnie", Price = 6000, Amount = 20, CategoryId = 2 },
                  new Product() { ProductId = 3, Name = "Chuppa", Price = 2000, Amount = 30, CategoryId = 3 }
                  );
        }
    }
}
