using System.ComponentModel;
using MangaLibCore;
using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibLogic.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly MangaLibDbContext _dbcontext;
        public CategoryRepo(MangaLibDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Category> GetCategories()
        {
           return _dbcontext.Categories.ToList();
        }

        public Category GetCategoryId(int id)
        {
            return _dbcontext.Categories.SingleOrDefault(i => i.Id == id)!;
        }

        public void UpdateCategory(int id, Category category)
        {
           var Updatedcategory = _dbcontext.Categories.FirstOrDefault(i => i.Id == id);
           Updatedcategory.Name = category.Name;
           Updatedcategory.Mangas = category.Mangas;
           Updatedcategory.UpdatedAt = DateTime.Now;
        }
        public Category AddCategory(Category category)
        {
            _dbcontext.Categories.Add(category);
            return category;
        }

        public void DeleteCategory(int id)
        {
            var category = _dbcontext.Categories.Single(i => i.Id == id);
            _dbcontext.Remove(category);
        }
    }
}