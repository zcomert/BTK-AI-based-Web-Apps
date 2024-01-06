using System.Linq.Expressions;
using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public class ProductRepository : IProductRepository
{

    private readonly RepositoryContext _context;

    public ProductRepository(RepositoryContext context)
    {
        _context = context;
    }

    public Product CreateOneProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
        return product;
    }

    public void DeleteOneProduct(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public IQueryable<Product> GetAllProducts()
    {
        return _context.Products;
    }

    public Product? GetOneProduct(Expression<Func<Product, bool>> filter)
    {
        return _context.Products.SingleOrDefault(filter);
    }

    public Product UpdateOneProduct(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();
        return product;
    }
}