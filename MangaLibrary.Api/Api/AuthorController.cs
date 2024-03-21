using AutoMapper;
using MangaLibrary.Api.Dto;
using MangaLibrary.Api.Persistence;
using MangaLibrary.Api.Services;
using MangaLibrary.Shared.Request.Author;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibrary.Api.Api;

public static class AuthorController
{
    public static void MapAuthors(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/authors");

        group.WithTags("Authors");

        group.MapGet("/", GetAll);
        group.MapPost("/", AddAuthorAsync);
        group.MapPatch("/{authorId:int}", UpdateAuthorAsync);
        group.MapDelete("/{authorId:int}", RemoveAuthorAsync);
    }

    private static Results<BadRequest, Ok<IAsyncEnumerable<AuthorDto>>> GetAll(
        [FromServices] MangaLibContext dbContext, [FromServices] IMapper mapper, CancellationToken ct)
        => AuthorService.GetAll(dbContext, mapper,ct);

    private static async Task<Results<NotFound, Ok<AuthorDto>>> GetAuthorAsync(
        [FromServices] MangaLibContext dbContext, [FromRoute] int authorId, [FromServices] IMapper mapper, CancellationToken ct)
        => await AuthorService.GetAuthorAsync(dbContext, authorId, mapper, ct);

    private static async Task<Results<Created, BadRequest>> AddAuthorAsync([FromServices] MangaLibContext dbContext,
        AddAuthorRequest request, [FromServices] IMapper mapper, CancellationToken ct)
        => await AuthorService.AddAsync(dbContext, request, mapper, ct);

    private static async Task<Results<NotFound, NoContent>> UpdateAuthorAsync([FromServices] MangaLibContext dbContext,
        int authorId, UpdateAuthorRequest request, [FromServices] IMapper mapper, CancellationToken ct)
        => await AuthorService.UpdateAuthorAsync(dbContext, authorId, request, mapper, ct);

    private static async Task<Results<NotFound, NoContent>> RemoveAuthorAsync([FromServices] MangaLibContext dbContext,
        int authorId, CancellationToken ct)
        => await AuthorService.RemoveAuthorAsync(dbContext, authorId, ct);

}