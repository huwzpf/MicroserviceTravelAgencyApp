using MassTransit;
using Microsoft.EntityFrameworkCore;
using hotelservice.Handlers;
using hotelservice.Models;
using hotelservice.Services.Hotel;

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
        busConfigurator.AddConsumer<AddHotelRequestConsumer>();
        busConfigurator.AddConsumer<HotelCheckAvailabilityRequestConsumer>();
        busConfigurator.AddConsumer<GetHotelsRequestConsumer>();
        busConfigurator.AddConsumer<GetHotelRequestConsumer>();
        busConfigurator.AddConsumer<HotelBookRoomsRequestConsumer>();
        busConfigurator.AddConsumer<HotelGetAvailableRoomsRequestConsumer>();
        busConfigurator.AddConsumer<HotelAddDiscountRequestConsumer>();
        busConfigurator.AddConsumer<HotelCancelBookRoomsRequestConsumer>();
        busConfigurator.AddConsumer<GetPopularHotelsRequestConsumer>();
        
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
    
    services.AddDbContext<HotelDbContext>(options => options.UseNpgsql(postgresConnectionString));
    services.AddScoped<HotelService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<HotelDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();
