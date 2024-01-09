using System.Reflection;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Services;
using MangaLibCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using MangaLibApp.Models;
using MangaLibApp.Models.Validators;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangaLibApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApp(this IServiceCollection services)
        {
            services.AddDbContext<MangaLibDbContext>();
            services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

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
            services.AddScoped<IValidator<RegisterUserDto>, RegisterUserDtoValidator>();

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