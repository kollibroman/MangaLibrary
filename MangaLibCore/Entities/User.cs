namespace MangaLibCore.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string PasswordHash { get; set; }
}