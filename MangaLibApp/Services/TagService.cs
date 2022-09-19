using AutoMapper;
using MangaLibApp.Helpers;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibApp.Wrappers;
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

        public async Task<TagDto> GetTagsAsync()
        {
            var Tags = await  _db.Tags.ToListAsync();

            return _mapper.Map<TagDto>(Tags);
        }

        public async Task<TEntity> TagAsync<TEntity>(TEntity entity, string str) where TEntity : ITaggable
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

        public async Task<TEntity> UntagAsync<TEntity>(TEntity entity, string str) where TEntity : ITaggable
        {
            Tag tag = entity.Tags.FirstOrDefault(x => x.TagName == str);

            if (tag != null)
                entity.Tags.Remove(tag);

            return entity;
        }
    }
}