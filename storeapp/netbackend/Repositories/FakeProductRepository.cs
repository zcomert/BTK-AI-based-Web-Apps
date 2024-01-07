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
                new Product { Id = 1, Name = "Fincan", Price = 1500 },
                new Product { Id = 2, Name = "Bardak", Price = 800 },
                new Product { Id = 3, Name = "Tava", Price = 100 },
                new Product { Id = 4, Name = "Bıçak", Price = 600 },
                new Product { Id = 5, Name = "Tencere", Price = 300 }
            };
    }

    public Product? CreateOne(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product CreateOneProduct(Product product)
    {
        _products.Add(product);
        return product;
    }

    public void DeleteOne(Product entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteOneProduct(Product product)
    {
        _products.Remove(product);
    }

    public IQueryable<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<Product> GetAllProducts()
    {
        return _products.AsQueryable();
    }

    public IQueryable<Product> GetAllProductsWithDetails()
    {
        throw new NotImplementedException();
    }

    public Product? GetOne(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public Product? GetOneProduct(Expression<Func<Product, bool>> filter)
    {
        return _products
            .AsQueryable()
            .SingleOrDefault(filter);
    }

    public Product? GetOneProductWithDetails(int id)
    {
        throw new NotImplementedException();
    }

    public Product? UpdateOne(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product UpdateOneProduct(Product product)
    {
        var productToUpdate = _products
            .SingleOrDefault(p => p.Id == product.Id);

        if (productToUpdate != null)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
        }
        return productToUpdate!;
    }
}
