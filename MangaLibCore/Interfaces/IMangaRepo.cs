using System.Reflection;
using MangaLibCore.Entities;

namespace MangaLibCore.Interfaces
{
    public interface IMangaRepo
    {
        IEnumerable<Manga> GetMangas();
        Manga GetMangaId(int id);
        Manga AddManga(Manga manga);
        Manga UpdateManga(Manga manga);
        void DeleteManga(int id);
    }
}