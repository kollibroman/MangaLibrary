using MangaLibCore.Entities;

namespace MangaLibApp.Interfaces
{
    public interface IEfCoreExtensions
    {
        public Task<Tag> AddAsync(Tag tag, CancellationToken ct);
    }
}