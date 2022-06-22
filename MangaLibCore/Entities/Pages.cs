namespace MangaLibCore.Entities
{
    public class Pages
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string PageTitle { get; set; }
        public byte[] PageData { get; set; }
    }
}