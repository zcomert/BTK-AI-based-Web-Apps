using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    // Dependency Injection
    public ProductsController(IProductRepository productRepository) // resolve
    {
        _productRepository = productRepository;
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
        var model = _productRepository
            .GetOneProduct(p => p.Id.Equals(id));
        return Ok(model);
    }

    [HttpPost]
    public IActionResult CreateOneProduct([FromBody] Product product)
    {
        _productRepository
            .CreateOneProduct(product);
        return Created($"api/products/{product.Id}", product); // 201
    }

    [HttpPut("{id}")] // ./api/products/id
    public IActionResult UpdateOneProduct([FromRoute(Name = "id")] int id,
    [FromBody] Product product)
    {
        var model = _productRepository
          .UpdateOneProduct(product);
        return Ok(model); // 200
    }

    [HttpDelete("{id}")] // ./api/products/
    public IActionResult DeleteOneProduct([FromRoute(Name = "id")] int id)
    {
        var product = _productRepository
            .GetOneProduct(p => p.Id.Equals(id));
        
        if (product is null)
            throw new Exception("Product not found!");
        else
        {
            _productRepository.DeleteOneProduct(product);
            return NoContent(); // 204
        }
    }
}