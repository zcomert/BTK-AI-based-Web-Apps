using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/comments")]
public class CommentsController : ControllerBase
{
    private readonly IRepositoryManager _manager;

    public CommentsController(IRepositoryManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    public IActionResult GetAllComments()
    {
        var model = _manager.CommentRepository.GetAll();
        return Ok(model);
    }

    [HttpGet("{id}")] // api/comments/:id
    public IActionResult GetOneComment([FromRoute(Name = "id")] int id)
    {
        var model = _manager.CommentRepository
                .GetOne(c => c.CommentId.Equals(id));
        return Ok(model);
    }

    [HttpGet("product/{id}")]
    public IActionResult GetAllCommentsByProductId([FromRoute(Name = "id")] int id)
    {
        var model = _manager
        .CommentRepository.GetAllCommentsByProductId(id);
        return Ok(model);
    }
}