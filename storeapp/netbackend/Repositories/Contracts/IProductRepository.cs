using Entities.Models;

namespace Repositories.Contracts;

public interface IProductRepository
{
    IQueryable<Product> GetAllProducts();
}