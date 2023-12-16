using Mobioko.Data.Models;

namespace Mobioko.Repositories.Contracts;

public interface IProductRepository : IRepository<Product, int>, IDisposable
{
    Task<int> GetCountByCategoryIdAsync(int categoryId);
    Task<List<Product>> GetAllByCategoryIdAsync(int categoryId);
}