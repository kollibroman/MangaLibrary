namespace MangaLibCore.Entities
{
    public class Chapter
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PagesCount { get; set; }
        public List<Pages> Pages { get; set; }
    }
}