using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddReportTypeToItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReportType",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "bd917bd5-ed89-489d-a509-3efeb7d32187", "AQAAAAIAAYagAAAAEMkrETDnu/8sk10q/Zxfftn3ScdiLqLagjcBH8ZCHnRSRzt9RzNUECPjEWm9WNO38g==", new DateTime(2025, 3, 6, 0, 55, 38, 731, DateTimeKind.Utc).AddTicks(4906), "51d76301-0214-4f3f-b21f-869b8bb3da3c" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(4865), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6571), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6578), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6581), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6584), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6587), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6590), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6593), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6595), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6599), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6602), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6605), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6608), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6611), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6613), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6616), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6618), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6621), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6624), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6627), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6629), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6632), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6637), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6640), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6642), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6645), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6648), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6651), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6654), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6657), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6659), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6662), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6666), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6669), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6671), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6674), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6676), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6679), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6681), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6684), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(2063), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3068), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3075), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3078), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3080), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3083), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3085), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3088), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3189), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3194), new DateTime(2026, 3, 6, 5, 55, 38, 950, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 943, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(8719), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9078), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9090), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9096), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9109), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9114), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9128), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9176), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9187), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9206), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9212), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9219), new DateTime(2026, 3, 6, 5, 55, 38, 946, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2210), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2271), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2283), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2289), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2302), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2309), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2317), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2323), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2329), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2335), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2343), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2349), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2363), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2365), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2369), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2374), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2377), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2383), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2385), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2388), new DateTime(2026, 3, 6, 5, 55, 38, 947, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(3030), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4043), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4052), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4056), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4150), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4203), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4209), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4212), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4215), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4220), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4223), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4226), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4228), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4231), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4233), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4236), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(7601), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9384), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9391), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9394), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9397), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9402), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9428), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9431), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9436), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9439), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9441), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9443), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9446), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9449), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9457), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9459), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9461), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9465), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9468), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9471), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9473), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9475), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9478), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9480), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9482), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9484), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9487), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9489), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9492), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9494), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9497), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9499), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9503), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9507), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9509), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9512), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9514), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9517), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9519), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9522), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9524), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9526), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9529), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9531), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9534), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9536), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9538), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9541), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9543), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9545), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9547), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9550), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9552), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9554), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9557), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9559), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9566), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9568), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9571), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9574), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9576), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9579), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9593), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9595), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9600), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9602), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9604), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9607), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9609), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9611), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9613), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9616), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9618), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9620), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9623), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9628), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9633), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9635), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9637), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9639), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9642), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9644), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9647), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9650), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9652), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9654), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9656), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9659), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9662), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9665), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9667), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9669), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9672), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9674), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9676), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9678), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9681), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9683), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9685), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9687), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9690), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9693), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9698), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9700), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9702), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9705), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9707), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9710), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9713), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9715), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9717), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9719), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9722), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9724), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9728), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9730), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9732), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9744), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9746), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9749), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9752), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9754), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9757), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9759), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9764), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9766), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9768), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9773), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9775), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9778), new DateTime(2026, 3, 6, 5, 55, 38, 954, DateTimeKind.Local).AddTicks(9778) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportType",
                table: "Items");

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

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3169), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3171), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3173), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3175), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(3176) });

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
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7533), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7541), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7542), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7544), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7551), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7568), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7570), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7575), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7577), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7578), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7580), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7581), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7587), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7589), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7590), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7593), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7595), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7597), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7598), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7600), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7601), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7603), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7604), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7606), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7607), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7610), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7613), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7614), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7616), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7618), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7621), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7623), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7624), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7626), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7628), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7630), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7631), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7633), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7635), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7636), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7638), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7639), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7641), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7642), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7645), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7646), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7648), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7649), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7651), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7653), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7654), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7656), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7657), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7659), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7661), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7662), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7664), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7666), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7668), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7669), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7679), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7681), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7684), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7685), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7687), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7689), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7691), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7692), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7694), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7695), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7697), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7699), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7700), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7702), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7704), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7706), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7707), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7709), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7711), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7712), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7714), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7715), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7717), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7719), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7721), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7722), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7724), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7726), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7727), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7729), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7731), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7732), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7734), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7736), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7737), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7739), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7741), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7742), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7744), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7746), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7747), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7749), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7751), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7752), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7754), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7756), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7757), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7759), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7761), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7762), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7764), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7766), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7767), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7769), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7771), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7772), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7792), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7794), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7796), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7797), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7799), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7800), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7802), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7805), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7806), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7808), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7811), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7813), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7815), new DateTime(2026, 3, 4, 4, 25, 16, 826, DateTimeKind.Local).AddTicks(7816) });
        }
    }
}
