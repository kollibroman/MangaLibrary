using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class PageClientService : IPageClientService
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         };
         
        private readonly HttpClient _client;

        public PageClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<PageDto>> GetPagesAsync()
        {
            var responseMsg = await _client.GetAsync("/page");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<PageDto>>(stream, options);
        }

        public async Task<PageDto> GetPageAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/page/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<PageDto>(stream, options);
        }
    }
}