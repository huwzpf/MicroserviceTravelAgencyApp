using apigateway.Authentication;
using apigateway.Swagger;
using MassTransit;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

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
        Name = "Authorization", // Nagłówek, w którym znajduje się token
        In = ParameterLocation.Header, // Gdzie znajduje się token: w nagłówku
        Type = SecuritySchemeType.ApiKey, // Typ uwierzytelniania (ApiKey w przypadku nagłówka Authorization)
        Scheme = "ApiKeyAuth" // Nazwa schematu uwierzytelniania
    });
});

// Add MassTransit
builder.Services.AddMassTransit(busConfigurator =>
{
    busConfigurator.SetKebabCaseEndpointNameFormatter();
    
    busConfigurator.UsingRabbitMq((context,cfg) =>
    {
        cfg.Host("localhost", "/", h => {
            h.Username("guest");
            h.Password("guest");
        });
        cfg.ConfigureEndpoints(context);
    });
});

builder.Services.AddAuthentication("Token")
    .AddScheme<BasicAuthenticationOptions, CustomAuthenticationHandler>("Token", null);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdmin", policy =>
        policy.RequireClaim("IsAdmin", "True"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
