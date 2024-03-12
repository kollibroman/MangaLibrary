using MangaLibClient.ApiClient;
using Microsoft.AspNetCore.Components;

namespace MangaLibClient.Pages;

public partial class Home
{
    [Inject] private IApiClient ApiClient { get; set; } = null!;
    private string? PingResponse { get; set; }
    
    public async Task GetPingAsync()
    {
        var resp = await ApiClient.PingAsync();
        PingResponse = resp.ToString()!;
    }
}