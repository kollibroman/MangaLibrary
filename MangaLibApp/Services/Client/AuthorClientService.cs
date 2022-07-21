using System.Text;
using System.Text.Json;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
using Newtonsoft.Json;

namespace MangaLibApp.Services.Client
{
    public class AuthorClientService : IAuthorClientService
    {   
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         }; 
        private readonly HttpClient _client;
        public AuthorClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<IList<AuthorViewModel>> GetAuthorsAsync(int pageNumber)
        {
            _client.BaseAddress =  new Uri("https://localhost:5001");
            var responseMsg = await _client.GetStringAsync("/api/author?PageNumber=1&PageSize=10");
            
            var Response = JsonConvert.DeserializeObject<PagedResponse<IList<AuthorViewModel>>>(responseMsg);
            return Response.Data;
        }
        public async Task<AuthorViewModel> GetAuthorAsync(int id)
        {
            _client.BaseAddress = new Uri("https://localhost:5001");
            var responseMsg = await _client.GetStringAsync($"/api/author/{id}");
            
            var Response = JsonConvert.DeserializeObject<Response<AuthorViewModel>>(responseMsg);
            return Response.Data;
        }
    }
}