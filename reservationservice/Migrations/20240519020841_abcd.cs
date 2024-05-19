using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class abcd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Reservations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservedUntil",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "FoodIncluded",
                table: "Reservations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "HotelName",
                table: "Reservations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfNights",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "HotelRoomReservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodIncluded",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "HotelName",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumberOfNights",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "HotelRoomReservations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReservedUntil",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
