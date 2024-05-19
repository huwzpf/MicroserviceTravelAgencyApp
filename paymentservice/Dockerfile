# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /paymentservice /source/paymentservice
COPY /contracts /source/contracts

WORKDIR /source/paymentservice

RUN dotnet restore "./paymentservice.csproj"
RUN dotnet publish "./paymentservice.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "paymentservice.dll"]