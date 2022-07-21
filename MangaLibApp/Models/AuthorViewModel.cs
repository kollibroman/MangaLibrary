using MangaLibApp.Models;
using Newtonsoft.Json;

namespace MangaLibApp.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class AuthorViewModel
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "Surname")]
        public string Surname { get; set; }

        [JsonProperty(PropertyName = "WrittenMangas")]
        public List<MangaDto> WrittenMangas { get; set; }
    }
}