using MangaLibApp.Filter;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IChapterService
    {
        Task<List<ChapterDto>> GetAllFromManga(string MangaName);
        Task<ChapterDto> GetById(int id);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecordsFromManga(string MangaName);
    }
}