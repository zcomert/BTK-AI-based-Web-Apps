using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services;

public class CommentManager : ICommentService
{
    private readonly IRepositoryManager _manager;

    public CommentManager(IRepositoryManager manager)
    {
        _manager = manager;
    }

    public IEnumerable<Comment>? GetAllCommentsByProductId(int productId)
    {
        return _manager
            .CommentRepository
            .GetAllCommentsByProductId(productId);
    }
}