# =========================
# BUILD STAGE
# =========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Solution and projects
COPY StudentDemo.sln ./
COPY StudentDemo.Core ./StudentDemo.Core
COPY StudentDemo.Data ./StudentDemo.Data
COPY StudentDemo.API ./StudentDemo.API

WORKDIR /src/StudentDemo.API

RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# =========================
# RUNTIME STAGE
# =========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "StudentDemo.API.dll"]
