using MangaLibApp.Interfaces;
using MangaLibApp.Services;
using MangaLibCore;
using MangaLibCore.Entities;

namespace MangaLibApp.Helpers
{
    public class EfCoreExtensions : IEfCoreExtensions
    {
        private readonly MangaLibDbContext _db;

        public EfCoreExtensions(MangaLibDbContext db)
        {
            _db = db;
        }

        public async Task<Tag> AddAsync(Tag tag)
        {
            await _db.Tags.AddAsync(tag);
            return tag;
        }
    }
}