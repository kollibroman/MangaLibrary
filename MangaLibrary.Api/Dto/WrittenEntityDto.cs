namespace MangaLibrary.Api.Dto;

public class WrittenEntityDto
{
    public required string Title { get; init; }
    public required string PublishedAt { get; init; }
    public required DateTime UpdatedAt { get; init; }
    public required string Description { get; init; }
    public required int ChaptersCount { get; init; }
}