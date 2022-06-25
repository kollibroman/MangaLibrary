using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface IApiConverter
    {
        Task<byte[]> convertToByte(IFormFile file);
        Task<IFormFile> convertToFile(byte[] byteArr, string title, string fileName);
    }
}