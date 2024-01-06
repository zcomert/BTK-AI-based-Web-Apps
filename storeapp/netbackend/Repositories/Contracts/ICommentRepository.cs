using Entities.Models;

namespace Repositories.Contracts;

public interface ICommentRepository : IRepositoryBase<Comment>
{
    IQueryable<Comment>? GetAllCommentsByProductId(int productId);
}