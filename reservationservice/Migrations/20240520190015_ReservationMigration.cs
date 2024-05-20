using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class ReservationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    NumAdults = table.Column<int>(type: "integer", nullable: false),
                    NumUnder3 = table.Column<int>(type: "integer", nullable: false),
                    NumUnder10 = table.Column<int>(type: "integer", nullable: false),
                    NumUnder18 = table.Column<int>(type: "integer", nullable: false),
                    ToDestinationTransport = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromDestinationTransport = table.Column<Guid>(type: "uuid", nullable: false),
                    Finalized = table.Column<bool>(type: "boolean", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NumberOfNights = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ToCity = table.Column<string>(type: "text", nullable: false),
                    FromCity = table.Column<string>(type: "text", nullable: true),
                    TransportType = table.Column<string>(type: "text", nullable: false),
                    ReservedUntil = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FoodIncluded = table.Column<bool>(type: "boolean", nullable: false),
                    HotelName = table.Column<string>(type: "text", nullable: false),
                    CancellationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

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
                    Size = table.Column<int>(type: "integer", nullable: false),
                    nRooms = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
