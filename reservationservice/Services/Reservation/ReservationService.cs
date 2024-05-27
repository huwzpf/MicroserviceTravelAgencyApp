using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using reservationservice.Models;
using reservationservice.Persistence;
using Timer = System.Timers.Timer;

namespace reservationservice.Services.Reservation;

public class ReservationService
{
    private readonly IDbContextFactory<ReservationDbContext> _dbContextFactory;
    private readonly IRequestClient<GetTransportOptionRequest> _getTransportOptionClient;
    private readonly IRequestClient<GetTransportOptionsRequest> _getTransportOptionsClient;
    private readonly IRequestClient<GetHotelRequest> _getHotelClient;
    private readonly IRequestClient<GetHotelsRequest> _getHotelsClient;
    private readonly IRequestClient<HotelGetAvailableRoomsRequest> _getAvailableRoomsClient;
    private readonly IRequestClient<GetPopularDestinationsRequest> _getPopularDestinationsClient;
    private readonly IRequestClient<HotelBookRoomsRequest> _bookRoomsClient;
    private readonly IRequestClient<TransportOptionSubtractSeatsRequest> _subtractSeatsClient;
    private readonly IRequestClient<TransportOptionAddSeatsRequest> _addSeatsClient;
    private readonly IRequestClient<HotelCancelBookRoomsRequest> _cancelBookRoomsClient;
    private readonly IRequestClient<HotelCheckAvailabilityRequest> _hotelCheckAvailabilityClient;
    private readonly IRequestClient<TransportOptionSearchRequest> _transportSearchClient;
    private readonly IRequestClient<PayRequest> _payRequestClient;
    private readonly ILogger<ReservationService> _logger;
    private readonly TimerManager _timerManager;

    public ReservationService(
        IDbContextFactory<ReservationDbContext> dbContextFactory,
        IRequestClient<GetTransportOptionRequest> getTransportOptionClient,
        IRequestClient<GetTransportOptionsRequest> getTransportOptionsClient,
        IRequestClient<GetHotelRequest> getHotelClient,
        IRequestClient<GetHotelsRequest> getHotelsClient,
        IRequestClient<HotelGetAvailableRoomsRequest> getAvailableRoomsClient,
        IRequestClient<GetPopularDestinationsRequest> getPopularDestinationsClient,
        IRequestClient<HotelBookRoomsRequest> bookRoomsClient,
        IRequestClient<TransportOptionSubtractSeatsRequest> subtractSeatsClient,
        IRequestClient<TransportOptionAddSeatsRequest> addSeatsClient,
        IRequestClient<HotelCheckAvailabilityRequest> hotelCheckAvailabilityClient,
        IRequestClient<TransportOptionSearchRequest> transportSearchClient,
        IRequestClient<HotelCancelBookRoomsRequest> cancelBookRoomsClient,
        IRequestClient<PayRequest> payRequestClient,
        ILogger<ReservationService> logger)
    {
        _dbContextFactory = dbContextFactory;
        _getTransportOptionClient = getTransportOptionClient;
        _getTransportOptionsClient = getTransportOptionsClient;
        _getHotelClient = getHotelClient;
        _getHotelsClient = getHotelsClient;
        _getAvailableRoomsClient = getAvailableRoomsClient;
        _getPopularDestinationsClient = getPopularDestinationsClient;
        _bookRoomsClient = bookRoomsClient;
        _subtractSeatsClient = subtractSeatsClient;
        _addSeatsClient = addSeatsClient;
        _cancelBookRoomsClient = cancelBookRoomsClient;
        _hotelCheckAvailabilityClient = hotelCheckAvailabilityClient;
        _transportSearchClient = transportSearchClient;
        _payRequestClient = payRequestClient;
        _logger = logger;
        _timerManager = new TimerManager(OnTimerElapsed);
    }

    private async Task OnTimerElapsed(Guid reservationId, Timer timer)
    {
        await using var dbContext = await _dbContextFactory.CreateDbContextAsync();

        timer.Stop();
        timer.Dispose();

        var reservation = await FetchReservations(dbContext)
            .FirstOrDefaultAsync(r => r.Id == reservationId);

        if (reservation == null || reservation.Finalized) return;


        if (reservation.BeingPaidFors.Any(bp => !bp.CancellationDate.HasValue))
        {
            // Restart the timer and exit
            _timerManager.ResetTimer(reservationId);
            return;
        }

        // otherwise (meaning there's no BeingPaidFors objects or all have cancellation date), cancel reservation 
        reservation.CancellationDate = DateTime.UtcNow;
        reservation.Finalized = true;

        // Revert all bookings
        await RevertHotelBooking(reservation.HotelId,
            reservation.HotelRoomReservations.Select(room => room.HotelRoomReservationObjectId).ToList());

        await RevertTransportBooking(reservation.ToDestinationTransport,
            GetTotalNumberOfPeople(reservation));

        await RevertTransportBooking(reservation.FromDestinationTransport,
            GetTotalNumberOfPeople(reservation));

        dbContext.Reservations.Update(reservation);
        await dbContext.SaveChangesAsync();
    }

    private IQueryable<Models.Reservation> FetchReservations(ReservationDbContext dbContext)
    {
        return dbContext.Reservations
            .Include(r => r.HotelRoomReservations)
            .Include(r => r.BeingPaidFors);
    }

    private static int GetTotalNumberOfPeople(CreateReservationDto reservation)
    {
        return reservation.NumAdults + reservation.NumUnder3 + reservation.NumUnder10 + reservation.NumUnder18;
    }

    private static int GetTotalNumberOfPeople(Models.Reservation reservation)
    {
        return reservation.NumAdults + reservation.NumUnder3 + reservation.NumUnder10 + reservation.NumUnder18;
    }

    private async Task<Models.Reservation> ReservationFromDtos(CreateReservationRequest createReservationRequest,
        Response<HotelBookRoomsResponse> hotelBookRoomsResponse,
        Response<GetTransportOptionResponse> toTransportOptionResponse,
        Response<GetTransportOptionResponse> fromTransportOptionResponse)
    {
        var hotelResponse = await _getHotelClient.GetResponse<GetHotelResponse>(
            new GetHotelRequest(createReservationRequest.Reservation.Hotel));

        if (hotelResponse.Message.Hotel == null || toTransportOptionResponse.Message.TransportOption == null ||
            fromTransportOptionResponse.Message.TransportOption == null)
        {
            throw new Exception("Could not fetch hotel or transport option");
        }
        var newReservationGuid = Guid.NewGuid();
        var nights = (int)(fromTransportOptionResponse.Message.TransportOption.End
                           - toTransportOptionResponse.Message.TransportOption.Start).TotalDays;
        var reservation = new Models.Reservation
        {
            Id = newReservationGuid,
            UserId = createReservationRequest.Reservation.UserId,
            NumAdults = createReservationRequest.Reservation.NumAdults,
            NumUnder3 = createReservationRequest.Reservation.NumUnder3,
            NumUnder10 = createReservationRequest.Reservation.NumUnder10,
            NumUnder18 = createReservationRequest.Reservation.NumUnder18,
            ToDestinationTransport = createReservationRequest.Reservation.ToDestinationTransport,
            HotelId = hotelResponse.Message.Hotel.Id,
            HotelName = hotelResponse.Message.Hotel.Name,
            HotelRoomReservations = hotelBookRoomsResponse.Message.RoomReservations.Select(rr =>
                new HotelRoomReservation
                {
                    nRooms = createReservationRequest.Reservation.Rooms[rr.Size],
                    Size = rr.Size,
                    Id = Guid.NewGuid(),
                    HotelRoomReservationObjectId = rr.Id,
                    ReservationId = newReservationGuid
                }).ToList(),
            FromDestinationTransport = createReservationRequest.Reservation.FromDestinationTransport,
            Finalized = false,
            StartDate = toTransportOptionResponse.Message.TransportOption.Start,
            NumberOfNights = nights,
            Price = CalculatePrice(
                createReservationRequest.Reservation,
                hotelResponse.Message.Hotel,
                toTransportOptionResponse.Message.TransportOption,
                fromTransportOptionResponse.Message.TransportOption,
                nights
            ),
            FromCity = toTransportOptionResponse.Message.TransportOption.FromCity,
            ToCity = toTransportOptionResponse.Message.TransportOption.ToCity,
            FoodIncluded = createReservationRequest.Reservation.WithFood,
            TransportType = toTransportOptionResponse.Message.TransportOption.Type,
            ReservedUntil = DateTime.Now.AddMinutes(_timerManager.InitialIntervalMinutes),
            BeingPaidFors = new List<BeingPaidFor>()
        };
        return reservation;
    }

    private async Task RevertHotelBooking(Guid hotelId, List<Guid> roomBookings)
    {
        await _cancelBookRoomsClient.GetResponse<HotelCancelBookRoomsResponse>(
            new HotelCancelBookRoomsRequest(hotelId, roomBookings));
    }

    private async Task RevertTransportBooking(Guid transportOptionId, int seats)
    {
        await _addSeatsClient.GetResponse<TransportOptionAddSeatsResponse>(
            new TransportOptionAddSeatsRequest(transportOptionId, seats));
    }

    private static decimal CalculateTransportPrice(CreateReservationDto reservation, TransportOptionDto transport)
    {
        decimal price = 0;

        price += reservation.NumAdults * transport.PriceAdult;
        price += reservation.NumUnder18 * transport.PriceUnder18;
        price += reservation.NumUnder10 * transport.PriceUnder10;
        price += reservation.NumUnder3 * transport.PriceUnder3;

        return price;
    }

    private static decimal CalculatePrice(CreateReservationDto reservation, HotelDto hotel,
        TransportOptionDto toTransport, TransportOptionDto fromTransport, int numberOfNights)
    {
        decimal totalPrice = 0;

        totalPrice += numberOfNights * CalculateHotelPrice(reservation, hotel);
        if (reservation.WithFood)
        {
            totalPrice += numberOfNights * hotel.FoodPricePerPerson * GetTotalNumberOfPeople(reservation);
        }
        totalPrice += CalculateTransportPrice(reservation, toTransport);
        totalPrice += CalculateTransportPrice(reservation, fromTransport);

        return totalPrice;
    }

    private static decimal CalculateHotelPrice(CreateReservationDto reservation, HotelDto hotel)
    {
        decimal totalPrice = 0;
        foreach (var room in reservation.Rooms)
        {
            var roomSize = room.Key;
            var roomCount = room.Value;
            var hotelRoom = hotel.Rooms.FirstOrDefault(r => r.Size == roomSize);
            if (hotelRoom != null)
            {
                var roomPrice = hotelRoom.Price;
                totalPrice += roomPrice * roomCount;
            }
            else
            {
                throw new Exception($"Hotel does not have rooms of size {roomSize}");
            }
        }

        return totalPrice;
    }

    private async Task<bool> CallPaymentService(PaymentInfoDto paymentInfo)
    {
        var response = await _payRequestClient.GetResponse<PayResponse>(new PayRequest(paymentInfo));
        return response.Message.success;
    }

    public async Task<GetAvailableDestinationsResponse> GetAvailableDestinations()
    {
        // Fetch all hotels
        var hotelsResponse = await _getHotelsClient.GetResponse<GetHotelsResponse>(new GetHotelsRequest());

        // Create a dictionary of Country -> List of Cities from the hotels
        var hotelDestinations = hotelsResponse.Message.Hotels
            .GroupBy(hotel => hotel.Country)
            .ToDictionary(
                group => group.Key,
                group => group.Select(hotel => hotel.City).Distinct().ToList()
            );

        // Fetch all transport options
        var transportOptionsResponse =
            await _getTransportOptionsClient.GetResponse<GetTransportOptionsResponse>(new GetTransportOptionsRequest());

        // Create a dictionary of Country -> List of Cities from the transport options
        var transportDestinationsTo = transportOptionsResponse.Message.TransportOptions
            .GroupBy(option => option.ToCountry)
            .ToDictionary(
                group => group.Key,
                group => group.Select(option => option.ToCity).Distinct().ToList()
            );

        // Create a dictionary of Country -> List of Cities from the transport options
        var transportDestinationsFrom = transportOptionsResponse.Message.TransportOptions
            .GroupBy(option => option.FromCountry)
            .ToDictionary(
                group => group.Key,
                group => group.Select(option => option.FromCity).Distinct().ToList()
            );

        // Merge To and From dicts
        var transportDestinations =
            new Dictionary<string, List<string>>(transportDestinationsTo);

        foreach (var kvp in transportDestinationsFrom)
            if (transportDestinations.ContainsKey(kvp.Key))
                transportDestinations[kvp.Key] = transportDestinations[kvp.Key]
                    .Concat(kvp.Value)
                    .Distinct()
                    .ToList();
            else
                transportDestinations[kvp.Key] = kvp.Value;

        // Find common destinations in both dictionaries
        var commonDestinations = hotelDestinations
            .Where(hotelCountry => transportDestinations.ContainsKey(hotelCountry.Key))
            .ToDictionary(
                hotelCountry => hotelCountry.Key,
                hotelCountry => hotelCountry.Value.Intersect(transportDestinations[hotelCountry.Key]).ToList()
            );

        return new GetAvailableDestinationsResponse(commonDestinations);
    }

    public async Task<GetReservationsResponse> GetReservations(GetReservationsRequest request)
    {
        await using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var reservations = await FetchReservations(dbContext)
            .Where(r => r.UserId == request.UserId)
            .ToListAsync();

        return new GetReservationsResponse(reservations.Select(r => r.ToDto()).ToList());
    }

    public async Task<GetSingleReservationResponse> GetSingleReservation(
        GetSingleReservationRequest getSingleReservationRequest)
    {
        await using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var reservation = await FetchReservations(dbContext)
            .FirstOrDefaultAsync(r => r.Id == getSingleReservationRequest.ReservationId);

        return new GetSingleReservationResponse(reservation?.ToDto());
    }

    public async Task<BuyResponse> Buy(BuyRequest buyRequest)
    {
        await using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        try
        {
            // Fetch reservation
            var reservation = await FetchReservations(dbContext)
                .FirstOrDefaultAsync(r => r.Id == buyRequest.ReservationId);

            if (reservation == null || reservation.Finalized) return new BuyResponse(false);

            // Mark reservation as being paid for in database
            var beingPaidFor = new BeingPaidFor
            {
                Id = Guid.NewGuid(),
                ReservationId = reservation.Id,
                CancellationDate = null
            };

            await dbContext.BeingPaidFors.AddAsync(beingPaidFor);
            await dbContext.SaveChangesAsync();

            var paymentResponse = await CallPaymentService(buyRequest.PaymentInfo);

            if (paymentResponse)
            {
                // If payment service returned True, mark as finalized
                reservation.Finalized = true;
                await dbContext.SaveChangesAsync();
                return new BuyResponse(true);
            }

            // Otherwise, modify active BeingPaidFor as cancelled
            beingPaidFor.CancellationDate = DateTime.UtcNow;
            await dbContext.SaveChangesAsync();
            return new BuyResponse(false);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while processing payment for reservation.");
            return new BuyResponse(false);
        }
    }

    public async Task<GetPopularOffersResponse> GetPopularOffers()
    {
        var destinationsResponse = await _getPopularDestinationsClient.GetResponse<GetPopularDestinationsResponse>(
            new GetPopularDestinationsRequest());

        // offer is a Dict<Country: Dict<City : List<Hotels>>>
        var offers = new Dictionary<string, Dictionary<string, List<string>>>();

        // iterate over destinationsResponse, extract To Address from each one and save City + Country
        foreach (var transport in destinationsResponse.Message.TransportOptions)
        {
            var country = transport.ToCountry;
            var city = transport.ToCity;

            if (!offers.ContainsKey(country)) offers[country] = new Dictionary<string, List<string>>();

            if (!offers[country].ContainsKey(city)) offers[country][city] = new List<string>();
        }

        // Get all hotels
        var hotelsResponse = await _getHotelsClient.GetResponse<GetHotelsResponse>(new GetHotelsRequest());

        // For each City + Country combination save list of hotels in this location
        hotelsResponse.Message.Hotels
            .Where(hotel => offers.ContainsKey(hotel.Country) && offers[hotel.Country].ContainsKey(hotel.City))
            .ToList()
            .ForEach(hotel => offers[hotel.Country][hotel.City].Add(hotel.Name));
        // TODO: do not return destinations with 0 hotels
        return new GetPopularOffersResponse(offers);
    }

    public async Task<CreateReservationResponse> CreateReservation(CreateReservationRequest createReservationRequest)
    {
        await using var dbContext = _dbContextFactory.CreateDbContext();
        await using var transaction = await dbContext.Database.BeginTransactionAsync();
        Response<HotelBookRoomsResponse>? hotelBookRoomsResponse = null;
        try
        {
            var toTransportOptionResponse =
                await _getTransportOptionClient.GetResponse<GetTransportOptionResponse>(
                    new GetTransportOptionRequest(createReservationRequest.Reservation.ToDestinationTransport));
            var fromTransportOptionResponse =
                await _getTransportOptionClient.GetResponse<GetTransportOptionResponse>(
                    new GetTransportOptionRequest(createReservationRequest.Reservation.FromDestinationTransport));

            if (toTransportOptionResponse.Message.TransportOption == null ||
                fromTransportOptionResponse.Message.TransportOption == null)
                throw new Exception("Transport options do not exist");

            // Try to book hotel with given number of rooms
            hotelBookRoomsResponse = await _bookRoomsClient.GetResponse<HotelBookRoomsResponse>(
                new HotelBookRoomsRequest(new HotelBookRoomsDto
                {
                    Id = createReservationRequest.Reservation.Hotel,
                    Start = toTransportOptionResponse.Message.TransportOption.Start,
                    NumberOfNights = (int)(fromTransportOptionResponse.Message.TransportOption.Start - 
                                           toTransportOptionResponse.Message.TransportOption.End).TotalDays,
                    Sizes = createReservationRequest.Reservation.Rooms
                }));

            if (hotelBookRoomsResponse.Message.RoomReservations == null ||
                !hotelBookRoomsResponse.Message.RoomReservations.Any())
                throw new Exception("Failed to book hotel rooms");

            // Try to reserve ToDestinationTransport
            var toDestinationTransportResponse =
                await _subtractSeatsClient.GetResponse<TransportOptionSubtractSeatsResponse>(
                    new TransportOptionSubtractSeatsRequest(createReservationRequest.Reservation.ToDestinationTransport,
                        GetTotalNumberOfPeople(createReservationRequest.Reservation)));

            if (toDestinationTransportResponse == null || !toDestinationTransportResponse.Message.Success)
            {
                await RevertHotelBooking(createReservationRequest.Reservation.Hotel, 
                    hotelBookRoomsResponse.Message.RoomReservations.Select(room => room.Id).ToList());
                throw new Exception("Failed to book transport option");
            };

            // Try to reserve FromDestinationTransport
            var fromDestinationTransportResponse =
                await _subtractSeatsClient.GetResponse<TransportOptionSubtractSeatsResponse>(
                    new TransportOptionSubtractSeatsRequest(
                        createReservationRequest.Reservation.FromDestinationTransport,
                        GetTotalNumberOfPeople(createReservationRequest.Reservation)));


            if (fromDestinationTransportResponse == null || !fromDestinationTransportResponse.Message.Success)
            {
                await RevertTransportBooking(createReservationRequest.Reservation.ToDestinationTransport,
                    GetTotalNumberOfPeople(createReservationRequest.Reservation));
                await RevertHotelBooking(createReservationRequest.Reservation.Hotel, 
                    hotelBookRoomsResponse.Message.RoomReservations.Select(room => room.Id).ToList());
                throw new Exception("Failed to book transport option");
            }

            // 4. If all above were positive, create Reservation object and add it to databas
            var reservation = await ReservationFromDtos(createReservationRequest, hotelBookRoomsResponse,
                toTransportOptionResponse, fromTransportOptionResponse);

            await dbContext.Reservations.AddAsync(reservation);
            await dbContext.SaveChangesAsync();

            await transaction.CommitAsync();
            _timerManager.StartInitialTimer(reservation.Id);
            return new CreateReservationResponse(reservation.ToDto());
        }
        catch (Exception ex)
        {
            // Revert everything
            await RevertTransportBooking(createReservationRequest.Reservation.ToDestinationTransport,
                GetTotalNumberOfPeople(createReservationRequest.Reservation));
            await RevertTransportBooking(createReservationRequest.Reservation.FromDestinationTransport,
                GetTotalNumberOfPeople(createReservationRequest.Reservation));
            if (hotelBookRoomsResponse is { Message.RoomReservations: not null })
            {
                await RevertHotelBooking(createReservationRequest.Reservation.Hotel,
                    hotelBookRoomsResponse.Message.RoomReservations.Select(room => room.Id).ToList());
            }
            _logger.LogError(ex, "Error occurred while creating reservation, reverting transactions");
            await transaction.RollbackAsync();

            return new CreateReservationResponse(null);
        }
    }

    public async Task<GetAvailableToursResponse> GetAvailableTours(GetAvailableToursRequest request)
    {
        var numPeople = request.Tours.NumPeople == 0 ? 1 : request.Tours.NumPeople;
        var minStart = request.Tours.MinStart?.ToUniversalTime();
        var maxEnd = request.Tours.MaxEnd?.ToUniversalTime();
        var toTransportSearchDto = new TransportOptionSearchDto
        {
            SeatsMinimum = numPeople,
            SourceCity = request.Tours.SourceCity,
            SourceCountry = request.Tours.SourceCountry,
            DestinationCity = request.Tours.DestinationCity,
            DestinationCountry = request.Tours.DestinationCountry,
            Type = request.Tours.Type,
            MinStart = minStart,
            MaxEnd = maxEnd
        };

        var fromTransportSearchDto = new TransportOptionSearchDto
        {
            SeatsMinimum = numPeople,
            SourceCity = request.Tours.DestinationCity,
            SourceCountry = request.Tours.DestinationCountry,
            DestinationCity = request.Tours.SourceCity,
            DestinationCountry = request.Tours.SourceCountry,
            Type = request.Tours.Type,
            MinStart = minStart,
            MaxEnd = maxEnd
        };
        // Get all hotels, filter them by City and Country (if the properties are not null)
        // Iterate over the list of possible hotels, for each hotel construct all possible pairs of transport options
        // A pair is valid when:
        // MaxDuration > fromHotelTransportOption.End - toHotelTransportOption.Start > MinDuration
        // toHotelTransportOption.From == fromHotelTransportOption.To && toHotelTransportOption.To == fromHotelTransportOption.From
        // For each pair call HotelCheckIfAvailableForTours(pair)
        // if response was True, this tuple (toHotelTransportOption, fromHotelTransportOption, Hotel> is valid
        // Construct tour from that tuple and add it to list
        var allHotelsResponse = await _getHotelsClient.GetResponse<GetHotelsResponse>(new GetHotelsRequest());

        var filteredResponses = allHotelsResponse.Message.Hotels
            .Where(hotel => (request.Tours.DestinationCity == null || hotel.City == request.Tours.DestinationCity) &&
                            (request.Tours.DestinationCountry == null ||
                             hotel.Country == request.Tours.DestinationCountry))
            .ToList();

        var fromHotelTransportOptionsResponse = await _transportSearchClient.GetResponse<TransportOptionSearchResponse>(
            new TransportOptionSearchRequest(fromTransportSearchDto));

        var toHotelTransportOptionsResponse = await _transportSearchClient.GetResponse<TransportOptionSearchResponse>(
            new TransportOptionSearchRequest(toTransportSearchDto));

        var maxDuration = request.Tours.MaxDuration == null || request.Tours.MaxDuration > 60
            ? 60
            : request.Tours.MaxDuration;
        var tours = new List<TourDto>();

        foreach (var hotel in filteredResponses)
        foreach (var toHotelTransportOption in toHotelTransportOptionsResponse.Message.TransportOptions)
            if (toHotelTransportOption.ToCity == hotel.City && toHotelTransportOption.ToCountry == hotel.Country)
                foreach (var fromHotelTransportOption in fromHotelTransportOptionsResponse.Message.TransportOptions)
                {
                    var duration = (int)(fromHotelTransportOption.End - toHotelTransportOption.Start).TotalDays;
                    if (duration > (request.Tours.MinDuration ?? 0) &&
                        duration < maxDuration &&
                        fromHotelTransportOption.FromCity == toHotelTransportOption.ToCity &&
                        fromHotelTransportOption.FromCountry == toHotelTransportOption.ToCountry &&
                        fromHotelTransportOption.ToCity == toHotelTransportOption.FromCity &&
                        fromHotelTransportOption.ToCountry == toHotelTransportOption.FromCountry)
                    {
                        var hotelAvailableResponse =
                            await _hotelCheckAvailabilityClient.GetResponse<HotelCheckAvailabilityResponse>(
                                new HotelCheckAvailabilityRequest(
                                    hotel.Id,
                                    toHotelTransportOption.End,
                                    fromHotelTransportOption.Start,
                                    numPeople));

                        if (!hotelAvailableResponse.Message.Found) continue;

                        var tour = new TourDto
                        {
                            ToHotelTransportOptionId = toHotelTransportOption.Id,
                            HotelId = hotel.Id,
                            FromHotelTransportOptionId = fromHotelTransportOption.Id,
                            TypeOfTransport = toHotelTransportOption.Type,
                            HotelCity = hotel.City,
                            FromCity = toHotelTransportOption.FromCity,
                            DateTime = toHotelTransportOption.Start,
                            NumberOfNights = duration
                        };
                        tours.Add(tour);
                    }
                }

        return new GetAvailableToursResponse(tours);
    }

    public async Task<ReservationGetTransportOptionResponse> ReservationGetTransportOption(
        ReservationGetTransportOptionRequest getTransportOptionRequest)
    {
        var response =
            await _getTransportOptionClient.GetResponse<GetTransportOptionResponse>(
                new GetTransportOptionRequest(getTransportOptionRequest.Id));
        return new ReservationGetTransportOptionResponse(response.Message.TransportOption);
    }

    public async Task<ReservationGetTransportOptionsResponse> ReservationGetTransportOptions()
    {
        var response =
            await _getTransportOptionsClient.GetResponse<GetTransportOptionsResponse>(
                new GetTransportOptionsRequest());
        return new ReservationGetTransportOptionsResponse(response.Message.TransportOptions);
    }

    public async Task<ReservationGetHotelResponse> ReservationGetHotel(ReservationGetHotelRequest getHotelRequest)
    {
        var response = await _getHotelClient.GetResponse<GetHotelResponse>(new GetHotelRequest(getHotelRequest.Id));
        return new ReservationGetHotelResponse(response.Message.Hotel);
    }

    public async Task<ReservationGetHotelsResponse> ReservationGetHotels()
    {
        var response = await _getHotelsClient.GetResponse<GetHotelsResponse>(new GetHotelsRequest());
        return new ReservationGetHotelsResponse(response.Message.Hotels);
    }

    public async Task<GetAvailableRoomsResponse> GetAvailableRooms(
        GetAvailableRoomsRequest getAvailableRoomsRequest)
    {
        var response = await _getAvailableRoomsClient.GetResponse<HotelGetAvailableRoomsResponse>(
            new HotelGetAvailableRoomsRequest(getAvailableRoomsRequest.HotelId, getAvailableRoomsRequest.Start,
                getAvailableRoomsRequest.End));
        return new GetAvailableRoomsResponse(response.Message.Rooms);
    }
}
