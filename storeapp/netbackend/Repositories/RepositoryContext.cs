using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Product>()
            .HasData(
                 new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Smartphone", Price = 800 },
                new Product { Id = 3, Name = "Headphones", Price = 100 },
                new Product { Id = 4, Name = "Tablet", Price = 600 },
                new Product { Id = 5, Name = "Smartwatch", Price = 300 }
            );
    }
}