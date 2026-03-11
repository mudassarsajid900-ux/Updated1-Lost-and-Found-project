using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class ExpandMobileModelsPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "b68aa4dc-9043-41d1-8ca3-d4d693843c02", "AQAAAAIAAYagAAAAEO+8EenLlZh9X1UBURGjAftWObuiYgZKI2Z0xC5uXKWuR7Vf92JlhhBknaCHCCsynQ==", new DateTime(2025, 3, 3, 23, 25, 16, 648, DateTimeKind.Utc).AddTicks(357), "56825790-af80-4dca-b26a-3cddd6031f64" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(4362), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5851), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5858), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5861), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5863), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5865), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5868), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5870), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5872), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5874), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5876), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5879), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5881), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5883), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5885), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5888), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5890), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5892), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5894), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5896), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5899), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5902), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5904), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5906), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5908), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5910), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5913), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5915), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5918), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5920), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5922), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5924), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5926), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5928), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5931), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5933), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5935), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5937), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5940), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5942), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(1291), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2672), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2680), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2682), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2684), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2686), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2689), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2691), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2693), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2780), new DateTime(2026, 3, 4, 4, 25, 16, 823, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 815, DateTimeKind.Local).AddTicks(6006), new DateTime(2026, 3, 4, 4, 25, 16, 818, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1293), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1645), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1656), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1661), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1686), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1691), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1708), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1748), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1754), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1771), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1777), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1782), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6516), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6651), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6662), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6667), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6695), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6701), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6706), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6712), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6719), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6724), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6732), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6737), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6749), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6751), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6753), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6756), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6758), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6760), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6762), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6764), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6766), new DateTime(2026, 3, 4, 4, 25, 16, 819, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(2109), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3015), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3021), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3024), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3110), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3151), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3153), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3156), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3158), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3162), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3164), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3166), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.InsertData(
                table: "MobileCompanies",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 13L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3169), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3169), "Itel" },
                    { 14L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3171), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3171), "Sparx" },
                    { 15L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3173), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3174), "VgoTel" },
                    { 16L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3175), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3176), "Nokia" }
                });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(5980), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7533), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7537), "S23 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7541), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7541), "S22 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7542), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7543), "A54" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7544), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7545), "A34" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7552), "A24" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7568), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7569), "A14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7570), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7571), "A05s" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7572), "A05" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7575), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7575), "A04" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7577), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7577), "M54" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7578), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7579), "M34" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7580), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7580), "M14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7581), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7582), "Grand Prime Plus" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7587), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7588), 2L, "iPhone 15 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7589), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7589), 2L, "iPhone 15 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7590), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7591), 2L, "iPhone 14 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7593), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7594), 2L, "iPhone 14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7595), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7596), "iPhone 13 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7597), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7597), "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7598), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7599), "iPhone 12 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7600), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7600), "iPhone 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7601), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7602), "iPhone 11 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7603), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7603), "iPhone 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7604), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7605), "iPhone X" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7606), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7606), "iPhone 8 Plus" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7607), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7608), "iPhone 7 Plus" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7610), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7610), 3L, "Reno 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7612), 3L, "Reno 10" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7613), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7613), 3L, "A78" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7614), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7615), 3L, "A58" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7616), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7617), 3L, "A38" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7618), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7618), "A18" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7621), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7622), "A17" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7623), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7623), "A16" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7624), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7625), "F21 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7626), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7626), "F19 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7628), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7629), 4L, "Note 13 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7630), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7630), 4L, "Note 13" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7631), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7632), 4L, "Note 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7633), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7633), 4L, "Note 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7635), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7635), 4L, "Note 10" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7636), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7637), 4L, "13C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7638), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7638), "12C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7639), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7640), "10C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7641), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7641), "A2+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7642), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7643), "A3" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7645), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7645), 5L, "Note 40 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7646), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7647), 5L, "Note 30 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7648), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7648), 5L, "Note 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7649), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7650), 5L, "Note 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7651), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7652), 5L, "Hot 40 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7653), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7653), "Hot 40i" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7654), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7655), "Hot 30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7656), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7656), "Hot 30i" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7657), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7658), "Hot 20" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7659), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7660), "Hot 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7661), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7661), "Smart 8" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7662), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7663), "Smart 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7664), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7664), "Smart 6" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7666), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7667), 6L, "12 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7668), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7668), "11 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7669), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7670), "C67" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7679), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7679), "C53" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7681), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7681), "C51" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7684), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7684), "C35" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7686), "C33" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7687), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7687), "Note 50" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7689), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7690), 7L, "V30" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7691), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7691), 7L, "V29" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7692), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7693), "V27e" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7694), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7694), "V23e" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7696), "Y100" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7697), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7698), "Y36" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7699), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7699), "Y27" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7700), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7701), "Y17s" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7702), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7702), "Y02s" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7704), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7705), 8L, "14 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7706), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7706), 8L, "13T" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7708), "12T" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7710), "Mi 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7711), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7711), "Poco X6 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7712), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7713), "Poco F5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7714), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7714), "Poco X3 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7716), "Poco M3" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7717), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7718), 9L, "Pixel 8 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7719), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7720), 9L, "Pixel 7 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7721), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7721), "Pixel 6 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7723), "Pixel 6a" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7724), "Pixel 4 XL" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7727), 10L, "OnePlus 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7727), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7728), 10L, "OnePlus 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7729), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7730), 10L, "OnePlus 10 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7731), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7731), 10L, "Nord CE 3 Lite" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7732), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7733), 10L, "OnePlus 8T" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7734), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7735), 11L, "Phantom V Fold" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7736), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7736), 11L, "Camon 20" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7737), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7738), 11L, "Camon 19 Neo" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7739), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7740), 11L, "Spark 20 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7741), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7741), 11L, "Spark 10 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7742), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7743), 11L, "Spark 9" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7744), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7745), 11L, "Spark 8C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7746), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7746), "Pova 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7747), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7748), "Pop 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7749), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7750), 12L, "Mate 60" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7751), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7751), 12L, "P60" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7752), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7753), 12L, "Nova 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7754), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7755), 12L, "Nova 9" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7756), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7756), 12L, "Y9a" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7757), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7758), "Y7p" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7759), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7760), 13L, "S23+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7761), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7761), 13L, "P40" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7762), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7763), 13L, "A70" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7764), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7765), 13L, "A60" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7766), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7766), 13L, "Vision 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7767), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7768), 13L, "Vision 3" });

            migrationBuilder.InsertData(
                table: "MobileModels",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[,]
                {
                    { 117L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7769), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7770), 14L, "Neo 7 Ultra" },
                    { 118L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7771), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7771), 14L, "Neo 7" },
                    { 119L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7772), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7773), 14L, "Note 20" },
                    { 120L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7792), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7792), 14L, "S9" },
                    { 121L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7794), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7794), 14L, "S3" },
                    { 122L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7796), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7796), 15L, "New 7" },
                    { 123L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7797), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7798), 15L, "New 5" },
                    { 124L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7799), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7800), 15L, "Note 24" },
                    { 125L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7800), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7801), 15L, "S12" },
                    { 126L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7802), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7803), 15L, "i850" },
                    { 127L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7805), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7805), 16L, "Nokia 3.4" },
                    { 128L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7806), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7807), 16L, "Nokia 2.4" },
                    { 129L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7808), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7808), 16L, "G20" },
                    { 130L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7811), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7812), 16L, "G10" },
                    { 131L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7813), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7814), 16L, "105 (Feature Phone)" },
                    { 132L, 1, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7815), null, null, true, false, null, new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7816), 16L, "210 (Feature Phone)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L);

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

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4798), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4804), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4808), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4816), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4820), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4825), new DateTime(2026, 3, 4, 4, 21, 1, 412, DateTimeKind.Local).AddTicks(4826) });

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
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1536), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1541), "S24+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1546), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1548), "S24" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1551), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1552), "S23 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1555), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1556), "S23+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1565), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1566), "S23" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1573), "S22 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1576), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1578), "S22+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1580), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1582), "S22" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1588), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1589), "S21 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1591), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1593), "S21 FE" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1596), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1597), "S21" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1600), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1601), "Z Fold 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1604), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1606), "Z Flip 5" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1608), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1610), 1L, "A54" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1613), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1614), 1L, "A34" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1616), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1618), 1L, "A24" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1623), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1625), 1L, "A14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1632), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1634), "iPhone 15 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1636), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1638), "iPhone 15 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1641), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1642), "iPhone 15 Plus" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1645), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1647), "iPhone 15" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1649), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1651), "iPhone 14 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1654), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1655), "iPhone 14 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1658), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1659), "iPhone 14 Plus" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1663), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1665), "iPhone 14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1668), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1669), "iPhone 13 Pro Max" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1672), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1673), 2L, "iPhone 13 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1676), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1677), 2L, "iPhone 13" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1680), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1682), 2L, "iPhone 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1684), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1685), 2L, "iPhone 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1688), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1689), 2L, "iPhone SE" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1693), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1694), "Find N3" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1700), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1701), "Find N3 Flip" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1704), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1706), "Find X6 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1708), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1710), "Find X6" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1713), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1714), "Reno 10 Pro+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1717), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1718), 3L, "Reno 10 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1721), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1723), 3L, "Reno 10" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1726), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1727), 3L, "A98" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1753), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1755), 3L, "A78" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1758), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1760), 3L, "A58" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1762), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1764), 3L, "A38" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1768), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1769), "Note 13 Pro+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1772), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1774), "Note 13 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1776), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1778), "Note 13" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1781), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1782), "Note 12 Pro+" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1785), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1786), 4L, "Note 12 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1791), 4L, "Note 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1793), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1794), 4L, "13C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1797), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1799), 4L, "12C" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1801), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1803), 4L, "A2" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1807), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1808), "Zero 30" });

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
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1840), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1842), 5L, "Smart 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1846), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1847), "GT 5 Pro" });

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
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1877), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1878), 6L, "C53" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1881), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1882), 6L, "C51" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1886), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1887), "X100 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1889), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1891), "X100" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1894), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1895), "V29 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1898), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1899), "V29" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1902), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1903), "V29e" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1906), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1907), "Y100" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1910), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1911), "Y36" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1914), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1915), 7L, "Y27" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1917), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1919), 7L, "Y17s" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1922), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1923), "14 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1926), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1927), "14" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1930), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1931), "13 Ultra" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1934), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1935), "13 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1938), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1940), "13" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1944), "13 Lite" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1947), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1948), 8L, "12T Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1951), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1953), 8L, "12T" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1957), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1958), "Pixel 8 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1961), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1963), "Pixel 8" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1966), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1967), "Pixel 7 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1970), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1971), 9L, "Pixel 7" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1974), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1976), 9L, "Pixel 7a" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1978), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1979), 9L, "Pixel 6 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1981), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1982), 9L, "Pixel 6" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1985), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1986), 9L, "Pixel 6a" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1990), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(1992), 10L, "OnePlus 12" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2006), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2007), 10L, "OnePlus 12R" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2010), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2011), 10L, "OnePlus 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2014), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2015), 10L, "OnePlus 11R" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2018), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2020), 10L, "Nord 3" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2023), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2024), 10L, "Nord CE 3" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2027), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2029), 10L, "Nord CE 3 Lite" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2033), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2034), "Phantom V Flip" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2037), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2038), "Phantom X2 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2041), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2042), 11L, "Camon 20 Premier" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2045), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2046), 11L, "Camon 20 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2048), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2050), 11L, "Spark 10 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2053), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2054), 11L, "Spark 10" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2057), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2059), 11L, "Pova 5 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2062), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2064), "Mate 60 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2067), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2068), 12L, "Mate 60" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2071), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2072), 12L, "P60 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2075), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2077), 12L, "P60" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2080), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2081), 12L, "Nova 11 Pro" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2084), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2085), 12L, "Nova 11" });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2088), new DateTime(2026, 3, 4, 4, 21, 1, 413, DateTimeKind.Local).AddTicks(2089), 12L, "Y91" });
        }
    }
}
