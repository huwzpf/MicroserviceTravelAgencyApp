namespace contracts.Dtos;

public class HotelDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Dictionary<int, Tuple<decimal, int>> Rooms { get; set; } // sizeOfRoom -> (price, roomsCount)
    public List<RoomReservationDto> Bookings { get; set; }
    public AddressDto Address { get; set; }
    public List<DiscountDto> Discounts { get; set; }
    public decimal FoodPricePerPerson { get; set; }
}