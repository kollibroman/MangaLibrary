using Blazored.LocalStorage;

namespace MangaLibClient.Services;

public interface ITokenService
{
    Task<string> GetAuthTokenAsync();
    Task<string> GetRefreshTokenAsync();
    Task RemoveAuthTokenAsync();
    Task SetTokensAsync(string bearerToken, string refreshToken);
}

public class TokenService : ITokenService
{
    private readonly ILocalStorageService _localStorageService;
    private const string AuthTokenKey = "bearerToken";
    private const string RefreshTokenKey = "refreshToken";

    public TokenService(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }

    public async Task SetTokensAsync(string bearerToken, string refreshToken)
    {
        await _localStorageService.SetItemAsync(AuthTokenKey, bearerToken);
        await _localStorageService.SetItemAsync(RefreshTokenKey, refreshToken);
    }

    public async Task<string> GetAuthTokenAsync()
    {
        return await _localStorageService.GetItemAsync<string>(AuthTokenKey);
    }

    public async Task<string> GetRefreshTokenAsync()
    {
        return await _localStorageService.GetItemAsync<string>(RefreshTokenKey);
    }

    public async Task RemoveAuthTokenAsync()
    {
        await _localStorageService.RemoveItemAsync(AuthTokenKey);
    }
}