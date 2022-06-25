using MangaLibApp.Filter;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IChapterService
    {
        Task<List<ChapterDto>> GetAllFromManga(string MangaName);
        Task<ChapterDto> GetByName(string Name);
        //Task<bool> Update(string Name, IFormFile file);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecordsFromManga(string MangaName);
    }
}