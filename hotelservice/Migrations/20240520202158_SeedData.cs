using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotelservice.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "FoodPricePerPerson", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"), "Tokyo", "Japan", 25m, "Tokyo Hotel", "Shinjuku" },
                    { new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"), "Gdansk", "Poland", 15m, "Gdansk Hotel", "Dluga" },
                    { new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"), "Berlin", "Germany", 20m, "Berlin Hotel", "Alexanderplatz" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "HotelId", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("19439c33-13f9-4a18-8dea-8c0ef418f3ca"), 5, new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"), 150m, 35 },
                    { new Guid("31990f0a-59b5-4cfb-968e-0676d9ce6108"), 5, new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"), 100m, 25 },
                    { new Guid("4155fad1-de49-46ce-b850-d6d617355642"), 5, new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"), 120m, 30 },
                    { new Guid("7931e403-43df-4fce-9dd8-9a84fc84fcf3"), 5, new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"), 200m, 22 },
                    { new Guid("8cb00db1-8309-47ee-b27b-87c23aacdcda"), 5, new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"), 80m, 20 },
                    { new Guid("a53bb938-91d1-4c65-9fec-ea81ce33cf61"), 5, new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"), 300m, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("19439c33-13f9-4a18-8dea-8c0ef418f3ca"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("31990f0a-59b5-4cfb-968e-0676d9ce6108"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4155fad1-de49-46ce-b850-d6d617355642"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7931e403-43df-4fce-9dd8-9a84fc84fcf3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8cb00db1-8309-47ee-b27b-87c23aacdcda"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a53bb938-91d1-4c65-9fec-ea81ce33cf61"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("52b1252e-9555-4933-a6e0-8b47477a133c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("9cc84410-13da-4d10-b485-b053bc22ddfb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b9544f88-c68e-4dcf-8f0e-bce60b680468"));
        }
    }
}
