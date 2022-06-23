using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class CoverService : ICoverService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;

        public CoverService(MangaLibDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<CoverDto>> GetAll(PaginationFilter filter)
        {
           var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var covers = await  _db.Cover.
            Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
            return _mapper.Map<List<CoverDto>>(covers);
        }

        public async Task<CoverDto> GetById(int id)
        {
            var cover = await _db.Cover.SingleOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<CoverDto>(cover);
        }

        public async Task<bool> Delete(int id)
        {
            var cover = await _db.Cover.SingleOrDefaultAsync(i => i.Id == id);

            if(cover is null)
                return false;

            _db.Remove(cover);
            await _db.SaveChangesAsync();
            return true;
        }


        public async Task<int> GetTotalRecords()
        {
            return await _db.Cover.CountAsync();
        }

        public async Task<bool> Update(int id, UpdateCoverDto dto)
        {
            var cover = await _db.Cover.SingleOrDefaultAsync(i => i.Id == id);

            if(cover is null) 
                return false;

            cover.Data = dto.Data;
            cover.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return true;
        }
    }
}