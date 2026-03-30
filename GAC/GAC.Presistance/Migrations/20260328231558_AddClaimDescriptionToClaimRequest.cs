using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddClaimDescriptionToClaimRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClaimDescription",
                table: "ClaimRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "ee145656-8f7d-41ab-95ce-cb2fa4f59abc", "AQAAAAIAAYagAAAAEEJnXiw/0QgM0nToKa3EPNTU8R7FPhFYu6UkgY/lU3/fxE3G295mpDMpB5qYH/V4Qw==", new DateTime(2025, 3, 28, 23, 15, 55, 625, DateTimeKind.Utc).AddTicks(8066), "e32f9f58-5bc0-4c08-ace2-e37870f1d551" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(3303), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5709), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5717), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5720), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5722), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5843), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5849), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5852), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5854), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5883), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5888), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5891), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5893), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5896), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5899), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5902), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5905), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5908), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5910), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5913), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5916), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5919), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5922), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5924), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5973), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5976), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5979), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5983), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5985), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5988), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5990), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5992), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5995), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5997), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6000), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6002), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6005), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6007), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6010), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6012), new DateTime(2026, 3, 29, 4, 15, 55, 782, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(5021), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6382), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6394), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6396), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6399), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6402), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6404), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6407), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6409), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6412), new DateTime(2026, 3, 29, 4, 15, 55, 781, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 774, DateTimeKind.Local).AddTicks(7839), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9432), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9759), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9771), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9777), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9797), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9804), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9810), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9816), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9825), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9838), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9845), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9852), new DateTime(2026, 3, 29, 4, 15, 55, 777, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2769), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2810), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2821), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2827), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2847), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2854), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2862), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2868), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2875), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2881), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2890), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2898), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2906), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2938), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2941), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2943), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2946), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2949), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2952), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2957), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2959), new DateTime(2026, 3, 29, 4, 15, 55, 778, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(941), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2165), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2173), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2175), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2177), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2191), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2193), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2195), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2196), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2200), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2202), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2204), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2206), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2208), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2211), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2213), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(5333), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(6999), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7006), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7007), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7009), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7015), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7017), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7018), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7020), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7024), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7025), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7026), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7028), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7032), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7033), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7034), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7037), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7038), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7040), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7041), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7043), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7044), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7046), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7048), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7049), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7050), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7052), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7054), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7055), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7057), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7058), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7060), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7063), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7064), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7065), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7067), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7069), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7070), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7086), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7088), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7089), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7093), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7094), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7095), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7097), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7099), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7100), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7102), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7104), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7105), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7107), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7108), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7110), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7112), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7113), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7115), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7117), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7118), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7120), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7122), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7123), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7125), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7126), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7129), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7130), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7134), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7136), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7137), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7139), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7140), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7142), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7144), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7145), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7147), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7150), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7153), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7155), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7158), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7160), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7163), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7164), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7165), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7167), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7171), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7172), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7173), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7175), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7184), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7185), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7187), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7188), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7189), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7191), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7192), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7193), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7195), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7199), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7200), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7202), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7203), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7205), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7206), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7208), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7210), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7211), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7213), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7215), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7216), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7218), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7220), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7221), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7223), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7224), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7226), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7228), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7229), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7231), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7232), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7234), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7236), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7239), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7240), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7241), new DateTime(2026, 3, 29, 4, 15, 55, 786, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 23, 15, 55, 788, DateTimeKind.Utc).AddTicks(9006), new DateTime(2026, 3, 29, 4, 15, 55, 788, DateTimeKind.Local).AddTicks(7087) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaimDescription",
                table: "ClaimRequest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "7a8f5b17-bf79-4dfb-a61b-9af486a1cafc", "AQAAAAIAAYagAAAAEBh4pt05zTNIDPDk2Lo+53xtYxCCACvY+/YDYkIURGsSTGrNicCXGkPC9Da9l3UTCw==", new DateTime(2025, 3, 28, 20, 13, 0, 340, DateTimeKind.Utc).AddTicks(4259), "5ee88324-e2fb-4aac-bd5d-fa15c2e79fc2" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(3422), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5235), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5241), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5245), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5248), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5251), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5253), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5256), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5259), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5297), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5301), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5303), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5306), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5437), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5440), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5443), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5446), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5449), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5455), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5458), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5461), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5464), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5467), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5469), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5472), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5475), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5478), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5481), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5483), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5486), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5489), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5492), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5495), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5498), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5501), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5508), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(482), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1562), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1569), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1575), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1577), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1580), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1583), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1586), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1589), new DateTime(2026, 3, 29, 1, 13, 0, 869, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 861, DateTimeKind.Local).AddTicks(5759), new DateTime(2026, 3, 29, 1, 13, 0, 864, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(1732), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2346), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2364), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2370), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2388), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2394), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2416), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2439), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2447), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2472), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2480), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2487), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6230), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6307), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6327), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6334), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6385), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6394), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6401), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6407), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6413), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6420), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6429), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6436), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6448), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6451), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6454), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6457), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6460), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6463), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6465), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6468), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6471), new DateTime(2026, 3, 29, 1, 13, 0, 865, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(7026), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8187), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8195), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8199), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8202), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8214), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8217), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8219), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8222), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8228), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8231), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8235), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8238), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8240), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8243), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8246), new DateTime(2026, 3, 29, 1, 13, 0, 873, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(3145), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5192), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5203), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5206), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5209), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5330), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5334), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5337), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5341), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5345), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5348), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5350), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5353), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5356), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5362), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5365), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5367), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5370), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5373), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5410), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5414), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5417), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5419), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5421), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5424), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5427), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5427) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5429), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5432), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5435), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5437), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5440), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5442), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5445), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5449), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5454), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5457), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5460), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5462), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5465), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5467), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5469), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5472), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5475), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5477), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5480), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5481) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5482), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5485), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5488), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5490), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5492), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5495), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5497), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5500), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5502), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5507), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5509), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5512), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5514), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5520), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5522), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5524), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5527), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5531), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5533), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5535), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5539), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5541), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5544), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5558), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5560), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5562), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5563) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5564), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5566), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5569), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5573), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5576), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5578), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5580), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5583), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5585), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5588), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5590), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5594), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5596), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5599), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5601), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5604), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5607), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5610), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5612), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5615), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5617), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5620), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5623), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5625), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5628), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5630), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5633), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5638), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5640), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5643), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5646), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5649), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5651), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5654), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5656), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5660), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5662), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5665), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5667), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5670), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5672), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5675), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5678), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5681), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5683), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5686), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5691), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5694), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5699), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5702), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5704), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5707), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5724), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5727), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5729), new DateTime(2026, 3, 29, 1, 13, 0, 874, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 20, 13, 0, 877, DateTimeKind.Utc).AddTicks(1657), new DateTime(2026, 3, 29, 1, 13, 0, 876, DateTimeKind.Local).AddTicks(8862) });
        }
    }
}
