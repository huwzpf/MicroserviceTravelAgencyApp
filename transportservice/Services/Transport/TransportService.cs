using contracts;
using Microsoft.EntityFrameworkCore;
using transportservice.Models;

namespace transportservice.Services.Transport;

public class TransportService
{
    private readonly IDbContextFactory<TransportDbContext> _dbContextFactory;
    private readonly IEventBus _eventBus;

    public TransportService(IDbContextFactory<TransportDbContext> dbContextFactory, IEventBus eventBus)
    {
        _dbContextFactory = dbContextFactory;
        _eventBus = eventBus;
    }

    private IQueryable<CommandTransportOption> FetchCommandTransportOptions(TransportDbContext dbContext)
    {
        return dbContext.CommandTransportOptions
            .Include(to => to.Discounts)
            .Include(to => to.SeatsChanges);
    }

    private IQueryable<QueryTransportOption> FetchQueryTransportOptions(TransportDbContext dbContext)
    {
        return dbContext.QueryTransportOptions.AsQueryable();
    }

    public async Task<AddTransportOptionResponse> AddTransportOption(AddTransportOptionRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transport = new CommandTransportOption
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
            PriceUnder3 = request.TransportOption.PriceUnder3,
            PriceUnder10 = request.TransportOption.PriceUnder10,
            PriceUnder18 = request.TransportOption.PriceUnder18,
            Type = request.TransportOption.Type,
            Discounts = new List<Discount>()
        };

        dbContext.CommandTransportOptions.Add(transport);
        await dbContext.SaveChangesAsync();

        var transportDto = transport.ToDto();
        _eventBus.Publish(new TransportOptionAddedEvent(transportDto));

        return new AddTransportOptionResponse(transportDto);
    }

    public async Task<TransportOptionSearchResponse> SearchTransportOptions(TransportOptionSearchRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var searchCriteria = request.SearchCriteria;
        var transportOptionsQuery = dbContext.Set<QueryTransportOption>().AsQueryable();

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

        if (searchCriteria.SeatsMinimum != 0)
            transportOptionsQuery = transportOptionsQuery.Where(t => t.Seats >= searchCriteria.SeatsMinimum);

        var transportOptions = await transportOptionsQuery.ToListAsync();
        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new TransportOptionSearchResponse(transportOptionsDto);
    }

    public async Task<GetTransportOptionsResponse> GetTransportOptions(GetTransportOptionsRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transports = await FetchQueryTransportOptions(dbContext).ToListAsync();
        var transportsDto = transports.Select(transport => transport.ToDto()).ToList();

        return new GetTransportOptionsResponse(transportsDto);
    }

    public async Task<GetTransportOptionResponse> GetTransportOption(GetTransportOptionRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transportQuery = await FetchQueryTransportOptions(dbContext)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new GetTransportOptionResponse(null);

        return new GetTransportOptionResponse(transportQuery.ToDto());
    }

    public async Task<TransportOptionAddSeatsResponse> AddSeats(TransportOptionAddSeatsRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transportQuery = await FetchCommandTransportOptions(dbContext)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new TransportOptionAddSeatsResponse();

        var seatsChange = new SeatsChange
        {
            Id = Guid.NewGuid(),
            TransportOptionId = transportQuery.Id,
            ChangeBy = request.SeatsAmount
        };

        await dbContext.SeatsChanges.AddAsync(seatsChange);
        await dbContext.SaveChangesAsync();

        _eventBus.Publish(new SeatsChangedEvent(transportQuery.Id, request.SeatsAmount));
        
        return new TransportOptionAddSeatsResponse();
    }

    public async Task<TransportOptionAddDiscountResponse> AddDiscount(TransportOptionAddDiscountRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transportQuery = await FetchCommandTransportOptions(dbContext)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null) return new TransportOptionAddDiscountResponse();

        var newDiscount = new Discount
        {
            Id = Guid.NewGuid(),
            TransportOptionId = request.Id,
            Value = request.Discount.Value,
            Start = request.Discount.Start,
        };

        await dbContext.Discounts.AddAsync(newDiscount);
        await dbContext.SaveChangesAsync();

        _eventBus.Publish(new DiscountAddedEvent(request.Id, request.Discount.Value));
        
        return new TransportOptionAddDiscountResponse();
    }

    public async Task<TransportOptionSubtractSeatsResponse> SubtractSeats(TransportOptionSubtractSeatsRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transportQuery = await FetchCommandTransportOptions(dbContext)
            .FirstOrDefaultAsync(to => to.Id == request.Id);

        if (transportQuery == null || transportQuery.GetSeats() < request.SeatsAmount)
            return new TransportOptionSubtractSeatsResponse(false);

        var seatsChange = new SeatsChange
        {
            Id = Guid.NewGuid(),
            TransportOptionId = transportQuery.Id,
            ChangeBy = -request.SeatsAmount
        };

        await dbContext.SeatsChanges.AddAsync(seatsChange);
        await dbContext.SaveChangesAsync();

        _eventBus.Publish(new SeatsChangedEvent(transportQuery.Id, -request.SeatsAmount));
        
        return new TransportOptionSubtractSeatsResponse(true);
    }

    public async Task<GetPopularDestinationsResponse> GetPopularDestinations(GetPopularDestinationsRequest request)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var transportOptions = await FetchQueryTransportOptions(dbContext).Take(10).ToListAsync();
        var transportOptionsDto = transportOptions.Select(t => t.ToDto()).ToList();

        return new GetPopularDestinationsResponse(transportOptionsDto);
    }
}
