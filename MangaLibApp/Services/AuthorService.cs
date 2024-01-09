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

        public Task<int> GetTotalRecords(CancellationToken ct)
        {
            return _db.Authors.CountAsync(ct);
        }

        public async Task<List<AuthorDto>> GetAll(PaginationFilter filter, CancellationToken ct)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var author = await _db.Authors
            .Include(w => w.WrittenMangas)
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync(ct);
            return _mapper.Map<List<AuthorDto>>(author);
        }

        public async Task<AuthorDto> GetById(int id, CancellationToken ct)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id, ct);

            return _mapper.Map<AuthorDto>(author);
        }

        public async Task<bool> Update(int id, UpdateAuthorDto dto, CancellationToken ct)
        {
           var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id, ct);

           if (author is null)
           {
               return false;
           }

           author.UpdatedAt = DateTime.Now;
           
           author.WrittenMangas.AddRange(_mapper.Map<List<Manga>>(dto.WrittenMangas));
            
           await _db.SaveChangesAsync(ct);
           return true;
        }
        public async Task Create(CreateAuthorDto dto, CancellationToken ct)
        {
            var author = _mapper.Map<Author>(dto);
            await _db.AddAsync(author);
            await _db.SaveChangesAsync(ct);
        }

        public async Task<bool> Delete(int id, CancellationToken ct)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(i => i.Id == id, ct);

            if(author is null)
                return false;
            
            _db.Remove(author);
            await _db.SaveChangesAsync(ct);
            return true;        
        }
    }
}