using MangaLibApp.Filter;
using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IPageService
    {
        Task<List<PageDto>> GetAllFromManga(string mangaName, CancellationToken ct);
        Task<PageDto> GetByNumber(int pageNumber, CancellationToken ct);
        Task<bool> Delete(int id, CancellationToken ct);
        Task<int> GetTotalRecordsFromManga(string mangaName, CancellationToken ct);
    }
}