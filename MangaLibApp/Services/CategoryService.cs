using AutoMapper;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;

namespace MangaLibApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly MangaLibDbContext _db;
        private readonly IMapper _mapper;

        public CategoryService(MangaLibDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public IEnumerable<CategoryDto> GetAll()
        {
            var category = _db.Categories.ToList();
            return _mapper.Map<IEnumerable<CategoryDto>>(category);
        }

        public CategoryDto GetById(int id)
        {
            var category = _db.Categories.SingleOrDefault(i => i.Id == id);
            return _mapper.Map<CategoryDto>(category);
        }

        public bool Update(int id, UpdateCategoryDto dto)
        {
            var category = _db.Categories.SingleOrDefault(i => i.Id == id);

            if(category is null) 
                return false;

            category.Mangas.AddRange(dto.Mangas);
            category.UpdatedAt = DateTime.Now;
            _db.SaveChanges();

            return true;
        }
        public void Create(CreateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            _db.Add(category);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var category = _db.Categories.SingleOrDefault(i => i.Id == id);

            if(category is null)
                return false;

            _db.Remove(category);
            _db.SaveChanges();
            return true;
        }

    }
}