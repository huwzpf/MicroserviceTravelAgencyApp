# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /transportservice /source/transportservice
COPY /contracts /source/contracts

WORKDIR /source/transportservice

RUN dotnet restore "./transportservice.csproj"
RUN dotnet publish "./transportservice.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "transportservice.dll"]