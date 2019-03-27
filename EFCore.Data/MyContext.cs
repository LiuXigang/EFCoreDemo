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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreDemo;Trusted_Connection=True;");
        }
    }
}
