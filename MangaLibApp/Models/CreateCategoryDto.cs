namespace MangaLibApp.Models
{
    public class CreateCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string> Mangas { get; set; }
    }
}