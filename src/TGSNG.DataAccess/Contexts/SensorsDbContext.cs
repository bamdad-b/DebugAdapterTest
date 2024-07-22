using Microsoft.EntityFrameworkCore;

namespace TGSNG.DataAccess.Contexts
{
    public class SensorsDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
