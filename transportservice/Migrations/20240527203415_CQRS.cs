using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace transportservice.Migrations
{
    public partial class CQRS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_TransportOptions_TransportOptionId",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatsChanges_TransportOptions_TransportOptionId",
                table: "SeatsChanges");

            migrationBuilder.DropTable(
                name: "TransportOptions");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Discounts");

            migrationBuilder.CreateTable(
                name: "CommandTransportOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PriceAdult = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder3 = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder10 = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder18 = table.Column<decimal>(type: "numeric", nullable: false),
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
                    table.PrimaryKey("PK_CommandTransportOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueryTransportOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PriceAdult = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder3 = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder10 = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceUnder18 = table.Column<decimal>(type: "numeric", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Seats = table.Column<int>(type: "integer", nullable: false),
                    FromCity = table.Column<string>(type: "text", nullable: false),
                    FromCountry = table.Column<string>(type: "text", nullable: false),
                    FromStreet = table.Column<string>(type: "text", nullable: false),
                    FromShowName = table.Column<string>(type: "text", nullable: true),
                    ToCity = table.Column<string>(type: "text", nullable: false),
                    ToCountry = table.Column<string>(type: "text", nullable: false),
                    ToStreet = table.Column<string>(type: "text", nullable: false),
                    ToShowName = table.Column<string>(type: "text", nullable: true),
                    Discount = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryTransportOptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CommandTransportOptions",
                columns: new[] { "Id", "End", "FromCity", "FromCountry", "FromShowName", "FromStreet", "InitialSeats", "PriceAdult", "PriceUnder10", "PriceUnder18", "PriceUnder3", "Start", "ToCity", "ToCountry", "ToShowName", "ToStreet", "Type" },
                values: new object[,]
                {
                    { new Guid("16bf195b-a751-412a-9532-63b173212889"), new DateTime(2024, 5, 30, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9368), "London", "UK", null, "Heathrow", 120, 200m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9367), "Gdansk", "Poland", null, "Lech Walesa", "Plane" },
                    { new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"), new DateTime(2024, 6, 2, 1, 34, 14, 937, DateTimeKind.Utc).AddTicks(9356), "Berlin", "Germany", null, "Tegel", 100, 150m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9356), "Paris", "France", null, "Charles de Gaulle", "Plane" },
                    { new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"), new DateTime(2024, 5, 28, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9347), "Paris", "France", null, "Charles de Gaulle", 100, 150m, 0m, 0m, 0m, new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9337), "Berlin", "Germany", null, "Tegel", "Plane" },
                    { new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"), new DateTime(2024, 5, 29, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9361), "Tokyo", "Japan", null, "Narita", 150, 500m, 0m, 0m, 0m, new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9361), "Gdansk", "Poland", null, "Lech Walesa", "Plane" },
                    { new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"), new DateTime(2024, 6, 11, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9365), "Gdansk", "Poland", null, "Lech Walesa", 150, 500m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9364), "Tokyo", "Japan", null, "Narita", "Plane" }
                });

            migrationBuilder.InsertData(
                table: "QueryTransportOptions",
                columns: new[] { "Id", "Discount", "End", "FromCity", "FromCountry", "FromShowName", "FromStreet", "PriceAdult", "PriceUnder10", "PriceUnder18", "PriceUnder3", "Seats", "Start", "ToCity", "ToCountry", "ToShowName", "ToStreet", "Type" },
                values: new object[,]
                {
                    { new Guid("16bf195b-a751-412a-9532-63b173212889"), null, new DateTime(2024, 5, 30, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9645), "London", "UK", null, "Heathrow", 200m, 0m, 0m, 0m, 120, new DateTime(2024, 5, 30, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9645), "Gdansk", "Poland", null, "Lech Walesa", "Plane" },
                    { new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"), null, new DateTime(2024, 6, 2, 1, 34, 14, 937, DateTimeKind.Utc).AddTicks(9634), "Berlin", "Germany", null, "Tegel", 150m, 0m, 0m, 0m, 100, new DateTime(2024, 6, 1, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9634), "Paris", "France", null, "Charles de Gaulle", "Plane" },
                    { new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"), null, new DateTime(2024, 5, 28, 22, 34, 14, 937, DateTimeKind.Utc).AddTicks(9629), "Paris", "France", null, "Charles de Gaulle", 150m, 0m, 0m, 0m, 100, new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9627), "Berlin", "Germany", null, "Tegel", "Plane" },
                    { new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"), null, new DateTime(2024, 5, 29, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9640), "Tokyo", "Japan", null, "Narita", 500m, 0m, 0m, 0m, 150, new DateTime(2024, 5, 28, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9639), "Gdansk", "Poland", null, "Lech Walesa", "Plane" },
                    { new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"), null, new DateTime(2024, 6, 11, 6, 34, 14, 937, DateTimeKind.Utc).AddTicks(9642), "Gdansk", "Poland", null, "Lech Walesa", 500m, 0m, 0m, 0m, 150, new DateTime(2024, 6, 10, 20, 34, 14, 937, DateTimeKind.Utc).AddTicks(9642), "Tokyo", "Japan", null, "Narita", "Plane" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_CommandTransportOptions_TransportOptionId",
                table: "Discounts",
                column: "TransportOptionId",
                principalTable: "CommandTransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatsChanges_CommandTransportOptions_TransportOptionId",
                table: "SeatsChanges",
                column: "TransportOptionId",
                principalTable: "CommandTransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_CommandTransportOptions_TransportOptionId",
                table: "Discounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatsChanges_CommandTransportOptions_TransportOptionId",
                table: "SeatsChanges");

            migrationBuilder.DropTable(
                name: "CommandTransportOptions");

            migrationBuilder.DropTable(
                name: "QueryTransportOptions");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Discounts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TransportOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FromCity = table.Column<string>(type: "text", nullable: false),
                    FromCountry = table.Column<string>(type: "text", nullable: false),
                    FromShowName = table.Column<string>(type: "text", nullable: true),
                    FromStreet = table.Column<string>(type: "text", nullable: false),
                    InitialSeats = table.Column<int>(type: "integer", nullable: false),
                    PriceAdult = table.Column<decimal>(type: "numeric", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ToCity = table.Column<string>(type: "text", nullable: false),
                    ToCountry = table.Column<string>(type: "text", nullable: false),
                    ToShowName = table.Column<string>(type: "text", nullable: true),
                    ToStreet = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOptions", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_TransportOptions_TransportOptionId",
                table: "Discounts",
                column: "TransportOptionId",
                principalTable: "TransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatsChanges_TransportOptions_TransportOptionId",
                table: "SeatsChanges",
                column: "TransportOptionId",
                principalTable: "TransportOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
