using Mobioko.Data.Models;

namespace Mobioko.Repositories.Contracts;

public interface IRepository<T, TKey> where T : BaseEntity<TKey>
{
    Task<bool> EntityExists(TKey id);
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(TKey id);
    Task<T> AddAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(TKey id);
}