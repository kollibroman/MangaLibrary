using AutoMapper;
using MangaLibApp.Filter;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<CategoryDto>> GetAll(PaginationFilter filter)
        {
           var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var categories = await  _db.Categories
            .Include(m => m.Mangas)
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public Task<int> GetTotalRecords()
        {
            return _db.Categories.CountAsync();
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var category = await _db.Categories.SingleOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<bool> Update(int id, UpdateCategoryDto dto)
        {
            var category = await _db.Categories.SingleOrDefaultAsync(i => i.Id == id);

            if(category is null) 
                return false;

            //category.Mangas.AddRange(dto.Mangas);
            category.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();

            return true;
        }
        public async Task Create(CreateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);
            await _db.AddAsync(category);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var category = await _db.Categories.SingleOrDefaultAsync(i => i.Id == id);

            if(category is null)
                return false;

            _db.Remove(category);
            await _db.SaveChangesAsync();
            return true;
        }

    }
}