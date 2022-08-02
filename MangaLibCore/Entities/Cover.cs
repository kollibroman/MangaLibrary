using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaLibCore.Entities
{
    public class Cover
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MangaName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MangaId { get; set; }
        [ForeignKey("MangaId")]
        public Manga Manga { get; set; }
    }
}