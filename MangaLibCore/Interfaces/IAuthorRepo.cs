using System.Net.Security;
using MangaLibCore.Entities;

namespace MangaLibCore.Interfaces
{
    public interface IAuthorRepo
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthorId(int id);
        Author AddAuthor(Author author);
        void UpdateAuthor(int id, Author author);
        void DeleteAuthor(int id);
    }
}