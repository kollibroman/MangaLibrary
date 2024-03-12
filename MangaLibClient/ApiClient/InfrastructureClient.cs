using Refit;

namespace MangaLibClient.ApiClient;

public partial interface IApiClient
{
    [Get(("/infrastructure/ping"))]
    public Task<IApiResponse> PingAsync();
}