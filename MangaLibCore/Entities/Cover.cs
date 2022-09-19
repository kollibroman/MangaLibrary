using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MangaLibCore.Enums;

namespace MangaLibCore.Entities
{
    public class Cover
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public EntityType Type { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MangaName { get; set; }

        public Manga Manga { get; set; }
    }
}