using PlatformService.Data.Interfaces;
using PlatformService.Data.Repositories;

namespace PlatformService
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlatformRepo, PlatformRepository>();
        }
    }
}
