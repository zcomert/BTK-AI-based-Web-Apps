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
    private readonly ICommentRepository _commentRepository;

    // Dependency Injection
    public ProductsController(IProductRepository productRepository,
        ICommentRepository commentRepository) // resolve
    {
        _productRepository = productRepository;
        _commentRepository = commentRepository;
    }

    [HttpGet("{id}/comments")]
    public IActionResult GetComments([FromRoute(Name = "id")] int id)
    {
        // var model = _productRepository
        // .GetAllProductsWithDetails()
        // .Where(p => p.Id.Equals(id))
        // .SingleOrDefault()
        // .Comments;

        var model = _commentRepository
        .GetAllCommentsByProductId(id);

        return Ok(model);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var models = _productRepository
            .GetAllProductsWithDetails();
        return Ok(models);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProduct(int id)
    {
        var model = _productRepository
            .GetOne(p => p.Id.Equals(id));
        return Ok(model);
    }

    [HttpPost]
    public IActionResult CreateOneProduct([FromBody] Product product)
    {
        if (product is null)
            return BadRequest(); // 400

        _productRepository
            .CreateOne(product);


        return Created($"api/products/{product.Id}", product); // 201


    }

    [HttpPut("{id}")] // ./api/products/id
    public IActionResult UpdateOneProduct([FromRoute(Name = "id")] int id,
    [FromBody] Product product)
    {
        var entity = _productRepository
            .GetOne(p => p.Id.Equals(id));

        if (entity is null)
            return BadRequest(); // 400

        if (!id.Equals(product.Id))
            throw new Exception("Parameters are not matched.");

        entity.Name = product.Name;
        entity.Price = product.Price;

        var model = _productRepository
          .UpdateOne(entity);

        return Ok(model); // 200
    }

    [HttpDelete("{id}")] // ./api/products/:id
    public IActionResult DeleteOneProduct([FromRoute(Name = "id")] int id)
    {
        var product = _productRepository
            .GetOne(p => p.Id.Equals(id));

        if (product is null)
            throw new Exception("Product not found!");
        else
        {
            _productRepository.DeleteOne(product);
            return NoContent(); // 204
        }
    }
}