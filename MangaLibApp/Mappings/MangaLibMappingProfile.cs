using AutoMapper;
using MangaLibApp.Models;
using MangaLibCore.Entities;

namespace MangaLibApp.Mappings
{
    public class MangaLibMappingProfile : Profile
    {
        public MangaLibMappingProfile()
        {
            CreateMap<Manga, MangaDto>();
            CreateMap<Author, AuthorDto>();
            CreateMap<Category, CategoryDto>();
        }
    }
}