using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        void Create(CreateAuthorDto dto);
        bool Update(int id, UpdateAuthorDto dto);
        bool Delete(int id);
    }
}