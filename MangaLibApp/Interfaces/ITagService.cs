using System.Runtime;
using MangaLibApp.Models;
using MangaLibCore.Interfaces;

namespace MangaLibApp.Interfaces
{
    public interface ITagService
    {
        Task<TagDto> GetTagsAsync();
        Task<TEntity> TagAsync<TEntity>(TEntity entity, string str) where TEntity : ITaggable;
        Task<TEntity> UntagAsync<TEntity>(TEntity entity, string str) where TEntity : ITaggable;
    }
}