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
            CreateMap<Cover, CoverDto>();
            CreateMap<Chapter, ChapterDto>();
            CreateMap<Page, PageDto>();
            
            CreateMap<CreateAuthorDto, Author>();
            CreateMap<CreateMangaDto, Manga>()
                .ForMember(p => p.PublishedAt, c => c.MapFrom(a => a.AddedAt));

            
            CreateMap<UpdateAuthorDto, Author>();
            CreateMap<UpdateMangaDto, Manga>();

            CreateMap<UploadChapterDto, Chapter>();
            CreateMap<UploadPageDto, Page>();
            CreateMap<UploadCoverDto, Cover>();
        }
    }
}