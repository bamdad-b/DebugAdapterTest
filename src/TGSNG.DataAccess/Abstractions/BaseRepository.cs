using Microsoft.EntityFrameworkCore;
using TGSNG.DataAccess.Contexts;

namespace TGSNG.DataAccess.Abstractions
{
    public class BaseRepository<T>(SensorsDbContext sensorsDbContext) where T : class
    {
        public IQueryable<T> GetAll() => GetAllForEdit().AsNoTracking();
        public IQueryable<T> GetAllForEdit()
        {
            return sensorsDbContext.Set<T>().AsQueryable();
        }
    }
}
