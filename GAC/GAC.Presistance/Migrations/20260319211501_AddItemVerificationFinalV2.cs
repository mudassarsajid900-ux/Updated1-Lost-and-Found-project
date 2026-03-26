using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddItemVerificationFinalV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerifiedByAdmin",
                table: "Items",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedDate",
                table: "Items",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerifiedByAdmin",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "VerifiedDate",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "8ab61454-f755-4afd-955e-86ce39a86cbf", "AQAAAAIAAYagAAAAENI/cxrCwaW6NlQ8f4/r9Br9PEBs6lmCqkqoeKfRRh0w/unRVSU9Ag9rT0JCpokmog==", new DateTime(2025, 3, 17, 15, 25, 2, 938, DateTimeKind.Utc).AddTicks(4218), "8cc7faad-59f3-4a8e-b445-45ca758ad64c" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(3393), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4556), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4561), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4563), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4565), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4641), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4645), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4647), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4649), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4650), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4652), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4654), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4656), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4685), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4687), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4689), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4691), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4692), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4694), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4696), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4698), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4699), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4701), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4703), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4705), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4706), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4708), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4710), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4711), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4713), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4715), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4717), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4718), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4720), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4722), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4723), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4725), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4727), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4729), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4730), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(1446), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2186), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2194), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2195), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2197), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2199), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2200), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2202), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2203), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2205), new DateTime(2026, 3, 17, 20, 25, 3, 68, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 61, DateTimeKind.Local).AddTicks(3346), new DateTime(2026, 3, 17, 20, 25, 3, 63, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(4998), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5526), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5550), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5558), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5582), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5591), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5598), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5605), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5615), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5626), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5633), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5639), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9825), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9909), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9921), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9930), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9967), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9979), new DateTime(2026, 3, 17, 20, 25, 3, 64, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(31), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(42), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(51), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(58), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(71), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(80), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(95), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(99), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(102), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(104), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(107), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(110), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(113), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(116), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(118), new DateTime(2026, 3, 17, 20, 25, 3, 65, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8134), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8866), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8870), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8872), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8874), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8885), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8887), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8891), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8894), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8896), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8898), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8899), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8901), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8903), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8905), new DateTime(2026, 3, 17, 20, 25, 3, 70, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(1771), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3305), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3311), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3313), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3314), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3320), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3321), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3323), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3324), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3326), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3327), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3329), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3330), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3331), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3335), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3336), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3338), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3340), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3341), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3342), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3344), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3345), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3346), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3364), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3365), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3366), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3368), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3370), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3371), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3372), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3373), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3375), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3376), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3378), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3380), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3381), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3382), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3384), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3385), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3386), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3387), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3389), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3390), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3391), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3392), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3393), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3395), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3396), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3398), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3399), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3400), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3402), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3403), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3404), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3405), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3406), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3408), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3409), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3410), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3411), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3413), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3414), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3415), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3417), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3418), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3420), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3422), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3423), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3425), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3426), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3427), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3428), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3429), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3431), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3439), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3441), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3442), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3444), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3445), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3446), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3447), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3449), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3450), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3451), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3452), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3454), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3455), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3456), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3458), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3459), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3461), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3462), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3463), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3464), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3465), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3467), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3469), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3470), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3471), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3472), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3474), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3475), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3476), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3477), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3479), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3480), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3481), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3483), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3484), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3485), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3487), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3488), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3489), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3490), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3492), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3493), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3494), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3496), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3497), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3498), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3500), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3501), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3502), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3504), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3504) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3505), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3506), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3508), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3509), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3510), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3520), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3521), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3523), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 17, 15, 25, 3, 71, DateTimeKind.Utc).AddTicks(9503), new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(7803) });
        }
    }
}
