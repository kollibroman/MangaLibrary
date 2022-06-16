using MangaLibApp.Filter;

namespace MangaLibApp.Interfaces
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}