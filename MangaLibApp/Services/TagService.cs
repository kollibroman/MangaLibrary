using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibCore;
using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibApp.Services
{
    public class TagService : ITagService
    {
        private readonly MangaLibDbContext _db;
        private readonly IEfCoreExtensions _ext;

        public TagService(MangaLibDbContext db, IEfCoreExtensions ext)
        {
            _db = db;
            _ext = ext;
        }

        public async Task<TEntity> Tag<TEntity>(TEntity entity, string str) where TEntity : ITaggable
        {
            string tag = str.Trim();

            if (entity.Tags.All(t => t.TagName != tag))
            {
                var tagEntity = _db.Tags.FirstOrDefault(t => t.TagName == tag);

                if(tagEntity == null)
                    tagEntity = await _ext.AddAsync(new Tag {TagName = tag});
                entity.Tags.Add(tagEntity);
            }
            return entity;
        }

        public async Task<TEntity> Untag<TEntity>(TEntity entity, string str) where TEntity : ITaggable
        {
            Tag tag = entity.Tags.FirstOrDefault(x => x.TagName == str);

            if (tag != null)
                entity.Tags.Remove(tag);

            return entity;
        }
    }
}