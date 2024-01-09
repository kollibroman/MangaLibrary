using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using MangaLibCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class TagService : ITagService
    {
        private readonly MangaLibDbContext _db;
        private readonly IEfCoreExtensions _ext;
        private readonly IMapper _mapper;

        public TagService(MangaLibDbContext db, IEfCoreExtensions ext, IMapper mapper)
        {
            _db = db;
            _ext = ext;
            _mapper = mapper;
        }

        public async Task<TagDto> GetTagsAsync(CancellationToken ct)
        {
            var tags = await  _db.Tags.ToListAsync(ct);

            return _mapper.Map<TagDto>(tags);
        }

        public async Task<TEntity> TagAsync<TEntity>(TEntity entity, string str, CancellationToken ct) where TEntity : ITaggable
        {
            string tag = str.Trim();

            if (entity.Tags.All(t => t.TagName != tag))
            {
                var tagEntity = await _db.Tags.FirstOrDefaultAsync(t => t.TagName == tag, ct);

                if(tagEntity == null)
                    tagEntity = await _ext.AddAsync(new Tag {TagName = tag}, ct);
                entity.Tags.Add(tagEntity);
            }
            return entity;
        }

        public async Task<TEntity> UntagAsync<TEntity>(TEntity entity, string str, CancellationToken ct) where TEntity : ITaggable
        {
            var tag = await _db.Tags.FirstOrDefaultAsync(x => x.TagName == str, ct);

            if (tag != null)
                entity.Tags.Remove(tag);

            return entity;
        }
    }
}