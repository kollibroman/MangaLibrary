using MangaLibApp;
using MangaLibApi.Middleware;
using MangaLibApp.Services.Client;

namespace MangaLibApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<ErrorHandler>();

            services.AddHttpClient<AuthorClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });
            services.AddHttpClient<CategoryClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });
            services.AddHttpClient<ChapterClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });
            services.AddHttpClient<CoverClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });
            services.AddHttpClient<MangaClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });
            services.AddHttpClient<PageClientService>(client =>
            {
                client.BaseAddress = Configuration.GetServiceUri("MangaLibApi");
            });

            services.AddApp();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseMiddleware<ErrorHandler>();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}