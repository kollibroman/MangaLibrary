using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MangaLibCore.Entities;

public class Account
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public EntityType Type { get; set; }
    public TYPE Type1 { get; set; }
}