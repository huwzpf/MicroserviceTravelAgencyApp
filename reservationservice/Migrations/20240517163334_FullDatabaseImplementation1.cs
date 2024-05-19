using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reservationservice.Migrations
{
    public partial class FullDatabaseImplementation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CancellationDate",
                table: "Reservations",
                type: "timestamp with time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancellationDate",
                table: "Reservations");
        }
    }
}
