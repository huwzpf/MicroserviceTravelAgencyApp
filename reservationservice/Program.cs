using MassTransit;
using Microsoft.EntityFrameworkCore;
using reservationservice.Handlers;
using reservationservice.Persistence;
using reservationservice.Services.Reservation;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    // Add MassTransit
    services.AddMassTransit(busConfigurator =>
    {
        busConfigurator.SetKebabCaseEndpointNameFormatter();
            
        // Add consumers
        busConfigurator.AddConsumer<GetAvailableDestinationsRequestConsumer>();
        busConfigurator.AddConsumer<GetReservationsRequestConsumer>();
        busConfigurator.AddConsumer<GetSingleReservationRequestConsumer>();
        busConfigurator.AddConsumer<BuyRequestConsumer>();
        busConfigurator.AddConsumer<GetPopularOffersRequestConsumer>();
        busConfigurator.AddConsumer<CreateReservationRequestConsumer>();
        busConfigurator.AddConsumer<GetAvailableToursRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetTransportOptionRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetTransportOptionsRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetHotelRequestConsumer>();
        busConfigurator.AddConsumer<ReservationGetHotelsRequestConsumer>();
        busConfigurator.AddConsumer<GetAvailableRoomsRequestConsumer>();
        
        busConfigurator.UsingRabbitMq((context,cfg) =>
        {
            cfg.Host("rabbitmq", "/", h => {
                h.Username("user_rabbitmq");
                h.Password("password_rabbitmq");
            });
            cfg.ConfigureEndpoints(context);
        });
    });
    
    services.AddDbContext<ReservationDbContext>(options => options.UseNpgsql("Host=postgres:5432;Database=reservationservice_db;Username=user_reservationservice_db;Password=password_reservationservice_db"));
    services.AddScoped<ReservationService>();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ReservationDbContext>();
    context.Database.Migrate();
}

await app.RunAsync();