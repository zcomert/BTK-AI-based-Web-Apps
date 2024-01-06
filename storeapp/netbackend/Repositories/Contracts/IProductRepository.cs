using System.Linq.Expressions;
using Entities.Models;

namespace Repositories.Contracts;

public interface IProductRepository
{
    IQueryable<Product> GetAllProducts();
    IQueryable<Product> GetAllProductsWithDetails();
    Product? GetOneProduct(Expression<Func<Product,bool>> filter);
    Product CreateOneProduct(Product product);
    Product UpdateOneProduct(Product product);
    void DeleteOneProduct(Product product);
}