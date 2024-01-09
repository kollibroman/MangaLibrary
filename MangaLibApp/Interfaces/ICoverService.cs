using MangaLibApp.Filter;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface ICoverService
    {
        Task<List<CoverDto>> GetAll(PaginationFilter filter, CancellationToken ct);
        Task<CoverDto> GetById(int id, CancellationToken ct);
        Task<bool> Update(int id, IFormFile file, CancellationToken ct);
        Task<bool> Delete(int id, CancellationToken ct);
        Task<int> GetTotalRecords(CancellationToken ct);
    }
}