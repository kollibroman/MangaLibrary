using Microsoft.AspNetCore.Http;
using Microsoft.CSharp.RuntimeBinder;

namespace MangaLibApp.Interfaces.Client
{
    public interface IUploadClientService
    {
       Task<bool> UploadCoverAsync(string MangaName, IFormFile file);
       Task<bool> UploadChapterAsync(string MangaName, List<IFormFile> files);
       Task<bool> UploadPageAsync(string ChapterName, IFormFile file); 
    }
}