using Entities.Models;

namespace Services.Contracts;

public interface ICommentService
{
    IEnumerable<Comment>? GetAllCommentsByProductId(int productId);
}