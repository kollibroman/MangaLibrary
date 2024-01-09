using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class MangaService : IMangaService
    {
        private readonly MangaLibDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ITagService _service;

        public MangaService(MangaLibDbContext dbContext, IMapper  mapper, ITagService service)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _service = service;
        }
        public async Task<List<MangaDto>> GetAll(PaginationFilter filter, CancellationToken ct)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            
            var mangas = await _dbContext.Mangas
            .Include(c => c.Cover)
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync(ct);
            
            return _mapper.Map<List<MangaDto>>(mangas);
        }

        public Task<int> GetTotalRecords(CancellationToken ct)
        {
            return _dbContext.Mangas.CountAsync(ct);
        }

        public async Task<MangaDto> GetById(int id, CancellationToken ct)
        {
            var manga = await _dbContext.Mangas
            .Include(c => c.Cover)
            .Where(c => c.Cover.MangaName == c.Title)
            .SingleOrDefaultAsync(i => i.Id == id, ct);
            
            return _mapper.Map<MangaDto>(manga);
        }

        public async Task<bool> Update(int id, UpdateMangaDto dto, CancellationToken ct)
        {
            var manga = await _dbContext.Mangas.FirstOrDefaultAsync(i => i.Id == id, ct);

            if(manga is null) 
                return false;

            manga.Title = dto.Title;
            manga.UpdatedAt = DateTime.Now;
            manga.ChaptersCount = dto.ChaptersCount;
            await _dbContext.SaveChangesAsync(ct);
            
            return true;
        }
        public async Task Create(CreateMangaDto dto, CancellationToken ct)
        {

           var manga = _mapper.Map<Manga>(dto);

           await _dbContext.AddAsync(manga, ct);
           await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<bool> Delete(int id, CancellationToken ct)
        {
            var manga = await  _dbContext.Mangas.SingleOrDefaultAsync(i => i.Id == id, ct);

            if(manga is null) 
                return false;

            _dbContext.Remove(manga);
            await _dbContext.SaveChangesAsync(ct);
            return true;
        }

    }
}