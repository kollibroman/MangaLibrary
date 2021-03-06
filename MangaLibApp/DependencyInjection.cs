using System.Reflection;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Services;
using MangaLibApp.Services.Client;
using MangaLibCore;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

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
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<ICoverService, CoverService>();
            services.AddScoped<IChapterService, ChapterService>();
            services.AddScoped<IApiConverter, ApiConverter>();
            services.AddScoped<IPageService, PageService>();

            services.AddHttpClient();

            services.AddScoped<IAuthorClientService, AuthorClientService>();
            services.AddScoped<ICategoryClientService, CategoryClientService>();
            services.AddScoped<IChapterClientService, ChapterClientService>();
            services.AddScoped<ICoverClientService, CoverClientService>();
            services.AddScoped<IMangaClientService, MangaClientService>();
            services.AddScoped<IPageClientService, PageClientService>();

            services.AddHttpContextAccessor();

            services.AddSingleton<IUriService>(o =>
                {
                    var accessor = o.GetRequiredService<IHttpContextAccessor>();
                    var request = accessor.HttpContext.Request;
                    var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
                    return new UriService(uri);
                }
            );
            return services;
        }
    }
}