using System.Linq.Expressions;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories;

public sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(RepositoryContext context) : base(context)
    {
        
    }

    public IQueryable<Product> GetAllProductsWithDetails()
    {
        return _context
            .Products
            .Include(p => p.Comments);
    }

    public Product? GetOneProductWithDetails(int id)
    {
        return _context
            .Products
            .Include(p => p.Comments)
            .SingleOrDefault(p => p.Id.Equals(id));
    }
}