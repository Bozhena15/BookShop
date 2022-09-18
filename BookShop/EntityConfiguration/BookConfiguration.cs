using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.EntityConfiguration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.BookName).IsRequired();
            builder.Property(x => x.GraduationYears);
            builder.Property(x => x.BookPrice).IsRequired();
            builder.Property(x => x.BookCost).IsRequired();
            builder.Property(x => x.BookCount).IsRequired();
            builder.Property(x => x.AutorId).IsRequired();
            builder.Property(x => x.GenreId).IsRequired();
            builder.Property(x => x.EditionId).IsRequired();
        }
    }
}
