using Mobioko.Data.Models;
using Mobioko.Data;
using Mobioko.Repositories.Contracts;

namespace Mobioko.Repositories;

public class ManufacturerRepository(ApplicationDbContext context) : BaseRepository<Manufacturer, int>(context), IManufacturerRepository, IDisposable
{
    public void Dispose() => _context.Dispose();
}