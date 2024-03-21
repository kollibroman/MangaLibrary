using AutoMapper;
using MangaLibrary.Api.Dto;
using MangaLibrary.Api.Persistence;
using MangaLibrary.Api.Services;
using MangaLibrary.Shared.Request.Author;
using MangaLibrary.Shared.Request.WrittenEntity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MangaLibrary.Api.Api;

public static class WrittenEntityController
{
    public static void MapWrittenEntities(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("/api/writtenEntities");

        group.WithTags("WrittenEntities");

        group.MapGet("/", GetAll);
        group.MapGet("/{writtenEntityId:int}", GetWrittenEntityAsync);
        group.MapPost("/", AddWrittenEntityAsync);
        group.MapPatch("/{writtenEntityId:int}", UpdateWrittenEntityAsync);
        group.MapDelete("/{writtenEntityId:int}", RemoveWrittenEntityAsync);
    }
    
    private static Results<BadRequest, Ok<IAsyncEnumerable<WrittenEntityDto>>> GetAll(
        [FromServices] MangaLibContext dbContext, [FromServices] IMapper mapper, CancellationToken ct)
        => WrittenEntityService.GetAll(dbContext, mapper,ct);

    private static async Task<Results<NotFound, Ok<WrittenEntityDto>>> GetWrittenEntityAsync(
        [FromServices] MangaLibContext dbContext, [FromRoute] int authorId, [FromServices] IMapper mapper, CancellationToken ct)
        => await WrittenEntityService.GetAuthorAsync(dbContext, authorId, mapper, ct);

    private static async Task<Results<Created, BadRequest>> AddWrittenEntityAsync([FromServices] MangaLibContext dbContext,
        AddWrittenEntityRequest request, [FromServices] IMapper mapper, CancellationToken ct)
        => await WrittenEntityService.AddAsync(dbContext, request, mapper, ct);

    private static async Task<Results<NotFound, NoContent>> UpdateWrittenEntityAsync([FromServices] MangaLibContext dbContext,
        [FromRoute] int writtenEntityId, UpdateWrittenEntityRequest request, [FromServices] IMapper mapper, CancellationToken ct)
        => await WrittenEntityService.UpdateAuthorAsync(dbContext, writtenEntityId, request, mapper, ct);

    private static async Task<Results<NotFound, NoContent>> RemoveWrittenEntityAsync([FromServices] MangaLibContext dbContext,
        [FromRoute] int writtenEntityId, CancellationToken ct)
        => await WrittenEntityService.RemoveAuthorAsync(dbContext, writtenEntityId, ct);
}