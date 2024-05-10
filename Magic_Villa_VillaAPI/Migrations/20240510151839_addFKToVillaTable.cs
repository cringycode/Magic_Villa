using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magic_Villa_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addFKToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6196), new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6209), new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6211), new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6215), new DateTime(2024, 5, 10, 18, 48, 38, 739, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

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
    }
}
