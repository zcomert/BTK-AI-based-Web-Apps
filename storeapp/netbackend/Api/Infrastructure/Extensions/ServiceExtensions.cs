using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

namespace Api.Infrastructure.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositories(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();

        services.AddDbContext<RepositoryContext>(options =>
        {
            options.UseSqlite(configuration.GetConnectionString("sqliteconnection"),
            b => b.MigrationsAssembly("Api"));
        }); // register
    }
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<ICommentService, CommentManager>();
    }

    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("Default", builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
        });
    }
}
