using MangaLibApp.Interfaces.Client;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Services.Client
{
    public class UploadClientService : IUploadClientService
    {
        public Task<bool> UploadChapterAsync(string MangaName, List<IFormFile> files)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UploadCoverAsync(string MangaName, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UploadPageAsync(string ChapterName, IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}