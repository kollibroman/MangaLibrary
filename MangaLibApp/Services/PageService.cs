using AutoMapper;
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

        public async Task<List<PageDto>> GetAllFromManga(string mangaName, CancellationToken ct)
        {
            var pages = await _db.Pages
                .Where(n => n.MangaName == mangaName)
                .OrderBy(p => p.PageNumber)
                .ToListAsync(ct);
            return _mapper.Map<List<PageDto>>(pages);
        }

        public async Task<PageDto> GetByNumber(int pageNumber, CancellationToken ct)
        {
             var page = await _db.Pages
               .SingleOrDefaultAsync(c => c.PageNumber == pageNumber, ct);
            return _mapper.Map<PageDto>(page);
        }

        public async Task<int> GetTotalRecordsFromManga(string mangaName, CancellationToken ct)
        {
            return await _db.Pages.Where(m => m.MangaName == mangaName).CountAsync(ct);
        }
        public async Task<bool> Delete(int id, CancellationToken ct)
        {
           var page = await _db.Pages.SingleOrDefaultAsync(i => i.Id == id, ct);

            if(page is null)
                return false;
            
            _db.Remove(page);
            await _db.SaveChangesAsync(ct);
            return true;
        }

    }
}