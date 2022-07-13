using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class ChapterClientService : IChapterClientService
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         };
         
        private readonly HttpClient _client;
        public ChapterClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<ChapterDto>> GetChaptersAsync()
        {
            var responseMsg = await _client.GetAsync("/chapter");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<ChapterDto>>(stream, options);
        }
        public async Task<ChapterDto> GetChapterAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/author/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<ChapterDto>(stream, options);
        }
    }
}