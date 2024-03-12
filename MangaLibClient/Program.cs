using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MangaLibClient;
using MangaLibClient.Filter;
using MangaLibCore.ApiClient;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var refitSettings = new RefitSettings();
var serializerOptions = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = false,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};
serializerOptions.Converters.Add(new ObjectToInferredTypesConverter());
refitSettings.ContentSerializer = new SystemTextJsonContentSerializer(serializerOptions);

// builder.Services.AddScoped<HttpClientDelegatingHandler>()
//     .AddRefitClient<IApiClient>()
//     .ConfigureHttpClient(client => { client.BaseAddress = new Uri("https://localhost:7143/api"); })
//     .AddHttpMessageHandler<HttpClientDelegatingHandler>();
builder.Services.AddRefitClient<IApiClient>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7143/api"));

await builder.Build().RunAsync();
