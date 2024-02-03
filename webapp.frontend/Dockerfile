FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
EXPOSE 80
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY ["webapp.frontend.csproj", "./frontend/"]
RUN dotnet restore "frontend/webapp.frontend.csproj"
COPY . .
RUN dotnet publish "webapp.frontend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "webapp.frontend.dll"]