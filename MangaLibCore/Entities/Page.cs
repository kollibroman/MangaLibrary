using System.ComponentModel.DataAnnotations.Schema;

namespace MangaLibCore.Entities
{
    public class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public byte[] PageData { get; set; }

        public string MangaName { get; set; }
    }
}