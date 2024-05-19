using MassTransit;
using Microsoft.EntityFrameworkCore;
using paymentservice.Handlers;
using paymentservice.Services.Payment;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    // Add MassTransit
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.SetKebabCaseEndpointNameFormatter();
            
        // Add consumers
        busConfigurator.AddConsumer<PayRequestConsumer>();
        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host("rabbitmq", "/", h => {
                h.Username("user_rabbitmq");
                h.Password("password_rabbitmq");
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    services.AddLogging();
    services.AddScoped<PaymentService>();
});

var app = builder.Build();

await app.RunAsync();
