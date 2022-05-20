using MangaLibCore;
using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibLogic.Repositories
{
    public class MangaRepo : IMangaRepo
    {
        private readonly MangaLibDbContext _dbcontext;
        public MangaRepo(MangaLibDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Manga> GetMangas()
        {
            return _dbcontext.Mangas.ToList();
        }
        public Manga GetMangaId(int id)
        {
            return _dbcontext.Mangas.SingleOrDefault(i => i.Id == id);
        }

        public Manga AddManga(Manga manga)
        {
            _dbcontext.Add(manga);
            return manga;
        }

        public void UpdateManga(int id, Manga manga)
        {
            var updatedManga = _dbcontext.Mangas.SingleOrDefault(i => i.Id == id);
            updatedManga.UpdatedAt = DateTime.Now;
            updatedManga.Chapters = manga.Chapters;
            updatedManga.ChaptersCount++;
            updatedManga.PagesCount += manga.PagesCount;
        }

        public void DeleteManga(int id)
        {
            var manga = _dbcontext.Mangas.SingleOrDefault(i => i.Id == id);
            _dbcontext.Remove(manga);
        }
    }
}