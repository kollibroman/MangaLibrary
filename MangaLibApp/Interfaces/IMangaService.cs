using MangaLibApp.Models;

namespace MangaLibApp.Interfaces
{
    public interface IMangaService
    {
        IEnumerable<MangaDto> GetAll();
        MangaDto GetById(int id);
        void Create(CreateMangaDto dto);
        bool Update(int id, UpdateMangaDto dto);
        bool Delete(int id);
    }
}