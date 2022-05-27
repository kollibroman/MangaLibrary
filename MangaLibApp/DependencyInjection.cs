using System.Reflection;
using MangaLibApp.Interfaces;
using MangaLibApp.Services;
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
            services.AddSingleton<IMangaService, MangaService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IAuthorService, AuthorService>();
            return services;
        }
    }
}