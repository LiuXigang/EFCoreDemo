using EFCore.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Province> Province { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=EFCoreDemo;Trusted_Connection=True;");
        }
    }
}
