using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class PageService : IPageService
    {
        private readonly IMapper _mapper;
        private readonly MangaLibDbContext _db;

        public PageService(IMapper mapper, MangaLibDbContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<List<PageDto>> GetAllFromManga(string MangaName)
        {
            var pages = await _db.Pages
                .Where(n => n.MangaName == MangaName)
                .OrderBy(p => p.PageNumber)
                .ToListAsync();
            return _mapper.Map<List<PageDto>>(pages);
        }

        public async Task<PageDto> GetByName(int PageNumber)
        {
             var page = await _db.Pages
               .SingleOrDefaultAsync(c => c.PageNumber == PageNumber);
            return _mapper.Map<PageDto>(page);
        }

        public async Task<int> GetTotalRecordsFromManga(string MangaName)
        {
            return await _db.Pages.Where(m => m.MangaName == MangaName).CountAsync();
        }
        public async Task<bool> Delete(int id)
        {
           var page = await _db.Pages.SingleOrDefaultAsync(i => i.Id == id);

            if(page is null)
                return false;
            
            _db.Remove(page);
            await _db.SaveChangesAsync();
            return true;
        }

    }
}