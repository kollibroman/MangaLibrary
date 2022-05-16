using System.Reflection;
using MangaLibCore.Entities;

namespace MangaLibCore.Interfaces
{
    public interface IMangaRepo
    {
        IEnumerable<Manga> GetMangas();
        Manga GetMangaId(int id);
        Manga AddManga(Manga manga);
        void UpdateManga(int id, Manga manga);
        void DeleteManga(int id);
    }
}