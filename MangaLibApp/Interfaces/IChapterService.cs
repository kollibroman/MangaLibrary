using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IChapterService
    {
        Task<List<ChapterDto>> GetAllFromManga(string mangaName, CancellationToken ct);
        Task<ChapterDto> GetById(int id, CancellationToken ct);
        Task<bool> Delete(int id, CancellationToken ct);
        Task<int> GetTotalRecordsFromManga(string mangaName, CancellationToken ct);
    }
}