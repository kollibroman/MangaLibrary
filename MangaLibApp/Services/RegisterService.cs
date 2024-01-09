using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MangaLibApp.Exceptions;
using MangaLibApp.Interfaces;
using MangaLibApp.Models;
using MangaLibCore;
using MangaLibCore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MangaLibApp.Services;

public class RegisterService : IRegisterService
{
    private readonly MangaLibDbContext _db;
    private readonly IPasswordHasher<User> _hasher;
    private readonly AuthenticationSettings _authSettings;

    public RegisterService(MangaLibDbContext db, IPasswordHasher<User> hasher, AuthenticationSettings authSettings)
    {
        _db = db;
        _hasher = hasher;
        _authSettings = authSettings;
    }
    public async Task RegisterUser(RegisterUserDto dto, CancellationToken ct)
    {
        var newUser = new User()
        {
            Email = dto.Email,
            DateOfBirth = dto.DateOfBirth,
            UserName = dto.UserName,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            RoleId = 2,
        };
        var hashedPassword = _hasher.HashPassword(newUser, dto.Password);
        newUser.PasswordHash = hashedPassword;

        await _db.Users.AddAsync(newUser, ct);
        await _db.SaveChangesAsync(ct);
    }

    public async Task<string> GenerateKJwt(LoginDto dto, CancellationToken ct)
    {
        var user = await _db.Users
            .Include(r => r.Role)
            .FirstOrDefaultAsync(e => e.Email == dto.Email, ct);

        if (user is null)
        {
            throw new BadRequestException("Invalid UserName or Password");
        }

        var result = _hasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);
        if (result == PasswordVerificationResult.Failed)
        {
            throw new BadRequestException("Invalid UserName or Password");
        }

        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            new Claim(ClaimTypes.Role, $"{user.Role.Name}"),
            new Claim("DateOfBirth", user.DateOfBirth!.Value.ToString("yyyy-MM-dd")),
        };

        var key = new SymmetricSecurityKey((Encoding.UTF8.GetBytes(_authSettings.JwtKey)));
        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.Now.AddDays(_authSettings.JwtExpireDays);

        var token = new JwtSecurityToken(_authSettings.JwtIssuer, _authSettings.JwtIssuer, 
            claims, expires: expires, signingCredentials: cred);

        var tokenHandler = new JwtSecurityTokenHandler();
        return tokenHandler.WriteToken(token);
    }
}