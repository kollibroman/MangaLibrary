using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface ICategoryClientService
    {
        Task<List<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(string Name);
    }
}