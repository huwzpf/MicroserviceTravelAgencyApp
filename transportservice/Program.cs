using MassTransit;
using Microsoft.EntityFrameworkCore;
using transportservice.Handlers;
using transportservice.Models;
using transportservice.Services.Transport;

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
    
    // Register InMemoryEventBus
    services.AddSingleton<IEventBus, InMemoryEventBus>();

    // Register event handlers
    services.AddScoped<TransportOptionAddedEventHandler>();
    services.AddScoped<SeatsChangedEventHandler>();
    services.AddScoped<TransportDiscountAddedEventHandler>();
    
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
        busConfigurator.AddConsumer<GetPopularTransportDestinationsRequestConsumer>();
        busConfigurator.AddConsumer<GetPopularTransportTypesRequestConsumer>();
        
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
    
    services.AddDbContextFactory<TransportDbContext>(options => options.UseNpgsql(postgresConnectionString));
    services.AddScoped<TransportService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TransportDbContext>();
    context.Database.Migrate();
    
    // Subscribe to events
    var eventBus = scope.ServiceProvider.GetRequiredService<IEventBus>();

    var transportOptionAddedHandler = scope.ServiceProvider.GetRequiredService<TransportOptionAddedEventHandler>();
    eventBus.Subscribe<TransportOptionAddedEvent>(transportOptionAddedHandler.Handle);

    var seatsChangedHandler = scope.ServiceProvider.GetRequiredService<SeatsChangedEventHandler>();
    eventBus.Subscribe<SeatsChangedEvent>(seatsChangedHandler.Handle);

    var discountAddedHandler = scope.ServiceProvider.GetRequiredService<TransportDiscountAddedEventHandler>();
    eventBus.Subscribe<TransportDiscountAddedEvent>(discountAddedHandler.Handle);
}

await app.RunAsync();
