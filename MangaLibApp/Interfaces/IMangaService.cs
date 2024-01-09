using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IMangaService
    {
        Task<List<MangaDto>> GetAll(PaginationFilter filter, CancellationToken ct);
        Task<MangaDto> GetById(int id, CancellationToken ct);
        Task<int> GetTotalRecords(CancellationToken ct);
        Task Create(CreateMangaDto dto, CancellationToken ct);
        Task<bool> Update(int id, UpdateMangaDto dto, CancellationToken ct);
        Task<bool> Delete(int id, CancellationToken ct);
    }
}