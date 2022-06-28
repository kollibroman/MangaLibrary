using AutoMapper;
using MangaLibApp.Filter;
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

        public async Task<List<ChapterDto>> GetAllFromManga(string MangaName)
        {
                var chapters = await _db.Chapters
                .Include(p => p.Pages)
                .Where(m => m.MangaName == MangaName)
                .OrderBy(i => i.Id)
                .ToListAsync();

                return _mapper.Map<List<ChapterDto>>(chapters);
        }

        public async Task<ChapterDto> GetByName(string Name)
        {
            var chapter = await _db.Chapters
               .SingleOrDefaultAsync(c => c.ChapterName == Name);
            return _mapper.Map<ChapterDto>(chapter);
        }

        public async Task<int> GetTotalRecordsFromManga(string MangaName)
        {
            return await _db.Chapters.Where(m => m.MangaName == MangaName).CountAsync();
        }
        public async Task<bool> Delete(int id)
        {
            var chapter = await _db.Chapters.SingleOrDefaultAsync(i => i.Id == id);

            if(chapter is null)
                return false;
            
            _db.Remove(chapter);
            await _db.SaveChangesAsync();
            return true;
        }

        // public Task<bool> Update(string Name, IFormFile file)
        // {
        //     throw new NotImplementedException();
        // }
    }
}