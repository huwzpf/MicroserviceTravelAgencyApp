using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace transportservice.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TransportOptions",
                columns: new[] { "Id", "End", "FromCity", "FromCountry", "FromShowName", "FromStreet", "InitialSeats", "PriceAdult", "Start", "ToCity", "ToCountry", "ToShowName", "ToStreet", "Type" },
                values: new object[,]
                {
                    { new Guid("0836f771-6dab-4162-a9eb-e036d7fbe740"), new DateTime(2024, 5, 26, 1, 20, 6, 841, DateTimeKind.Utc).AddTicks(4761), "Berlin", "Germany", null, "Tegel", 100, 150m, new DateTime(2024, 5, 25, 20, 20, 6, 841, DateTimeKind.Utc).AddTicks(4761), "Paris", "France", null, "Charles de Gaulle", "Plane" },
                    { new Guid("1328aca2-bf3e-4ba0-b684-a39a1da0b5c0"), new DateTime(2024, 5, 21, 22, 20, 6, 841, DateTimeKind.Utc).AddTicks(4752), "Paris", "France", null, "Charles de Gaulle", 100, 150m, new DateTime(2024, 5, 21, 20, 20, 6, 841, DateTimeKind.Utc).AddTicks(4741), "Berlin", "Germany", null, "Tegel", "Plane" },
                    { new Guid("1c0ec85f-2093-46de-b36b-025e78e9bd1f"), new DateTime(2024, 5, 23, 22, 20, 6, 841, DateTimeKind.Utc).AddTicks(4910), "London", "UK", null, "Heathrow", 120, 200m, new DateTime(2024, 5, 23, 20, 20, 6, 841, DateTimeKind.Utc).AddTicks(4909), "Gdansk", "Poland", null, "Lech Walesa", "Plane" },
                    { new Guid("a889c081-5ee8-4e06-9cf6-52c6f9291556"), new DateTime(2024, 6, 4, 6, 20, 6, 841, DateTimeKind.Utc).AddTicks(4781), "Gdansk", "Poland", null, "Lech Walesa", 150, 500m, new DateTime(2024, 6, 3, 20, 20, 6, 841, DateTimeKind.Utc).AddTicks(4781), "Tokyo", "Japan", null, "Narita", "Plane" },
                    { new Guid("df19951a-99ce-43c9-9a77-44c79ed876ec"), new DateTime(2024, 5, 22, 6, 20, 6, 841, DateTimeKind.Utc).AddTicks(4765), "Tokyo", "Japan", null, "Narita", 150, 500m, new DateTime(2024, 5, 21, 20, 20, 6, 841, DateTimeKind.Utc).AddTicks(4765), "Gdansk", "Poland", null, "Lech Walesa", "Plane" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0836f771-6dab-4162-a9eb-e036d7fbe740"));

            migrationBuilder.DeleteData(
                table: "TransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1328aca2-bf3e-4ba0-b684-a39a1da0b5c0"));

            migrationBuilder.DeleteData(
                table: "TransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1c0ec85f-2093-46de-b36b-025e78e9bd1f"));

            migrationBuilder.DeleteData(
                table: "TransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a889c081-5ee8-4e06-9cf6-52c6f9291556"));

            migrationBuilder.DeleteData(
                table: "TransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("df19951a-99ce-43c9-9a77-44c79ed876ec"));
        }
    }
}
