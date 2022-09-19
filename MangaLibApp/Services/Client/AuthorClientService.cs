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
        private readonly HttpClient _client;
        public AuthorClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<IList<AuthorViewModel>> GetAuthorsAsync(int pageNumber)
        {
            var responseMsg = await _client.GetStringAsync("/api/author?PageNumber=1&PageSize=10");
            
            return JsonConvert.DeserializeObject<PagedResponse<IList<AuthorViewModel>>>(responseMsg).Data;
        }
        public async Task<AuthorViewModel> GetAuthorAsync(int id)
        {
            var responseMsg = await _client.GetStringAsync($"/api/author/{id}");
            
            return JsonConvert.DeserializeObject<Response<AuthorViewModel>>(responseMsg).Data;
        }
    }
}