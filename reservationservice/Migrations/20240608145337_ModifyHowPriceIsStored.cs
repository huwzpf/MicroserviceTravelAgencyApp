using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class ModifyHowPriceIsStored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FoodPricePerNight",
                table: "Reservations",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FromTransportOptionPrice",
                table: "Reservations",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ToTransportOptionPrice",
                table: "Reservations",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PricePerRoomPerNight",
                table: "HotelRoomReservations",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodPricePerNight",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "FromTransportOptionPrice",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ToTransportOptionPrice",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "PricePerRoomPerNight",
                table: "HotelRoomReservations");
        }
    }
}
