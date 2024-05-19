using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class FullDatabaseImplementation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FromCity",
                table: "Reservations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FromDestinationTransport",
                table: "Reservations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "NumAdults",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumUnder10",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumUnder18",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumUnder3",
                table: "Reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedUntil",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ToCity",
                table: "Reservations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ToDestinationTransport",
                table: "Reservations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "TransportType",
                table: "Reservations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BeingPaidFors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CancellationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeingPaidFors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeingPaidFors_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoomReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelRoomReservationObjectId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoomReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRoomReservations_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeingPaidFors_ReservationId",
                table: "BeingPaidFors",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRoomReservations_ReservationId",
                table: "HotelRoomReservations",
                column: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeingPaidFors");

            migrationBuilder.DropTable(
                name: "HotelRoomReservations");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "FromCity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "FromDestinationTransport",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumAdults",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumUnder10",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumUnder18",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "NumUnder3",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservedUntil",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ToCity",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ToDestinationTransport",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "TransportType",
                table: "Reservations");
        }
    }
}
