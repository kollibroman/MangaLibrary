using AutoMapper;
using MangaLibrary.Api.Dto;
using MangaLibrary.Api.Extensions;
using MangaLibrary.Api.Persistence;
using MangaLibrary.Api.Persistence.Models;
using MangaLibrary.Shared.Request.Author;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace MangaLibrary.Api.Services;

public class AuthorService
{
    public static Results<BadRequest, Ok<IAsyncEnumerable<AuthorDto>>> GetAll(MangaLibContext dbContext, IMapper mapper,
        CancellationToken ct)
    {
        var authors = dbContext.Authors.ToAsyncEnumerable(ct);

        return TypedResults.Ok(mapper.Map<IAsyncEnumerable<AuthorDto>>(authors));
    }

    public static async Task<Results<NotFound, Ok<AuthorDto>>> GetAuthorAsync(MangaLibContext dbContext, int authorId,
        IMapper mapper, CancellationToken ct)
    {
        var author = await dbContext.Authors.FirstOrDefaultAsync(a => a.Id == authorId, ct);

        if (author is null)
        {
            return TypedResults.NotFound();
        }

        return TypedResults.Ok(mapper.Map<AuthorDto>(author));
    }

    public static async Task<Results<Created, BadRequest>> AddAsync(MangaLibContext dbContext,
        AddAuthorRequest request, IMapper mapper, CancellationToken ct)
    {
        await dbContext.Authors.AddAsync(mapper.Map<Author>(request), ct);
        await dbContext.SaveChangesAsync(ct);

        return TypedResults.Created();
    }

    public static async Task<Results<NotFound, NoContent>> UpdateAuthorAsync(MangaLibContext dbContext,
        int authorId, UpdateAuthorRequest request, IMapper mapper, CancellationToken ct)
    {
        var author = await dbContext.Authors.FirstOrDefaultAsync(a => a.Id == authorId, ct);

        if (author is null)
        {
            return TypedResults.NotFound();
        }
        
        author.Name = request.Name;
        author.Surname = request.Surname;

        await dbContext.SaveChangesAsync(ct);

        return TypedResults.NoContent();
    }

    public static async Task<Results<NotFound, NoContent>> RemoveAuthorAsync(MangaLibContext dbContext, int authorId,
        CancellationToken ct)
    {
        var author = await dbContext.Authors.FirstOrDefaultAsync(a => a.Id == authorId, ct);

        if (author is null)
        {
            return TypedResults.NotFound();
        }

        dbContext.Authors.Remove(author);
        await dbContext.SaveChangesAsync(ct);

        return TypedResults.NoContent();
    }
}