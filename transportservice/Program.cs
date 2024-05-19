using MassTransit;
using Microsoft.EntityFrameworkCore;
using transportservice.Handlers;
using transportservice.Models;
using transportservice.Services.Transport;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    // Add MassTransit
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.SetKebabCaseEndpointNameFormatter();
            
        // Add consumers
        busConfigurator.AddConsumer<AddTransportOptionRequestConsumer>();
        busConfigurator.AddConsumer<TransportOptionSearchRequestConsumer>();
        busConfigurator.AddConsumer<GetTransportOptionsRequestConsumer>();
        busConfigurator.AddConsumer<GetTransportOptionRequestConsumer>();
        busConfigurator.AddConsumer<TransportOptionAddSeatsRequestConsumer>();
        busConfigurator.AddConsumer<TransportOptionAddDiscountRequestConsumer>();
        busConfigurator.AddConsumer<TransportOptionSubtractSeatsRequestConsumer>();
        busConfigurator.AddConsumer<GetTransportOptionWhenRequestConsumer>();
        busConfigurator.AddConsumer<GetPopularDestinationsRequestConsumer>();

        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host("rabbitmq", "/", h => {
                h.Username("user_rabbitmq");
                h.Password("password_rabbitmq");
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    
    services.AddDbContext<TransportDbContext>(options => options.UseNpgsql("Host=postgres:5432;Database=transportservice_db;Username=user_transportservice_db;Password=password_transportservice_db"));
    services.AddScoped<TransportService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TransportDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();
