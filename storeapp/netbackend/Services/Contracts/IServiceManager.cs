namespace Services.Contracts;

public interface IServiceManager
{
    IProductService ProductService { get; }
    ICommentService CommentService { get; }
}