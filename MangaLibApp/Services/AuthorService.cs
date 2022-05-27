using System.Reflection.Metadata.Ecma335;
using System.Xml;
using AutoMapper;
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

        public IEnumerable<AuthorDto> GetAll()
        {
            var author = _db.Authors.ToList();
            return _mapper.Map<IEnumerable<AuthorDto>>(author);
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

            author.Name = dto.Name;
            author.Surname = dto.Surname;
            author.UpdatedAt = DateTime.Now;
            author.WrittenMangas = dto.WrittenMangas;
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