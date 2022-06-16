using System.Reflection.Metadata.Ecma335;
using System.Xml;
using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;

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

        public int GetTotalRecords()
        {
            return _db.Authors.Count();
        }

        public List<AuthorDto> GetAll(PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var author = _db.Authors.
            Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToList();
            return _mapper.Map<List<AuthorDto>>(author);
        }

        public AuthorDto GetById(int id)
        {
            var author = _db.Authors.SingleOrDefault(i => i.Id == id);

            return _mapper.Map<AuthorDto>(author);
        }

        public bool Update(int id, UpdateAuthorDto dto)
        {
           var author = _db.Authors.SingleOrDefault(i => i.Id == id);

           if(author is null)
            return false;

            author.UpdatedAt = DateTime.Now;

            if(dto.WrittenMangas is not null)
            {
                 author.WrittenMangas.AddRange(dto.WrittenMangas);
            }
            _db.SaveChanges();
            return true;
        }
        public void Create(CreateAuthorDto dto)
        {
            var author = _mapper.Map<Author>(dto);
            _db.Add(author);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var author = _db.Authors.SingleOrDefault(i => i.Id == id);

            if(author is null)
                return false;
            
            _db.Remove(author);
            _db.SaveChanges();
            return true;        
        }
    }
}