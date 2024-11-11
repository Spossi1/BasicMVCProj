// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using ComputerPartsStore.Models;

namespace ComputerPartsStore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<ComputerPart> ComputerParts { get; set; }
    }
}