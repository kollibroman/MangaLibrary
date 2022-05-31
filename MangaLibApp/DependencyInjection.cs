using System.Reflection;
using MangaLibApp.Interfaces;
using MangaLibApp.Services;
using MangaLibCore;
using Microsoft.Extensions.DependencyInjection;

namespace MangaLibApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddDbContext<MangaLibDbContext>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IMangaService, MangaService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAuthorService, AuthorService>();
            return services;
        }
    }
}