using MangaLibCore;
using MangaLibCore.Entities;
using MangaLibCore.Interfaces;

namespace MangaLibLogic.Repositories
{
    public class AuthorRepo : IAuthorRepo
    {
        private readonly MangaLibDbContext _dbcontext;

        public AuthorRepo(MangaLibDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _dbcontext.Authors.ToList();
        }

        public Author GetAuthorId(int id)
        {
            return _dbcontext.Authors.SingleOrDefault(i => i.Id == id);
        }


        public void UpdateAuthor(int id, Author author)
        {
            var UpdateAuthor = _dbcontext.Authors.SingleOrDefault(i => i.Id == id);
            UpdateAuthor.Name = author.Name;
            UpdateAuthor.Surname = author.Surname;
            UpdateAuthor.UpdatedAt = DateTime.Now;
            UpdateAuthor.WrittenMangas = author.WrittenMangas;
        }

        public Author AddAuthor(Author author)
        {
            _dbcontext.Authors.Add(author);
            return author;
        }

        public void DeleteAuthor(int id)
        {
            var author = _dbcontext.Authors.SingleOrDefault(i => i.Id == id);
           _dbcontext.Remove(author);
        }
    }
}