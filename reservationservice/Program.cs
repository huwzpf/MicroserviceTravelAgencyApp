using MassTransit;
using Microsoft.EntityFrameworkCore;
using reservationservice.Handlers;
using reservationservice.Persistence;
using reservationservice.Services.Reservation;

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
        busConfigurator.AddConsumer<GetAvailableDestinationsRequestConsumer>();
        busConfigurator.AddConsumer<GetReservationsRequestConsumer>();
        busConfigurator.AddConsumer<GetSingleReservationRequestConsumer>();
        busConfigurator.AddConsumer<BuyRequestConsumer>();
        busConfigurator.AddConsumer<CreateReservationRequestConsumer>();
        busConfigurator.AddConsumer<GetAvailableToursRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetTransportOptionRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetTransportOptionsRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetHotelRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetHotelsRequestConsumer>();
        busConfigurator.AddConsumer<GetAvailableRoomsRequestConsumer>();
        
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
    
    services.AddDbContextFactory<ReservationDbContext>(options => options.UseNpgsql(postgresConnectionString));
    services.AddScoped<ReservationService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ReservationDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();