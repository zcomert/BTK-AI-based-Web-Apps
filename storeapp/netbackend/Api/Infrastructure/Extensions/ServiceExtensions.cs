using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

namespace Api.Infrastructure.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
    }
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ICommentService, CommentManager>();
    }
}
