using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

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
        public async Task<List<AuthorDto>> GetAuthorsAsync()
        {
            var responseMsg = await _client.GetAsync("/author");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<AuthorDto>>(stream, options);
        }
        public async Task<AuthorDto> GetAuthorAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/author/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<AuthorDto>(stream, options);
        }
    }
}