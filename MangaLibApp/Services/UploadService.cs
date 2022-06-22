using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Http;

namespace MangaLibApp.Services
{
    public class UploadService : IUploadService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;

        public UploadService(MangaLibDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task UploadCoverAsync(IFormFile file, string mangaName)
        {
            var dto = new UploadCoverDto
            {
                Id = 1,
                Name = file.Name,
                Data = new byte[file.Length],
                MangaName = mangaName
            };
            var cover = _mapper.Map<Cover>(dto);

            await _db.AddAsync(cover);
            await _db.SaveChangesAsync();
        }

        public async Task UploadChapterAsync(IFormFile file, string mangaName)
        {
            throw new NotImplementedException();
        }

        public Task UploadPageAsync(IFormFile file, string mangaName)
        {
            throw new NotImplementedException();
        }
    }
}