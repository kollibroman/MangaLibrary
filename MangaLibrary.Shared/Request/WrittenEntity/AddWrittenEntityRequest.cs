namespace MangaLibrary.Shared.Request.WrittenEntity;

public record AddWrittenEntityRequest(string Title, string PublishedAt, DateTime UpdatedAt, string Description);