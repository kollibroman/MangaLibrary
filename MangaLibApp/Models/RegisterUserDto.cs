using System.ComponentModel.DataAnnotations;

namespace MangaLibApp.Models;

public class RegisterUserDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    [MinLength(8)]
    public string Password { get; set; }
    public DateTime? DateOfBirth { get; set; }
}