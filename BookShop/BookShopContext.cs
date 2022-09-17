using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using BookShop.EntityConfiguration;
using BookShop.Models;


namespace BookShop
{
    public class BookShopContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
