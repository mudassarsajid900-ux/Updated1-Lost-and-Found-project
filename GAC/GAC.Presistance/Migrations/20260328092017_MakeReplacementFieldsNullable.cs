using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class MakeReplacementFieldsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "ReplacementRecords",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "ReplacementRecords",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "AdminNotes",
                table: "ReplacementRecords",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "01001953-a142-4779-add6-609a0923a728", "AQAAAAIAAYagAAAAEKcuSOHRI5CA4StABMdZlvjrTL+8Gtp1SK0RvQ/AU+uC76aY2Rw+FhClXG8oeyOvWA==", new DateTime(2025, 3, 28, 9, 20, 0, 546, DateTimeKind.Utc).AddTicks(28), "cbf07afd-b2b3-4de7-9556-cf6211de2b49" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(6221), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7472), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7478), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7480), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7481), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7556), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7559), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7561), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7563), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7565), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7566), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7568), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7570), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7574), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7576), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7577), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7579), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7581), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7583), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7585), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7729), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7732), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7735), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7738), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7741), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7743), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7746), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7749), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7751), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7754), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7759), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7787), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7792), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7795), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7797), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4150), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4939), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4944), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4946), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4948), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4950), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4951), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4953), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4955), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4956), new DateTime(2026, 3, 28, 14, 20, 2, 445, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 439, DateTimeKind.Local).AddTicks(8156), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5213), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5602), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5615), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5620), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5635), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5830), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5840), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5846), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5863), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5867), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5871), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8400), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8454), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8472), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8484), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8494), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8498), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8501), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8505), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8509), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8512), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8517), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8551), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8560), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8562), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8564), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8566), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8568), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8570), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8572), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8574), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8576), new DateTime(2026, 3, 28, 14, 20, 2, 442, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(1654), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2473), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2482), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2484), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2492), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2494), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2496), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2498), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2501), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2504), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2506), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2508), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2510), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2592), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2595), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(5689), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7123), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7130), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7132), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7133), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7139), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7141), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7142), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7144), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7146), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7147), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7149), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7150), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7152), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7158), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7159), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7162), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7163), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7165), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7166), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7168), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7169), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7171), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7172), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7174), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7175), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7177), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7178), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7180), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7204), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7206), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7207), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7210), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7211), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7213), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7214), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7216), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7217), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7219), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7220), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7222), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7223), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7225), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7226), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7228), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7229), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7231), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7233), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7235), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7236), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7237), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7239), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7241), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7242), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7244), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7245), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7246), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7248), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7249), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7251), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7253), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7254), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7256), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7257), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7260), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7261), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7263), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7265), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7266), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7267), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7269), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7270), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7272), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7273), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7275), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7276), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7278), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7279), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7281), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7282), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7283), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7292), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7294), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7295), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7297), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7298), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7300), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7301), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7303), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7305), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7306), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7308), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7309), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7310), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7312), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7314), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7315), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7317), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7318), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7319), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7321), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7322), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7324), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7326), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7327), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7328), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7330), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7331), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7333), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7334), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7336), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7338), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7339), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7341), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7342), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7344), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7345), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7347), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7348), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7350), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7351), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7353), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7354), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7356), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7357), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7359), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7360), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7362), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7364), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7375), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7376), new DateTime(2026, 3, 28, 14, 20, 2, 448, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 28, 9, 20, 2, 449, DateTimeKind.Utc).AddTicks(6381), new DateTime(2026, 3, 28, 14, 20, 2, 449, DateTimeKind.Local).AddTicks(3689) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "ReplacementRecords",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "ReplacementRecords",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdminNotes",
                table: "ReplacementRecords",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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
    }
}
