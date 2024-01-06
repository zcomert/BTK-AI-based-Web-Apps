using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public sealed class CommentRepository : RepositoryBase<Comment>, ICommentRepository
{
    public CommentRepository(RepositoryContext context)
        : base(context)
    {

    }

    public IQueryable<Comment>? GetAllCommentsByProductId(int productId)
    {
        return _context
            .Comments
            .Where(c => c.ProductId.Equals(productId));
    }
}