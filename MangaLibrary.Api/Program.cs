using MangaLibrary.Api.Persistence;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((builderContext, configuration) =>
    configuration.ReadFrom.Configuration(builderContext.Configuration));

var connectionStrings = builder.Configuration.GetConnectionString("MangaDB");
builder.Services.AddNpgsql<MangaLibContext>(connectionStrings);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
