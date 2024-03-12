using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using MangaLibClient.Models;
using MangaLibClient.Services;
using Microsoft.AspNetCore.Components;

namespace MangaLibClient.Filter;

public class HttpClientDelegatingHandler : DelegatingHandler
{
    private readonly ITokenService _tokenService;
    private readonly NavigationManager _navigationManager;

    public HttpClientDelegatingHandler(ITokenService tokenService, NavigationManager navigationManager)
    {
        _tokenService = tokenService;
        _navigationManager = navigationManager;
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken ct)
    {
        var token = await _tokenService.GetAuthTokenAsync();
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await base.SendAsync(request, ct);

        if (response.StatusCode != HttpStatusCode.Unauthorized)
            return response;

        var refreshToken = await _tokenService.GetRefreshTokenAsync();
        var refreshRequest = new HttpRequestMessage(HttpMethod.Post, "users/refresh");
        refreshRequest.Content = JsonContent.Create(new AuthToken(token, refreshToken));
        var refreshResponse = await base.SendAsync(refreshRequest, ct);

        if (!refreshResponse.IsSuccessStatusCode
            || await refreshResponse.Content.ReadFromJsonAsync<AuthToken>(cancellationToken: ct) is not { } authToken)
        {
            await _tokenService.RemoveAuthTokenAsync();
            _navigationManager.NavigateTo("/", forceLoad: true);
            return response;
        }

        await _tokenService.SetTokensAsync(authToken.BearerToken, authToken.RefreshToken);
        var newResponse = await base.SendAsync(request, ct);
        if (response.StatusCode != HttpStatusCode.Unauthorized)
            return newResponse;

        await _tokenService.RemoveAuthTokenAsync();
        _navigationManager.NavigateTo("/", forceLoad: true);
        return newResponse;
    }
}