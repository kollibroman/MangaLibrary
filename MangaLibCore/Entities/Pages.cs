namespace MangaLibCore.Entities
{
    public class Pages
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string PageTitle { get; set; }
        public byte[] PageData { get; set; }

        public Chapter Chapter { get; set; }
    }
}