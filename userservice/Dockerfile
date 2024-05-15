# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /userservice /source/userservice
COPY /contracts /source/contracts

WORKDIR /source/userservice

RUN dotnet restore "./userservice.csproj"
RUN dotnet publish "./userservice.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "userservice.dll"]