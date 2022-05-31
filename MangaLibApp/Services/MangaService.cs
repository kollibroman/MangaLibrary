using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;

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
        public IEnumerable<MangaDto> GetAll()
        {
            var mangas = _dbcontext.Mangas.ToList();
            return _mapper.Map<IEnumerable<MangaDto>>(mangas);
        }

        public MangaDto GetById(int id)
        {
            var manga = _dbcontext.Mangas.SingleOrDefault(i => i.Id == id);
            return _mapper.Map<MangaDto>(manga);
        }

        public bool Update(int id, UpdateMangaDto dto)
        {
            var manga = _dbcontext.Mangas.FirstOrDefault(i => i.Id == id);

            if(manga is null) 
                return false;

            manga.Title = dto.Title;
            manga.UpdatedAt = DateTime.Now;
            manga.PagesCount = dto.PagesCount;
            manga.Author = dto.Author;
            manga.ChaptersCount = dto.ChaptersCount;
            manga.Chapters = dto.Chapters;
           _dbcontext.SaveChanges();
            
            return true;
        }
        public void Create(CreateMangaDto dto)
        {
           var manga = _mapper.Map<Manga>(dto);

           _dbcontext.Add(manga);
           _dbcontext.SaveChanges();
        }

        public bool Delete(int id)
        {
            var manga = _dbcontext.Mangas.SingleOrDefault(i => i.Id == id);

            if(manga is null) 
                return false;

            _dbcontext.Remove(manga);
            _dbcontext.SaveChanges();
            return true;
        }

    }
}