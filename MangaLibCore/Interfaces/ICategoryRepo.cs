using MangaLibCore.Entities;

namespace MangaLibCore.Interfaces
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryId(int id);
        Category AddCategory(Category category);
        void UpdateCategory(int id, Category category);
        void DeleteCategory(int id);
    }
}