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
            From = request.TransportOption.From,
            To = request.TransportOption.To,
            Start = request.TransportOption.Start,
            End = request.TransportOption.End,
            SeatsAvailable = request.TransportOption.SeatsAvailable,
            PriceAdult = request.TransportOption.PriceAdult,
            PriceUnder3 = request.TransportOption.PriceUnder3,
            PriceUnder10 = request.TransportOption.PriceUnder10,
            PriceUnder18 = request.TransportOption.PriceUnder18,
            Type = request.TransportOption.Type,
            Discounts = new List<DiscountDto>()
        });
    }

    public TransportOptionSearchResponse SearchTransportOptions(TransportOptionSearchRequest request)
    {
        return new TransportOptionSearchResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                To = new AddressDto { City = "Destination City", Country = "Destination Country", Street = "Destination Street", ShowName = "Destination Show Name" },
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Airplane",
                Discounts = new List<DiscountDto>()
            }
        });
    }

    public GetTransportOptionsResponse GetTransportOptions(GetTransportOptionsRequest request)
    {
        return new GetTransportOptionsResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                To = new AddressDto { City = "Berlin", Country = "Germany", Street = "Destination Street", ShowName = "Destination Show Name" },
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Airplane",
                Discounts = new List<DiscountDto>()
            },
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                To = new AddressDto { City = "Warsaw", Country = "Poland", Street = "Destination Street", ShowName = "Destination Show Name" },
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Airplane",
                Discounts = new List<DiscountDto>()
            }
        });
    }

    public GetTransportOptionResponse GetTransportOption(GetTransportOptionRequest request)
    {
        return new GetTransportOptionResponse(new TransportOptionDto
        {
            Id = request.Id,
            From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
            To = new AddressDto { City = "Destination City", Country = "Destination Country", Street = "Destination Street", ShowName = "Destination Show Name" },
            Start = DateTime.Now.AddHours(1),
            End = DateTime.Now.AddHours(5),
            SeatsAvailable = 50,
            PriceAdult = 100,
            PriceUnder3 = 50,
            PriceUnder10 = 70,
            PriceUnder18 = 80,
            Type = "Airplane",
            Discounts = new List<DiscountDto>()
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
            From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
            To = new AddressDto { City = "Destination City", Country = "Destination Country", Street = "Destination Street", ShowName = "Destination Show Name" },
            Start = request.When,
            End = request.When.AddHours(4),
            SeatsAvailable = 50,
            PriceAdult = 100,
            PriceUnder3 = 50,
            PriceUnder10 = 70,
            PriceUnder18 = 80,
            Type = "Airplane",
            Discounts = new List<DiscountDto>()
        });
    }

    public GetPopularDestinationsResponse GetPopularDestinations(GetPopularDestinationsRequest request)
    {
        return new GetPopularDestinationsResponse(new List<TransportOptionDto>
        {
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                To = new AddressDto { City = "Berlin", Country = "Germany", Street = "Destination Street", ShowName = "Destination Show Name" },
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Airplane",
                Discounts = new List<DiscountDto>()
            },
            new TransportOptionDto
            {
                Id = Guid.NewGuid(),
                From = new AddressDto { City = "Sample City", Country = "Sample Country", Street = "Sample Street", ShowName = "Sample Show Name" },
                To = new AddressDto { City = "Warsaw", Country = "Poland", Street = "Destination Street", ShowName = "Destination Show Name" },
                Start = DateTime.Now.AddHours(1),
                End = DateTime.Now.AddHours(5),
                SeatsAvailable = 50,
                PriceAdult = 100,
                PriceUnder3 = 50,
                PriceUnder10 = 70,
                PriceUnder18 = 80,
                Type = "Airplane",
                Discounts = new List<DiscountDto>()
            }
        });
    }


}
