using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class UpdateService : IUpdateService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;
        private readonly IApiConverter _converter;
        private readonly ICoverService _service;

        public UpdateService(MangaLibDbContext db, IMapper mapper, IApiConverter converter, ICoverService service)
        {
            _db = db;
            _mapper = mapper;
            _converter = converter;
            _service = service;
        }
        
        //TODO: zaimplementowac
        public Task UpdatePage(int id, IFormFile file, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
        
        //TODO: zaimplementowac
        public Task UpdateChapter(int id, IFormFile file, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateCover(int id, IFormFile file, CancellationToken ct)
        {
            var cover = await _db.Cover.SingleOrDefaultAsync(i => i.Id == id, ct);

            if(cover is null)
                return false;

            cover.Data = await _converter.ConvertToByte(file, ct);

            await _db.SaveChangesAsync(ct);
            return true;
        }

    }
}