// EventHandlers.cs
using contracts.Dtos;
using Microsoft.EntityFrameworkCore;
using transportservice.Models;

namespace transportservice.Services.Transport;

public class SeatsChangedEvent
{
    public Guid TransportOptionId { get; }
    public int ChangeBy { get; }

    public SeatsChangedEvent(Guid transportOptionId, int changeBy)
    {
        TransportOptionId = transportOptionId;
        ChangeBy = changeBy;
    }
}

public class DiscountAddedEvent
{
    public Guid TransportOptionId { get; }
    public decimal DiscountValue { get; }

    public DiscountAddedEvent(Guid transportOptionId, decimal discountValue)
    {
        TransportOptionId = transportOptionId;
        DiscountValue = discountValue;
    }
}

public class TransportOptionAddedEvent
{
    public TransportOptionDto Dto { get; }

    public TransportOptionAddedEvent(TransportOptionDto dto)
    {
        Dto = dto;
    }
}

// Event Handlers
public class TransportOptionAddedEventHandler
{
    private readonly IDbContextFactory<TransportDbContext> _dbContextFactory;

    public TransportOptionAddedEventHandler(IDbContextFactory<TransportDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void Handle(TransportOptionAddedEvent @event)
    {
        using (var dbContext = _dbContextFactory.CreateDbContext())
        {
            var queryTransportOption = new QueryTransportOption
            {
                Id = @event.Dto.Id,
                Start = @event.Dto.Start,
                End = @event.Dto.End,
                PriceAdult = @event.Dto.PriceAdult,
                PriceUnder3 = @event.Dto.PriceUnder3,
                PriceUnder10 = @event.Dto.PriceUnder10,
                PriceUnder18 = @event.Dto.PriceUnder18,
                Type = @event.Dto.Type,
                Seats = @event.Dto.SeatsAvailable,
                FromCity = @event.Dto.FromCity,
                FromCountry = @event.Dto.FromCountry,
                FromStreet = @event.Dto.FromStreet,
                FromShowName = @event.Dto.FromShowName,
                ToCity = @event.Dto.ToCity,
                ToCountry = @event.Dto.ToCountry,
                ToStreet = @event.Dto.ToStreet,
                ToShowName = @event.Dto.ToShowName,
                Discount = null
            };

            dbContext.QueryTransportOptions.Add(queryTransportOption);
            dbContext.SaveChanges();
        }
    }
}

public class SeatsChangedEventHandler
{
    private readonly IDbContextFactory<TransportDbContext> _dbContextFactory;

    public SeatsChangedEventHandler(IDbContextFactory<TransportDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void Handle(SeatsChangedEvent @event)
    {
        using (var dbContext = _dbContextFactory.CreateDbContext())
        {
            var queryTransportOption = dbContext.QueryTransportOptions
                .FirstOrDefault(to => to.Id == @event.TransportOptionId);

            if (queryTransportOption != null)
            {
                queryTransportOption.Seats += @event.ChangeBy;
                dbContext.SaveChanges();
            }
        }
    }
}

public class DiscountAddedEventHandler
{
    private readonly IDbContextFactory<TransportDbContext> _dbContextFactory;

    public DiscountAddedEventHandler(IDbContextFactory<TransportDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public void Handle(DiscountAddedEvent @event)
    {
        using (var dbContext = _dbContextFactory.CreateDbContext())
        {
            var queryTransportOption = dbContext.QueryTransportOptions
                .FirstOrDefault(to => to.Id == @event.TransportOptionId);

            if (queryTransportOption != null)
            {
                queryTransportOption.Discount = @event.DiscountValue;
                dbContext.SaveChanges();
            }
        }
    }
}
