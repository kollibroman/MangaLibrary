using MangaLibrary.Api.Api;
using MangaLibrary.Api.Mappings;
using MangaLibrary.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((builderContext, configuration) =>
    configuration.ReadFrom.Configuration(builderContext.Configuration));

var connectionStrings = builder.Configuration.GetConnectionString("Manga-DB");
builder.Services.AddNpgsql<MangaLibContext>(connectionStrings);

builder.Services.AddAutoMapper(typeof(MapConfig));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSerilogRequestLogging();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.Map("/", () => Results.Redirect("/swagger"));

app.RegisterApiEndpoints();

using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetService<MangaLibContext>();
context!.Database.Migrate();

app.Run();
