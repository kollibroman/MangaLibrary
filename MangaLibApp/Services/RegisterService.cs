using MangaLibApp.Interfaces;
using MangaLibApp.Mappings;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangaLibApp.Services;

public class RegisterService : IRegisterService
{
    private readonly MangaLibDbContext _db;
    private readonly IPasswordHasher<User> _hasher;

    public RegisterService(MangaLibDbContext db, IPasswordHasher<User> hasher)
    {
        _db = db;
        _hasher = hasher;
    }
    public async Task RegisterUser(RegisterUserDto dto)
    {
        var newUser = new User()
        {
            Email = dto.Email,
            DateOfBirth = dto.DateOfBirth,
            PasswordHash = dto.Password
        };
        var hashedPassword = _hasher.HashPassword(newUser, dto.Password);
        newUser.PasswordHash = hashedPassword;

        await _db.Users.AddAsync(newUser);
        await _db.SaveChangesAsync();
    }
}