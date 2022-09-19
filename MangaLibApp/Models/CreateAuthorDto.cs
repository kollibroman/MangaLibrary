using System.ComponentModel.DataAnnotations;
using MangaLibCore.Entities;

namespace MangaLibApp.Models
{
    public class CreateAuthorDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string> WrittenMangas { get; set; }
    }
}