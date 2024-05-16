# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /hotelservice /source/hotelservice
COPY /contracts /source/contracts

WORKDIR /source/hotelservice

RUN dotnet restore "./hotelservice.csproj"
RUN dotnet publish "./hotelservice.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "hotelservice.dll"]