using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private Product[] _products = new Product[]{
        new Product { Id = 1, Name = "Laptop", Price = 1500 },
        new Product { Id = 2, Name = "Smartphone", Price = 800 },
        new Product { Id = 3, Name = "Headphones", Price = 100 },
    };
    public IQueryable<Product> GetAllProducts()
    {
        return _products.AsQueryable();
    }
}