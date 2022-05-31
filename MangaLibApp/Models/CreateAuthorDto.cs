using System.ComponentModel.DataAnnotations;
using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class CreateAuthorDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Required]
        public List<string> WrittenMangas { get; set; }
    }
}