using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class AddHotelIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HotelId",
                table: "Reservations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Reservations");
        }
    }
}
