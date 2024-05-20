using System;
using System.Collections.Generic;using contracts;
using contracts.Dtos;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using reservationservice.Models;
using reservationservice.Persistence;
using Microsoft.Extensions.DependencyInjection;

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
        private readonly int ReservationDurationMinutes = 5;

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
        }
        
        private int GetTotalNumberOfPeople(CreateReservationDto reservation)
        {
            return reservation.NumAdults + reservation.NumUnder3 + reservation.NumUnder10 + reservation.NumUnder18;
        }
        
        private int GetTotalNumberOfPeople(Models.Reservation reservation)
        {
            return reservation.NumAdults + reservation.NumUnder3 + reservation.NumUnder10 + reservation.NumUnder18;
        }
        
        private async Task<Models.Reservation> ReservationFromDtos(CreateReservationRequest createReservationRequest,
            Response<HotelBookRoomsResponse> hotelBookRoomsResponse,
            Response<GetTransportOptionResponse> toTransportOptionResponse, Response<GetTransportOptionResponse> fromTransportOptionResponse)
        {
            var hotelResponse = await _getHotelClient.GetResponse<GetHotelResponse>(
                new GetHotelRequest(createReservationRequest.Reservation.Hotel));
            
            var newReservationGuid = Guid.NewGuid();
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
                HotelRoomReservations = hotelBookRoomsResponse.Message.RoomReservations.Select(rr => new Models.HotelRoomReservation
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
                NumberOfNights = (int)(fromTransportOptionResponse.Message.TransportOption.Start
                                       - toTransportOptionResponse.Message.TransportOption.End).TotalDays,
                Price = CalculatePrice(
                    createReservationRequest.Reservation, 
                    hotelResponse.Message.Hotel,
                    toTransportOptionResponse.Message.TransportOption,
                    fromTransportOptionResponse.Message.TransportOption
                ),
                FromCity = toTransportOptionResponse.Message.TransportOption.FromCity,
                ToCity = toTransportOptionResponse.Message.TransportOption.ToCity,
                FoodIncluded = createReservationRequest.Reservation.WithFood,
                TransportType = toTransportOptionResponse.Message.TransportOption.Type,
                ReservedUntil = DateTime.Now.AddMinutes(ReservationDurationMinutes),
                BeingPaidFors = new List<BeingPaidFor>()
            };
            return reservation;
        }

        private async Task RevertHotelBooking(Guid hotelId, List<Guid> roomBookings)
        {
            // Implement logic to revert hotel booking based on roomReservations
            await _cancelBookRoomsClient.GetResponse<HotelCancelBookRoomsResponse>(
                new HotelCancelBookRoomsRequest(hotelId, roomBookings));
        }

        private async Task RevertTransportBooking(Guid transportOptionId, int seats)
        {
            // Implement logic to add back seats to the transport option
            await _addSeatsClient.GetResponse<TransportOptionAddSeatsResponse>(
                new TransportOptionAddSeatsRequest(transportOptionId, seats));
        }

        private decimal CalculatePrice(CreateReservationDto reservation, HotelDto hotel, TransportOptionDto toTransport, TransportOptionDto fromTransport)
        {
            decimal totalPrice = 0;

            // Calculate the hotel room price
            foreach (var room in reservation.Rooms)
            {
                int roomSize = room.Key;
                int roomCount = room.Value;
                var hotelRoom = hotel.Rooms.FirstOrDefault(r => r.Size == roomSize);
                if (hotelRoom != null)
                {
                    decimal roomPrice = hotelRoom.Price;
                    totalPrice += roomPrice * roomCount;
                }
                else
                {
                    throw new Exception($"Hotel does not have rooms of size {roomSize}");
                }
            }

            // Calculate the transport price for ToDestinationTransport
            totalPrice += reservation.NumAdults * toTransport.PriceAdult;
            totalPrice += reservation.NumUnder18 * toTransport.PriceUnder18;
            totalPrice += reservation.NumUnder10 * toTransport.PriceUnder10;
            totalPrice += reservation.NumUnder3 * toTransport.PriceUnder3;

            // Calculate the transport price for FromDestinationTransport
            totalPrice += reservation.NumAdults * fromTransport.PriceAdult;
            totalPrice += reservation.NumUnder18 * fromTransport.PriceUnder18;
            totalPrice += reservation.NumUnder10 * fromTransport.PriceUnder10;
            totalPrice += reservation.NumUnder3 * fromTransport.PriceUnder3;

            return totalPrice;
        }

        private async Task SetCancellationTimer(Guid reservationId)
        {
            var timer = new System.Timers.Timer(ReservationDurationMinutes * 60 * 1000); // 5 minutes in milliseconds
            timer.Elapsed += async (sender, e) => await OnTimerElapsed(reservationId, timer);
            timer.AutoReset = false; // Make sure it only runs once
            timer.Start();
        }

        private async Task OnTimerElapsed(Guid reservationId, System.Timers.Timer timer)
        {
            await using var dbContext = _dbContextFactory.CreateDbContext();
            
            // Todo?: add some kind of lock guard for timer (if it is not automagically disposed) 
            timer.Stop();
            
            var reservation = await dbContext.Reservations
                .Include(r => r.BeingPaidFors)
                .Include(r => r.HotelRoomReservations)
                .FirstOrDefaultAsync(r => r.Id == reservationId);
            
            if (reservation == null || reservation.Finalized)
            {
                timer.Dispose();
                return;
            }

            // check if reservation has non cancelled BeingPayedFor object
            // if yes, restart the timer and exit
            var nonCancelledBeingPaidFor = reservation.BeingPaidFors.Any(bp => !bp.CancellationDate.HasValue);

            if (nonCancelledBeingPaidFor)
            {
                // Restart the timer and exit
                timer.Start();
                return;
            }

            // otherwise (meaning there's no objects or all have cancellation date), dispose timer and cancel reservation 
            timer.Dispose();
            reservation.CancellationDate = DateTime.UtcNow;
            reservation.Finalized = true;
            // Revert hotel booking
            await RevertHotelBooking(reservation.HotelId, reservation.HotelRoomReservations.Select(room => room.Id).ToList());
            // Revert ToDestinationTransport
            await RevertTransportBooking(reservation.ToDestinationTransport, 
                GetTotalNumberOfPeople(reservation));
            
            await RevertTransportBooking(reservation.ToDestinationTransport, 
                GetTotalNumberOfPeople(reservation));
            

            dbContext.Reservations.Update(reservation);
            await dbContext.SaveChangesAsync();
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
            var transportOptionsResponse = await _getTransportOptionsClient.GetResponse<GetTransportOptionsResponse>(new GetTransportOptionsRequest());

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
            Dictionary<string, List<string>> transportDestinations =
                new Dictionary<string, List<string>>(transportDestinationsTo);
            
            foreach (var kvp in transportDestinationsFrom)
            {
                if (transportDestinations.ContainsKey(kvp.Key))
                {
                    transportDestinations[kvp.Key] = transportDestinations[kvp.Key]
                        .Concat(kvp.Value)
                        .Distinct()
                        .ToList();
                }
                else
                {
                    transportDestinations[kvp.Key] = kvp.Value;
                }
            }
            
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
            await using var dbContext = _dbContextFactory.CreateDbContext();
            var reservations = await dbContext.Reservations
                .Include(r => r.HotelRoomReservations)
                .Include(r => r.BeingPaidFors)
                .Where(r => r.UserId == request.UserId)
                .ToListAsync();

            return new GetReservationsResponse(reservations.Select(r => r.ToDto()).ToList());
        }

        public async Task<GetSingleReservationResponse> GetSingleReservation(
            GetSingleReservationRequest getSingleReservationRequest)
        {
            await using var dbContext = _dbContextFactory.CreateDbContext();
            var reservation = await dbContext.Reservations
                .Include(r => r.HotelRoomReservations)
                .Include(r => r.BeingPaidFors)
                .FirstOrDefaultAsync(r => r.Id == getSingleReservationRequest.ReservationId);

            return new GetSingleReservationResponse(reservation?.ToDto());
        }

        public async Task<BuyResponse> Buy(BuyRequest buyRequest)
        {
            await using var dbContext = _dbContextFactory.CreateDbContext();
            try
            {
                // Fetch reservation
                var reservation = await dbContext.Reservations
                    .Include(r => r.BeingPaidFors)
                    .FirstOrDefaultAsync(r => r.Id == buyRequest.ReservationId);

                if (reservation == null || reservation.Finalized)
                {
                    return new BuyResponse(false);
                }

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
                else
                {
                    // Otherwise, modify active BeingPaidFor as cancelled
                    beingPaidFor.CancellationDate = DateTime.UtcNow;
                    await dbContext.SaveChangesAsync();
                    return new BuyResponse(false);
                }
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
            
            var offers = new Dictionary<string, Dictionary<string, List<string>>>();
            
            // iterate over destinationsResponse, extract To Address from each one and save City + Country
            foreach (var transport in destinationsResponse.Message.TransportOptions)
            {
                var country = transport.ToCountry;
                var city = transport.ToCity;

                if (!offers.ContainsKey(country))
                {
                    offers[country] = new Dictionary<string, List<string>>();
                }

                if (!offers[country].ContainsKey(city))
                {
                    offers[country][city] = new List<string>();
                }
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

            try
            {
                
                var toTransportOptionResponse =
                    await _getTransportOptionClient.GetResponse<GetTransportOptionResponse>(
                        new GetTransportOptionRequest(createReservationRequest.Reservation.ToDestinationTransport));
                var fromTransportOptionResponse =
                    await _getTransportOptionClient.GetResponse<GetTransportOptionResponse>(
                        new GetTransportOptionRequest(createReservationRequest.Reservation.FromDestinationTransport));
                
                // Try to book hotel with given number of rooms
                var hotelBookRoomsResponse = await _bookRoomsClient.GetResponse<HotelBookRoomsResponse>(
                    new HotelBookRoomsRequest(new HotelBookRoomsDto
                    {
                        Id = createReservationRequest.Reservation.Hotel,
                        Start = toTransportOptionResponse.Message.TransportOption.Start,
                        NumberOfNights = (int)(fromTransportOptionResponse.Message.TransportOption.Start
                                               - toTransportOptionResponse.Message.TransportOption.End).TotalDays,
                        Sizes = createReservationRequest.Reservation.Rooms
                    }));

                if (hotelBookRoomsResponse.Message.RoomReservations == null || (!hotelBookRoomsResponse.Message.RoomReservations.Any()))
                {
                    throw new Exception("Failed to book hotel rooms");
                }

                // Try to reserve ToDestinationTransport
                var toDestinationTransportResponse = await _subtractSeatsClient.GetResponse<TransportOptionSubtractSeatsResponse>(
                    new TransportOptionSubtractSeatsRequest(createReservationRequest.Reservation.ToDestinationTransport, 
                        GetTotalNumberOfPeople(createReservationRequest.Reservation)));

                // 3. Try to reserve FromDestinationTransport
                var fromDestinationTransportResponse = await _subtractSeatsClient.GetResponse<TransportOptionSubtractSeatsResponse>(
                    new TransportOptionSubtractSeatsRequest(createReservationRequest.Reservation.FromDestinationTransport, 
                        GetTotalNumberOfPeople(createReservationRequest.Reservation)));

                // 4. If all above were positive, create Reservation object and add it to database
                var reservation = await ReservationFromDtos(createReservationRequest, hotelBookRoomsResponse,
                    toTransportOptionResponse, fromTransportOptionResponse);

                await dbContext.Reservations.AddAsync(reservation);
                await dbContext.SaveChangesAsync();

                await transaction.CommitAsync();
                SetCancellationTimer(reservation.Id);
                return new CreateReservationResponse(reservation.ToDto()); // Assuming you have a method to convert to DTO
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating reservation, reverting transactions");
                await transaction.RollbackAsync();

                return new CreateReservationResponse(null); // Returning null or appropriate error response
            }
        }
        
        public async Task<GetAvailableToursResponse> GetAvailableTours(GetAvailableToursRequest request)
        {
            var transportSearchDto = new TransportOptionSearchDto
            {
                SeatsMinimum = request.Tours.NumPeople,
                SourceCity = request.Tours.SourceCity,
                SourceCountry = request.Tours.SourceCountry,
                DestinationCity = request.Tours.DestinationCity,
                DestinationCountry = request.Tours.DestinationCountry,
                Type = request.Tours.Type,
                MinStart = request.Tours.MinStart,
                MaxEnd = request.Tours.MaxEnd
            };
            // Get all hotels, filter them by City and Country (if the properties are not null)
            // Iterate over the list of possible hotels, for each hotel construct all possible pairs of transport options
            // A pair is valid when:
            // MaxDuration > FromTransportOption.End - ToTransportOption.Start > MinDuration
            // ToTransportOption.From == FromTransportOption.To && ToTransportOption.To == FromTransportOption.From
            // For each pair call HotelCheckIfAvailableForTours(pair)
            // if response was True, this tuple (ToTransportOption, FromTransportOption, Hotel> is valid
            // Construct tour from that tuple and add it to list
            var allHotelsResponse = await _getHotelsClient.GetResponse<GetHotelsResponse>(new GetHotelsRequest());
            
            var filteredResponses = allHotelsResponse.Message.Hotels
                .Where(hotel => (request.Tours.DestinationCity == null || hotel.City == request.Tours.DestinationCity) &&
                                (request.Tours.DestinationCountry == null || hotel.Country == request.Tours.DestinationCountry))
                .ToList();
            var allTransportOptions = await _transportSearchClient.GetResponse<TransportOptionSearchResponse>(
                new TransportOptionSearchRequest(transportSearchDto));
            
            var tours = new List<TourDto>();

            foreach (var hotel in filteredResponses)
            {
                foreach (var toTransportOption in allTransportOptions.Message.TransportOptions)
                {
                    if (toTransportOption.ToCity == hotel.City &&
                        toTransportOption.ToCountry == hotel.Country)
                    {
                        foreach (var fromTransportOption in allTransportOptions.Message.TransportOptions)
                        {
                            var duration = (int)(fromTransportOption.End - toTransportOption.Start).TotalDays;
                            if (duration > request.Tours.MinDuration &&
                                duration < request.Tours.MaxDuration &&
                                toTransportOption.FromCity == fromTransportOption.ToCity &&
                                toTransportOption.FromCountry == fromTransportOption.ToCountry &&
                                toTransportOption.ToCity == fromTransportOption.FromCity &&
                                toTransportOption.ToCountry == fromTransportOption.FromCountry)
                            {
                                var hotelAvailable = 
                                    await _hotelCheckAvailabilityClient.GetResponse<HotelCheckAvailabilityResponse>(
                                        new HotelCheckAvailabilityRequest(
                                            hotel.Id,
                                            toTransportOption.End,
                                            fromTransportOption.Start,
                                            request.Tours.NumPeople));
                                if (!hotelAvailable.Message.Found)
                                {
                                    continue;
                                }
                                var tour = new TourDto
                                {
                                    ToHotelTransportOptionId = toTransportOption.Id,
                                    HotelId = hotel.Id,
                                    FromHotelTransportOptionId = fromTransportOption.Id,
                                    TypeOfTransport = toTransportOption.Type,
                                    HotelCity = hotel.City,
                                    FromCity = fromTransportOption.FromCity,
                                    DateTime = toTransportOption.Start,
                                    NumberOfNights = (fromTransportOption.Start - toTransportOption.Start).Days
                                };
                                tours.Add(tour);
                            }
                        }
                    }
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
        