using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotelservice.Migrations
{
    public partial class ScrappedHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FoodPricePerPerson = table.Column<decimal>(type: "numeric", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelId = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<decimal>(type: "numeric", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HotelId = table.Column<Guid>(type: "uuid", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomsId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoomsReserved = table.Column<int>(type: "integer", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CancelationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomReservations_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "FoodPricePerPerson", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("00fca576-8fd4-4ac1-97ce-8dbe8880301b"), "Brava", "hiszpania", 37m, "Cartago Nova by Alegria", "Paseo del Prado" },
                    { new Guid("086aec19-0d5e-4cdc-9f47-08477a6978ba"), "Turecka", "turcja", 107m, "Kolibri Hotel", "Atatürk Caddesi" },
                    { new Guid("09b224f1-17f3-469f-8867-d0663c86a2ad"), "Brava", "hiszpania", 96m, "Evenia Olympic Park", "Calle Mayor" },
                    { new Guid("0a3efaf9-b617-4289-8afc-06f4f5260106"), "Durres", "albania", 83m, "Pinea Resort & Spa", "Rruga e Dibres" },
                    { new Guid("0eca1b28-f97e-4363-b310-e9d321001a67"), "Chania", "grecja", 91m, "Rethymno Mare Water Park", "Leoforos Vasilissis Sofias" },
                    { new Guid("1335ee5b-7ca5-4bb6-a106-f28c5a15e654"), "Kalabria", "wlochy", 81m, "Hotel Orizzonte Blu", "Via Nazionale" },
                    { new Guid("15a863c6-f0af-46cc-814f-d37a1dcef9d8"), "Almeria", "hiszpania", 38m, "Evenia Zoraida Beach Resort", "Paseo del Prado" },
                    { new Guid("18519dfd-80db-41c4-aa75-f61803f90477"), "Riwiera", "chorwacja", 88m, "Nano", "Maksimirska ulica" },
                    { new Guid("22f44e2f-5cb2-4a2e-8bf4-d6b3c576f7ba"), "Kalabria", "wlochy", 47m, "Baia di Zambrone", "Via Veneto" },
                    { new Guid("3c876902-2e40-46ea-bbe2-700f8344aa16"), "Olimpijska", "grecja", 31m, "Dias Apartments", "Plateia Syntagmatos" },
                    { new Guid("450f571d-b811-4a35-9b01-e88f62003758"), "Riwiera", "chorwacja", 31m, "Villa Penava", "Trg bana Josipa Jelačića" },
                    { new Guid("4da21b0d-26ab-4ce1-af64-a18f729b05f0"), "Durres", "albania", 74m, "Casa Durres", "Rruga e Dibres" },
                    { new Guid("52e2248d-8c44-413e-8f75-9194126c34cc"), "Nero", "grecja", 56m, "Studia Katerina", "Leoforos Vasilissis Sofias" },
                    { new Guid("606eb796-f8c0-44c1-b6e7-d9c74c0e7aef"), "Durres", "albania", 94m, "Mel Holidays", "Bulevardi Bajram Curri" },
                    { new Guid("73b1ede0-a09e-42e5-8709-49982716aa64"), "Alam", "egipt", 83m, "Bliss Nada Beach Resort", "Sharia Tahrir" },
                    { new Guid("7965d57f-a0ba-408f-b4b2-c7e141df8abd"), "Kalabria", "wlochy", 79m, "San Domenico", "Via del Corso" },
                    { new Guid("7c0ce2fe-9a04-426a-833b-43e8ade405be"), "Brava", "hiszpania", 77m, "GHT Oasis Park & Spa", "Gran Vía" },
                    { new Guid("8c10ea27-8d72-4d6b-ad47-98f7131e4baf"), "Sheikh", "egipt", 74m, "Old Vic Resort Sharm", "Sharia Ramsis" },
                    { new Guid("8c6d9bc2-f359-4a7b-b4de-952cf48019aa"), "Durres", "albania", 31m, "Bonita Luxury Hotel", "Rruga Abdyl Frasheri" },
                    { new Guid("94c25c53-975c-452c-b35f-9112134ed5b7"), "Alam", "egipt", 97m, "Marina Resort Port Ghalib", "Sharia Tahrir" },
                    { new Guid("99073865-f88c-4f28-8173-2193299b411a"), "Marmaris", "turcja", 109m, "Turunc Resort", "Bağdat Caddesi" },
                    { new Guid("a4165ec6-43c0-4ba5-82bc-e9455e27be3f"), "Riwiera", "chorwacja", 116m, "Gradac", "Kapucinska ulica" },
                    { new Guid("aa282794-4b9d-47c5-b7f9-4d657ecdfe4b"), "Kalabria", "wlochy", 93m, "Rada Siri", "Via Veneto" },
                    { new Guid("aade28ca-437f-48cb-aee9-99a510b740e6"), "Alam", "egipt", 80m, "Protels Crystal Beach Resort", "Sharia Tahrir" },
                    { new Guid("b2534063-171c-4be8-93a3-4a60be8dc272"), "Luz", "hiszpania", 94m, "Estival Islantilla", "Calle Mayor" },
                    { new Guid("b49466bc-7701-4a23-9da8-4ea5b6bdec65"), "Sheikh", "egipt", 116m, "Falcon Naama Star", "Sharia Salah Salem" },
                    { new Guid("b729250c-f872-478b-a297-643840368782"), "Riwiera", "chorwacja", 83m, "Apartamenty Makarska", "Maksimirska ulica" },
                    { new Guid("b90c2fe3-4d24-4bcd-aa95-9659c1b5857e"), "Alam", "egipt", 89m, "MG Alexander The Great", "Sharia Gamal Abdel Nasser" },
                    { new Guid("c2b21d2c-9c87-4b3c-9898-76187afe18d1"), "Sheikh", "egipt", 76m, "Barcelo Tiran Sharm Resort", "Sharia Tahrir" },
                    { new Guid("cef41a55-9cd3-4144-ba46-c0a160dae3db"), "Vlora", "albania", 99m, "MonteCarlo Lungomare", "Rruga e Kavajes" },
                    { new Guid("d0cdfde2-390c-42bf-9ded-14dc608b195b"), "Vlora", "albania", 90m, "Monte Carlo Vlora", "Rruga 28 Nentori" },
                    { new Guid("d690b2bb-718a-4e7c-950a-dfbcc19e4108"), "Brava", "hiszpania", 67m, "Catalonia", "Calle de Alcalá" },
                    { new Guid("daedf97d-0277-4e8a-874f-038c0608f189"), "Turecka", "turcja", 111m, "Andriake Beach Club Hotel", "Atatürk Caddesi" },
                    { new Guid("dc159078-7c6d-4b29-928b-cc635819a9d0"), "Peloponez", "grecja", 43m, "Aldemar Olympian Village", "Leoforos Alexandras" },
                    { new Guid("e155db27-2552-4c02-8441-11626ef2bc01"), "Alam", "egipt", 33m, "Marina Lodge Port Ghalib", "Sharia Ramsis" },
                    { new Guid("e183174a-4833-4ee0-b916-3fa404526b5a"), "Turecka", "turcja", 114m, "Kimeros Park Holiday Village", "Bağdat Caddesi" },
                    { new Guid("e184f9fc-616f-406b-b2ef-6c570792a655"), "Maresme", "hiszpania", 106m, "Reymar Playa", "Paseo del Prado" },
                    { new Guid("e24043be-eccc-401d-8043-7d82f6aa3655"), "Turecka", "turcja", 50m, "Melissa", "Halaskargazi Caddesi" },
                    { new Guid("e5f235c5-c4e2-48df-a927-bc68c49f4840"), "Heraklion", "grecja", 74m, "Irini Studios", "Plateia Syntagmatos" },
                    { new Guid("eb92356c-007d-4038-ae7e-f140aee1a1f0"), "Nero", "grecja", 110m, "Studia Maria", "Leoforos Alexandras" },
                    { new Guid("ed65f816-8a45-4fdf-9460-0ba2242b4576"), "Durres", "albania", 34m, "Diamma Resort", "Rruga Abdyl Frasheri" },
                    { new Guid("f1c8d7e8-b08e-40c3-97e7-dcedd3520f7e"), "Turecka", "turcja", 35m, "Kleopatra Micador", "Atatürk Caddesi" },
                    { new Guid("fd2ec648-7ff4-485c-928e-c97272823862"), "Riwiera", "chorwacja", 42m, "Apartamenty Omiś", "Vukovarska ulica" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "HotelId", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("01b563b3-b5f0-4c2d-9393-279e7e1d0ce0"), 2, new Guid("aade28ca-437f-48cb-aee9-99a510b740e6"), 62m, 3 },
                    { new Guid("01c8f7d4-5191-44ec-b944-acea3831a540"), 3, new Guid("aa282794-4b9d-47c5-b7f9-4d657ecdfe4b"), 178m, 2 },
                    { new Guid("0960b91d-1b61-460e-9dcb-ad9e36909c5a"), 2, new Guid("1335ee5b-7ca5-4bb6-a106-f28c5a15e654"), 81m, 5 },
                    { new Guid("09b8175f-7499-457c-b02e-851feb668414"), 1, new Guid("18519dfd-80db-41c4-aa75-f61803f90477"), 143m, 4 },
                    { new Guid("130c46ad-159c-4012-b8f3-ae5654f90ad2"), 3, new Guid("c2b21d2c-9c87-4b3c-9898-76187afe18d1"), 223m, 4 },
                    { new Guid("18890b13-ffb7-4890-a554-751153d38013"), 1, new Guid("b729250c-f872-478b-a297-643840368782"), 177m, 4 },
                    { new Guid("19887486-63c8-4c8c-805b-0161026559ff"), 2, new Guid("606eb796-f8c0-44c1-b6e7-d9c74c0e7aef"), 143m, 5 },
                    { new Guid("1a53f593-e2f5-41c6-af7e-a54e539a49ab"), 1, new Guid("e184f9fc-616f-406b-b2ef-6c570792a655"), 112m, 3 },
                    { new Guid("1accea07-829f-46d8-93aa-223fc4aa6c15"), 1, new Guid("cef41a55-9cd3-4144-ba46-c0a160dae3db"), 182m, 3 },
                    { new Guid("1ace775f-e083-462e-8b4b-6d12499285c5"), 2, new Guid("22f44e2f-5cb2-4a2e-8bf4-d6b3c576f7ba"), 250m, 5 },
                    { new Guid("1c787a55-971e-4f83-aabf-de655f43bdf8"), 2, new Guid("e183174a-4833-4ee0-b916-3fa404526b5a"), 168m, 3 },
                    { new Guid("1d56fae4-bc92-4b05-a7b2-b8d7b2404a86"), 3, new Guid("606eb796-f8c0-44c1-b6e7-d9c74c0e7aef"), 109m, 3 },
                    { new Guid("1d8506e5-56c4-428c-94e7-f16c79942c6d"), 3, new Guid("daedf97d-0277-4e8a-874f-038c0608f189"), 132m, 2 },
                    { new Guid("2010ff59-a091-4cb2-920f-635bfb84c3eb"), 1, new Guid("3c876902-2e40-46ea-bbe2-700f8344aa16"), 153m, 2 },
                    { new Guid("218d1fe6-fb23-4173-91c6-a2a7da0b0c8b"), 3, new Guid("0a3efaf9-b617-4289-8afc-06f4f5260106"), 119m, 2 },
                    { new Guid("2444778b-9f4a-4aad-95ad-605df060d730"), 2, new Guid("ed65f816-8a45-4fdf-9460-0ba2242b4576"), 145m, 2 },
                    { new Guid("2548a1f6-408c-4f2a-abc5-2f9b6d0357fc"), 3, new Guid("15a863c6-f0af-46cc-814f-d37a1dcef9d8"), 197m, 4 },
                    { new Guid("2599221b-c375-4a44-b926-95351c9d9053"), 3, new Guid("dc159078-7c6d-4b29-928b-cc635819a9d0"), 208m, 3 },
                    { new Guid("262b3c05-d7e1-4618-9486-0ab22c93a48a"), 3, new Guid("b729250c-f872-478b-a297-643840368782"), 155m, 3 },
                    { new Guid("2749ae1f-ccfe-4d91-9eda-6dade48a8c3e"), 2, new Guid("b729250c-f872-478b-a297-643840368782"), 179m, 2 },
                    { new Guid("27806582-a4fe-498c-a091-5d4669669794"), 3, new Guid("52e2248d-8c44-413e-8f75-9194126c34cc"), 84m, 4 },
                    { new Guid("27d213e5-8a69-4099-bded-9e8fad5c1da0"), 3, new Guid("aade28ca-437f-48cb-aee9-99a510b740e6"), 129m, 2 },
                    { new Guid("283a6834-96d1-4b6a-9a86-64c914358be9"), 1, new Guid("e184f9fc-616f-406b-b2ef-6c570792a655"), 177m, 5 },
                    { new Guid("299f9ec5-81a1-4e66-b319-b755f4a3ddeb"), 1, new Guid("3c876902-2e40-46ea-bbe2-700f8344aa16"), 183m, 4 },
                    { new Guid("29cf8d8d-a13b-412e-90b1-f9eab17c08b3"), 3, new Guid("1335ee5b-7ca5-4bb6-a106-f28c5a15e654"), 118m, 2 },
                    { new Guid("2b58ba91-d477-4360-8034-7fba74171031"), 1, new Guid("8c6d9bc2-f359-4a7b-b4de-952cf48019aa"), 69m, 5 },
                    { new Guid("2cfc7807-4801-4a39-a511-f66e8a1aec34"), 2, new Guid("ed65f816-8a45-4fdf-9460-0ba2242b4576"), 138m, 3 },
                    { new Guid("2d1b62be-c8a5-44cf-b173-e990068f4d99"), 3, new Guid("b2534063-171c-4be8-93a3-4a60be8dc272"), 242m, 2 },
                    { new Guid("313be7dc-e62f-41d7-9528-6005f077646b"), 2, new Guid("22f44e2f-5cb2-4a2e-8bf4-d6b3c576f7ba"), 140m, 4 },
                    { new Guid("31786618-681a-48a0-84a5-76dd9b1bf97b"), 1, new Guid("00fca576-8fd4-4ac1-97ce-8dbe8880301b"), 94m, 5 },
                    { new Guid("33406056-5a39-414f-93d0-3c694949b08d"), 3, new Guid("086aec19-0d5e-4cdc-9f47-08477a6978ba"), 163m, 4 },
                    { new Guid("3362c175-627a-4cf1-b536-5f2f95ee725e"), 2, new Guid("7c0ce2fe-9a04-426a-833b-43e8ade405be"), 60m, 2 },
                    { new Guid("336e3c8b-328b-49ca-9372-02cf82bfefef"), 3, new Guid("cef41a55-9cd3-4144-ba46-c0a160dae3db"), 70m, 5 },
                    { new Guid("3980fabf-808d-444d-b4f8-772468ce6fc9"), 2, new Guid("52e2248d-8c44-413e-8f75-9194126c34cc"), 234m, 3 },
                    { new Guid("3ade7f47-f02e-4c23-a1ff-33dab1d76755"), 2, new Guid("18519dfd-80db-41c4-aa75-f61803f90477"), 96m, 3 },
                    { new Guid("3b2277b7-ec06-4710-9523-520813b73bfc"), 3, new Guid("e183174a-4833-4ee0-b916-3fa404526b5a"), 111m, 5 },
                    { new Guid("3b7221db-e30a-4eeb-b7e8-59960655ca31"), 1, new Guid("cef41a55-9cd3-4144-ba46-c0a160dae3db"), 238m, 4 },
                    { new Guid("3c4c5bfb-0546-41d9-ad0a-313101da05ef"), 3, new Guid("d690b2bb-718a-4e7c-950a-dfbcc19e4108"), 250m, 4 },
                    { new Guid("3efc743b-1a3a-49ff-bc48-56974496f3c8"), 1, new Guid("086aec19-0d5e-4cdc-9f47-08477a6978ba"), 164m, 3 },
                    { new Guid("3f633072-9c83-4511-bd6b-3fdd6d0bac78"), 1, new Guid("450f571d-b811-4a35-9b01-e88f62003758"), 121m, 2 },
                    { new Guid("4156a32b-a715-4454-bc4d-83a818534f9d"), 1, new Guid("dc159078-7c6d-4b29-928b-cc635819a9d0"), 64m, 5 },
                    { new Guid("4161eab2-4d2f-4dd0-a53b-ed4b1f6419e1"), 2, new Guid("1335ee5b-7ca5-4bb6-a106-f28c5a15e654"), 73m, 3 },
                    { new Guid("44532019-8fff-46cb-b48c-a6422a8485cd"), 2, new Guid("e184f9fc-616f-406b-b2ef-6c570792a655"), 152m, 4 },
                    { new Guid("4453fd93-a28d-4c82-a6e4-1ea528376826"), 2, new Guid("0a3efaf9-b617-4289-8afc-06f4f5260106"), 215m, 5 },
                    { new Guid("4652781c-62ec-4c3f-b9c4-cef2d952fad7"), 3, new Guid("00fca576-8fd4-4ac1-97ce-8dbe8880301b"), 233m, 2 },
                    { new Guid("48090581-34c4-43fe-ba64-cfddf741607e"), 3, new Guid("94c25c53-975c-452c-b35f-9112134ed5b7"), 195m, 3 },
                    { new Guid("480c9dbd-86b9-429f-94e1-1e298850fb3a"), 3, new Guid("8c6d9bc2-f359-4a7b-b4de-952cf48019aa"), 247m, 3 },
                    { new Guid("483cc984-d591-42dd-9a34-73e517b1db6f"), 2, new Guid("0a3efaf9-b617-4289-8afc-06f4f5260106"), 123m, 4 },
                    { new Guid("4952773c-1fa5-4913-b312-077db9651e6b"), 1, new Guid("15a863c6-f0af-46cc-814f-d37a1dcef9d8"), 76m, 2 },
                    { new Guid("49d218c0-5b0d-4308-8781-c9c762131aa0"), 2, new Guid("0eca1b28-f97e-4363-b310-e9d321001a67"), 211m, 2 },
                    { new Guid("49fc83d9-9317-4de0-903f-3ad956786453"), 1, new Guid("e5f235c5-c4e2-48df-a927-bc68c49f4840"), 119m, 5 },
                    { new Guid("4a0a21a2-65a7-409b-9f4a-049440f0f379"), 3, new Guid("a4165ec6-43c0-4ba5-82bc-e9455e27be3f"), 239m, 5 },
                    { new Guid("4a3813e2-1b63-4666-ad67-decbbb4c2c7c"), 1, new Guid("73b1ede0-a09e-42e5-8709-49982716aa64"), 219m, 3 },
                    { new Guid("4a60fe73-b213-445d-9a24-225973b9453a"), 2, new Guid("b2534063-171c-4be8-93a3-4a60be8dc272"), 154m, 5 },
                    { new Guid("4d4b78c7-420e-459b-af3e-638a5013e9e7"), 3, new Guid("606eb796-f8c0-44c1-b6e7-d9c74c0e7aef"), 78m, 4 },
                    { new Guid("4e45b01e-294a-4c90-ae45-63aee3d8279f"), 2, new Guid("99073865-f88c-4f28-8173-2193299b411a"), 207m, 2 },
                    { new Guid("503bd43c-1489-4515-9e19-b9227ef5065e"), 2, new Guid("450f571d-b811-4a35-9b01-e88f62003758"), 201m, 4 },
                    { new Guid("5137c90a-f581-4c63-9728-690efa62c17e"), 1, new Guid("52e2248d-8c44-413e-8f75-9194126c34cc"), 129m, 2 },
                    { new Guid("51803451-e86b-4b63-9644-627b5903d423"), 1, new Guid("f1c8d7e8-b08e-40c3-97e7-dcedd3520f7e"), 201m, 2 },
                    { new Guid("52608c29-31fd-40f1-8ba9-0bc124666a14"), 3, new Guid("94c25c53-975c-452c-b35f-9112134ed5b7"), 180m, 4 },
                    { new Guid("55310490-d52c-4150-8f6f-eee4a5fb1e28"), 2, new Guid("e5f235c5-c4e2-48df-a927-bc68c49f4840"), 165m, 2 },
                    { new Guid("55aee54e-c00d-42b5-979f-e2c87f7f4e44"), 3, new Guid("d0cdfde2-390c-42bf-9ded-14dc608b195b"), 147m, 3 },
                    { new Guid("56c9253b-e6ba-43ea-9b74-478c025c4ea7"), 3, new Guid("d690b2bb-718a-4e7c-950a-dfbcc19e4108"), 92m, 3 },
                    { new Guid("5776eb4f-1350-481d-b311-6b15459fac44"), 1, new Guid("00fca576-8fd4-4ac1-97ce-8dbe8880301b"), 171m, 4 },
                    { new Guid("587d726a-5017-415d-a354-f2069bcf2095"), 1, new Guid("b729250c-f872-478b-a297-643840368782"), 195m, 5 },
                    { new Guid("590f4889-a519-489b-9927-b757916d360b"), 2, new Guid("aade28ca-437f-48cb-aee9-99a510b740e6"), 162m, 4 },
                    { new Guid("5bb7c355-aacc-4722-99cc-93a51f2b56f4"), 2, new Guid("daedf97d-0277-4e8a-874f-038c0608f189"), 111m, 5 },
                    { new Guid("609fbfed-b202-48bb-8081-db34fefd0780"), 1, new Guid("73b1ede0-a09e-42e5-8709-49982716aa64"), 218m, 4 },
                    { new Guid("63239170-e0b9-4b83-8353-388e7c243fc9"), 1, new Guid("8c6d9bc2-f359-4a7b-b4de-952cf48019aa"), 164m, 4 },
                    { new Guid("633c2ce6-ce29-4802-b785-82e91ee59243"), 3, new Guid("7965d57f-a0ba-408f-b4b2-c7e141df8abd"), 162m, 5 },
                    { new Guid("63bc813d-207f-41d6-8431-5aa191ef3ea4"), 3, new Guid("aa282794-4b9d-47c5-b7f9-4d657ecdfe4b"), 216m, 3 },
                    { new Guid("63fcc672-a4ce-4218-a3f3-e4c133b8ed01"), 3, new Guid("cef41a55-9cd3-4144-ba46-c0a160dae3db"), 193m, 2 },
                    { new Guid("64fd57a0-801a-42d4-97ee-e8a19a9f6798"), 1, new Guid("aa282794-4b9d-47c5-b7f9-4d657ecdfe4b"), 98m, 4 },
                    { new Guid("66e13e21-851c-46ba-8363-01e11bb8f9ae"), 2, new Guid("0eca1b28-f97e-4363-b310-e9d321001a67"), 169m, 4 },
                    { new Guid("688591ed-6b32-473a-b1e3-58ff36c778b9"), 1, new Guid("99073865-f88c-4f28-8173-2193299b411a"), 119m, 5 },
                    { new Guid("6953fa73-d4cb-4b19-8bbc-0e46ad7563e2"), 1, new Guid("09b224f1-17f3-469f-8867-d0663c86a2ad"), 247m, 3 },
                    { new Guid("6aa4194b-426d-482e-a0ef-e3169f34acd2"), 3, new Guid("99073865-f88c-4f28-8173-2193299b411a"), 146m, 4 },
                    { new Guid("6bc53aa9-2c9a-4b32-bd21-5ca0fbe5def8"), 2, new Guid("8c6d9bc2-f359-4a7b-b4de-952cf48019aa"), 186m, 2 },
                    { new Guid("6c01386b-05cc-4da9-a01b-015daecd3c23"), 2, new Guid("daedf97d-0277-4e8a-874f-038c0608f189"), 244m, 3 },
                    { new Guid("6ce3a6ce-8fed-4253-a914-e757751d855b"), 3, new Guid("086aec19-0d5e-4cdc-9f47-08477a6978ba"), 215m, 2 },
                    { new Guid("6d3312da-95bd-4b00-b33b-c1a907a4d4d0"), 3, new Guid("7c0ce2fe-9a04-426a-833b-43e8ade405be"), 217m, 5 },
                    { new Guid("6d48e5d6-b6e2-484f-af4a-18785ea976b0"), 1, new Guid("daedf97d-0277-4e8a-874f-038c0608f189"), 243m, 4 },
                    { new Guid("6e28b834-ce20-4254-bffc-085fa27e197c"), 2, new Guid("8c10ea27-8d72-4d6b-ad47-98f7131e4baf"), 125m, 4 },
                    { new Guid("6eb52e44-5c8e-43c5-8040-08d8f3a81b51"), 1, new Guid("a4165ec6-43c0-4ba5-82bc-e9455e27be3f"), 110m, 3 },
                    { new Guid("7049255f-78cb-42dc-9142-b3077cc5535d"), 2, new Guid("c2b21d2c-9c87-4b3c-9898-76187afe18d1"), 153m, 2 },
                    { new Guid("70d4aaac-a563-44c5-b18d-865d36397a66"), 1, new Guid("ed65f816-8a45-4fdf-9460-0ba2242b4576"), 205m, 5 },
                    { new Guid("71efcb4d-c10c-44c9-bf41-51cbfee53e8d"), 1, new Guid("e24043be-eccc-401d-8043-7d82f6aa3655"), 175m, 2 },
                    { new Guid("72095243-4828-4f2b-a6c2-f4d1aae50ea8"), 2, new Guid("0a3efaf9-b617-4289-8afc-06f4f5260106"), 95m, 3 },
                    { new Guid("743b84c0-9625-4cb9-8643-6a4c6ea90534"), 3, new Guid("e183174a-4833-4ee0-b916-3fa404526b5a"), 148m, 2 },
                    { new Guid("74703dc7-f077-4d0d-85f1-10defa129717"), 3, new Guid("e155db27-2552-4c02-8441-11626ef2bc01"), 127m, 4 },
                    { new Guid("74c2b12e-aaa0-4acc-beac-9da94136ba0a"), 1, new Guid("e24043be-eccc-401d-8043-7d82f6aa3655"), 219m, 5 },
                    { new Guid("7627832c-a64b-47b9-bea7-b921eb8c519b"), 2, new Guid("f1c8d7e8-b08e-40c3-97e7-dcedd3520f7e"), 219m, 3 },
                    { new Guid("78483eb7-6f0d-481b-be0c-bcce637ed81d"), 1, new Guid("73b1ede0-a09e-42e5-8709-49982716aa64"), 123m, 2 },
                    { new Guid("7bcf531b-c980-4fcd-bfad-d24a73f2cb52"), 3, new Guid("e155db27-2552-4c02-8441-11626ef2bc01"), 95m, 3 },
                    { new Guid("7be6ea95-e61b-42ef-9807-280eff6be55d"), 3, new Guid("d0cdfde2-390c-42bf-9ded-14dc608b195b"), 110m, 5 },
                    { new Guid("7e5dc0ba-d394-4117-9e5a-af22f67334b6"), 1, new Guid("450f571d-b811-4a35-9b01-e88f62003758"), 187m, 3 },
                    { new Guid("7f79f219-2e20-43a8-9e04-9975b2e48916"), 3, new Guid("e155db27-2552-4c02-8441-11626ef2bc01"), 88m, 5 },
                    { new Guid("80666e6f-ad58-451c-831c-c12305c8b56e"), 1, new Guid("e5f235c5-c4e2-48df-a927-bc68c49f4840"), 210m, 4 },
                    { new Guid("80b460a3-0b74-4bcf-84c8-8f4fe3757795"), 1, new Guid("b49466bc-7701-4a23-9da8-4ea5b6bdec65"), 158m, 2 },
                    { new Guid("815a0e39-831c-4bb8-b322-6b6ba3628468"), 3, new Guid("eb92356c-007d-4038-ae7e-f140aee1a1f0"), 165m, 4 },
                    { new Guid("85b06894-8cab-475c-94fb-b6797891b8d5"), 1, new Guid("a4165ec6-43c0-4ba5-82bc-e9455e27be3f"), 95m, 4 },
                    { new Guid("85c3454a-b83d-4878-88e1-5b987d27ba1e"), 3, new Guid("7c0ce2fe-9a04-426a-833b-43e8ade405be"), 77m, 4 },
                    { new Guid("85f64acb-f3ae-4666-b8e0-255121d366ef"), 1, new Guid("0eca1b28-f97e-4363-b310-e9d321001a67"), 77m, 3 },
                    { new Guid("87b28a08-64c9-48fc-8dc8-089b40879738"), 1, new Guid("73b1ede0-a09e-42e5-8709-49982716aa64"), 235m, 5 },
                    { new Guid("8a691dc3-b59d-4ae3-92b5-d7b23c2322d3"), 3, new Guid("09b224f1-17f3-469f-8867-d0663c86a2ad"), 184m, 5 },
                    { new Guid("8b59680e-8ac6-4fb1-85a8-9ae192a6c8ab"), 3, new Guid("94c25c53-975c-452c-b35f-9112134ed5b7"), 210m, 5 },
                    { new Guid("8c38e2c7-09e7-4a15-b792-ab68fff47fde"), 3, new Guid("00fca576-8fd4-4ac1-97ce-8dbe8880301b"), 204m, 3 },
                    { new Guid("90033f73-589b-4218-8230-c31a9b8b4944"), 2, new Guid("18519dfd-80db-41c4-aa75-f61803f90477"), 220m, 2 },
                    { new Guid("93da5343-6328-452c-b716-c1829713ca5d"), 1, new Guid("f1c8d7e8-b08e-40c3-97e7-dcedd3520f7e"), 63m, 5 },
                    { new Guid("96295dec-3a0b-48e7-aab7-2068c5d5c7be"), 2, new Guid("b90c2fe3-4d24-4bcd-aa95-9659c1b5857e"), 188m, 2 },
                    { new Guid("97fb4e24-dd16-4166-9c1a-e9c9749eaf33"), 2, new Guid("15a863c6-f0af-46cc-814f-d37a1dcef9d8"), 237m, 5 },
                    { new Guid("99cd4b93-95f5-4845-8c1b-e0bac1ba03c6"), 3, new Guid("4da21b0d-26ab-4ce1-af64-a18f729b05f0"), 177m, 4 },
                    { new Guid("9a31fed0-d5d3-49d0-a6dd-65e22a443aa4"), 3, new Guid("b2534063-171c-4be8-93a3-4a60be8dc272"), 142m, 4 },
                    { new Guid("9ad7322e-ec58-43fc-b0a2-d8c0e377f0dd"), 2, new Guid("e5f235c5-c4e2-48df-a927-bc68c49f4840"), 88m, 3 },
                    { new Guid("9adf5a6a-321f-467f-987a-514b9d4635fd"), 1, new Guid("3c876902-2e40-46ea-bbe2-700f8344aa16"), 84m, 5 },
                    { new Guid("9ae5045e-59e5-4677-9134-733f9e2b156e"), 3, new Guid("aade28ca-437f-48cb-aee9-99a510b740e6"), 191m, 5 },
                    { new Guid("9bb66b6c-d95d-4ad1-ba45-f20db3da2740"), 1, new Guid("eb92356c-007d-4038-ae7e-f140aee1a1f0"), 72m, 5 },
                    { new Guid("9d7db273-ec5f-45af-a1c2-b55e71378ff8"), 2, new Guid("e155db27-2552-4c02-8441-11626ef2bc01"), 176m, 2 },
                    { new Guid("a481e6ac-7bbd-47ce-bb64-81dc576b4059"), 3, new Guid("b49466bc-7701-4a23-9da8-4ea5b6bdec65"), 95m, 4 },
                    { new Guid("a4ac1750-509f-4f8c-862e-748f80f0695e"), 1, new Guid("1335ee5b-7ca5-4bb6-a106-f28c5a15e654"), 166m, 4 },
                    { new Guid("ad9b801b-84c8-42ad-9b45-44c46c07602a"), 2, new Guid("4da21b0d-26ab-4ce1-af64-a18f729b05f0"), 105m, 5 },
                    { new Guid("afc4608f-8615-4974-bd2f-048e9d64964f"), 3, new Guid("4da21b0d-26ab-4ce1-af64-a18f729b05f0"), 104m, 2 },
                    { new Guid("b3d865d0-e72f-43b1-aba4-590f19dcc29b"), 3, new Guid("c2b21d2c-9c87-4b3c-9898-76187afe18d1"), 135m, 5 },
                    { new Guid("b53d315e-aaaa-4912-8ced-6b466c54a299"), 3, new Guid("606eb796-f8c0-44c1-b6e7-d9c74c0e7aef"), 219m, 2 },
                    { new Guid("b53dad0a-1c73-44dc-839e-07ff6ea951f6"), 1, new Guid("d0cdfde2-390c-42bf-9ded-14dc608b195b"), 84m, 2 },
                    { new Guid("b94a2dc4-69cc-420a-89f2-a2555ae515ee"), 2, new Guid("fd2ec648-7ff4-485c-928e-c97272823862"), 221m, 4 },
                    { new Guid("b97786d5-f052-42e9-9bc7-d4014279ce5a"), 3, new Guid("aa282794-4b9d-47c5-b7f9-4d657ecdfe4b"), 165m, 5 },
                    { new Guid("ba0313a1-27e3-426b-800e-378fdd85e854"), 2, new Guid("dc159078-7c6d-4b29-928b-cc635819a9d0"), 239m, 2 },
                    { new Guid("bb063a09-9326-482d-a095-bb5c1dd14551"), 3, new Guid("e183174a-4833-4ee0-b916-3fa404526b5a"), 230m, 4 },
                    { new Guid("bc74a4fb-2bdc-4b08-89c7-62c993561d7c"), 1, new Guid("450f571d-b811-4a35-9b01-e88f62003758"), 73m, 5 },
                    { new Guid("bd800ee4-5641-42ae-9a0b-6041f5ad720f"), 2, new Guid("22f44e2f-5cb2-4a2e-8bf4-d6b3c576f7ba"), 131m, 3 },
                    { new Guid("bde342a2-4964-4d34-92a6-d74b4ee1af79"), 2, new Guid("d0cdfde2-390c-42bf-9ded-14dc608b195b"), 78m, 4 },
                    { new Guid("c1695ca9-9d49-4a22-b74e-8684d5c6e36e"), 3, new Guid("7c0ce2fe-9a04-426a-833b-43e8ade405be"), 190m, 3 },
                    { new Guid("c2bee144-ea6b-4d3c-b4bc-2d10f354a461"), 2, new Guid("8c10ea27-8d72-4d6b-ad47-98f7131e4baf"), 66m, 2 },
                    { new Guid("c2c9a531-17de-448a-b8b6-04a718489495"), 3, new Guid("ed65f816-8a45-4fdf-9460-0ba2242b4576"), 74m, 4 },
                    { new Guid("c448be82-ef4e-48fb-8d2f-56e5d09a0eab"), 2, new Guid("22f44e2f-5cb2-4a2e-8bf4-d6b3c576f7ba"), 213m, 2 },
                    { new Guid("c53cdec2-302f-44a1-b06a-0ea2d36ca9e0"), 3, new Guid("e184f9fc-616f-406b-b2ef-6c570792a655"), 190m, 2 },
                    { new Guid("c9d5c9fb-3eb8-459a-a00b-280aeefbdc69"), 1, new Guid("7965d57f-a0ba-408f-b4b2-c7e141df8abd"), 146m, 2 },
                    { new Guid("ca013163-412c-4397-af1d-b680a8cc4cf6"), 3, new Guid("99073865-f88c-4f28-8173-2193299b411a"), 131m, 3 },
                    { new Guid("caaa157b-1a50-43dd-aaac-9274f0fcab4b"), 1, new Guid("7965d57f-a0ba-408f-b4b2-c7e141df8abd"), 164m, 4 },
                    { new Guid("cb05be9d-d4f4-45bd-9818-4dfb31144d67"), 3, new Guid("52e2248d-8c44-413e-8f75-9194126c34cc"), 216m, 5 },
                    { new Guid("ce1eeed5-a141-48fc-8618-aedef998412c"), 2, new Guid("8c10ea27-8d72-4d6b-ad47-98f7131e4baf"), 147m, 5 },
                    { new Guid("ce2e107a-7e37-4121-8724-ff7b879065c6"), 1, new Guid("0eca1b28-f97e-4363-b310-e9d321001a67"), 84m, 5 },
                    { new Guid("d00689b2-b79b-4d9e-89bb-85ff9f76a9d3"), 2, new Guid("086aec19-0d5e-4cdc-9f47-08477a6978ba"), 247m, 5 },
                    { new Guid("d11cc252-5fc9-4ae0-8302-aec3038c8e02"), 2, new Guid("f1c8d7e8-b08e-40c3-97e7-dcedd3520f7e"), 76m, 4 },
                    { new Guid("d1b0053a-e39c-4611-8a0d-87f0a72297b9"), 3, new Guid("b49466bc-7701-4a23-9da8-4ea5b6bdec65"), 154m, 5 },
                    { new Guid("d4a43b75-74c3-404e-990b-563f4ed77a99"), 3, new Guid("09b224f1-17f3-469f-8867-d0663c86a2ad"), 70m, 4 },
                    { new Guid("d55296c8-83fc-4c4f-a874-de40379dbcbf"), 3, new Guid("15a863c6-f0af-46cc-814f-d37a1dcef9d8"), 149m, 3 },
                    { new Guid("d57b19b7-17e2-4122-b4d1-8681bc163897"), 2, new Guid("fd2ec648-7ff4-485c-928e-c97272823862"), 108m, 5 },
                    { new Guid("d64e249e-d3bd-41d8-9586-e048164c1f3c"), 2, new Guid("b90c2fe3-4d24-4bcd-aa95-9659c1b5857e"), 209m, 5 },
                    { new Guid("d7466e53-b7a2-45d5-bf69-07a646afb84e"), 2, new Guid("b90c2fe3-4d24-4bcd-aa95-9659c1b5857e"), 90m, 3 },
                    { new Guid("d7bb40af-0060-4083-8a49-38eca125d088"), 1, new Guid("4da21b0d-26ab-4ce1-af64-a18f729b05f0"), 136m, 3 },
                    { new Guid("d8643756-09d1-44d5-8d5c-6b0aab0d13ee"), 2, new Guid("c2b21d2c-9c87-4b3c-9898-76187afe18d1"), 221m, 3 },
                    { new Guid("dae716c4-19e5-4ae5-afc2-92fc91ce810b"), 2, new Guid("3c876902-2e40-46ea-bbe2-700f8344aa16"), 125m, 3 },
                    { new Guid("dcf195da-a585-42da-bd79-13e455ca9388"), 2, new Guid("8c10ea27-8d72-4d6b-ad47-98f7131e4baf"), 179m, 3 },
                    { new Guid("ddf0d252-552c-40bc-81db-b12a1bd0fb94"), 3, new Guid("dc159078-7c6d-4b29-928b-cc635819a9d0"), 161m, 4 },
                    { new Guid("dee509a7-73ec-4a99-b931-cf140f6304b5"), 3, new Guid("7965d57f-a0ba-408f-b4b2-c7e141df8abd"), 107m, 3 },
                    { new Guid("def96cdb-c68d-4189-bee5-fc5134625645"), 1, new Guid("b2534063-171c-4be8-93a3-4a60be8dc272"), 132m, 3 },
                    { new Guid("e3c5f804-618b-45bc-9821-ab5d1d8d56ce"), 1, new Guid("e24043be-eccc-401d-8043-7d82f6aa3655"), 245m, 3 },
                    { new Guid("e918dbff-78a1-430e-bb0a-a9f4ae3fc15a"), 3, new Guid("eb92356c-007d-4038-ae7e-f140aee1a1f0"), 97m, 3 },
                    { new Guid("e9f5e5d3-612b-46ad-a883-878fdae3d2bc"), 2, new Guid("b49466bc-7701-4a23-9da8-4ea5b6bdec65"), 133m, 3 },
                    { new Guid("ec004b7c-8d3d-4967-b6b1-636ee3b72e81"), 3, new Guid("d690b2bb-718a-4e7c-950a-dfbcc19e4108"), 241m, 5 },
                    { new Guid("ee01e133-8f08-4410-8ac8-ebf4830ada27"), 1, new Guid("eb92356c-007d-4038-ae7e-f140aee1a1f0"), 130m, 2 },
                    { new Guid("ee1a5b1b-14fa-4a53-b1b1-3ce901a2ef53"), 1, new Guid("e24043be-eccc-401d-8043-7d82f6aa3655"), 50m, 4 },
                    { new Guid("ef7418e2-3165-41b8-9a6d-900b7b0c2dd6"), 1, new Guid("d690b2bb-718a-4e7c-950a-dfbcc19e4108"), 53m, 2 },
                    { new Guid("f1782a56-c79f-4ff2-8b8b-bb681f639b38"), 2, new Guid("a4165ec6-43c0-4ba5-82bc-e9455e27be3f"), 111m, 2 },
                    { new Guid("f2f7b3a2-49cc-406a-adde-5e874cc49365"), 3, new Guid("18519dfd-80db-41c4-aa75-f61803f90477"), 71m, 5 },
                    { new Guid("f30a1940-3f84-472f-bee7-e8efba10650a"), 2, new Guid("b90c2fe3-4d24-4bcd-aa95-9659c1b5857e"), 166m, 4 },
                    { new Guid("f4f7a2b2-bbce-4446-8fda-75097c17720f"), 2, new Guid("09b224f1-17f3-469f-8867-d0663c86a2ad"), 87m, 2 },
                    { new Guid("f54c4ea1-a447-47a8-a821-e9d758012b00"), 3, new Guid("fd2ec648-7ff4-485c-928e-c97272823862"), 84m, 2 },
                    { new Guid("fa1a3a04-c1d4-49be-8fe2-82c7d816b154"), 2, new Guid("94c25c53-975c-452c-b35f-9112134ed5b7"), 76m, 2 },
                    { new Guid("fc88df53-0235-4497-8ec2-8c9503ad9cc8"), 1, new Guid("fd2ec648-7ff4-485c-928e-c97272823862"), 145m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_HotelId",
                table: "Discounts",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReservations_RoomsId",
                table: "RoomReservations",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "RoomReservations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
