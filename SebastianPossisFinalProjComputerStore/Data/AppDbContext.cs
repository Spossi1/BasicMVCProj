// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ComputerPartsStore.Models;

namespace ComputerPartsStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<ComputerPart> ComputerParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for ComputerParts table
            modelBuilder.Entity<ComputerPart>().HasData(
                new ComputerPart { Id = 4, Name = "Graphics Card", Description = "High-performance GPU", Price = 399.99m, Stock = 10 },
                new ComputerPart { Id = 5, Name = "Processor", Description = "Quad-core CPU", Price = 299.99m, Stock = 15 },
                new ComputerPart { Id = 6, Name = "RAM", Description = "16GB DDR4", Price = 79.99m, Stock = 25 },
                new ComputerPart { Id = 7, Name = "SSD", Description = "512GB NVMe SSD", Price = 119.99m, Stock = 20 },
                new ComputerPart { Id = 8, Name = "Motherboard", Description = "ATX Motherboard", Price = 149.99m, Stock = 12 }
            );
        }
    }
}