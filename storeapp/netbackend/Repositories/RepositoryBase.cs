using System.Linq.Expressions;
using Repositories.Contracts;

namespace Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T>
    where T : class // constraints
{
    protected readonly RepositoryContext _context;

    public RepositoryBase(RepositoryContext context)
    {
        _context = context;
    }

    public T? CreateOne(T entity)
    {
        _context.Set<T>().Add(entity);
        // _context.SaveChanges();
        return entity;
    }

    public void DeleteOne(T entity)
    {
        _context.Set<T>().Remove(entity);
        // _context.SaveChanges();
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public T? GetOne(Expression<Func<T, bool>> filter)
    {
        return _context
        .Set<T>()
        .SingleOrDefault(filter);
    }

    public T? UpdateOne(T entity)
    {
        _context.Set<T>().Update(entity);
        // _context.SaveChanges();
        return entity;
    }
}