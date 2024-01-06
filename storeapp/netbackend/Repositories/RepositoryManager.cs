using Repositories.Contracts;

namespace Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly IProductRepository _productRepository;
    private readonly ICommentRepository _commentRepository;


    public RepositoryManager(RepositoryContext context,
        IProductRepository productRepository,
        ICommentRepository commentRepository)
    {
        _context = context;
        _productRepository = productRepository;
        _commentRepository = commentRepository;
    }

    public IProductRepository ProductRepository =>
        _productRepository;

    public ICommentRepository CommentRepository =>
        _commentRepository;

    public void Save()
    {
        _context.SaveChanges();
    }
}