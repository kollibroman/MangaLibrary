using System.ComponentModel.DataAnnotations.Schema;
using MangaLibCore.Enums;
using MangaLibCore.Idk;

namespace MangaLibCore.Entities
{
    public class Manga : AbstractTag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public EntityType Type { get; set; }
        public string Title { get; set; }
        public string PublishedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
        public int ChaptersCount { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        public int CoverId { get; set; }
        public Author Author { get; set; }
        public Cover Cover { get; set; }
    }
}