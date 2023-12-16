using Microsoft.EntityFrameworkCore;
using Mobioko.Data;
using Mobioko.Data.Models;
using Mobioko.Repositories.Contracts;

namespace Mobioko.Repositories;

public class ProductRepository(ApplicationDbContext context) : BaseRepository<Product, int>(context), IProductRepository, IDisposable
{
    public void Dispose() => _context.Dispose();

    public async Task<List<Product>> GetAllByCategoryIdAsync(int categoryId)
        => await _context.Products.Where(p => p.CategoryId == categoryId && p.IsDeleted == false).ToListAsync();

    public async Task<int> GetCountByCategoryIdAsync(int categoryId)
        => await _context.Products.CountAsync(p => p.CategoryId == categoryId && p.IsDeleted == false);
}