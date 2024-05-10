using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magic_Villa_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumberTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1898), new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1902), new DateTime(2024, 5, 10, 18, 19, 38, 795, DateTimeKind.Local).AddTicks(1903) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2814), new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2827), new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2829), new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2831), new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2833), new DateTime(2024, 5, 8, 19, 5, 49, 337, DateTimeKind.Local).AddTicks(2833) });
        }
    }
}
