using System.Linq.Expressions;
using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class FakeProductRepository : IProductRepository
{
    private List<Product> _products;
    public FakeProductRepository()
    {
        _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1500 },
                new Product { Id = 2, Name = "Smartphone", Price = 800 },
                new Product { Id = 3, Name = "Headphones", Price = 100 },
                new Product { Id = 4, Name = "Tablet", Price = 600 },
                new Product { Id = 5, Name = "Smartwatch", Price = 300 }
            };
    }

    public Product CreateOneProduct(Product product)
    {
        _products.Add(product);
        return product;
    }

    public IQueryable<Product> GetAllProducts()
    {
        return _products.AsQueryable();
    }

    public Product? GetOneProduct(Expression<Func<Product, bool>> filter)
    {
        return _products
            .AsQueryable()
            .SingleOrDefault(filter);
    }
}
