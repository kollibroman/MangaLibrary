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
            CreateMap<CreateMangaDto, Manga>()
                .ForMember(p => p.PublishedAt, c => c.MapFrom(a => a.AddedAt));

            
            CreateMap<UpdateAuthorDto, Author>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<UpdateMangaDto, Manga>();

            CreateMap<UploadCoverDto, Cover>();
        }
    }
}