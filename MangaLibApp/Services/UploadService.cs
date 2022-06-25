using AutoMapper;
using MangaLibApp.Helpers;
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
        private readonly IApiConverter _converter;

        public UploadService(MangaLibDbContext db, IMapper mapper, IApiConverter converter)
        {
            _db = db;
            _mapper = mapper;
            _converter = converter;
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
                    Id = i,
                    PageNumber = i,
                    PageData = pageDatas.ElementAt(i - 1)
                };
                pages.Add(page);
            }

            var chapterDto = new UploadChapterDto
            {
                Id = 1,
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

        public async Task UploadPageAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}