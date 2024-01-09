using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IAuthorService
    {
        Task<List<AuthorDto>> GetAll(PaginationFilter filter, CancellationToken ct);
        Task<AuthorDto> GetById(int id, CancellationToken ct);
        Task Create(CreateAuthorDto dto, CancellationToken ct);
        Task<bool> Update(int id, UpdateAuthorDto dto, CancellationToken ct);
        Task<bool> Delete(int id, CancellationToken ct);
        Task<int> GetTotalRecords(CancellationToken ct);
    }
}