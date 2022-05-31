using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UpdateAuthorDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        
        [Required]
        public List<string> WrittenMangas { get; set; }
    }
}