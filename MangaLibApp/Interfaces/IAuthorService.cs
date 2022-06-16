using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IAuthorService
    {
        List<AuthorDto> GetAll(PaginationFilter filter);
        AuthorDto GetById(int id);
        void Create(CreateAuthorDto dto);
        bool Update(int id, UpdateAuthorDto dto);
        bool Delete(int id);
        int GetTotalRecords();
    }
}