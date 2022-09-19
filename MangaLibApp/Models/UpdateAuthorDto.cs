using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models
{
    public class UpdateAuthorDto
    {
        public List<MangaDto> WrittenMangas { get; set; }
    }
}