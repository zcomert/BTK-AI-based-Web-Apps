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

    public IEnumerable<Comment> AddOneCommentByProductId(int productId, string text)
    {
        var product = GetOneProductByProductId(productId);

        if (string.IsNullOrWhiteSpace(text))
            throw new ArgumentException("text");

        var comment = new Comment()
        {
            Text = text,
            ProductId = productId,
        };

        _manager.CommentRepository.CreateOne(comment);
        _manager.Save();

        return _manager
            .CommentRepository
            .GetAllCommentsByProductId(productId)!;
    }

    public Product? CreateOneProduct(Product product)
    {
        if (product is null)
            throw new ArgumentNullException("product");

        _manager.ProductRepository.CreateOne(product);
        _manager.Save();
        return product;
    }

    public void DeleteOneProduct(int id)
    {
        var entity = GetOneProductByProductId(id);
        _manager.ProductRepository.DeleteOne(entity!);
        _manager.Save();
    }

    public IEnumerable<Product> GetAllProductsWithDetails()
    {
        return _manager
            .ProductRepository
            .GetAllProductsWithDetails();
    }

    public Product? GetOneProductByProductId(int id)
    {
        var entity = _manager
            .ProductRepository
            .GetOneProductWithDetails(id);

        if (entity is null)
            throw new Exception($"Product with id {id} not found.");

        return entity;
    }

    public Product? UpdateOneProduct(int id, Product product)
    {
        var entity = GetOneProductByProductId(id);

        if (!id.Equals(product.Id))
            throw new Exception("Parameters are not matched.");

        entity!.Name = product.Name;
        entity!.Price = product.Price;
        entity!.Comments = product.Comments;

        _manager.ProductRepository.UpdateOne(entity);
        _manager.Save();

        return entity;
    }
}