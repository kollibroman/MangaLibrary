using MangaLibApp.Filter;
using MangaLibApp.Models;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Interfaces
{
    public interface ICoverService
    {
        Task<List<CoverDto>> GetAll(PaginationFilter filter);
        Task<CoverDto> GetById(int id);
        Task<bool> Update(int id, IFormFile file);
        Task<bool> Delete(int id);
        Task<int> GetTotalRecords();
    }
}