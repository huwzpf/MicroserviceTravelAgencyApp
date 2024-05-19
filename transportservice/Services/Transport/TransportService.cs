using System.Security.Cryptography;
using contracts;
using contracts.Dtos;
using Microsoft.EntityFrameworkCore;
using transportservice.Persistence;

namespace transportservice.Services.Transport;

public class TransportService
{
    private readonly DbContextOptions _dbContext;

    public TransportService(DbContextOptions dbContext)
    {
        _dbContext = dbContext;
    }
    
    public AddTransportOptionResponse AddTransportOption(AddTransportOptionRequest request)
    {
        return new AddTransportOptionResponse(new TransportOptionDto
        {
            Id = Guid.NewGuid(),
            FromCity = request.TransportOption.FromCity,
            FromCountry = request.TransportOption.FromCountry,
            FromStreet = request.TransportOption.FromStreet,
            FromShowName = request.TransportOption.FromShowName,
            ToCity = request.TransportOption.ToCity,
            ToCountry = request.TransportOption.ToCountry,
            ToStreet = request.TransportOption.ToStreet,
            ToShowName = request.TransportOption.ToShowName,
            Start = request.TransportOption.Start,
            End = request.TransportOption.End,
            SeatsAvailable = request.TransportOption.SeatsAvailable,
            PriceAdult = request.TransportOption.PriceAdult,
            PriceUnder3 = request.TransportOption.PriceUnder3,
            PriceUnder10 = request.TransportOption.PriceUnder10,
            PriceUnder18 = request.TransportOption.PriceUnder18,
        });
    }

    public TransportOptionSearchResponse SearchTransportOptions(TransportOptionSearchRequest request)
    {
        return new TransportOptionSearchResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Warsaw",
                FromCountry = "Poland",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Berlin",
                ToCountry = "Germany",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            },
            
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Berlin",
                FromCountry = "Germany",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Warsaw",
                ToCountry = "Poland",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(10),
                End = DateTime.Now.AddHours(14),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            },
        });
    }

    public GetTransportOptionsResponse GetTransportOptions(GetTransportOptionsRequest request)
    {
        return new GetTransportOptionsResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Berlin",
                FromCountry = "Germany",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Warsaw",
                ToCountry = "Poland",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            },
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Warsaw",
                FromCountry = "Poland",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Berlin",
                ToCountry = "Germany",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            }
        });
    }

    public GetTransportOptionResponse GetTransportOption(GetTransportOptionRequest request)
    {
        return new GetTransportOptionResponse(new TransportOptionDto
        {
            Id = request.Id,
            FromCity = "Berlin",
            FromCountry = "Germany",
            FromStreet = "Sample Street",
            FromShowName = "Sample Show Name",
            ToCity = "Warsaw",
            ToCountry = "Poland",
            ToStreet = "Destination Street",
            ToShowName = "Destination Show Name",
            Start = DateTime.Now.AddHours(1),
            End = DateTime.Now.AddHours(5),
            SeatsAvailable = 50,
            PriceAdult = 100,
            PriceUnder3 = 50,
            PriceUnder10 = 70,
            PriceUnder18 = 80,
            Type = "Plane",
        });
    }

    public TransportOptionAddSeatsResponse AddSeats(TransportOptionAddSeatsRequest request)
    {
        return new TransportOptionAddSeatsResponse();
    }

    public TransportOptionAddDiscountResponse AddDiscount(TransportOptionAddDiscountRequest request)
    {
        return new TransportOptionAddDiscountResponse();
    }

    public TransportOptionSubtractSeatsResponse SubtractSeats(TransportOptionSubtractSeatsRequest request)
    {
        return new TransportOptionSubtractSeatsResponse(true);
    }

    public GetTransportOptionWhenResponse GetTransportOptionWhen(GetTransportOptionWhenRequest request)
    {
        return new GetTransportOptionWhenResponse(new TransportOptionDto
        {
            Id = Guid.NewGuid(),
            FromCity = "Berlin",
            FromCountry = "Germany",
            FromStreet = "Sample Street",
            FromShowName = "Sample Show Name",
            ToCity = "Warsaw",
            ToCountry = "Poland",
            ToStreet = "Destination Street",
            ToShowName = "Destination Show Name",
            Start = request.When,
            End = request.When.AddHours(4),
            SeatsAvailable = 50,
            PriceAdult = 100,
            PriceUnder3 = 50,
            PriceUnder10 = 70,
            PriceUnder18 = 80,
            Type = "Plane",
        });
    }

    public GetPopularDestinationsResponse GetPopularDestinations(GetPopularDestinationsRequest request)
    {
        return new GetPopularDestinationsResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Berlin",
                FromCountry = "Germany",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Warsaw",
                ToCountry = "Poland",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            },
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                FromCity = "Berlin",
                FromCountry = "Germany",
                FromStreet = "Sample Street",
                FromShowName = "Sample Show Name",
                ToCity = "Warsaw",
                ToCountry = "Poland",
                ToStreet = "Destination Street",
                ToShowName = "Destination Show Name",
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Plane",
            }
        });
    }


}
