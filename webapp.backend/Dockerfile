FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
EXPOSE 80
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY ["webapp.backend.csproj", "./backend/"]
RUN dotnet restore "backend/webapp.backend.csproj"
COPY . .
RUN dotnet publish "webapp.backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "webapp.backend.dll"]