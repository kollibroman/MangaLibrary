using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAll();
        AuthorDto GetById(int id);
        void Create(CreateAuthorDto dto);
        bool Update(int id, UpdateAuthorDto dto);
        bool Delete(int id);
    }
}