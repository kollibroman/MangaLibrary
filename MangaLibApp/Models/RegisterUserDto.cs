using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models;

public class RegisterUserDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public DateTime? DateOfBirth { get; set; }
}