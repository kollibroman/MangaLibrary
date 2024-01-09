using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MangaLibApp.Services
{
    public class UploadService : IUploadService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;
        private readonly IApiConverter _converter;
        private readonly ILogger<UploadService> _logger;
        private readonly ICoverService _service;

        public UploadService(MangaLibDbContext db, IMapper mapper, IApiConverter converter, ILogger<UploadService> logger, ICoverService service)
        {
            _db = db;
            _mapper = mapper;
            _converter = converter;
            _logger = logger;
            _service = service;
        }
        
        public async Task UploadCoverAsync(IFormFile file, string fileName, string mangaName, CancellationToken ct)
        {
            var dto = new UploadCoverDto
            {
                Name = fileName,
                Data = await _converter.ConvertToByte(file, ct),
                MangaName = mangaName
            };
            
            var cover = _mapper.Map<Cover>(dto);

            await _db.AddAsync(cover, ct);
            await _db.SaveChangesAsync(ct);
        }

        public async Task UploadChapterAsync(List<IFormFile> files, string chapterName, string mangaName, CancellationToken ct)
        {
            List<UploadPageDto> pages = new();
            List<byte[]> pageDatas = new();
            int i = 0;

            foreach(var item in files)
            {
                i++;
                var convertedItem = await _converter.ConvertToByte(item, ct);
                pageDatas.Add(convertedItem);

                var page = new UploadPageDto
                {
                    PageNumber = i,
                    PageData = pageDatas.ElementAt(i - 1)
                };
                pages.Add(page);
            }

            _logger.LogInformation($"{i}");

            var chapterDto = new UploadChapterDto
            {
                Name = chapterName,
                PagesCount = pages.Count,
                ChapterName = chapterName,
                MangaName = mangaName,
                Pages = pages
            };
            var chapter = _mapper.Map<Chapter>(chapterDto);

            await _db.AddAsync(chapter, ct);
            await _db.SaveChangesAsync(ct);
        }

        public async Task UploadPageAsync(IFormFile file, int pageNumber, string mangaName, CancellationToken ct)
        {
           var pagedto = new UploadPageDto
           {
                PageData = await _converter.ConvertToByte(file, ct),
                PageNumber = pageNumber,
                MangaName = mangaName
           };

           var page = _mapper.Map<Page>(pagedto);
           
           await _db.Pages.AddAsync(page, ct);
           await _db.SaveChangesAsync(ct);
        }
    }
}