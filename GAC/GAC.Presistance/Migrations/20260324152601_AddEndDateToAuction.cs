using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddEndDateToAuction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "AuctionRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "ece3070c-161f-4b41-a7e7-5c0d1638e911", "AQAAAAIAAYagAAAAEOZOIXpYuSwSuHsUjSKZ0mkhUfXnxtjfbR/sW6jEBUWj7raSiWm+bUtlC6l/tlem/g==", new DateTime(2025, 3, 24, 15, 25, 56, 184, DateTimeKind.Utc).AddTicks(8486), "ef13c987-2e46-48bd-a35d-b90037bebf41" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(4872), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7117), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7128), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7135), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7139), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7142), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7145), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7155), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7159), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7302), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7348), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7352), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7355), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7358), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7362), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7365), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7368), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7372), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7376), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7379), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7382), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7385), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7388), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7391), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7395), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7398), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7401), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7404), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7407), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7411), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7413), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7416), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7419), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7422), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7425), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7428), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7431), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(1037), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2642), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2664), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2668), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2671), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2674), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2677), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2680), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2683), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2686), new DateTime(2026, 3, 24, 20, 25, 56, 338, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 331, DateTimeKind.Local).AddTicks(6749), new DateTime(2026, 3, 24, 20, 25, 56, 333, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(1993), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2215), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2223), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2227), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2243), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2248), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2261), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2269), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2274), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2289), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2293), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2297), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4549), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4616), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4623), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4627), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4639), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4644), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4679), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4685), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4688), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4692), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4700), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4704), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4712), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4714), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4716), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4718), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4720), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4722), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4724), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4726), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4728), new DateTime(2026, 3, 24, 20, 25, 56, 334, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3026), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3901), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3914), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3916), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3919), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3931), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3934), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3936), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3939), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3943), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3945), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3947), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3950), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3952), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3954), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3956), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(7131), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8724), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8734), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8736), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8738), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8745), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8746), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8748), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8750), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8752), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8753), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8755), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8757), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8759), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8764), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8766), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8767), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8770), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8771), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8773), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8774), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8776), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8777), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8803), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8805), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8807), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8808), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8810), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8812), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8814), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8816), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8817), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8819), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8822), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8823), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8825), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8826), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8828), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8830), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8831), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8833), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8834), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8836), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8838), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8839), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8841), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8842), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8845), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8846), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8848), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8849), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8851), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8852), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8854), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8856), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8857), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8859), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8860), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8862), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8864), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8867), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8868), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8870), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8872), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8873), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8876), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8877), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8879), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8881), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8883), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8884), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8886), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8888), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8899), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8900), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8902), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8904), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8906), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8907), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8909), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8910), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8912), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8913), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8915), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8917), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8919), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8920), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8922), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8923), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8925), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8927), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8928), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8930), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8931), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8934), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8935), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8937), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8938), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8940), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8941), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8943), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8945), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8946), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8949), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8951), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8952), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8954), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8955), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8957), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8959), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8960), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8962), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8964), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8965), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8967), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8970), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8971), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8973), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8975), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8977), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8979), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8980), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8982), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8983), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8985), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8987), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8989), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8990), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9003), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9004), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9006), new DateTime(2026, 3, 24, 20, 25, 56, 342, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 24, 15, 25, 56, 343, DateTimeKind.Utc).AddTicks(6555), new DateTime(2026, 3, 24, 20, 25, 56, 343, DateTimeKind.Local).AddTicks(4589) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "AuctionRecords");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "1bb5eadd-20f0-4f35-844e-8b6520ff3f6e", "AQAAAAIAAYagAAAAELyAuNRTwupF4M2exKspd3o5beIWM9NwUQEGraUn0I3QfjIjX1FbDszWwDom3MHWRg==", new DateTime(2025, 3, 19, 22, 34, 10, 669, DateTimeKind.Utc).AddTicks(3940), "eda04b11-6533-430e-a265-4a672825ad29" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(3371), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4560), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4565), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4567), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4569), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4641), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4644), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4646), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4648), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4649), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4651), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4653), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4655), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4656), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4658), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4660), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4662), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4663), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4665), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4667), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4669), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4671), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4672), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4674), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4676), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4677), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4679), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4681), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4683), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4685), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4686), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4688), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4690), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4692), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4693), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4695), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4697), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4699), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4700), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4702), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(1579), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2272), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2276), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2278), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2280), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2281), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2283), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2284), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2286), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2288), new DateTime(2026, 3, 20, 3, 34, 10, 797, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 792, DateTimeKind.Local).AddTicks(7292), new DateTime(2026, 3, 20, 3, 34, 10, 794, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1380), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1629), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1635), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1639), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1654), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1659), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1673), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1680), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1707), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1720), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1725), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1728), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3697), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3740), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3747), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3751), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3764), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3768), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3771), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3775), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3779), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3782), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3787), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3790), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3798), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3800), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3802), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3803), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3805), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3807), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3808) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3809), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3811), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3812), new DateTime(2026, 3, 20, 3, 34, 10, 795, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(1941), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2703), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2708), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2710), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2712), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2724), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2726), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2751), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2753), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2756), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2757), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2759), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2761), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2763), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2765), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2766), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(8719), new DateTime(2026, 3, 20, 3, 34, 10, 800, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(388), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(394), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(396), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(398), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(403), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(404), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(406), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(429), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(431), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(432), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(434), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(435), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(436), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(441), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(442), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(443), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(446), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(447), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(449), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(450), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(451), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(453), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(454), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(455), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(457), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(458), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(460), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(461), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(463), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(464), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(465), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(467), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(469), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(470), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(472), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(473), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(475), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(476), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(477), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(479), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(480), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(482), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(483), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(484), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(486), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(487), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(489), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(490), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(491), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(493), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(494), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(495), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(497), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(498), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(499), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(501), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(502), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(503), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(505), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(506), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(508), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(509), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(510), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(512), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(522), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(523), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(524), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(526), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(528), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(529), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(530), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(531), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(533), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(534), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(535), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(536), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(538), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(539), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(541), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(542), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(543), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(544), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(546), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(547), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(549), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(550), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(551), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(553), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(554), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(556), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(557), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(559), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(560), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(561), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(563), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(564), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(566), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(567), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(568), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(570), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(571), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(572), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(574), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(575), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(577), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(578), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(579), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(581), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(582), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(584), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(585), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(587), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(588), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(589), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(590), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(592), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(594), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(595), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(596), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(597), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(607), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(609), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(610), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(611), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(613), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(614), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(616), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(617), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(620), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(621), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(622), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 19, 22, 34, 10, 801, DateTimeKind.Utc).AddTicks(7193), new DateTime(2026, 3, 20, 3, 34, 10, 801, DateTimeKind.Local).AddTicks(5160) });
        }
    }
}
