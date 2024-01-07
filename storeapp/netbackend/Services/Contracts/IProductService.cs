using Entities.Models;

namespace Services.Contracts;

public interface IProductService
{
    IEnumerable<Product> GetAllProductsWithDetails();
    Product? GetOneProductByProductId(int id);
    Product? CreateOneProduct(Product product);
    Product? UpdateOneProduct(int id, Product product);
    void DeleteOneProduct(int id);
    IEnumerable<Comment> AddOneCommentByProductId(int productId, string text);
}