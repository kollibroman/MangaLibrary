using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibLogic.Repositories
{
    public class MangaRepo : IMangaRepo
    {
        public IEnumerable<Manga> GetMangas()
        {
            throw new NotImplementedException();
        }
        public Manga GetMangaId(int id)
        {
            throw new NotImplementedException();
        }

        public Manga AddManga(Manga manga)
        {
            throw new NotImplementedException();
        }

        public void UpdateManga(int id, Manga manga)
        {
            throw new NotImplementedException();
        }

        public void DeleteManga(int id)
        {
            throw new NotImplementedException();
        }
    }
}