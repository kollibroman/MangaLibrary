FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MangaLibrary.Client/MangaLibrary.Client.csproj", "MangaLibrary.Client/"]
COPY ["MangaLibrary.Shared/MangaLibrary.Shared.csproj", "MangaLibrary.Shared/"]
RUN dotnet restore "MangaLibrary.Client/MangaLibrary.Client.csproj"
COPY . .
WORKDIR "/src/MangaLibrary.Client"
RUN dotnet build "MangaLibrary.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MangaLibrary.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MangaLibrary.Client.dll"]
