using AutoMapper;
using MangaLibApp.Exceptions;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace MangaLibApp.Services;

public class AccountService : IAccountService
{
    private readonly MangaLibDbContext _db;
    private readonly IMapper _mapper;
    
    public AccountService(MangaLibDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }


    public async Task<AccountDto> GetUserDetails(string UserName)
    {
        var user = await _db.Users
            .Include(r => r.Role)
            .FirstOrDefaultAsync(u => u.UserName == UserName);

        if (user is null)
        {
            throw new NotFoundException("There's no user with this Id!");
        }

        return _mapper.Map<AccountDto>(user);
    }
}