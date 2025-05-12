using Microsoft.EntityFrameworkCore;
using MingoButik.Models;

namespace MingoButik.Contexts
{
    public class AppDbContext:DbContext
    {
    
        private readonly string _connectionString = @"Server=DESKTOP-KA8SSD4;Database=MingoAppDb;Trusted_Connection=True;TrustServerCertificate=True;";
        DbSet<Products> products {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
