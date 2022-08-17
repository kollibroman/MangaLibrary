using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Newtonsoft.Json;

namespace MangaLibApp.Services.Client
{
    public class CoverClientService : ICoverClientService
    {
         
        private readonly HttpClient _client;
        public CoverClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<CoverDto>> GetCoversAsync()
        {
            var responseMsg = await _client.GetStringAsync("/api/cover");
           
            return JsonConvert.DeserializeObject<PagedResponse<List<CoverDto>>>(responseMsg).Data;
        }
        public async Task<CoverDto> GetCoverAsync(int id)
        {
            var responseMsg = await _client.GetStringAsync($"/api/cover/{id}");
            
            return JsonConvert.DeserializeObject<Response<CoverDto>>(responseMsg).Data;
        }
    }
}