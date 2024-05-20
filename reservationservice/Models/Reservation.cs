using System;
using System.Collections.Generic;
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
    public List<BeingPaidFor> BeingPaidFors { get; init; } = new List<BeingPaidFor>();
    
    public ReservationDto ToDto()
    {
        return new ReservationDto
        {
            Id = this.Id,
            NumberOfAdults = this.NumAdults,
            NumberOfUnder3 = this.NumUnder3,
            NumberOfUnder10 = this.NumUnder10,
            NumberOfUnder18 = this.NumUnder18,
            ToHotelTransportOptionId = this.ToDestinationTransport,
            HotelId = this.HotelId,
            Rooms = this.HotelRoomReservations.GroupBy
                    (r =>  r.Size).Select(group => new ReservationHotelRoom
                    {
                        Size = group.Key,
                        Number = group.Count() 
                    })
                    .ToList(),
            FromHotelTransportOptionId = this.FromDestinationTransport,
            Finalized = this.Finalized,
            DateTime = this.StartDate,
            NumberOfNights = this.NumberOfNights,
            FoodIncluded = this.FoodIncluded,
            Price = this.Price,
            HotelCity = this.ToCity,
            TypeOfTransport = this.TransportType,
            FromCity = this.FromCity,
            CancellationDate = this.CancellationDate,
            ReservedUntil = this.ReservedUntil
        };
    }
}

public class HotelRoomReservation
{
    public int Size {get; set;}
    public int nRooms {get; set;}
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