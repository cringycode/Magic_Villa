using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Magic_Villa_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqm", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2814), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Royal Villa", 4, 200.0, 550, new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2825) },
                    { 2, "", new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2827), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2827) },
                    { 3, "", new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2829), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2829) },
                    { 4, "", new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2831), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg", "Diamond Villa", 4, 550.0, 900, new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2831) },
                    { 5, "", new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2833), "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2833) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
