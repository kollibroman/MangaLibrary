using System.Globalization;
using MangaLibCore;
using MangaLibCore.Interfaces;
using MangaLibLogic.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MangaLibLogic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogic(this IServiceCollection services)
        {
            services.AddDbContext<MangaLibDbContext>();

            services.AddScoped<IMangaRepo, MangaRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IAuthorRepo, AuthorRepo>();
            return services;
        }
    }
}