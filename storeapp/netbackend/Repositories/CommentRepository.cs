using Entities.Models;
using Repositories.Contracts;

namespace Repositories;

public sealed class CommentRepository : RepositoryBase<Comment>, ICommentRepository
{
    public CommentRepository(RepositoryContext context)
        : base(context)
    {

    }
}