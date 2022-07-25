using System.ComponentModel.DataAnnotations.Schema;
using MangaLibCore.Enums;

namespace MangaLibCore.Entities
{
    public class Manga
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public EntityType Type { get; set; }
        public string Title { get; set; }
        public string PublishedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
        public int ChaptersCount { get; set; }

        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string CoverId { get; set; }
        public Author Author { get; set; }
        public Cover Cover { get; set; }
    }
}