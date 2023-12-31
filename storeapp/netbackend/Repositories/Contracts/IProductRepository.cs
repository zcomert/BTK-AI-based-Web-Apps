using System.Linq.Expressions;
using Entities.Models;

namespace Repositories.Contracts;

public interface IProductRepository
{
    IQueryable<Product> GetAllProducts();
    Product? GetOneProduct(Expression<Func<Product,bool>> filter);
    Product CreateOneProduct(Product product);
}