using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class CategoryClientService : ICategoryClientService
    {
        public Task<List<CategoryDto>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryAsync(string Name)
        {
            throw new NotImplementedException();
        }
    }
}