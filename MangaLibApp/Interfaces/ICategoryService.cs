using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAll(PaginationFilter filter);
        Task<CategoryDto> GetById(int id);
        Task Create(CreateCategoryDto dto);
        Task<bool> Update(int id, UpdateCategoryDto dto);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecords();
    }
}