using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UpdateAuthorDto
    {
        [Required]
        public List<string> WrittenMangas { get; set; }
    }
}