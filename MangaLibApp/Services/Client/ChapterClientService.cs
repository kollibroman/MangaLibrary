using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Newtonsoft.Json;

namespace MangaLibApp.Services.Client
{
    public class ChapterClientService : IChapterClientService
    {
        private readonly HttpClient _client;
        public ChapterClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<ChapterDto>> GetChaptersAsync()
        {
            var responseMsg = await _client.GetStringAsync("/api/chapter");
    
            return JsonConvert.DeserializeObject<PagedResponse<List<ChapterDto>>>(responseMsg).Data;
        }
        public async Task<ChapterDto> GetChapterAsync(int id)
        {
            var responseMsg = await _client.GetStringAsync($"/api/author/{id}");

            return JsonConvert.DeserializeObject<Response<ChapterDto>>(responseMsg).Data;
        }
    }
}