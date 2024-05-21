using contracts;
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

    private IQueryable<TransportOption> FetchTransportOptions()
    {
        return _dbContext.TransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges);
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
            transportOptionsQuery = transportOptionsQuery.Where(t => t.FromCountry == searchCriteria.SourceCountry);

        if (!string.IsNullOrEmpty(searchCriteria.SourceCity))
            transportOptionsQuery = transportOptionsQuery.Where(t => t.FromCity == searchCriteria.SourceCity);

        if (!string.IsNullOrEmpty(searchCriteria.DestinationCountry))
            transportOptionsQuery = transportOptionsQuery.Where(t => t.ToCountry == searchCriteria.DestinationCountry);

        if (!string.IsNullOrEmpty(searchCriteria.DestinationCity))
            transportOptionsQuery = transportOptionsQuery.Where(t => t.ToCity == searchCriteria.DestinationCity);

        if (searchCriteria.MinStart.HasValue)
            transportOptionsQuery = transportOptionsQuery.Where(t => t.Start >= searchCriteria.MinStart.Value);

        if (searchCriteria.MaxEnd.HasValue)
            transportOptionsQuery = transportOptionsQuery.Where(t => t.End <= searchCriteria.MaxEnd.Value);

        if (!string.IsNullOrEmpty(searchCriteria.Type))
            transportOptionsQuery = transportOptionsQuery.Where(t => t.Type == searchCriteria.Type);

        // Retrieve the filtered transport options from the database
        var transportOptions = await transportOptionsQuery.ToListAsync();

        // Perform in-memory filtering for the seats criteria
        if (searchCriteria.SeatsMinimum != 0)
            transportOptions = transportOptions
                .Where(t => t.GetSeats() > searchCriteria.SeatsMinimum)
                .ToList();

        // Convert to DTOs
        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new TransportOptionSearchResponse(transportOptionsDto);
    }

    public async Task<GetTransportOptionsResponse> GetTransportOptions(GetTransportOptionsRequest request)
    {
        var transports = await FetchTransportOptions()
            .ToListAsync();

        var transportsDto = transports.Select(transport => transport.ToDto()).ToList();

        return new GetTransportOptionsResponse(transportsDto);
    }

    public async Task<GetTransportOptionResponse> GetTransportOption(GetTransportOptionRequest request)
    {
        var transportQuery = await FetchTransportOptions()
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new GetTransportOptionResponse(null);

        return new GetTransportOptionResponse(transportQuery.ToDto());
    }

    public async Task<TransportOptionAddSeatsResponse> AddSeats(TransportOptionAddSeatsRequest request)
    {
        var transportQuery = await FetchTransportOptions()
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new TransportOptionAddSeatsResponse();

        await _dbContext.SeatsChanges.AddAsync(new SeatsChange
        {
            Id = Guid.NewGuid(),
            TransportOptionId = transportQuery.Id,
            ChangeBy = request.SeatsAmount
        });

        await _dbContext.SaveChangesAsync();
        return new TransportOptionAddSeatsResponse();
    }

    public async Task<TransportOptionAddDiscountResponse> AddDiscount(TransportOptionAddDiscountRequest request)
    {
        var transportQuery = await FetchTransportOptions()
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new TransportOptionAddDiscountResponse();

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
        var transportQuery = await FetchTransportOptions()
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null || transportQuery.GetSeats() < request.SeatsAmount)
            return new TransportOptionSubtractSeatsResponse(false);

        await _dbContext.SeatsChanges.AddAsync(new SeatsChange
        {
            Id = Guid.NewGuid(),
            TransportOptionId = transportQuery.Id,
            ChangeBy = -request.SeatsAmount
        });

        await _dbContext.SaveChangesAsync();
        
        return new TransportOptionSubtractSeatsResponse(true);
    }

    public async Task<GetPopularDestinationsResponse> GetPopularDestinations(GetPopularDestinationsRequest request)
    {
        var transportOptions = await FetchTransportOptions()
            .Take(10)
            .ToListAsync();

        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new GetPopularDestinationsResponse(transportOptionsDto);
    }
}