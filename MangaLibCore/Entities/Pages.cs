namespace MangaLibCore.Entities
{
    public class Pages
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string PageTitle { get; set; }
        public byte[] PageData { get; set; }
        public string MangaId { get; set; }

        public Chapter Chapter { get; set; }
        public string ChapterId { get; set; }
    }
}