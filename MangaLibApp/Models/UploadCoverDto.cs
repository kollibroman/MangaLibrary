using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UploadCoverDto
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string MangaName { get; set; }
    }
}