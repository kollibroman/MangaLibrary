using AutoMapper;
using MangaLibrary.Api.Dto;
using MangaLibrary.Api.Extensions;
using MangaLibrary.Api.Persistence;
using MangaLibrary.Api.Persistence.Models;
using MangaLibrary.Shared.Request.WrittenEntity;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace MangaLibrary.Api.Services;

public class WrittenEntityService
{
    public static Results<BadRequest, Ok<IAsyncEnumerable<WrittenEntityDto>>> GetAll(MangaLibContext dbContext, IMapper mapper,
        CancellationToken ct)
    {
        var writtenEntities = dbContext.WrittenEntities.ToAsyncEnumerable(ct);

        return TypedResults.Ok(mapper.Map<IAsyncEnumerable<WrittenEntityDto>>(writtenEntities));
    }

    public static async Task<Results<NotFound, Ok<WrittenEntityDto>>> GetAuthorAsync(MangaLibContext dbContext, int writtenEntityId,
        IMapper mapper, CancellationToken ct)
    {
        var entity = await dbContext.WrittenEntities.FirstOrDefaultAsync(a => a.Id == writtenEntityId, ct);

        if (entity is null)
        {
            return TypedResults.NotFound();
        }

        return TypedResults.Ok(mapper.Map<WrittenEntityDto>(entity));
    }

    public static async Task<Results<Created, BadRequest>> AddAsync(MangaLibContext dbContext,
        AddWrittenEntityRequest request, IMapper mapper, CancellationToken ct)
    {
        await dbContext.WrittenEntities.AddAsync(mapper.Map<WrittenEntity>(request), ct);
        await dbContext.SaveChangesAsync(ct);

        return TypedResults.Created();
    }

    public static async Task<Results<NotFound, NoContent>> UpdateAuthorAsync(MangaLibContext dbContext,
        int writtenEntityId, UpdateWrittenEntityRequest request, IMapper mapper, CancellationToken ct)
    {
        var entity = await dbContext.WrittenEntities.FirstOrDefaultAsync(a => a.Id == writtenEntityId, ct);

        if (entity is null)
        {
            return TypedResults.NotFound();
        }
        
        entity.Title = request.Title;
        entity.Description = request.Description;
        entity.UpdatedAt = DateTime.Now;

        await dbContext.SaveChangesAsync(ct);

        return TypedResults.NoContent();
    }

    public static async Task<Results<NotFound, NoContent>> RemoveAuthorAsync(MangaLibContext dbContext, int writtenEntityId,
        CancellationToken ct)
    {
        var entity = await dbContext.WrittenEntities.FirstOrDefaultAsync(a => a.Id == writtenEntityId, ct);

        if (entity is null)
        {
            return TypedResults.NotFound();
        }

        dbContext.WrittenEntities.Remove(entity);
        await dbContext.SaveChangesAsync(ct);

        return TypedResults.NoContent();
    }
}