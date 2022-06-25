using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class CoverService : ICoverService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;
        private readonly IApiConverter _converter;

        public CoverService(MangaLibDbContext db, IMapper mapper, IApiConverter converter)
        {
            _db = db;
            _mapper = mapper;
            _converter = converter;
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

        public async Task<bool> Update(int id, IFormFile file)
        {
            var cover = await _db.Cover.SingleOrDefaultAsync(i => i.Id == id);

            if(cover is null) 
                return false;

            cover.Data = await _converter.convertToByte(file);
            cover.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return true;
        }
    }
}