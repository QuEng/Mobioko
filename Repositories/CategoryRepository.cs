using Mobioko.Data;
using Mobioko.Data.Models;
using Mobioko.Repositories.Contracts;

namespace Mobioko.Repositories;

public class CategoryRepository(ApplicationDbContext context) : BaseRepository<Category, int>(context), ICategoryRepository, IDisposable
{
    public void Dispose() => _context.Dispose();
}