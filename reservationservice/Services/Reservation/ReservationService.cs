using System;
using System.Collections.Generic;using contracts;
using contracts.Dtos;
using MassTransit;
using reservationservice.Persistence;

namespace reservationservice.Services.Reservation;

    public class ReservationService
    {
        private readonly ReservationDbContext _dbContext;
        private readonly IRequestClient<GetTransportOptionRequest> _getTransportOptionClient;
        private readonly IRequestClient<GetTransportOptionsRequest> _getTransportOptionsClient;
        private readonly IRequestClient<GetHotelRequest> _getHotelClient;
        private readonly IRequestClient<GetHotelsRequest> _getHotelsClient;
        private readonly IRequestClient<HotelGetAvailableRoomsRequest> _getAvailableRoomsClient;
        private readonly ILogger<ReservationService> _logger;

        public ReservationService(ReservationDbContext dbContext,
            IRequestClient<GetTransportOptionRequest> getTransportOptionClient,
            IRequestClient<GetTransportOptionsRequest> getTransportOptionsClient,
            IRequestClient<GetHotelRequest> getHotelClient,
            IRequestClient<GetHotelsRequest> getHotelsClient,
            IRequestClient<HotelGetAvailableRoomsRequest> getAvailableRoomsClient,
            ILogger<ReservationService> logger)
        {
            _dbContext = dbContext;
            _getTransportOptionClient = getTransportOptionClient;
            _getTransportOptionsClient = getTransportOptionsClient;
            _getHotelClient = getHotelClient;
            _getHotelsClient = getHotelsClient;
            _getAvailableRoomsClient = getAvailableRoomsClient;
            _logger = logger;
        }

        public GetAvailableDestinationsResponse GetAvailableDestinations(
            GetAvailableDestinationsRequest GetAvailableDestinationsRequest)
        {
            var destinations = new Dictionary<string, List<string>>
            {
                { "Poland", new List<string> { "Warsaw", "Krakow" } },
                { "Germany", new List<string> { "Berlin", "Munich" } }
            };
            return new GetAvailableDestinationsResponse(destinations);
        }

        public GetReservationsResponse GetReservations(GetReservationsRequest getReservationsRequest)
        {
            var reservations = new List<ReservationDto>
            {
                new ReservationDto
                {
                    Id = Guid.NewGuid(),
                    UserId = getReservationsRequest.UserId,
                    NumAdults = 2,
                    NumUnder3 = 0,
                    NumUnder10 = 1,
                    NumUnder18 = 0,
                    ToDestinationTransport = Guid.NewGuid(),
                    HotelRoomReservations = new List<Guid> { Guid.NewGuid() },
                    FromDestinationTransport = Guid.NewGuid(),
                    Finalized = true,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(7),
                    Price = 1500.00m,
                    ToCity = "Berlin",
                    FromCity = "Warsaw",
                    TransportType = "Train",
                    ReservedUntil = DateTime.UtcNow.AddMonths(1)
                }
            };
            return new GetReservationsResponse(reservations);
        }

        public GetSingleReservationResponse GetSingleReservation(
            GetSingleReservationRequest getSingleReservationRequest)
        {
            var reservation = new ReservationDto
            {
                Id = getSingleReservationRequest.ReservationId,
                UserId = Guid.NewGuid(),
                NumAdults = 2,
                NumUnder3 = 0,
                NumUnder10 = 1,
                NumUnder18 = 0,
                ToDestinationTransport = Guid.NewGuid(),
                HotelRoomReservations = new List<Guid> { Guid.NewGuid() },
                FromDestinationTransport = Guid.NewGuid(),
                Finalized = true,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(7),
                Price = 1500.00m,
                ToCity = "Berlin",
                FromCity = "Warsaw",
                TransportType = "Train",
                ReservedUntil = DateTime.UtcNow.AddMonths(1)
            };
            return new GetSingleReservationResponse(reservation);
        }

        public BuyResponse Buy(BuyRequest buyRequest)
        {
            return new BuyResponse(true);
        }

        public GetPopularOffersResponse GetPopularOffers(GetPopularOffersRequest GetPopularOffersRequest)
        {
            var offers = new Dictionary<string, Dictionary<string, List<string>>>
            {
                {
                    "Poland", new Dictionary<string, List<string>>
                    {
                        {
                            "Warsaw", new List<string> { "HotelA1", "HotelA2", "HotelA3" }
                        },
                        {
                            "Cracow", new List<string> { "HotelA4", "HotelA5" }
                        }
                    }
                },
                {
                    "Germany", new Dictionary<string, List<string>>
                    {
                        {
                            "Berlin", new List<string> { "HotelB1" }
                        }
                    }
                }
            };

            return new GetPopularOffersResponse(offers);
        }

        public CreateReservationResponse CreateReservation(CreateReservationRequest createReservationRequest)
        {
            var reservation = new ReservationDto
            {
                Id = Guid.NewGuid(),
                UserId = createReservationRequest.Reservation.UserId,
                NumAdults = createReservationRequest.Reservation.NumAdults,
                NumUnder3 = createReservationRequest.Reservation.NumUnder3,
                NumUnder10 = createReservationRequest.Reservation.NumUnder10,
                NumUnder18 = createReservationRequest.Reservation.NumUnder18,
                ToDestinationTransport = createReservationRequest.Reservation.ToDestinationTransport,
                HotelRoomReservations = new List<Guid> { Guid.NewGuid() },
                FromDestinationTransport = createReservationRequest.Reservation.FromDestinationTransport,
                Finalized = true,
                StartDate = createReservationRequest.Reservation.StartDate,
                EndDate = createReservationRequest.Reservation.EndDate,
                Price = 2000.00m,
                ToCity = "Berlin",
                FromCity = "Warsaw",
                TransportType = "Train",
                ReservedUntil = DateTime.UtcNow.AddMonths(1)
            };
            return new CreateReservationResponse(reservation);
        }

        public GetAvailableToursResponse GetAvailableTours(GetAvailableToursRequest getAvailableToursRequest)
        {
            var tours = new List<TourDto>
            {
                new TourDto
                {
                    ToDestinationTransportOption = Guid.NewGuid(),
                    Hotel = Guid.NewGuid(),
                    FromDestinationTransportOption = Guid.NewGuid(),
                    TransportType = "Bus",
                    FromCity = "Warsaw",
                    ToCity = "Berlin",
                    StartDate = DateTime.UtcNow,
                    DurationDays = 5
                }
            };
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

        public async Task<ReservationGetTransportOptionsResponse> ReservationGetTransportOptions(
            ReservationGetTransportOptionsRequest getTransportOptionsRequest)
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

        public async Task<ReservationGetHotelsResponse> ReservationGetHotels(ReservationGetHotelsRequest getHotelsRequest)
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
        