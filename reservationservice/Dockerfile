# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /reservationservice /source/reservationservice
COPY /contracts /source/contracts

WORKDIR /source/reservationservice

RUN dotnet restore "./reservationservice.csproj"
RUN dotnet publish "./reservationservice.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "reservationservice.dll"]