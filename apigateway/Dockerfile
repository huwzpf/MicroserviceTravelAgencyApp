# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY /apigateway /source/apigateway
COPY /contracts /source/contracts

WORKDIR /source/apigateway

RUN dotnet restore "./apigateway.csproj"
RUN dotnet publish "./apigateway.csproj" -c release -o /out --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /out ./

EXPOSE 80

# Set the entry point for the application
ENTRYPOINT ["dotnet", "apigateway.dll"]
