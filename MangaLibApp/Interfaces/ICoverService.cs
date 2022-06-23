using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface ICoverService
    {
       Task<List<CoverDto>> GetAll(PaginationFilter filter);
        Task<CoverDto> GetById(int id);
        Task<bool> Update(int id, UpdateCoverDto dto);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecords();
    }
}