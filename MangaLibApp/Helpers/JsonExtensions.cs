using Newtonsoft.Json;

namespace MangaLibApp.Helpers
{
    public static class JsonExtensions
    {
        public  static IList<T> Deserialize<T>(this string SerializedJSONString)
        {
            var stuff = JsonConvert.DeserializeObject<IList<T>>(SerializedJSONString);
            return stuff;
        }
    }
}