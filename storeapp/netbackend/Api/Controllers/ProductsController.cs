using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Greetings()
    {
        return Ok("Merhaba ASP.NET Core Web API.");
    }

    [HttpGet("{id}")]
    public IActionResult GetOneProduct(int id)
    {
        var product = new Product();
        
        product.Id = 1;
        product.Name = "HP Computer";
        product.Price = 30_000;
        return Ok(product);
    }
}