using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotelservice.Migrations
{
    public partial class _18052058 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RoomsId1",
                table: "RoomReservations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RoomsId1",
                table: "RoomReservations",
                column: "RoomsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomReservations_Rooms_RoomsId1",
                table: "RoomReservations",
                column: "RoomsId1",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomReservations_Rooms_RoomsId1",
                table: "RoomReservations");

            migrationBuilder.DropIndex(
                name: "IX_RoomReservations_RoomsId1",
                table: "RoomReservations");

            migrationBuilder.DropColumn(
                name: "RoomsId1",
                table: "RoomReservations");
        }
    }
}
