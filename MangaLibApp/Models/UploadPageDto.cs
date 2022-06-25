using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UploadPageDto
    {
        public int PageNumber { get; set; }
        [Required]
        public byte[] PageData { get; set; }
    }
}