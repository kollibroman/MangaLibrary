using AutoMapper;
using MangaLibrary.Api.Dto;
using MangaLibrary.Api.Persistence.Models;
using MangaLibrary.Shared.Request.Author;
using MangaLibrary.Shared.Request.WrittenEntity;

namespace MangaLibrary.Api.Mappings;

public class MapConfig : Profile
{
    public MapConfig()
    {
        CreateMap<Author, AuthorDto>();
        CreateMap<WrittenEntity, WrittenEntityDto>();

        CreateMap<AddAuthorRequest, Author>();
        CreateMap<AddWrittenEntityRequest, WrittenEntity> ();
    }
}