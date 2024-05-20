using System.Security.Cryptography;
using contracts;
using contracts.Dtos;
using Microsoft.EntityFrameworkCore;
using transportservice.Models;

namespace transportservice.Services.Transport;

public class TransportService
{
    private readonly TransportDbContext _dbContext;

    public TransportService(TransportDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<AddTransportOptionResponse> AddTransportOption(AddTransportOptionRequest request)
    {
        var transport = new TransportOption
        {
            Id = Guid.NewGuid(),
            FromCountry = request.TransportOption.FromCountry,
            FromCity = request.TransportOption.FromCity,
            FromStreet = request.TransportOption.FromStreet,
            FromShowName = request.TransportOption.FromShowName,
            ToCountry = request.TransportOption.ToCountry,
            ToCity = request.TransportOption.ToCity,
            ToStreet = request.TransportOption.ToStreet,
            ToShowName = request.TransportOption.ToShowName,
            Start = request.TransportOption.Start,
            End = request.TransportOption.End,
            InitialSeats = request.TransportOption.SeatsAvailable,
            PriceAdult = request.TransportOption.PriceAdult,
            Type = request.TransportOption.Type,
            Discounts = new List<Discount>()
        };
        
        _dbContext.TransportOptions.Add(transport);
        await _dbContext.SaveChangesAsync();
        
        return new AddTransportOptionResponse(transport.ToDto());
    }

    public async Task<TransportOptionSearchResponse> SearchTransportOptions(TransportOptionSearchRequest request)
    {
        var searchCriteria = request.SearchCriteria;
        var transportOptionsQuery = _dbContext.Set<TransportOption>()
            .Include(t => t.Discounts)
            .Include(t => t.SeatsChanges)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchCriteria.SourceCountry))
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.FromCountry == searchCriteria.SourceCountry);
        }

        if (!string.IsNullOrEmpty(searchCriteria.SourceCity))
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.FromCity == searchCriteria.SourceCity);
        }

        if (!string.IsNullOrEmpty(searchCriteria.DestinationCountry))
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.ToCountry == searchCriteria.DestinationCountry);
        }

        if (!string.IsNullOrEmpty(searchCriteria.DestinationCity))
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.ToCity == searchCriteria.DestinationCity);
        }

        if (searchCriteria.MinStart.HasValue)
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.Start >= searchCriteria.MinStart.Value);
        }

        if (searchCriteria.MaxEnd.HasValue)
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.End <= searchCriteria.MaxEnd.Value);
        }

        if (!string.IsNullOrEmpty(searchCriteria.Type))
        {
            transportOptionsQuery = transportOptionsQuery.Where(t => t.Type == searchCriteria.Type);
        }

        // Retrieve the filtered transport options from the database
        var transportOptions = await transportOptionsQuery.ToListAsync();

        // Perform in-memory filtering for the seats criteria
        if (searchCriteria.SeatsMinimum != 0)
        {
            transportOptions = transportOptions
                .Where(t => t.GetSeats() > searchCriteria.SeatsMinimum)
                .ToList();
        }

        // Convert to DTOs
        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new TransportOptionSearchResponse(transportOptionsDto);
    }
    
    public async Task<GetTransportOptionsResponse> GetTransportOptions(GetTransportOptionsRequest request)
    {
        var transports = await _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges)
            .ToListAsync();

        var transportsDto = transports.Select(transport => transport.ToDto()).ToList();

        return new GetTransportOptionsResponse(transportsDto);
    }

    public async Task<GetTransportOptionResponse> GetTransportOption(GetTransportOptionRequest request)
    {
        var transportQuery = await _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null)
        {
            return null;
        }
        
        var transportsDto = transportQuery.ToDto();

        return new GetTransportOptionResponse(transportsDto);
    }

    public async  Task<TransportOptionAddSeatsResponse> AddSeats(TransportOptionAddSeatsRequest request)
    {
        var transportQuery = await _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges)
            .FirstOrDefaultAsync(to => to.Id == request.Id);
        
            if (transportQuery == null)
            {
                return null;
            }

            transportQuery.InitialSeats += request.SeatsAmount;
            transportQuery.SeatsChanges.Add(new SeatsChange
            {
                Id = Guid.NewGuid(),
                TransportOptionId = transportQuery.Id,
                ChangeBy = request.SeatsAmount
            });

            return new TransportOptionAddSeatsResponse();
    }

    public async Task<TransportOptionAddDiscountResponse> AddDiscount(TransportOptionAddDiscountRequest request)
    {
        var transportQuery = await _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if(transportQuery == null)
        {
            return null;
        }

        var newDiscount = new Discount
        {
            Id = Guid.NewGuid(),
            TransportOptionId = request.Id,
            Value = request.Discount.Value,
            Start = request.Discount.Start,
            End = request.Discount.End
        };

        await _dbContext.Discounts.AddAsync(newDiscount);
        await _dbContext.SaveChangesAsync();
        
        return new TransportOptionAddDiscountResponse();
    }
    
    public async Task<TransportOptionSubtractSeatsResponse> SubtractSeats(TransportOptionSubtractSeatsRequest request)
    {
        var transportQuery = await _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges)
            .FirstOrDefaultAsync(to => to.Id == request.Id);
        
        if (transportQuery == null)
        {
            return null;
        }

        transportQuery.InitialSeats -= request.SeatsAmount;
        transportQuery.SeatsChanges.Add(new SeatsChange
        {
            Id = Guid.NewGuid(),
            TransportOptionId = transportQuery.Id,
            ChangeBy = request.SeatsAmount
        });

        return new TransportOptionSubtractSeatsResponse();
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

    public async Task<GetPopularDestinationsResponse> GetPopularDestinations(GetPopularDestinationsRequest request)
    {
        var transportOptions = await _dbContext.Set<TransportOption>()
            .Include(t => t.Discounts)
            .Include(t => t.SeatsChanges)
            .Take(10)
            .ToListAsync();

        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new GetPopularDestinationsResponse(transportOptionsDto);
    }
}




