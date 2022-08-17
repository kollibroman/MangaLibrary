using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Newtonsoft.Json;

namespace MangaLibApp.Services.Client
{
    public class PageClientService : IPageClientService
    {
        private readonly HttpClient _client;

        public PageClientService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<PageDto>> GetPagesAsync()
        {
            var responseMsg = await _client.GetStringAsync("/api/page");
            
            return JsonConvert.DeserializeObject<PagedResponse<List<PageDto>>>(responseMsg).Data;
        }

        public async Task<PageDto> GetPageAsync(int id)
        {
            var responseMsg = await _client.GetStringAsync($"/api/page/{id}");

            return JsonConvert.DeserializeObject<Response<PageDto>>(responseMsg).Data;
        }
    }
}