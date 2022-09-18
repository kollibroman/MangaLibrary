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
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangaLibApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddDbContext<MangaLibDbContext>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IMangaService, MangaService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IUpdateService, UpdateService>();
            services.AddScoped<ICoverService, CoverService>();
            services.AddScoped<IChapterService, ChapterService>();
            services.AddScoped<IApiConverter, ApiConverter>();
            services.AddScoped<IPageService, PageService>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<IRegisterService, RegisterService>();

            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            services.AddScoped<IAuthorClientService, AuthorClientService>();
            services.AddScoped<IChapterClientService, ChapterClientService>();
            services.AddScoped<ICoverClientService, CoverClientService>();
            services.AddScoped<IMangaClientService, MangaClientService>();
            services.AddScoped<IPageClientService, PageClientService>();
            services.AddScoped<IUpdateClientService, UpdateClientService>();
            services.AddScoped<IUploadClientService, UploadClientService>();

            services.AddHttpClient<IAuthorClientService, AuthorClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<IChapterClientService, ChapterClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<ICoverClientService, CoverClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<IMangaClientService, MangaClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<IPageClientService, PageClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<IUpdateClientService, UpdateClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));
            services.AddHttpClient<IUploadClientService, UploadClientService>(c => c.BaseAddress = new Uri("https://localhost:5001"));

            services.AddScoped<IEfCoreExtensions, EfCoreExtensions>();

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