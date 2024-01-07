using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services;

public class ProductManager : IProductService
{
    private readonly IRepositoryManager _manager;

    public ProductManager(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public Product? CreateOneProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteOneProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProductsWithDetails()
    {
        throw new NotImplementedException();
    }

    public Product? GetOneProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Product? UpdateOneProduct(int id, Product product)
    {
        throw new NotImplementedException();
    }
}