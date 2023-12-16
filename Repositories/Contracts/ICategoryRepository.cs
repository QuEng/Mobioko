using Mobioko.Data.Models;

namespace Mobioko.Repositories.Contracts;

public interface ICategoryRepository : IRepository<Category, int>, IDisposable
{
}