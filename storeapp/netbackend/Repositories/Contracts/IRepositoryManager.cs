namespace Repositories.Contracts;

public interface IRepositoryManager
{
    IProductRepository ProductRepository { get; }
    ICommentRepository CommentRepository { get; }
    void Save();
}