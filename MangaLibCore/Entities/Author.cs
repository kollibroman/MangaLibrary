using System.ComponentModel.DataAnnotations.Schema;
using MangaLibCore.Enums;

namespace MangaLibCore.Entities
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EntityType Type { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<Manga> WrittenMangas { get; set; }
    }
}