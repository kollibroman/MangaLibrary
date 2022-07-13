using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class CoverClientService : ICoverClientService
    {
       private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         };
         
        private readonly HttpClient _client;
        public CoverClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<CoverDto>> GetCoversAsync()
        {
            var responseMsg = await _client.GetAsync("/cover");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<CoverDto>>(stream, options);
        }
        public async Task<CoverDto> GetCoverAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/cover/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<CoverDto>(stream, options);
        }
    }
}