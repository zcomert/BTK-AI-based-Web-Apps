using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private readonly IServiceManager _manager;

    public ProductsController(IServiceManager manager)
    {
        _manager = manager;
    }

    [HttpGet("{id}/comments")]
    public IActionResult GetComments([FromRoute(Name = "id")] int id)
    {
        var model = _manager
            .CommentService
            .GetAllCommentsByProductId(id);

        return Ok(model);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var models = _manager
            .ProductService
            .GetAllProductsWithDetails();

        return Ok(models);
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProduct(int id)
    {
        var model = _manager
            .ProductService
            .GetOneProductByProductId(id);

        return Ok(model);
    }

    [HttpPost]
    public IActionResult CreateOneProduct([FromBody] Product product)
    {
        _manager
            .ProductService
            .CreateOneProduct(product);

        return Created($"api/products/{product.Id}", product); // 201
    }

    [HttpPut("{id}")] // ./api/products/id
    public IActionResult UpdateOneProduct([FromRoute(Name = "id")] int id,
    [FromBody] Product product)
    {
        var model = _manager
            .ProductService
            .UpdateOneProduct(id, product);

        return Ok(model); // 200
    }

    [HttpDelete("{id}")] // ./api/products/:id
    public IActionResult DeleteOneProduct([FromRoute(Name = "id")] int id)
    {
        _manager
            .ProductService
            .DeleteOneProduct(id);

        return NoContent(); // 204
    }

    [HttpPost("{id}/comments")]
    public IActionResult AddOneCommentByProductId([FromRoute(Name = "id")] int id,
        [FromBody] Comment comment)
    {
        var comments = _manager
            .ProductService
            .AddOneCommentByProductId(id, comment.Text);

        return Created($"api/products/{id}/comments", comments!);
    }
}