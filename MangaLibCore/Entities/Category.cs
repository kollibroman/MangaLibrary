using System.ComponentModel.DataAnnotations.Schema;

namespace MangaLibCore.Entities
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string> Mangas { get; set; }
    }
}