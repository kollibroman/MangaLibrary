namespace MangaLibrary.Api.Dto;

public class AuthorDto
{
    public required string Name { get; init; }
    public required string Surname { get; init; }
    
    public List<WrittenEntityDto>? WrittenEntities { get; init; }
}