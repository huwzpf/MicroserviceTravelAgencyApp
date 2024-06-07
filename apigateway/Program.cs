using System.Threading.Channels;
using apigateway.Authentication;
using apigateway.Handlers;
using apigateway.Swagger;
using contracts;
using MassTransit;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using apigateway.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Load configuration
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: false)
    .AddEnvironmentVariables();

var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<AuthorizeCheckOperationFilter>();
    options.AddSecurityDefinition("Token", new OpenApiSecurityScheme
    {
        Description = "Token authentication.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "ApiKeyAuth"
    });
});

// Add MassTransit
builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetKebabCaseEndpointNameFormatter();
    
    busConfigurator.AddConsumer<TourReservedConsumer>();
    busConfigurator.AddConsumer<DiscountAddedConsumer>();
    
    busConfigurator.UsingRabbitMq((context, cfg) =>
    {
        var rabbitMQHost = configuration.GetConnectionString("RabbitMQHost");
        var rabbitMQUser = configuration.GetConnectionString("RabbitMQUser");
        var rabbitMQPassword = configuration.GetConnectionString("RabbitMQPassword");
        
        cfg.Host(rabbitMQHost, "/", h => {
            h.Username(rabbitMQUser);
            h.Password(rabbitMQPassword);
        });
        cfg.ConfigureEndpoints(context);
    });
});

// Register the channels and background services as singletons
builder.Services.AddSingleton(Channel.CreateUnbounded<TourReservedEvent>());
builder.Services.AddSingleton(Channel.CreateUnbounded<DiscountAddedEvent>());
builder.Services.AddSingleton<WebSocketController.BroadcastService<TourReservedEvent>>();
builder.Services.AddSingleton<WebSocketController.BroadcastService<DiscountAddedEvent>>();
builder.Services.AddHostedService(provider => provider.GetService<WebSocketController.BroadcastService<TourReservedEvent>>());
builder.Services.AddHostedService(provider => provider.GetService<WebSocketController.BroadcastService<DiscountAddedEvent>>());

builder.Services.AddAuthentication("Token")
    .AddScheme<BasicAuthenticationOptions, CustomAuthenticationHandler>("Token", null);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdmin", policy =>
        policy.RequireClaim("IsAdmin", "True"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", b =>
        b.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowAll");

// REENABLE LATER
// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }
var webSocketOptions = new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromMinutes(1)
};

app.UseWebSockets(webSocketOptions);
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
