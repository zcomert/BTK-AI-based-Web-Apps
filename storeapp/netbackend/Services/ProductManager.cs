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
        if(product is null)
            throw new ArgumentNullException("product");
        
        _manager.ProductRepository.CreateOne(product);
        _manager.Save();
        return product;
    }

    public void DeleteOneProduct(int id)
    {
        var entity = GetOneProduct(id);
        _manager.ProductRepository.DeleteOne(entity!);
        _manager.Save();
    }

    public IEnumerable<Product> GetAllProductsWithDetails()
    {
        throw new NotImplementedException();
    }

    public Product? GetOneProduct(int id)
    {
        var entity = _manager
            .ProductRepository
            .GetOne(p => p.Id.Equals(id));

        if (entity is null)
            throw new Exception($"Product with id {id} not found.");

        return entity;
    }

    public Product? UpdateOneProduct(int id, Product product)
    {
        throw new NotImplementedException();
    }
}