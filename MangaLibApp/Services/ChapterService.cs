using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class ChapterService : IChapterService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;
        
        public ChapterService(MangaLibDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<ChapterDto>> GetAllFromManga(string mangaName, CancellationToken ct)
        {
                var chapters = await _db.Chapters
                .Include(p => p.Pages)
                .Where(m => m.MangaName == mangaName)
                .OrderBy(i => i.Id)
                .ToListAsync(ct);

                return _mapper.Map<List<ChapterDto>>(chapters);
        }

        public async Task<ChapterDto> GetById(int id, CancellationToken ct)
        {
            var chapter = await _db.Chapters
               .SingleOrDefaultAsync(c => c.Id == id, ct);
            return _mapper.Map<ChapterDto>(chapter);
        }

        public async Task<int> GetTotalRecordsFromManga(string mangaName, CancellationToken ct)
        {
            return await _db.Chapters.Where(m => m.MangaName == mangaName).CountAsync(ct);
        }
        public async Task<bool> Delete(int id, CancellationToken ct)
        {
            var chapter = await _db.Chapters.SingleOrDefaultAsync(i => i.Id == id, ct);

            if(chapter is null)
                return false;
            
            _db.Remove(chapter);
            await _db.SaveChangesAsync(ct);
            return true;
        }
    }
}