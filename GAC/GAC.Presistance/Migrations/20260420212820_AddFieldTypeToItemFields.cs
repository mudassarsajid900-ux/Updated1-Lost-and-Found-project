using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldTypeToItemFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ItemTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "FieldType",
                table: "Fields",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "d35e9bdd-1cf9-43e7-9898-e64826d9e978", "AQAAAAIAAYagAAAAEIWmonZ50QetIjB6K49OqFgF+BSkCnEjuWcg5jR5WfyMGbl0qP4s2Wr/KSURy51vAQ==", new DateTime(2025, 4, 20, 21, 28, 13, 255, DateTimeKind.Utc).AddTicks(2723), "701c7458-360f-47d7-941e-0cd41108654e" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(884), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(885), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2355), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2356), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2359), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2359), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2361), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2362), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2363), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2363), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2364), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2365), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2366), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2366), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2367), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2368), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2369), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2369), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2370), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2371), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2372), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2372), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2373), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2374), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2375), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2375), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2376), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2377), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2378), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2378), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2454), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2455), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2457), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2457), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2458), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2459), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2460), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2460), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2461), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2462), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2463), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2463), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2465), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2465), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2466), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2466), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2468), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2468), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2469), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2469), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2471), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2471), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2498), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2498), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2499), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2500), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2501), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2501), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2503), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2503), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2504), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2504), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2505), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2506), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2507), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2507), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2508), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2509), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2510), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2510), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2512), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2512), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2513), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2513), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2515), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2515), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2516), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2517), null });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "FieldType", "LastModifiedOn", "Options" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2518), "text", new DateTime(2026, 4, 20, 21, 28, 13, 441, DateTimeKind.Utc).AddTicks(2518), null });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(8633), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9511), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9515), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9516), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9518), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9519), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9520), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9522), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9523), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9525), new DateTime(2026, 4, 20, 21, 28, 13, 440, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(1746), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5098), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5270), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5277), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5281), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5292), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5295), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5309), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5319), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5324), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5337), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5342), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5345), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7935), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7988), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7995), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(7999), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8008), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8013), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8016), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8020), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8023), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8027), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8034), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8038), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8044), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8046), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8048), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8049), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8051), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8052), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8054), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8088), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8090), new DateTime(2026, 4, 20, 21, 28, 13, 438, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(7826), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8984), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8990), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8995), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8997), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9006), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9008), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9010), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9012), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9016), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9018), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9020), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9022), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9024), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9026), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9028), new DateTime(2026, 4, 20, 21, 28, 13, 444, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(2369), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4133), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4138), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4140), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4141), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4146), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4148), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4149), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4150), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4152), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4154), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4155), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4156), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4158), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4164), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4165), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4167), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4169), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4171), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4173), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4174), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4175), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4177), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4178), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4180), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4181), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4182), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4184), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4185), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4187), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4188), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4190), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4191), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4213), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4214), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4216), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4217), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4219), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4220), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4221), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4223), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4224), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4225), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4226), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4228), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4229), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4230), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4233), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4234), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4235), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4236), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4238), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4239), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4240), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4241), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4243), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4244), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4245), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4247), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4248), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4250), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4251), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4252), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4254), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4255), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4257), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4258), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4260), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4261), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4263), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4264), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4265), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4266), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4268), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4269), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4270), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4272), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4273), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4275), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4276), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4277), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4278), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4280), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4281), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4282), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4284), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4294), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4296), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4297), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4298), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4300), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4301), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4303), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4304), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4306), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4308), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4309), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4310), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4312), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4313), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4314), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4315), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4317), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4318), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4320), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4321), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4322), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4324), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4325), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4326), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4328), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4329), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4331), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4332), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4333), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4334), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4336), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4337), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4339), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4340), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4341), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4343), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4344), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4345), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4347), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4348), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4350), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4351), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4352), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4355), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4356), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4357), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 4, 20, 21, 28, 13, 446, DateTimeKind.Utc).AddTicks(2163), new DateTime(2026, 4, 20, 21, 28, 13, 445, DateTimeKind.Utc).AddTicks(9781) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldType",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "Fields");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ItemTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "e735b228-162f-42a5-bf7e-9778e52ebd28", "AQAAAAIAAYagAAAAEN5dDioGtiPrlElE8x4IMV7Tsrq4WQOfg/Z1JzrCOTWteNVgI9UBfuAuqvN+JPMaug==", new DateTime(2025, 3, 30, 19, 35, 6, 675, DateTimeKind.Utc).AddTicks(2523), "6bb7cbc9-5a4b-4af2-9a36-3258a908594f" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(3540), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4813), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4817), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4903), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4906), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4908), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4910), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4912), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4914), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4916), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4918), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4920), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4922), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4924), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4925), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4927), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4929), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4931), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4933), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4935), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4937), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4939), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4941), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4943), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4944), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4946), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4948), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4950), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4954), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4956), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4958), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4960), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4961), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4963), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4965), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4967), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4969), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4971), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4973), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(1523), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2322), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2330), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2332), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2334), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2336), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2338), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2340), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2341), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2343), new DateTime(2026, 3, 31, 0, 35, 6, 846, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 841, DateTimeKind.Local).AddTicks(5390), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7475), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7890), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7909), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7914), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7943), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7948), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7957), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7967), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7973), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7989), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7993), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7996), new DateTime(2026, 3, 31, 0, 35, 6, 843, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(564), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(613), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(620), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(624), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(642), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(646), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(650), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(653), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(657), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(661), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(667), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(670), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(677), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(679), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(681), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(683), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(685), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(687), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(689), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(691), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(693), new DateTime(2026, 3, 31, 0, 35, 6, 844, DateTimeKind.Local).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(883), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1786), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1796), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1799), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1802), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1815), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1818), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1821), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1823), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1827), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1851), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1854), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1856), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1858), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1860), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1862), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7699), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7706), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7716), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7718), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7719), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7721), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7725), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7727), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7728), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7749), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7755), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7756), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7758), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7760), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7762), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7763), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7764), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7766), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7768), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7769), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7770), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7772), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7773), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7775), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7777), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7778), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7779), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7781), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7782), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7785), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7787), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7788), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7789), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7791), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7793), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7794), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7795), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7796), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7798), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7799), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7802), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7803), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7805), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7807), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7808), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7809), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7812), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7814), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7815), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7816), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7818), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7819), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7820), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7821), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7823), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7825), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7826), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7827), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7829), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7839), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7841), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7842), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7844), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7845), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7847), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7848), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7849), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7851), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7852), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7854), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7855), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7857), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7858), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7860), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7861), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7862), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7864), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7865), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7867), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7868), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7870), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7871), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7872), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7874), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7875), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7877), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7878), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7880), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7881), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7883), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7884), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7886), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7887), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7888), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7890), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7891), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7893), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7894), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7896), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7898), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7899), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7901), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7902), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7903), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7905), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7907), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7908), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7909), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7911), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7912), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7914), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7916), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7917), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7918), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7920), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7922), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7923), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7925), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7926), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7927), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7938), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7939), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7941), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7945), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7946), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7948), new DateTime(2026, 3, 31, 0, 35, 6, 849, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 30, 19, 35, 6, 850, DateTimeKind.Utc).AddTicks(5013), new DateTime(2026, 3, 31, 0, 35, 6, 850, DateTimeKind.Local).AddTicks(2924) });
        }
    }
}
