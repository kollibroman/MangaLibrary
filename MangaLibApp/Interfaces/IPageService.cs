using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IPageService
    {
        Task<List<PageDto>> GetAllFromManga(string MangaName);
        Task<PageDto> GetByName(int PageNumber);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecordsFromManga(string MangaName);
    }
}