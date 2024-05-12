using MassTransit;
using Microsoft.EntityFrameworkCore;
using userservice.Persistence;
using userservice.Services.User;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    // Add MassTransit
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.SetKebabCaseEndpointNameFormatter();
            
        // Add consumers
        busConfigurator.AddConsumer<LoginRequestConsumer>();
        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host("localhost", "/", h => {
                h.Username("guest");
                h.Password("guest");
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    
    services.AddDbContext<UserDbContext>(options => options.UseInMemoryDatabase("db_mem"));
    services.AddScoped<UserService>();
});

var app = builder.Build();

await app.RunAsync();
