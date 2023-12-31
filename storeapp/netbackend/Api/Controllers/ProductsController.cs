using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public String Greetings()
    {
        return "Merhaba ASP.NET Core Web API.";
    }

    [HttpGet("{name}")]
    public String Greetings(string name)
    {
        return $"Merhaba {name}.";
    }
}