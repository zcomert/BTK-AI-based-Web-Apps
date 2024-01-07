using Microsoft.EntityFrameworkCore;
using Repositories;
using Services.Contracts;

namespace Services;

public class ServiceManager : IServiceManager
{
    private readonly IProductService _productService;
    private readonly ICommentService _commentService;

    public ServiceManager(IProductService productService, ICommentService commentService)
    {
        _productService = productService;
        _commentService = commentService;
    }

    public IProductService ProductService =>
        _productService;

    public ICommentService CommentService =>
        _commentService;
}