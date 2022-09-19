using MangaLibApp.Interfaces;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Helpers
{
    public class ApiConverter : IApiConverter
    {
        public async Task<byte[]> convertToByte(IFormFile file)
        {
            MemoryStream ms = new();
            await file.CopyToAsync(ms);
            var byteArr = ms.ToArray();

            await ms.DisposeAsync();
            ms.Close();

            return byteArr;
        }

        public async Task<IFormFile> convertToFile(byte[] byteArr, string title, string fileName)
        {
            var stream = new MemoryStream(byteArr);

            IFormFile file = new FormFile(stream, 0, byteArr.Length, title, fileName);

            return file;
        }
    }
}