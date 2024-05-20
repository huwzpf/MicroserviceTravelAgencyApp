using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace transportservice.Migrations
{
    public partial class TransportMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransportOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PriceAdult = table.Column<decimal>(type: "numeric", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    InitialSeats = table.Column<int>(type: "integer", nullable: false),
                    FromCity = table.Column<string>(type: "text", nullable: false),
                    FromCountry = table.Column<string>(type: "text", nullable: false),
                    FromStreet = table.Column<string>(type: "text", nullable: false),
                    FromShowName = table.Column<string>(type: "text", nullable: true),
                    ToCity = table.Column<string>(type: "text", nullable: false),
                    ToCountry = table.Column<string>(type: "text", nullable: false),
                    ToStreet = table.Column<string>(type: "text", nullable: false),
                    ToShowName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TransportOptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<decimal>(type: "numeric", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_TransportOptions_TransportOptionId",
                        column: x => x.TransportOptionId,
                        principalTable: "TransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatsChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TransportOptionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ChangeBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatsChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatsChanges_TransportOptions_TransportOptionId",
                        column: x => x.TransportOptionId,
                        principalTable: "TransportOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_TransportOptionId",
                table: "Discounts",
                column: "TransportOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatsChanges_TransportOptionId",
                table: "SeatsChanges",
                column: "TransportOptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "SeatsChanges");

            migrationBuilder.DropTable(
                name: "TransportOptions");
        }
    }
}
