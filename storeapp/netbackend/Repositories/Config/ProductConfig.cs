using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name).IsRequired();

        builder
          .Property(p => p.ImageURL)
          .HasDefaultValue("/images/default.jpg");


        builder
            .HasData(
                    new Product { Id = 1, ImageURL = "/images/1.jpg", Name = "Laptop", Price = 1500 },
                    new Product { Id = 2, ImageURL = "/images/2.jpg", Name = "Smartphone", Price = 800 },
                    new Product { Id = 3, ImageURL = "/images/3.jpg", Name = "Headphones", Price = 100 },
                    new Product { Id = 4, ImageURL = "/images/4.jpg", Name = "Tablet", Price = 600 },
                    new Product { Id = 5, ImageURL = "/images/5.jpg", Name = "Smartwatch", Price = 300 }
            );
    }
}