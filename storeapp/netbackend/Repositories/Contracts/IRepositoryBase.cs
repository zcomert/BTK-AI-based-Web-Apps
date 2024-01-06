using System.Linq.Expressions;

namespace Repositories.Contracts;

public interface IRepositoryBase<T>
{
    IQueryable<T> GetAll();
    T? GetOne(Expression<Func<T, bool>> filter);
    T? CreateOne(T entity);
    T? UpdateOne(T entity);
    void DeleteOne(T entity);
}