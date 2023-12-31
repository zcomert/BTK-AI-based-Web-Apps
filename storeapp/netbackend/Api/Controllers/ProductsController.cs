using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private IProductRepository _productRepository;
    public ProductsController()
    {
        _productRepository = new InMemoryProductRepository();
    }
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var models = _productRepository.GetAllProducts();
        return Ok(models);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProduct(int id)
    {
        var product = new Product();

        product.Id = 1;
        product.Name = "HP Computer";
        product.Price = 30_000;

        var prd = new Product()
        {
            Id = 1,
            Name = "Asus Laptop",
            Price = 45_000
        };

        return Ok(prd);
    }
}