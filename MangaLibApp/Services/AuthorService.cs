using System.Reflection.Metadata.Ecma335;
using System.Xml;
using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;

        public AuthorService(MangaLibDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }

        public Task<int> GetTotalRecords()
        {
            return _db.Authors.CountAsync();
        }

        public async Task<List<AuthorDto>> GetAll(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var author = await _db.Authors
            .Include(w => w.WrittenMangas)
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
            return _mapper.Map<List<AuthorDto>>(author);
        }

        public async Task<AuthorDto> GetById(int id)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id);

            return _mapper.Map<AuthorDto>(author);
        }

        public async Task<bool> Update(int id, UpdateAuthorDto dto)
        {
           var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id);

           if(author is null)
            return false;

            author.UpdatedAt = DateTime.Now;

            if(dto.WrittenMangas is not null)
            {
                author.WrittenMangas.AddRange(_mapper.Map<List<Manga>>(dto.WrittenMangas));
            }
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task Create(CreateAuthorDto dto)
        {
            var author = _mapper.Map<Author>(dto);
            await _db.AddAsync(author);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id);

            if(author is null)
                return false;
            
            _db.Remove(author);
            await _db.SaveChangesAsync();
            return true;        
        }
    }
}