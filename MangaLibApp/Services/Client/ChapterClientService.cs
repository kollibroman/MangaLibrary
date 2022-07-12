using MangaLibApp.Interfaces.Client;
using MangaLibApp.Models;

namespace MangaLibApp.Services.Client
{
    public class ChapterClientService : IChapterClientService
    {
        public Task<ChapterDto> GetChapterAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChapterDto>> GetChaptersAsync()
        {
            throw new NotImplementedException();
        }
    }
}