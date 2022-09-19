using MangaLibCore.Interfaces;

namespace MangaLibApp.Interfaces
{
    public interface ITagService
    {
        Task<TEntity> Tag<TEntity>(TEntity entity, string str) where TEntity : ITaggable;
        Task<TEntity> Untag<TEntity>(TEntity entity, string str) where TEntity : ITaggable;
    }
}