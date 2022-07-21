using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UpdateAuthorDto
    {
        [Required]
        public List<MangaDto> WrittenMangas { get; set; }
    }
}