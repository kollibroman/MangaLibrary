using MangaLibApp.Models;

namespace MangaLibApp.Interfaces.Client
{
    public interface IChapterClientService
    {
        Task<List<ChapterDto>> GetChaptersAsync();
        Task<ChapterDto> GetChapterAsync(string Name);
    }
}