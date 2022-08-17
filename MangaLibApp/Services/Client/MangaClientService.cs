using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Newtonsoft.Json;

namespace MangaLibApp.Services.Client
{
    public class MangaClientService : IMangaClientService
    {
        private readonly HttpClient _client;

        public MangaClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<MangaDto>> GetMangasAsync()
        {
            var responseMsg = await _client.GetStringAsync("/api/manga");

            return JsonConvert.DeserializeObject<PagedResponse<List<MangaDto>>>(responseMsg).Data;            
        }

        public async Task<MangaDto> GetMangaAsync(int id)
        {
            var responseMsg = await _client.GetStringAsync($"/api/manga/{id}");
            
            return JsonConvert.DeserializeObject<Response<MangaDto>>(responseMsg).Data;
        }
    }
}