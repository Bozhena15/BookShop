using Microsoft.EntityFrameworkCore;


namespace BookShop
{
    internal class BookShopContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer();

        }
        protected override void OnModelCreating() { }
    }
}
