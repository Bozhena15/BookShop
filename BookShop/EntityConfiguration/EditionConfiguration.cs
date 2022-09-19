using Microsoft.EntityFrameworkCore;
using BookShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.EntityConfiguration
{ 
   
    public class EditionConfiguration : IEntityTypeConfiguration<Edition>
{
           public void Configure(EntityTypeBuilder<Edition> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.EditionName).IsRequired();
            builder.Property(x => x.CountryOrigin);
            builder.Property(x => x.Years);
        }
    }
}
