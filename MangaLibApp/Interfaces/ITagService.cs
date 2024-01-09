using System.Runtime;
using MangaLibApp.Models;
using MangaLibCore.Interfaces;

namespace MangaLibApp.Interfaces
{
    public interface ITagService
    {
        Task<TagDto> GetTagsAsync(CancellationToken ct);
        Task<TEntity> TagAsync<TEntity>(TEntity entity, string str, CancellationToken ct) where TEntity : ITaggable;
        Task<TEntity> UntagAsync<TEntity>(TEntity entity, string str, CancellationToken ct) where TEntity : ITaggable;
    }
}