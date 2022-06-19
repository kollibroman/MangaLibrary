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
        private readonly MangaLibDbContext _dbcontext;
        private readonly IMapper _mapper;

        public MangaService(MangaLibDbContext dbcontext, IMapper  mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<List<MangaDto>> GetAll(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var mangas = await _dbcontext.Mangas.
            Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
            return _mapper.Map<List<MangaDto>>(mangas);
        }

        public Task<int> GetTotalRecords()
        {
            return _dbcontext.Mangas.CountAsync();
        }

        public async Task<MangaDto> GetById(int id)
        {
            var manga = await _dbcontext.Mangas
            .SingleOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<MangaDto>(manga);
        }

        public async Task<bool> Update(int id, UpdateMangaDto dto)
        {
            var manga = await _dbcontext.Mangas.FirstOrDefaultAsync(i => i.Id == id);

            if(manga is null) 
                return false;

            manga.Title = dto.Title;
            manga.UpdatedAt = DateTime.Now;
            manga.Author = dto.Author;
            manga.ChaptersCount = dto.ChaptersCount;
            await _dbcontext.SaveChangesAsync();
            
            return true;
        }
        public async Task Create(CreateMangaDto dto)
        {
           var manga = _mapper.Map<Manga>(dto);

           await _dbcontext.AddAsync(manga);
           await _dbcontext.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var manga = await  _dbcontext.Mangas.SingleOrDefaultAsync(i => i.Id == id);

            if(manga is null) 
                return false;

            _dbcontext.Remove(manga);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

    }
}