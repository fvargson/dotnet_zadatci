using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 1, "+385-HRV-191", "Hrvatska", "Croatia" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 2, "+380-UKR-142", "Ukrajina", "Ukraine" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "id", "city_name", "country_id", "latitude", "longitude" },
                values: new object[,]
                {
                    { 1, "Zagreb", 1, 45.815399m, 15.966568m },
                    { 2, "Rijeka", 1, 45.328979m, 14.457664m },
                    { 3, "Vinkovci", 1, 45.287865m, 18.802666m },
                    { 4, "Кiев", 2, 50.450001m, 30.523333m },
                    { 5, "Донецк", 2, 48.002777m, 37.805279m },
                    { 6, "Одесса", 2, 46.482952m, 30.712481m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
