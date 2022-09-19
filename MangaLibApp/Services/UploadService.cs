using AutoMapper;
using MangaLibApp.Helpers;
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
        public async Task UploadCoverAsync(IFormFile file, string fileName, string mangaName)
        {
            var dto = new UploadCoverDto
            {
                Name = fileName,
                Data = await _converter.convertToByte(file),
                MangaName = mangaName
            };
            var cover = _mapper.Map<Cover>(dto);

            await _db.AddAsync(cover);
            await _db.SaveChangesAsync();
        }

        public async Task UploadChapterAsync(List<IFormFile> files, string chapterName, string mangaName)
        {
            List<UploadPageDto> pages = new();
            List<byte[]> pageDatas = new();
            int i = 0;

            foreach(var item in files)
            {
                i++;
                var convertedItem = await _converter.convertToByte(item);
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

            await _db.AddAsync(chapter);
            await _db.SaveChangesAsync();
        }

        public async Task UploadPageAsync(IFormFile file, int pageNumber, string mangaName)
        {
           var pagedto = new UploadPageDto
           {
                PageData = await _converter.convertToByte(file),
                PageNumber = pageNumber,
                MangaName = mangaName
           };

           var page = _mapper.Map<Page>(pagedto);
           
           await _db.Pages.AddAsync(page);
           await _db.SaveChangesAsync();
        }
    }
}