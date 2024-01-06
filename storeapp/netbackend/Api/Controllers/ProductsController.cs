using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IRepositoryManager _manager;

    public ProductsController(IRepositoryManager manager)
    {
        _manager = manager;
    }

    [HttpGet("{id}/comments")]
    public IActionResult GetComments([FromRoute(Name = "id")] int id)
    {
        // var model = _productRepository
        // .GetAllProductsWithDetails()
        // .Where(p => p.Id.Equals(id))
        // .SingleOrDefault()
        // .Comments;

        var model = _manager
        .CommentRepository
        .GetAllCommentsByProductId(id);

        return Ok(model);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var models = _manager
            .ProductRepository
            .GetAllProductsWithDetails();

        return Ok(models);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProduct(int id)
    {
        var model = _manager
            .ProductRepository
            .GetOne(p => p.Id.Equals(id));
        return Ok(model);
    }

    [HttpPost]
    public IActionResult CreateOneProduct([FromBody] Product product)
    {
        if (product is null)
            return BadRequest(); // 400

        _manager
            .ProductRepository
            .CreateOne(product);


        return Created($"api/products/{product.Id}", product); // 201


    }

    [HttpPut("{id}")] // ./api/products/id
    public IActionResult UpdateOneProduct([FromRoute(Name = "id")] int id,
    [FromBody] Product product)
    {
        var entity = _manager
            .ProductRepository
            .GetOne(p => p.Id.Equals(id));

        if (entity is null)
            return BadRequest(); // 400

        if (!id.Equals(product.Id))
            throw new Exception("Parameters are not matched.");

        entity.Name = product.Name;
        entity.Price = product.Price;

        var model = _manager
            .ProductRepository
            .UpdateOne(entity);

        return Ok(model); // 200
    }

    [HttpDelete("{id}")] // ./api/products/:id
    public IActionResult DeleteOneProduct([FromRoute(Name = "id")] int id)
    {
        var product = _manager
            .ProductRepository
            .GetOne(p => p.Id.Equals(id));

        if (product is null)
            throw new Exception("Product not found!");
        else
        {
            _manager
                .ProductRepository
                .DeleteOne(product);

            return NoContent(); // 204
        }
    }
}