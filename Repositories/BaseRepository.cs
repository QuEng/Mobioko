using Microsoft.EntityFrameworkCore;
using Mobioko.Data;
using Mobioko.Data.Models;
using Mobioko.Repositories.Contracts;

namespace Mobioko.Repositories;

public class BaseRepository<T, TKey> : IRepository<T, TKey> where T : BaseEntity<TKey>
{
    protected readonly ApplicationDbContext _context;

    protected BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return entity;
    }
    public virtual async Task<bool> UpdateAsync(T entity)
    {
        if (await EntityExists(entity.Id) is false)
        {
            return false;
        }
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();

        return true;
    }

    public virtual async Task<bool> DeleteAsync(TKey id)
    {
        if (await EntityExists(id) is false)
        {
            return false;
        }

        _context.Set<T>().Remove((await GetByIdAsync(id))!);

        return true;
    }

    public async Task<bool> EntityExists(TKey id)
        => await _context.Set<T>().FindAsync(id) is not null;

    public virtual async Task<List<T>> GetAllAsync()
        => await _context.Set<T>().ToListAsync();

    public async Task<T?> GetByIdAsync(TKey id)
        => await _context.Set<T>().FindAsync(id);
}