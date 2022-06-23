using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UpdateCoverDto
    {
        [Required]
        public byte[] Data { get; set; }
    }
}