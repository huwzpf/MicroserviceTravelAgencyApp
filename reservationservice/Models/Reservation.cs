using contracts.Dtos;

namespace reservationservice.Models;

public class Reservation
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public int NumAdults { get; init; }
    public int NumUnder3 { get; init; }
    public int NumUnder10 { get; init; }
    public int NumUnder18 { get; init; }
    public Guid ToDestinationTransport { get; init; }
    public Guid HotelId { get; init; }
    public List<HotelRoomReservation> HotelRoomReservations { get; init; } = new();
    public Guid FromDestinationTransport { get; init; }
    public bool Finalized { get; set; }
    public DateTime StartDate { get; init; }
    public int NumberOfNights { get; init; }
    public decimal Price { get; init; }
    public string ToCity { get; init; }
    public string? FromCity { get; init; }
    public string TransportType { get; init; }
    public DateTime ReservedUntil { get; init; }
    public bool FoodIncluded { get; set; }
    public string HotelName { get; set; }

    public DateTime? CancellationDate { get; set; }
    public List<BeingPaidFor> BeingPaidFors { get; init; } = new();

    public ReservationDto ToDto()
    {
        return new ReservationDto
        {
            Id = Id,
            NumberOfAdults = NumAdults,
            NumberOfUnder3 = NumUnder3,
            NumberOfUnder10 = NumUnder10,
            NumberOfUnder18 = NumUnder18,
            ToHotelTransportOptionId = ToDestinationTransport,
            HotelId = HotelId,
            Rooms = HotelRoomReservations.Select(r => new ReservationHotelRoom
                {
                    Size = r.Size,
                    Number = r.nRooms
                })
                .ToList(),
            FromHotelTransportOptionId = FromDestinationTransport,
            Finalized = Finalized,
            DateTime = StartDate,
            NumberOfNights = NumberOfNights,
            FoodIncluded = FoodIncluded,
            Price = Price,
            HotelCity = ToCity,
            TypeOfTransport = TransportType,
            FromCity = FromCity,
            CancellationDate = CancellationDate,
            ReservedUntil = ReservedUntil
        };
    }
}

public class HotelRoomReservation
{
    public int Size { get; set; }
    public int nRooms { get; set; }
    public Guid Id { get; init; }
    public Guid ReservationId { get; init; } // Foreign key property
    public Guid HotelRoomReservationObjectId { get; init; }
}

public class BeingPaidFor
{
    public Guid Id { get; init; }
    public Guid ReservationId { get; init; } // Foreign key property
    public DateTime? CancellationDate { get; set; }
}