using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace transportservice.Migrations
{
    public partial class ScrappedTransportOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("16bf195b-a751-412a-9532-63b173212889"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("16bf195b-a751-412a-9532-63b173212889"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7d5b901c-bd58-4aba-aa53-4aecf56781fa"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9cdbc293-27f7-4de1-a23d-05a548f25442"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7576fc8-f86e-4bbc-bc50-e6177d3f2920"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c52ad295-b949-4203-89c0-4781c88f6cbf"));

            migrationBuilder.InsertData(
                table: "CommandTransportOptions",
                columns: new[] { "Id", "End", "FromCity", "FromCountry", "FromShowName", "FromStreet", "InitialSeats", "PriceAdult", "PriceUnder10", "PriceUnder18", "PriceUnder3", "Start", "ToCity", "ToCountry", "ToShowName", "ToStreet", "Type" },
                values: new object[,]
                {
                    { new Guid("00893056-15a0-4f78-9970-17ddb471e36b"), new DateTime(2024, 7, 5, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5235), "Turecka", "turcja", null, "Atatürk Caddesi", 180, 263m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5235), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("00f9b6b3-0a65-4dc0-9ed5-ec113d4a9895"), new DateTime(2024, 8, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4784), "Alam", "egipt", null, "Sharia Ramsis", 138, 223m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4783), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("01c4f44e-cd07-4fe1-8e2e-9e860694c4a5"), new DateTime(2024, 6, 15, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6842), "Brava", "hiszpania", null, "Calle Mayor", 155, 287m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6841), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("02414fa3-d48e-476c-9474-a95a38a91adb"), new DateTime(2024, 8, 8, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(3917), "Marmaris", "turcja", null, "Bağdat Caddesi", 59, 225m, 0m, 0m, 0m, new DateTime(2024, 8, 8, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(3917), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("03085164-80fe-4de9-9c4e-1f37407cf46a"), new DateTime(2024, 8, 22, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4553), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 200, 140m, 0m, 0m, 0m, new DateTime(2024, 8, 22, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4552), "Sheikh", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("0433b874-1bd0-4a09-bf45-511bf181b1b1"), new DateTime(2024, 7, 24, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6697), "Sheikh", "egipt", null, "Sharia Salah Salem", 194, 154m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6696), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("0461efda-320d-44d2-9c0d-4751b1505ba4"), new DateTime(2024, 7, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4881), "Sheikh", "egipt", null, "Sharia Tahrir", 182, 254m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4880), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("053a6598-dcf6-4f2d-b21b-044446251b6c"), new DateTime(2024, 8, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5809), "Kalabria", "wlochy", null, "Via del Corso", 152, 179m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5808), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("05b0c2dd-7a98-4582-b5c3-5b8f583b83d1"), new DateTime(2024, 6, 5, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5444), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 81, 169m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5444), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("06126004-e5b9-4f43-8887-50f27194ee36"), new DateTime(2024, 8, 17, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6028), "Vlora", "albania", null, "Rruga e Kavajes", 141, 251m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6027), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("0626f293-d926-4e9f-91e3-1007a806857f"), new DateTime(2024, 6, 25, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(5304), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 69, 72m, 0m, 0m, 0m, new DateTime(2024, 6, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5304), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("066ceed3-7bf1-4d91-ac66-6e225203ac13"), new DateTime(2024, 6, 16, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6561), "Alam", "egipt", null, "Sharia Tahrir", 82, 137m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6561), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("068e0096-0fca-467d-8e0b-1182144ec6f6"), new DateTime(2024, 8, 20, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5848), "Durres", "albania", null, "Rruga e Dibres", 194, 94m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5847), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("0771f6e2-f41f-4b3d-9913-34238c6c4d6b"), new DateTime(2024, 7, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5044), "Luz", "hiszpania", null, "Calle Mayor", 102, 54m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5043), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("07b22677-a066-48e8-98ee-655dc7d86f10"), new DateTime(2024, 8, 12, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5963), "Alam", "egipt", null, "Sharia Tahrir", 120, 181m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5962), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("07b7fa77-5869-492e-b871-1fdc4b15a503"), new DateTime(2024, 7, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5649), "Peloponez", "grecja", null, "Leoforos Alexandras", 176, 232m, 0m, 0m, 0m, new DateTime(2024, 7, 25, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5648), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("07fe9823-fece-4e68-9630-6546111f93d6"), new DateTime(2024, 7, 27, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6373), "Turecka", "turcja", null, "Bağdat Caddesi", 117, 280m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6372), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("082f9c03-8296-4fcd-807d-711dea48489e"), new DateTime(2024, 7, 19, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6865), "Sheikh", "egipt", null, "Sharia Tahrir", 150, 215m, 0m, 0m, 0m, new DateTime(2024, 7, 19, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6864), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("0841f17c-6b83-4ede-b890-b676e986c6c6"), new DateTime(2024, 8, 17, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4029), "Sheikh", "egipt", null, "Sharia Salah Salem", 172, 127m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4029), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("08429c83-a767-4f1e-b0a7-bfe977002342"), new DateTime(2024, 8, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5382), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 145, 78m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5382), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("08eda514-0bc6-43c7-8938-7a0fa10dbc47"), new DateTime(2024, 7, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5600), "Durres", "albania", null, "Bulevardi Bajram Curri", 189, 244m, 0m, 0m, 0m, new DateTime(2024, 7, 25, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5599), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("0c020ccd-9d5f-4b16-8cad-eb572a067f3a"), new DateTime(2024, 8, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5114), "Alam", "egipt", null, "Sharia Tahrir", 189, 227m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5112), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("0c3aefbc-7f41-4e25-a3a3-bcfd707cd9a1"), new DateTime(2024, 8, 26, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5086), "Alam", "egipt", null, "Sharia Tahrir", 191, 59m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5085), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("0cffef58-925b-42a1-8799-791f9605b420"), new DateTime(2024, 7, 10, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5448), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 115, 300m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5447), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("0d3e65eb-56ed-415f-a0b7-808415b62516"), new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6337), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 149, 131m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6336), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("0d5f9348-cc55-47c4-90f5-f54d7f1ff9c6"), new DateTime(2024, 8, 19, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6389), "Kalabria", "wlochy", null, "Via del Corso", 130, 81m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6388), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("0f0ed66f-9acc-4402-b801-637624a4bd1b"), new DateTime(2024, 8, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5231), "Almeria", "hiszpania", null, "Paseo del Prado", 181, 57m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5230), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("0fdd580a-418b-4e8c-80c7-e902880c41b2"), new DateTime(2024, 6, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6154), "Kalabria", "wlochy", null, "Via Veneto", 146, 238m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6153), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("108ef18c-ce3b-4417-ac33-a3133d31522a"), new DateTime(2024, 7, 4, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5480), "Sheikh", "egipt", null, "Sharia Tahrir", 98, 140m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5479), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("11777006-b3cf-4dff-9517-daab12acfb50"), new DateTime(2024, 8, 14, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5959), "Durres", "albania", null, "Rruga Abdyl Frasheri", 105, 197m, 0m, 0m, 0m, new DateTime(2024, 8, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5958), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("11d43bfa-24d4-4609-8c18-eba5530e874b"), new DateTime(2024, 8, 11, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4075), "Alam", "egipt", null, "Sharia Tahrir", 74, 227m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4075), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("12fa82b3-4cab-4eda-b3ba-f8425aef0e16"), new DateTime(2024, 6, 10, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4189), "Kalabria", "wlochy", null, "Via Veneto", 52, 190m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4189), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("13366d6a-58cf-48a0-bde0-da651958ceaa"), new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4303), "Sheikh", "egipt", null, "Sharia Salah Salem", 142, 225m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4302), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("142ddb73-72d7-49b7-b0dd-010ce8842435"), new DateTime(2024, 7, 10, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4763), "Durres", "albania", null, "Rruga e Dibres", 137, 108m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4762), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("14395779-bef4-4e7b-9afa-b36c93a49e27"), new DateTime(2024, 8, 4, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5947), "Durres", "albania", null, "Rruga e Dibres", 105, 269m, 0m, 0m, 0m, new DateTime(2024, 8, 4, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5946), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("14496b4a-2f93-4434-8765-3aefa25c1426"), new DateTime(2024, 8, 13, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6598), "Vlora", "albania", null, "Rruga 28 Nentori", 65, 92m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6597), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("14f997e5-f8a9-46f2-aef0-2c219b582146"), new DateTime(2024, 6, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6644), "Turecka", "turcja", null, "Atatürk Caddesi", 152, 174m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6643), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("15b82b04-7515-451e-96c9-1e6b88f4550b"), new DateTime(2024, 8, 8, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4316), "Vlora", "albania", null, "Rruga e Kavajes", 73, 298m, 0m, 0m, 0m, new DateTime(2024, 8, 8, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4315), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("15c7df23-c3c3-47fa-882a-ea75fc2a00ef"), new DateTime(2024, 6, 12, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4038), "Vlora", "albania", null, "Rruga e Kavajes", 67, 160m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4037), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("17214aff-8314-4ad3-89eb-1b6448ef610a"), new DateTime(2024, 7, 4, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5118), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 173, 132m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5117), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("17db8b38-32f3-4383-89d8-bd59a6b25d90"), new DateTime(2024, 8, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6457), "Durres", "albania", null, "Rruga Abdyl Frasheri", 166, 95m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6456), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("188fcf6c-b95b-4e8a-993a-b8917e0f949a"), new DateTime(2024, 8, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4104), "Turecka", "turcja", null, "Atatürk Caddesi", 146, 135m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4103), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("1abeb6d2-6e43-4f63-8251-1ec5cbe67776"), new DateTime(2024, 7, 9, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4288), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 173, 166m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4287), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("1b7272c7-9308-4c8d-970f-b82899d83b48"), new DateTime(2024, 6, 2, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4271), "Durres", "albania", null, "Rruga Abdyl Frasheri", 90, 252m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4271), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("1b9b4d65-dc4f-406d-afda-3e3ccf61da49"), new DateTime(2024, 7, 13, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6701), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 90, 173m, 0m, 0m, 0m, new DateTime(2024, 7, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6700), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("1c8e2f4c-a8e8-4a80-a5b1-495ae1b05dbc"), new DateTime(2024, 6, 21, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4194), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 54, 95m, 0m, 0m, 0m, new DateTime(2024, 6, 21, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4194), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("1cd55716-6307-4540-a566-82facab0636e"), new DateTime(2024, 6, 18, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6876), "Durres", "albania", null, "Rruga Abdyl Frasheri", 99, 192m, 0m, 0m, 0m, new DateTime(2024, 6, 18, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6875), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("1d61bb51-c9ce-4771-85ad-05b283eaa248"), new DateTime(2024, 6, 3, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5074), "Turecka", "turcja", null, "Atatürk Caddesi", 179, 249m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5073), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("1d830cc7-4865-4bba-b289-453e6ce43eac"), new DateTime(2024, 6, 7, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4284), "Durres", "albania", null, "Rruga Abdyl Frasheri", 139, 161m, 0m, 0m, 0m, new DateTime(2024, 6, 7, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4283), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("1da4b2f0-d711-44bd-b2d8-803acc00759e"), new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6081), "Vlora", "albania", null, "Rruga 28 Nentori", 168, 297m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6080), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("1df09754-f415-486a-abe5-815307fcea76"), new DateTime(2024, 5, 31, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4779), "Sheikh", "egipt", null, "Sharia Salah Salem", 156, 78m, 0m, 0m, 0m, new DateTime(2024, 5, 31, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4779), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("1df0f007-3c19-4814-b55b-8ea813e4b85f"), new DateTime(2024, 5, 31, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6263), "Kalabria", "wlochy", null, "Via Nazionale", 83, 91m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6263), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("1e168de4-e097-4011-98d2-cd283d6a620b"), new DateTime(2024, 8, 18, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(5321), "Kalabria", "wlochy", null, "Via Nazionale", 71, 150m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5320), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("1f4c56d7-a9e4-414e-ad1a-d01ba3a57496"), new DateTime(2024, 7, 11, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(5215), "Durres", "albania", null, "Rruga Abdyl Frasheri", 153, 99m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5214), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("1f98b760-253f-443c-9800-617a355bed0f"), new DateTime(2024, 7, 14, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6626), "Alam", "egipt", null, "Sharia Ramsis", 171, 267m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6625), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("1fa52beb-b833-48a5-b24b-9508ab2fa42e"), new DateTime(2024, 8, 12, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5151), "Kalabria", "wlochy", null, "Via Nazionale", 64, 274m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5150), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("2006bf18-515c-42c6-9f4f-1521046a1e0e"), new DateTime(2024, 7, 6, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6452), "Durres", "albania", null, "Rruga e Dibres", 65, 153m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6451), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("202df9e0-4735-49e1-81dc-8fdc8215c5d2"), new DateTime(2024, 7, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5456), "Vlora", "albania", null, "Rruga 28 Nentori", 61, 105m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5455), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("207a0ab8-5be6-42ef-a0f3-8f724bd28fd1"), new DateTime(2024, 6, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6517), "Vlora", "albania", null, "Rruga e Kavajes", 187, 152m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6516), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("20d4ec7a-0dec-4bae-9823-5d984de6f3af"), new DateTime(2024, 7, 24, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6016), "Vlora", "albania", null, "Rruga 28 Nentori", 181, 62m, 0m, 0m, 0m, new DateTime(2024, 7, 24, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6016), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("211408d5-016a-4d37-8ce5-8b534c4f1c11"), new DateTime(2024, 7, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6461), "Kalabria", "wlochy", null, "Via Nazionale", 112, 116m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6460), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("211f701d-0340-4ef7-991f-227ff727141a"), new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6908), "Alam", "egipt", null, "Sharia Tahrir", 50, 275m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6907), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("21d6ab9b-8571-4f77-9f61-3ccc9e708d02"), new DateTime(2024, 8, 3, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5976), "Marmaris", "turcja", null, "Bağdat Caddesi", 165, 124m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5975), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("23038dd0-a417-4144-ac78-ac0bdcf7a1e5"), new DateTime(2024, 7, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5930), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 157, 149m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5929), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("23980b82-ac86-4720-99c8-30f7ceadd040"), new DateTime(2024, 8, 20, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4701), "Durres", "albania", null, "Rruga e Dibres", 145, 162m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4700), "Sheikh", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("2537118e-96b4-4898-bf53-d1eab09a50b4"), new DateTime(2024, 6, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5300), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 99, 171m, 0m, 0m, 0m, new DateTime(2024, 6, 4, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5300), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("255b199c-547b-442b-8155-8bbb6bc257b4"), new DateTime(2024, 7, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6314), "Turecka", "turcja", null, "Atatürk Caddesi", 167, 68m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6313), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("26be5b09-bae2-4d5d-8533-4562e7bca1bb"), new DateTime(2024, 5, 31, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5991), "Turecka", "turcja", null, "Halaskargazi Caddesi", 149, 106m, 0m, 0m, 0m, new DateTime(2024, 5, 31, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5990), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("271613b4-cc5f-4f97-8dff-444b9bf8e5d2"), new DateTime(2024, 7, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5279), "Durres", "albania", null, "Rruga e Dibres", 191, 55m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5278), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("27f3ba34-2be4-41e8-8b90-bd216945ceac"), new DateTime(2024, 7, 4, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4600), "Sheikh", "egipt", null, "Sharia Ramsis", 112, 207m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4600), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("28706770-883f-417f-bdef-a82c0c092cb4"), new DateTime(2024, 8, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6732), "Brava", "hiszpania", null, "Gran Vía", 197, 106m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6731), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("294e5378-a8f8-4611-a075-2cf09a8a7bd4"), new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6443), "Alam", "egipt", null, "Sharia Ramsis", 136, 83m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6442), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("29f240b8-510e-4d7b-b623-f007bbe38a4b"), new DateTime(2024, 8, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6309), "Kalabria", "wlochy", null, "Via del Corso", 171, 185m, 0m, 0m, 0m, new DateTime(2024, 7, 31, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6308), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("2acece12-e592-4703-a127-29c74f24888c"), new DateTime(2024, 7, 8, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4319), "Durres", "albania", null, "Bulevardi Bajram Curri", 95, 134m, 0m, 0m, 0m, new DateTime(2024, 7, 8, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4319), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("2b6e6ae7-9a26-48ff-8fa7-9c1acccb61b7"), new DateTime(2024, 8, 24, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5369), "Riwiera", "chorwacja", null, "Kapucinska ulica", 98, 289m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5368), "Vlora", "albania", null, "Rruga e Kavajes", "Bus" },
                    { new Guid("2bc4ea9c-f5c7-48e5-9b9d-c5c8760faee9"), new DateTime(2024, 5, 29, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6805), "Marmaris", "turcja", null, "Bağdat Caddesi", 53, 185m, 0m, 0m, 0m, new DateTime(2024, 5, 29, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6804), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("2c27fd27-1abf-4e7a-8840-83565bf6f158"), new DateTime(2024, 6, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6899), "Durres", "albania", null, "Rruga e Dibres", 70, 292m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6899), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("2cb53a92-5959-4023-98d1-282324b49e43"), new DateTime(2024, 6, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6304), "Sheikh", "egipt", null, "Sharia Ramsis", 147, 126m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6303), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("2d217c0f-b419-44b3-9709-10e38f146755"), new DateTime(2024, 6, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5825), "Turecka", "turcja", null, "Atatürk Caddesi", 110, 277m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5824), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("2d2841f8-95a8-4f8b-bfa5-fbf887816714"), new DateTime(2024, 7, 4, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6814), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 83, 115m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6813), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("2d3c5286-c2b7-44f1-a0f2-6639b1ec3924"), new DateTime(2024, 7, 11, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6740), "Durres", "albania", null, "Rruga e Dibres", 159, 91m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6739), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("2d4c1e88-ecad-4cef-a60f-df1102244812"), new DateTime(2024, 7, 23, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(3922), "Almeria", "hiszpania", null, "Paseo del Prado", 196, 284m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(3921), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("2dbdc00f-fe4c-466b-897b-50715192cbf7"), new DateTime(2024, 6, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5980), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 132, 51m, 0m, 0m, 0m, new DateTime(2024, 6, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5979), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("2dc40ebe-f4c0-40cd-884d-e5c9355d60ab"), new DateTime(2024, 6, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6497), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 82, 58m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6496), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("2e0f2995-0576-4f3b-8a99-e4eb674118a2"), new DateTime(2024, 6, 23, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6434), "Peloponez", "grecja", null, "Leoforos Alexandras", 89, 221m, 0m, 0m, 0m, new DateTime(2024, 6, 22, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6433), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("30e51248-0a7b-49e7-b324-3a905e88bb56"), new DateTime(2024, 6, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5734), "Kalabria", "wlochy", null, "Via del Corso", 130, 54m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5733), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("312094bb-0c59-41b6-9051-4f66fc474ba4"), new DateTime(2024, 6, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6385), "Kalabria", "wlochy", null, "Via Nazionale", 170, 92m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6384), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("32a6d2e1-1b3f-4c32-933d-ea3be54cd798"), new DateTime(2024, 7, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(3892), "Alam", "egipt", null, "Sharia Tahrir", 167, 221m, 0m, 0m, 0m, new DateTime(2024, 7, 28, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(3891), "Vlora", "albania", null, "Rruga e Kavajes", "Bus" },
                    { new Guid("3301f0dd-1ef1-49e9-b4e0-6afc6a649a2a"), new DateTime(2024, 6, 8, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4705), "Alam", "egipt", null, "Sharia Tahrir", 90, 257m, 0m, 0m, 0m, new DateTime(2024, 6, 8, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4704), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("330cfbc1-d36d-4b56-a002-f37e966becdb"), new DateTime(2024, 7, 22, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6329), "Riwiera", "chorwacja", null, "Kapucinska ulica", 55, 176m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6328), "Kalabria", "wlochy", null, "Via del Corso", "Train" },
                    { new Guid("33382ec2-822c-42f5-8e0b-e4541c4e4a3a"), new DateTime(2024, 6, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5476), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 111, 168m, 0m, 0m, 0m, new DateTime(2024, 6, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5475), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("3360fa4e-6103-4965-a679-ffb3d73cd460"), new DateTime(2024, 6, 26, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4252), "Kalabria", "wlochy", null, "Via Veneto", 191, 244m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4251), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("33752f18-6f0a-4987-8dfc-dcd1c6e7712d"), new DateTime(2024, 6, 24, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4015), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 158, 271m, 0m, 0m, 0m, new DateTime(2024, 6, 24, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4014), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("34b05611-2c74-4f4c-9573-9a3d3932a4e6"), new DateTime(2024, 6, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4055), "Vlora", "albania", null, "Rruga e Kavajes", 108, 227m, 0m, 0m, 0m, new DateTime(2024, 6, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4054), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("34d912cd-12f0-4dde-80d9-0bc016fc5b79"), new DateTime(2024, 7, 26, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4410), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 50, 214m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4409), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("34e324f2-c5f7-4559-8690-76274f6020f4"), new DateTime(2024, 6, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6095), "Alam", "egipt", null, "Sharia Ramsis", 105, 268m, 0m, 0m, 0m, new DateTime(2024, 6, 21, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6093), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("360f3f1a-27b6-413d-9228-65dc7834c2ae"), new DateTime(2024, 7, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5251), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 57, 158m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5250), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("36526872-a74c-4f44-9d3b-0fe24a159a3c"), new DateTime(2024, 5, 29, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6365), "Kalabria", "wlochy", null, "Via Veneto", 69, 123m, 0m, 0m, 0m, new DateTime(2024, 5, 29, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6364), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("369b12ec-3d4f-48e1-983d-f85c43b0aa42"), new DateTime(2024, 6, 3, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4071), "Turecka", "turcja", null, "Bağdat Caddesi", 86, 84m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4071), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("36bce1df-febe-4cf7-94ae-e8ba86efe8d5"), new DateTime(2024, 6, 10, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5916), "Vlora", "albania", null, "Rruga e Kavajes", 67, 92m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5915), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("36f5d6ad-2bf9-4e90-b187-bc5e16fb1764"), new DateTime(2024, 8, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6008), "Riwiera", "chorwacja", null, "Maksimirska ulica", 131, 134m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6007), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("372ccd08-6fc2-46e4-b265-46f9f0e49575"), new DateTime(2024, 6, 19, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5205), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 165, 211m, 0m, 0m, 0m, new DateTime(2024, 6, 18, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5204), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("38acea95-f1bd-4715-b65b-73e42c9b6626"), new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5247), "Sheikh", "egipt", null, "Sharia Ramsis", 125, 169m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5246), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("392c0c82-e64e-49fe-9cdf-d80727438d4d"), new DateTime(2024, 6, 9, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4898), "Kalabria", "wlochy", null, "Via Nazionale", 184, 101m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4897), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("3acb665d-fd57-4074-af8a-201381a13cbe"), new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5432), "Alam", "egipt", null, "Sharia Tahrir", 183, 125m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5431), "Peloponez", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("3adb42d7-e8c7-43a4-8c15-1353a8ef3d19"), new DateTime(2024, 6, 20, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6129), "Durres", "albania", null, "Rruga e Dibres", 121, 297m, 0m, 0m, 0m, new DateTime(2024, 6, 20, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6128), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("3c3694fe-1d0d-4a90-9e99-6ca416689202"), new DateTime(2024, 7, 11, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6903), "Sheikh", "egipt", null, "Sharia Salah Salem", 99, 136m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6902), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("3c4c4b2d-4807-4260-9e55-09ec659cb12b"), new DateTime(2024, 6, 18, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6215), "Heraklion", "grecja", null, "Plateia Syntagmatos", 103, 172m, 0m, 0m, 0m, new DateTime(2024, 6, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6214), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("3d66d9c3-5ac1-41bd-891f-98325bf7b64b"), new DateTime(2024, 8, 4, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5155), "Brava", "hiszpania", null, "Calle Mayor", 79, 118m, 0m, 0m, 0m, new DateTime(2024, 8, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5154), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("3dc70e7a-f569-4e83-b500-2c409275fea8"), new DateTime(2024, 6, 15, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6145), "Brava", "hiszpania", null, "Paseo del Prado", 106, 161m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6144), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("3dd6d8a9-2dd4-447e-acb0-703f939aef75"), new DateTime(2024, 6, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(3883), "Durres", "albania", null, "Rruga e Dibres", 159, 149m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(3882), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("3e191e65-aa56-44f3-b404-327dfa1d5349"), new DateTime(2024, 8, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6656), "Turecka", "turcja", null, "Bağdat Caddesi", 58, 187m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6655), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("3f260cc0-b777-4700-88cb-5e7d8dbbf0c0"), new DateTime(2024, 7, 21, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5793), "Durres", "albania", null, "Rruga e Dibres", 166, 112m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5792), "Durres", "albania", null, "Bulevardi Bajram Curri", "Bus" },
                    { new Guid("3fa28c8a-b711-4170-96ba-2405ae38e9c1"), new DateTime(2024, 6, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5452), "Durres", "albania", null, "Rruga Abdyl Frasheri", 155, 249m, 0m, 0m, 0m, new DateTime(2024, 6, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5451), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Train" },
                    { new Guid("3fc4003c-4e6e-494b-80bb-9a78970744ca"), new DateTime(2024, 6, 8, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4399), "Alam", "egipt", null, "Sharia Tahrir", 117, 273m, 0m, 0m, 0m, new DateTime(2024, 6, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4398), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("3fe32803-eb37-4dfe-a68d-82e1c0f47f61"), new DateTime(2024, 7, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4363), "Nero", "grecja", null, "Leoforos Alexandras", 195, 208m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4362), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("40250884-edd1-420c-978a-6a177a91c6b1"), new DateTime(2024, 6, 2, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4243), "Luz", "hiszpania", null, "Calle Mayor", 151, 148m, 0m, 0m, 0m, new DateTime(2024, 6, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4242), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("40f8de8a-9a13-4f68-bb84-780b407dac81"), new DateTime(2024, 5, 31, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5090), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 166, 275m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5089), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("41a2fe6e-c45d-4f00-ab29-d313b796fa91"), new DateTime(2024, 6, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6345), "Riwiera", "chorwacja", null, "Vukovarska ulica", 128, 95m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6344), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("41ec14a8-9cfa-4df1-bc06-be7e01d4c755"), new DateTime(2024, 6, 18, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5098), "Sheikh", "egipt", null, "Sharia Tahrir", 126, 190m, 0m, 0m, 0m, new DateTime(2024, 6, 17, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5097), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("41fda860-d5e3-47b4-a2bf-fc67fd23ff63"), new DateTime(2024, 7, 17, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4276), "Heraklion", "grecja", null, "Plateia Syntagmatos", 193, 189m, 0m, 0m, 0m, new DateTime(2024, 7, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4275), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("4255f6f1-fd9a-4c2c-83f4-f765626a4be3"), new DateTime(2024, 7, 1, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6513), "Peloponez", "grecja", null, "Leoforos Alexandras", 127, 82m, 0m, 0m, 0m, new DateTime(2024, 6, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6512), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("43525c91-a1ab-4436-9bd6-598c2c3d072f"), new DateTime(2024, 6, 14, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6150), "Durres", "albania", null, "Rruga Abdyl Frasheri", 175, 65m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6149), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("439235df-d030-4e94-95a2-ff90201bec19"), new DateTime(2024, 7, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4726), "Riwiera", "chorwacja", null, "Kapucinska ulica", 177, 108m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4725), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("43faa088-f9e3-47d3-8a3b-63f8707ceff0"), new DateTime(2024, 7, 4, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(3867), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 60, 262m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(3859), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("443e6bc5-1f66-41b0-9cd7-7b31ae1098c0"), new DateTime(2024, 6, 28, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4374), "Riwiera", "chorwacja", null, "Maksimirska ulica", 158, 172m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4373), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("462f3d36-41fc-48a3-a430-8a38323cb17a"), new DateTime(2024, 8, 22, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6132), "Vlora", "albania", null, "Rruga e Kavajes", 134, 208m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6132), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("475792fc-0a58-410c-9fed-47a79b6f7924"), new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5571), "Turecka", "turcja", null, "Bağdat Caddesi", 67, 268m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5571), "Sheikh", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("483b162e-b79d-4cb0-a6b8-fa26eb7e09ab"), new DateTime(2024, 7, 22, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6166), "Riwiera", "chorwacja", null, "Maksimirska ulica", 174, 295m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6165), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("4841c33d-d7a8-4be8-a1a6-aa40f89ea1c4"), new DateTime(2024, 8, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5609), "Maresme", "hiszpania", null, "Paseo del Prado", 67, 96m, 0m, 0m, 0m, new DateTime(2024, 8, 9, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5608), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("48a6fb05-2669-4f9b-87a6-5596bb4d3d5a"), new DateTime(2024, 7, 29, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4132), "Vlora", "albania", null, "Rruga e Kavajes", 115, 193m, 0m, 0m, 0m, new DateTime(2024, 7, 29, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4131), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("49274805-3c5f-4cdf-8f53-193da44c81fa"), new DateTime(2024, 6, 12, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5272), "Turecka", "turcja", null, "Atatürk Caddesi", 92, 215m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5271), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("4995bade-fe68-4b89-ba79-2082f1dc3819"), new DateTime(2024, 6, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6116), "Kalabria", "wlochy", null, "Via Veneto", 160, 131m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6115), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("49fd6301-49fa-4899-a480-36e954917c4a"), new DateTime(2024, 8, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5263), "Nero", "grecja", null, "Leoforos Alexandras", 148, 131m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5263), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("4a0b6c54-095c-4cfa-b42f-2d756487edee"), new DateTime(2024, 6, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4604), "Durres", "albania", null, "Rruga e Dibres", 178, 245m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4604), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("4a4367c9-0bc6-4c31-ac5b-2e1c025c4173"), new DateTime(2024, 7, 11, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6318), "Turecka", "turcja", null, "Bağdat Caddesi", 57, 226m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6317), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("4af92ca3-0cb3-49de-a045-d5160aa5f59d"), new DateTime(2024, 6, 1, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5938), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 58, 194m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5937), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("4afcc932-148f-4aa2-bea7-557998378ef7"), new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5567), "Kalabria", "wlochy", null, "Via Veneto", 163, 191m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5566), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("4b0bb5c5-2a57-4425-aa37-b62f8b6068db"), new DateTime(2024, 8, 18, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6207), "Brava", "hiszpania", null, "Gran Vía", 118, 184m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6206), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("4b927f4b-cecc-4c31-bc84-ee95f7a7e4ad"), new DateTime(2024, 6, 5, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4124), "Alam", "egipt", null, "Sharia Tahrir", 170, 197m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4123), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("4bade09f-ff75-4b02-bbfc-9c0048d453ad"), new DateTime(2024, 6, 28, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4918), "Alam", "egipt", null, "Sharia Tahrir", 197, 157m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4917), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("4bdef029-717b-4dcc-91ae-23627f6351b4"), new DateTime(2024, 8, 17, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4714), "Vlora", "albania", null, "Rruga e Kavajes", 131, 265m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4713), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("4c24b9ac-e571-42a8-b96e-ea0ba0d4b02d"), new DateTime(2024, 7, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6693), "Durres", "albania", null, "Rruga e Dibres", 168, 248m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6692), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("4c55c99b-9452-4cfc-a414-325b2fc16f96"), new DateTime(2024, 8, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6259), "Turecka", "turcja", null, "Atatürk Caddesi", 94, 187m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6258), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("4c566d7a-6d85-4b14-9718-d7bc6c24e084"), new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6280), "Vlora", "albania", null, "Rruga 28 Nentori", 200, 74m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6279), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("4c9666a6-9837-43a0-96c4-47774b8b060d"), new DateTime(2024, 8, 11, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5022), "Kalabria", "wlochy", null, "Via del Corso", 53, 109m, 0m, 0m, 0m, new DateTime(2024, 8, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5021), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("4d8a427a-8750-432d-a672-fa7325a9211d"), new DateTime(2024, 6, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4803), "Alam", "egipt", null, "Sharia Ramsis", 134, 194m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4802), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("4e946abb-820b-4e38-a5a0-65f935e3c259"), new DateTime(2024, 6, 24, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4739), "Durres", "albania", null, "Rruga Abdyl Frasheri", 68, 135m, 0m, 0m, 0m, new DateTime(2024, 6, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4738), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("4fb9a445-9e97-4b0c-bcd0-3bb9ac54e3d0"), new DateTime(2024, 7, 14, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5412), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 86, 196m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5411), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("50035f01-8aca-4c46-8e07-136996b22a72"), new DateTime(2024, 6, 25, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6272), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 57, 137m, 0m, 0m, 0m, new DateTime(2024, 6, 25, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6271), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("515df4ee-92fd-4791-81a0-03085e0c8e68"), new DateTime(2024, 7, 2, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4621), "Sheikh", "egipt", null, "Sharia Ramsis", 108, 67m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4619), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("51b7c19d-89a7-4339-8c98-9eaf767fb8a5"), new DateTime(2024, 6, 9, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5663), "Almeria", "hiszpania", null, "Paseo del Prado", 199, 259m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5662), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("5256d696-be11-48e1-bc1e-4ddaa28aa37c"), new DateTime(2024, 7, 23, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4755), "Alam", "egipt", null, "Sharia Tahrir", 116, 96m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4754), "Peloponez", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("52776fa3-9743-4f7d-abd0-cec3bb95fa79"), new DateTime(2024, 8, 19, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4951), "Almeria", "hiszpania", null, "Paseo del Prado", 143, 196m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4950), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("52884dc2-2de1-41ed-9793-1ca28a4e57dd"), new DateTime(2024, 6, 25, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6668), "Kalabria", "wlochy", null, "Via Veneto", 155, 172m, 0m, 0m, 0m, new DateTime(2024, 6, 25, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6667), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("52da3e53-56b9-47f7-bbed-3284e0c8f8ed"), new DateTime(2024, 6, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6508), "Turecka", "turcja", null, "Atatürk Caddesi", 172, 226m, 0m, 0m, 0m, new DateTime(2024, 6, 16, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6508), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("532d7285-9218-40ef-97c1-4494840a2177"), new DateTime(2024, 7, 24, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6521), "Riwiera", "chorwacja", null, "Vukovarska ulica", 121, 186m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6520), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("53bc034f-b443-46a7-8e4b-f6dd9f20fbdf"), new DateTime(2024, 7, 21, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4083), "Kalabria", "wlochy", null, "Via del Corso", 107, 60m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4082), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("53df456f-cde2-43e7-bb49-c9445a7e319f"), new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5259), "Nero", "grecja", null, "Leoforos Alexandras", 161, 145m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5259), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("53e5538f-fbf0-45f1-8346-3528d1b20bf8"), new DateTime(2024, 6, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5316), "Riwiera", "chorwacja", null, "Maksimirska ulica", 138, 222m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5315), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("54b51986-eb68-4329-ad93-c334c0076668"), new DateTime(2024, 7, 4, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4747), "Durres", "albania", null, "Rruga Abdyl Frasheri", 82, 118m, 0m, 0m, 0m, new DateTime(2024, 7, 3, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4746), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("55114206-88ae-42e6-a106-69ee86752084"), new DateTime(2024, 6, 22, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5592), "Alam", "egipt", null, "Sharia Ramsis", 174, 296m, 0m, 0m, 0m, new DateTime(2024, 6, 21, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5591), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("55266bd4-f9da-4f22-b749-d322a7ec8357"), new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5984), "Turecka", "turcja", null, "Bağdat Caddesi", 155, 106m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5983), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("5649eb44-f826-4ab7-87a8-c1e054d07ce4"), new DateTime(2024, 7, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5325), "Brava", "hiszpania", null, "Gran Vía", 99, 187m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5324), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("57137ec7-9270-430e-9236-490402be9137"), new DateTime(2024, 6, 17, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6493), "Sheikh", "egipt", null, "Sharia Salah Salem", 167, 246m, 0m, 0m, 0m, new DateTime(2024, 6, 16, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6492), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("5778f175-bfe9-43ac-91e8-2896f6df83fa"), new DateTime(2024, 6, 6, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(3943), "Kalabria", "wlochy", null, "Via Nazionale", 182, 156m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(3942), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("57d4462a-f4cb-48b6-84d6-ffb5415f4777"), new DateTime(2024, 6, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4292), "Kalabria", "wlochy", null, "Via Nazionale", 152, 51m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4291), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("5875c8b8-8f67-41f6-8de4-88dd1b05ac33"), new DateTime(2024, 7, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4906), "Riwiera", "chorwacja", null, "Maksimirska ulica", 106, 212m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4905), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("5891ce70-ea29-4652-9071-c3d32df3f06d"), new DateTime(2024, 7, 8, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6617), "Kalabria", "wlochy", null, "Via Veneto", 161, 284m, 0m, 0m, 0m, new DateTime(2024, 7, 7, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6616), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("592a0d4e-4486-4e72-8f2e-b0ec262a3d32"), new DateTime(2024, 7, 28, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6810), "Riwiera", "chorwacja", null, "Maksimirska ulica", 103, 156m, 0m, 0m, 0m, new DateTime(2024, 7, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6809), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("5951f0bb-c341-4cc5-a023-332914af7ef9"), new DateTime(2024, 8, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5757), "Maresme", "hiszpania", null, "Paseo del Prado", 193, 88m, 0m, 0m, 0m, new DateTime(2024, 8, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5756), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("598ae609-bb45-478d-920a-cb0fc45490cc"), new DateTime(2024, 6, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5580), "Riwiera", "chorwacja", null, "Maksimirska ulica", 157, 197m, 0m, 0m, 0m, new DateTime(2024, 6, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5579), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("5ac8ecaf-545b-45a8-b989-0d33855f9d0b"), new DateTime(2024, 8, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6557), "Luz", "hiszpania", null, "Calle Mayor", 133, 129m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6557), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("5b26f030-7de2-42a7-9331-aeb6ec9a659a"), new DateTime(2024, 7, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5427), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 116, 271m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5426), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("5c342a88-bc08-42f4-8fde-4181520f9c91"), new DateTime(2024, 8, 20, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5781), "Durres", "albania", null, "Rruga Abdyl Frasheri", 123, 251m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5780), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("5c683411-517a-4360-ac23-2f38c3593dee"), new DateTime(2024, 7, 30, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6621), "Alam", "egipt", null, "Sharia Tahrir", 188, 149m, 0m, 0m, 0m, new DateTime(2024, 7, 30, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6621), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("5cc67bd0-bc61-4ae1-88f3-b9839821c4ba"), new DateTime(2024, 7, 19, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4775), "Durres", "albania", null, "Rruga e Dibres", 141, 55m, 0m, 0m, 0m, new DateTime(2024, 7, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4774), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("5d0400b3-068e-44b8-815e-4d4b36112fb1"), new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4865), "Vlora", "albania", null, "Rruga 28 Nentori", 194, 83m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4864), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("5d4c7cf0-f782-4f9e-8448-f8f7bc85d7ec"), new DateTime(2024, 6, 8, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6835), "Maresme", "hiszpania", null, "Paseo del Prado", 196, 80m, 0m, 0m, 0m, new DateTime(2024, 6, 8, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6834), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("5d898b69-63d3-479a-a05e-e4cd51101ed1"), new DateTime(2024, 7, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4239), "Almeria", "hiszpania", null, "Paseo del Prado", 97, 136m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4238), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("5e59e7bc-fc12-417e-98a6-05ddb5c8a624"), new DateTime(2024, 7, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6140), "Sheikh", "egipt", null, "Sharia Tahrir", 192, 129m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6139), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("5e6eece5-02f7-44af-b131-dda97d78591c"), new DateTime(2024, 8, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5049), "Sheikh", "egipt", null, "Sharia Ramsis", 184, 237m, 0m, 0m, 0m, new DateTime(2024, 8, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5048), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("5edd3e53-1ee7-401d-8293-f88674f6a603"), new DateTime(2024, 8, 14, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4108), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 51, 199m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4107), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("5f93ff81-afeb-4b14-a621-ef91704467d9"), new DateTime(2024, 7, 22, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4580), "Luz", "hiszpania", null, "Calle Mayor", 96, 126m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4579), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("60109d52-834d-4f11-a59f-87b4bdfd34d4"), new DateTime(2024, 7, 22, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6672), "Heraklion", "grecja", null, "Plateia Syntagmatos", 84, 125m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6672), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("60393959-db0f-4608-9106-90cf5da5beb7"), new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6651), "Peloponez", "grecja", null, "Leoforos Alexandras", 117, 257m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6651), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("609ab132-f455-49c1-9fea-946023b584e1"), new DateTime(2024, 7, 27, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6354), "Brava", "hiszpania", null, "Calle Mayor", 137, 87m, 0m, 0m, 0m, new DateTime(2024, 7, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6353), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("61581a5f-2957-401b-b7db-4eac0f990418"), new DateTime(2024, 7, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6605), "Turecka", "turcja", null, "Atatürk Caddesi", 63, 140m, 0m, 0m, 0m, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6604), "Brava", "hiszpania", null, "Gran Vía", "Bus" },
                    { new Guid("61c155d0-229d-4546-8afc-d6f3f0b764bf"), new DateTime(2024, 6, 3, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6111), "Sheikh", "egipt", null, "Sharia Tahrir", 164, 146m, 0m, 0m, 0m, new DateTime(2024, 6, 2, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6111), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("621ed7d8-4115-498d-bc53-24895e360147"), new DateTime(2024, 7, 14, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4222), "Durres", "albania", null, "Rruga e Dibres", 184, 252m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4221), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("62527bf9-ec44-4fbb-8ab5-2ae1be45d0f4"), new DateTime(2024, 8, 18, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4592), "Alam", "egipt", null, "Sharia Tahrir", 122, 251m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4591), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("625b2cd2-b465-4f10-a1ce-bdf3008b4477"), new DateTime(2024, 8, 16, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5069), "Alam", "egipt", null, "Sharia Tahrir", 88, 276m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5068), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("629fe310-354f-470f-bfe7-db3eab9d66ed"), new DateTime(2024, 7, 6, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6219), "Turecka", "turcja", null, "Atatürk Caddesi", 51, 222m, 0m, 0m, 0m, new DateTime(2024, 7, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6218), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("6435d935-b58d-49e3-9dd1-e99376ca6f83"), new DateTime(2024, 6, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6869), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 193, 253m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6868), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("6584127d-523c-4293-a4d9-cd8baee11080"), new DateTime(2024, 7, 5, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6477), "Turecka", "turcja", null, "Atatürk Caddesi", 64, 281m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6476), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("65845500-fe87-4953-8f90-803a1019e30c"), new DateTime(2024, 6, 28, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6788), "Durres", "albania", null, "Bulevardi Bajram Curri", 97, 224m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6787), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("658e5867-22d6-4373-b6b0-9b15c9503b33"), new DateTime(2024, 6, 19, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5749), "Nero", "grecja", null, "Leoforos Alexandras", 175, 254m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5748), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("66bd1e27-f8d4-4ba6-a9e7-c56ad8b34f59"), new DateTime(2024, 6, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4976), "Vlora", "albania", null, "Rruga e Kavajes", 132, 179m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4975), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("66be5bcd-6ad0-403e-b549-6f0264122a6b"), new DateTime(2024, 8, 22, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6630), "Alam", "egipt", null, "Sharia Tahrir", 101, 139m, 0m, 0m, 0m, new DateTime(2024, 8, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6629), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("68e68005-4f70-4d8a-b91c-fc754a30c896"), new DateTime(2024, 7, 7, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4693), "Almeria", "hiszpania", null, "Paseo del Prado", 81, 199m, 0m, 0m, 0m, new DateTime(2024, 7, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4692), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("691da9d2-b86b-497f-a2d3-44b188d97754"), new DateTime(2024, 8, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4588), "Durres", "albania", null, "Bulevardi Bajram Curri", 133, 89m, 0m, 0m, 0m, new DateTime(2024, 8, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4587), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("69217239-08d6-4800-a5cb-9aa07cb95824"), new DateTime(2024, 7, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4549), "Durres", "albania", null, "Rruga Abdyl Frasheri", 185, 108m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4548), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("69a21483-444a-41d7-8f19-f2586a4d453f"), new DateTime(2024, 8, 21, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4087), "Durres", "albania", null, "Rruga e Dibres", 85, 131m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4087), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("6a0cba52-f3e3-4f53-b7fd-4f4459fe489c"), new DateTime(2024, 8, 3, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5636), "Brava", "hiszpania", null, "Paseo del Prado", 113, 286m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5636), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("6a32bee7-b5ee-4351-8dd4-d53f0e8b0cf0"), new DateTime(2024, 8, 18, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4247), "Heraklion", "grecja", null, "Plateia Syntagmatos", 109, 179m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4247), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("6aa6ca98-d5f1-453f-a007-d14fe61b8034"), new DateTime(2024, 8, 25, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5065), "Alam", "egipt", null, "Sharia Tahrir", 196, 137m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5064), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("6bf26f08-c8fe-4e7e-8359-213239b124a0"), new DateTime(2024, 8, 15, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6199), "Riwiera", "chorwacja", null, "Vukovarska ulica", 69, 140m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6198), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("6c49c95f-6cb0-4b08-8814-4b730b05d02d"), new DateTime(2024, 7, 16, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4025), "Luz", "hiszpania", null, "Calle Mayor", 51, 91m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4025), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("6c4ea837-9df4-42fa-b26f-79588ced8a47"), new DateTime(2024, 8, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4968), "Kalabria", "wlochy", null, "Via Nazionale", 146, 141m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4967), "Sheikh", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("6c845aba-d797-4b91-bd19-0e5b965657ae"), new DateTime(2024, 8, 27, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4922), "Alam", "egipt", null, "Sharia Tahrir", 71, 140m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4921), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("6d31964a-f276-4e54-ab34-ff6168f2adb0"), new DateTime(2024, 8, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5653), "Durres", "albania", null, "Rruga e Dibres", 168, 268m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5652), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("6d3462eb-d065-4972-961f-f50b0ab9937a"), new DateTime(2024, 6, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4046), "Kalabria", "wlochy", null, "Via del Corso", 128, 79m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4045), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("6dba49c7-7e12-475d-9123-5702019ced6f"), new DateTime(2024, 6, 27, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4625), "Alam", "egipt", null, "Sharia Tahrir", 155, 167m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4624), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("6de0fcc2-9b6f-4f46-a685-fb2e3cac514d"), new DateTime(2024, 8, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6911), "Turecka", "turcja", null, "Bağdat Caddesi", 184, 194m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6911), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("6ed30637-1282-4982-a08c-48da7ce98837"), new DateTime(2024, 7, 25, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5223), "Sheikh", "egipt", null, "Sharia Tahrir", 144, 129m, 0m, 0m, 0m, new DateTime(2024, 7, 25, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5223), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("6f6c69ba-8432-4eaa-96c6-3ff743cdf954"), new DateTime(2024, 6, 6, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4145), "Vlora", "albania", null, "Rruga 28 Nentori", 68, 101m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4144), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("7097a98c-5903-42d7-a3e2-ba26b5d840e8"), new DateTime(2024, 7, 28, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5197), "Durres", "albania", null, "Bulevardi Bajram Curri", 58, 126m, 0m, 0m, 0m, new DateTime(2024, 7, 28, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5197), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("7212bb55-bfba-4c0d-aa5e-dcf86815264f"), new DateTime(2024, 6, 20, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(5395), "Peloponez", "grecja", null, "Leoforos Alexandras", 151, 147m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5395), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("7365050d-c4dd-4555-a299-9d4f770052b4"), new DateTime(2024, 6, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(3930), "Turecka", "turcja", null, "Atatürk Caddesi", 150, 108m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(3929), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("736a5c2d-224d-4fc6-90b8-cbf095892806"), new DateTime(2024, 7, 7, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4234), "Vlora", "albania", null, "Rruga e Kavajes", 126, 160m, 0m, 0m, 0m, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4234), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("742aff7c-fea9-4c29-8264-335d671b35d9"), new DateTime(2024, 8, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6549), "Durres", "albania", null, "Rruga e Dibres", 167, 89m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6549), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("74382f26-b693-4cfe-936c-f066642ee47f"), new DateTime(2024, 8, 6, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4567), "Riwiera", "chorwacja", null, "Maksimirska ulica", 171, 125m, 0m, 0m, 0m, new DateTime(2024, 8, 5, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4566), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("74c8f3cb-431a-4194-8ff3-b2d0f8ea3506"), new DateTime(2024, 6, 19, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4719), "Turecka", "turcja", null, "Atatürk Caddesi", 106, 254m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4718), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("763a756a-0965-4d09-867e-977eb05a3ecd"), new DateTime(2024, 7, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4848), "Marmaris", "turcja", null, "Bağdat Caddesi", 152, 259m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4847), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("7646aa7f-d759-429c-85e3-96256659512c"), new DateTime(2024, 6, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6469), "Vlora", "albania", null, "Rruga e Kavajes", 66, 282m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6468), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("772f9071-8e43-400d-ab14-52bbc5e0f5aa"), new DateTime(2024, 6, 6, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4256), "Peloponez", "grecja", null, "Leoforos Alexandras", 125, 114m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4255), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("77662026-a0b1-4754-ad71-f22ac58d91f1"), new DateTime(2024, 7, 1, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6892), "Durres", "albania", null, "Rruga Abdyl Frasheri", 199, 68m, 0m, 0m, 0m, new DateTime(2024, 7, 1, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6891), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("77776e1b-a36a-4633-9c22-eb011083e3e8"), new DateTime(2024, 7, 4, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6541), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 90, 272m, 0m, 0m, 0m, new DateTime(2024, 7, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6540), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("7792b17e-c44b-46dc-ba3b-e63485c431ce"), new DateTime(2024, 6, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5082), "Durres", "albania", null, "Rruga Abdyl Frasheri", 159, 164m, 0m, 0m, 0m, new DateTime(2024, 6, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5081), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("77f8a524-ccf0-49bb-8590-558685a44ad9"), new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6823), "Turecka", "turcja", null, "Atatürk Caddesi", 120, 282m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6822), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Train" },
                    { new Guid("78645dfb-59ec-4278-a7d2-9e9023ba17bd"), new DateTime(2024, 6, 19, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4383), "Alam", "egipt", null, "Sharia Tahrir", 89, 199m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4382), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("78944ec2-72fa-4b64-955b-2efe56fd6eab"), new DateTime(2024, 8, 9, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4323), "Durres", "albania", null, "Rruga e Dibres", 169, 209m, 0m, 0m, 0m, new DateTime(2024, 8, 8, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4323), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("79a6b239-3185-4353-b6fd-af11a7d7c083"), new DateTime(2024, 7, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5292), "Kalabria", "wlochy", null, "Via del Corso", 133, 244m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5292), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("7b0ddc71-9455-4ca2-b867-bec98cd5d03d"), new DateTime(2024, 8, 24, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4230), "Heraklion", "grecja", null, "Plateia Syntagmatos", 143, 296m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4229), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("7b9c395e-42e8-4aa1-a04d-20df4c8dcbc6"), new DateTime(2024, 6, 11, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6798), "Riwiera", "chorwacja", null, "Maksimirska ulica", 179, 281m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6797), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("7bc5983e-94ad-4bbd-9349-e34533f8cf41"), new DateTime(2024, 6, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5903), "Peloponez", "grecja", null, "Leoforos Alexandras", 171, 68m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5903), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("7bd8fadb-468c-4e24-a326-418ea9242bb5"), new DateTime(2024, 6, 2, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6177), "Sheikh", "egipt", null, "Sharia Tahrir", 77, 178m, 0m, 0m, 0m, new DateTime(2024, 6, 2, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6177), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("7c236d68-0d4d-4139-9c9a-6a3793953538"), new DateTime(2024, 8, 20, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6430), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 192, 241m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6429), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("7d649274-0e52-45df-a153-1b5a67009aea"), new DateTime(2024, 6, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5309), "Brava", "hiszpania", null, "Calle Mayor", 104, 94m, 0m, 0m, 0m, new DateTime(2024, 6, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5308), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("7ee22798-63f6-4710-be09-3874d7d28a8d"), new DateTime(2024, 8, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5463), "Turecka", "turcja", null, "Atatürk Caddesi", 62, 242m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5462), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("7ee92b4f-9d61-465f-9d2e-5ffc81694807"), new DateTime(2024, 7, 22, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5967), "Maresme", "hiszpania", null, "Paseo del Prado", 131, 166m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5966), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("7f15ae71-1c48-4b9a-93cd-d97611e80e6d"), new DateTime(2024, 8, 19, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4209), "Sheikh", "egipt", null, "Sharia Salah Salem", 102, 213m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4208), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("7f470928-5827-41e3-b431-ca974e83c68a"), new DateTime(2024, 8, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4034), "Durres", "albania", null, "Rruga e Dibres", 94, 173m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4033), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("7f5fe41e-7885-459e-815c-412190145143"), new DateTime(2024, 6, 2, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4280), "Maresme", "hiszpania", null, "Paseo del Prado", 148, 127m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4279), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("7f7bb65d-4249-4a1a-98b5-bfd30c344aaf"), new DateTime(2024, 8, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6187), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 131, 287m, 0m, 0m, 0m, new DateTime(2024, 8, 7, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6186), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("7fef1bf5-41fa-4b05-9049-9b01b0de033c"), new DateTime(2024, 7, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6818), "Turecka", "turcja", null, "Atatürk Caddesi", 149, 186m, 0m, 0m, 0m, new DateTime(2024, 7, 16, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6818), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("808f4a6b-755e-440a-b5c5-0ce0d6417d66"), new DateTime(2024, 8, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6287), "Kalabria", "wlochy", null, "Via Nazionale", 96, 232m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6286), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("818486df-c0c7-460d-ad18-f292f3647a8c"), new DateTime(2024, 6, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4735), "Marmaris", "turcja", null, "Bağdat Caddesi", 175, 158m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4734), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("8275f5cb-0c0a-47f7-b0cb-6f04ffe99089"), new DateTime(2024, 7, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5798), "Durres", "albania", null, "Rruga Abdyl Frasheri", 55, 233m, 0m, 0m, 0m, new DateTime(2024, 7, 18, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5797), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("828fe435-bb58-46c2-9ccb-1dfb0376e996"), new DateTime(2024, 8, 1, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5147), "Heraklion", "grecja", null, "Plateia Syntagmatos", 200, 81m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5146), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("82a5da2e-5521-42be-b55b-897c5d4d1e2c"), new DateTime(2024, 7, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4914), "Brava", "hiszpania", null, "Calle Mayor", 147, 153m, 0m, 0m, 0m, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4913), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("83bb88ed-5597-40d4-9699-48a3f21a124a"), new DateTime(2024, 7, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6858), "Vlora", "albania", null, "Rruga 28 Nentori", 94, 273m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6857), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("83e415ea-6728-4e9d-aa7c-52f3cb1da9f1"), new DateTime(2024, 6, 11, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4743), "Brava", "hiszpania", null, "Calle de Alcalá", 100, 54m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4742), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("84258752-c63e-4bba-b121-c2629cf03c0b"), new DateTime(2024, 7, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4852), "Luz", "hiszpania", null, "Calle Mayor", 163, 294m, 0m, 0m, 0m, new DateTime(2024, 7, 8, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4851), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("84422b5c-635f-4c15-9238-36912236d11a"), new DateTime(2024, 7, 20, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4296), "Turecka", "turcja", null, "Atatürk Caddesi", 157, 184m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4295), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("850459ff-ecc6-4e98-a6fd-9157275e72b0"), new DateTime(2024, 8, 13, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(3939), "Almeria", "hiszpania", null, "Paseo del Prado", 131, 257m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(3938), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("8512de6a-9961-4771-b7ac-b57d62c4e878"), new DateTime(2024, 6, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5053), "Alam", "egipt", null, "Sharia Ramsis", 135, 56m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5052), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("85498e9e-3ea9-452b-9ae3-82c200f7c0ee"), new DateTime(2024, 7, 14, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(3876), "Sheikh", "egipt", null, "Sharia Tahrir", 123, 285m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(3876), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("85925723-359d-4b02-9fa9-e244f8d835f7"), new DateTime(2024, 5, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6677), "Heraklion", "grecja", null, "Plateia Syntagmatos", 160, 244m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6676), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("85fb5ee6-6ce6-4c4f-8541-e820c1cecf67"), new DateTime(2024, 6, 11, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4021), "Turecka", "turcja", null, "Atatürk Caddesi", 163, 167m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4020), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("880da1fa-1ea9-4d98-b012-bb6cb16e7d00"), new DateTime(2024, 8, 15, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4596), "Kalabria", "wlochy", null, "Via Nazionale", 79, 283m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4595), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("883c23d5-ac2e-4ed7-868c-6a0ea5024ebe"), new DateTime(2024, 8, 19, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4885), "Maresme", "hiszpania", null, "Paseo del Prado", 150, 179m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4884), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("88683758-f1cc-487b-b7c5-4b5eca88bad4"), new DateTime(2024, 8, 6, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(4260), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 107, 264m, 0m, 0m, 0m, new DateTime(2024, 8, 5, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4259), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("8938956c-da09-4afa-8eb4-4dea144a27aa"), new DateTime(2024, 8, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6525), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 110, 190m, 0m, 0m, 0m, new DateTime(2024, 8, 3, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6524), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("8973462c-f309-47c8-bae4-33462f5291e2"), new DateTime(2024, 6, 25, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4067), "Peloponez", "grecja", null, "Leoforos Alexandras", 79, 193m, 0m, 0m, 0m, new DateTime(2024, 6, 24, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4067), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("8a298dce-6b4b-4613-bfac-61bfaa2f2a50"), new DateTime(2024, 7, 31, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6554), "Alam", "egipt", null, "Sharia Ramsis", 50, 91m, 0m, 0m, 0m, new DateTime(2024, 7, 30, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6553), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("8a432cdf-792c-4312-8c64-947e8f183142"), new DateTime(2024, 8, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5287), "Riwiera", "chorwacja", null, "Kapucinska ulica", 155, 151m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5287), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("8abaaef7-7de3-41de-89c5-2432be8a905e"), new DateTime(2024, 8, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5420), "Peloponez", "grecja", null, "Leoforos Alexandras", 102, 202m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5419), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("8b6b7214-1580-421b-937c-4514fb4d819c"), new DateTime(2024, 8, 17, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6485), "Turecka", "turcja", null, "Atatürk Caddesi", 128, 79m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6484), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("8b6e1f99-96d0-4357-9b76-49850ec12797"), new DateTime(2024, 6, 4, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5907), "Nero", "grecja", null, "Leoforos Alexandras", 144, 59m, 0m, 0m, 0m, new DateTime(2024, 6, 4, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5907), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("8b741baf-4612-4340-877d-1dcfec89093e"), new DateTime(2024, 7, 18, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6883), "Turecka", "turcja", null, "Bağdat Caddesi", 71, 152m, 0m, 0m, 0m, new DateTime(2024, 7, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6883), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("8c1ca158-4c79-4163-a613-7f9efb9b7f52"), new DateTime(2024, 7, 23, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4616), "Vlora", "albania", null, "Rruga e Kavajes", 197, 78m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4615), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("8ddda30f-88f9-4e92-b124-c9211c34d91d"), new DateTime(2024, 8, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6846), "Turecka", "turcja", null, "Atatürk Caddesi", 176, 143m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6845), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("8de1e46d-c8ec-4a15-8a42-169f131d7049"), new DateTime(2024, 7, 31, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4980), "Durres", "albania", null, "Bulevardi Bajram Curri", 81, 270m, 0m, 0m, 0m, new DateTime(2024, 7, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4980), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("8e91234d-901b-406f-b938-b7ecbc043e73"), new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5296), "Heraklion", "grecja", null, "Plateia Syntagmatos", 50, 243m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5296), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("8f5bbbda-14c9-4240-bdc4-5897be36e4ea"), new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4367), "Kalabria", "wlochy", null, "Via del Corso", 164, 104m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4366), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("8fb7a589-b164-4156-ad50-4b4ce71661d6"), new DateTime(2024, 8, 6, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6831), "Turecka", "turcja", null, "Atatürk Caddesi", 188, 141m, 0m, 0m, 0m, new DateTime(2024, 8, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6830), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("9066bc80-dd1e-4967-b584-ca6c5b25bc0c"), new DateTime(2024, 8, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5996), "Durres", "albania", null, "Rruga e Dibres", 77, 67m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5995), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("90ccbcc4-559c-4fdb-8fbd-0d0f4eae3ccc"), new DateTime(2024, 8, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5210), "Brava", "hiszpania", null, "Calle de Alcalá", 184, 65m, 0m, 0m, 0m, new DateTime(2024, 8, 7, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5209), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("9100c878-4cdd-493c-912c-e6ee5781c246"), new DateTime(2024, 7, 16, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5691), "Durres", "albania", null, "Bulevardi Bajram Curri", 136, 151m, 0m, 0m, 0m, new DateTime(2024, 7, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5691), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("9104436e-ae77-488d-a456-1812dbf93620"), new DateTime(2024, 7, 12, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5467), "Heraklion", "grecja", null, "Plateia Syntagmatos", 74, 146m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5466), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("9155e7fa-164e-46c1-9c1a-e769d7224c9e"), new DateTime(2024, 7, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4955), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 131, 51m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4954), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("915cabe0-6212-4e53-8587-e2f93603d3f9"), new DateTime(2024, 6, 13, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4403), "Marmaris", "turcja", null, "Bağdat Caddesi", 83, 207m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4402), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("921752ef-f203-4362-95ae-1e4e010e7f19"), new DateTime(2024, 7, 18, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5105), "Riwiera", "chorwacja", null, "Maksimirska ulica", 191, 192m, 0m, 0m, 0m, new DateTime(2024, 7, 18, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5105), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("921e883a-2799-47ce-9a44-3cbae38a64b8"), new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6191), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 137, 289m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6190), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("9245af68-fb58-4c4e-b094-53c3787d36c4"), new DateTime(2024, 7, 17, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6710), "Durres", "albania", null, "Bulevardi Bajram Curri", 179, 235m, 0m, 0m, 0m, new DateTime(2024, 7, 17, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6710), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("92ff069a-e863-4525-9a5a-f4e97df3b415"), new DateTime(2024, 7, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6529), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 122, 225m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6528), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("937a020b-c11d-47b7-8737-6121837da765"), new DateTime(2024, 6, 9, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6880), "Alam", "egipt", null, "Sharia Ramsis", 181, 62m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6878), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("94140dbc-0651-4214-9985-3db996d1ebf1"), new DateTime(2024, 6, 1, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6032), "Durres", "albania", null, "Bulevardi Bajram Curri", 126, 56m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6031), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("946200a9-04bb-4085-a246-d010765d24e0"), new DateTime(2024, 8, 14, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(3888), "Turecka", "turcja", null, "Bağdat Caddesi", 106, 122m, 0m, 0m, 0m, new DateTime(2024, 8, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(3887), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("9542fc5e-8a7c-49f1-9c3e-bbb5cdf31169"), new DateTime(2024, 8, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4387), "Turecka", "turcja", null, "Bağdat Caddesi", 175, 236m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4387), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("95afd198-3153-41d8-862b-98334a9b7941"), new DateTime(2024, 8, 18, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5404), "Sheikh", "egipt", null, "Sharia Tahrir", 74, 215m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5403), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("95b90e42-87b8-4508-9988-586399579c20"), new DateTime(2024, 6, 15, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6020), "Kalabria", "wlochy", null, "Via del Corso", 55, 196m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6020), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("96cf4267-9967-4453-bd8f-451a992f391d"), new DateTime(2024, 7, 3, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6268), "Brava", "hiszpania", null, "Gran Vía", 66, 131m, 0m, 0m, 0m, new DateTime(2024, 7, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6267), "Nero", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("97090ce7-427c-413d-9871-555e282b4984"), new DateTime(2024, 6, 3, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5852), "Luz", "hiszpania", null, "Calle Mayor", 195, 166m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5851), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("9826c27e-b8a5-46dd-b2d6-10cd8541b60a"), new DateTime(2024, 5, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5562), "Durres", "albania", null, "Rruga Abdyl Frasheri", 51, 291m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5561), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("98bb1c90-ee72-45c7-b6f4-cf0d6ce99b93"), new DateTime(2024, 7, 26, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5416), "Almeria", "hiszpania", null, "Paseo del Prado", 140, 187m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5415), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("98d74c27-049a-42ba-b9b6-7f883826291c"), new DateTime(2024, 8, 22, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5485), "Kalabria", "wlochy", null, "Via Veneto", 84, 198m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5484), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("9a482430-57c5-4425-8008-fb99f8b52cbf"), new DateTime(2024, 7, 1, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6369), "Brava", "hiszpania", null, "Calle Mayor", 186, 250m, 0m, 0m, 0m, new DateTime(2024, 7, 1, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6368), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("9a4e363b-f22d-4802-a88d-74005278103a"), new DateTime(2024, 8, 10, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6296), "Turecka", "turcja", null, "Atatürk Caddesi", 56, 159m, 0m, 0m, 0m, new DateTime(2024, 8, 10, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6295), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("9a72205b-b8d7-4e27-9cd6-b054af9404ef"), new DateTime(2024, 7, 4, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6545), "Turecka", "turcja", null, "Halaskargazi Caddesi", 194, 266m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6544), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("9b702bbe-bf08-4e59-bbee-bd7219ef643a"), new DateTime(2024, 6, 22, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6481), "Kalabria", "wlochy", null, "Via Nazionale", 123, 140m, 0m, 0m, 0m, new DateTime(2024, 6, 22, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6480), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("9bc5715f-82b9-4344-9a6d-c42ad855bdfe"), new DateTime(2024, 7, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(3950), "Vlora", "albania", null, "Rruga e Kavajes", 86, 75m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(3950), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("9bd2a24f-d5c0-4453-8218-cc60adcaec07"), new DateTime(2024, 7, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5676), "Alam", "egipt", null, "Sharia Ramsis", 56, 262m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5675), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("9bee6ebf-c1b0-4c3d-b3b9-e6adb437c858"), new DateTime(2024, 7, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6861), "Durres", "albania", null, "Rruga e Dibres", 98, 277m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6861), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("9d66b30e-1d41-43ca-aeff-9debb30ad69d"), new DateTime(2024, 8, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5817), "Alam", "egipt", null, "Sharia Tahrir", 56, 195m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5817), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("9df085d3-60cc-41be-aee3-03cf5c17a40a"), new DateTime(2024, 6, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6439), "Durres", "albania", null, "Rruga e Dibres", 176, 243m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6438), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("9fd2e128-fe57-4013-afc3-62a4034b6ac3"), new DateTime(2024, 8, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5138), "Alam", "egipt", null, "Sharia Tahrir", 130, 153m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5138), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("a008bcc8-7339-47f3-8349-c9e5e4b77029"), new DateTime(2024, 6, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4137), "Durres", "albania", null, "Rruga e Dibres", 191, 132m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4136), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("a08b317f-33f8-42cf-b0c3-e103b91e1f2e"), new DateTime(2024, 6, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6961), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 52, 73m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6960), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Plane" },
                    { new Guid("a0d92007-7ec5-47b3-86da-7542dbfd0f5b"), new DateTime(2024, 6, 17, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6182), "Vlora", "albania", null, "Rruga 28 Nentori", 171, 92m, 0m, 0m, 0m, new DateTime(2024, 6, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6181), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("a15d2d53-148b-4c4f-a129-fa55a6a9e14a"), new DateTime(2024, 7, 10, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6849), "Riwiera", "chorwacja", null, "Kapucinska ulica", 109, 171m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6849), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("a1dc375d-b006-49e2-ae12-d6f47f9e802e"), new DateTime(2024, 6, 30, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4902), "Sheikh", "egipt", null, "Sharia Ramsis", 166, 259m, 0m, 0m, 0m, new DateTime(2024, 6, 30, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4901), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("a1faf02b-b581-405a-abfb-9bca6b1e9ccf"), new DateTime(2024, 8, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(3913), "Riwiera", "chorwacja", null, "Kapucinska ulica", 135, 65m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(3912), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("a21e6e71-f777-44d0-bf8a-d977ff7af4ab"), new DateTime(2024, 7, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6103), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 157, 51m, 0m, 0m, 0m, new DateTime(2024, 7, 3, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6102), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a2989265-f827-4765-a0a5-f7cc0fe3a7fc"), new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5193), "Sheikh", "egipt", null, "Sharia Ramsis", 171, 188m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5192), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("a3bbe95a-04ca-4e79-abfa-850a03798e65"), new DateTime(2024, 6, 24, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4200), "Turecka", "turcja", null, "Bağdat Caddesi", 160, 97m, 0m, 0m, 0m, new DateTime(2024, 6, 24, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4198), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("a3f8f721-e6a0-43a8-9d40-a926f6a2c689"), new DateTime(2024, 7, 23, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6158), "Turecka", "turcja", null, "Bağdat Caddesi", 111, 224m, 0m, 0m, 0m, new DateTime(2024, 7, 22, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6157), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("a413d765-03f3-4915-88e3-7d74d030793a"), new DateTime(2024, 7, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5268), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 131, 228m, 0m, 0m, 0m, new DateTime(2024, 7, 3, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5267), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a597c37e-ec84-484d-b83f-2a12905f4ae5"), new DateTime(2024, 8, 20, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4792), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 187, 169m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4791), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("a5bdf384-14de-482e-ad8d-e0c5a7427239"), new DateTime(2024, 7, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6040), "Luz", "hiszpania", null, "Calle Mayor", 170, 116m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6040), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("a5c9b499-0420-46da-8622-d097708627f9"), new DateTime(2024, 7, 16, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5684), "Turecka", "turcja", null, "Atatürk Caddesi", 160, 185m, 0m, 0m, 0m, new DateTime(2024, 7, 16, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5683), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a5fed571-a1cc-4810-b055-b39b8c7b4b5b"), new DateTime(2024, 7, 4, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4149), "Durres", "albania", null, "Rruga e Dibres", 50, 104m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4148), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("a67f5e53-82d0-49ec-9c67-b67eef071b57"), new DateTime(2024, 7, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4557), "Sheikh", "egipt", null, "Sharia Tahrir", 57, 249m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4556), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("a6cf90dd-be92-4b7e-a913-2a0417ec3585"), new DateTime(2024, 6, 19, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5109), "Durres", "albania", null, "Rruga Abdyl Frasheri", 68, 194m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5108), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("a6fc7119-76da-4a39-bdab-050590216643"), new DateTime(2024, 6, 17, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4395), "Durres", "albania", null, "Rruga e Dibres", 124, 276m, 0m, 0m, 0m, new DateTime(2024, 6, 17, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4395), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a77c1259-67d2-4e37-a0f5-7ccf6251f4e0"), new DateTime(2024, 8, 21, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5612), "Turecka", "turcja", null, "Bağdat Caddesi", 56, 275m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5611), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("a7ecc4f3-6ee1-4cb8-a248-ab6e527f43b3"), new DateTime(2024, 8, 25, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6120), "Riwiera", "chorwacja", null, "Vukovarska ulica", 108, 235m, 0m, 0m, 0m, new DateTime(2024, 8, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6119), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("a94abd52-e1f3-425e-a6df-9b535dcfdd90"), new DateTime(2024, 8, 6, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5227), "Alam", "egipt", null, "Sharia Tahrir", 58, 118m, 0m, 0m, 0m, new DateTime(2024, 8, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5227), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("a9c18ee3-c68a-450f-afbb-178ab7c196fe"), new DateTime(2024, 8, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5102), "Sheikh", "egipt", null, "Sharia Salah Salem", 170, 127m, 0m, 0m, 0m, new DateTime(2024, 8, 20, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5101), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("ab283795-6b68-487f-88e4-af9d5bc4596c"), new DateTime(2024, 7, 3, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6360), "Durres", "albania", null, "Rruga Abdyl Frasheri", 98, 248m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6360), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("ab830f9c-4124-4fad-84f3-467623d7e68f"), new DateTime(2024, 7, 10, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4378), "Sheikh", "egipt", null, "Sharia Tahrir", 156, 64m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4378), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("ac721538-6e3a-4977-b352-d5a3d0701001"), new DateTime(2024, 8, 24, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(3901), "Nero", "grecja", null, "Leoforos Alexandras", 189, 64m, 0m, 0m, 0m, new DateTime(2024, 8, 24, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(3900), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("acc25501-ea42-480b-9c41-cd43e4a4e573"), new DateTime(2024, 6, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4935), "Riwiera", "chorwacja", null, "Maksimirska ulica", 129, 131m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4934), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("acf2bcc8-3a98-466e-a164-eca20181a54d"), new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4091), "Alam", "egipt", null, "Sharia Tahrir", 134, 152m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4090), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("acf8f863-b8e6-4e80-b159-8f5f75bf761e"), new DateTime(2024, 6, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6612), "Sheikh", "egipt", null, "Sharia Salah Salem", 107, 274m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6612), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("aedc32b2-2489-46e4-93da-5c1e76f96d4b"), new DateTime(2024, 7, 31, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6965), "Riwiera", "chorwacja", null, "Kapucinska ulica", 110, 50m, 0m, 0m, 0m, new DateTime(2024, 7, 31, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6964), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("af01ed56-c24b-4942-b2bf-7edd062297d4"), new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(4307), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 91, 135m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4307), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("afa5b05a-6389-4fbb-97e9-1810046c576d"), new DateTime(2024, 7, 31, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4575), "Marmaris", "turcja", null, "Bağdat Caddesi", 125, 110m, 0m, 0m, 0m, new DateTime(2024, 7, 31, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4574), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("b094cd2f-4248-4b65-83e1-7ad46022d32b"), new DateTime(2024, 8, 1, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5408), "Peloponez", "grecja", null, "Leoforos Alexandras", 144, 279m, 0m, 0m, 0m, new DateTime(2024, 7, 31, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5407), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("b0d1ac7f-9217-4af7-a6c0-d04c025ee9d9"), new DateTime(2024, 8, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5584), "Turecka", "turcja", null, "Atatürk Caddesi", 146, 89m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5583), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("b22de072-ef55-4afc-a3af-ca53c078756b"), new DateTime(2024, 6, 29, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6706), "Riwiera", "chorwacja", null, "Kapucinska ulica", 141, 130m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6705), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("b2a5aa60-3fa3-4c65-8e5c-7cf3c45bc5ed"), new DateTime(2024, 8, 7, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4213), "Sheikh", "egipt", null, "Sharia Ramsis", 184, 59m, 0m, 0m, 0m, new DateTime(2024, 8, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4212), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("b2e34325-faa3-4edb-bdcc-922ed5e0cdfa"), new DateTime(2024, 7, 18, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5761), "Marmaris", "turcja", null, "Bağdat Caddesi", 82, 108m, 0m, 0m, 0m, new DateTime(2024, 7, 18, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5760), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("b32d9c02-12c9-4e17-887f-4e824a10a8e8"), new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5032), "Heraklion", "grecja", null, "Plateia Syntagmatos", 195, 141m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5031), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("b35001f9-b40d-4f83-b523-e671f92425e1"), new DateTime(2024, 7, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6203), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 133, 290m, 0m, 0m, 0m, new DateTime(2024, 7, 15, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6202), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("b451530e-ccb2-487e-9f4c-ce89baa36012"), new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5865), "Kalabria", "wlochy", null, "Via Veneto", 178, 212m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5864), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("b45258b0-fa6d-4985-8bf7-8c8c3bb5ec8e"), new DateTime(2024, 7, 25, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5616), "Peloponez", "grecja", null, "Leoforos Alexandras", 194, 201m, 0m, 0m, 0m, new DateTime(2024, 7, 24, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5616), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("b4b50bce-fcea-4aa6-a98d-bcd5998d1fab"), new DateTime(2024, 7, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6300), "Alam", "egipt", null, "Sharia Ramsis", 65, 188m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6299), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("b51feca2-86b4-48ed-b392-b48150c40426"), new DateTime(2024, 7, 16, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6895), "Kalabria", "wlochy", null, "Via Veneto", 94, 122m, 0m, 0m, 0m, new DateTime(2024, 7, 16, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6895), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("b56c4a68-d113-4a31-812e-ac25e54b2f46"), new DateTime(2024, 8, 17, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5785), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 67, 160m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5785), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("b6896646-de44-463f-b043-6c13a66d65e6"), new DateTime(2024, 7, 27, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6504), "Alam", "egipt", null, "Sharia Tahrir", 179, 218m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6503), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("b78e5ca6-5601-4f51-8e50-9d1cc4e517c6"), new DateTime(2024, 7, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5472), "Riwiera", "chorwacja", null, "Maksimirska ulica", 147, 136m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5471), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("b7af1aac-73dc-412c-beea-9ec7b5c67f43"), new DateTime(2024, 6, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5122), "Brava", "hiszpania", null, "Calle Mayor", 94, 90m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5121), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("b7cb1176-9abe-4952-82b7-0d9830cf15a8"), new DateTime(2024, 7, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5856), "Durres", "albania", null, "Rruga e Dibres", 114, 177m, 0m, 0m, 0m, new DateTime(2024, 7, 26, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5856), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("b7cd8cab-7833-4c0b-9422-436bade0e978"), new DateTime(2024, 6, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4312), "Durres", "albania", null, "Rruga Abdyl Frasheri", 164, 247m, 0m, 0m, 0m, new DateTime(2024, 6, 12, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4311), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("b7dc6b86-e07e-43e1-9621-eff0284a830b"), new DateTime(2024, 6, 3, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4894), "Maresme", "hiszpania", null, "Paseo del Prado", 200, 151m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4893), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("b845843c-03ad-45b9-81a5-67d60e4dc2da"), new DateTime(2024, 7, 9, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5621), "Durres", "albania", null, "Bulevardi Bajram Curri", 62, 115m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5620), "Almeria", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("b9903a4b-1cf7-48b2-9123-4b0720c543fa"), new DateTime(2024, 6, 22, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5440), "Almeria", "hiszpania", null, "Paseo del Prado", 189, 264m, 0m, 0m, 0m, new DateTime(2024, 6, 22, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5439), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("bad4bb2c-ecc4-4f61-9c03-7b63cf227a41"), new DateTime(2024, 6, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5753), "Kalabria", "wlochy", null, "Via Veneto", 66, 241m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5752), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("baf79a8a-a15b-4e31-8f3c-9ec15b701cb5"), new DateTime(2024, 6, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4392), "Turecka", "turcja", null, "Halaskargazi Caddesi", 140, 71m, 0m, 0m, 0m, new DateTime(2024, 6, 10, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4391), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("bc95fe3b-1f26-4e5a-8103-ca3ee7c5d27c"), new DateTime(2024, 7, 11, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6792), "Riwiera", "chorwacja", null, "Kapucinska ulica", 160, 97m, 0m, 0m, 0m, new DateTime(2024, 7, 11, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(6791), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("bd1b7f86-d89e-4342-ab68-a20302d47128"), new DateTime(2024, 8, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6719), "Kalabria", "wlochy", null, "Via del Corso", 106, 157m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6719), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("bd2cc0a1-94cb-4719-b0a5-f4b11c44dce5"), new DateTime(2024, 8, 17, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5672), "Heraklion", "grecja", null, "Plateia Syntagmatos", 160, 297m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5670), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("bd93250d-08dd-4507-bbda-e441c29f8b5f"), new DateTime(2024, 8, 9, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(3935), "Heraklion", "grecja", null, "Plateia Syntagmatos", 125, 149m, 0m, 0m, 0m, new DateTime(2024, 8, 8, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(3934), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("bd947581-e390-4e37-973b-7f6b49fdcdb8"), new DateTime(2024, 8, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5971), "Alam", "egipt", null, "Sharia Tahrir", 53, 287m, 0m, 0m, 0m, new DateTime(2024, 8, 7, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5970), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("bda7b447-cd78-48e7-bcab-42ad75536f36"), new DateTime(2024, 6, 28, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5040), "Kalabria", "wlochy", null, "Via Nazionale", 151, 88m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5039), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("bdfbb8f7-2a14-4b1c-a10b-ddc1ee6d1021"), new DateTime(2024, 8, 3, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5740), "Alam", "egipt", null, "Sharia Ramsis", 140, 239m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5739), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("bdfbe8b8-c55c-42a8-9192-9ec279789fdf"), new DateTime(2024, 7, 22, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6727), "Sheikh", "egipt", null, "Sharia Ramsis", 169, 66m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6726), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("be7bf98b-6eb8-4b56-9607-e86f4f3747bc"), new DateTime(2024, 7, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6004), "Kalabria", "wlochy", null, "Via Veneto", 126, 255m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6003), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("bfb8942b-2935-4ec8-bb98-fbd39a557532"), new DateTime(2024, 6, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4972), "Peloponez", "grecja", null, "Leoforos Alexandras", 126, 123m, 0m, 0m, 0m, new DateTime(2024, 6, 16, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4971), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("c05af1bb-3c4e-47c1-8ef4-8586ac1ab0f9"), new DateTime(2024, 8, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5378), "Nero", "grecja", null, "Leoforos Alexandras", 129, 135m, 0m, 0m, 0m, new DateTime(2024, 8, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5377), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("c0ee555f-45a8-4674-af52-311952cad673"), new DateTime(2024, 6, 28, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5934), "Riwiera", "chorwacja", null, "Maksimirska ulica", 179, 157m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5933), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("c138814f-28bf-4b05-b39c-0ac7dedbc6dc"), new DateTime(2024, 7, 12, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(4939), "Sheikh", "egipt", null, "Sharia Tahrir", 181, 278m, 0m, 0m, 0m, new DateTime(2024, 7, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4939), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("c13a81fa-6a29-4bfc-a7c7-a08ceccac9a6"), new DateTime(2024, 8, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6036), "Peloponez", "grecja", null, "Leoforos Alexandras", 171, 195m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6035), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("c1d54431-584c-4767-bc11-53254364b4d3"), new DateTime(2024, 6, 19, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4680), "Peloponez", "grecja", null, "Leoforos Alexandras", 179, 260m, 0m, 0m, 0m, new DateTime(2024, 6, 19, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4679), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("c2894dee-38bb-4fd0-bc00-afcc9cf38950"), new DateTime(2024, 6, 11, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5605), "Alam", "egipt", null, "Sharia Ramsis", 156, 139m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5604), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("c299a1dd-2e55-47b3-aefe-a00f165d9d31"), new DateTime(2024, 8, 18, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6090), "Turecka", "turcja", null, "Atatürk Caddesi", 167, 79m, 0m, 0m, 0m, new DateTime(2024, 8, 18, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6089), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("c37ab55b-feec-42a5-99e0-b7ee2b4445e0"), new DateTime(2024, 8, 13, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6681), "Turecka", "turcja", null, "Atatürk Caddesi", 186, 278m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6680), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("c39ba93a-e8f7-4520-819b-df7ccdb0dd75"), new DateTime(2024, 7, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5837), "Turecka", "turcja", null, "Atatürk Caddesi", 72, 132m, 0m, 0m, 0m, new DateTime(2024, 7, 17, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5836), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("c3a54a31-515b-4123-8ff9-560850728408"), new DateTime(2024, 7, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4843), "Nero", "grecja", null, "Leoforos Alexandras", 127, 93m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4842), "Brava", "hiszpania", null, "Gran Vía", "Bus" },
                    { new Guid("c55b9ed5-2eaa-42a7-9826-d3f7f0a7f1c7"), new DateTime(2024, 6, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4562), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 200, 72m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4561), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("c64b0a99-1023-42ce-9338-b216d82b0298"), new DateTime(2024, 7, 21, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4675), "Durres", "albania", null, "Rruga Abdyl Frasheri", 200, 105m, 0m, 0m, 0m, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4675), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("c67ac350-5b3f-4d73-8f85-a1e71eecc4d3"), new DateTime(2024, 8, 13, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5633), "Luz", "hiszpania", null, "Calle Mayor", 114, 223m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5632), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("c6983f92-ae2c-4f4d-9a74-f553533b5292"), new DateTime(2024, 8, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4120), "Heraklion", "grecja", null, "Plateia Syntagmatos", 50, 281m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4119), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("c784bb4f-3178-492f-881c-abec365b0f44"), new DateTime(2024, 8, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5628), "Marmaris", "turcja", null, "Bağdat Caddesi", 77, 123m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5627), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("c78a9287-1a40-4928-9bad-16c61820c53f"), new DateTime(2024, 6, 6, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5391), "Kalabria", "wlochy", null, "Via Veneto", 191, 195m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5390), "Brava", "hiszpania", null, "Gran Vía", "Plane" },
                    { new Guid("c7c34803-4cf6-4fd9-af3b-b5fd9e6b71c5"), new DateTime(2024, 7, 31, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5644), "Riwiera", "chorwacja", null, "Kapucinska ulica", 163, 274m, 0m, 0m, 0m, new DateTime(2024, 7, 31, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5644), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("c7c8200b-0d3f-4d03-b7da-2f15f2cf89de"), new DateTime(2024, 5, 30, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4799), "Turecka", "turcja", null, "Atatürk Caddesi", 195, 250m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4799), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("c7dfac9c-2c46-4ebb-9078-7c0ee66c820c"), new DateTime(2024, 7, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5943), "Peloponez", "grecja", null, "Leoforos Alexandras", 198, 88m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5942), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("c7f7110e-eeec-46ae-b7f3-80f59c3d9d94"), new DateTime(2024, 8, 20, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4788), "Vlora", "albania", null, "Rruga e Kavajes", 164, 123m, 0m, 0m, 0m, new DateTime(2024, 8, 19, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4787), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("c8ac05ab-732c-499a-876e-ca9753af0cb8"), new DateTime(2024, 8, 16, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6086), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 65, 270m, 0m, 0m, 0m, new DateTime(2024, 8, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6085), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("c8b8580b-bbbc-4543-8704-d95c3b262566"), new DateTime(2024, 6, 30, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(4709), "Sheikh", "egipt", null, "Sharia Salah Salem", 138, 203m, 0m, 0m, 0m, new DateTime(2024, 6, 30, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4708), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("c8db4bcb-9c47-40d5-97c7-a2cd21ef80a3"), new DateTime(2024, 8, 6, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5833), "Durres", "albania", null, "Rruga Abdyl Frasheri", 187, 104m, 0m, 0m, 0m, new DateTime(2024, 8, 6, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5832), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("c94c93c2-be01-457a-9e65-94bfa1f6f8b2"), new DateTime(2024, 8, 26, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6381), "Almeria", "hiszpania", null, "Paseo del Prado", 117, 67m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6380), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("c9a050fc-e5f1-468e-862a-7e38599b63a6"), new DateTime(2024, 7, 29, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6012), "Turecka", "turcja", null, "Atatürk Caddesi", 127, 289m, 0m, 0m, 0m, new DateTime(2024, 7, 29, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6011), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("c9b8d501-261b-41ae-a374-559952dac656"), new DateTime(2024, 6, 7, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6377), "Brava", "hiszpania", null, "Gran Vía", 66, 95m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6376), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Train" },
                    { new Guid("cacd6ffa-5662-4b4d-9a3e-3d3b72817d2d"), new DateTime(2024, 8, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5493), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 88, 87m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5492), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("cb3a338a-3934-4cbd-bfa0-e67aa7979fb4"), new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(3905), "Brava", "hiszpania", null, "Calle de Alcalá", 90, 90m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(3904), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("cb3d3a82-1d32-4374-b6ae-8a5cdf465c0e"), new DateTime(2024, 6, 2, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(6664), "Vlora", "albania", null, "Rruga e Kavajes", 51, 187m, 0m, 0m, 0m, new DateTime(2024, 6, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(6663), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("cb674683-6ab3-44d4-a467-2b3791308988"), new DateTime(2024, 7, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4931), "Peloponez", "grecja", null, "Leoforos Alexandras", 107, 183m, 0m, 0m, 0m, new DateTime(2024, 7, 8, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4930), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("cc650342-146d-44db-9487-a086445ce087"), new DateTime(2024, 7, 10, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6276), "Brava", "hiszpania", null, "Calle de Alcalá", 51, 180m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6275), "Brava", "hiszpania", null, "Gran Vía", "Plane" },
                    { new Guid("cc79c480-ede9-45d6-b5d8-37a9183d905a"), new DateTime(2024, 5, 31, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6162), "Durres", "albania", null, "Bulevardi Bajram Curri", 161, 107m, 0m, 0m, 0m, new DateTime(2024, 5, 31, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6161), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("ccc24266-f518-44ab-81be-71693b485bf5"), new DateTime(2024, 7, 14, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5596), "Turecka", "turcja", null, "Atatürk Caddesi", 149, 73m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5595), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("ccffc060-1940-4856-9cd5-8f1ba4681d08"), new DateTime(2024, 6, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(5925), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 197, 271m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5924), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("cd482a44-70f2-4453-9dfd-767a3ddc5e62"), new DateTime(2024, 8, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5507), "Heraklion", "grecja", null, "Plateia Syntagmatos", 72, 244m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5506), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("cd618957-c67d-4a16-8387-b3d107d7ef22"), new DateTime(2024, 8, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4731), "Brava", "hiszpania", null, "Gran Vía", 172, 175m, 0m, 0m, 0m, new DateTime(2024, 8, 3, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4730), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("cd7d2fe4-3cbb-4b77-ac54-e25ee2762afd"), new DateTime(2024, 7, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(3896), "Riwiera", "chorwacja", null, "Vukovarska ulica", 156, 62m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(3895), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("cd8c6f7d-9dc2-4b85-a11b-5741b17a9e3c"), new DateTime(2024, 7, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5036), "Durres", "albania", null, "Rruga Abdyl Frasheri", 140, 51m, 0m, 0m, 0m, new DateTime(2024, 7, 25, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5035), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("ce2f3fa9-b5b0-42a9-9736-6d5b2e760203"), new DateTime(2024, 7, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4141), "Alam", "egipt", null, "Sharia Tahrir", 91, 130m, 0m, 0m, 0m, new DateTime(2024, 7, 20, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4140), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("ce6040b2-5ff9-4b10-abed-9c49cfa9709e"), new DateTime(2024, 6, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6489), "Turecka", "turcja", null, "Bağdat Caddesi", 148, 97m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(6488), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("cebb749d-19e9-45c4-b8d5-60a74717127f"), new DateTime(2024, 8, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6660), "Turecka", "turcja", null, "Atatürk Caddesi", 132, 100m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6659), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("d03cfd7e-4a64-4295-b602-b79d3dd0df0d"), new DateTime(2024, 8, 25, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6827), "Alam", "egipt", null, "Sharia Ramsis", 164, 213m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6826), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("d083e741-34b2-4298-907c-0bedf2b3f088"), new DateTime(2024, 6, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5283), "Brava", "hiszpania", null, "Calle Mayor", 171, 242m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5283), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("d171cb25-dd3a-40b9-a3a1-092964d6f450"), new DateTime(2024, 8, 10, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5126), "Riwiera", "chorwacja", null, "Vukovarska ulica", 69, 291m, 0m, 0m, 0m, new DateTime(2024, 8, 9, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(5125), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("d3098e0a-2204-4cd6-92e1-35562c333698"), new DateTime(2024, 8, 13, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6349), "Alam", "egipt", null, "Sharia Tahrir", 190, 182m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(6349), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("d351b322-9702-486c-a785-9c72330cb1b8"), new DateTime(2024, 5, 30, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4218), "Alam", "egipt", null, "Sharia Tahrir", 60, 126m, 0m, 0m, 0m, new DateTime(2024, 5, 30, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4217), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("d3a1ebe8-03dd-4c2c-9d53-b18b099fbf95"), new DateTime(2024, 8, 22, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6888), "Turecka", "turcja", null, "Atatürk Caddesi", 114, 129m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6887), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("d42549ac-76bd-4675-882a-eaa7d5635130"), new DateTime(2024, 7, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4095), "Turecka", "turcja", null, "Atatürk Caddesi", 84, 166m, 0m, 0m, 0m, new DateTime(2024, 7, 13, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4094), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("d46fe497-725e-4139-96df-1474c24c5a86"), new DateTime(2024, 6, 6, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(6107), "Brava", "hiszpania", null, "Gran Vía", 190, 124m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(6106), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Bus" },
                    { new Guid("d4d5fbf2-1147-4b75-8d22-62e44af3f597"), new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4927), "Durres", "albania", null, "Bulevardi Bajram Curri", 189, 113m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4926), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("d5e7d9ef-48b3-4dcc-b89f-77f883bd1bd8"), new DateTime(2024, 8, 23, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6333), "Turecka", "turcja", null, "Halaskargazi Caddesi", 77, 240m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6332), "Nero", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("d607f9e8-779a-4d4a-8941-34ae0f33fa26"), new DateTime(2024, 8, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5061), "Sheikh", "egipt", null, "Sharia Ramsis", 164, 275m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5060), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("d8cd410e-7028-4416-83cb-e3ec346534e0"), new DateTime(2024, 7, 29, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4767), "Kalabria", "wlochy", null, "Via Nazionale", 161, 101m, 0m, 0m, 0m, new DateTime(2024, 7, 29, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(4766), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("d8ce63b2-a2d3-4f9d-847c-cb34b31671f0"), new DateTime(2024, 8, 11, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6736), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 156, 217m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6735), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("d912179f-44f9-4c7e-9d68-ffae39162da9"), new DateTime(2024, 8, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5921), "Vlora", "albania", null, "Rruga e Kavajes", 180, 99m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5920), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("d9306861-f1c7-4fbb-ae59-3518673c8606"), new DateTime(2024, 8, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6195), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 127, 279m, 0m, 0m, 0m, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6194), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("da94ac15-fca4-4c25-ad0c-ace540228c26"), new DateTime(2024, 6, 17, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5802), "Riwiera", "chorwacja", null, "Kapucinska ulica", 95, 125m, 0m, 0m, 0m, new DateTime(2024, 6, 17, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5801), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("db83fad0-6d1c-4d59-aa69-479d6049ce22"), new DateTime(2024, 6, 14, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4671), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 80, 297m, 0m, 0m, 0m, new DateTime(2024, 6, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4670), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("dcc05505-a973-48df-a858-8570259e80d4"), new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4944), "Riwiera", "chorwacja", null, "Vukovarska ulica", 69, 100m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4943), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("dd6532a8-7258-46a9-a528-b702a8194b20"), new DateTime(2024, 8, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5078), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 116, 254m, 0m, 0m, 0m, new DateTime(2024, 8, 7, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5077), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("dd98b2aa-612e-40fa-9bb7-fc17d291d1bb"), new DateTime(2024, 6, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4959), "Sheikh", "egipt", null, "Sharia Salah Salem", 166, 256m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4958), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("dda6b8d0-b803-4d19-bb6f-0fb0384d0b90"), new DateTime(2024, 6, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4890), "Sheikh", "egipt", null, "Sharia Tahrir", 57, 151m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4889), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("dde83e77-ba5f-4abf-a0d6-5c56a46eb46b"), new DateTime(2024, 6, 26, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(5744), "Sheikh", "egipt", null, "Sharia Tahrir", 183, 83m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5743), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("de04bce4-6e06-414d-8cd9-5028782e6b48"), new DateTime(2024, 6, 14, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5640), "Vlora", "albania", null, "Rruga e Kavajes", 57, 75m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5640), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("de0bcfdc-60ac-4b3e-97e7-d75d44452f0e"), new DateTime(2024, 6, 15, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4267), "Vlora", "albania", null, "Rruga e Kavajes", 185, 218m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4266), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("de18c9b7-bd4e-40de-87b2-d61dad7dea25"), new DateTime(2024, 6, 22, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4112), "Turecka", "turcja", null, "Atatürk Caddesi", 129, 239m, 0m, 0m, 0m, new DateTime(2024, 6, 22, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4111), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("dee7e8f3-f47c-4a90-a7f1-49d207455e04"), new DateTime(2024, 8, 14, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4612), "Sheikh", "egipt", null, "Sharia Salah Salem", 170, 183m, 0m, 0m, 0m, new DateTime(2024, 8, 14, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4611), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("df8429a4-0292-480c-90d0-f676d02cfab4"), new DateTime(2024, 8, 26, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4687), "Vlora", "albania", null, "Rruga e Kavajes", 59, 280m, 0m, 0m, 0m, new DateTime(2024, 8, 25, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4686), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("dfd5b284-0fe9-4e94-becb-85c6d958630e"), new DateTime(2024, 7, 5, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5255), "Kalabria", "wlochy", null, "Via Veneto", 140, 236m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5254), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("dfe48284-41db-47de-a23e-7aab217899c7"), new DateTime(2024, 6, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4964), "Durres", "albania", null, "Rruga e Dibres", 172, 77m, 0m, 0m, 0m, new DateTime(2024, 6, 13, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4963), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("e0e4001f-c039-468d-a940-51c3aeaf4f3b"), new DateTime(2024, 7, 9, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4050), "Kalabria", "wlochy", null, "Via Veneto", 178, 180m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4050), "Almeria", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("e1303af7-1f08-40be-8123-f5d76da90dec"), new DateTime(2024, 8, 16, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4666), "Kalabria", "wlochy", null, "Via Veneto", 97, 90m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4666), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("e145f700-2cc4-41fb-9136-6c37569e495e"), new DateTime(2024, 6, 29, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(6533), "Turecka", "turcja", null, "Halaskargazi Caddesi", 80, 203m, 0m, 0m, 0m, new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6532), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("e2832c98-56c2-491e-be8c-49e8bcc9c047"), new DateTime(2024, 8, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5954), "Alam", "egipt", null, "Sharia Tahrir", 87, 158m, 0m, 0m, 0m, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5954), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("e29be1a1-71b1-471e-af30-f319dcb191fa"), new DateTime(2024, 7, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5489), "Nero", "grecja", null, "Leoforos Alexandras", 136, 286m, 0m, 0m, 0m, new DateTime(2024, 7, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5488), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("e32bf3a9-d823-4cdf-9fab-57b01a152031"), new DateTime(2024, 8, 23, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4099), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 154, 118m, 0m, 0m, 0m, new DateTime(2024, 8, 22, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4099), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("e3ba87b4-afe9-40eb-9d46-264b99dd3b0a"), new DateTime(2024, 7, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6325), "Almeria", "hiszpania", null, "Paseo del Prado", 74, 286m, 0m, 0m, 0m, new DateTime(2024, 7, 10, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6324), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("e4b22703-de13-425c-8bc6-b2acebe77c8b"), new DateTime(2024, 6, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5242), "Turecka", "turcja", null, "Atatürk Caddesi", 158, 103m, 0m, 0m, 0m, new DateTime(2024, 6, 20, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5241), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("e665edec-eda7-4653-b57b-768122ca19a7"), new DateTime(2024, 7, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6000), "Riwiera", "chorwacja", null, "Maksimirska ulica", 166, 234m, 0m, 0m, 0m, new DateTime(2024, 7, 9, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5999), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("e6e89e63-d826-408c-aed3-467a4f42656d"), new DateTime(2024, 6, 18, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5436), "Peloponez", "grecja", null, "Leoforos Alexandras", 142, 190m, 0m, 0m, 0m, new DateTime(2024, 6, 18, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(5435), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("e78c1cd4-c503-4ca0-8fa8-be94ceb4db49"), new DateTime(2024, 8, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5656), "Marmaris", "turcja", null, "Bağdat Caddesi", 196, 109m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5656), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Plane" },
                    { new Guid("e87ef2bf-8795-472a-9190-dd58885e2f95"), new DateTime(2024, 6, 29, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5861), "Durres", "albania", null, "Rruga e Dibres", 113, 124m, 0m, 0m, 0m, new DateTime(2024, 6, 29, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5860), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("e88dcfe7-dc4c-49a8-b110-93683aceea5e"), new DateTime(2024, 7, 5, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(6341), "Alam", "egipt", null, "Sharia Tahrir", 104, 83m, 0m, 0m, 0m, new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6340), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("e8b2f9ea-83e0-4556-855a-2662c4052d19"), new DateTime(2024, 7, 18, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(5027), "Alam", "egipt", null, "Sharia Ramsis", 59, 246m, 0m, 0m, 0m, new DateTime(2024, 7, 18, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5026), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("e92ca304-f351-405b-9eb5-02a620593754"), new DateTime(2024, 6, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5219), "Riwiera", "chorwacja", null, "Kapucinska ulica", 113, 159m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(5218), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("e9de5440-d446-4e2b-b7a2-98b951a2c787"), new DateTime(2024, 6, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5821), "Durres", "albania", null, "Rruga e Dibres", 177, 191m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5821), "Vlora", "albania", null, "Rruga 28 Nentori", "Plane" },
                    { new Guid("ea57c8e7-31d5-44a4-acf8-260b0dfa59f1"), new DateTime(2024, 8, 17, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5576), "Kalabria", "wlochy", null, "Via del Corso", 108, 204m, 0m, 0m, 0m, new DateTime(2024, 8, 17, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5575), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("ea6b2620-c8b3-45af-b1a8-32396bde1aca"), new DateTime(2024, 6, 27, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5773), "Durres", "albania", null, "Rruga e Dibres", 198, 132m, 0m, 0m, 0m, new DateTime(2024, 6, 27, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(5772), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("ea6d419f-5bc8-449b-8d53-102fdee0907f"), new DateTime(2024, 6, 3, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(4128), "Alam", "egipt", null, "Sharia Tahrir", 101, 127m, 0m, 0m, 0m, new DateTime(2024, 6, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4127), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Bus" },
                    { new Guid("eb008dbd-1ffb-497b-abfa-5cd6ccde1179"), new DateTime(2024, 6, 26, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5765), "Riwiera", "chorwacja", null, "Vukovarska ulica", 178, 262m, 0m, 0m, 0m, new DateTime(2024, 6, 26, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(5764), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("eb3e538e-5992-441d-898b-2baa4ef6e340"), new DateTime(2024, 8, 26, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(3954), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 187, 107m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(3954), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("ebb24283-ff00-48fe-bf78-c5b7c86c7a41"), new DateTime(2024, 8, 13, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4861), "Durres", "albania", null, "Bulevardi Bajram Curri", 105, 123m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(4860), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("ebee5a90-9f16-4eac-a301-41d95223e9e3"), new DateTime(2024, 7, 24, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(6640), "Sheikh", "egipt", null, "Sharia Salah Salem", 103, 54m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(6639), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("ec64b49c-2040-470f-9916-cf33ac200f6b"), new DateTime(2024, 7, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6292), "Riwiera", "chorwacja", null, "Maksimirska ulica", 84, 132m, 0m, 0m, 0m, new DateTime(2024, 7, 18, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(6291), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("ece97917-e0e6-4afb-a1b3-4d79fb72ad8f"), new DateTime(2024, 7, 1, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6124), "Turecka", "turcja", null, "Atatürk Caddesi", 120, 290m, 0m, 0m, 0m, new DateTime(2024, 6, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(6123), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("ed796677-9eca-4417-977f-e97a2506c55e"), new DateTime(2024, 8, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4697), "Turecka", "turcja", null, "Atatürk Caddesi", 162, 276m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4696), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("edaec21d-4e9c-4e54-8ac8-7111a8695261"), new DateTime(2024, 7, 30, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6473), "Durres", "albania", null, "Rruga Abdyl Frasheri", 200, 108m, 0m, 0m, 0m, new DateTime(2024, 7, 30, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6472), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("edc4458d-6901-4231-a786-aae99173eb13"), new DateTime(2024, 8, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(6715), "Durres", "albania", null, "Bulevardi Bajram Curri", 174, 97m, 0m, 0m, 0m, new DateTime(2024, 8, 9, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6714), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Bus" },
                    { new Guid("ef3bbc81-56e5-4e37-80f9-3ed750e0cea6"), new DateTime(2024, 8, 12, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(5688), "Peloponez", "grecja", null, "Leoforos Alexandras", 171, 85m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(5687), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("ef8f8913-6ee7-4718-841a-2a4f2212a7be"), new DateTime(2024, 6, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5143), "Durres", "albania", null, "Rruga e Dibres", 159, 123m, 0m, 0m, 0m, new DateTime(2024, 6, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5142), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("f02e32f9-b70e-4593-9d7d-f4ff855845c9"), new DateTime(2024, 7, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(6170), "Alam", "egipt", null, "Sharia Tahrir", 134, 158m, 0m, 0m, 0m, new DateTime(2024, 7, 14, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6169), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("f1b0c9b0-98b2-4ad6-8ac4-f351e8862a77"), new DateTime(2024, 8, 3, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4544), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 83, 134m, 0m, 0m, 0m, new DateTime(2024, 8, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(4544), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("f1ea08ad-0cad-4bfe-b8ee-622d8f37de7e"), new DateTime(2024, 6, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(6688), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 109, 65m, 0m, 0m, 0m, new DateTime(2024, 6, 8, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(6687), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("f1f387a7-956a-4d3e-9f3c-e0a24bb3f291"), new DateTime(2024, 7, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5134), "Durres", "albania", null, "Bulevardi Bajram Curri", 157, 256m, 0m, 0m, 0m, new DateTime(2024, 7, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(5133), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("f22cddec-dc16-4dc5-8fa0-0eacfb52eb9b"), new DateTime(2024, 6, 9, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(5400), "Almeria", "hiszpania", null, "Paseo del Prado", 65, 119m, 0m, 0m, 0m, new DateTime(2024, 6, 9, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5399), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("f23e0dc4-14d5-4282-becc-e19a35c162f7"), new DateTime(2024, 6, 8, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(5777), "Durres", "albania", null, "Bulevardi Bajram Curri", 65, 192m, 0m, 0m, 0m, new DateTime(2024, 6, 8, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5776), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("f2da215c-faa7-4b5e-ad3e-d84133b93413"), new DateTime(2024, 6, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(4540), "Sheikh", "egipt", null, "Sharia Salah Salem", 95, 176m, 0m, 0m, 0m, new DateTime(2024, 6, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4539), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("f3b89f8f-7e79-434b-b253-82a56c96651a"), new DateTime(2024, 7, 23, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5844), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 194, 56m, 0m, 0m, 0m, new DateTime(2024, 7, 23, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5843), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("f3f07411-8464-4d23-9af2-278f66cbd041"), new DateTime(2024, 6, 13, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(6635), "Riwiera", "chorwacja", null, "Maksimirska ulica", 50, 261m, 0m, 0m, 0m, new DateTime(2024, 6, 13, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(6634), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("f5113209-a6eb-4e5a-a4a9-a1cee59ae283"), new DateTime(2024, 6, 5, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(4856), "Durres", "albania", null, "Rruga e Dibres", 142, 275m, 0m, 0m, 0m, new DateTime(2024, 6, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(4856), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("f5447225-f6c0-4b43-9a9b-19e6466942c0"), new DateTime(2024, 7, 28, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(5829), "Kalabria", "wlochy", null, "Via Veneto", 149, 197m, 0m, 0m, 0m, new DateTime(2024, 7, 27, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(5828), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("f58495f7-84e5-4c9d-aba3-4eac6a0bdedf"), new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5502), "Durres", "albania", null, "Bulevardi Bajram Curri", 145, 185m, 0m, 0m, 0m, new DateTime(2024, 6, 11, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(5501), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("f6df0c71-ca05-4f72-90da-9cc4a8306d95"), new DateTime(2024, 8, 2, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(4584), "Kalabria", "wlochy", null, "Via del Corso", 115, 231m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(4583), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("f726c641-2e58-451d-a857-bcb2a52f8151"), new DateTime(2024, 8, 23, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(4063), "Turecka", "turcja", null, "Bağdat Caddesi", 187, 228m, 0m, 0m, 0m, new DateTime(2024, 8, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(4063), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("f80a305c-ece0-43d7-9df7-776328ec83ab"), new DateTime(2024, 6, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6854), "Vlora", "albania", null, "Rruga e Kavajes", 101, 59m, 0m, 0m, 0m, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(6854), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("f85de725-9d41-4abe-8d9b-c57ae4fd620b"), new DateTime(2024, 7, 31, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(5329), "Marmaris", "turcja", null, "Bağdat Caddesi", 126, 219m, 0m, 0m, 0m, new DateTime(2024, 7, 30, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5328), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("f9b1c801-163b-4b30-b4ff-7acb851a26fe"), new DateTime(2024, 6, 2, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(4205), "Brava", "hiszpania", null, "Calle Mayor", 98, 51m, 0m, 0m, 0m, new DateTime(2024, 6, 1, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(4204), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("f9e05225-a9d7-402a-b4b2-efb58eb5a7f9"), new DateTime(2024, 7, 1, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(4751), "Alam", "egipt", null, "Sharia Tahrir", 172, 242m, 0m, 0m, 0m, new DateTime(2024, 7, 1, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4750), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("fa73bd39-e58c-4de7-b0af-5cc7594a483c"), new DateTime(2024, 8, 26, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(3926), "Riwiera", "chorwacja", null, "Vukovarska ulica", 155, 118m, 0m, 0m, 0m, new DateTime(2024, 8, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(3925), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("fac1e180-f429-46eb-ac39-3f2d92bb4233"), new DateTime(2024, 8, 13, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(6783), "Peloponez", "grecja", null, "Leoforos Alexandras", 121, 98m, 0m, 0m, 0m, new DateTime(2024, 8, 13, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(6782), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("faccfd72-0154-4513-9e2d-2dc8aeee7691"), new DateTime(2024, 7, 28, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5813), "Riwiera", "chorwacja", null, "Maksimirska ulica", 67, 117m, 0m, 0m, 0m, new DateTime(2024, 7, 28, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5812), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("fbc62ce7-d843-48aa-babf-7591fe9f3848"), new DateTime(2024, 6, 16, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(4059), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 181, 79m, 0m, 0m, 0m, new DateTime(2024, 6, 15, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(4058), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("fc688d20-b856-49d0-b83a-01d63d9cb3bf"), new DateTime(2024, 8, 21, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(5667), "Brava", "hiszpania", null, "Paseo del Prado", 192, 166m, 0m, 0m, 0m, new DateTime(2024, 8, 21, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(5666), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("fcc7ad48-ea43-4914-b789-7833b7177b71"), new DateTime(2024, 8, 2, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(6447), "Brava", "hiszpania", null, "Calle de Alcalá", 174, 53m, 0m, 0m, 0m, new DateTime(2024, 8, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(6446), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("fd669e0c-d3f1-4b06-b696-ef92dfd005b0"), new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5374), "Vlora", "albania", null, "Rruga e Kavajes", 181, 238m, 0m, 0m, 0m, new DateTime(2024, 8, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(5373), "Durres", "albania", null, "Bulevardi Bajram Curri", "Bus" },
                    { new Guid("fd7f0286-b5f5-441e-bafe-406adb69e3b9"), new DateTime(2024, 7, 2, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(4771), "Maresme", "hiszpania", null, "Paseo del Prado", 61, 204m, 0m, 0m, 0m, new DateTime(2024, 7, 2, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(4770), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("fdfd0948-48e7-4b22-b116-b4d94f819c1e"), new DateTime(2024, 6, 6, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(5789), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 184, 164m, 0m, 0m, 0m, new DateTime(2024, 6, 6, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(5789), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("fe15a7ec-c779-47a1-a65b-be305cae6aba"), new DateTime(2024, 6, 14, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(4874), "Vlora", "albania", null, "Rruga 28 Nentori", 180, 101m, 0m, 0m, 0m, new DateTime(2024, 6, 14, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(4872), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("fe5f4065-e306-43fc-b3f6-c9de26f223c2"), new DateTime(2024, 8, 13, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(5680), "Durres", "albania", null, "Rruga Abdyl Frasheri", 136, 286m, 0m, 0m, 0m, new DateTime(2024, 8, 12, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(5679), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" }
                });

            migrationBuilder.InsertData(
                table: "QueryTransportOptions",
                columns: new[] { "Id", "Discount", "End", "FromCity", "FromCountry", "FromShowName", "FromStreet", "PriceAdult", "PriceUnder10", "PriceUnder18", "PriceUnder3", "Seats", "Start", "ToCity", "ToCountry", "ToShowName", "ToStreet", "Type" },
                values: new object[,]
                {
                    { new Guid("00913ef2-2c83-4abc-a098-dda64f4decf4"), null, new DateTime(2024, 8, 6, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7638), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 264m, 0m, 0m, 0m, 107, new DateTime(2024, 8, 5, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7638), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("01840b51-7c74-4662-9017-cbdfb156dccc"), null, new DateTime(2024, 7, 7, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7613), "Vlora", "albania", null, "Rruga e Kavajes", 160m, 0m, 0m, 0m, 126, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7612), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("029bf101-6448-42e9-b523-deb9b5a37a15"), null, new DateTime(2024, 7, 20, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7673), "Turecka", "turcja", null, "Atatürk Caddesi", 184m, 0m, 0m, 0m, 157, new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7672), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("03499c64-12b2-4855-92af-6c5a6b93acf9"), null, new DateTime(2024, 8, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9271), "Turecka", "turcja", null, "Atatürk Caddesi", 187m, 0m, 0m, 0m, 94, new DateTime(2024, 8, 19, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9271), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("036d5b62-74b8-4e0d-86ba-56e2fbe6dd18"), null, new DateTime(2024, 8, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8750), "Durres", "albania", null, "Rruga e Dibres", 268m, 0m, 0m, 0m, 168, new DateTime(2024, 8, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8750), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("037a7829-26ec-4fa1-8f4d-2a930d9ac6fe"), null, new DateTime(2024, 8, 18, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9122), "Turecka", "turcja", null, "Atatürk Caddesi", 79m, 0m, 0m, 0m, 167, new DateTime(2024, 8, 18, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9121), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("049eb95c-99c5-44b5-b7dd-d57c46862e90"), null, new DateTime(2024, 6, 13, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9632), "Riwiera", "chorwacja", null, "Maksimirska ulica", 261m, 0m, 0m, 0m, 50, new DateTime(2024, 6, 13, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9631), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("04c0545e-b4c9-4684-b242-9986c70e967b"), null, new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8532), "Alam", "egipt", null, "Sharia Tahrir", 125m, 0m, 0m, 0m, 183, new DateTime(2024, 7, 4, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8531), "Peloponez", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("055b4b04-87f5-426a-96cc-0508eb8e464f"), null, new DateTime(2024, 7, 5, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8405), "Kalabria", "wlochy", null, "Via Veneto", 236m, 0m, 0m, 0m, 140, new DateTime(2024, 7, 5, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8404), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("05ccddf1-0d56-4ed7-bcbb-1a144e35b23b"), null, new DateTime(2024, 7, 23, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8926), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 56m, 0m, 0m, 0m, 194, new DateTime(2024, 7, 23, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8925), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("07fb1195-d580-45ca-a1ed-4b7f99c10fec"), null, new DateTime(2024, 7, 21, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8882), "Durres", "albania", null, "Rruga e Dibres", 112m, 0m, 0m, 0m, 166, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8882), "Durres", "albania", null, "Bulevardi Bajram Curri", "Bus" },
                    { new Guid("08a20038-e38d-4a1f-aee9-5423f826bc61"), null, new DateTime(2024, 8, 23, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9372), "Turecka", "turcja", null, "Halaskargazi Caddesi", 240m, 0m, 0m, 0m, 77, new DateTime(2024, 8, 23, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9371), "Nero", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("08b22b84-e4bc-4922-b0c0-d4308f517dee"), null, new DateTime(2024, 6, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9474), "Vlora", "albania", null, "Rruga e Kavajes", 282m, 0m, 0m, 0m, 66, new DateTime(2024, 6, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9473), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("08cb7968-70be-4984-84b0-448a1c9f51eb"), null, new DateTime(2024, 6, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7688), "Durres", "albania", null, "Rruga Abdyl Frasheri", 247m, 0m, 0m, 0m, 164, new DateTime(2024, 6, 12, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7687), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("08e2135c-412c-4567-90ff-3ce04649d80e"), null, new DateTime(2024, 6, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9140), "Kalabria", "wlochy", null, "Via Veneto", 131m, 0m, 0m, 0m, 160, new DateTime(2024, 6, 6, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9139), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("097802a2-db08-4c24-b51d-a9da3535eae8"), null, new DateTime(2024, 6, 29, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8944), "Durres", "albania", null, "Rruga e Dibres", 124m, 0m, 0m, 0m, 113, new DateTime(2024, 6, 29, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8943), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("09af8f61-e155-4522-9e35-fd768140dbbe"), null, new DateTime(2024, 7, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7618), "Almeria", "hiszpania", null, "Paseo del Prado", 136m, 0m, 0m, 0m, 97, new DateTime(2024, 7, 23, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7617), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("09d07c95-9372-464c-a803-4d5c9818b455"), null, new DateTime(2024, 7, 21, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7879), "Durres", "albania", null, "Rruga Abdyl Frasheri", 105m, 0m, 0m, 0m, 200, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7879), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("0a8a216c-494e-4049-ab2f-f0847665abd6"), null, new DateTime(2024, 6, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8458), "Brava", "hiszpania", null, "Calle Mayor", 94m, 0m, 0m, 0m, 104, new DateTime(2024, 6, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8457), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("0a9974a8-c01d-4808-a25d-5d7a5616c6ae"), null, new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8398), "Sheikh", "egipt", null, "Sharia Ramsis", 169m, 0m, 0m, 0m, 125, new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8397), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("0ba15b09-e778-49c0-9f7d-d8549e63077d"), null, new DateTime(2024, 6, 28, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8207), "Kalabria", "wlochy", null, "Via Nazionale", 88m, 0m, 0m, 0m, 151, new DateTime(2024, 6, 27, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8206), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("0bad4f4f-ba13-4ce7-a8c9-32c40f669376"), null, new DateTime(2024, 7, 22, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9665), "Heraklion", "grecja", null, "Plateia Syntagmatos", 125m, 0m, 0m, 0m, 84, new DateTime(2024, 7, 22, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9664), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("0bb49e15-195c-4e9b-bfba-2ef3a9a3f103"), null, new DateTime(2024, 7, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8056), "Sheikh", "egipt", null, "Sharia Tahrir", 254m, 0m, 0m, 0m, 182, new DateTime(2024, 7, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8055), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("0cb32b35-08cd-4faf-8304-143249e9a9ee"), null, new DateTime(2024, 6, 10, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8992), "Vlora", "albania", null, "Rruga e Kavajes", 92m, 0m, 0m, 0m, 67, new DateTime(2024, 6, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8992), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("0d1a0b6e-2cbc-4fe5-b8ef-6079fba588b6"), null, new DateTime(2024, 7, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9330), "Almeria", "hiszpania", null, "Paseo del Prado", 286m, 0m, 0m, 0m, 74, new DateTime(2024, 7, 10, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9329), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("0d8790ac-f74a-439c-a62d-51206a39787d"), null, new DateTime(2024, 5, 30, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7602), "Alam", "egipt", null, "Sharia Tahrir", 126m, 0m, 0m, 0m, 60, new DateTime(2024, 5, 30, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7601), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("0d9acfa9-1d5f-48c1-a297-11fa24018cbb"), null, new DateTime(2024, 7, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8102), "Peloponez", "grecja", null, "Leoforos Alexandras", 183m, 0m, 0m, 0m, 107, new DateTime(2024, 7, 8, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8102), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("0db44a8c-87bf-42a7-ac11-d29a3b57fde8"), null, new DateTime(2024, 8, 14, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7852), "Sheikh", "egipt", null, "Sharia Salah Salem", 183m, 0m, 0m, 0m, 170, new DateTime(2024, 8, 14, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7851), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("0dc40dc4-dfaf-4d86-8e78-a0e8484e5a9f"), null, new DateTime(2024, 7, 25, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8378), "Sheikh", "egipt", null, "Sharia Tahrir", 129m, 0m, 0m, 0m, 144, new DateTime(2024, 7, 25, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8377), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("0dc83d7c-3bde-48c2-a83b-acfcbf7b791d"), null, new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8048), "Vlora", "albania", null, "Rruga 28 Nentori", 83m, 0m, 0m, 0m, 194, new DateTime(2024, 6, 12, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8048), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("0de51b90-0cb4-437d-9f24-9ba0df587f2e"), null, new DateTime(2024, 7, 10, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9289), "Brava", "hiszpania", null, "Calle de Alcalá", 180m, 0m, 0m, 0m, 51, new DateTime(2024, 7, 10, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9288), "Brava", "hiszpania", null, "Gran Vía", "Plane" },
                    { new Guid("0de51cd2-68b5-4135-a165-a15e48839521"), null, new DateTime(2024, 6, 25, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7467), "Peloponez", "grecja", null, "Leoforos Alexandras", 193m, 0m, 0m, 0m, 79, new DateTime(2024, 6, 24, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7466), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("0e03eade-56d7-4be2-9793-62bda3acce47"), null, new DateTime(2024, 6, 6, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9133), "Brava", "hiszpania", null, "Gran Vía", 124m, 0m, 0m, 0m, 190, new DateTime(2024, 6, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9132), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Bus" },
                    { new Guid("0e6afff3-891c-4aae-bebd-73cb8a476348"), null, new DateTime(2024, 8, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8242), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 254m, 0m, 0m, 0m, 116, new DateTime(2024, 8, 7, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8241), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("0ea3d350-8409-4de8-a5b3-ed9d310cdca2"), null, new DateTime(2024, 7, 8, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9613), "Kalabria", "wlochy", null, "Via Veneto", 284m, 0m, 0m, 0m, 161, new DateTime(2024, 7, 7, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9613), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("0fba0ba8-ef6a-4cb4-be14-277f63d98787"), null, new DateTime(2024, 8, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8488), "Nero", "grecja", null, "Leoforos Alexandras", 135m, 0m, 0m, 0m, 129, new DateTime(2024, 8, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8487), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("101ed09a-8433-4101-9cb1-2509cb73194f"), null, new DateTime(2024, 7, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8887), "Durres", "albania", null, "Rruga Abdyl Frasheri", 233m, 0m, 0m, 0m, 55, new DateTime(2024, 7, 18, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8886), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("111c5636-384e-40ba-ad1e-8d92d7344ac8"), null, new DateTime(2024, 7, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9198), "Sheikh", "egipt", null, "Sharia Tahrir", 129m, 0m, 0m, 0m, 192, new DateTime(2024, 7, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9197), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("1126c193-ac7c-46ee-9798-38dd6bfa8bf1"), null, new DateTime(2024, 8, 22, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9194), "Vlora", "albania", null, "Rruga e Kavajes", 208m, 0m, 0m, 0m, 134, new DateTime(2024, 8, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9193), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("1159f1d7-ec25-4ab3-b8b0-11cad45ccf04"), null, new DateTime(2024, 6, 3, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9137), "Sheikh", "egipt", null, "Sharia Tahrir", 146m, 0m, 0m, 0m, 164, new DateTime(2024, 6, 2, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9136), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("11ebcafd-200d-4ee6-839f-aabf42677a8a"), null, new DateTime(2024, 8, 13, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9602), "Vlora", "albania", null, "Rruga 28 Nentori", 92m, 0m, 0m, 0m, 65, new DateTime(2024, 8, 13, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9601), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("130900f7-d0b4-4f32-aeaa-5cd2d004bea3"), null, new DateTime(2024, 7, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9071), "Riwiera", "chorwacja", null, "Maksimirska ulica", 234m, 0m, 0m, 0m, 166, new DateTime(2024, 7, 9, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9070), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("13cf04d6-2d45-48f3-9756-bbc68d7f2a83"), null, new DateTime(2024, 7, 11, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9718), "Durres", "albania", null, "Rruga e Dibres", 91m, 0m, 0m, 0m, 159, new DateTime(2024, 7, 10, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9718), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("13e9d67e-7e52-4e8f-abff-7cdf9468b4ca"), null, new DateTime(2024, 7, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9108), "Luz", "hiszpania", null, "Calle Mayor", 116m, 0m, 0m, 0m, 170, new DateTime(2024, 7, 12, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9107), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("1501e254-8c95-4f59-9473-34e793acd8d9"), null, new DateTime(2024, 6, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9516), "Vlora", "albania", null, "Rruga e Kavajes", 152m, 0m, 0m, 0m, 187, new DateTime(2024, 6, 12, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9515), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("15bc8ada-753c-4afb-aa4f-5ba40d67d34b"), null, new DateTime(2024, 7, 31, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9588), "Alam", "egipt", null, "Sharia Ramsis", 91m, 0m, 0m, 0m, 50, new DateTime(2024, 7, 30, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9587), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("1601212d-f692-4a1b-9801-dc93ff073c30"), null, new DateTime(2024, 6, 23, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9439), "Peloponez", "grecja", null, "Leoforos Alexandras", 221m, 0m, 0m, 0m, 89, new DateTime(2024, 6, 22, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9438), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("164d7160-4d45-4c20-8282-053bf3fcd9a5"), null, new DateTime(2024, 8, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7508), "Heraklion", "grecja", null, "Plateia Syntagmatos", 281m, 0m, 0m, 0m, 50, new DateTime(2024, 8, 2, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7507), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("16eb9521-0870-4679-bd39-33235d4f823e"), null, new DateTime(2024, 8, 7, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7598), "Sheikh", "egipt", null, "Sharia Ramsis", 59m, 0m, 0m, 0m, 184, new DateTime(2024, 8, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7597), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("175e676f-1c76-44fc-8bd6-93c8da0a97dd"), null, new DateTime(2024, 8, 16, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8230), "Alam", "egipt", null, "Sharia Tahrir", 276m, 0m, 0m, 0m, 88, new DateTime(2024, 8, 16, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8229), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("182cc7d3-7baa-4738-8320-5ee422e0cf14"), null, new DateTime(2024, 6, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9494), "Turecka", "turcja", null, "Bağdat Caddesi", 97m, 0m, 0m, 0m, 148, new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9493), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("1844b963-cd47-403c-9bd9-9287711a5526"), null, new DateTime(2024, 6, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8125), "Sheikh", "egipt", null, "Sharia Salah Salem", 256m, 0m, 0m, 0m, 166, new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8124), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("1881c20a-3aab-4446-9012-956406cac5b1"), null, new DateTime(2024, 8, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9813), "Turecka", "turcja", null, "Atatürk Caddesi", 143m, 0m, 0m, 0m, 176, new DateTime(2024, 8, 17, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9812), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("18e9ae32-1ef1-41b0-9bc1-9d1f17991272"), null, new DateTime(2024, 6, 9, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8791), "Almeria", "hiszpania", null, "Paseo del Prado", 259m, 0m, 0m, 0m, 199, new DateTime(2024, 6, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8790), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("1a19a7e2-84cf-4eba-9add-326c66366838"), null, new DateTime(2024, 7, 4, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9580), "Turecka", "turcja", null, "Halaskargazi Caddesi", 266m, 0m, 0m, 0m, 194, new DateTime(2024, 7, 4, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9579), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("1a4ab2ff-3b87-4744-ad35-73f6a8acb5d0"), null, new DateTime(2024, 7, 26, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8521), "Almeria", "hiszpania", null, "Paseo del Prado", 187m, 0m, 0m, 0m, 140, new DateTime(2024, 7, 26, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8520), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("1a99a193-885d-49d5-a641-5296da9f946b"), null, new DateTime(2024, 6, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8462), "Riwiera", "chorwacja", null, "Maksimirska ulica", 222m, 0m, 0m, 0m, 138, new DateTime(2024, 6, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8461), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("1aaa5ea6-693d-4271-84f9-158b552ad917"), null, new DateTime(2024, 7, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9007), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 149m, 0m, 0m, 0m, 157, new DateTime(2024, 7, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9005), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("1b55179f-8da8-4ea7-aa29-e7384cfdd276"), null, new DateTime(2024, 8, 13, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8810), "Durres", "albania", null, "Rruga Abdyl Frasheri", 286m, 0m, 0m, 0m, 136, new DateTime(2024, 8, 12, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8809), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("1bea6fe5-6dd8-47d3-9080-bc082da112ba"), null, new DateTime(2024, 6, 15, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9809), "Brava", "hiszpania", null, "Calle Mayor", 287m, 0m, 0m, 0m, 155, new DateTime(2024, 6, 14, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9808), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("1c69bf11-3efb-4d64-9e6a-16a933e52c2d"), null, new DateTime(2024, 7, 1, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9512), "Peloponez", "grecja", null, "Leoforos Alexandras", 82m, 0m, 0m, 0m, 127, new DateTime(2024, 6, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9511), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("1d395622-7ad4-46a3-b328-2501049895ab"), null, new DateTime(2024, 6, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7751), "Sheikh", "egipt", null, "Sharia Salah Salem", 176m, 0m, 0m, 0m, 95, new DateTime(2024, 6, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7750), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("201218fc-40b1-4711-b533-872af3fcc050"), null, new DateTime(2024, 5, 31, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9275), "Kalabria", "wlochy", null, "Via Nazionale", 91m, 0m, 0m, 0m, 83, new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9274), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("2016640e-60c7-4ac2-85bb-0f9d82a6b4a5"), null, new DateTime(2024, 8, 17, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8871), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 160m, 0m, 0m, 0m, 67, new DateTime(2024, 8, 16, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8871), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("2055d0c3-6c11-441c-8519-89aae5b4a269"), null, new DateTime(2024, 7, 3, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9400), "Durres", "albania", null, "Rruga Abdyl Frasheri", 248m, 0m, 0m, 0m, 98, new DateTime(2024, 7, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9399), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("20794d3a-0279-45ac-80b1-5a0c2f5c986e"), null, new DateTime(2024, 8, 19, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9431), "Kalabria", "wlochy", null, "Via del Corso", 81m, 0m, 0m, 0m, 130, new DateTime(2024, 8, 19, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9430), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("21ca2080-a321-47ef-9496-a50b7fabd30f"), null, new DateTime(2024, 8, 11, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9715), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 217m, 0m, 0m, 0m, 156, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9714), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("2412642d-0518-4272-95b4-292bc3ce05d1"), null, new DateTime(2024, 8, 19, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7557), "Sheikh", "egipt", null, "Sharia Salah Salem", 213m, 0m, 0m, 0m, 102, new DateTime(2024, 8, 18, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7556), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("242819d0-02f5-41dc-8a4d-0e9305b95730"), null, new DateTime(2024, 7, 22, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9224), "Riwiera", "chorwacja", null, "Maksimirska ulica", 295m, 0m, 0m, 0m, 174, new DateTime(2024, 7, 22, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9224), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("2462ead6-d683-4be0-ae5c-4d6325182885"), null, new DateTime(2024, 8, 20, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8016), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 169m, 0m, 0m, 0m, 187, new DateTime(2024, 8, 20, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8015), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("2584c2ba-2436-415a-953f-6ab334c23c39"), null, new DateTime(2024, 8, 17, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8673), "Kalabria", "wlochy", null, "Via del Corso", 204m, 0m, 0m, 0m, 108, new DateTime(2024, 8, 17, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8672), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("26797068-5872-45b8-9284-424e1b4f90f4"), null, new DateTime(2024, 7, 21, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7475), "Kalabria", "wlochy", null, "Via del Corso", 60m, 0m, 0m, 0m, 107, new DateTime(2024, 7, 21, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7474), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("26b7f69c-e9a1-4216-ae65-8daf38e56cb5"), null, new DateTime(2024, 8, 15, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9253), "Riwiera", "chorwacja", null, "Vukovarska ulica", 140m, 0m, 0m, 0m, 69, new DateTime(2024, 8, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9252), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("26ea8baa-dd2e-4bce-87b6-774ddf30d8dc"), null, new DateTime(2024, 6, 6, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7532), "Vlora", "albania", null, "Rruga 28 Nentori", 101m, 0m, 0m, 0m, 68, new DateTime(2024, 6, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7531), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("27543b1a-a88a-43b8-a94c-9e191ce65e61"), null, new DateTime(2024, 7, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8401), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 158m, 0m, 0m, 0m, 57, new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8401), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("2807b1f0-4382-4af1-871f-d7fc8d9ed8b3"), null, new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7681), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 135m, 0m, 0m, 0m, 91, new DateTime(2024, 8, 1, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7680), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("28274d95-0a24-4f25-a6f2-17d9fe069df0"), null, new DateTime(2024, 8, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7497), "Turecka", "turcja", null, "Atatürk Caddesi", 135m, 0m, 0m, 0m, 146, new DateTime(2024, 8, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7497), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("297a6432-738a-4fa1-9e3e-09c66ebb9433"), null, new DateTime(2024, 7, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8937), "Durres", "albania", null, "Rruga e Dibres", 177m, 0m, 0m, 0m, 114, new DateTime(2024, 7, 26, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8936), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("2a149761-4b8b-44fa-80c7-7add60e67300"), null, new DateTime(2024, 8, 21, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8795), "Brava", "hiszpania", null, "Paseo del Prado", 166m, 0m, 0m, 0m, 192, new DateTime(2024, 8, 21, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8794), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("2a7a1028-1570-4921-bc2d-6744909b6ebd"), null, new DateTime(2024, 7, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9606), "Turecka", "turcja", null, "Atatürk Caddesi", 140m, 0m, 0m, 0m, 63, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9605), "Brava", "hiszpania", null, "Gran Vía", "Bus" },
                    { new Guid("2af11d07-f7c7-4303-ac14-d9c80a8b40fa"), null, new DateTime(2024, 7, 31, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8473), "Marmaris", "turcja", null, "Bağdat Caddesi", 219m, 0m, 0m, 0m, 126, new DateTime(2024, 7, 30, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8473), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("2b519b99-95ac-42b0-9c6c-de994de78083"), null, new DateTime(2024, 6, 30, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7908), "Sheikh", "egipt", null, "Sharia Salah Salem", 203m, 0m, 0m, 0m, 138, new DateTime(2024, 6, 30, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7907), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("2c26c73d-38e0-403e-afa8-c969f22b8252"), null, new DateTime(2024, 6, 3, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7469), "Turecka", "turcja", null, "Bağdat Caddesi", 84m, 0m, 0m, 0m, 86, new DateTime(2024, 6, 3, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7469), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("2c35a085-f0c9-4dae-b27d-a36ab90762ff"), null, new DateTime(2024, 8, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8996), "Vlora", "albania", null, "Rruga e Kavajes", 99m, 0m, 0m, 0m, 180, new DateTime(2024, 8, 13, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8995), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("2cf99e44-03ce-43ae-9d1d-01f867eed9fd"), null, new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8317), "Sheikh", "egipt", null, "Sharia Ramsis", 188m, 0m, 0m, 0m, 171, new DateTime(2024, 6, 26, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8316), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("2d0d911c-9b49-4692-af4c-db285bbffe9d"), null, new DateTime(2024, 7, 27, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9505), "Alam", "egipt", null, "Sharia Tahrir", 218m, 0m, 0m, 0m, 179, new DateTime(2024, 7, 26, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9504), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("2d4fe31a-4a4a-4728-b576-f6eb22be5a1e"), null, new DateTime(2024, 8, 21, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7479), "Durres", "albania", null, "Rruga e Dibres", 131m, 0m, 0m, 0m, 85, new DateTime(2024, 8, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7478), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("2dae1ff0-16da-41b1-8110-68d5615311bc"), null, new DateTime(2024, 7, 14, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8690), "Turecka", "turcja", null, "Atatürk Caddesi", 73m, 0m, 0m, 0m, 149, new DateTime(2024, 7, 14, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8690), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("2e387cab-5964-414a-892f-c57bec4c8612"), null, new DateTime(2024, 6, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8023), "Alam", "egipt", null, "Sharia Ramsis", 194m, 0m, 0m, 0m, 134, new DateTime(2024, 6, 19, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8023), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("2e9607af-a4f8-4e0b-b444-69b9fff8bdba"), null, new DateTime(2024, 8, 11, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7472), "Alam", "egipt", null, "Sharia Tahrir", 227m, 0m, 0m, 0m, 74, new DateTime(2024, 8, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7471), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("2f0b434c-cab3-4424-bca1-81a17e1e4b4e"), null, new DateTime(2024, 8, 27, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8092), "Alam", "egipt", null, "Sharia Tahrir", 140m, 0m, 0m, 0m, 71, new DateTime(2024, 8, 26, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8091), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("2f767050-edd9-46b7-b028-56f63d2236b0"), null, new DateTime(2024, 7, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7795), "Durres", "albania", null, "Rruga Abdyl Frasheri", 108m, 0m, 0m, 0m, 185, new DateTime(2024, 7, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7794), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("2f96a69b-a5cf-44dd-933d-34df01c046d7"), null, new DateTime(2024, 7, 27, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9397), "Brava", "hiszpania", null, "Calle Mayor", 87m, 0m, 0m, 0m, 137, new DateTime(2024, 7, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9396), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("2fc87f47-b004-44f3-9f3c-cd996553a365"), null, new DateTime(2024, 7, 29, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9085), "Turecka", "turcja", null, "Atatürk Caddesi", 289m, 0m, 0m, 0m, 127, new DateTime(2024, 7, 29, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9085), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("317b49b7-1b70-41e8-8fd5-e3fa953cb9f8"), null, new DateTime(2024, 6, 24, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7419), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 271m, 0m, 0m, 0m, 158, new DateTime(2024, 6, 24, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7418), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("327cdd2d-d32b-4db1-bcdc-9d297b2738fb"), null, new DateTime(2024, 8, 26, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8251), "Alam", "egipt", null, "Sharia Tahrir", 59m, 0m, 0m, 0m, 191, new DateTime(2024, 8, 25, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8251), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("32b8dadd-4c1b-46f4-b77f-13806bc24126"), null, new DateTime(2024, 6, 3, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8235), "Turecka", "turcja", null, "Atatürk Caddesi", 249m, 0m, 0m, 0m, 179, new DateTime(2024, 6, 3, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8233), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("32e65b26-3818-4810-ad6d-b8f30e52d52a"), null, new DateTime(2024, 7, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8528), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 271m, 0m, 0m, 0m, 116, new DateTime(2024, 7, 11, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8528), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("331e6621-9c24-473f-b2f8-275b3c3beeed"), null, new DateTime(2024, 7, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9129), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 51m, 0m, 0m, 0m, 157, new DateTime(2024, 7, 3, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9129), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("33414b42-d1cf-4590-9a35-dc07b8e02bd0"), null, new DateTime(2024, 8, 14, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9033), "Durres", "albania", null, "Rruga Abdyl Frasheri", 197m, 0m, 0m, 0m, 105, new DateTime(2024, 8, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9032), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("34879b2a-1d0d-478a-bfbc-f7b7af540a5b"), null, new DateTime(2024, 8, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9595), "Luz", "hiszpania", null, "Calle Mayor", 129m, 0m, 0m, 0m, 133, new DateTime(2024, 8, 23, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9594), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("35412c44-5ac1-4c0c-b781-42234976d624"), null, new DateTime(2024, 8, 19, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8117), "Almeria", "hiszpania", null, "Paseo del Prado", 196m, 0m, 0m, 0m, 143, new DateTime(2024, 8, 18, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8116), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("356169a8-493e-4a97-af42-ddaa632e3f88"), null, new DateTime(2024, 8, 20, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9435), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 241m, 0m, 0m, 0m, 192, new DateTime(2024, 8, 20, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9434), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("3599ee61-c7a0-4e13-bf82-0318ed716621"), null, new DateTime(2024, 8, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9104), "Peloponez", "grecja", null, "Leoforos Alexandras", 195m, 0m, 0m, 0m, 171, new DateTime(2024, 8, 18, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9103), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("36181cc6-53d7-4137-883d-009d37b6ab6a"), null, new DateTime(2024, 7, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9228), "Alam", "egipt", null, "Sharia Tahrir", 158m, 0m, 0m, 0m, 134, new DateTime(2024, 7, 14, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9227), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("36e5a00f-2ec2-487b-ae45-a585930c42ef"), null, new DateTime(2024, 8, 23, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7463), "Turecka", "turcja", null, "Bağdat Caddesi", 228m, 0m, 0m, 0m, 187, new DateTime(2024, 8, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7462), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("385138e9-437c-4fdd-8af3-9f7104ad1bf8"), null, new DateTime(2024, 6, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7358), "Turecka", "turcja", null, "Atatürk Caddesi", 108m, 0m, 0m, 0m, 150, new DateTime(2024, 6, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7357), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("38ea2439-e763-4a72-95c9-1a69ea6cefe8"), null, new DateTime(2024, 8, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9030), "Alam", "egipt", null, "Sharia Tahrir", 158m, 0m, 0m, 0m, 87, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9029), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("39ef8b97-3ad5-4dd2-baab-0164287e7f3c"), null, new DateTime(2024, 7, 10, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8603), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 300m, 0m, 0m, 0m, 115, new DateTime(2024, 7, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8602), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("3a10cd8f-55af-445e-86cc-6c34b2d96ff2"), null, new DateTime(2024, 8, 4, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8313), "Brava", "hiszpania", null, "Calle Mayor", 118m, 0m, 0m, 0m, 79, new DateTime(2024, 8, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8313), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("3ab93cb4-4252-4850-908e-75eeedf55773"), null, new DateTime(2024, 7, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7807), "Sheikh", "egipt", null, "Sharia Tahrir", 249m, 0m, 0m, 0m, 57, new DateTime(2024, 7, 10, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7806), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("3ade35bb-9d73-4e1e-9a09-7877df9c1ed9"), null, new DateTime(2024, 6, 26, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8856), "Riwiera", "chorwacja", null, "Vukovarska ulica", 262m, 0m, 0m, 0m, 178, new DateTime(2024, 6, 26, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8855), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("3ed6027c-8fcd-4c58-baaf-079bfae7a67f"), null, new DateTime(2024, 6, 5, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8041), "Durres", "albania", null, "Rruga e Dibres", 275m, 0m, 0m, 0m, 142, new DateTime(2024, 6, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8040), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("3edbb835-67bb-48c3-ae06-986b89f231d0"), null, new DateTime(2024, 6, 8, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9806), "Maresme", "hiszpania", null, "Paseo del Prado", 80m, 0m, 0m, 0m, 196, new DateTime(2024, 6, 8, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9805), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("3fff0065-18d4-4b88-aadb-cdecbc0d050e"), null, new DateTime(2024, 8, 12, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8817), "Peloponez", "grecja", null, "Leoforos Alexandras", 85m, 0m, 0m, 0m, 171, new DateTime(2024, 8, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8817), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("400cd152-4ed4-4e9e-ac9a-7a47ac1db09a"), null, new DateTime(2024, 7, 30, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9617), "Alam", "egipt", null, "Sharia Tahrir", 149m, 0m, 0m, 0m, 188, new DateTime(2024, 7, 30, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9616), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("40839416-8722-42e8-a0bf-e3a4e35d6249"), null, new DateTime(2024, 6, 27, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7863), "Alam", "egipt", null, "Sharia Tahrir", 167m, 0m, 0m, 0m, 155, new DateTime(2024, 6, 27, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7862), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("409e3714-3892-45a3-bc91-2bdc332a9e88"), null, new DateTime(2024, 7, 8, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7699), "Durres", "albania", null, "Bulevardi Bajram Curri", 134m, 0m, 0m, 0m, 95, new DateTime(2024, 7, 8, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7698), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("40a2b22a-0389-4552-8c28-1ad97841bbe1"), null, new DateTime(2024, 5, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8659), "Durres", "albania", null, "Rruga Abdyl Frasheri", 291m, 0m, 0m, 0m, 51, new DateTime(2024, 5, 30, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8658), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("40a9ff5b-e1eb-49b1-8cdd-c534e1a4dcd6"), null, new DateTime(2024, 7, 5, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9382), "Alam", "egipt", null, "Sharia Tahrir", 83m, 0m, 0m, 0m, 104, new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9381), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("40e0d4f4-a96e-410f-8f87-1958b6a767f3"), null, new DateTime(2024, 6, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9838), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 253m, 0m, 0m, 0m, 193, new DateTime(2024, 6, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9838), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("4192d2c8-d638-4bcf-b9e1-bcc8a377bbcc"), null, new DateTime(2024, 6, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9056), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 51m, 0m, 0m, 0m, 132, new DateTime(2024, 6, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9055), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("41d0feee-6c2e-4061-9a78-022c8c960a98"), null, new DateTime(2024, 7, 2, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7859), "Sheikh", "egipt", null, "Sharia Ramsis", 67m, 0m, 0m, 0m, 108, new DateTime(2024, 7, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7858), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("426b6992-9623-49ae-acc2-8e3f0cd2e1d1"), null, new DateTime(2024, 8, 8, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7692), "Vlora", "albania", null, "Rruga e Kavajes", 298m, 0m, 0m, 0m, 73, new DateTime(2024, 8, 8, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7691), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("42ea2633-855b-4708-9ce3-14aa457502b8"), null, new DateTime(2024, 6, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9314), "Sheikh", "egipt", null, "Sharia Ramsis", 126m, 0m, 0m, 0m, 147, new DateTime(2024, 6, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9313), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("430cce33-3ebb-4de2-8421-ba9382c5125a"), null, new DateTime(2024, 7, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8802), "Alam", "egipt", null, "Sharia Ramsis", 262m, 0m, 0m, 0m, 56, new DateTime(2024, 7, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8802), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("44328a0b-8fd8-4fe4-a092-0ee1d8615c1d"), null, new DateTime(2024, 6, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8911), "Turecka", "turcja", null, "Atatürk Caddesi", 277m, 0m, 0m, 0m, 110, new DateTime(2024, 6, 9, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8910), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("449bd94d-6521-4a61-ba7b-0302803bbc7d"), null, new DateTime(2024, 6, 19, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7915), "Turecka", "turcja", null, "Atatürk Caddesi", 254m, 0m, 0m, 0m, 106, new DateTime(2024, 6, 19, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7915), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("44d9cf3b-1e19-4644-b316-28a3f2654103"), null, new DateTime(2024, 7, 1, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9861), "Durres", "albania", null, "Rruga Abdyl Frasheri", 68m, 0m, 0m, 0m, 199, new DateTime(2024, 7, 1, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9860), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("4528254d-e6a7-49bb-af40-78b1c0305562"), null, new DateTime(2024, 8, 16, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9118), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 270m, 0m, 0m, 0m, 65, new DateTime(2024, 8, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9118), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("453578e5-f65a-4eac-9165-695a54274d50"), null, new DateTime(2024, 7, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8292), "Durres", "albania", null, "Bulevardi Bajram Curri", 256m, 0m, 0m, 0m, 157, new DateTime(2024, 7, 5, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8291), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("4598eb6f-b29c-4b7c-8f2e-3c6a9e924bf0"), null, new DateTime(2024, 8, 9, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7362), "Heraklion", "grecja", null, "Plateia Syntagmatos", 149m, 0m, 0m, 0m, 125, new DateTime(2024, 8, 8, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7361), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("45a89a3b-e933-44a1-a184-22da5161a36c"), null, new DateTime(2024, 8, 17, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7434), "Sheikh", "egipt", null, "Sharia Salah Salem", 127m, 0m, 0m, 0m, 172, new DateTime(2024, 8, 16, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7433), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("46d63104-2492-4c21-b555-50f2f8c9ae03"), null, new DateTime(2024, 7, 11, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9767), "Riwiera", "chorwacja", null, "Kapucinska ulica", 97m, 0m, 0m, 0m, 160, new DateTime(2024, 7, 11, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9766), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("46f26a7f-5f0f-4d38-bcc1-0d9207268c04"), null, new DateTime(2024, 8, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8649), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 87m, 0m, 0m, 0m, 88, new DateTime(2024, 8, 23, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8648), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("47004419-0431-4f38-8412-97c3fc7120d8"), null, new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7677), "Sheikh", "egipt", null, "Sharia Salah Salem", 225m, 0m, 0m, 0m, 142, new DateTime(2024, 8, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7676), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("47d4c2b6-86d3-4ced-b4d2-25c9cad10362"), null, new DateTime(2024, 6, 6, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7407), "Kalabria", "wlochy", null, "Via Nazionale", 156m, 0m, 0m, 0m, 182, new DateTime(2024, 6, 6, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7406), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("4881d024-93d5-4bc9-a510-4689982b8aa5"), null, new DateTime(2024, 7, 20, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8411), "Nero", "grecja", null, "Leoforos Alexandras", 145m, 0m, 0m, 0m, 161, new DateTime(2024, 7, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8410), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("48b50834-2a4a-4357-87f2-73beaae8a656"), null, new DateTime(2024, 6, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8677), "Riwiera", "chorwacja", null, "Maksimirska ulica", 197m, 0m, 0m, 0m, 157, new DateTime(2024, 6, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8676), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("4a2dfbf8-b0a2-45df-bfc7-09265164616c"), null, new DateTime(2024, 6, 30, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8077), "Sheikh", "egipt", null, "Sharia Ramsis", 259m, 0m, 0m, 0m, 166, new DateTime(2024, 6, 30, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8077), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("4a48e9df-187c-4e39-ad24-896af98ea159"), null, new DateTime(2024, 7, 24, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9635), "Sheikh", "egipt", null, "Sharia Salah Salem", 54m, 0m, 0m, 0m, 103, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9635), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("4a9472f3-d2f0-4520-9b75-ac46e7873d5a"), null, new DateTime(2024, 8, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8328), "Brava", "hiszpania", null, "Calle de Alcalá", 65m, 0m, 0m, 0m, 184, new DateTime(2024, 8, 7, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8327), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("4aceb197-2f8a-4f9e-83ab-e6a61ad13b8c"), null, new DateTime(2024, 7, 4, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7941), "Durres", "albania", null, "Rruga Abdyl Frasheri", 118m, 0m, 0m, 0m, 82, new DateTime(2024, 7, 3, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7940), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("4b01f823-4328-4a4b-94d2-0a9e1e8e65cf"), null, new DateTime(2024, 8, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9047), "Alam", "egipt", null, "Sharia Tahrir", 287m, 0m, 0m, 0m, 53, new DateTime(2024, 8, 7, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9046), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("4b21e15d-7f47-4392-8a9e-a1faeda52c44"), null, new DateTime(2024, 8, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8009), "Alam", "egipt", null, "Sharia Ramsis", 223m, 0m, 0m, 0m, 138, new DateTime(2024, 8, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8007), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("4b661d3f-2f78-47dd-b26d-dd8721e189e6"), null, new DateTime(2024, 5, 30, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8020), "Turecka", "turcja", null, "Atatürk Caddesi", 250m, 0m, 0m, 0m, 195, new DateTime(2024, 5, 30, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8019), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("4b816c15-a1f3-4465-8751-dc83d922d17d"), null, new DateTime(2024, 7, 1, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7945), "Alam", "egipt", null, "Sharia Tahrir", 242m, 0m, 0m, 0m, 172, new DateTime(2024, 7, 1, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7944), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("4bdd1ffa-533a-44d3-81f0-66b86a7583cf"), null, new DateTime(2024, 7, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8644), "Nero", "grecja", null, "Leoforos Alexandras", 286m, 0m, 0m, 0m, 136, new DateTime(2024, 7, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8644), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("4be7b113-7265-4cf8-b339-0abc4bf1ed64"), null, new DateTime(2024, 6, 28, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9762), "Durres", "albania", null, "Bulevardi Bajram Curri", 224m, 0m, 0m, 0m, 97, new DateTime(2024, 6, 28, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9761), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("4c8ab485-018f-486c-8831-9907c25c43c7"), null, new DateTime(2024, 6, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9509), "Turecka", "turcja", null, "Atatürk Caddesi", 226m, 0m, 0m, 0m, 172, new DateTime(2024, 6, 16, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9508), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("4cd70144-90e9-47cb-ae67-c3ea50653e56"), null, new DateTime(2024, 7, 1, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9185), "Turecka", "turcja", null, "Atatürk Caddesi", 290m, 0m, 0m, 0m, 120, new DateTime(2024, 6, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9185), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("4d4b06a5-7d82-40b2-934b-b176fc4b8122"), null, new DateTime(2024, 7, 16, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9865), "Kalabria", "wlochy", null, "Via Veneto", 122m, 0m, 0m, 0m, 94, new DateTime(2024, 7, 16, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9864), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("4db894e0-5228-47ef-a713-f1bbc800eec8"), null, new DateTime(2024, 7, 14, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8518), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 196m, 0m, 0m, 0m, 86, new DateTime(2024, 7, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8517), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("4ea7d226-37f2-4b7d-a664-e9ff4e5e55cf"), null, new DateTime(2024, 7, 12, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8618), "Heraklion", "grecja", null, "Plateia Syntagmatos", 146m, 0m, 0m, 0m, 74, new DateTime(2024, 7, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8617), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("4f09a07f-119e-4169-864c-6a80cd5adbd7"), null, new DateTime(2024, 7, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8694), "Durres", "albania", null, "Bulevardi Bajram Curri", 244m, 0m, 0m, 0m, 189, new DateTime(2024, 7, 25, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8693), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("4fad6db0-1624-45e3-aea2-d7f514816687"), null, new DateTime(2024, 7, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8922), "Turecka", "turcja", null, "Atatürk Caddesi", 132m, 0m, 0m, 0m, 72, new DateTime(2024, 7, 17, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8922), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("4fea86dc-17bc-4918-9ecf-22b927ed71bd"), null, new DateTime(2024, 8, 24, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7609), "Heraklion", "grecja", null, "Plateia Syntagmatos", 296m, 0m, 0m, 0m, 143, new DateTime(2024, 8, 23, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7609), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("4ff3e332-8b3c-4043-a8e3-e6fafcdc4302"), null, new DateTime(2024, 8, 2, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9453), "Brava", "hiszpania", null, "Calle de Alcalá", 53m, 0m, 0m, 0m, 174, new DateTime(2024, 8, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9452), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("509e19af-94da-42a6-af77-d44d81fac312"), null, new DateTime(2024, 6, 21, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7543), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 95m, 0m, 0m, 0m, 54, new DateTime(2024, 6, 21, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7543), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("5147dd2e-ae38-4304-8453-a19086d42b71"), null, new DateTime(2024, 8, 6, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9802), "Turecka", "turcja", null, "Atatürk Caddesi", 141m, 0m, 0m, 0m, 188, new DateTime(2024, 8, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9801), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("515d0711-61be-4897-8ad8-f7e6af93c519"), null, new DateTime(2024, 6, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7315), "Durres", "albania", null, "Rruga e Dibres", 149m, 0m, 0m, 0m, 159, new DateTime(2024, 6, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7314), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("51757f2c-ce2d-4f72-9a7e-2a5272451df8"), null, new DateTime(2024, 6, 6, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7635), "Peloponez", "grecja", null, "Leoforos Alexandras", 114m, 0m, 0m, 0m, 125, new DateTime(2024, 6, 5, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7634), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("51b89e14-da51-4fe8-877d-b527bf4ffd21"), null, new DateTime(2024, 7, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7329), "Riwiera", "chorwacja", null, "Vukovarska ulica", 62m, 0m, 0m, 0m, 156, new DateTime(2024, 7, 9, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7328), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("51f979ef-1eeb-4704-9e84-ee146f6d3a29"), null, new DateTime(2024, 8, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8137), "Kalabria", "wlochy", null, "Via Nazionale", 141m, 0m, 0m, 0m, 146, new DateTime(2024, 8, 23, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8135), "Sheikh", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("53af9ee0-a182-4bc9-9317-db146f8dd963"), null, new DateTime(2024, 8, 20, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8868), "Durres", "albania", null, "Rruga Abdyl Frasheri", 251m, 0m, 0m, 0m, 123, new DateTime(2024, 8, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8867), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("53df4edf-6960-4e52-9460-0d824c8ed4aa"), null, new DateTime(2024, 8, 22, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7803), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 140m, 0m, 0m, 0m, 200, new DateTime(2024, 8, 22, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7802), "Sheikh", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("53e43bc5-b489-4941-9c4a-9df2ae1b19c0"), null, new DateTime(2024, 7, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8439), "Kalabria", "wlochy", null, "Via del Corso", 244m, 0m, 0m, 0m, 133, new DateTime(2024, 7, 14, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8438), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("5400d67f-7768-4f0d-a5f0-dc4b4377bb31"), null, new DateTime(2024, 8, 10, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8710), "Maresme", "hiszpania", null, "Paseo del Prado", 96m, 0m, 0m, 0m, 67, new DateTime(2024, 8, 9, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8708), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("54a665c3-202a-460c-92e6-e3cd1c48e973"), null, new DateTime(2024, 6, 1, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9018), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 194m, 0m, 0m, 0m, 58, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9018), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("54f6f81c-76ea-4f87-93cb-0603852686ce"), null, new DateTime(2024, 6, 2, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7654), "Maresme", "hiszpania", null, "Paseo del Prado", 127m, 0m, 0m, 0m, 148, new DateTime(2024, 6, 1, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7653), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("556c3603-d146-4c44-a0ce-ec2b1fa62f91"), null, new DateTime(2024, 6, 18, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8582), "Peloponez", "grecja", null, "Leoforos Alexandras", 190m, 0m, 0m, 0m, 142, new DateTime(2024, 6, 18, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8582), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("55c2a1a3-b3fb-42ad-a143-9367b62ab9a6"), null, new DateTime(2024, 7, 10, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7952), "Durres", "albania", null, "Rruga e Dibres", 108m, 0m, 0m, 0m, 137, new DateTime(2024, 7, 10, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7951), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("56eb9060-a43f-4891-bf1a-5356f47b3872"), null, new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8446), "Heraklion", "grecja", null, "Plateia Syntagmatos", 243m, 0m, 0m, 0m, 50, new DateTime(2024, 7, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8445), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("56ee8d9f-89a1-4126-8338-4a2a44e8c160"), null, new DateTime(2024, 8, 13, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7368), "Almeria", "hiszpania", null, "Paseo del Prado", 257m, 0m, 0m, 0m, 131, new DateTime(2024, 8, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7367), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("56f3750d-76fe-4e76-b0c6-c18b7a84951d"), null, new DateTime(2024, 8, 13, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8044), "Durres", "albania", null, "Bulevardi Bajram Curri", 123m, 0m, 0m, 0m, 105, new DateTime(2024, 8, 12, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8044), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("57344535-a150-4b58-836e-0a0b4ffec728"), null, new DateTime(2024, 6, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8106), "Riwiera", "chorwacja", null, "Maksimirska ulica", 131m, 0m, 0m, 0m, 129, new DateTime(2024, 6, 10, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8105), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("573f0fae-d4a9-4b6b-b959-88059e4a42c3"), null, new DateTime(2024, 7, 31, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8743), "Riwiera", "chorwacja", null, "Kapucinska ulica", 274m, 0m, 0m, 0m, 163, new DateTime(2024, 7, 31, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8742), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("586e3e42-bc82-488c-bdf5-20675330a789"), null, new DateTime(2024, 8, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8655), "Heraklion", "grecja", null, "Plateia Syntagmatos", 244m, 0m, 0m, 0m, 72, new DateTime(2024, 8, 17, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8654), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("5901008a-f9f7-4455-b983-4b8b0f811740"), null, new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9293), "Vlora", "albania", null, "Rruga 28 Nentori", 74m, 0m, 0m, 0m, 200, new DateTime(2024, 6, 12, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9292), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("59160cb8-b649-4600-9907-76f3f0975811"), null, new DateTime(2024, 8, 18, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8507), "Sheikh", "egipt", null, "Sharia Tahrir", 215m, 0m, 0m, 0m, 74, new DateTime(2024, 8, 18, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8506), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("593cfbe2-32ec-426e-b89d-794f79f54150"), null, new DateTime(2024, 6, 14, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8052), "Vlora", "albania", null, "Rruga 28 Nentori", 101m, 0m, 0m, 0m, 180, new DateTime(2024, 6, 14, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8051), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("59455b30-bf2c-4ab9-adcc-e2013f038ad1"), null, new DateTime(2024, 8, 25, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9798), "Alam", "egipt", null, "Sharia Ramsis", 213m, 0m, 0m, 0m, 164, new DateTime(2024, 8, 25, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9797), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("595e56c2-dd33-4cfa-a85b-14baa45fbeb3"), null, new DateTime(2024, 6, 22, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8587), "Almeria", "hiszpania", null, "Paseo del Prado", 264m, 0m, 0m, 0m, 189, new DateTime(2024, 6, 22, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8586), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("5a09b2fe-0596-4a01-a2b1-880ccae3d756"), null, new DateTime(2024, 6, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8984), "Peloponez", "grecja", null, "Leoforos Alexandras", 68m, 0m, 0m, 0m, 171, new DateTime(2024, 6, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8983), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("5b638ca7-83e4-4480-9a96-5b4695ebe86b"), null, new DateTime(2024, 7, 2, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7994), "Maresme", "hiszpania", null, "Paseo del Prado", 204m, 0m, 0m, 0m, 61, new DateTime(2024, 7, 2, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7993), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("5bb48df9-6fa5-42cf-8899-07e7b999dda7"), null, new DateTime(2024, 6, 8, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7904), "Alam", "egipt", null, "Sharia Tahrir", 257m, 0m, 0m, 0m, 90, new DateTime(2024, 6, 8, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7904), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("5c2842d1-58d8-4050-810d-1037da2bfbae"), null, new DateTime(2024, 6, 5, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8598), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 169m, 0m, 0m, 0m, 81, new DateTime(2024, 6, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8597), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("5c293541-2943-4e58-89e2-cd363d9223af"), null, new DateTime(2024, 6, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8140), "Peloponez", "grecja", null, "Leoforos Alexandras", 123m, 0m, 0m, 0m, 126, new DateTime(2024, 6, 16, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8140), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("5c356b0f-084c-493f-958d-214958ad9e20"), null, new DateTime(2024, 8, 20, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7898), "Durres", "albania", null, "Rruga e Dibres", 162m, 0m, 0m, 0m, 145, new DateTime(2024, 8, 20, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7897), "Sheikh", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("5e56d3df-d043-4d38-a992-243c20203e9e"), null, new DateTime(2024, 7, 22, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9040), "Maresme", "hiszpania", null, "Paseo del Prado", 166m, 0m, 0m, 0m, 131, new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9040), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("5e58c9d4-0314-4826-82b0-b28b802f2509"), null, new DateTime(2024, 6, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8844), "Kalabria", "wlochy", null, "Via Veneto", 241m, 0m, 0m, 0m, 66, new DateTime(2024, 6, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8843), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("5ee9f75c-75aa-4cfd-859b-c9db2e562245"), null, new DateTime(2024, 7, 3, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9282), "Brava", "hiszpania", null, "Gran Vía", 131m, 0m, 0m, 0m, 66, new DateTime(2024, 7, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9281), "Nero", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("5f0f0e4b-3ba4-4d31-a561-2b484f823099"), null, new DateTime(2024, 8, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7340), "Riwiera", "chorwacja", null, "Kapucinska ulica", 65m, 0m, 0m, 0m, 135, new DateTime(2024, 8, 26, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7339), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("5f658c15-b545-4a98-9a39-0606d4a45b3f"), null, new DateTime(2024, 8, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9704), "Kalabria", "wlochy", null, "Via del Corso", 157m, 0m, 0m, 0m, 106, new DateTime(2024, 8, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9703), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("5f6cd75c-0763-412a-8654-445f5802eb12"), null, new DateTime(2024, 6, 20, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9189), "Durres", "albania", null, "Rruga e Dibres", 297m, 0m, 0m, 0m, 121, new DateTime(2024, 6, 20, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9189), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("60b1ee61-4d5c-40e9-81cd-6ac9c4fba95d"), null, new DateTime(2024, 7, 4, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9576), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 272m, 0m, 0m, 0m, 90, new DateTime(2024, 7, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9575), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("60b8b3b7-97d4-41dc-a979-3244cd569ede"), null, new DateTime(2024, 8, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8848), "Maresme", "hiszpania", null, "Paseo del Prado", 88m, 0m, 0m, 0m, 193, new DateTime(2024, 8, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8847), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("61c1ebeb-9e94-4861-a094-e2ca27bd37ed"), null, new DateTime(2024, 8, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9651), "Turecka", "turcja", null, "Atatürk Caddesi", 100m, 0m, 0m, 0m, 132, new DateTime(2024, 8, 12, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9650), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("61e7b4ff-35bf-413a-b12e-0a8ff81ea9f1"), null, new DateTime(2024, 7, 4, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7536), "Durres", "albania", null, "Rruga e Dibres", 104m, 0m, 0m, 0m, 50, new DateTime(2024, 7, 4, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7535), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Train" },
                    { new Guid("620e10db-bcd7-453e-aaab-b4b69590539a"), null, new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8663), "Kalabria", "wlochy", null, "Via Veneto", 191m, 0m, 0m, 0m, 163, new DateTime(2024, 7, 9, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8662), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("6279422b-2750-4885-8340-4cb81a396290"), null, new DateTime(2024, 6, 11, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9771), "Riwiera", "chorwacja", null, "Maksimirska ulica", 281m, 0m, 0m, 0m, 179, new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9770), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("629bd506-c294-4622-bd6c-bd7c74a87649"), null, new DateTime(2024, 7, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8469), "Brava", "hiszpania", null, "Gran Vía", 187m, 0m, 0m, 0m, 99, new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8468), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("63a56921-19b4-433d-a1c1-49d80ed24607"), null, new DateTime(2024, 7, 11, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9872), "Sheikh", "egipt", null, "Sharia Salah Salem", 136m, 0m, 0m, 0m, 99, new DateTime(2024, 7, 10, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9872), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("63e8286e-4ec2-4e09-accf-d2ae18935fcd"), null, new DateTime(2024, 7, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7325), "Alam", "egipt", null, "Sharia Tahrir", 221m, 0m, 0m, 0m, 167, new DateTime(2024, 7, 28, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7325), "Vlora", "albania", null, "Rruga e Kavajes", "Bus" },
                    { new Guid("64aab650-6815-4a2e-939f-61a6b8702532"), null, new DateTime(2024, 6, 12, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8422), "Turecka", "turcja", null, "Atatürk Caddesi", 215m, 0m, 0m, 0m, 92, new DateTime(2024, 6, 12, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8421), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("64b06edf-5ec1-4530-bccb-166e7daea158"), null, new DateTime(2024, 7, 22, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7822), "Luz", "hiszpania", null, "Calle Mayor", 126m, 0m, 0m, 0m, 96, new DateTime(2024, 7, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7822), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("659cb894-4b92-4e29-bbd1-b1dd5f7aff7f"), null, new DateTime(2024, 8, 26, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7415), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 107m, 0m, 0m, 0m, 187, new DateTime(2024, 8, 26, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7414), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("65df5e00-f949-4abf-b517-9cae86220224"), null, new DateTime(2024, 7, 18, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8191), "Alam", "egipt", null, "Sharia Ramsis", 246m, 0m, 0m, 0m, 59, new DateTime(2024, 7, 18, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8190), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("6708c3a1-b6cc-44e9-b078-921296134a28"), null, new DateTime(2024, 7, 23, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7348), "Almeria", "hiszpania", null, "Paseo del Prado", 284m, 0m, 0m, 0m, 196, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7347), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("676a61e1-f478-486b-8c5a-e320423ac258"), null, new DateTime(2024, 7, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8425), "Durres", "albania", null, "Rruga e Dibres", 55m, 0m, 0m, 0m, 191, new DateTime(2024, 7, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8424), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("6773cb34-ee66-4f3b-899a-71108ceb81cc"), null, new DateTime(2024, 6, 11, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7937), "Brava", "hiszpania", null, "Calle de Alcalá", 54m, 0m, 0m, 0m, 100, new DateTime(2024, 6, 10, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7937), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("67d51185-fdc3-4c75-b2e3-c13a624f2b92"), null, new DateTime(2024, 6, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9126), "Alam", "egipt", null, "Sharia Ramsis", 268m, 0m, 0m, 0m, 105, new DateTime(2024, 6, 21, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9125), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("6868d2ba-2326-4032-ab24-f5772a3c131a"), null, new DateTime(2024, 8, 8, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7344), "Marmaris", "turcja", null, "Bağdat Caddesi", 225m, 0m, 0m, 0m, 59, new DateTime(2024, 8, 8, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7343), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("6903234d-f453-4593-aee9-e918b3325f6a"), null, new DateTime(2024, 8, 6, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8919), "Durres", "albania", null, "Rruga Abdyl Frasheri", 104m, 0m, 0m, 0m, 187, new DateTime(2024, 8, 6, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8918), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("6a41fb84-c4c9-4b60-b4ce-93982420c17b"), null, new DateTime(2024, 8, 9, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7703), "Durres", "albania", null, "Rruga e Dibres", 209m, 0m, 0m, 0m, 169, new DateTime(2024, 8, 8, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7702), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("6a9eb7cc-7eac-4a55-a40a-27e9a019352c"), null, new DateTime(2024, 6, 8, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7740), "Alam", "egipt", null, "Sharia Tahrir", 273m, 0m, 0m, 0m, 117, new DateTime(2024, 6, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7739), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("6ad3da42-b7c6-4e44-9154-be3dd413b1c6"), null, new DateTime(2024, 6, 19, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8284), "Brava", "hiszpania", null, "Calle Mayor", 90m, 0m, 0m, 0m, 94, new DateTime(2024, 6, 19, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8283), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("6d2c56c6-9ecf-49ce-ade5-c43052ef5e91"), null, new DateTime(2024, 6, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7927), "Marmaris", "turcja", null, "Bağdat Caddesi", 158m, 0m, 0m, 0m, 175, new DateTime(2024, 6, 6, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7926), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("6dbc967c-7c46-4d06-b592-dfe89700c05e"), null, new DateTime(2024, 7, 9, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7449), "Kalabria", "wlochy", null, "Via Veneto", 180m, 0m, 0m, 0m, 178, new DateTime(2024, 7, 9, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7448), "Almeria", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("6e92be27-54b1-402c-8891-6206dc4a7e18"), null, new DateTime(2024, 8, 23, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7494), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 118m, 0m, 0m, 0m, 154, new DateTime(2024, 8, 22, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7493), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("6f0653ea-d6c7-43a6-b360-4e3278b736e8"), null, new DateTime(2024, 6, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9000), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 271m, 0m, 0m, 0m, 197, new DateTime(2024, 6, 14, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8999), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("6f1c57a0-f4c4-49c6-b475-e197b3a29e91"), null, new DateTime(2024, 8, 25, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9181), "Riwiera", "chorwacja", null, "Vukovarska ulica", 235m, 0m, 0m, 0m, 108, new DateTime(2024, 8, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9180), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("6fd822cf-8934-4061-a7ff-ea7c0966a897"), null, new DateTime(2024, 6, 27, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8905), "Durres", "albania", null, "Rruga e Dibres", 191m, 0m, 0m, 0m, 177, new DateTime(2024, 6, 27, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8904), "Vlora", "albania", null, "Rruga 28 Nentori", "Plane" },
                    { new Guid("700e1505-1f6c-45b0-8997-25260f502714"), null, new DateTime(2024, 7, 19, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7998), "Durres", "albania", null, "Rruga e Dibres", 55m, 0m, 0m, 0m, 141, new DateTime(2024, 7, 19, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7997), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("70574ac7-959b-4431-a261-4688e99836ca"), null, new DateTime(2024, 7, 18, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8852), "Marmaris", "turcja", null, "Bağdat Caddesi", 108m, 0m, 0m, 0m, 82, new DateTime(2024, 7, 18, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8851), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("706b1f7e-3225-450f-9f57-9d44cd0a9cc4"), null, new DateTime(2024, 6, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7445), "Kalabria", "wlochy", null, "Via del Corso", 79m, 0m, 0m, 0m, 128, new DateTime(2024, 6, 28, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7444), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("716de180-5a20-4acf-8db4-9a61808007a3"), null, new DateTime(2024, 6, 12, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7441), "Vlora", "albania", null, "Rruga e Kavajes", 160m, 0m, 0m, 0m, 67, new DateTime(2024, 6, 12, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7441), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("71e08b3b-d308-4cd4-bc0e-fcaa1e962851"), null, new DateTime(2024, 8, 13, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9724), "Peloponez", "grecja", null, "Leoforos Alexandras", 98m, 0m, 0m, 0m, 121, new DateTime(2024, 8, 13, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9723), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("72a6a683-13af-416e-9718-99798dbc8e93"), null, new DateTime(2024, 8, 7, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8214), "Sheikh", "egipt", null, "Sharia Ramsis", 237m, 0m, 0m, 0m, 184, new DateTime(2024, 8, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8213), "Almeria", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("7308100f-2e13-4cb9-a808-d8aad173f2ec"), null, new DateTime(2024, 6, 15, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9202), "Brava", "hiszpania", null, "Paseo del Prado", 161m, 0m, 0m, 0m, 106, new DateTime(2024, 6, 15, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9201), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("7341a50e-1b8b-4c65-8db4-5b38a71da4c1"), null, new DateTime(2024, 7, 5, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9481), "Turecka", "turcja", null, "Atatürk Caddesi", 281m, 0m, 0m, 0m, 64, new DateTime(2024, 7, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9481), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("73f45855-439b-46be-ae50-7f97c2158408"), null, new DateTime(2024, 8, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7923), "Brava", "hiszpania", null, "Gran Vía", 175m, 0m, 0m, 0m, 172, new DateTime(2024, 8, 3, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7922), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("73fde571-226e-459d-8ecd-cc1e4760a168"), null, new DateTime(2024, 8, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8276), "Alam", "egipt", null, "Sharia Tahrir", 227m, 0m, 0m, 0m, 189, new DateTime(2024, 8, 12, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8276), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("743c9c80-837e-449d-9d47-a8989135189a"), null, new DateTime(2024, 8, 18, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8465), "Kalabria", "wlochy", null, "Via Nazionale", 150m, 0m, 0m, 0m, 71, new DateTime(2024, 8, 17, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8464), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("74679b11-7cac-474e-9a01-306f45d8d808"), null, new DateTime(2024, 6, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8096), "Durres", "albania", null, "Bulevardi Bajram Curri", 113m, 0m, 0m, 0m, 189, new DateTime(2024, 6, 26, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8095), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("756141a5-f9fe-4ba9-bddf-910be5519800"), null, new DateTime(2024, 6, 7, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7661), "Durres", "albania", null, "Rruga Abdyl Frasheri", 161m, 0m, 0m, 0m, 139, new DateTime(2024, 6, 7, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7660), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("758040bf-5dc7-49c6-a4f2-cd8d83cd2dbe"), null, new DateTime(2024, 7, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9301), "Riwiera", "chorwacja", null, "Maksimirska ulica", 132m, 0m, 0m, 0m, 84, new DateTime(2024, 7, 18, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9300), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("7602850f-2459-4fbd-98eb-9c3060a57656"), null, new DateTime(2024, 5, 31, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9063), "Turecka", "turcja", null, "Halaskargazi Caddesi", 106m, 0m, 0m, 0m, 149, new DateTime(2024, 5, 31, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9062), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Train" },
                    { new Guid("766cc4ae-e5c1-4d6d-a0fe-de948e84313b"), null, new DateTime(2024, 8, 10, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8288), "Riwiera", "chorwacja", null, "Vukovarska ulica", 291m, 0m, 0m, 0m, 69, new DateTime(2024, 8, 9, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8287), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("7738cf5f-6ab9-44e7-a107-08a790471a27"), null, new DateTime(2024, 7, 29, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7990), "Kalabria", "wlochy", null, "Via Nazionale", 101m, 0m, 0m, 0m, 161, new DateTime(2024, 7, 29, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7989), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("7834a855-1583-4028-9b52-68249631127e"), null, new DateTime(2024, 7, 26, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7748), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 214m, 0m, 0m, 0m, 50, new DateTime(2024, 7, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7747), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("797d1802-b412-44d5-8927-7cde98459d8e"), null, new DateTime(2024, 6, 16, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7456), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 79m, 0m, 0m, 0m, 181, new DateTime(2024, 6, 15, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7455), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("7a76bff5-2e13-4288-b931-4d9e14dcfebf"), null, new DateTime(2024, 7, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7919), "Riwiera", "chorwacja", null, "Kapucinska ulica", 108m, 0m, 0m, 0m, 177, new DateTime(2024, 7, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7918), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Bus" },
                    { new Guid("7a78ef0b-7afe-420f-82ab-40efa9eefddf"), null, new DateTime(2024, 6, 14, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8736), "Vlora", "albania", null, "Rruga e Kavajes", 75m, 0m, 0m, 0m, 57, new DateTime(2024, 6, 14, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8735), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("7abe971e-3b7c-4ddb-bcb8-8c28585e34bd"), null, new DateTime(2024, 7, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8746), "Peloponez", "grecja", null, "Leoforos Alexandras", 232m, 0m, 0m, 0m, 176, new DateTime(2024, 7, 25, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8746), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("7bdf9e4f-8b5a-4c7c-a931-f795e98f75e1"), null, new DateTime(2024, 8, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8725), "Marmaris", "turcja", null, "Bağdat Caddesi", 123m, 0m, 0m, 0m, 77, new DateTime(2024, 8, 16, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8724), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("7cbd22a3-75f3-4c31-9eb7-805410fa5f5d"), null, new DateTime(2024, 8, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9067), "Durres", "albania", null, "Rruga e Dibres", 67m, 0m, 0m, 0m, 77, new DateTime(2024, 8, 15, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9066), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("7d43ab2c-f287-44eb-8ce3-d9841d0b6805"), null, new DateTime(2024, 7, 9, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7666), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 166m, 0m, 0m, 0m, 173, new DateTime(2024, 7, 9, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7665), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("7d9bed6a-bb5f-49b9-aafc-a3a1f66b45fb"), null, new DateTime(2024, 7, 14, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9621), "Alam", "egipt", null, "Sharia Ramsis", 267m, 0m, 0m, 0m, 171, new DateTime(2024, 7, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9620), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("7f904971-6535-4a22-8256-892aca4ad9dc"), null, new DateTime(2024, 6, 22, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9485), "Kalabria", "wlochy", null, "Via Nazionale", 140m, 0m, 0m, 0m, 123, new DateTime(2024, 6, 22, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9484), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("7f976b96-4c4e-42cf-8a3e-4017e5bd2c10"), null, new DateTime(2024, 6, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9501), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 58m, 0m, 0m, 0m, 82, new DateTime(2024, 6, 12, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9501), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("7fb2bf4b-cd7d-4403-be0c-a43bb898b4fe"), null, new DateTime(2024, 8, 17, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8799), "Heraklion", "grecja", null, "Plateia Syntagmatos", 297m, 0m, 0m, 0m, 160, new DateTime(2024, 8, 16, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8798), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("801f9d45-63d5-42ac-9ac5-b9baa4f999a5"), null, new DateTime(2024, 7, 10, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9817), "Riwiera", "chorwacja", null, "Kapucinska ulica", 171m, 0m, 0m, 0m, 109, new DateTime(2024, 7, 9, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9816), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("806d58ba-43cb-4530-9271-92aa1767d901"), null, new DateTime(2024, 6, 2, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7622), "Luz", "hiszpania", null, "Calle Mayor", 148m, 0m, 0m, 0m, 151, new DateTime(2024, 6, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7621), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("809e1fcb-ec41-4ddf-b187-6512541d30f4"), null, new DateTime(2024, 6, 3, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8933), "Luz", "hiszpania", null, "Calle Mayor", 166m, 0m, 0m, 0m, 195, new DateTime(2024, 6, 3, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8933), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("812906c9-e550-4e23-9226-1c87c2662172"), null, new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7710), "Kalabria", "wlochy", null, "Via del Corso", 104m, 0m, 0m, 0m, 164, new DateTime(2024, 6, 28, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7709), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("827fb766-fbf8-4e82-a4cb-3ef8dd5e8a3e"), null, new DateTime(2024, 7, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9308), "Alam", "egipt", null, "Sharia Ramsis", 188m, 0m, 0m, 0m, 65, new DateTime(2024, 7, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9307), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("82fedd8a-51b7-42dd-995a-b17ba8ac44b2"), null, new DateTime(2024, 8, 1, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8514), "Peloponez", "grecja", null, "Leoforos Alexandras", 279m, 0m, 0m, 0m, 144, new DateTime(2024, 7, 31, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8513), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("839f191b-2556-482b-b925-a84c58e4cc48"), null, new DateTime(2024, 7, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9022), "Peloponez", "grecja", null, "Leoforos Alexandras", 88m, 0m, 0m, 0m, 198, new DateTime(2024, 7, 5, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9021), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("840aff46-d913-4fe3-a7f4-3dfe1445b099"), null, new DateTime(2024, 7, 17, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7650), "Heraklion", "grecja", null, "Plateia Syntagmatos", 189m, 0m, 0m, 0m, 193, new DateTime(2024, 7, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7650), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("843c9f3c-e4a8-4819-bba1-5832a9ff0232"), null, new DateTime(2024, 6, 3, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7514), "Alam", "egipt", null, "Sharia Tahrir", 127m, 0m, 0m, 0m, 101, new DateTime(2024, 6, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7513), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Bus" },
                    { new Guid("84e4e6dd-5acc-46bf-8e59-a585ad51b37f"), null, new DateTime(2024, 7, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9257), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 290m, 0m, 0m, 0m, 133, new DateTime(2024, 7, 15, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9256), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("8598b8a0-b209-4f8e-9420-3994a8102a34"), null, new DateTime(2024, 7, 27, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9413), "Turecka", "turcja", null, "Bağdat Caddesi", 280m, 0m, 0m, 0m, 117, new DateTime(2024, 7, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9412), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("86c19e60-a875-417e-a9c7-887c0a27917b"), null, new DateTime(2024, 8, 10, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9304), "Turecka", "turcja", null, "Atatürk Caddesi", 159m, 0m, 0m, 0m, 56, new DateTime(2024, 8, 10, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9304), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("8701d145-989a-43da-8f75-9ed8e94c405e"), null, new DateTime(2024, 8, 2, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8754), "Marmaris", "turcja", null, "Bağdat Caddesi", 109m, 0m, 0m, 0m, 196, new DateTime(2024, 8, 2, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8753), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Plane" },
                    { new Guid("872649ce-6d88-423d-81ac-3a75738be24d"), null, new DateTime(2024, 8, 13, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9672), "Turecka", "turcja", null, "Atatürk Caddesi", 278m, 0m, 0m, 0m, 186, new DateTime(2024, 8, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9672), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("872daf23-6065-4f8a-9166-f675bb526903"), null, new DateTime(2024, 6, 5, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9386), "Riwiera", "chorwacja", null, "Vukovarska ulica", 95m, 0m, 0m, 0m, 128, new DateTime(2024, 6, 5, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9385), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("8780b72a-09a3-4e15-8e30-9aa1cbeace31"), null, new DateTime(2024, 7, 16, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8814), "Turecka", "turcja", null, "Atatürk Caddesi", 185m, 0m, 0m, 0m, 160, new DateTime(2024, 7, 16, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8813), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("891ca40d-87c0-4d16-b768-a3a60a0985f8"), null, new DateTime(2024, 6, 8, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8863), "Durres", "albania", null, "Bulevardi Bajram Curri", 192m, 0m, 0m, 0m, 65, new DateTime(2024, 6, 8, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8862), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("896c3b44-052f-42fc-a069-064307ce0e25"), null, new DateTime(2024, 6, 6, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8496), "Kalabria", "wlochy", null, "Via Veneto", 195m, 0m, 0m, 0m, 191, new DateTime(2024, 6, 6, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8495), "Brava", "hiszpania", null, "Gran Vía", "Plane" },
                    { new Guid("896faa36-444d-4cbf-9a30-535caf43c60b"), null, new DateTime(2024, 6, 3, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8180), "Vlora", "albania", null, "Rruga e Kavajes", 179m, 0m, 0m, 0m, 132, new DateTime(2024, 6, 3, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8179), "Turecka", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("8b29613a-eab7-4bc4-bb91-7d286001bdeb"), null, new DateTime(2024, 6, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8625), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 168m, 0m, 0m, 0m, 111, new DateTime(2024, 6, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8624), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("8b8197d1-0d89-49f4-866d-95f4850beb42"), null, new DateTime(2024, 8, 4, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9026), "Durres", "albania", null, "Rruga e Dibres", 269m, 0m, 0m, 0m, 105, new DateTime(2024, 8, 4, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9025), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("8be744ee-1032-4c8f-a6ca-979a3eeea514"), null, new DateTime(2024, 8, 3, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7754), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 134m, 0m, 0m, 0m, 83, new DateTime(2024, 8, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7754), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("8c587025-781f-4946-9ab2-cb90aac05b18"), null, new DateTime(2024, 8, 20, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8012), "Vlora", "albania", null, "Rruga e Kavajes", 123m, 0m, 0m, 0m, 164, new DateTime(2024, 8, 19, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8012), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("8c63bd82-320c-4371-970e-79eb66515bfb"), null, new DateTime(2024, 7, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9831), "Durres", "albania", null, "Rruga e Dibres", 277m, 0m, 0m, 0m, 98, new DateTime(2024, 7, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9830), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("8c64eff6-f4f1-4e47-91cb-80559ec2319d"), null, new DateTime(2024, 7, 2, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9470), "Kalabria", "wlochy", null, "Via Nazionale", 116m, 0m, 0m, 0m, 112, new DateTime(2024, 7, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9469), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("8c8da164-bb1e-4476-af97-8623a9bf1e19"), null, new DateTime(2024, 7, 23, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7948), "Alam", "egipt", null, "Sharia Tahrir", 96m, 0m, 0m, 0m, 116, new DateTime(2024, 7, 22, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7948), "Peloponez", "grecja", null, "Leoforos Alexandras", "Train" },
                    { new Guid("8cd80fb9-1d66-46a1-a775-969e5e07646d"), null, new DateTime(2024, 6, 2, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7647), "Durres", "albania", null, "Rruga Abdyl Frasheri", 252m, 0m, 0m, 0m, 90, new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7646), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("8d48c3f4-8028-46cd-a153-8f4c572b2cc4"), null, new DateTime(2024, 6, 10, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7540), "Kalabria", "wlochy", null, "Via Veneto", 190m, 0m, 0m, 0m, 52, new DateTime(2024, 6, 10, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7539), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("8dec0c79-246f-4826-90f5-27434d54b58d"), null, new DateTime(2024, 7, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8037), "Luz", "hiszpania", null, "Calle Mayor", 294m, 0m, 0m, 0m, 163, new DateTime(2024, 7, 8, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8037), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("8f6bd250-c74e-49b5-a624-41eb5163a55c"), null, new DateTime(2024, 8, 17, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7912), "Vlora", "albania", null, "Rruga e Kavajes", 265m, 0m, 0m, 0m, 131, new DateTime(2024, 8, 17, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7911), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("8fa68f6a-4343-4d93-b77c-20f31ef288c7"), null, new DateTime(2024, 6, 27, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8859), "Durres", "albania", null, "Rruga e Dibres", 132m, 0m, 0m, 0m, 198, new DateTime(2024, 6, 27, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8858), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Bus" },
                    { new Guid("903e6605-fe5a-4671-9bb0-e5024abaddec"), null, new DateTime(2024, 7, 14, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7605), "Durres", "albania", null, "Rruga e Dibres", 252m, 0m, 0m, 0m, 184, new DateTime(2024, 7, 14, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7605), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("90e80b26-2bf4-4f8f-93a3-90be3681dcc2"), null, new DateTime(2024, 8, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9584), "Durres", "albania", null, "Rruga e Dibres", 89m, 0m, 0m, 0m, 167, new DateTime(2024, 8, 19, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9583), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("91f69cbf-4958-4a38-b5c5-9de9cfd36c72"), null, new DateTime(2024, 7, 18, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9850), "Turecka", "turcja", null, "Bağdat Caddesi", 152m, 0m, 0m, 0m, 71, new DateTime(2024, 7, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9849), "Vlora", "albania", null, "Rruga 28 Nentori", "Bus" },
                    { new Guid("9205bf39-2c09-4b6c-b2c9-e968270fbd10"), null, new DateTime(2024, 6, 17, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9235), "Vlora", "albania", null, "Rruga 28 Nentori", 92m, 0m, 0m, 0m, 171, new DateTime(2024, 6, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9234), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("9230a23c-f58a-49ad-bf16-f91babdcfd63"), null, new DateTime(2024, 8, 17, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9465), "Durres", "albania", null, "Rruga Abdyl Frasheri", 95m, 0m, 0m, 0m, 166, new DateTime(2024, 8, 17, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9464), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("92351772-fa87-4019-bd85-f2fb0d3e17bd"), null, new DateTime(2024, 8, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9711), "Brava", "hiszpania", null, "Gran Vía", 106m, 0m, 0m, 0m, 197, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9710), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("9291b6fd-f063-4e02-aa07-6163d7434fdb"), null, new DateTime(2024, 7, 25, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8717), "Peloponez", "grecja", null, "Leoforos Alexandras", 201m, 0m, 0m, 0m, 194, new DateTime(2024, 7, 24, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8716), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("934abd05-fa25-4370-a8b5-014bc9acac42"), null, new DateTime(2024, 8, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9239), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 287m, 0m, 0m, 0m, 131, new DateTime(2024, 8, 7, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9238), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("93603ab6-8022-4f51-858b-a5512f8f6d24"), null, new DateTime(2024, 7, 22, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9708), "Sheikh", "egipt", null, "Sharia Ramsis", 66m, 0m, 0m, 0m, 169, new DateTime(2024, 7, 21, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9707), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("943ce4d0-3b9d-421e-a0de-9cb623d89fa1"), null, new DateTime(2024, 6, 2, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7550), "Brava", "hiszpania", null, "Calle Mayor", 51m, 0m, 0m, 0m, 98, new DateTime(2024, 6, 1, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7549), "Vlora", "albania", null, "Rruga e Kavajes", "Train" },
                    { new Guid("946cd470-8f58-4e48-a3b2-ef210fa03f82"), null, new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9375), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 131m, 0m, 0m, 0m, 149, new DateTime(2024, 6, 1, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9375), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("94cc245e-22be-4fbe-92e1-ff4b5e936ba1"), null, new DateTime(2024, 6, 14, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7452), "Vlora", "albania", null, "Rruga e Kavajes", 227m, 0m, 0m, 0m, 108, new DateTime(2024, 6, 13, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7452), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("95082298-7679-4b45-8e6e-111a223c42d8"), null, new DateTime(2024, 7, 30, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9478), "Durres", "albania", null, "Rruga Abdyl Frasheri", 108m, 0m, 0m, 0m, 200, new DateTime(2024, 7, 30, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9477), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("956f2e5a-6193-4a2a-bdb3-32ec256c8d90"), null, new DateTime(2024, 7, 23, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9216), "Turecka", "turcja", null, "Bağdat Caddesi", 224m, 0m, 0m, 0m, 111, new DateTime(2024, 7, 22, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9215), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("95750c0e-9e15-4fdf-b161-dce7e83db1f9"), null, new DateTime(2024, 7, 11, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9326), "Turecka", "turcja", null, "Bağdat Caddesi", 226m, 0m, 0m, 0m, 57, new DateTime(2024, 7, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9326), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("95ab513f-c484-4146-bd3a-d683dfd4f748"), null, new DateTime(2024, 6, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9869), "Durres", "albania", null, "Rruga e Dibres", 292m, 0m, 0m, 0m, 70, new DateTime(2024, 6, 19, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9868), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("95dfb6cd-9ccb-4801-8b59-5e12ac1ce4e8"), null, new DateTime(2024, 7, 6, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9458), "Durres", "albania", null, "Rruga e Dibres", 153m, 0m, 0m, 0m, 65, new DateTime(2024, 7, 5, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9457), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("965dd752-46ff-4087-85ea-2716a1e128f7"), null, new DateTime(2024, 8, 3, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9051), "Marmaris", "turcja", null, "Bağdat Caddesi", 124m, 0m, 0m, 0m, 165, new DateTime(2024, 8, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9050), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("96b6415a-0f04-4fc1-811e-0630f11f9fae"), null, new DateTime(2024, 8, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8901), "Alam", "egipt", null, "Sharia Tahrir", 195m, 0m, 0m, 0m, 56, new DateTime(2024, 8, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8900), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("9855ee8a-9459-4a6d-88f6-f60e212696f9"), null, new DateTime(2024, 8, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9297), "Kalabria", "wlochy", null, "Via Nazionale", 232m, 0m, 0m, 0m, 96, new DateTime(2024, 8, 26, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9296), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("98575414-b585-441c-a375-21bf8cf3989c"), null, new DateTime(2024, 6, 26, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8833), "Sheikh", "egipt", null, "Sharia Tahrir", 83m, 0m, 0m, 0m, 183, new DateTime(2024, 6, 26, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8832), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("9a154635-28df-4b7d-a77d-1144c2c465c4"), null, new DateTime(2024, 6, 9, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8503), "Almeria", "hiszpania", null, "Paseo del Prado", 119m, 0m, 0m, 0m, 65, new DateTime(2024, 6, 9, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8502), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("9a4486d3-6270-475f-89b8-e89ebb630491"), null, new DateTime(2024, 6, 29, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9693), "Riwiera", "chorwacja", null, "Kapucinska ulica", 130m, 0m, 0m, 0m, 141, new DateTime(2024, 6, 28, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9692), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("9ad3a03c-b139-4ab2-ad68-0d9f8cd8efc3"), null, new DateTime(2024, 7, 24, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9522), "Riwiera", "chorwacja", null, "Vukovarska ulica", 186m, 0m, 0m, 0m, 121, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9522), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("9b929cd3-050e-4ad4-8677-43b428137bb2"), null, new DateTime(2024, 7, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9680), "Durres", "albania", null, "Rruga e Dibres", 248m, 0m, 0m, 0m, 168, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9679), "Sheikh", "egipt", null, "Sharia Salah Salem", "Bus" },
                    { new Guid("9bad7ead-ac43-4894-ad51-9860df7b0f3a"), null, new DateTime(2024, 8, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7725), "Turecka", "turcja", null, "Bağdat Caddesi", 236m, 0m, 0m, 0m, 175, new DateTime(2024, 8, 21, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7724), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("9bdecfb0-fa8e-4258-9bb0-ef148c84caef"), null, new DateTime(2024, 7, 19, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9835), "Sheikh", "egipt", null, "Sharia Tahrir", 215m, 0m, 0m, 0m, 150, new DateTime(2024, 7, 19, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9834), "Kalabria", "wlochy", null, "Via del Corso", "Bus" },
                    { new Guid("9be5869d-4f65-4001-8662-08de3737dd7c"), null, new DateTime(2024, 8, 6, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7814), "Riwiera", "chorwacja", null, "Maksimirska ulica", 125m, 0m, 0m, 0m, 171, new DateTime(2024, 8, 5, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7813), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("9bf02dcc-b96a-4753-b567-5749e87d384e"), null, new DateTime(2024, 8, 16, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7872), "Kalabria", "wlochy", null, "Via Veneto", 90m, 0m, 0m, 0m, 97, new DateTime(2024, 8, 15, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7871), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("9c42990f-3bfe-4835-a146-ac56bfaeb5a2"), null, new DateTime(2024, 8, 15, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7841), "Kalabria", "wlochy", null, "Via Nazionale", 283m, 0m, 0m, 0m, 79, new DateTime(2024, 8, 15, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7840), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("9c58929b-e310-41c2-99c0-17e256b99b0b"), null, new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9243), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 289m, 0m, 0m, 0m, 137, new DateTime(2024, 6, 23, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9242), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("9c797990-d9ed-4766-a50b-cc4f1aec26ab"), null, new DateTime(2024, 5, 31, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8004), "Sheikh", "egipt", null, "Sharia Salah Salem", 78m, 0m, 0m, 0m, 156, new DateTime(2024, 5, 31, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8004), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("9cf76c57-1c8d-4c4a-a35a-e5b3f87e1da5"), null, new DateTime(2024, 6, 27, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9209), "Kalabria", "wlochy", null, "Via Veneto", 238m, 0m, 0m, 0m, 146, new DateTime(2024, 6, 26, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9208), "Brava", "hiszpania", null, "Calle de Alcalá", "Plane" },
                    { new Guid("a00f12d3-d889-4dca-87b4-c6b1cc9c427d"), null, new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8948), "Kalabria", "wlochy", null, "Via Veneto", 212m, 0m, 0m, 0m, 178, new DateTime(2024, 6, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8947), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("a02b88ce-52df-426e-8801-03f2ff64c3ef"), null, new DateTime(2024, 7, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8027), "Nero", "grecja", null, "Leoforos Alexandras", 93m, 0m, 0m, 0m, 127, new DateTime(2024, 7, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8026), "Brava", "hiszpania", null, "Gran Vía", "Bus" },
                    { new Guid("a034251b-7da0-4ffa-bb9a-2821e9dc10ad"), null, new DateTime(2024, 5, 31, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8255), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 275m, 0m, 0m, 0m, 166, new DateTime(2024, 5, 30, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8254), "Heraklion", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("a0e27ec5-9cf0-43fb-85d7-6b1110a34068"), null, new DateTime(2024, 7, 18, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8266), "Riwiera", "chorwacja", null, "Maksimirska ulica", 192m, 0m, 0m, 0m, 191, new DateTime(2024, 7, 18, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8265), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("a11f380c-9fd0-4d10-b29f-c6191f168f17"), null, new DateTime(2024, 6, 22, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8687), "Alam", "egipt", null, "Sharia Ramsis", 296m, 0m, 0m, 0m, 174, new DateTime(2024, 6, 21, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8685), "Maresme", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("a15955d4-c921-4339-b944-8fb56c9e9d01"), null, new DateTime(2024, 6, 1, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9060), "Turecka", "turcja", null, "Bağdat Caddesi", 106m, 0m, 0m, 0m, 155, new DateTime(2024, 6, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9059), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("a1d7babe-4c18-4c77-a2b7-9a3bec7a9bd8"), null, new DateTime(2024, 6, 28, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8089), "Alam", "egipt", null, "Sharia Tahrir", 157m, 0m, 0m, 0m, 197, new DateTime(2024, 6, 27, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8088), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("a21b5a33-280f-4565-a6bb-d6c3f87d4a01"), null, new DateTime(2024, 8, 19, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8059), "Maresme", "hiszpania", null, "Paseo del Prado", 179m, 0m, 0m, 0m, 150, new DateTime(2024, 8, 19, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8059), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("a21d1947-ef9c-4a33-a169-c8e67b5436a2"), null, new DateTime(2024, 7, 24, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9089), "Vlora", "albania", null, "Rruga 28 Nentori", 62m, 0m, 0m, 0m, 181, new DateTime(2024, 7, 24, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9088), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("a2e6ff82-8320-49b0-8fee-640629e66014"), null, new DateTime(2024, 8, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9082), "Riwiera", "chorwacja", null, "Maksimirska ulica", 134m, 0m, 0m, 0m, 131, new DateTime(2024, 8, 12, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9081), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("a44f35ac-6036-40cf-aa25-f75d5ecd2162"), null, new DateTime(2024, 6, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7732), "Turecka", "turcja", null, "Halaskargazi Caddesi", 71m, 0m, 0m, 0m, 140, new DateTime(2024, 6, 10, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7731), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("a55edcc0-1683-472f-941b-966d233ce7f3"), null, new DateTime(2024, 6, 20, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8499), "Peloponez", "grecja", null, "Leoforos Alexandras", 147m, 0m, 0m, 0m, 151, new DateTime(2024, 6, 19, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8499), "Alam", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("a57aeef3-bc57-4e9a-85c5-2faf5f46eaa6"), null, new DateTime(2024, 8, 14, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7501), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 199m, 0m, 0m, 0m, 51, new DateTime(2024, 8, 13, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7501), "Kalabria", "wlochy", null, "Via Veneto", "Bus" },
                    { new Guid("a60dc203-fd4a-4413-8efa-ebbaeaa7a05a"), null, new DateTime(2024, 8, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9647), "Turecka", "turcja", null, "Bağdat Caddesi", 187m, 0m, 0m, 0m, 58, new DateTime(2024, 8, 18, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9647), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a75bc8dd-7b43-44b2-bd48-4801d9d7330f"), null, new DateTime(2024, 7, 28, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9780), "Riwiera", "chorwacja", null, "Maksimirska ulica", 156m, 0m, 0m, 0m, 103, new DateTime(2024, 7, 28, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9779), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("a7cedf1c-1589-44f7-828c-68830baa2e5c"), null, new DateTime(2024, 8, 18, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7837), "Alam", "egipt", null, "Sharia Tahrir", 251m, 0m, 0m, 0m, 122, new DateTime(2024, 8, 18, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7836), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("a8459a13-c37a-4df4-80f1-de57cd27e828"), null, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7336), "Brava", "hiszpania", null, "Calle de Alcalá", 90m, 0m, 0m, 0m, 90, new DateTime(2024, 6, 1, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7335), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Train" },
                    { new Guid("a8ce79f9-3129-4ee6-85f6-7236b4a7df64"), null, new DateTime(2024, 6, 9, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8074), "Kalabria", "wlochy", null, "Via Nazionale", 101m, 0m, 0m, 0m, 184, new DateTime(2024, 6, 9, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8073), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("a95691a7-8dd8-498f-a5f8-e9438190a00e"), null, new DateTime(2024, 6, 3, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8070), "Maresme", "hiszpania", null, "Paseo del Prado", 151m, 0m, 0m, 0m, 200, new DateTime(2024, 6, 3, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8069), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("a9881247-e17f-4274-a1ce-cf3c750026d8"), null, new DateTime(2024, 8, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9880), "Turecka", "turcja", null, "Bağdat Caddesi", 194m, 0m, 0m, 0m, 184, new DateTime(2024, 8, 11, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9880), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("a9a59904-e8e5-4361-8b09-00cab5b301ed"), null, new DateTime(2024, 6, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8825), "Kalabria", "wlochy", null, "Via del Corso", 54m, 0m, 0m, 0m, 130, new DateTime(2024, 6, 26, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8824), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("a9f447cb-43cd-478f-a18c-c9132704535d"), null, new DateTime(2024, 7, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9530), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 225m, 0m, 0m, 0m, 122, new DateTime(2024, 7, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9529), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("aa707255-1c8b-4f0c-8fb4-6aab6d26cef6"), null, new DateTime(2024, 7, 29, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7518), "Vlora", "albania", null, "Rruga e Kavajes", 193m, 0m, 0m, 0m, 115, new DateTime(2024, 7, 29, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7517), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("aae77c87-a74e-4bef-af95-f6a5fe4eed7e"), null, new DateTime(2024, 8, 20, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8930), "Durres", "albania", null, "Rruga e Dibres", 94m, 0m, 0m, 0m, 194, new DateTime(2024, 8, 20, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8929), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("abcdde70-976c-42cb-a755-326341776858"), null, new DateTime(2024, 5, 30, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9669), "Heraklion", "grecja", null, "Plateia Syntagmatos", 244m, 0m, 0m, 0m, 160, new DateTime(2024, 5, 30, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9668), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("ac0855e4-8a2a-4550-ba8e-0a4ef7474683"), null, new DateTime(2024, 6, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9676), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 65m, 0m, 0m, 0m, 109, new DateTime(2024, 6, 8, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9675), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("ad17377b-748b-4579-a06d-9278ddef16cc"), null, new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9876), "Alam", "egipt", null, "Sharia Tahrir", 275m, 0m, 0m, 0m, 50, new DateTime(2024, 8, 15, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9875), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("ad69173c-4a9a-420d-858d-6c3b3622dd31"), null, new DateTime(2024, 8, 26, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9423), "Almeria", "hiszpania", null, "Paseo del Prado", 67m, 0m, 0m, 0m, 117, new DateTime(2024, 8, 25, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9423), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("ad99ce06-1b58-42ba-85ea-29c407ce3ba8"), null, new DateTime(2024, 8, 2, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8386), "Almeria", "hiszpania", null, "Paseo del Prado", 57m, 0m, 0m, 0m, 181, new DateTime(2024, 8, 2, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8385), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("adf0f38f-1b13-43c2-ad27-7892204127ee"), null, new DateTime(2024, 8, 17, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9491), "Turecka", "turcja", null, "Atatürk Caddesi", 79m, 0m, 0m, 0m, 128, new DateTime(2024, 8, 17, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9490), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Bus" },
                    { new Guid("ae44efa6-7c98-4b7b-9a4b-14bb0d74ee0c"), null, new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9794), "Turecka", "turcja", null, "Atatürk Caddesi", 282m, 0m, 0m, 0m, 120, new DateTime(2024, 5, 30, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9794), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Train" },
                    { new Guid("ae82cdda-d763-4e06-a285-f2b04b69c950"), null, new DateTime(2024, 7, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9788), "Turecka", "turcja", null, "Atatürk Caddesi", 186m, 0m, 0m, 0m, 149, new DateTime(2024, 7, 16, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9787), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("aefc60ae-591e-43e0-967b-cd887db99a85"), null, new DateTime(2024, 7, 4, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8632), "Sheikh", "egipt", null, "Sharia Tahrir", 140m, 0m, 0m, 0m, 98, new DateTime(2024, 7, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8631), "Brava", "hiszpania", null, "Calle de Alcalá", "Train" },
                    { new Guid("afb32130-ed98-4156-a386-835398ec38c5"), null, new DateTime(2024, 6, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8218), "Alam", "egipt", null, "Sharia Ramsis", 56m, 0m, 0m, 0m, 135, new DateTime(2024, 6, 6, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8218), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("b037b585-75a7-4323-b169-a53d34164ba0"), null, new DateTime(2024, 6, 19, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7883), "Peloponez", "grecja", null, "Leoforos Alexandras", 260m, 0m, 0m, 0m, 179, new DateTime(2024, 6, 19, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7882), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("b03e578a-a8e7-4897-a56e-85747e3492e1"), null, new DateTime(2024, 7, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(7529), "Alam", "egipt", null, "Sharia Tahrir", 130m, 0m, 0m, 0m, 91, new DateTime(2024, 7, 20, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7528), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("b105916c-1cd8-4b5f-ba53-e8b65b784781"), null, new DateTime(2024, 6, 17, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7736), "Durres", "albania", null, "Rruga e Dibres", 276m, 0m, 0m, 0m, 124, new DateTime(2024, 6, 17, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7735), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("b11d5988-a9c1-4ff9-959d-8a37eee6a16f"), null, new DateTime(2024, 6, 11, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7423), "Turecka", "turcja", null, "Atatürk Caddesi", 167m, 0m, 0m, 0m, 163, new DateTime(2024, 6, 11, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7422), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("b1840605-9112-4b75-b448-40fb0ec60f84"), null, new DateTime(2024, 6, 2, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9655), "Vlora", "albania", null, "Rruga e Kavajes", 187m, 0m, 0m, 0m, 51, new DateTime(2024, 6, 2, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9654), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("b18af85e-eb2c-4a0f-a0e9-1ad826c44ae3"), null, new DateTime(2024, 6, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8669), "Turecka", "turcja", null, "Bağdat Caddesi", 268m, 0m, 0m, 0m, 67, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8669), "Sheikh", "egipt", null, "Sharia Ramsis", "Plane" },
                    { new Guid("b235e1cb-6627-4a61-bbfb-c46004f7ad67"), null, new DateTime(2024, 7, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8085), "Brava", "hiszpania", null, "Calle Mayor", 153m, 0m, 0m, 0m, 147, new DateTime(2024, 7, 7, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8084), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("b24e45c1-dda5-4d76-a8db-7d127dd3d579"), null, new DateTime(2024, 8, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9526), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 190m, 0m, 0m, 0m, 110, new DateTime(2024, 8, 3, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9525), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("b31a2c20-a402-4b40-bf04-49e28bd7c529"), null, new DateTime(2024, 8, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7437), "Durres", "albania", null, "Rruga e Dibres", 173m, 0m, 0m, 0m, 94, new DateTime(2024, 8, 15, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7437), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("b364c06a-bf57-4174-9654-09389fd63ce2"), null, new DateTime(2024, 8, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8525), "Peloponez", "grecja", null, "Leoforos Alexandras", 202m, 0m, 0m, 0m, 102, new DateTime(2024, 8, 12, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8524), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("b38b8e22-f21f-42f5-845f-ed150242de43"), null, new DateTime(2024, 6, 21, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8247), "Durres", "albania", null, "Rruga Abdyl Frasheri", 164m, 0m, 0m, 0m, 159, new DateTime(2024, 6, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8246), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("b3f89e0a-e126-4039-a94c-906b588a23a3"), null, new DateTime(2024, 7, 4, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9784), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 115m, 0m, 0m, 0m, 83, new DateTime(2024, 7, 4, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9783), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("b4a5b21c-2689-4531-b789-28e69d67ee37"), null, new DateTime(2024, 7, 24, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9683), "Sheikh", "egipt", null, "Sharia Salah Salem", 154m, 0m, 0m, 0m, 194, new DateTime(2024, 7, 23, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9683), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("b4b96268-683e-4f5f-9a0d-70521a0826f6"), null, new DateTime(2024, 6, 25, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8454), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 72m, 0m, 0m, 0m, 69, new DateTime(2024, 6, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8454), "Kalabria", "wlochy", null, "Via Nazionale", "Plane" },
                    { new Guid("b5b793fc-362d-483c-84c2-cd3e1d9fc2f9"), null, new DateTime(2024, 8, 5, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7830), "Durres", "albania", null, "Bulevardi Bajram Curri", 89m, 0m, 0m, 0m, 133, new DateTime(2024, 8, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7829), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("b6472eea-7aa9-404d-8aa7-bf5d4aee1f01"), null, new DateTime(2024, 6, 5, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7511), "Alam", "egipt", null, "Sharia Tahrir", 197m, 0m, 0m, 0m, 170, new DateTime(2024, 6, 5, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7511), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("b66a4919-9847-4560-93f4-b4ad2c52be53"), null, new DateTime(2024, 6, 28, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7714), "Riwiera", "chorwacja", null, "Maksimirska ulica", 172m, 0m, 0m, 0m, 158, new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7713), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("b6d3dbf6-0ae0-4829-932d-647be411eef6"), null, new DateTime(2024, 6, 18, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9842), "Durres", "albania", null, "Rruga Abdyl Frasheri", 192m, 0m, 0m, 0m, 99, new DateTime(2024, 6, 18, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9841), "Luz", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("b74a5dd7-dd41-4000-b577-68e930eb1591"), null, new DateTime(2024, 6, 19, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8270), "Durres", "albania", null, "Rruga Abdyl Frasheri", 194m, 0m, 0m, 0m, 68, new DateTime(2024, 6, 19, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8269), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("b860d134-f4ad-410c-a3a5-30593b20c7f9"), null, new DateTime(2024, 5, 31, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9221), "Durres", "albania", null, "Bulevardi Bajram Curri", 107m, 0m, 0m, 0m, 161, new DateTime(2024, 5, 31, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9220), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("b8962418-ec3b-4709-baf3-b50489cd30e2"), null, new DateTime(2024, 6, 14, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7876), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 297m, 0m, 0m, 0m, 80, new DateTime(2024, 6, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7875), "Brava", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("b8982d83-7350-41e9-8319-11ff2b9bb87b"), null, new DateTime(2024, 8, 18, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7628), "Heraklion", "grecja", null, "Plateia Syntagmatos", 179m, 0m, 0m, 0m, 109, new DateTime(2024, 8, 18, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7628), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("b979a01f-7d64-45dd-be89-45bc98784f1d"), null, new DateTime(2024, 6, 29, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9571), "Turecka", "turcja", null, "Halaskargazi Caddesi", 203m, 0m, 0m, 0m, 80, new DateTime(2024, 6, 28, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9570), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("ba5225a0-8ae6-45e1-ab60-b59fe1cf2d2b"), null, new DateTime(2024, 8, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8681), "Turecka", "turcja", null, "Atatürk Caddesi", 89m, 0m, 0m, 0m, 146, new DateTime(2024, 8, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8680), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("bb51b5d8-0ea4-4566-98dd-27a09df96869"), null, new DateTime(2024, 8, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9318), "Kalabria", "wlochy", null, "Via del Corso", 185m, 0m, 0m, 0m, 171, new DateTime(2024, 7, 31, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(9317), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("bb861c73-42c2-42aa-9eed-d95f184b6596"), null, new DateTime(2024, 6, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9427), "Kalabria", "wlochy", null, "Via Nazionale", 92m, 0m, 0m, 0m, 170, new DateTime(2024, 6, 11, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9426), "Turecka", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("bb93a3b5-a5e1-45bb-9751-431696522daf"), null, new DateTime(2024, 8, 20, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8492), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 78m, 0m, 0m, 0m, 145, new DateTime(2024, 8, 20, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8491), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("bbb57a2a-7a93-429e-970c-d5596bce50ad"), null, new DateTime(2024, 6, 19, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8837), "Nero", "grecja", null, "Leoforos Alexandras", 254m, 0m, 0m, 0m, 175, new DateTime(2024, 6, 19, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8836), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("bc085529-1884-4d44-b550-51750535eaeb"), null, new DateTime(2024, 6, 7, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9419), "Brava", "hiszpania", null, "Gran Vía", 95m, 0m, 0m, 0m, 66, new DateTime(2024, 6, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9419), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Train" },
                    { new Guid("bc85b7f0-31b1-4905-b332-1b8eb085dc9b"), null, new DateTime(2024, 8, 22, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9854), "Turecka", "turcja", null, "Atatürk Caddesi", 129m, 0m, 0m, 0m, 114, new DateTime(2024, 8, 21, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9853), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("bc912406-b8d7-442c-8fcd-d22a72236e3d"), null, new DateTime(2024, 6, 17, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9498), "Sheikh", "egipt", null, "Sharia Salah Salem", 246m, 0m, 0m, 0m, 167, new DateTime(2024, 6, 16, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9497), "Durres", "albania", null, "Bulevardi Bajram Curri", "Train" },
                    { new Guid("bd3f046f-87aa-4c53-afa7-85c99bfb6ffa"), null, new DateTime(2024, 8, 12, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8310), "Kalabria", "wlochy", null, "Via Nazionale", 274m, 0m, 0m, 0m, 64, new DateTime(2024, 8, 12, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8309), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("be924219-9c18-4a94-a55f-58c3a5a4a8b6"), null, new DateTime(2024, 8, 1, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8303), "Heraklion", "grecja", null, "Plateia Syntagmatos", 81m, 0m, 0m, 0m, 200, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8302), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("bed94fb9-2159-47f4-9eb0-2a3f933ce6ba"), null, new DateTime(2024, 8, 26, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(7887), "Vlora", "albania", null, "Rruga e Kavajes", 280m, 0m, 0m, 0m, 59, new DateTime(2024, 8, 25, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7886), "Marmaris", "turcja", null, "Bağdat Caddesi", "Train" },
                    { new Guid("bfb893a8-da11-4a25-979b-a4303e902d7e"), null, new DateTime(2024, 7, 4, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8280), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 132m, 0m, 0m, 0m, 173, new DateTime(2024, 7, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8279), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("c032ba25-f8e0-4a21-8459-4d9190430b01"), null, new DateTime(2024, 7, 12, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8110), "Sheikh", "egipt", null, "Sharia Tahrir", 278m, 0m, 0m, 0m, 181, new DateTime(2024, 7, 12, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8109), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("c041c9fd-acbd-464f-beec-5f8a19b2d3ee"), null, new DateTime(2024, 7, 28, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8897), "Riwiera", "chorwacja", null, "Maksimirska ulica", 117m, 0m, 0m, 0m, 67, new DateTime(2024, 7, 28, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8897), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Plane" },
                    { new Guid("c1401c7f-3962-42f8-876e-ad652949ef6f"), null, new DateTime(2024, 8, 25, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8226), "Alam", "egipt", null, "Sharia Tahrir", 137m, 0m, 0m, 0m, 196, new DateTime(2024, 8, 25, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8225), "Olimpijska", "grecja", null, "Plateia Syntagmatos", "Train" },
                    { new Guid("c2b96ef7-a17a-487c-a906-abd1d9eb2bc2"), null, new DateTime(2024, 6, 26, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(7632), "Kalabria", "wlochy", null, "Via Veneto", 244m, 0m, 0m, 0m, 191, new DateTime(2024, 6, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7631), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("c2d14423-1f0f-47b5-aa7f-e47d02f13b80"), null, new DateTime(2024, 6, 24, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7930), "Durres", "albania", null, "Rruga Abdyl Frasheri", 135m, 0m, 0m, 0m, 68, new DateTime(2024, 6, 24, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7929), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("c3453372-f06d-4a9f-a754-9752e5c61306"), null, new DateTime(2024, 6, 15, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8430), "Brava", "hiszpania", null, "Calle Mayor", 242m, 0m, 0m, 0m, 171, new DateTime(2024, 6, 14, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8428), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("c3455c55-4397-4afd-9ab7-6e359e91565d"), null, new DateTime(2024, 5, 29, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9776), "Marmaris", "turcja", null, "Bağdat Caddesi", 185m, 0m, 0m, 0m, 53, new DateTime(2024, 5, 29, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(9775), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("c34f1509-b072-4adb-af8a-9901af3911f9"), null, new DateTime(2024, 7, 5, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8390), "Turecka", "turcja", null, "Atatürk Caddesi", 263m, 0m, 0m, 0m, 180, new DateTime(2024, 7, 5, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8389), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("c39a7834-c82d-4b1d-b8b3-6a6bd64368b3"), null, new DateTime(2024, 8, 13, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8729), "Luz", "hiszpania", null, "Calle Mayor", 223m, 0m, 0m, 0m, 114, new DateTime(2024, 8, 13, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8728), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("c43a09a3-59e0-4a17-aa81-a7f6ceaeb7da"), null, new DateTime(2024, 7, 28, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8321), "Durres", "albania", null, "Bulevardi Bajram Curri", 126m, 0m, 0m, 0m, 58, new DateTime(2024, 7, 28, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8320), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("c5ec1c28-e1a0-4a87-b679-91a4e7fab258"), null, new DateTime(2024, 7, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8121), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 51m, 0m, 0m, 0m, 131, new DateTime(2024, 7, 4, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8120), "Turecka", "turcja", null, "Atatürk Caddesi", "Bus" },
                    { new Guid("c70a6ccb-2dc9-4536-ace2-f4ac5ca576dc"), null, new DateTime(2024, 7, 4, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7302), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 262m, 0m, 0m, 0m, 60, new DateTime(2024, 7, 4, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7300), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("c914f033-2bf9-4738-a2c9-67f10e70f777"), null, new DateTime(2024, 7, 28, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8915), "Kalabria", "wlochy", null, "Via Veneto", 197m, 0m, 0m, 0m, 149, new DateTime(2024, 7, 27, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8914), "Vlora", "albania", null, "Rruga 28 Nentori", "Train" },
                    { new Guid("c93171c9-1aa2-4910-ba0d-68b4699f30b6"), null, new DateTime(2024, 7, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8210), "Luz", "hiszpania", null, "Calle Mayor", 54m, 0m, 0m, 0m, 102, new DateTime(2024, 7, 26, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8210), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("c95f54ab-28e3-424b-bf4d-beefba85f75d"), null, new DateTime(2024, 6, 22, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7505), "Turecka", "turcja", null, "Atatürk Caddesi", 239m, 0m, 0m, 0m, 129, new DateTime(2024, 6, 22, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(7504), "Nero", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("c9b9a29c-b7f6-43d9-8cce-bcb60ef45b8b"), null, new DateTime(2024, 6, 13, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(7743), "Marmaris", "turcja", null, "Bağdat Caddesi", 207m, 0m, 0m, 0m, 83, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7743), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", "Bus" },
                    { new Guid("ca15c807-831e-4d66-a75d-2dd07cd4b9f1"), null, new DateTime(2024, 8, 16, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8415), "Nero", "grecja", null, "Leoforos Alexandras", 131m, 0m, 0m, 0m, 148, new DateTime(2024, 8, 16, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8414), "Kalabria", "wlochy", null, "Via del Corso", "Plane" },
                    { new Guid("ca35f4ef-e95b-4539-93b1-c1a7b926d58b"), null, new DateTime(2024, 6, 4, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8299), "Durres", "albania", null, "Rruga e Dibres", 123m, 0m, 0m, 0m, 159, new DateTime(2024, 6, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8299), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("ca8ae0b5-2c4e-446d-9b35-2936eecf1c08"), null, new DateTime(2024, 7, 1, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9408), "Brava", "hiszpania", null, "Calle Mayor", 250m, 0m, 0m, 0m, 186, new DateTime(2024, 7, 1, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9407), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("cb793ea4-6c1c-4100-8b24-c69fd8787923"), null, new DateTime(2024, 6, 19, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8324), "Olimpijska", "grecja", null, "Plateia Syntagmatos", 211m, 0m, 0m, 0m, 165, new DateTime(2024, 6, 18, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(8323), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("cbc9845c-c726-413c-b3b0-76bd04fe4b6b"), null, new DateTime(2024, 6, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7670), "Kalabria", "wlochy", null, "Via Nazionale", 51m, 0m, 0m, 0m, 152, new DateTime(2024, 6, 12, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7669), "Durres", "albania", null, "Bulevardi Bajram Curri", "Plane" },
                    { new Guid("cc311c98-288f-4cbc-b480-7f63a42bae2e"), null, new DateTime(2024, 8, 2, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7826), "Kalabria", "wlochy", null, "Via del Corso", 231m, 0m, 0m, 0m, 115, new DateTime(2024, 8, 2, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7825), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("cd1dcc5b-7546-4b47-a8b0-43c927756735"), null, new DateTime(2024, 7, 14, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7310), "Sheikh", "egipt", null, "Sharia Tahrir", 285m, 0m, 0m, 0m, 123, new DateTime(2024, 7, 14, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7308), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("cd3f24c0-fc6f-4297-8688-4edbc941fa2e"), null, new DateTime(2024, 6, 28, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9014), "Riwiera", "chorwacja", null, "Maksimirska ulica", 157m, 0m, 0m, 0m, 179, new DateTime(2024, 6, 28, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9013), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("cd92060d-6fb6-448c-815d-865c8d300015"), null, new DateTime(2024, 6, 1, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9100), "Durres", "albania", null, "Bulevardi Bajram Curri", 56m, 0m, 0m, 0m, 126, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9100), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("cdc1a185-0b73-4e9f-b96f-11dd7b59d2c2"), null, new DateTime(2024, 8, 26, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8436), "Riwiera", "chorwacja", null, "Kapucinska ulica", 151m, 0m, 0m, 0m, 155, new DateTime(2024, 8, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8435), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("ced5584b-bc84-43d2-ad86-1d8345db0236"), null, new DateTime(2024, 8, 6, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8382), "Alam", "egipt", null, "Sharia Tahrir", 118m, 0m, 0m, 0m, 58, new DateTime(2024, 8, 6, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8381), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("cf4cfd11-aeaa-4536-87aa-d0384bc0f98e"), null, new DateTime(2024, 6, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8129), "Durres", "albania", null, "Rruga e Dibres", 77m, 0m, 0m, 0m, 172, new DateTime(2024, 6, 13, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8128), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("cfb0d9fb-3c91-44b0-b9a6-14f6ccf16ea3"), null, new DateTime(2024, 7, 17, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9697), "Durres", "albania", null, "Bulevardi Bajram Curri", 235m, 0m, 0m, 0m, 179, new DateTime(2024, 7, 17, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9696), "Peloponez", "grecja", null, "Leoforos Alexandras", "Bus" },
                    { new Guid("d06f3944-5e5f-424c-b2db-cc1c214f3643"), null, new DateTime(2024, 6, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9640), "Turecka", "turcja", null, "Atatürk Caddesi", 174m, 0m, 0m, 0m, 152, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9639), "Sheikh", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("d1a292ff-8e0a-4ff2-9a66-542646aed582"), null, new DateTime(2024, 6, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7811), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 72m, 0m, 0m, 0m, 200, new DateTime(2024, 6, 5, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7810), "Maresme", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("d21e860f-c709-46d9-b4e8-72fe454666ae"), null, new DateTime(2024, 6, 11, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8699), "Alam", "egipt", null, "Sharia Ramsis", 139m, 0m, 0m, 0m, 156, new DateTime(2024, 6, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8698), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("d269e91e-2930-4045-b693-a3d3a00e5ce1"), null, new DateTime(2024, 7, 7, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7891), "Almeria", "hiszpania", null, "Paseo del Prado", 199m, 0m, 0m, 0m, 81, new DateTime(2024, 7, 7, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7890), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("d27bde5f-50d9-4e9b-9cfa-ff2f9572540a"), null, new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8195), "Heraklion", "grecja", null, "Plateia Syntagmatos", 141m, 0m, 0m, 0m, 195, new DateTime(2024, 8, 1, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8194), "Brava", "hiszpania", null, "Paseo del Prado", "Train" },
                    { new Guid("d2ea5717-3c2d-4877-b11f-4e77621c1108"), null, new DateTime(2024, 8, 18, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9261), "Brava", "hiszpania", null, "Gran Vía", 184m, 0m, 0m, 0m, 118, new DateTime(2024, 8, 17, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9260), "Maresme", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("d3021f38-eb66-43cd-a371-cba97886d388"), null, new DateTime(2024, 5, 29, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9404), "Kalabria", "wlochy", null, "Via Veneto", 123m, 0m, 0m, 0m, 69, new DateTime(2024, 5, 29, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9404), "Kalabria", "wlochy", null, "Via Veneto", "Train" },
                    { new Guid("d30d1e09-c47d-45af-b18d-9e809b0e465b"), null, new DateTime(2024, 8, 12, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9037), "Alam", "egipt", null, "Sharia Tahrir", 181m, 0m, 0m, 0m, 120, new DateTime(2024, 8, 11, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9036), "Almeria", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("d411672e-aeb1-4635-a5bc-631c9bd2e046"), null, new DateTime(2024, 6, 12, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8336), "Riwiera", "chorwacja", null, "Kapucinska ulica", 159m, 0m, 0m, 0m, 113, new DateTime(2024, 6, 11, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8335), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("d5376653-8719-46df-b2be-dffba353ae17"), null, new DateTime(2024, 6, 5, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9609), "Sheikh", "egipt", null, "Sharia Salah Salem", 274m, 0m, 0m, 0m, 107, new DateTime(2024, 6, 5, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9609), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("d6e410f5-4882-4564-9997-988abd6b15ae"), null, new DateTime(2024, 7, 31, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8184), "Durres", "albania", null, "Bulevardi Bajram Curri", 270m, 0m, 0m, 0m, 81, new DateTime(2024, 7, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8183), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Bus" },
                    { new Guid("d72f7a38-ff08-4a13-92ce-1aae5adb2ba9"), null, new DateTime(2024, 8, 21, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8894), "Kalabria", "wlochy", null, "Via del Corso", 179m, 0m, 0m, 0m, 152, new DateTime(2024, 8, 21, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8893), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("d7b1b7de-2d60-4a4c-a8ab-88c8e84654e1"), null, new DateTime(2024, 7, 4, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(8418), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", 228m, 0m, 0m, 0m, 131, new DateTime(2024, 7, 3, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8417), "Alam", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("d7c20fd7-9f16-4723-a06f-db642da1e2e3"), null, new DateTime(2024, 6, 19, 20, 40, 9, 514, DateTimeKind.Utc).AddTicks(7722), "Alam", "egipt", null, "Sharia Tahrir", 199m, 0m, 0m, 0m, 89, new DateTime(2024, 6, 19, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7721), "Durres", "albania", null, "Rruga e Dibres", "Plane" },
                    { new Guid("d84f6eee-4957-449f-8897-aae10343c51b"), null, new DateTime(2024, 7, 11, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8622), "Riwiera", "chorwacja", null, "Maksimirska ulica", 136m, 0m, 0m, 0m, 147, new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8621), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("d88db3df-fde9-4dc1-a835-2bc113b28b39"), null, new DateTime(2024, 8, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8614), "Turecka", "turcja", null, "Atatürk Caddesi", 242m, 0m, 0m, 0m, 62, new DateTime(2024, 8, 21, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8613), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("d89f0385-0847-4456-8ecc-7d35595d7ef5"), null, new DateTime(2024, 6, 25, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9285), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 137m, 0m, 0m, 0m, 57, new DateTime(2024, 6, 25, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9285), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("d8cd30f7-8c94-46a2-ba94-2a36ca222089"), null, new DateTime(2024, 8, 16, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8295), "Alam", "egipt", null, "Sharia Tahrir", 153m, 0m, 0m, 0m, 130, new DateTime(2024, 8, 16, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8294), "Brava", "hiszpania", null, "Calle Mayor", "Plane" },
                    { new Guid("d90a13b6-fb79-45da-ad0c-49496d5b6dd7"), null, new DateTime(2024, 8, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8263), "Sheikh", "egipt", null, "Sharia Salah Salem", 127m, 0m, 0m, 0m, 170, new DateTime(2024, 8, 20, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(8262), "Alam", "egipt", null, "Sharia Tahrir", "Bus" },
                    { new Guid("d9feffcf-7c5c-49b2-ab16-ff78905dc047"), null, new DateTime(2024, 6, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8652), "Durres", "albania", null, "Bulevardi Bajram Curri", 185m, 0m, 0m, 0m, 145, new DateTime(2024, 6, 11, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8651), "Alam", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("dc5176d7-15b2-4636-a6ae-39718efb1824"), null, new DateTime(2024, 7, 13, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9074), "Kalabria", "wlochy", null, "Via Veneto", 255m, 0m, 0m, 0m, 126, new DateTime(2024, 7, 12, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(9074), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("ddd34863-5469-4069-a0a6-23913a8ccb2d"), null, new DateTime(2024, 6, 25, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9661), "Kalabria", "wlochy", null, "Via Veneto", 172m, 0m, 0m, 0m, 155, new DateTime(2024, 6, 25, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9660), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("de177b2a-2886-4f13-8263-f53646bfe951"), null, new DateTime(2024, 6, 15, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9093), "Kalabria", "wlochy", null, "Via del Corso", 196m, 0m, 0m, 0m, 55, new DateTime(2024, 6, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9092), "Sheikh", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("de86007a-f314-4104-bfba-4e54f0a87de1"), null, new DateTime(2024, 7, 11, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8332), "Durres", "albania", null, "Rruga Abdyl Frasheri", 99m, 0m, 0m, 0m, 153, new DateTime(2024, 7, 11, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8331), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("df4d2f4a-dba5-4ca9-b9bc-41cfdb3d854b"), null, new DateTime(2024, 6, 23, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7848), "Durres", "albania", null, "Rruga e Dibres", 245m, 0m, 0m, 0m, 178, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7847), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("df7753f0-5850-4ef4-9c81-8bc779482c18"), null, new DateTime(2024, 6, 24, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9446), "Alam", "egipt", null, "Sharia Ramsis", 83m, 0m, 0m, 0m, 136, new DateTime(2024, 6, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9445), "Turecka", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("df786801-3860-4eaf-bcd2-f88b12aac8de"), null, new DateTime(2024, 7, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(7706), "Nero", "grecja", null, "Leoforos Alexandras", 208m, 0m, 0m, 0m, 195, new DateTime(2024, 7, 20, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(7706), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Train" },
                    { new Guid("e0be5692-88d3-4b6e-b802-11a4da491193"), null, new DateTime(2024, 7, 25, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8200), "Durres", "albania", null, "Rruga Abdyl Frasheri", 51m, 0m, 0m, 0m, 140, new DateTime(2024, 7, 25, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8199), "Marmaris", "turcja", null, "Bağdat Caddesi", "Plane" },
                    { new Guid("e2232f0f-9107-42a2-aeae-c0105ef64245"), null, new DateTime(2024, 8, 24, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8481), "Riwiera", "chorwacja", null, "Kapucinska ulica", 289m, 0m, 0m, 0m, 98, new DateTime(2024, 8, 23, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8480), "Vlora", "albania", null, "Rruga e Kavajes", "Bus" },
                    { new Guid("e3b4613e-3efd-46fd-93cb-da08b9d77ea7"), null, new DateTime(2024, 7, 31, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(7819), "Marmaris", "turcja", null, "Bağdat Caddesi", 110m, 0m, 0m, 0m, 125, new DateTime(2024, 7, 31, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7818), "Kalabria", "wlochy", null, "Via Veneto", "Plane" },
                    { new Guid("e46c0049-9093-4c80-b831-3ab0fe3c8452"), null, new DateTime(2024, 7, 23, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8030), "Marmaris", "turcja", null, "Bağdat Caddesi", 259m, 0m, 0m, 0m, 152, new DateTime(2024, 7, 23, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8029), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("e4bcb530-0375-4005-bd68-bb92c943b1a3"), null, new DateTime(2024, 7, 12, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7411), "Vlora", "albania", null, "Rruga e Kavajes", 75m, 0m, 0m, 0m, 86, new DateTime(2024, 7, 12, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7410), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("e5d4ff5e-7dfc-470a-a3fc-beeb3934a42a"), null, new DateTime(2024, 6, 9, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9846), "Alam", "egipt", null, "Sharia Ramsis", 62m, 0m, 0m, 0m, 181, new DateTime(2024, 6, 9, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(9845), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("e65dd37c-79f3-48a6-83e6-8ccbbea0b61e"), null, new DateTime(2024, 7, 10, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7717), "Sheikh", "egipt", null, "Sharia Tahrir", 64m, 0m, 0m, 0m, 156, new DateTime(2024, 7, 10, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(7716), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("e69cfacb-43db-46f8-833a-941b862c9943"), null, new DateTime(2024, 7, 22, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9367), "Riwiera", "chorwacja", null, "Kapucinska ulica", 176m, 0m, 0m, 0m, 55, new DateTime(2024, 7, 22, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9366), "Kalabria", "wlochy", null, "Via del Corso", "Train" },
                    { new Guid("e83f1856-786a-4249-9d85-7978ac6bde03"), null, new DateTime(2024, 8, 26, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(7352), "Riwiera", "chorwacja", null, "Vukovarska ulica", 118m, 0m, 0m, 0m, 155, new DateTime(2024, 8, 26, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(7351), "Brava", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("e9013cd2-beea-4a83-a6b9-bc648b962271"), null, new DateTime(2024, 7, 4, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7844), "Sheikh", "egipt", null, "Sharia Ramsis", 207m, 0m, 0m, 0m, 112, new DateTime(2024, 7, 4, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7844), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Train" },
                    { new Guid("e9102871-63cc-4ec9-b35c-c859b55ee656"), null, new DateTime(2024, 6, 7, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(8608), "Durres", "albania", null, "Rruga Abdyl Frasheri", 249m, 0m, 0m, 0m, 155, new DateTime(2024, 6, 7, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8606), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Train" },
                    { new Guid("e9c21f51-2ddd-47c9-9fb9-4a2f61ac4241"), null, new DateTime(2024, 8, 3, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8828), "Alam", "egipt", null, "Sharia Ramsis", 239m, 0m, 0m, 0m, 140, new DateTime(2024, 8, 2, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(8827), "Sheikh", "egipt", null, "Sharia Salah Salem", "Plane" },
                    { new Guid("e9cd80b1-ed92-4fc9-a371-8489d27e53dc"), null, new DateTime(2024, 6, 18, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8259), "Sheikh", "egipt", null, "Sharia Tahrir", 190m, 0m, 0m, 0m, 126, new DateTime(2024, 6, 17, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8258), "Brava", "hiszpania", null, "Gran Vía", "Train" },
                    { new Guid("eb4e05e5-c20b-4c28-b63b-5f4f0a597994"), null, new DateTime(2024, 6, 4, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8989), "Nero", "grecja", null, "Leoforos Alexandras", 59m, 0m, 0m, 0m, 144, new DateTime(2024, 6, 4, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8988), "Durres", "albania", null, "Rruga e Dibres", "Bus" },
                    { new Guid("eb7050bf-3ef2-4a3f-a465-50a7f4269249"), null, new DateTime(2024, 8, 22, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8639), "Kalabria", "wlochy", null, "Via Veneto", 198m, 0m, 0m, 0m, 84, new DateTime(2024, 8, 21, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8638), "Turecka", "turcja", null, "Halaskargazi Caddesi", "Plane" },
                    { new Guid("ebe37152-af8d-4f1f-ba13-2b43d710e62f"), null, new DateTime(2024, 7, 21, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8081), "Riwiera", "chorwacja", null, "Maksimirska ulica", 212m, 0m, 0m, 0m, 106, new DateTime(2024, 7, 21, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(8081), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("ec43faf9-c930-4da9-9637-8b39ed0de878"), null, new DateTime(2024, 7, 15, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9323), "Turecka", "turcja", null, "Atatürk Caddesi", 68m, 0m, 0m, 0m, 167, new DateTime(2024, 7, 15, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(9322), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("ec836db6-bed8-41bd-b99b-ac36b5c00807"), null, new DateTime(2024, 7, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8610), "Vlora", "albania", null, "Rruga 28 Nentori", 105m, 0m, 0m, 0m, 61, new DateTime(2024, 7, 20, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8610), "Vlora", "albania", null, "Rruga e Kavajes", "Plane" },
                    { new Guid("ecdccf72-938d-4fbf-a1ac-e5ca9d18a690"), null, new DateTime(2024, 8, 15, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8484), "Vlora", "albania", null, "Rruga e Kavajes", 238m, 0m, 0m, 0m, 181, new DateTime(2024, 8, 15, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(8484), "Durres", "albania", null, "Bulevardi Bajram Curri", "Bus" },
                    { new Guid("edb80cf0-d651-4838-8e60-917a193a8919"), null, new DateTime(2024, 5, 30, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(9115), "Vlora", "albania", null, "Rruga 28 Nentori", 297m, 0m, 0m, 0m, 168, new DateTime(2024, 5, 30, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(9114), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("edbac97d-02df-47f2-9dbe-ea21f11dcfc1"), null, new DateTime(2024, 8, 11, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(8187), "Kalabria", "wlochy", null, "Via del Corso", 109m, 0m, 0m, 0m, 53, new DateTime(2024, 8, 10, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(8187), "Brava", "hiszpania", null, "Calle de Alcalá", "Bus" },
                    { new Guid("edf5e8fe-e357-4184-818f-56ec7dbd5f96"), null, new DateTime(2024, 8, 3, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(8732), "Brava", "hiszpania", null, "Paseo del Prado", 286m, 0m, 0m, 0m, 113, new DateTime(2024, 8, 2, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(8732), "Luz", "hiszpania", null, "Calle Mayor", "Bus" },
                    { new Guid("ee547548-b1fd-4b57-b93a-5b15228b3b84"), null, new DateTime(2024, 7, 13, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(9687), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 173m, 0m, 0m, 0m, 90, new DateTime(2024, 7, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9686), "Sheikh", "egipt", null, "Sharia Ramsis", "Bus" },
                    { new Guid("ef18b709-576b-410d-97b6-6ee73ccbee94"), null, new DateTime(2024, 6, 17, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8891), "Riwiera", "chorwacja", null, "Kapucinska ulica", 125m, 0m, 0m, 0m, 95, new DateTime(2024, 6, 17, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8890), "Turecka", "turcja", null, "Atatürk Caddesi", "Train" },
                    { new Guid("ef5d2764-cdbc-4e73-b4ab-e4f4829e031d"), null, new DateTime(2024, 7, 16, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8821), "Durres", "albania", null, "Bulevardi Bajram Curri", 151m, 0m, 0m, 0m, 136, new DateTime(2024, 7, 16, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8820), "Alam", "egipt", null, "Sharia Tahrir", "Plane" },
                    { new Guid("ef9cd989-6426-4526-9fbb-a1e7a63953fd"), null, new DateTime(2024, 6, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9443), "Durres", "albania", null, "Rruga e Dibres", 243m, 0m, 0m, 0m, 176, new DateTime(2024, 6, 1, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9442), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("ef9e6208-1e7e-46d7-9992-df0e95f36997"), null, new DateTime(2024, 8, 24, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7333), "Nero", "grecja", null, "Leoforos Alexandras", 64m, 0m, 0m, 0m, 189, new DateTime(2024, 8, 24, 8, 40, 9, 514, DateTimeKind.Utc).AddTicks(7332), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", "Plane" },
                    { new Guid("f1391096-118a-425d-85e7-061b0bc904fe"), null, new DateTime(2024, 6, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9820), "Vlora", "albania", null, "Rruga e Kavajes", 59m, 0m, 0m, 0m, 101, new DateTime(2024, 6, 23, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9819), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("f19b9325-52e7-48e4-b9d2-1eda54c0178c"), null, new DateTime(2024, 8, 14, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7319), "Turecka", "turcja", null, "Bağdat Caddesi", 122m, 0m, 0m, 0m, 106, new DateTime(2024, 8, 14, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7318), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("f28786d5-f933-437d-8f12-02b39e684566"), null, new DateTime(2024, 6, 21, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8394), "Turecka", "turcja", null, "Atatürk Caddesi", 103m, 0m, 0m, 0m, 158, new DateTime(2024, 6, 20, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(8393), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" },
                    { new Guid("f2c17bf3-5d78-4b4d-a5e1-4204989266f4"), null, new DateTime(2024, 6, 5, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8063), "Sheikh", "egipt", null, "Sharia Tahrir", 151m, 0m, 0m, 0m, 57, new DateTime(2024, 6, 5, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(8062), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Bus" },
                    { new Guid("f2ddca4c-85a3-49a5-8467-0ee8e1ade35f"), null, new DateTime(2024, 8, 11, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(8222), "Sheikh", "egipt", null, "Sharia Ramsis", 275m, 0m, 0m, 0m, 164, new DateTime(2024, 8, 11, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(8221), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("f343fc73-f4e3-4e20-89da-775416f0a77f"), null, new DateTime(2024, 6, 24, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7547), "Turecka", "turcja", null, "Bağdat Caddesi", 97m, 0m, 0m, 0m, 160, new DateTime(2024, 6, 24, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7546), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Plane" },
                    { new Guid("f3efc6bb-7b93-47ae-9a35-35ea220e4dab"), null, new DateTime(2024, 7, 20, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9827), "Vlora", "albania", null, "Rruga 28 Nentori", 273m, 0m, 0m, 0m, 94, new DateTime(2024, 7, 20, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9826), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("f50159ac-d588-438a-9179-a3e957ea05e3"), null, new DateTime(2024, 7, 13, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(7487), "Turecka", "turcja", null, "Atatürk Caddesi", 166m, 0m, 0m, 0m, 84, new DateTime(2024, 7, 13, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7486), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("f513d749-5701-445b-87ef-91fa43bf3be5"), null, new DateTime(2024, 7, 11, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(9644), "Peloponez", "grecja", null, "Leoforos Alexandras", 257m, 0m, 0m, 0m, 117, new DateTime(2024, 7, 11, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9643), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("f64a0f75-4cdb-4a6d-9f7d-a119ecabf23b"), null, new DateTime(2024, 8, 23, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(7894), "Turecka", "turcja", null, "Atatürk Caddesi", 276m, 0m, 0m, 0m, 162, new DateTime(2024, 8, 23, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(7893), "Marmaris", "turcja", null, "Bağdat Caddesi", "Bus" },
                    { new Guid("f650cf3a-5255-4421-9233-45a82d82b0fc"), null, new DateTime(2024, 7, 9, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(8721), "Durres", "albania", null, "Bulevardi Bajram Curri", 115m, 0m, 0m, 0m, 62, new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8720), "Almeria", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("f6b44712-9df6-456e-967d-7c2ee35f2baa"), null, new DateTime(2024, 7, 6, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(9268), "Turecka", "turcja", null, "Atatürk Caddesi", 222m, 0m, 0m, 0m, 51, new DateTime(2024, 7, 6, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9267), "Brava", "hiszpania", null, "Paseo del Prado", "Plane" },
                    { new Guid("f6d85ea5-443c-4159-983a-1a34f3eec176"), null, new DateTime(2024, 6, 14, 15, 40, 9, 514, DateTimeKind.Utc).AddTicks(9205), "Durres", "albania", null, "Rruga Abdyl Frasheri", 65m, 0m, 0m, 0m, 175, new DateTime(2024, 6, 14, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9205), "Durres", "albania", null, "Rruga e Dibres", "Train" },
                    { new Guid("f761ba51-85f3-4d0c-b051-5afb5ecdecc4"), null, new DateTime(2024, 8, 22, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9628), "Alam", "egipt", null, "Sharia Tahrir", 139m, 0m, 0m, 0m, 101, new DateTime(2024, 8, 22, 0, 40, 9, 514, DateTimeKind.Utc).AddTicks(9627), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", "Plane" },
                    { new Guid("f7a94836-6f0b-429f-ad5e-70286cdf5cf2"), null, new DateTime(2024, 6, 2, 14, 40, 9, 514, DateTimeKind.Utc).AddTicks(9232), "Sheikh", "egipt", null, "Sharia Tahrir", 178m, 0m, 0m, 0m, 77, new DateTime(2024, 6, 2, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(9231), "Peloponez", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("f7df179b-1789-42a7-af10-65ed0813be11"), null, new DateTime(2024, 8, 13, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9393), "Alam", "egipt", null, "Sharia Tahrir", 182m, 0m, 0m, 0m, 190, new DateTime(2024, 8, 13, 5, 40, 9, 514, DateTimeKind.Utc).AddTicks(9392), "Nero", "grecja", null, "Leoforos Alexandras", "Plane" },
                    { new Guid("f8557a03-51e7-48cf-b118-f968e576d162"), null, new DateTime(2024, 6, 26, 19, 40, 9, 514, DateTimeKind.Utc).AddTicks(7525), "Durres", "albania", null, "Rruga e Dibres", 132m, 0m, 0m, 0m, 191, new DateTime(2024, 6, 26, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7524), "Brava", "hiszpania", null, "Paseo del Prado", "Bus" },
                    { new Guid("f869e496-aa7e-46ca-a773-9f8cab2f6970"), null, new DateTime(2024, 8, 9, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9701), "Durres", "albania", null, "Bulevardi Bajram Curri", 97m, 0m, 0m, 0m, 174, new DateTime(2024, 8, 9, 9, 40, 9, 514, DateTimeKind.Utc).AddTicks(9700), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Bus" },
                    { new Guid("f8ca9803-4765-4b8b-bbb1-25b77094b035"), null, new DateTime(2024, 7, 23, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(7856), "Vlora", "albania", null, "Rruga e Kavajes", 78m, 0m, 0m, 0m, 197, new DateTime(2024, 7, 23, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(7855), "Kalabria", "wlochy", null, "Via Nazionale", "Train" },
                    { new Guid("f97654d4-028d-40e7-a3b4-6b39bc217e4e"), null, new DateTime(2024, 6, 18, 23, 40, 9, 514, DateTimeKind.Utc).AddTicks(9264), "Heraklion", "grecja", null, "Plateia Syntagmatos", 172m, 0m, 0m, 0m, 103, new DateTime(2024, 6, 18, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(9264), "Luz", "hiszpania", null, "Calle Mayor", "Train" },
                    { new Guid("f97d7bc4-3057-48e1-ae87-44fedfe30857"), null, new DateTime(2024, 8, 2, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7483), "Alam", "egipt", null, "Sharia Tahrir", 152m, 0m, 0m, 0m, 134, new DateTime(2024, 8, 1, 21, 40, 9, 514, DateTimeKind.Utc).AddTicks(7482), "Alam", "egipt", null, "Sharia Ramsis", "Train" },
                    { new Guid("fa14b4de-d534-4067-8f86-4b61f2f65fb8"), null, new DateTime(2024, 6, 6, 16, 40, 9, 514, DateTimeKind.Utc).AddTicks(8878), "Nero", "grecja", null, "Leoforos Vasilissis Sofias", 164m, 0m, 0m, 0m, 184, new DateTime(2024, 6, 6, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(8877), "Sheikh", "egipt", null, "Sharia Salah Salem", "Train" },
                    { new Guid("fa205dfb-d174-4262-9012-87dc443bed50"), null, new DateTime(2024, 8, 21, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(8714), "Turecka", "turcja", null, "Bağdat Caddesi", 275m, 0m, 0m, 0m, 56, new DateTime(2024, 8, 21, 11, 40, 9, 514, DateTimeKind.Utc).AddTicks(8713), "Kalabria", "wlochy", null, "Via Nazionale", "Bus" },
                    { new Guid("fa37989a-2847-499b-8978-f79a42e5efbb"), null, new DateTime(2024, 8, 1, 13, 40, 9, 514, DateTimeKind.Utc).AddTicks(9249), "Chania", "grecja", null, "Leoforos Vasilissis Sofias", 279m, 0m, 0m, 0m, 127, new DateTime(2024, 8, 1, 10, 40, 9, 514, DateTimeKind.Utc).AddTicks(9249), "Riwiera", "chorwacja", null, "Vukovarska ulica", "Bus" },
                    { new Guid("fbb9cd22-59d5-43fd-a97e-6448308dc8c0"), null, new DateTime(2024, 6, 15, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(7642), "Vlora", "albania", null, "Rruga e Kavajes", 218m, 0m, 0m, 0m, 185, new DateTime(2024, 6, 15, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(7641), "Turecka", "turcja", null, "Atatürk Caddesi", "Plane" },
                    { new Guid("fcdd4bf0-1481-4972-92e6-03ab936d8243"), null, new DateTime(2024, 8, 17, 6, 40, 9, 514, DateTimeKind.Utc).AddTicks(9097), "Vlora", "albania", null, "Rruga e Kavajes", 251m, 0m, 0m, 0m, 141, new DateTime(2024, 8, 17, 3, 40, 9, 514, DateTimeKind.Utc).AddTicks(9096), "Riwiera", "chorwacja", null, "Trg bana Josipa Jelačića", "Plane" },
                    { new Guid("fe05be29-f5a4-4663-a7a6-fdd42ebdf766"), null, new DateTime(2024, 7, 9, 18, 40, 9, 514, DateTimeKind.Utc).AddTicks(8113), "Riwiera", "chorwacja", null, "Vukovarska ulica", 100m, 0m, 0m, 0m, 69, new DateTime(2024, 7, 9, 12, 40, 9, 514, DateTimeKind.Utc).AddTicks(8112), "Riwiera", "chorwacja", null, "Kapucinska ulica", "Plane" },
                    { new Guid("ff755268-742f-4a26-af73-73401c991cee"), null, new DateTime(2024, 7, 16, 2, 40, 9, 514, DateTimeKind.Utc).AddTicks(7429), "Luz", "hiszpania", null, "Calle Mayor", 91m, 0m, 0m, 0m, 51, new DateTime(2024, 7, 15, 22, 40, 9, 514, DateTimeKind.Utc).AddTicks(7429), "Sheikh", "egipt", null, "Sharia Tahrir", "Train" },
                    { new Guid("ffdd2c03-5a77-4bdb-90e3-83c7759deaf5"), null, new DateTime(2024, 6, 16, 4, 40, 9, 514, DateTimeKind.Utc).AddTicks(9599), "Alam", "egipt", null, "Sharia Tahrir", 137m, 0m, 0m, 0m, 82, new DateTime(2024, 6, 15, 17, 40, 9, 514, DateTimeKind.Utc).AddTicks(9598), "Riwiera", "chorwacja", null, "Maksimirska ulica", "Train" },
                    { new Guid("ffe06f8c-2681-4e0d-b3c4-d1a9ea89d847"), null, new DateTime(2024, 6, 4, 7, 40, 9, 514, DateTimeKind.Utc).AddTicks(8451), "Alam", "egipt", null, "Sharia Gamal Abdel Nasser", 171m, 0m, 0m, 0m, 99, new DateTime(2024, 6, 4, 1, 40, 9, 514, DateTimeKind.Utc).AddTicks(8450), "Durres", "albania", null, "Rruga Abdyl Frasheri", "Plane" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("00893056-15a0-4f78-9970-17ddb471e36b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("00f9b6b3-0a65-4dc0-9ed5-ec113d4a9895"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("01c4f44e-cd07-4fe1-8e2e-9e860694c4a5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("02414fa3-d48e-476c-9474-a95a38a91adb"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("03085164-80fe-4de9-9c4e-1f37407cf46a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0433b874-1bd0-4a09-bf45-511bf181b1b1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0461efda-320d-44d2-9c0d-4751b1505ba4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("053a6598-dcf6-4f2d-b21b-044446251b6c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("05b0c2dd-7a98-4582-b5c3-5b8f583b83d1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("06126004-e5b9-4f43-8887-50f27194ee36"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0626f293-d926-4e9f-91e3-1007a806857f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("066ceed3-7bf1-4d91-ac66-6e225203ac13"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("068e0096-0fca-467d-8e0b-1182144ec6f6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0771f6e2-f41f-4b3d-9913-34238c6c4d6b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("07b22677-a066-48e8-98ee-655dc7d86f10"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("07b7fa77-5869-492e-b871-1fdc4b15a503"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("07fe9823-fece-4e68-9630-6546111f93d6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("082f9c03-8296-4fcd-807d-711dea48489e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0841f17c-6b83-4ede-b890-b676e986c6c6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08429c83-a767-4f1e-b0a7-bfe977002342"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08eda514-0bc6-43c7-8938-7a0fa10dbc47"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0c020ccd-9d5f-4b16-8cad-eb572a067f3a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0c3aefbc-7f41-4e25-a3a3-bcfd707cd9a1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0cffef58-925b-42a1-8799-791f9605b420"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0d3e65eb-56ed-415f-a0b7-808415b62516"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0d5f9348-cc55-47c4-90f5-f54d7f1ff9c6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0f0ed66f-9acc-4402-b801-637624a4bd1b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0fdd580a-418b-4e8c-80c7-e902880c41b2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("108ef18c-ce3b-4417-ac33-a3133d31522a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("11777006-b3cf-4dff-9517-daab12acfb50"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("11d43bfa-24d4-4609-8c18-eba5530e874b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("12fa82b3-4cab-4eda-b3ba-f8425aef0e16"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("13366d6a-58cf-48a0-bde0-da651958ceaa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("142ddb73-72d7-49b7-b0dd-010ce8842435"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("14395779-bef4-4e7b-9afa-b36c93a49e27"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("14496b4a-2f93-4434-8765-3aefa25c1426"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("14f997e5-f8a9-46f2-aef0-2c219b582146"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("15b82b04-7515-451e-96c9-1e6b88f4550b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("15c7df23-c3c3-47fa-882a-ea75fc2a00ef"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("17214aff-8314-4ad3-89eb-1b6448ef610a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("17db8b38-32f3-4383-89d8-bd59a6b25d90"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("188fcf6c-b95b-4e8a-993a-b8917e0f949a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1abeb6d2-6e43-4f63-8251-1ec5cbe67776"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1b7272c7-9308-4c8d-970f-b82899d83b48"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1b9b4d65-dc4f-406d-afda-3e3ccf61da49"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1c8e2f4c-a8e8-4a80-a5b1-495ae1b05dbc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1cd55716-6307-4540-a566-82facab0636e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1d61bb51-c9ce-4771-85ad-05b283eaa248"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1d830cc7-4865-4bba-b289-453e6ce43eac"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1da4b2f0-d711-44bd-b2d8-803acc00759e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1df09754-f415-486a-abe5-815307fcea76"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1df0f007-3c19-4814-b55b-8ea813e4b85f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1e168de4-e097-4011-98d2-cd283d6a620b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1f4c56d7-a9e4-414e-ad1a-d01ba3a57496"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1f98b760-253f-443c-9800-617a355bed0f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1fa52beb-b833-48a5-b24b-9508ab2fa42e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2006bf18-515c-42c6-9f4f-1521046a1e0e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("202df9e0-4735-49e1-81dc-8fdc8215c5d2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("207a0ab8-5be6-42ef-a0f3-8f724bd28fd1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("20d4ec7a-0dec-4bae-9823-5d984de6f3af"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("211408d5-016a-4d37-8ce5-8b534c4f1c11"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("211f701d-0340-4ef7-991f-227ff727141a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("21d6ab9b-8571-4f77-9f61-3ccc9e708d02"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("23038dd0-a417-4144-ac78-ac0bdcf7a1e5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("23980b82-ac86-4720-99c8-30f7ceadd040"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2537118e-96b4-4898-bf53-d1eab09a50b4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("255b199c-547b-442b-8155-8bbb6bc257b4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("26be5b09-bae2-4d5d-8533-4562e7bca1bb"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("271613b4-cc5f-4f97-8dff-444b9bf8e5d2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("27f3ba34-2be4-41e8-8b90-bd216945ceac"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("28706770-883f-417f-bdef-a82c0c092cb4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("294e5378-a8f8-4611-a075-2cf09a8a7bd4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("29f240b8-510e-4d7b-b623-f007bbe38a4b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2acece12-e592-4703-a127-29c74f24888c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2b6e6ae7-9a26-48ff-8fa7-9c1acccb61b7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2bc4ea9c-f5c7-48e5-9b9d-c5c8760faee9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2c27fd27-1abf-4e7a-8840-83565bf6f158"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2cb53a92-5959-4023-98d1-282324b49e43"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d217c0f-b419-44b3-9709-10e38f146755"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d2841f8-95a8-4f8b-bfa5-fbf887816714"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d3c5286-c2b7-44f1-a0f2-6639b1ec3924"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d4c1e88-ecad-4cef-a60f-df1102244812"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2dbdc00f-fe4c-466b-897b-50715192cbf7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2dc40ebe-f4c0-40cd-884d-e5c9355d60ab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2e0f2995-0576-4f3b-8a99-e4eb674118a2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("30e51248-0a7b-49e7-b324-3a905e88bb56"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("312094bb-0c59-41b6-9051-4f66fc474ba4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("32a6d2e1-1b3f-4c32-933d-ea3be54cd798"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3301f0dd-1ef1-49e9-b4e0-6afc6a649a2a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("330cfbc1-d36d-4b56-a002-f37e966becdb"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("33382ec2-822c-42f5-8e0b-e4541c4e4a3a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3360fa4e-6103-4965-a679-ffb3d73cd460"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("33752f18-6f0a-4987-8dfc-dcd1c6e7712d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("34b05611-2c74-4f4c-9573-9a3d3932a4e6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("34d912cd-12f0-4dde-80d9-0bc016fc5b79"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("34e324f2-c5f7-4559-8690-76274f6020f4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("360f3f1a-27b6-413d-9228-65dc7834c2ae"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("36526872-a74c-4f44-9d3b-0fe24a159a3c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("369b12ec-3d4f-48e1-983d-f85c43b0aa42"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("36bce1df-febe-4cf7-94ae-e8ba86efe8d5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("36f5d6ad-2bf9-4e90-b187-bc5e16fb1764"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("372ccd08-6fc2-46e4-b265-46f9f0e49575"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("38acea95-f1bd-4715-b65b-73e42c9b6626"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("392c0c82-e64e-49fe-9cdf-d80727438d4d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3acb665d-fd57-4074-af8a-201381a13cbe"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3adb42d7-e8c7-43a4-8c15-1353a8ef3d19"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3c3694fe-1d0d-4a90-9e99-6ca416689202"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3c4c4b2d-4807-4260-9e55-09ec659cb12b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3d66d9c3-5ac1-41bd-891f-98325bf7b64b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3dc70e7a-f569-4e83-b500-2c409275fea8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3dd6d8a9-2dd4-447e-acb0-703f939aef75"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3e191e65-aa56-44f3-b404-327dfa1d5349"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3f260cc0-b777-4700-88cb-5e7d8dbbf0c0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3fa28c8a-b711-4170-96ba-2405ae38e9c1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3fc4003c-4e6e-494b-80bb-9a78970744ca"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3fe32803-eb37-4dfe-a68d-82e1c0f47f61"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40250884-edd1-420c-978a-6a177a91c6b1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40f8de8a-9a13-4f68-bb84-780b407dac81"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("41a2fe6e-c45d-4f00-ab29-d313b796fa91"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("41ec14a8-9cfa-4df1-bc06-be7e01d4c755"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("41fda860-d5e3-47b4-a2bf-fc67fd23ff63"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4255f6f1-fd9a-4c2c-83f4-f765626a4be3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("43525c91-a1ab-4436-9bd6-598c2c3d072f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("439235df-d030-4e94-95a2-ff90201bec19"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("43faa088-f9e3-47d3-8a3b-63f8707ceff0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("443e6bc5-1f66-41b0-9cd7-7b31ae1098c0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("462f3d36-41fc-48a3-a430-8a38323cb17a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("475792fc-0a58-410c-9fed-47a79b6f7924"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("483b162e-b79d-4cb0-a6b8-fa26eb7e09ab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4841c33d-d7a8-4be8-a1a6-aa40f89ea1c4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("48a6fb05-2669-4f9b-87a6-5596bb4d3d5a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("49274805-3c5f-4cdf-8f53-193da44c81fa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4995bade-fe68-4b89-ba79-2082f1dc3819"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("49fd6301-49fa-4899-a480-36e954917c4a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4a0b6c54-095c-4cfa-b42f-2d756487edee"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4a4367c9-0bc6-4c31-ac5b-2e1c025c4173"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4af92ca3-0cb3-49de-a045-d5160aa5f59d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4afcc932-148f-4aa2-bea7-557998378ef7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b0bb5c5-2a57-4425-aa37-b62f8b6068db"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b927f4b-cecc-4c31-bc84-ee95f7a7e4ad"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4bade09f-ff75-4b02-bbfc-9c0048d453ad"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4bdef029-717b-4dcc-91ae-23627f6351b4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4c24b9ac-e571-42a8-b96e-ea0ba0d4b02d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4c55c99b-9452-4cfc-a414-325b2fc16f96"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4c566d7a-6d85-4b14-9718-d7bc6c24e084"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4c9666a6-9837-43a0-96c4-47774b8b060d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4d8a427a-8750-432d-a672-fa7325a9211d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4e946abb-820b-4e38-a5a0-65f935e3c259"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4fb9a445-9e97-4b0c-bcd0-3bb9ac54e3d0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("50035f01-8aca-4c46-8e07-136996b22a72"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("515df4ee-92fd-4791-81a0-03085e0c8e68"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("51b7c19d-89a7-4339-8c98-9eaf767fb8a5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5256d696-be11-48e1-bc1e-4ddaa28aa37c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("52776fa3-9743-4f7d-abd0-cec3bb95fa79"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("52884dc2-2de1-41ed-9793-1ca28a4e57dd"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("52da3e53-56b9-47f7-bbed-3284e0c8f8ed"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("532d7285-9218-40ef-97c1-4494840a2177"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53bc034f-b443-46a7-8e4b-f6dd9f20fbdf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53df456f-cde2-43e7-bb49-c9445a7e319f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53e5538f-fbf0-45f1-8346-3528d1b20bf8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("54b51986-eb68-4329-ad93-c334c0076668"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("55114206-88ae-42e6-a106-69ee86752084"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("55266bd4-f9da-4f22-b749-d322a7ec8357"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5649eb44-f826-4ab7-87a8-c1e054d07ce4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("57137ec7-9270-430e-9236-490402be9137"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5778f175-bfe9-43ac-91e8-2896f6df83fa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("57d4462a-f4cb-48b6-84d6-ffb5415f4777"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5875c8b8-8f67-41f6-8de4-88dd1b05ac33"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5891ce70-ea29-4652-9071-c3d32df3f06d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("592a0d4e-4486-4e72-8f2e-b0ec262a3d32"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5951f0bb-c341-4cc5-a023-332914af7ef9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("598ae609-bb45-478d-920a-cb0fc45490cc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5ac8ecaf-545b-45a8-b989-0d33855f9d0b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5b26f030-7de2-42a7-9331-aeb6ec9a659a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c342a88-bc08-42f4-8fde-4181520f9c91"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c683411-517a-4360-ac23-2f38c3593dee"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5cc67bd0-bc61-4ae1-88f3-b9839821c4ba"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5d0400b3-068e-44b8-815e-4d4b36112fb1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5d4c7cf0-f782-4f9e-8448-f8f7bc85d7ec"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5d898b69-63d3-479a-a05e-e4cd51101ed1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5e59e7bc-fc12-417e-98a6-05ddb5c8a624"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5e6eece5-02f7-44af-b131-dda97d78591c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5edd3e53-1ee7-401d-8293-f88674f6a603"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5f93ff81-afeb-4b14-a621-ef91704467d9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("60109d52-834d-4f11-a59f-87b4bdfd34d4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("60393959-db0f-4608-9106-90cf5da5beb7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("609ab132-f455-49c1-9fea-946023b584e1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("61581a5f-2957-401b-b7db-4eac0f990418"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("61c155d0-229d-4546-8afc-d6f3f0b764bf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("621ed7d8-4115-498d-bc53-24895e360147"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("62527bf9-ec44-4fbb-8ab5-2ae1be45d0f4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("625b2cd2-b465-4f10-a1ce-bdf3008b4477"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("629fe310-354f-470f-bfe7-db3eab9d66ed"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6435d935-b58d-49e3-9dd1-e99376ca6f83"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6584127d-523c-4293-a4d9-cd8baee11080"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("65845500-fe87-4953-8f90-803a1019e30c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("658e5867-22d6-4373-b6b0-9b15c9503b33"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("66bd1e27-f8d4-4ba6-a9e7-c56ad8b34f59"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("66be5bcd-6ad0-403e-b549-6f0264122a6b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("68e68005-4f70-4d8a-b91c-fc754a30c896"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("691da9d2-b86b-497f-a2d3-44b188d97754"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("69217239-08d6-4800-a5cb-9aa07cb95824"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("69a21483-444a-41d7-8f19-f2586a4d453f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6a0cba52-f3e3-4f53-b7fd-4f4459fe489c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6a32bee7-b5ee-4351-8dd4-d53f0e8b0cf0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6aa6ca98-d5f1-453f-a007-d14fe61b8034"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6bf26f08-c8fe-4e7e-8359-213239b124a0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6c49c95f-6cb0-4b08-8814-4b730b05d02d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6c4ea837-9df4-42fa-b26f-79588ced8a47"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6c845aba-d797-4b91-bd19-0e5b965657ae"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6d31964a-f276-4e54-ab34-ff6168f2adb0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6d3462eb-d065-4972-961f-f50b0ab9937a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6dba49c7-7e12-475d-9123-5702019ced6f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6de0fcc2-9b6f-4f46-a685-fb2e3cac514d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6ed30637-1282-4982-a08c-48da7ce98837"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6f6c69ba-8432-4eaa-96c6-3ff743cdf954"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7097a98c-5903-42d7-a3e2-ba26b5d840e8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7212bb55-bfba-4c0d-aa5e-dcf86815264f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7365050d-c4dd-4555-a299-9d4f770052b4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("736a5c2d-224d-4fc6-90b8-cbf095892806"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("742aff7c-fea9-4c29-8264-335d671b35d9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("74382f26-b693-4cfe-936c-f066642ee47f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("74c8f3cb-431a-4194-8ff3-b2d0f8ea3506"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("763a756a-0965-4d09-867e-977eb05a3ecd"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7646aa7f-d759-429c-85e3-96256659512c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("772f9071-8e43-400d-ab14-52bbc5e0f5aa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("77662026-a0b1-4754-ad71-f22ac58d91f1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("77776e1b-a36a-4633-9c22-eb011083e3e8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7792b17e-c44b-46dc-ba3b-e63485c431ce"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("77f8a524-ccf0-49bb-8590-558685a44ad9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("78645dfb-59ec-4278-a7d2-9e9023ba17bd"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("78944ec2-72fa-4b64-955b-2efe56fd6eab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("79a6b239-3185-4353-b6fd-af11a7d7c083"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7b0ddc71-9455-4ca2-b867-bec98cd5d03d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7b9c395e-42e8-4aa1-a04d-20df4c8dcbc6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7bc5983e-94ad-4bbd-9349-e34533f8cf41"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7bd8fadb-468c-4e24-a326-418ea9242bb5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7c236d68-0d4d-4139-9c9a-6a3793953538"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7d649274-0e52-45df-a153-1b5a67009aea"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7ee22798-63f6-4710-be09-3874d7d28a8d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7ee92b4f-9d61-465f-9d2e-5ffc81694807"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f15ae71-1c48-4b9a-93cd-d97611e80e6d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f470928-5827-41e3-b431-ca974e83c68a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f5fe41e-7885-459e-815c-412190145143"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f7bb65d-4249-4a1a-98b5-bfd30c344aaf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7fef1bf5-41fa-4b05-9049-9b01b0de033c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("808f4a6b-755e-440a-b5c5-0ce0d6417d66"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("818486df-c0c7-460d-ad18-f292f3647a8c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8275f5cb-0c0a-47f7-b0cb-6f04ffe99089"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("828fe435-bb58-46c2-9ccb-1dfb0376e996"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("82a5da2e-5521-42be-b55b-897c5d4d1e2c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("83bb88ed-5597-40d4-9699-48a3f21a124a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("83e415ea-6728-4e9d-aa7c-52f3cb1da9f1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("84258752-c63e-4bba-b121-c2629cf03c0b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("84422b5c-635f-4c15-9238-36912236d11a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("850459ff-ecc6-4e98-a6fd-9157275e72b0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8512de6a-9961-4771-b7ac-b57d62c4e878"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("85498e9e-3ea9-452b-9ae3-82c200f7c0ee"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("85925723-359d-4b02-9fa9-e244f8d835f7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("85fb5ee6-6ce6-4c4f-8541-e820c1cecf67"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("880da1fa-1ea9-4d98-b012-bb6cb16e7d00"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("883c23d5-ac2e-4ed7-868c-6a0ea5024ebe"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("88683758-f1cc-487b-b7c5-4b5eca88bad4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8938956c-da09-4afa-8eb4-4dea144a27aa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8973462c-f309-47c8-bae4-33462f5291e2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8a298dce-6b4b-4613-bfac-61bfaa2f2a50"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8a432cdf-792c-4312-8c64-947e8f183142"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8abaaef7-7de3-41de-89c5-2432be8a905e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8b6b7214-1580-421b-937c-4514fb4d819c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8b6e1f99-96d0-4357-9b76-49850ec12797"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8b741baf-4612-4340-877d-1dcfec89093e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8c1ca158-4c79-4163-a613-7f9efb9b7f52"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8ddda30f-88f9-4e92-b124-c9211c34d91d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8de1e46d-c8ec-4a15-8a42-169f131d7049"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8e91234d-901b-406f-b938-b7ecbc043e73"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8f5bbbda-14c9-4240-bdc4-5897be36e4ea"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8fb7a589-b164-4156-ad50-4b4ce71661d6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9066bc80-dd1e-4967-b584-ca6c5b25bc0c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("90ccbcc4-559c-4fdb-8fbd-0d0f4eae3ccc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9100c878-4cdd-493c-912c-e6ee5781c246"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9104436e-ae77-488d-a456-1812dbf93620"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9155e7fa-164e-46c1-9c1a-e769d7224c9e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("915cabe0-6212-4e53-8587-e2f93603d3f9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("921752ef-f203-4362-95ae-1e4e010e7f19"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("921e883a-2799-47ce-9a44-3cbae38a64b8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9245af68-fb58-4c4e-b094-53c3787d36c4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("92ff069a-e863-4525-9a5a-f4e97df3b415"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("937a020b-c11d-47b7-8737-6121837da765"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("94140dbc-0651-4214-9985-3db996d1ebf1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("946200a9-04bb-4085-a246-d010765d24e0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9542fc5e-8a7c-49f1-9c3e-bbb5cdf31169"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95afd198-3153-41d8-862b-98334a9b7941"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95b90e42-87b8-4508-9988-586399579c20"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("96cf4267-9967-4453-bd8f-451a992f391d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("97090ce7-427c-413d-9871-555e282b4984"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9826c27e-b8a5-46dd-b2d6-10cd8541b60a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("98bb1c90-ee72-45c7-b6f4-cf0d6ce99b93"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("98d74c27-049a-42ba-b9b6-7f883826291c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9a482430-57c5-4425-8008-fb99f8b52cbf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9a4e363b-f22d-4802-a88d-74005278103a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9a72205b-b8d7-4e27-9cd6-b054af9404ef"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9b702bbe-bf08-4e59-bbee-bd7219ef643a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bc5715f-82b9-4344-9a6d-c42ad855bdfe"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bd2a24f-d5c0-4453-8218-cc60adcaec07"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bee6ebf-c1b0-4c3d-b3b9-e6adb437c858"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9d66b30e-1d41-43ca-aeff-9debb30ad69d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9df085d3-60cc-41be-aee3-03cf5c17a40a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9fd2e128-fe57-4013-afc3-62a4034b6ac3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a008bcc8-7339-47f3-8349-c9e5e4b77029"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a08b317f-33f8-42cf-b0c3-e103b91e1f2e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a0d92007-7ec5-47b3-86da-7542dbfd0f5b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a15d2d53-148b-4c4f-a129-fa55a6a9e14a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a1dc375d-b006-49e2-ae12-d6f47f9e802e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a1faf02b-b581-405a-abfb-9bca6b1e9ccf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a21e6e71-f777-44d0-bf8a-d977ff7af4ab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a2989265-f827-4765-a0a5-f7cc0fe3a7fc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a3bbe95a-04ca-4e79-abfa-850a03798e65"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a3f8f721-e6a0-43a8-9d40-a926f6a2c689"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a413d765-03f3-4915-88e3-7d74d030793a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a597c37e-ec84-484d-b83f-2a12905f4ae5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a5bdf384-14de-482e-ad8d-e0c5a7427239"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a5c9b499-0420-46da-8622-d097708627f9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a5fed571-a1cc-4810-b055-b39b8c7b4b5b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a67f5e53-82d0-49ec-9c67-b67eef071b57"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a6cf90dd-be92-4b7e-a913-2a0417ec3585"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a6fc7119-76da-4a39-bdab-050590216643"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a77c1259-67d2-4e37-a0f5-7ccf6251f4e0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a7ecc4f3-6ee1-4cb8-a248-ab6e527f43b3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a94abd52-e1f3-425e-a6df-9b535dcfdd90"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a9c18ee3-c68a-450f-afbb-178ab7c196fe"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ab283795-6b68-487f-88e4-af9d5bc4596c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ab830f9c-4124-4fad-84f3-467623d7e68f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ac721538-6e3a-4977-b352-d5a3d0701001"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("acc25501-ea42-480b-9c41-cd43e4a4e573"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("acf2bcc8-3a98-466e-a164-eca20181a54d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("acf8f863-b8e6-4e80-b159-8f5f75bf761e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("aedc32b2-2489-46e4-93da-5c1e76f96d4b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("af01ed56-c24b-4942-b2bf-7edd062297d4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("afa5b05a-6389-4fbb-97e9-1810046c576d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b094cd2f-4248-4b65-83e1-7ad46022d32b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b0d1ac7f-9217-4af7-a6c0-d04c025ee9d9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b22de072-ef55-4afc-a3af-ca53c078756b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b2a5aa60-3fa3-4c65-8e5c-7cf3c45bc5ed"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b2e34325-faa3-4edb-bdcc-922ed5e0cdfa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b32d9c02-12c9-4e17-887f-4e824a10a8e8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b35001f9-b40d-4f83-b523-e671f92425e1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b451530e-ccb2-487e-9f4c-ce89baa36012"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b45258b0-fa6d-4985-8bf7-8c8c3bb5ec8e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b4b50bce-fcea-4aa6-a98d-bcd5998d1fab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b51feca2-86b4-48ed-b392-b48150c40426"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b56c4a68-d113-4a31-812e-ac25e54b2f46"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b6896646-de44-463f-b043-6c13a66d65e6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b78e5ca6-5601-4f51-8e50-9d1cc4e517c6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7af1aac-73dc-412c-beea-9ec7b5c67f43"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7cb1176-9abe-4952-82b7-0d9830cf15a8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7cd8cab-7833-4c0b-9422-436bade0e978"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b7dc6b86-e07e-43e1-9621-eff0284a830b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b845843c-03ad-45b9-81a5-67d60e4dc2da"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b9903a4b-1cf7-48b2-9123-4b0720c543fa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bad4bb2c-ecc4-4f61-9c03-7b63cf227a41"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("baf79a8a-a15b-4e31-8f3c-9ec15b701cb5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bc95fe3b-1f26-4e5a-8103-ca3ee7c5d27c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bd1b7f86-d89e-4342-ab68-a20302d47128"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bd2cc0a1-94cb-4719-b0a5-f4b11c44dce5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bd93250d-08dd-4507-bbda-e441c29f8b5f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bd947581-e390-4e37-973b-7f6b49fdcdb8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bda7b447-cd78-48e7-bcab-42ad75536f36"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bdfbb8f7-2a14-4b1c-a10b-ddc1ee6d1021"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bdfbe8b8-c55c-42a8-9192-9ec279789fdf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("be7bf98b-6eb8-4b56-9607-e86f4f3747bc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bfb8942b-2935-4ec8-bb98-fbd39a557532"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c05af1bb-3c4e-47c1-8ef4-8586ac1ab0f9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c0ee555f-45a8-4674-af52-311952cad673"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c138814f-28bf-4b05-b39c-0ac7dedbc6dc"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c13a81fa-6a29-4bfc-a7c7-a08ceccac9a6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c1d54431-584c-4767-bc11-53254364b4d3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c2894dee-38bb-4fd0-bc00-afcc9cf38950"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c299a1dd-2e55-47b3-aefe-a00f165d9d31"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c37ab55b-feec-42a5-99e0-b7ee2b4445e0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c39ba93a-e8f7-4520-819b-df7ccdb0dd75"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c3a54a31-515b-4123-8ff9-560850728408"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c55b9ed5-2eaa-42a7-9826-d3f7f0a7f1c7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c64b0a99-1023-42ce-9338-b216d82b0298"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c67ac350-5b3f-4d73-8f85-a1e71eecc4d3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c6983f92-ae2c-4f4d-9a74-f553533b5292"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c784bb4f-3178-492f-881c-abec365b0f44"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c78a9287-1a40-4928-9bad-16c61820c53f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c7c34803-4cf6-4fd9-af3b-b5fd9e6b71c5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c7c8200b-0d3f-4d03-b7da-2f15f2cf89de"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c7dfac9c-2c46-4ebb-9078-7c0ee66c820c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c7f7110e-eeec-46ae-b7f3-80f59c3d9d94"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c8ac05ab-732c-499a-876e-ca9753af0cb8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c8b8580b-bbbc-4543-8704-d95c3b262566"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c8db4bcb-9c47-40d5-97c7-a2cd21ef80a3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c94c93c2-be01-457a-9e65-94bfa1f6f8b2"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c9a050fc-e5f1-468e-862a-7e38599b63a6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c9b8d501-261b-41ae-a374-559952dac656"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cacd6ffa-5662-4b4d-9a3e-3d3b72817d2d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cb3a338a-3934-4cbd-bfa0-e67aa7979fb4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cb3d3a82-1d32-4374-b6ae-8a5cdf465c0e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cb674683-6ab3-44d4-a467-2b3791308988"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cc650342-146d-44db-9487-a086445ce087"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cc79c480-ede9-45d6-b5d8-37a9183d905a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ccc24266-f518-44ab-81be-71693b485bf5"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ccffc060-1940-4856-9cd5-8f1ba4681d08"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd482a44-70f2-4453-9dfd-767a3ddc5e62"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd618957-c67d-4a16-8387-b3d107d7ef22"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd7d2fe4-3cbb-4b77-ac54-e25ee2762afd"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd8c6f7d-9dc2-4b85-a11b-5741b17a9e3c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ce2f3fa9-b5b0-42a9-9736-6d5b2e760203"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ce6040b2-5ff9-4b10-abed-9c49cfa9709e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cebb749d-19e9-45c4-b8d5-60a74717127f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d03cfd7e-4a64-4295-b602-b79d3dd0df0d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d083e741-34b2-4298-907c-0bedf2b3f088"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d171cb25-dd3a-40b9-a3a1-092964d6f450"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d3098e0a-2204-4cd6-92e1-35562c333698"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d351b322-9702-486c-a785-9c72330cb1b8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d3a1ebe8-03dd-4c2c-9d53-b18b099fbf95"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d42549ac-76bd-4675-882a-eaa7d5635130"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d46fe497-725e-4139-96df-1474c24c5a86"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d4d5fbf2-1147-4b75-8d22-62e44af3f597"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d5e7d9ef-48b3-4dcc-b89f-77f883bd1bd8"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d607f9e8-779a-4d4a-8941-34ae0f33fa26"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d8cd410e-7028-4416-83cb-e3ec346534e0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d8ce63b2-a2d3-4f9d-847c-cb34b31671f0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d912179f-44f9-4c7e-9d68-ffae39162da9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d9306861-f1c7-4fbb-ae59-3518673c8606"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("da94ac15-fca4-4c25-ad0c-ace540228c26"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("db83fad0-6d1c-4d59-aa69-479d6049ce22"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dcc05505-a973-48df-a858-8570259e80d4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dd6532a8-7258-46a9-a528-b702a8194b20"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dd98b2aa-612e-40fa-9bb7-fc17d291d1bb"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dda6b8d0-b803-4d19-bb6f-0fb0384d0b90"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dde83e77-ba5f-4abf-a0d6-5c56a46eb46b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("de04bce4-6e06-414d-8cd9-5028782e6b48"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("de0bcfdc-60ac-4b3e-97e7-d75d44452f0e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("de18c9b7-bd4e-40de-87b2-d61dad7dea25"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dee7e8f3-f47c-4a90-a7f1-49d207455e04"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("df8429a4-0292-480c-90d0-f676d02cfab4"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dfd5b284-0fe9-4e94-becb-85c6d958630e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dfe48284-41db-47de-a23e-7aab217899c7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e0e4001f-c039-468d-a940-51c3aeaf4f3b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e1303af7-1f08-40be-8123-f5d76da90dec"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e145f700-2cc4-41fb-9136-6c37569e495e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e2832c98-56c2-491e-be8c-49e8bcc9c047"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e29be1a1-71b1-471e-af30-f319dcb191fa"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e32bf3a9-d823-4cdf-9fab-57b01a152031"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e3ba87b4-afe9-40eb-9d46-264b99dd3b0a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e4b22703-de13-425c-8bc6-b2acebe77c8b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e665edec-eda7-4653-b57b-768122ca19a7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e6e89e63-d826-408c-aed3-467a4f42656d"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e78c1cd4-c503-4ca0-8fa8-be94ceb4db49"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e87ef2bf-8795-472a-9190-dd58885e2f95"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e88dcfe7-dc4c-49a8-b110-93683aceea5e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e8b2f9ea-83e0-4556-855a-2662c4052d19"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e92ca304-f351-405b-9eb5-02a620593754"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9de5440-d446-4e2b-b7a2-98b951a2c787"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ea57c8e7-31d5-44a4-acf8-260b0dfa59f1"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ea6b2620-c8b3-45af-b1a8-32396bde1aca"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ea6d419f-5bc8-449b-8d53-102fdee0907f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("eb008dbd-1ffb-497b-abfa-5cd6ccde1179"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("eb3e538e-5992-441d-898b-2baa4ef6e340"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ebb24283-ff00-48fe-bf78-c5b7c86c7a41"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ebee5a90-9f16-4eac-a301-41d95223e9e3"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ec64b49c-2040-470f-9916-cf33ac200f6b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ece97917-e0e6-4afb-a1b3-4d79fb72ad8f"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ed796677-9eca-4417-977f-e97a2506c55e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("edaec21d-4e9c-4e54-8ac8-7111a8695261"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("edc4458d-6901-4231-a786-aae99173eb13"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef3bbc81-56e5-4e37-80f9-3ed750e0cea6"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef8f8913-6ee7-4718-841a-2a4f2212a7be"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f02e32f9-b70e-4593-9d7d-f4ff855845c9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f1b0c9b0-98b2-4ad6-8ac4-f351e8862a77"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f1ea08ad-0cad-4bfe-b8ee-622d8f37de7e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f1f387a7-956a-4d3e-9f3c-e0a24bb3f291"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f22cddec-dc16-4dc5-8fa0-0eacfb52eb9b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f23e0dc4-14d5-4282-becc-e19a35c162f7"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f2da215c-faa7-4b5e-ad3e-d84133b93413"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f3b89f8f-7e79-434b-b253-82a56c96651a"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f3f07411-8464-4d23-9af2-278f66cbd041"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f5113209-a6eb-4e5a-a4a9-a1cee59ae283"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f5447225-f6c0-4b43-9a9b-19e6466942c0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f58495f7-84e5-4c9d-aba3-4eac6a0bdedf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f6df0c71-ca05-4f72-90da-9cc4a8306d95"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f726c641-2e58-451d-a857-bcb2a52f8151"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f80a305c-ece0-43d7-9df7-776328ec83ab"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f85de725-9d41-4abe-8d9b-c57ae4fd620b"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f9b1c801-163b-4b30-b4ff-7acb851a26fe"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f9e05225-a9d7-402a-b4b2-efb58eb5a7f9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fa73bd39-e58c-4de7-b0af-5cc7594a483c"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fac1e180-f429-46eb-ac39-3f2d92bb4233"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("faccfd72-0154-4513-9e2d-2dc8aeee7691"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fbc62ce7-d843-48aa-babf-7591fe9f3848"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fc688d20-b856-49d0-b83a-01d63d9cb3bf"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fcc7ad48-ea43-4914-b789-7833b7177b71"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fd669e0c-d3f1-4b06-b696-ef92dfd005b0"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fd7f0286-b5f5-441e-bafe-406adb69e3b9"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fdfd0948-48e7-4b22-b116-b4d94f819c1e"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fe15a7ec-c779-47a1-a65b-be305cae6aba"));

            migrationBuilder.DeleteData(
                table: "CommandTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fe5f4065-e306-43fc-b3f6-c9de26f223c2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("00913ef2-2c83-4abc-a098-dda64f4decf4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("01840b51-7c74-4662-9017-cbdfb156dccc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("029bf101-6448-42e9-b523-deb9b5a37a15"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("03499c64-12b2-4855-92af-6c5a6b93acf9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("036d5b62-74b8-4e0d-86ba-56e2fbe6dd18"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("037a7829-26ec-4fa1-8f4d-2a930d9ac6fe"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("049eb95c-99c5-44b5-b7dd-d57c46862e90"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("04c0545e-b4c9-4684-b242-9986c70e967b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("055b4b04-87f5-426a-96cc-0508eb8e464f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("05ccddf1-0d56-4ed7-bcbb-1a144e35b23b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("07fb1195-d580-45ca-a1ed-4b7f99c10fec"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08a20038-e38d-4a1f-aee9-5423f826bc61"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08b22b84-e4bc-4922-b0c0-d4308f517dee"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08cb7968-70be-4984-84b0-448a1c9f51eb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("08e2135c-412c-4567-90ff-3ce04649d80e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("097802a2-db08-4c24-b51d-a9da3535eae8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("09af8f61-e155-4522-9e35-fd768140dbbe"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("09d07c95-9372-464c-a803-4d5c9818b455"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0a8a216c-494e-4049-ab2f-f0847665abd6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0a9974a8-c01d-4808-a25d-5d7a5616c6ae"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0ba15b09-e778-49c0-9f7d-d8549e63077d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0bad4f4f-ba13-4ce7-a8c9-32c40f669376"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0bb49e15-195c-4e9b-bfba-2ef3a9a3f103"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0cb32b35-08cd-4faf-8304-143249e9a9ee"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0d1a0b6e-2cbc-4fe5-b8ef-6079fba588b6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0d8790ac-f74a-439c-a62d-51206a39787d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0d9acfa9-1d5f-48c1-a297-11fa24018cbb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0db44a8c-87bf-42a7-ac11-d29a3b57fde8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0dc40dc4-dfaf-4d86-8e78-a0e8484e5a9f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0dc83d7c-3bde-48c2-a83b-acfcbf7b791d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0de51b90-0cb4-437d-9f24-9ba0df587f2e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0de51cd2-68b5-4135-a165-a15e48839521"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0e03eade-56d7-4be2-9793-62bda3acce47"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0e6afff3-891c-4aae-bebd-73cb8a476348"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0ea3d350-8409-4de8-a5b3-ed9d310cdca2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("0fba0ba8-ef6a-4cb4-be14-277f63d98787"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("101ed09a-8433-4101-9cb1-2509cb73194f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("111c5636-384e-40ba-ad1e-8d92d7344ac8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1126c193-ac7c-46ee-9798-38dd6bfa8bf1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1159f1d7-ec25-4ab3-b8b0-11cad45ccf04"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("11ebcafd-200d-4ee6-839f-aabf42677a8a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("130900f7-d0b4-4f32-aeaa-5cd2d004bea3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("13cf04d6-2d45-48f3-9756-bbc68d7f2a83"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("13e9d67e-7e52-4e8f-abff-7cdf9468b4ca"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1501e254-8c95-4f59-9473-34e793acd8d9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("15bc8ada-753c-4afb-aa4f-5ba40d67d34b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1601212d-f692-4a1b-9801-dc93ff073c30"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("164d7160-4d45-4c20-8282-053bf3fcd9a5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("16eb9521-0870-4679-bd39-33235d4f823e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("175e676f-1c76-44fc-8bd6-93c8da0a97dd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("182cc7d3-7baa-4738-8320-5ee422e0cf14"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1844b963-cd47-403c-9bd9-9287711a5526"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1881c20a-3aab-4446-9012-956406cac5b1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("18e9ae32-1ef1-41b0-9bc1-9d1f17991272"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1a19a7e2-84cf-4eba-9add-326c66366838"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1a4ab2ff-3b87-4744-ad35-73f6a8acb5d0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1a99a193-885d-49d5-a641-5296da9f946b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1aaa5ea6-693d-4271-84f9-158b552ad917"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1b55179f-8da8-4ea7-aa29-e7384cfdd276"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1bea6fe5-6dd8-47d3-9080-bc082da112ba"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1c69bf11-3efb-4d64-9e6a-16a933e52c2d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("1d395622-7ad4-46a3-b328-2501049895ab"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("201218fc-40b1-4711-b533-872af3fcc050"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2016640e-60c7-4ac2-85bb-0f9d82a6b4a5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2055d0c3-6c11-441c-8519-89aae5b4a269"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("20794d3a-0279-45ac-80b1-5a0c2f5c986e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("21ca2080-a321-47ef-9496-a50b7fabd30f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2412642d-0518-4272-95b4-292bc3ce05d1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("242819d0-02f5-41dc-8a4d-0e9305b95730"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2462ead6-d683-4be0-ae5c-4d6325182885"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2584c2ba-2436-415a-953f-6ab334c23c39"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("26797068-5872-45b8-9284-424e1b4f90f4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("26b7f69c-e9a1-4216-ae65-8daf38e56cb5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("26ea8baa-dd2e-4bce-87b6-774ddf30d8dc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("27543b1a-a88a-43b8-a94c-9e191ce65e61"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2807b1f0-4382-4af1-871f-d7fc8d9ed8b3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("28274d95-0a24-4f25-a6f2-17d9fe069df0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("297a6432-738a-4fa1-9e3e-09c66ebb9433"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2a149761-4b8b-44fa-80c7-7add60e67300"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2a7a1028-1570-4921-bc2d-6744909b6ebd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2af11d07-f7c7-4303-ac14-d9c80a8b40fa"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2b519b99-95ac-42b0-9c6c-de994de78083"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2c26c73d-38e0-403e-afa8-c969f22b8252"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2c35a085-f0c9-4dae-b27d-a36ab90762ff"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2cf99e44-03ce-43ae-9d1d-01f867eed9fd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d0d911c-9b49-4692-af4c-db285bbffe9d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2d4fe31a-4a4a-4728-b576-f6eb22be5a1e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2dae1ff0-16da-41b1-8110-68d5615311bc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2e387cab-5964-414a-892f-c57bec4c8612"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2e9607af-a4f8-4e0b-b444-69b9fff8bdba"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2f0b434c-cab3-4424-bca1-81a17e1e4b4e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2f767050-edd9-46b7-b028-56f63d2236b0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2f96a69b-a5cf-44dd-933d-34df01c046d7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("2fc87f47-b004-44f3-9f3c-cd996553a365"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("317b49b7-1b70-41e8-8fd5-e3fa953cb9f8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("327cdd2d-d32b-4db1-bcdc-9d297b2738fb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("32b8dadd-4c1b-46f4-b77f-13806bc24126"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("32e65b26-3818-4810-ad6d-b8f30e52d52a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("331e6621-9c24-473f-b2f8-275b3c3beeed"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("33414b42-d1cf-4590-9a35-dc07b8e02bd0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("34879b2a-1d0d-478a-bfbc-f7b7af540a5b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("35412c44-5ac1-4c0c-b781-42234976d624"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("356169a8-493e-4a97-af42-ddaa632e3f88"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3599ee61-c7a0-4e13-bf82-0318ed716621"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("36181cc6-53d7-4137-883d-009d37b6ab6a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("36e5a00f-2ec2-487b-ae45-a585930c42ef"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("385138e9-437c-4fdd-8af3-9f7104ad1bf8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("38ea2439-e763-4a72-95c9-1a69ea6cefe8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("39ef8b97-3ad5-4dd2-baab-0164287e7f3c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3a10cd8f-55af-445e-86cc-6c34b2d96ff2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3ab93cb4-4252-4850-908e-75eeedf55773"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3ade35bb-9d73-4e1e-9a09-7877df9c1ed9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3ed6027c-8fcd-4c58-baaf-079bfae7a67f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3edbb835-67bb-48c3-ae06-986b89f231d0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("3fff0065-18d4-4b88-aadb-cdecbc0d050e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("400cd152-4ed4-4e9e-ac9a-7a47ac1db09a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40839416-8722-42e8-a0bf-e3a4e35d6249"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("409e3714-3892-45a3-bc91-2bdc332a9e88"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40a2b22a-0389-4552-8c28-1ad97841bbe1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40a9ff5b-e1eb-49b1-8cdd-c534e1a4dcd6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("40e0d4f4-a96e-410f-8f87-1958b6a767f3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4192d2c8-d638-4bcf-b9e1-bcc8a377bbcc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("41d0feee-6c2e-4061-9a78-022c8c960a98"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("426b6992-9623-49ae-acc2-8e3f0cd2e1d1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("42ea2633-855b-4708-9ce3-14aa457502b8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("430cce33-3ebb-4de2-8421-ba9382c5125a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("44328a0b-8fd8-4fe4-a092-0ee1d8615c1d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("449bd94d-6521-4a61-ba7b-0302803bbc7d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("44d9cf3b-1e19-4644-b316-28a3f2654103"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4528254d-e6a7-49bb-af40-78b1c0305562"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("453578e5-f65a-4eac-9165-695a54274d50"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4598eb6f-b29c-4b7c-8f2e-3c6a9e924bf0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("45a89a3b-e933-44a1-a184-22da5161a36c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("46d63104-2492-4c21-b555-50f2f8c9ae03"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("46f26a7f-5f0f-4d38-bcc1-0d9207268c04"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("47004419-0431-4f38-8412-97c3fc7120d8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("47d4c2b6-86d3-4ced-b4d2-25c9cad10362"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4881d024-93d5-4bc9-a510-4689982b8aa5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("48b50834-2a4a-4357-87f2-73beaae8a656"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4a2dfbf8-b0a2-45df-bfc7-09265164616c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4a48e9df-187c-4e39-ad24-896af98ea159"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4a9472f3-d2f0-4520-9b75-ac46e7873d5a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4aceb197-2f8a-4f9e-83ab-e6a61ad13b8c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b01f823-4328-4a4b-94d2-0a9e1e8e65cf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b21e15d-7f47-4392-8a9e-a1faeda52c44"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b661d3f-2f78-47dd-b26d-dd8721e189e6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4b816c15-a1f3-4465-8751-dc83d922d17d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4bdd1ffa-533a-44d3-81f0-66b86a7583cf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4be7b113-7265-4cf8-b339-0abc4bf1ed64"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4c8ab485-018f-486c-8831-9907c25c43c7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4cd70144-90e9-47cb-ae67-c3ea50653e56"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4d4b06a5-7d82-40b2-934b-b176fc4b8122"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4db894e0-5228-47ef-a713-f1bbc800eec8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4ea7d226-37f2-4b7d-a664-e9ff4e5e55cf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4f09a07f-119e-4169-864c-6a80cd5adbd7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4fad6db0-1624-45e3-aea2-d7f514816687"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4fea86dc-17bc-4918-9ecf-22b927ed71bd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("4ff3e332-8b3c-4043-a8e3-e6fafcdc4302"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("509e19af-94da-42a6-af77-d44d81fac312"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5147dd2e-ae38-4304-8453-a19086d42b71"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("515d0711-61be-4897-8ad8-f7e6af93c519"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("51757f2c-ce2d-4f72-9a7e-2a5272451df8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("51b89e14-da51-4fe8-877d-b527bf4ffd21"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("51f979ef-1eeb-4704-9e84-ee146f6d3a29"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53af9ee0-a182-4bc9-9317-db146f8dd963"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53df4edf-6960-4e52-9460-0d824c8ed4aa"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("53e43bc5-b489-4941-9c4a-9df2ae1b19c0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5400d67f-7768-4f0d-a5f0-dc4b4377bb31"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("54a665c3-202a-460c-92e6-e3cd1c48e973"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("54f6f81c-76ea-4f87-93cb-0603852686ce"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("556c3603-d146-4c44-a0ce-ec2b1fa62f91"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("55c2a1a3-b3fb-42ad-a143-9367b62ab9a6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("56eb9060-a43f-4891-bf1a-5356f47b3872"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("56ee8d9f-89a1-4126-8338-4a2a44e8c160"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("56f3750d-76fe-4e76-b0c6-c18b7a84951d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("57344535-a150-4b58-836e-0a0b4ffec728"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("573f0fae-d4a9-4b6b-b959-88059e4a42c3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("586e3e42-bc82-488c-bdf5-20675330a789"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5901008a-f9f7-4455-b983-4b8b0f811740"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("59160cb8-b649-4600-9907-76f3f0975811"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("593cfbe2-32ec-426e-b89d-794f79f54150"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("59455b30-bf2c-4ab9-adcc-e2013f038ad1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("595e56c2-dd33-4cfa-a85b-14baa45fbeb3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5a09b2fe-0596-4a01-a2b1-880ccae3d756"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5b638ca7-83e4-4480-9a96-5b4695ebe86b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5bb48df9-6fa5-42cf-8899-07e7b999dda7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c2842d1-58d8-4050-810d-1037da2bfbae"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c293541-2943-4e58-89e2-cd363d9223af"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5c356b0f-084c-493f-958d-214958ad9e20"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5e56d3df-d043-4d38-a992-243c20203e9e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5e58c9d4-0314-4826-82b0-b28b802f2509"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5ee9f75c-75aa-4cfd-859b-c9db2e562245"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5f0f0e4b-3ba4-4d31-a561-2b484f823099"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5f658c15-b545-4a98-9a39-0606d4a45b3f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("5f6cd75c-0763-412a-8654-445f5802eb12"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("60b1ee61-4d5c-40e9-81cd-6ac9c4fba95d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("60b8b3b7-97d4-41dc-a979-3244cd569ede"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("61c1ebeb-9e94-4861-a094-e2ca27bd37ed"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("61e7b4ff-35bf-413a-b12e-0a8ff81ea9f1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("620e10db-bcd7-453e-aaab-b4b69590539a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6279422b-2750-4885-8340-4cb81a396290"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("629bd506-c294-4622-bd6c-bd7c74a87649"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("63a56921-19b4-433d-a1c1-49d80ed24607"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("63e8286e-4ec2-4e09-accf-d2ae18935fcd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("64aab650-6815-4a2e-939f-61a6b8702532"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("64b06edf-5ec1-4530-bccb-166e7daea158"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("659cb894-4b92-4e29-bbd1-b1dd5f7aff7f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("65df5e00-f949-4abf-b517-9cae86220224"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6708c3a1-b6cc-44e9-b078-921296134a28"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("676a61e1-f478-486b-8c5a-e320423ac258"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6773cb34-ee66-4f3b-899a-71108ceb81cc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("67d51185-fdc3-4c75-b2e3-c13a624f2b92"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6868d2ba-2326-4032-ab24-f5772a3c131a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6903234d-f453-4593-aee9-e918b3325f6a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6a41fb84-c4c9-4b60-b4ce-93982420c17b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6a9eb7cc-7eac-4a55-a40a-27e9a019352c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6ad3da42-b7c6-4e44-9154-be3dd413b1c6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6d2c56c6-9ecf-49ce-ade5-c43052ef5e91"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6dbc967c-7c46-4d06-b592-dfe89700c05e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6e92be27-54b1-402c-8891-6206dc4a7e18"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6f0653ea-d6c7-43a6-b360-4e3278b736e8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6f1c57a0-f4c4-49c6-b475-e197b3a29e91"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("6fd822cf-8934-4061-a7ff-ea7c0966a897"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("700e1505-1f6c-45b0-8997-25260f502714"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("70574ac7-959b-4431-a261-4688e99836ca"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("706b1f7e-3225-450f-9f57-9d44cd0a9cc4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("716de180-5a20-4acf-8db4-9a61808007a3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("71e08b3b-d308-4cd4-bc0e-fcaa1e962851"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("72a6a683-13af-416e-9718-99798dbc8e93"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7308100f-2e13-4cb9-a808-d8aad173f2ec"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7341a50e-1b8b-4c65-8db4-5b38a71da4c1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("73f45855-439b-46be-ae50-7f97c2158408"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("73fde571-226e-459d-8ecd-cc1e4760a168"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("743c9c80-837e-449d-9d47-a8989135189a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("74679b11-7cac-474e-9a01-306f45d8d808"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("756141a5-f9fe-4ba9-bddf-910be5519800"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("758040bf-5dc7-49c6-a4f2-cd8d83cd2dbe"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7602850f-2459-4fbd-98eb-9c3060a57656"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("766cc4ae-e5c1-4d6d-a0fe-de948e84313b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7738cf5f-6ab9-44e7-a107-08a790471a27"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7834a855-1583-4028-9b52-68249631127e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("797d1802-b412-44d5-8927-7cde98459d8e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7a76bff5-2e13-4288-b931-4d9e14dcfebf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7a78ef0b-7afe-420f-82ab-40efa9eefddf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7abe971e-3b7c-4ddb-bcb8-8c28585e34bd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7bdf9e4f-8b5a-4c7c-a931-f795e98f75e1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7cbd22a3-75f3-4c31-9eb7-805410fa5f5d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7d43ab2c-f287-44eb-8ce3-d9841d0b6805"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7d9bed6a-bb5f-49b9-aafc-a3a1f66b45fb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f904971-6535-4a22-8256-892aca4ad9dc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7f976b96-4c4e-42cf-8a3e-4017e5bd2c10"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("7fb2bf4b-cd7d-4403-be0c-a43bb898b4fe"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("801f9d45-63d5-42ac-9ac5-b9baa4f999a5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("806d58ba-43cb-4530-9271-92aa1767d901"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("809e1fcb-ec41-4ddf-b187-6512541d30f4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("812906c9-e550-4e23-9226-1c87c2662172"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("827fb766-fbf8-4e82-a4cb-3ef8dd5e8a3e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("82fedd8a-51b7-42dd-995a-b17ba8ac44b2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("839f191b-2556-482b-b925-a84c58e4cc48"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("840aff46-d913-4fe3-a7f4-3dfe1445b099"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("843c9f3c-e4a8-4819-bba1-5832a9ff0232"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("84e4e6dd-5acc-46bf-8e59-a585ad51b37f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8598b8a0-b209-4f8e-9420-3994a8102a34"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("86c19e60-a875-417e-a9c7-887c0a27917b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8701d145-989a-43da-8f75-9ed8e94c405e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("872649ce-6d88-423d-81ac-3a75738be24d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("872daf23-6065-4f8a-9166-f675bb526903"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8780b72a-09a3-4e15-8e30-9aa1cbeace31"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("891ca40d-87c0-4d16-b768-a3a60a0985f8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("896c3b44-052f-42fc-a069-064307ce0e25"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("896faa36-444d-4cbf-9a30-535caf43c60b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8b29613a-eab7-4bc4-bb91-7d286001bdeb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8b8197d1-0d89-49f4-866d-95f4850beb42"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8be744ee-1032-4c8f-a6ca-979a3eeea514"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8c587025-781f-4946-9ab2-cb90aac05b18"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8c63bd82-320c-4371-970e-79eb66515bfb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8c64eff6-f4f1-4e47-91cb-80559ec2319d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8c8da164-bb1e-4476-af97-8623a9bf1e19"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8cd80fb9-1d66-46a1-a775-969e5e07646d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8d48c3f4-8028-46cd-a153-8f4c572b2cc4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8dec0c79-246f-4826-90f5-27434d54b58d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8f6bd250-c74e-49b5-a624-41eb5163a55c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("8fa68f6a-4343-4d93-b77c-20f31ef288c7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("903e6605-fe5a-4671-9bb0-e5024abaddec"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("90e80b26-2bf4-4f8f-93a3-90be3681dcc2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("91f69cbf-4958-4a38-b5c5-9de9cfd36c72"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9205bf39-2c09-4b6c-b2c9-e968270fbd10"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9230a23c-f58a-49ad-bf16-f91babdcfd63"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("92351772-fa87-4019-bd85-f2fb0d3e17bd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9291b6fd-f063-4e02-aa07-6163d7434fdb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("934abd05-fa25-4370-a8b5-014bc9acac42"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("93603ab6-8022-4f51-858b-a5512f8f6d24"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("943ce4d0-3b9d-421e-a0de-9cb623d89fa1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("946cd470-8f58-4e48-a3b2-ef210fa03f82"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("94cc245e-22be-4fbe-92e1-ff4b5e936ba1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95082298-7679-4b45-8e6e-111a223c42d8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("956f2e5a-6193-4a2a-bdb3-32ec256c8d90"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95750c0e-9e15-4fdf-b161-dce7e83db1f9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95ab513f-c484-4146-bd3a-d683dfd4f748"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("95dfb6cd-9ccb-4801-8b59-5e12ac1ce4e8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("965dd752-46ff-4087-85ea-2716a1e128f7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("96b6415a-0f04-4fc1-811e-0630f11f9fae"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9855ee8a-9459-4a6d-88f6-f60e212696f9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("98575414-b585-441c-a375-21bf8cf3989c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9a154635-28df-4b7d-a77d-1144c2c465c4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9a4486d3-6270-475f-89b8-e89ebb630491"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9ad3a03c-b139-4ab2-ad68-0d9f8cd8efc3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9b929cd3-050e-4ad4-8677-43b428137bb2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bad7ead-ac43-4894-ad51-9860df7b0f3a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bdecfb0-fa8e-4258-9bb0-ef148c84caef"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9be5869d-4f65-4001-8662-08de3737dd7c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9bf02dcc-b96a-4753-b567-5749e87d384e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9c42990f-3bfe-4835-a146-ac56bfaeb5a2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9c58929b-e310-41c2-99c0-17e256b99b0b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9c797990-d9ed-4766-a50b-cc4f1aec26ab"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("9cf76c57-1c8d-4c4a-a35a-e5b3f87e1da5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a00f12d3-d889-4dca-87b4-c6b1cc9c427d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a02b88ce-52df-426e-8801-03f2ff64c3ef"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a034251b-7da0-4ffa-bb9a-2821e9dc10ad"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a0e27ec5-9cf0-43fb-85d7-6b1110a34068"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a11f380c-9fd0-4d10-b29f-c6191f168f17"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a15955d4-c921-4339-b944-8fb56c9e9d01"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a1d7babe-4c18-4c77-a2b7-9a3bec7a9bd8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a21b5a33-280f-4565-a6bb-d6c3f87d4a01"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a21d1947-ef9c-4a33-a169-c8e67b5436a2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a2e6ff82-8320-49b0-8fee-640629e66014"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a44f35ac-6036-40cf-aa25-f75d5ecd2162"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a55edcc0-1683-472f-941b-966d233ce7f3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a57aeef3-bc57-4e9a-85c5-2faf5f46eaa6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a60dc203-fd4a-4413-8efa-ebbaeaa7a05a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a75bc8dd-7b43-44b2-bd48-4801d9d7330f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a7cedf1c-1589-44f7-828c-68830baa2e5c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a8459a13-c37a-4df4-80f1-de57cd27e828"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a8ce79f9-3129-4ee6-85f6-7236b4a7df64"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a95691a7-8dd8-498f-a5f8-e9438190a00e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a9881247-e17f-4274-a1ce-cf3c750026d8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a9a59904-e8e5-4361-8b09-00cab5b301ed"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("a9f447cb-43cd-478f-a18c-c9132704535d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("aa707255-1c8b-4f0c-8fb4-6aab6d26cef6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("aae77c87-a74e-4bef-af95-f6a5fe4eed7e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("abcdde70-976c-42cb-a755-326341776858"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ac0855e4-8a2a-4550-ba8e-0a4ef7474683"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ad17377b-748b-4579-a06d-9278ddef16cc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ad69173c-4a9a-420d-858d-6c3b3622dd31"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ad99ce06-1b58-42ba-85ea-29c407ce3ba8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("adf0f38f-1b13-43c2-ad27-7892204127ee"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ae44efa6-7c98-4b7b-9a4b-14bb0d74ee0c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ae82cdda-d763-4e06-a285-f2b04b69c950"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("aefc60ae-591e-43e0-967b-cd887db99a85"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("afb32130-ed98-4156-a386-835398ec38c5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b037b585-75a7-4323-b169-a53d34164ba0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b03e578a-a8e7-4897-a56e-85747e3492e1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b105916c-1cd8-4b5f-ba53-e8b65b784781"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b11d5988-a9c1-4ff9-959d-8a37eee6a16f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b1840605-9112-4b75-b448-40fb0ec60f84"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b18af85e-eb2c-4a0f-a0e9-1ad826c44ae3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b235e1cb-6627-4a61-bbfb-c46004f7ad67"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b24e45c1-dda5-4d76-a8db-7d127dd3d579"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b31a2c20-a402-4b40-bf04-49e28bd7c529"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b364c06a-bf57-4174-9654-09389fd63ce2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b38b8e22-f21f-42f5-845f-ed150242de43"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b3f89e0a-e126-4039-a94c-906b588a23a3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b4a5b21c-2689-4531-b789-28e69d67ee37"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b4b96268-683e-4f5f-9a0d-70521a0826f6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b5b793fc-362d-483c-84c2-cd3e1d9fc2f9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b6472eea-7aa9-404d-8aa7-bf5d4aee1f01"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b66a4919-9847-4560-93f4-b4ad2c52be53"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b6d3dbf6-0ae0-4829-932d-647be411eef6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b74a5dd7-dd41-4000-b577-68e930eb1591"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b860d134-f4ad-410c-a3a5-30593b20c7f9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b8962418-ec3b-4709-baf3-b50489cd30e2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b8982d83-7350-41e9-8319-11ff2b9bb87b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("b979a01f-7d64-45dd-be89-45bc98784f1d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ba5225a0-8ae6-45e1-ab60-b59fe1cf2d2b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bb51b5d8-0ea4-4566-98dd-27a09df96869"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bb861c73-42c2-42aa-9eed-d95f184b6596"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bb93a3b5-a5e1-45bb-9751-431696522daf"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bbb57a2a-7a93-429e-970c-d5596bce50ad"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bc085529-1884-4d44-b550-51750535eaeb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bc85b7f0-31b1-4905-b332-1b8eb085dc9b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bc912406-b8d7-442c-8fcd-d22a72236e3d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bd3f046f-87aa-4c53-afa7-85c99bfb6ffa"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("be924219-9c18-4a94-a55f-58c3a5a4a8b6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bed94fb9-2159-47f4-9eb0-2a3f933ce6ba"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("bfb893a8-da11-4a25-979b-a4303e902d7e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c032ba25-f8e0-4a21-8459-4d9190430b01"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c041c9fd-acbd-464f-beec-5f8a19b2d3ee"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c1401c7f-3962-42f8-876e-ad652949ef6f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c2b96ef7-a17a-487c-a906-abd1d9eb2bc2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c2d14423-1f0f-47b5-aa7f-e47d02f13b80"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c3453372-f06d-4a9f-a754-9752e5c61306"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c3455c55-4397-4afd-9ab7-6e359e91565d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c34f1509-b072-4adb-af8a-9901af3911f9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c39a7834-c82d-4b1d-b8b3-6a6bd64368b3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c43a09a3-59e0-4a17-aa81-a7f6ceaeb7da"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c5ec1c28-e1a0-4a87-b679-91a4e7fab258"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c70a6ccb-2dc9-4536-ace2-f4ac5ca576dc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c914f033-2bf9-4738-a2c9-67f10e70f777"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c93171c9-1aa2-4910-ba0d-68b4699f30b6"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c95f54ab-28e3-424b-bf4d-beefba85f75d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("c9b9a29c-b7f6-43d9-8cce-bcb60ef45b8b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ca15c807-831e-4d66-a75d-2dd07cd4b9f1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ca35f4ef-e95b-4539-93b1-c1a7b926d58b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ca8ae0b5-2c4e-446d-9b35-2936eecf1c08"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cb793ea4-6c1c-4100-8b24-c69fd8787923"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cbc9845c-c726-413c-b3b0-76bd04fe4b6b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cc311c98-288f-4cbc-b480-7f63a42bae2e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd1dcc5b-7546-4b47-a8b0-43c927756735"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd3f24c0-fc6f-4297-8688-4edbc941fa2e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cd92060d-6fb6-448c-815d-865c8d300015"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cdc1a185-0b73-4e9f-b96f-11dd7b59d2c2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ced5584b-bc84-43d2-ad86-1d8345db0236"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cf4cfd11-aeaa-4536-87aa-d0384bc0f98e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("cfb0d9fb-3c91-44b0-b9a6-14f6ccf16ea3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d06f3944-5e5f-424c-b2db-cc1c214f3643"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d1a292ff-8e0a-4ff2-9a66-542646aed582"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d21e860f-c709-46d9-b4e8-72fe454666ae"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d269e91e-2930-4045-b693-a3d3a00e5ce1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d27bde5f-50d9-4e9b-9cfa-ff2f9572540a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d2ea5717-3c2d-4877-b11f-4e77621c1108"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d3021f38-eb66-43cd-a371-cba97886d388"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d30d1e09-c47d-45af-b18d-9e809b0e465b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d411672e-aeb1-4635-a5bc-631c9bd2e046"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d5376653-8719-46df-b2be-dffba353ae17"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d6e410f5-4882-4564-9997-988abd6b15ae"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d72f7a38-ff08-4a13-92ce-1aae5adb2ba9"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d7b1b7de-2d60-4a4c-a8ab-88c8e84654e1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d7c20fd7-9f16-4723-a06f-db642da1e2e3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d84f6eee-4957-449f-8897-aae10343c51b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d88db3df-fde9-4dc1-a835-2bc113b28b39"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d89f0385-0847-4456-8ecc-7d35595d7ef5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d8cd30f7-8c94-46a2-ba94-2a36ca222089"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d90a13b6-fb79-45da-ad0c-49496d5b6dd7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("d9feffcf-7c5c-49b2-ab16-ff78905dc047"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("dc5176d7-15b2-4636-a6ae-39718efb1824"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ddd34863-5469-4069-a0a6-23913a8ccb2d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("de177b2a-2886-4f13-8263-f53646bfe951"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("de86007a-f314-4104-bfba-4e54f0a87de1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("df4d2f4a-dba5-4ca9-b9bc-41cfdb3d854b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("df7753f0-5850-4ef4-9c81-8bc779482c18"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("df786801-3860-4eaf-bcd2-f88b12aac8de"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e0be5692-88d3-4b6e-b802-11a4da491193"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e2232f0f-9107-42a2-aeae-c0105ef64245"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e3b4613e-3efd-46fd-93cb-da08b9d77ea7"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e46c0049-9093-4c80-b831-3ab0fe3c8452"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e4bcb530-0375-4005-bd68-bb92c943b1a3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e5d4ff5e-7dfc-470a-a3fc-beeb3934a42a"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e65dd37c-79f3-48a6-83e6-8ccbbea0b61e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e69cfacb-43db-46f8-833a-941b862c9943"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e83f1856-786a-4249-9d85-7978ac6bde03"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9013cd2-beea-4a83-a6b9-bc648b962271"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9102871-63cc-4ec9-b35c-c859b55ee656"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9c21f51-2ddd-47c9-9fb9-4a2f61ac4241"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("e9cd80b1-ed92-4fc9-a371-8489d27e53dc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("eb4e05e5-c20b-4c28-b63b-5f4f0a597994"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("eb7050bf-3ef2-4a3f-a465-50a7f4269249"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ebe37152-af8d-4f1f-ba13-2b43d710e62f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ec43faf9-c930-4da9-9637-8b39ed0de878"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ec836db6-bed8-41bd-b99b-ac36b5c00807"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ecdccf72-938d-4fbf-a1ac-e5ca9d18a690"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("edb80cf0-d651-4838-8e60-917a193a8919"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("edbac97d-02df-47f2-9dbe-ea21f11dcfc1"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("edf5e8fe-e357-4184-818f-56ec7dbd5f96"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ee547548-b1fd-4b57-b93a-5b15228b3b84"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef18b709-576b-410d-97b6-6ee73ccbee94"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef5d2764-cdbc-4e73-b4ab-e4f4829e031d"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef9cd989-6426-4526-9fbb-a1e7a63953fd"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ef9e6208-1e7e-46d7-9992-df0e95f36997"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f1391096-118a-425d-85e7-061b0bc904fe"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f19b9325-52e7-48e4-b9d2-1eda54c0178c"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f28786d5-f933-437d-8f12-02b39e684566"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f2c17bf3-5d78-4b4d-a5e1-4204989266f4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f2ddca4c-85a3-49a5-8467-0ee8e1ade35f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f343fc73-f4e3-4e20-89da-775416f0a77f"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f3efc6bb-7b93-47ae-9a35-35ea220e4dab"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f50159ac-d588-438a-9179-a3e957ea05e3"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f513d749-5701-445b-87ef-91fa43bf3be5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f64a0f75-4cdb-4a6d-9f7d-a119ecabf23b"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f650cf3a-5255-4421-9233-45a82d82b0fc"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f6b44712-9df6-456e-967d-7c2ee35f2baa"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f6d85ea5-443c-4159-983a-1a34f3eec176"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f761ba51-85f3-4d0c-b051-5afb5ecdecc4"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f7a94836-6f0b-429f-ad5e-70286cdf5cf2"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f7df179b-1789-42a7-af10-65ed0813be11"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f8557a03-51e7-48cf-b118-f968e576d162"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f869e496-aa7e-46ca-a773-9f8cab2f6970"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f8ca9803-4765-4b8b-bbb1-25b77094b035"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f97654d4-028d-40e7-a3b4-6b39bc217e4e"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("f97d7bc4-3057-48e1-ae87-44fedfe30857"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fa14b4de-d534-4067-8f86-4b61f2f65fb8"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fa205dfb-d174-4262-9012-87dc443bed50"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fa37989a-2847-499b-8978-f79a42e5efbb"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fbb9cd22-59d5-43fd-a97e-6448308dc8c0"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fcdd4bf0-1481-4972-92e6-03ab936d8243"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("fe05be29-f5a4-4663-a7a6-fdd42ebdf766"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ff755268-742f-4a26-af73-73401c991cee"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ffdd2c03-5a77-4bdb-90e3-83c7759deaf5"));

            migrationBuilder.DeleteData(
                table: "QueryTransportOptions",
                keyColumn: "Id",
                keyValue: new Guid("ffe06f8c-2681-4e0d-b3c4-d1a9ea89d847"));

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
        }
    }
}
