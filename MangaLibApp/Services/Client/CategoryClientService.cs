using System.Text.Json;
using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class CategoryClientService : ICategoryClientService
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
         {
             PropertyNameCaseInsensitive = true,
             PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
         };
         
        private readonly HttpClient _client;
        public CategoryClientService(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var responseMsg = await _client.GetAsync("/category");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<CategoryDto>>(stream, options);
        }
        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            var responseMsg = await _client.GetAsync($"/category/{id}");
            var stream = await responseMsg.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<CategoryDto>(stream, options);
        }
    }
}