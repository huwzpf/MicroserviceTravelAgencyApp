using MassTransit;
using Microsoft.EntityFrameworkCore;
using userservice.Handlers;
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
        busConfigurator.AddConsumer<GetUserRequestConsumer>();
        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host("rabbitmq", "/", h => {
                h.Username("user_rabbitmq");
                h.Password("password_rabbitmq");
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    
    services.AddDbContext<UserDbContext>(options => options.UseNpgsql("Host=postgres:5432;Database=userservice_db;Username=user_userservice_db;Password=password_userservice_db"));
    services.AddScoped<UserService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<UserDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();
