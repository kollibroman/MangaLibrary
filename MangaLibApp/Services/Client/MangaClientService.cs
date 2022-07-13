using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class MangaClientService : IMangaClientService
    {
       private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         };
         
        private readonly HttpClient _client;

        public MangaClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<MangaDto>> GetMangasAsync()
        {
            var responseMsg = await _client.GetAsync("/manga");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<MangaDto>>(stream, options);
        }

        public async Task<MangaDto> GetMangaAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/manga/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<MangaDto>(stream, options);
        }
    }
}