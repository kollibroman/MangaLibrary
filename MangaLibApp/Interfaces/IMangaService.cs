using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IMangaService
    {
        Task<List<MangaDto>> GetAll(PaginationFilter filter);
        Task<MangaDto> GetByName(string Name);
        Task<int> GetTotalRecords();
        Task Create(CreateMangaDto dto);
        Task<bool> Update(int id, UpdateMangaDto dto);
        Task<bool> Delete(int id);
    }
}