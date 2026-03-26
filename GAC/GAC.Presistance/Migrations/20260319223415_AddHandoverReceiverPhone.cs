using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddHandoverReceiverPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiverPhone",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverPhone",
                table: "ItemsHandOverRecords");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "72085e63-f77d-428e-9226-4a900ff0d294", "AQAAAAIAAYagAAAAEAZpsGwDo5QUceJWocIRk7h/UEKir0ZQuV9oeTn2gyF8QrC6aiEOeSFv3EL+R5EQwg==", new DateTime(2025, 3, 19, 21, 14, 55, 575, DateTimeKind.Utc).AddTicks(7782), "e0feea83-8d89-4c45-af1e-41fd78a077b3" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(449), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1684), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1689), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1691), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1693), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1695), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1697), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1777), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1780), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1782), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1784), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1786), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1787), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1789), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1791), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1793), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1795), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1796), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1798), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1800), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1804), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1806), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1808), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1809), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1811), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1836), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1838), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1840), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1841), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1843), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1845), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1847), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1849), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1850), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1852), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1854), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1856), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1857), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1859), new DateTime(2026, 3, 20, 2, 14, 55, 720, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(8027), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9222), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9229), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9233), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9235), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9237), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9238), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9240), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9242), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9243), new DateTime(2026, 3, 20, 2, 14, 55, 719, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 713, DateTimeKind.Local).AddTicks(1834), new DateTime(2026, 3, 20, 2, 14, 55, 715, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9188), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9778), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9801), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9810), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9836), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9848), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9855), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9864), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9878), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9896), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9906), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9915), new DateTime(2026, 3, 20, 2, 14, 55, 716, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5311), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5434), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5446), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5452), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5497), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5504), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5508), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5512), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5521), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5535), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5540), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5571), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5576), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5578), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5703), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5728), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5738), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5740), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5742), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5744), new DateTime(2026, 3, 20, 2, 14, 55, 717, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 722, DateTimeKind.Local).AddTicks(9284), new DateTime(2026, 3, 20, 2, 14, 55, 722, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(82), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(87), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(89), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(91), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(103), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(105), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(107), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(109), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(112), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(114), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(116), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(118), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(121), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(122), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(124), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(2980), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4923), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4929), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4931), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4932), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4937), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4939), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4940), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4941), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4944), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4945), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4946), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4947), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4949), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4954), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4955), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4957), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4958), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4960), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4961), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4962), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4963), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4964), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4966), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4967), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4968), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4970), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4971), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4972), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4974), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4975), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4976), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4991), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4993), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4994), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4995), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4997), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4998), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(4999), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5001), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5002), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5003), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5004), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5005), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5007), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5008), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5010), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5011), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5012), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5013), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5014), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5016), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5017), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5018), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5019), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5021), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5022), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5023), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5024), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5026), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5027), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5028), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5030), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5031), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5033), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5035), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5036), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5039), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5040), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5041), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5043), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5044), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5045), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5046), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5048), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5049), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5051), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5052), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5053), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5054), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5055), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5056), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5058), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5059), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5061), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5071), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5072), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5073), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5075), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5076), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5077), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5078), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5080), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5081), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5082), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5084), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5085), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5086), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5087), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5089), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5090), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5091), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5093), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5094), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5095), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5097), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5098), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5099), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5101), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5102), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5103), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5104), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5105), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5107), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5108), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5110), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5111), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5113), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5115), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5116), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5117), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5118), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5120), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5121), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5123), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5124), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5127), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5128), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5129), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 19, 21, 14, 55, 724, DateTimeKind.Utc).AddTicks(1581), new DateTime(2026, 3, 20, 2, 14, 55, 723, DateTimeKind.Local).AddTicks(9647) });
        }
    }
}
