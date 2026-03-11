using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMobileModelsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "8000b37f-d9d7-45ea-b212-fb79a43923f7", "AQAAAAIAAYagAAAAELlJ+Ma6jIEwGudc0qYGVdIHImZ21GUpogrCYCbOJzoiz+ry2GEYYPk4TvGe5lerUg==", new DateTime(2025, 3, 3, 23, 21, 1, 78, DateTimeKind.Utc).AddTicks(5245), "625c5d72-660d-459a-adcf-f0bd4f142d1a" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(4585), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6524), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6532), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6536), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6541), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6545), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6549), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6554), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6558), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6563), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6567), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6572), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6577), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6581), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6586), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6590), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6595), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6600), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6604), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6608), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6613), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6617), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6622), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6627), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6631), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6636), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6674), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6679), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6684), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6688), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6692), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6697), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6702), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6706), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6710), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6715), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6719), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6724), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6728), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6732), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(1021), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2231), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2241), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2245), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2249), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2252), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2360), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2375), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2379), new DateTime(2026, 3, 4, 4, 21, 1, 407, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 397, DateTimeKind.Local).AddTicks(2933), new DateTime(2026, 3, 4, 4, 21, 1, 401, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(3915), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4513), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4538), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4546), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4572), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4609), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4624), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4638), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4649), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4672), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4689), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4696), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8510), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8596), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8616), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8625), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8650), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8660), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8668), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8677), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8684), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8692), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8703), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8712), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8729), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8732), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8736), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8740), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8789), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8793), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8799), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8803), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8806), new DateTime(2026, 3, 4, 4, 21, 1, 402, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(3417), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4626), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4761), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4769), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4774), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4793), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.InsertData(
                table: "MobileCompanies",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 7L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4798), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4799), "Vivo" },
                    { 8L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4804), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4805), "Xiaomi" },
                    { 9L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4808), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4810), "Google" },
                    { 10L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4816), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4817), "OnePlus" },
                    { 11L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4820), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4822), "Tecno" },
                    { 12L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4825), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4826), "Huawei" }
                });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(9130), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1536), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1546), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1551), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1555), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1565), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1576), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1580), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1588), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1591), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1596), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1600), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1604), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1608), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1613), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1616), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1623), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1632), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1636), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1641), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1645), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1649), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1654), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1658), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1663), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1668), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1672), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1676), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1680), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1682), "iPhone 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1684), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1685), "iPhone 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1688), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1689), "iPhone SE" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1693), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1700), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1708), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1713), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1717), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1721), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1726), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1753), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1758), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1762), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1768), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1772), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1776), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1781), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1793), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1801), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1807), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1808), 5L, "Zero 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1811), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1812), "Zero Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1815), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1817), "Note 30 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1820), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1821), "Note 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1823), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1824), "Hot 40 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1827), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1828), "Hot 40" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1831), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1833), "Hot 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1836), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1837), "Smart 8" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1840), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1842), "Smart 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1846), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1847), 6L, "GT 5 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1850), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1851), "GT 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1854), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1855), "11 Pro+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1858), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1859), "11 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1864), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1866), "11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1868), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1870), "C67" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1873), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1874), "C55" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1877), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1878), "C53" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1881), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1882), "C51" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1886), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1887), 7L, "X100 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1889), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1891), 7L, "X100" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1894), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1895), 7L, "V29 Pro" });

            migrationBuilder.InsertData(
                table: "MobileModels",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[,]
                {
                    { 74L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1898), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1899), 7L, "V29" },
                    { 75L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1902), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1903), 7L, "V29e" },
                    { 76L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1906), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1907), 7L, "Y100" },
                    { 77L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1910), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1911), 7L, "Y36" },
                    { 78L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1914), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1915), 7L, "Y27" },
                    { 79L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1917), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1919), 7L, "Y17s" },
                    { 80L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1922), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1923), 8L, "14 Pro" },
                    { 81L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1926), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1927), 8L, "14" },
                    { 82L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1930), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1931), 8L, "13 Ultra" },
                    { 83L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1934), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1935), 8L, "13 Pro" },
                    { 84L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1938), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1940), 8L, "13" },
                    { 85L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1943), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1944), 8L, "13 Lite" },
                    { 86L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1947), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1948), 8L, "12T Pro" },
                    { 87L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1951), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1953), 8L, "12T" },
                    { 88L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1957), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1958), 9L, "Pixel 8 Pro" },
                    { 89L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1961), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1963), 9L, "Pixel 8" },
                    { 90L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1966), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1967), 9L, "Pixel 7 Pro" },
                    { 91L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1970), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1971), 9L, "Pixel 7" },
                    { 92L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1974), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1976), 9L, "Pixel 7a" },
                    { 93L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1978), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1979), 9L, "Pixel 6 Pro" },
                    { 94L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1981), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1982), 9L, "Pixel 6" },
                    { 95L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1985), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1986), 9L, "Pixel 6a" },
                    { 96L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1990), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1992), 10L, "OnePlus 12" },
                    { 97L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2006), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2007), 10L, "OnePlus 12R" },
                    { 98L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2010), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2011), 10L, "OnePlus 11" },
                    { 99L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2014), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2015), 10L, "OnePlus 11R" },
                    { 100L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2018), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2020), 10L, "Nord 3" },
                    { 101L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2023), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2024), 10L, "Nord CE 3" },
                    { 102L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2027), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2029), 10L, "Nord CE 3 Lite" },
                    { 103L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2033), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2034), 11L, "Phantom V Flip" },
                    { 104L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2037), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2038), 11L, "Phantom X2 Pro" },
                    { 105L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2041), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2042), 11L, "Camon 20 Premier" },
                    { 106L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2045), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2046), 11L, "Camon 20 Pro" },
                    { 107L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2048), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2050), 11L, "Spark 10 Pro" },
                    { 108L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2053), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2054), 11L, "Spark 10" },
                    { 109L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2057), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2059), 11L, "Pova 5 Pro" },
                    { 110L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2062), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2064), 12L, "Mate 60 Pro" },
                    { 111L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2067), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2068), 12L, "Mate 60" },
                    { 112L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2071), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2072), 12L, "P60 Pro" },
                    { 113L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2075), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2077), 12L, "P60" },
                    { 114L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2080), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2081), 12L, "Nova 11 Pro" },
                    { 115L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2084), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2085), 12L, "Nova 11" },
                    { 116L, 1, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2088), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2089), 12L, "Y91" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "d4dafc79-9856-448c-ba33-d625ae31826f", "AQAAAAIAAYagAAAAEJK/v1R5erMNIE3b0YsoyoEO7yba0M5onYT7DaGUFbL4r4MzpkYQt/vIawMr1LGkrw==", new DateTime(2025, 3, 3, 21, 53, 9, 330, DateTimeKind.Utc).AddTicks(1097), "0293b5c7-e130-4758-8551-c94856720532" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(3373), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4552), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4559), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4561), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4563), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4564), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4566), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4568), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4570), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4571), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4573), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4575), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4576), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4578), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4580), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4582), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4583), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4585), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4587), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4589), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4590), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4592), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4594), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4596), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4597), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4599), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4601), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4603), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4604), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4606), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4608), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4609), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4611), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4613), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4615), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4616), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4618), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4620), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4621), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4623), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(1137), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2060), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2069), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2071), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2072), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2074), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2076), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2077), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2079), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2153), new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 452, DateTimeKind.Local).AddTicks(9401), new DateTime(2026, 3, 4, 2, 53, 9, 454, DateTimeKind.Local).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(344), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(534), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(542), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(548), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(567), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(576), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(592), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(603), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(610), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(625), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(630), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(635), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2648), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2705), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2712), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2716), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2734), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2739), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2743), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2747), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2751), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2754), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2764), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2769), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2776), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2778), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2780), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2782), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2783), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2785), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2787), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2789), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2790), new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 458, DateTimeKind.Local).AddTicks(9646), new DateTime(2026, 3, 4, 2, 53, 9, 458, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(388), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(396), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(398), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(401), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(412), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(2767), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4028), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4034), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4035), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4037), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4044), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4045), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4046), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4048), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4050), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4051), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4053), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4054), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4055), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4056), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4058), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4059), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4061), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4065), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4066), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4068), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4094), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4095), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4097), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4098), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4100), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4101), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4102), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4104), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4105), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4105), "iPhone 13 mini" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4106), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4107), "iPhone 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4107), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4108), "iPhone SE (3rd gen)" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4109), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4112), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4113), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4114), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4116), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4117), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4118), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4120), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4121), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4122), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4123), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4125), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4126), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4128), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4129), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4130), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4131), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4133), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4134), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4135), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4136), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4137), 4L, "K60 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4138), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4139), "Zero 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4139), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4140), "Zero Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4141), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4141), "Note 30 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4142), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4142), "Note 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4143), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4144), "Hot 40 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4145), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4145), "Hot 40" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4146), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4146), "Hot 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4147), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4148), "Smart 8" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4149), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4149), 5L, "Smart 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4150), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4151), "GT 5 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4151), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4152), "GT 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4153), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4154), "11 Pro+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4156), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4156), "11 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4157), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4158), "11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4159), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4159), "C67" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4160), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4160), "C55" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4161), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4161), "C53" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4162), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4163), 6L, "C51" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4164), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4164), 6L, "Narzo 60 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4165), new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4165), 6L, "Narzo 60" });
        }
    }
}
