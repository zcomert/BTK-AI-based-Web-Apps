using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/comments")]
public class CommentsController : ControllerBase
{
    private readonly ICommentRepository _commentRepository;

    public CommentsController(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }
    [HttpGet]
    public IActionResult GetAllComments()
    {
        var model = _commentRepository.GetAll();
        return Ok(model);
    }

    [HttpGet("{id}")] // api/comments/:id
    public IActionResult GetOneComment([FromRoute(Name = "id")] int id)
    {
        var model = _commentRepository
                .GetOne(c => c.CommentId.Equals(id));
        return Ok(model);
    }

    [HttpGet("product/{id}")]
    public IActionResult GetAllCommentsByProductId([FromRoute(Name = "id")] int id)
    {
        var model = _commentRepository.GetAllCommentsByProductId(id);
        return Ok(model);
    }
}