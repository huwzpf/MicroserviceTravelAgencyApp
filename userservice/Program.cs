using MassTransit;
using Microsoft.EntityFrameworkCore;
using userservice.Handlers;
using userservice.Persistence;
using userservice.Services.User;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration((hostingContext, config) =>
{
    var env = hostingContext.HostingEnvironment;
    
    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: false)
        .AddEnvironmentVariables();
});

builder.ConfigureServices((hostContext, services) =>
{
    var configuration = hostContext.Configuration;
    
    // Add MassTransit
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.SetKebabCaseEndpointNameFormatter();
            
        // Add consumers
        busConfigurator.AddConsumer<LoginRequestConsumer>();
        busConfigurator.AddConsumer<GetUserRequestConsumer>();
        
        // Get the connection string from configuration
        var rabbitMQHost = configuration.GetConnectionString("RabbitMQHost");
        var rabbitMQUser = configuration.GetConnectionString("RabbitMQUser");
        var rabbitMQPassword = configuration.GetConnectionString("RabbitMQPassword");
        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host(rabbitMQHost, "/", h => {
                h.Username(rabbitMQUser);
                h.Password(rabbitMQPassword);
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    
    // Get the connection string from configuration
    var postgresConnectionString = configuration.GetConnectionString("PostgresConnectionString");
    
    services.AddDbContext<UserDbContext>(options => options.UseNpgsql(postgresConnectionString));
    services.AddScoped<UserService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<UserDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();
