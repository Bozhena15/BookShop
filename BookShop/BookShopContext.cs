﻿using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using BookShop.EntityConfiguration;
using BookShop.Models;


namespace BookShop
{
    public class BookShopContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new EditionConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new UserOrderConfiguration());
        }
    }
}
