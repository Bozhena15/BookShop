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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new EditionConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
        }
    }
}
