using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UploadPageDto
    {
        public int PageNumber { get; set; }
        public string PageTitle { get; set; }
        [Required]
        public byte[] PageData { get; set; }
    }
}