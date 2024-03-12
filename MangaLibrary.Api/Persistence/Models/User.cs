using Microsoft.AspNetCore.Identity;

namespace MangaLibrary.Api.Persistence.Models;

public class User : IdentityUser<Guid>
{
    public bool IsActive { get; set; }
}