using System.ComponentModel.DataAnnotations;
using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class UpdateCategoryDto
    {
        [Required]
        public List<string> Mangas { get; set; }
    }
}