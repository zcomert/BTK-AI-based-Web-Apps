using System.Linq.Expressions;
using Entities.Models;

namespace Repositories.Contracts;

public interface IProductRepository : IRepositoryBase<Product>
{
    IQueryable<Product> GetAllProductsWithDetails();
    Product? GetOneProductWithDetails(int id);
}