using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        void Create(CreateCategoryDto dto);
        bool Update(int id, UpdateCategoryDto dto);
        bool Delete(int id);
    }
}