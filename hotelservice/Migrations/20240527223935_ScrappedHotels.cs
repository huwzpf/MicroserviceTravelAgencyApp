using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotelservice.Migrations
{
    public partial class ScrappedHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "FoodPricePerPerson", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("1074a13e-c554-433c-a3e4-50564106b112"), "Chania", "grecja", 37m, "Rethymno Mare Water Park", "Leoforos Vasilissis Sofias" },
                    { new Guid("12b63b13-0780-4dd0-bf96-564594543b79"), "Maresme", "hiszpania", 84m, "Reymar Playa", "Paseo del Prado" },
                    { new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"), "Durres", "albania", 101m, "Bonita Luxury Hotel", "Rruga Abdyl Frasheri" },
                    { new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"), "Riwiera", "chorwacja", 30m, "Nano", "Maksimirska ulica" },
                    { new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"), "Alam", "egipt", 98m, "MG Alexander The Great", "Sharia Gamal Abdel Nasser" },
                    { new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"), "Vlora", "albania", 119m, "MonteCarlo Lungomare", "Rruga e Kavajes" },
                    { new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"), "Almeria", "hiszpania", 119m, "Evenia Zoraida Beach Resort", "Paseo del Prado" },
                    { new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"), "Olimpijska", "grecja", 86m, "Dias Apartments", "Plateia Syntagmatos" },
                    { new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"), "Nero", "grecja", 90m, "Studia Maria", "Leoforos Alexandras" },
                    { new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"), "Turecka", "turcja", 45m, "Kolibri Hotel", "Atatürk Caddesi" },
                    { new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"), "Sheikh", "egipt", 62m, "Falcon Naama Star", "Sharia Salah Salem" },
                    { new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"), "Marmaris", "turcja", 65m, "Turunc Resort", "Bağdat Caddesi" },
                    { new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"), "Heraklion", "grecja", 85m, "Irini Studios", "Plateia Syntagmatos" },
                    { new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"), "Riwiera", "chorwacja", 37m, "Apartamenty Makarska", "Maksimirska ulica" },
                    { new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"), "Sheikh", "egipt", 76m, "Old Vic Resort Sharm", "Sharia Ramsis" },
                    { new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"), "Alam", "egipt", 86m, "Protels Crystal Beach Resort", "Sharia Tahrir" },
                    { new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"), "Durres", "albania", 110m, "Diamma Resort", "Rruga Abdyl Frasheri" },
                    { new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"), "Alam", "egipt", 118m, "Marina Lodge Port Ghalib", "Sharia Ramsis" },
                    { new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"), "Kalabria", "wlochy", 90m, "Hotel Orizzonte Blu", "Via Nazionale" },
                    { new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"), "Turecka", "turcja", 81m, "Kleopatra Micador", "Atatürk Caddesi" },
                    { new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"), "Kalabria", "wlochy", 73m, "San Domenico", "Via del Corso" },
                    { new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"), "Riwiera", "chorwacja", 92m, "Gradac", "Kapucinska ulica" },
                    { new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"), "Durres", "albania", 40m, "Casa Durres", "Rruga e Dibres" },
                    { new Guid("90f8336e-35db-4c21-af68-411ee95df62c"), "Peloponez", "grecja", 31m, "Aldemar Olympian Village", "Leoforos Alexandras" },
                    { new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"), "Turecka", "turcja", 90m, "Kimeros Park Holiday Village", "Bağdat Caddesi" },
                    { new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"), "Luz", "hiszpania", 45m, "Estival Islantilla", "Calle Mayor" },
                    { new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"), "Riwiera", "chorwacja", 84m, "Apartamenty Omiś", "Vukovarska ulica" },
                    { new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"), "Sheikh", "egipt", 87m, "Barcelo Tiran Sharm Resort", "Sharia Tahrir" },
                    { new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"), "Alam", "egipt", 75m, "Bliss Nada Beach Resort", "Sharia Tahrir" },
                    { new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"), "Brava", "hiszpania", 82m, "Cartago Nova by Alegria", "Paseo del Prado" },
                    { new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"), "Vlora", "albania", 44m, "Monte Carlo Vlora", "Rruga 28 Nentori" },
                    { new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"), "Riwiera", "chorwacja", 100m, "Villa Penava", "Trg bana Josipa Jelačića" },
                    { new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"), "Turecka", "turcja", 82m, "Melissa", "Halaskargazi Caddesi" },
                    { new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"), "Alam", "egipt", 74m, "Marina Resort Port Ghalib", "Sharia Tahrir" },
                    { new Guid("c94df083-fc2a-4695-8493-f02af5db384b"), "Kalabria", "wlochy", 70m, "Rada Siri", "Via Veneto" },
                    { new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"), "Brava", "hiszpania", 66m, "GHT Oasis Park & Spa", "Gran Vía" },
                    { new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"), "Durres", "albania", 103m, "Pinea Resort & Spa", "Rruga e Dibres" },
                    { new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"), "Nero", "grecja", 80m, "Studia Katerina", "Leoforos Vasilissis Sofias" },
                    { new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"), "Brava", "hiszpania", 76m, "Evenia Olympic Park", "Calle Mayor" },
                    { new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"), "Brava", "hiszpania", 60m, "Catalonia", "Calle de Alcalá" },
                    { new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"), "Turecka", "turcja", 119m, "Andriake Beach Club Hotel", "Atatürk Caddesi" },
                    { new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"), "Durres", "albania", 102m, "Mel Holidays", "Bulevardi Bajram Curri" },
                    { new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"), "Kalabria", "wlochy", 109m, "Baia di Zambrone", "Via Veneto" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Count", "HotelId", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("007e116e-5e14-44b2-a901-f95b9305214b"), 3, new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"), 117m, 2 },
                    { new Guid("0430961d-58e0-47ba-aa32-9917a663afd6"), 1, new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"), 181m, 3 },
                    { new Guid("04c45f0f-31bb-450e-a0bd-5810b20f48a4"), 3, new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"), 151m, 5 },
                    { new Guid("066af1ee-3733-4286-aea9-4d268b25a9eb"), 1, new Guid("c94df083-fc2a-4695-8493-f02af5db384b"), 172m, 5 },
                    { new Guid("0c1fed65-29b3-4843-af11-61a453c11fd6"), 3, new Guid("12b63b13-0780-4dd0-bf96-564594543b79"), 211m, 4 },
                    { new Guid("0c84ce5a-45be-4560-b7c5-db12e3259527"), 1, new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"), 59m, 5 },
                    { new Guid("13e992a5-e98c-4adf-8f87-7353cf4223d2"), 3, new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"), 57m, 4 },
                    { new Guid("1418ece0-c1ed-4510-90f8-90a2e3550205"), 3, new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"), 50m, 2 },
                    { new Guid("14a92577-fa68-4479-a05c-4e17151c31b4"), 2, new Guid("c94df083-fc2a-4695-8493-f02af5db384b"), 159m, 2 },
                    { new Guid("15d09c0a-bf6e-48bc-a6e1-12b604a81cb3"), 3, new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"), 168m, 2 },
                    { new Guid("174248b0-58c6-4e71-b9d1-a80d6dd56315"), 2, new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"), 171m, 2 },
                    { new Guid("1918ae9f-49c5-4f80-8e5f-f811ea8a83fd"), 3, new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"), 150m, 5 },
                    { new Guid("1b42c77c-949c-4be3-b950-c7ce324dbe54"), 3, new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"), 206m, 2 },
                    { new Guid("1cbf812e-60b5-4858-b89a-aaa8f289f29a"), 1, new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"), 104m, 5 },
                    { new Guid("200ec92a-e88a-4d24-b23b-7a4085e6eb20"), 2, new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"), 205m, 2 },
                    { new Guid("20b61173-6008-48cf-925d-e4bc30c193fe"), 1, new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"), 247m, 5 },
                    { new Guid("24004a7d-8948-4036-9c6e-44afe5f5a2db"), 1, new Guid("1074a13e-c554-433c-a3e4-50564106b112"), 205m, 4 },
                    { new Guid("2c4a9505-3173-48de-9c5f-4f6322a78f45"), 2, new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"), 192m, 5 },
                    { new Guid("2c5d580a-b6fe-4620-99c8-0b53fcfdcad6"), 3, new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"), 55m, 2 },
                    { new Guid("2cf8fb5f-5cb5-4081-9705-ac620652537f"), 2, new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"), 87m, 3 },
                    { new Guid("2e156c3f-477d-4925-be76-ed961b63aa0c"), 2, new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"), 120m, 5 },
                    { new Guid("2f180121-5960-4020-9655-297b289a2de4"), 1, new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"), 208m, 5 },
                    { new Guid("2fdfd16e-2e6c-4e0e-a966-d7093ae5e0bc"), 3, new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"), 57m, 5 },
                    { new Guid("3119c03c-010c-4e92-bab8-6f34f20186cd"), 3, new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"), 141m, 4 },
                    { new Guid("3829f8a2-08bf-4e99-b497-0657a505e5bc"), 3, new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"), 65m, 2 },
                    { new Guid("3b1ce55d-3252-468f-8930-aa73eb279653"), 3, new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"), 181m, 3 },
                    { new Guid("3b3906cf-e16a-4a4b-b393-2b6b47686e40"), 2, new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"), 219m, 2 },
                    { new Guid("3b45f947-b7d1-4371-87bb-81a07f293c5a"), 3, new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"), 204m, 2 },
                    { new Guid("3f5c0faa-0372-4aaa-bd6c-011758facc2d"), 3, new Guid("1074a13e-c554-433c-a3e4-50564106b112"), 62m, 3 },
                    { new Guid("40c51aa1-1dcc-4404-bcab-a6db383313d6"), 1, new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"), 118m, 2 },
                    { new Guid("41d23654-6590-4ee9-9452-dfd3ee433cf6"), 1, new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"), 183m, 4 },
                    { new Guid("4252ce03-14d6-4c8d-8a22-53a6bcec53cc"), 1, new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"), 140m, 5 },
                    { new Guid("44321137-fda7-4716-b023-8ada0aadd844"), 1, new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"), 159m, 2 },
                    { new Guid("45b6e24b-be1d-4043-bbb2-7cd307712ed6"), 2, new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"), 149m, 3 },
                    { new Guid("4798c241-b744-4a56-b436-9b5bd5a6f71c"), 2, new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"), 100m, 4 },
                    { new Guid("495cd99b-6d24-4ecb-96f6-6c6a0d5a13a6"), 1, new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"), 249m, 2 },
                    { new Guid("4a0367a7-d5e8-4aa8-9df2-9980ec300952"), 2, new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"), 202m, 2 },
                    { new Guid("4a6d17ae-1869-4f74-bb28-ed9748528a85"), 3, new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"), 133m, 3 },
                    { new Guid("4ac29a10-7c62-4f9b-bd02-6b4788883e77"), 2, new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"), 51m, 5 },
                    { new Guid("4c948705-55a8-49ab-b9fa-e21a7c570b1c"), 3, new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"), 52m, 5 },
                    { new Guid("4d5cd011-0823-41c1-b401-fdf7006aaf0f"), 3, new Guid("c94df083-fc2a-4695-8493-f02af5db384b"), 153m, 3 },
                    { new Guid("512200cf-c63e-4836-bbfd-981eff207c2f"), 1, new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"), 99m, 3 },
                    { new Guid("516261f7-4a2d-4b70-965f-056286aaa289"), 3, new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"), 230m, 2 },
                    { new Guid("51db99ad-652d-4829-b36b-01679060b498"), 1, new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"), 171m, 2 },
                    { new Guid("53b9c8e0-1a59-4d88-bece-76bad7b0f6f3"), 1, new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"), 65m, 4 },
                    { new Guid("54263b90-b24d-4ed5-a5eb-a1f878c0c686"), 3, new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"), 147m, 3 },
                    { new Guid("54a74870-d544-46f1-9b83-eaa2261ea07b"), 2, new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"), 92m, 4 },
                    { new Guid("54ad1dcb-4e4a-4f02-97e1-0b2b3dbe22c8"), 2, new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"), 214m, 3 },
                    { new Guid("5542537c-39fa-424b-9d9b-e92e05a8019a"), 1, new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"), 116m, 4 },
                    { new Guid("56115bea-f0b9-440e-b245-a543fa79da02"), 1, new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"), 97m, 3 },
                    { new Guid("57781933-1902-4059-abd2-39062bd8a812"), 2, new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"), 143m, 5 },
                    { new Guid("57826ac0-eea7-4c6a-ac1b-d0df116fe8d5"), 3, new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"), 109m, 3 },
                    { new Guid("57a98880-8f0c-4336-bbc8-005e44820d6e"), 1, new Guid("90f8336e-35db-4c21-af68-411ee95df62c"), 235m, 5 },
                    { new Guid("593a4bf8-18ce-433d-bb7a-c9f80747fa14"), 3, new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"), 148m, 5 },
                    { new Guid("5a2c6e11-c61d-4c56-93a5-1eb1d2efcdd2"), 2, new Guid("1074a13e-c554-433c-a3e4-50564106b112"), 176m, 2 },
                    { new Guid("5c13a966-2cab-4b1f-b67a-4fba7687f54a"), 1, new Guid("90f8336e-35db-4c21-af68-411ee95df62c"), 113m, 3 },
                    { new Guid("60f3d306-da90-4524-a501-9aba826e39cd"), 3, new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"), 167m, 3 },
                    { new Guid("6611ae3c-51cb-42bb-8f9b-a92dda284823"), 3, new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"), 98m, 4 },
                    { new Guid("6687abb6-e85e-4816-9240-afa23c80a4f5"), 2, new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"), 196m, 5 },
                    { new Guid("67bbf2e7-a3c0-4b08-a1b8-4ed656494b3a"), 3, new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"), 119m, 3 },
                    { new Guid("67d5d998-c1a5-4fa9-8e06-c5169ecce3b2"), 2, new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"), 159m, 4 },
                    { new Guid("68962468-9e2f-42cd-80b2-0569900b296e"), 2, new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"), 236m, 3 },
                    { new Guid("694dd827-981e-4980-b736-9a27cd33e247"), 3, new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"), 197m, 2 },
                    { new Guid("69b5b886-7003-46b1-a073-c9942d993c89"), 3, new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"), 235m, 3 },
                    { new Guid("6ce365ec-de05-4f5b-bc14-3ac652664fca"), 1, new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"), 240m, 5 },
                    { new Guid("6dfe53b7-4e6b-48b5-bcd6-ad2ffa1d661a"), 3, new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"), 229m, 2 },
                    { new Guid("70e4dd97-5e09-4fca-aadc-4b88a3883094"), 3, new Guid("1074a13e-c554-433c-a3e4-50564106b112"), 183m, 5 },
                    { new Guid("713dcc4f-adc2-46f2-904e-150f8ffc712f"), 3, new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"), 55m, 4 },
                    { new Guid("71b1b9d4-87f9-4978-aee0-62581dd04ab8"), 3, new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"), 85m, 5 },
                    { new Guid("726e803d-bed0-48f0-b30f-bce375ef4cdc"), 3, new Guid("90f8336e-35db-4c21-af68-411ee95df62c"), 186m, 2 },
                    { new Guid("7278811a-2838-4d30-b246-01dbe87bb948"), 3, new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"), 118m, 4 },
                    { new Guid("73b4b533-f7c1-4869-b23d-9c379be0f30d"), 2, new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"), 130m, 4 },
                    { new Guid("73dd3d70-98a4-4ba4-b996-61728bb04747"), 3, new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"), 127m, 5 },
                    { new Guid("74b80e8c-080f-4b4e-9d56-08a6a0636359"), 2, new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"), 137m, 3 },
                    { new Guid("751994d4-641e-4ae9-8bd7-abee30eedd29"), 1, new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"), 215m, 5 },
                    { new Guid("78d34f6a-3ace-4ed5-84b0-12db85ec8d6f"), 1, new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"), 158m, 2 },
                    { new Guid("792726b0-b2cb-4ae9-bd77-42d47183497e"), 3, new Guid("12b63b13-0780-4dd0-bf96-564594543b79"), 135m, 3 },
                    { new Guid("798c8989-971e-4744-8abc-2f836db0dcca"), 3, new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"), 226m, 4 },
                    { new Guid("79e30df7-fd01-42d4-929a-9ba59c1d7a2a"), 2, new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"), 222m, 4 },
                    { new Guid("7b7afac8-cbd5-4524-9389-b6086d26cda3"), 1, new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"), 165m, 5 },
                    { new Guid("7fdba6f3-da59-449c-9d74-aa0a5828ef6a"), 2, new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"), 178m, 3 },
                    { new Guid("803fc3f1-e31b-43f1-b258-875c28bf4bf8"), 3, new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"), 183m, 4 },
                    { new Guid("80930220-b37d-432f-9743-6e801c23b524"), 1, new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"), 228m, 5 },
                    { new Guid("836d9cbd-611d-4468-97b2-002079a3e7f0"), 3, new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"), 185m, 4 },
                    { new Guid("849a08c6-5daa-4884-833d-4cbbc8a7740e"), 2, new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"), 165m, 3 },
                    { new Guid("86dbb60f-1d3f-45c9-8a04-4a2135c6c852"), 1, new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"), 146m, 5 },
                    { new Guid("87567091-319d-4837-81d8-8d79f767ffd0"), 2, new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"), 148m, 3 },
                    { new Guid("88645b4d-5276-4d7a-8715-9c6fd1979060"), 1, new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"), 92m, 2 },
                    { new Guid("89bcb243-605e-4969-a9da-04bb1b6930a2"), 3, new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"), 196m, 2 },
                    { new Guid("8aa504e7-7953-4544-8edb-851a67255a69"), 2, new Guid("12b63b13-0780-4dd0-bf96-564594543b79"), 98m, 2 },
                    { new Guid("8e1dfed5-ac9d-4c8f-98cf-74a915248e6e"), 1, new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"), 241m, 3 },
                    { new Guid("8efc2198-7829-4d5e-a14a-39a7c7499a4a"), 3, new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"), 229m, 3 },
                    { new Guid("8f1e3364-f11c-4d59-a2a6-e700b58cbb3e"), 2, new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"), 53m, 3 },
                    { new Guid("918a5b35-a35b-45c7-9c6c-0f538735ad68"), 3, new Guid("c94df083-fc2a-4695-8493-f02af5db384b"), 173m, 4 },
                    { new Guid("92a55e94-13fa-49cb-8dce-333bc539dfbd"), 2, new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"), 168m, 4 },
                    { new Guid("949746a0-5da5-4b2d-9780-24b028531826"), 2, new Guid("90f8336e-35db-4c21-af68-411ee95df62c"), 161m, 4 },
                    { new Guid("953cfcf3-911b-48fd-bba7-ac601a35c926"), 3, new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"), 63m, 2 },
                    { new Guid("95fa4e01-26db-4bdc-b645-fe0a990ba9e0"), 3, new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"), 194m, 5 },
                    { new Guid("99ea04bb-bc21-41aa-bbdb-b034f62012e4"), 2, new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"), 193m, 3 },
                    { new Guid("9bad65ec-6c07-465c-891e-7cc341dd29d5"), 1, new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"), 106m, 5 },
                    { new Guid("9d6b3e15-5c44-41ae-8cb7-2d9c0bb5e03f"), 1, new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"), 163m, 2 },
                    { new Guid("9db5fcdb-4dba-4105-9678-6ae3874745ff"), 3, new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"), 201m, 3 },
                    { new Guid("9dc2fadd-db14-44ab-99be-c622d61708fd"), 1, new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"), 92m, 2 },
                    { new Guid("9e2de49c-84e3-4deb-a2aa-10fc7080c6f3"), 2, new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"), 77m, 5 },
                    { new Guid("a312fab8-8d93-4287-96f4-44965d4c706d"), 1, new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"), 127m, 3 },
                    { new Guid("a40f8917-2338-444f-bb53-867e04022003"), 3, new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"), 134m, 4 },
                    { new Guid("a6609dd8-3ff9-4002-b620-0f71484b5761"), 2, new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"), 140m, 2 },
                    { new Guid("a953dcf5-8355-4fab-be62-7df4bf005084"), 2, new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"), 149m, 5 },
                    { new Guid("a9af942a-68a5-4a93-88dd-312be3396bc3"), 2, new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"), 161m, 2 },
                    { new Guid("aeb30c86-5233-4278-948f-e1097a217b83"), 1, new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"), 250m, 4 },
                    { new Guid("b0094f58-91d3-4cba-a057-0761c3398e4a"), 1, new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"), 103m, 2 },
                    { new Guid("b214b9af-3a88-4d13-a160-d01edfdb70f6"), 3, new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"), 57m, 2 },
                    { new Guid("b2a3ad0e-e8e0-4153-9b80-09d79ca8ee5a"), 2, new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"), 139m, 4 },
                    { new Guid("b52de355-1c63-4135-a8b3-11f2df71c7e3"), 1, new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"), 80m, 4 },
                    { new Guid("b7cc4f19-ccb6-4a0f-95f5-33733d13596c"), 3, new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"), 250m, 3 },
                    { new Guid("ba987fb6-1afb-4e2f-bea0-875d4b082714"), 1, new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"), 185m, 4 },
                    { new Guid("bdece263-a952-4bac-b377-3309911e4bdf"), 2, new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"), 177m, 3 },
                    { new Guid("c057e082-602f-4122-8e3c-2af7246567d8"), 2, new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"), 87m, 4 },
                    { new Guid("c05f6931-f618-4506-b209-b2b698c930e9"), 1, new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"), 215m, 4 },
                    { new Guid("c11520f6-8ef1-4f5b-b1b2-870a73622419"), 3, new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"), 236m, 2 },
                    { new Guid("c197c5a7-5d77-4769-8e95-789eaaf1c993"), 3, new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"), 73m, 5 },
                    { new Guid("c1dfdf73-4c9d-4615-8d43-dae9ce364982"), 1, new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"), 209m, 3 },
                    { new Guid("c1dff838-695b-48b5-9f89-65c0e4e58f7d"), 2, new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"), 51m, 2 },
                    { new Guid("c1fb9b9d-370b-49bf-a190-f06b8b13f03b"), 3, new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"), 222m, 4 },
                    { new Guid("c273dd33-e0dd-4157-b3b2-80e097abbdab"), 1, new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"), 248m, 5 },
                    { new Guid("c3e79e25-4d71-4648-bb6d-c7aa1b912e5f"), 3, new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"), 52m, 5 },
                    { new Guid("c5339276-939b-4814-a8a5-b605c468ef42"), 2, new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"), 226m, 5 },
                    { new Guid("c6a5250d-afc7-45f6-ad10-d6368066fe70"), 1, new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"), 139m, 2 },
                    { new Guid("c8871faa-b4e1-4879-9d1b-6fb33485a16d"), 2, new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"), 159m, 3 },
                    { new Guid("c966fa97-55a8-4aca-978e-65bbd61d4eab"), 3, new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"), 153m, 3 },
                    { new Guid("caa23a2b-7ce5-4444-a6c1-098a43e8b7d1"), 3, new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"), 70m, 2 },
                    { new Guid("cb6f4e7f-21c4-422c-a4d9-6de2ec21eb89"), 3, new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"), 129m, 2 },
                    { new Guid("ccd1ba57-fd75-4be2-a61c-a0d8354510d9"), 1, new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"), 221m, 2 },
                    { new Guid("ced6af0b-0dbd-4c93-87a0-944dfc01510f"), 1, new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"), 222m, 4 },
                    { new Guid("d0a3f9dd-4bc2-47ff-952a-46065f7236d7"), 1, new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"), 192m, 5 },
                    { new Guid("d243bcf1-c3d2-4f34-889b-053fdeba94b6"), 1, new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"), 191m, 5 },
                    { new Guid("d411eef2-c4dc-45f7-bda9-2280254ffce0"), 3, new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"), 146m, 2 },
                    { new Guid("d586051a-6700-4f8c-8ad9-49c76db8fe4e"), 2, new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"), 237m, 4 },
                    { new Guid("d684a8ba-2566-4aea-868f-bfb74631b96e"), 3, new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"), 81m, 5 },
                    { new Guid("d96184b7-97f2-4855-a541-1ef468850857"), 1, new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"), 92m, 3 },
                    { new Guid("d9cc568d-70b0-49ca-aae5-71c613129469"), 1, new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"), 134m, 3 },
                    { new Guid("db96975b-8ea6-40e9-b10e-db15ca6187f9"), 2, new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"), 91m, 4 },
                    { new Guid("dbe9d969-4c1d-48d9-8159-114b38e9d741"), 2, new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"), 206m, 4 },
                    { new Guid("dfda7488-9c3d-4a7d-8911-84f94f9f753e"), 1, new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"), 241m, 3 },
                    { new Guid("e00850ba-ad63-4878-b2a9-292241d241c3"), 2, new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"), 147m, 2 },
                    { new Guid("e009f6e7-4ab0-4cb1-8b44-4c9462c3cb84"), 2, new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"), 140m, 3 },
                    { new Guid("e00f1d8d-5fab-4513-bd46-9de40e1f9121"), 3, new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"), 192m, 4 },
                    { new Guid("e499214d-0065-46b1-9210-6ec5d01119c1"), 1, new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"), 50m, 2 },
                    { new Guid("e6a38b14-c923-43b0-a2b3-fab56f8b4477"), 1, new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"), 87m, 4 },
                    { new Guid("e896168c-9030-4edd-b063-d171eb999d09"), 1, new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"), 244m, 3 },
                    { new Guid("e969af57-73b4-4908-9dcc-479bd868daee"), 1, new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"), 172m, 5 },
                    { new Guid("ea5c9dab-5f14-4b34-af64-3b3ae9a4c69b"), 1, new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"), 76m, 4 },
                    { new Guid("eb5d5452-9889-46d0-8770-957ef9c11613"), 1, new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"), 55m, 5 },
                    { new Guid("ecee996b-0938-464f-a0a8-1c0047cfc8ac"), 2, new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"), 203m, 3 },
                    { new Guid("ecf06b6b-c3e8-48a0-be6e-dfe9bc6e44e5"), 3, new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"), 87m, 4 },
                    { new Guid("ed2c6011-158f-48d5-a158-5d0a3eaba2b3"), 3, new Guid("12b63b13-0780-4dd0-bf96-564594543b79"), 91m, 5 },
                    { new Guid("ef7ade87-faa9-4c99-a0be-aec3db3d6a6f"), 2, new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"), 204m, 4 },
                    { new Guid("f0f05172-bcf3-4183-b6db-77a7e3146721"), 3, new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"), 186m, 4 },
                    { new Guid("f13b3ac5-d662-455d-b136-f5094f1c0957"), 2, new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"), 190m, 5 },
                    { new Guid("f19f6e6f-3d82-4e5c-874c-48e27e052a7b"), 2, new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"), 53m, 3 },
                    { new Guid("f3172922-148a-42b0-a71d-bc14cd3e1e73"), 2, new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"), 152m, 4 },
                    { new Guid("f33b9605-b0e9-4c63-a899-dc004c7c516f"), 3, new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"), 50m, 5 },
                    { new Guid("f36a32fe-170b-457a-93ce-c78382f8b5cb"), 3, new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"), 175m, 5 },
                    { new Guid("f72a153a-2cc1-4170-82a8-ea5c5ed2830e"), 1, new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"), 77m, 2 },
                    { new Guid("f834404a-7693-464a-bb65-e8ad363414be"), 1, new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"), 91m, 4 },
                    { new Guid("f85dce40-9172-4ce5-a4d4-a9069c77ac2a"), 1, new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"), 164m, 5 },
                    { new Guid("f98a7bd5-1b68-4d96-a39c-bb2735961e3b"), 2, new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"), 199m, 3 },
                    { new Guid("f9b3bec4-6817-47a3-ab80-cd6ffa399bb5"), 1, new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"), 163m, 2 },
                    { new Guid("faeae1a4-a512-4684-986b-ad965d19ec6c"), 2, new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"), 244m, 3 },
                    { new Guid("fcfc6d06-90c1-44a7-b8ab-26b2e0ae2130"), 2, new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"), 248m, 3 },
                    { new Guid("fe5c2037-8fa9-4554-b5e7-afd79657e4e0"), 2, new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"), 243m, 4 },
                    { new Guid("fee5db84-7006-494a-82a3-f0ca1b9384dd"), 3, new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"), 174m, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("007e116e-5e14-44b2-a901-f95b9305214b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0430961d-58e0-47ba-aa32-9917a663afd6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("04c45f0f-31bb-450e-a0bd-5810b20f48a4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("066af1ee-3733-4286-aea9-4d268b25a9eb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c1fed65-29b3-4843-af11-61a453c11fd6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0c84ce5a-45be-4560-b7c5-db12e3259527"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("13e992a5-e98c-4adf-8f87-7353cf4223d2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1418ece0-c1ed-4510-90f8-90a2e3550205"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("14a92577-fa68-4479-a05c-4e17151c31b4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("15d09c0a-bf6e-48bc-a6e1-12b604a81cb3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("174248b0-58c6-4e71-b9d1-a80d6dd56315"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1918ae9f-49c5-4f80-8e5f-f811ea8a83fd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1b42c77c-949c-4be3-b950-c7ce324dbe54"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1cbf812e-60b5-4858-b89a-aaa8f289f29a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("200ec92a-e88a-4d24-b23b-7a4085e6eb20"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("20b61173-6008-48cf-925d-e4bc30c193fe"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("24004a7d-8948-4036-9c6e-44afe5f5a2db"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2c4a9505-3173-48de-9c5f-4f6322a78f45"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2c5d580a-b6fe-4620-99c8-0b53fcfdcad6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2cf8fb5f-5cb5-4081-9705-ac620652537f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2e156c3f-477d-4925-be76-ed961b63aa0c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2f180121-5960-4020-9655-297b289a2de4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2fdfd16e-2e6c-4e0e-a966-d7093ae5e0bc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3119c03c-010c-4e92-bab8-6f34f20186cd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3829f8a2-08bf-4e99-b497-0657a505e5bc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3b1ce55d-3252-468f-8930-aa73eb279653"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3b3906cf-e16a-4a4b-b393-2b6b47686e40"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3b45f947-b7d1-4371-87bb-81a07f293c5a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3f5c0faa-0372-4aaa-bd6c-011758facc2d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("40c51aa1-1dcc-4404-bcab-a6db383313d6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("41d23654-6590-4ee9-9452-dfd3ee433cf6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4252ce03-14d6-4c8d-8a22-53a6bcec53cc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("44321137-fda7-4716-b023-8ada0aadd844"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("45b6e24b-be1d-4043-bbb2-7cd307712ed6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4798c241-b744-4a56-b436-9b5bd5a6f71c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("495cd99b-6d24-4ecb-96f6-6c6a0d5a13a6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4a0367a7-d5e8-4aa8-9df2-9980ec300952"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4a6d17ae-1869-4f74-bb28-ed9748528a85"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4ac29a10-7c62-4f9b-bd02-6b4788883e77"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4c948705-55a8-49ab-b9fa-e21a7c570b1c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4d5cd011-0823-41c1-b401-fdf7006aaf0f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("512200cf-c63e-4836-bbfd-981eff207c2f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("516261f7-4a2d-4b70-965f-056286aaa289"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("51db99ad-652d-4829-b36b-01679060b498"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("53b9c8e0-1a59-4d88-bece-76bad7b0f6f3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("54263b90-b24d-4ed5-a5eb-a1f878c0c686"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("54a74870-d544-46f1-9b83-eaa2261ea07b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("54ad1dcb-4e4a-4f02-97e1-0b2b3dbe22c8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5542537c-39fa-424b-9d9b-e92e05a8019a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("56115bea-f0b9-440e-b245-a543fa79da02"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("57781933-1902-4059-abd2-39062bd8a812"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("57826ac0-eea7-4c6a-ac1b-d0df116fe8d5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("57a98880-8f0c-4336-bbc8-005e44820d6e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("593a4bf8-18ce-433d-bb7a-c9f80747fa14"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5a2c6e11-c61d-4c56-93a5-1eb1d2efcdd2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5c13a966-2cab-4b1f-b67a-4fba7687f54a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("60f3d306-da90-4524-a501-9aba826e39cd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6611ae3c-51cb-42bb-8f9b-a92dda284823"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6687abb6-e85e-4816-9240-afa23c80a4f5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("67bbf2e7-a3c0-4b08-a1b8-4ed656494b3a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("67d5d998-c1a5-4fa9-8e06-c5169ecce3b2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("68962468-9e2f-42cd-80b2-0569900b296e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("694dd827-981e-4980-b736-9a27cd33e247"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("69b5b886-7003-46b1-a073-c9942d993c89"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6ce365ec-de05-4f5b-bc14-3ac652664fca"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6dfe53b7-4e6b-48b5-bcd6-ad2ffa1d661a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("70e4dd97-5e09-4fca-aadc-4b88a3883094"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("713dcc4f-adc2-46f2-904e-150f8ffc712f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("71b1b9d4-87f9-4978-aee0-62581dd04ab8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("726e803d-bed0-48f0-b30f-bce375ef4cdc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7278811a-2838-4d30-b246-01dbe87bb948"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("73b4b533-f7c1-4869-b23d-9c379be0f30d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("73dd3d70-98a4-4ba4-b996-61728bb04747"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("74b80e8c-080f-4b4e-9d56-08a6a0636359"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("751994d4-641e-4ae9-8bd7-abee30eedd29"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("78d34f6a-3ace-4ed5-84b0-12db85ec8d6f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("792726b0-b2cb-4ae9-bd77-42d47183497e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("798c8989-971e-4744-8abc-2f836db0dcca"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("79e30df7-fd01-42d4-929a-9ba59c1d7a2a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7b7afac8-cbd5-4524-9389-b6086d26cda3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7fdba6f3-da59-449c-9d74-aa0a5828ef6a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("803fc3f1-e31b-43f1-b258-875c28bf4bf8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("80930220-b37d-432f-9743-6e801c23b524"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("836d9cbd-611d-4468-97b2-002079a3e7f0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("849a08c6-5daa-4884-833d-4cbbc8a7740e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("86dbb60f-1d3f-45c9-8a04-4a2135c6c852"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("87567091-319d-4837-81d8-8d79f767ffd0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("88645b4d-5276-4d7a-8715-9c6fd1979060"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("89bcb243-605e-4969-a9da-04bb1b6930a2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8aa504e7-7953-4544-8edb-851a67255a69"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8e1dfed5-ac9d-4c8f-98cf-74a915248e6e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8efc2198-7829-4d5e-a14a-39a7c7499a4a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8f1e3364-f11c-4d59-a2a6-e700b58cbb3e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("918a5b35-a35b-45c7-9c6c-0f538735ad68"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("92a55e94-13fa-49cb-8dce-333bc539dfbd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("949746a0-5da5-4b2d-9780-24b028531826"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("953cfcf3-911b-48fd-bba7-ac601a35c926"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("95fa4e01-26db-4bdc-b645-fe0a990ba9e0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("99ea04bb-bc21-41aa-bbdb-b034f62012e4"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9bad65ec-6c07-465c-891e-7cc341dd29d5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9d6b3e15-5c44-41ae-8cb7-2d9c0bb5e03f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9db5fcdb-4dba-4105-9678-6ae3874745ff"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9dc2fadd-db14-44ab-99be-c622d61708fd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9e2de49c-84e3-4deb-a2aa-10fc7080c6f3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a312fab8-8d93-4287-96f4-44965d4c706d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a40f8917-2338-444f-bb53-867e04022003"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a6609dd8-3ff9-4002-b620-0f71484b5761"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a953dcf5-8355-4fab-be62-7df4bf005084"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a9af942a-68a5-4a93-88dd-312be3396bc3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("aeb30c86-5233-4278-948f-e1097a217b83"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b0094f58-91d3-4cba-a057-0761c3398e4a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b214b9af-3a88-4d13-a160-d01edfdb70f6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b2a3ad0e-e8e0-4153-9b80-09d79ca8ee5a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b52de355-1c63-4135-a8b3-11f2df71c7e3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("b7cc4f19-ccb6-4a0f-95f5-33733d13596c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ba987fb6-1afb-4e2f-bea0-875d4b082714"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("bdece263-a952-4bac-b377-3309911e4bdf"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c057e082-602f-4122-8e3c-2af7246567d8"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c05f6931-f618-4506-b209-b2b698c930e9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c11520f6-8ef1-4f5b-b1b2-870a73622419"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c197c5a7-5d77-4769-8e95-789eaaf1c993"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c1dfdf73-4c9d-4615-8d43-dae9ce364982"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c1dff838-695b-48b5-9f89-65c0e4e58f7d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c1fb9b9d-370b-49bf-a190-f06b8b13f03b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c273dd33-e0dd-4157-b3b2-80e097abbdab"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c3e79e25-4d71-4648-bb6d-c7aa1b912e5f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c5339276-939b-4814-a8a5-b605c468ef42"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c6a5250d-afc7-45f6-ad10-d6368066fe70"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c8871faa-b4e1-4879-9d1b-6fb33485a16d"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("c966fa97-55a8-4aca-978e-65bbd61d4eab"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("caa23a2b-7ce5-4444-a6c1-098a43e8b7d1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cb6f4e7f-21c4-422c-a4d9-6de2ec21eb89"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ccd1ba57-fd75-4be2-a61c-a0d8354510d9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ced6af0b-0dbd-4c93-87a0-944dfc01510f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d0a3f9dd-4bc2-47ff-952a-46065f7236d7"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d243bcf1-c3d2-4f34-889b-053fdeba94b6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d411eef2-c4dc-45f7-bda9-2280254ffce0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d586051a-6700-4f8c-8ad9-49c76db8fe4e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d684a8ba-2566-4aea-868f-bfb74631b96e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d96184b7-97f2-4855-a541-1ef468850857"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d9cc568d-70b0-49ca-aae5-71c613129469"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("db96975b-8ea6-40e9-b10e-db15ca6187f9"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dbe9d969-4c1d-48d9-8159-114b38e9d741"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dfda7488-9c3d-4a7d-8911-84f94f9f753e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e00850ba-ad63-4878-b2a9-292241d241c3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e009f6e7-4ab0-4cb1-8b44-4c9462c3cb84"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e00f1d8d-5fab-4513-bd46-9de40e1f9121"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e499214d-0065-46b1-9210-6ec5d01119c1"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e6a38b14-c923-43b0-a2b3-fab56f8b4477"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e896168c-9030-4edd-b063-d171eb999d09"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e969af57-73b4-4908-9dcc-479bd868daee"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ea5c9dab-5f14-4b34-af64-3b3ae9a4c69b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("eb5d5452-9889-46d0-8770-957ef9c11613"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ecee996b-0938-464f-a0a8-1c0047cfc8ac"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ecf06b6b-c3e8-48a0-be6e-dfe9bc6e44e5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ed2c6011-158f-48d5-a158-5d0a3eaba2b3"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ef7ade87-faa9-4c99-a0be-aec3db3d6a6f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f0f05172-bcf3-4183-b6db-77a7e3146721"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f13b3ac5-d662-455d-b136-f5094f1c0957"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f19f6e6f-3d82-4e5c-874c-48e27e052a7b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f3172922-148a-42b0-a71d-bc14cd3e1e73"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f33b9605-b0e9-4c63-a899-dc004c7c516f"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f36a32fe-170b-457a-93ce-c78382f8b5cb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f72a153a-2cc1-4170-82a8-ea5c5ed2830e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f834404a-7693-464a-bb65-e8ad363414be"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f85dce40-9172-4ce5-a4d4-a9069c77ac2a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f98a7bd5-1b68-4d96-a39c-bb2735961e3b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f9b3bec4-6817-47a3-ab80-cd6ffa399bb5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("faeae1a4-a512-4684-986b-ad965d19ec6c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fcfc6d06-90c1-44a7-b8ab-26b2e0ae2130"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fe5c2037-8fa9-4554-b5e7-afd79657e4e0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fee5db84-7006-494a-82a3-f0ca1b9384dd"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("1074a13e-c554-433c-a3e4-50564106b112"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("12b63b13-0780-4dd0-bf96-564594543b79"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("17c2a049-354a-4ee9-970b-bebafa860d0b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("1eba02c2-00f8-4190-a118-d4970c7de667"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("318a37a9-8132-4cb5-bab1-df114dafabf4"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("3254d8e1-ade4-4269-afbb-8700239b983e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("33c07c58-128d-4230-b102-2d75ec3f5c6c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("384e7d47-f9e4-432e-9036-34d6da8152eb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("390d22d9-89cb-4b5b-8ed2-db63c20c1fe0"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("392a2517-d760-4f0c-bf1b-3f76ed2a5b5d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("44933f93-2830-46bd-bb3f-90a47a8dd8d3"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("4d41a2f3-e79d-47f6-93e3-31990462b67c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("5219e274-fc18-4abf-b431-a15d0c0980a7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("57b599b2-ea69-400c-80b8-f2222e2cf10c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("593235a6-71b4-4f1b-814f-8338e22fe404"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("61b21151-7cf1-4482-a3dc-37f169d554e1"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("665e3853-5f15-41d7-b1b5-ca6dc35270d1"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("6bc5772a-43c7-4d16-b56a-2fd0f5576681"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("76a510f4-a1ee-40e7-8236-7b58e0772d98"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("832de1a7-b9d9-4bbc-8a4b-c9f68cb0e6fb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("83ce943a-f3df-4fb5-9c37-a659b5afc2c8"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("887a924c-5946-4819-b49c-70a717b9ff2f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("8fb1730f-da85-49ae-910e-558ff4d2e364"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("90f8336e-35db-4c21-af68-411ee95df62c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("91492bb1-767f-4b58-829f-e4475a314d1a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("9699fea0-c651-4a40-828c-1b3e304c3edc"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("984962a4-b362-4e3b-a8c3-5124c19ed106"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("9e0b4c5e-37d8-45cd-a054-e0287686b5ed"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b28d50e4-41b0-403b-af83-5a0c5f733173"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b5dfb131-8042-4bec-ac0e-adc3a18d75d0"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("b77dcf11-ac64-41c1-b658-fdfe1b722440"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("bbf5e021-266d-4020-8279-b6df7f250f53"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c0a97197-ac51-41ab-a63b-340a31f8d25a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c5fcc3f1-ae51-4f8d-93a3-3cbceadd8029"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("c94df083-fc2a-4695-8493-f02af5db384b"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ca7c8aaf-de51-46e6-95f7-f7147440b528"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("d492ac49-473f-40af-a22e-8a09677a4f77"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("ee56336a-9aab-45e9-b0f1-383e9897baf9"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("f869ad97-26c7-45e5-b83c-85723f9867bf"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fa68ad5b-ffbe-48ae-9f93-8fa94bf7226c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fb56e927-a622-46fd-82a7-32bb2c3e30b2"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fcf46a5d-0ca7-4f75-a75e-92d4e4fcfe64"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: new Guid("fd285982-c0cf-4a0c-b248-0b194c17210c"));

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
    }
}
