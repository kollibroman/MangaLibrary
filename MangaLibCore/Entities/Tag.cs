using System.ComponentModel.DataAnnotations;

namespace MangaLibCore.Entities
{
    public class Tag
    {
        public Tag()
        {
            Mangas = new List<Manga>();
        }

        [Key]
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<Manga> Mangas { get; set; }
    }
}