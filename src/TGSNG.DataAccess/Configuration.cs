using Microsoft.Extensions.DependencyInjection;
using TGSNG.DataAccess.Abstractions;

namespace TGSNG.DataAccess
{
    public static class Configuration
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseRepository<>));
        }
    }
}
