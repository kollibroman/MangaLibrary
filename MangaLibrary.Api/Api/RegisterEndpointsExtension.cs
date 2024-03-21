namespace MangaLibrary.Api.Api;

public static class RegisterEndpointsExtension
{
    public static void RegisterApiEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapAuthors();
        builder.MapWrittenEntities();
    }
}