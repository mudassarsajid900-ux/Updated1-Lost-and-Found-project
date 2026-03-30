using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddRejectionReasonToClaimRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "ClaimRequest",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "ClaimRequest");

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
    }
}
