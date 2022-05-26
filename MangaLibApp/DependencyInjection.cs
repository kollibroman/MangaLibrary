using System.Reflection;
using MangaLibCore;
using Microsoft.Extensions.DependencyInjection;

namespace MangaLibApp
{
    public static class DependencyInjection
    {
        static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddDbContext<MangaLibDbContext>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}