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
        _productRepository = new FakeProductRepository();
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
}