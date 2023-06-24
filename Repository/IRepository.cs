using System.Linq.Expressions;

namespace ApiCatologo.Repository;

public interface IRepository<T>
{
    IQueryable<T> Get();
    T GetById(Expression<Func<T, bool>> Predicate);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
