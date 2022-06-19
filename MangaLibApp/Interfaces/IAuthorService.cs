using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IAuthorService
    {
        Task<List<AuthorDto>> GetAll(PaginationFilter filter);
        Task<AuthorDto> GetById(int id);
        Task Create(CreateAuthorDto dto);
        Task<bool> Update(int id, UpdateAuthorDto dto);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecords();
    }
}