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
            
            CreateMap<CreateAuthorDto, Author>();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<CreateMangaDto, Manga>();
            
            CreateMap<UpdateAuthorDto, Author>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<UpdateMangaDto, Manga>();
        }
    }
}