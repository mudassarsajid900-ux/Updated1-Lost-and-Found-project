using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class MakeAuctionImagesNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "AuctionRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "AuctionRecords",
                type: "nvarchar(max)",
                nullable: true,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "AuctionRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "AuctionRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "e37ca361-8e98-4ee2-bc6b-6e3297cb0b13", "AQAAAAIAAYagAAAAEDZH7SE3UD66EL24NNXjrUVF3rh+wMqWRuFHrSRsbl6gTMVCJlicruxTpUeM3w+41g==", new DateTime(2025, 3, 30, 19, 24, 7, 162, DateTimeKind.Utc).AddTicks(4309), "94384571-b826-466b-a34e-6186b65fd0a5" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(5109), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6812), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6825), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6827), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6830), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6946), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6952), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6955), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6958), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6962), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6964), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6967), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6970), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6973), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6976), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6979), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6982), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6985), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6988), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6991), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6994), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6997), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7000), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7003), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7006), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7009), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7013), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7016), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7018), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7058), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7062), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7066), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7069), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7072), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7075), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7077), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7080), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7083), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7086), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7089), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(2383), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3608), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3620), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3622), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3624), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3626), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3627), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3629), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3631), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3632), new DateTime(2026, 3, 31, 0, 24, 7, 298, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 292, DateTimeKind.Local).AddTicks(6287), new DateTime(2026, 3, 31, 0, 24, 7, 294, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(4606), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5014), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5030), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5036), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5058), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5064), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5070), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5076), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5085), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5096), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5105), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5112), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7879), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7944), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7952), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7959), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7989), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(7999), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8007), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8013), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8020), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8027), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8040), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8046), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8058), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8061), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8063), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8066), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8069), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8071), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8109), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8112), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8115), new DateTime(2026, 3, 31, 0, 24, 7, 295, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 303, DateTimeKind.Local).AddTicks(7819), new DateTime(2026, 3, 31, 0, 24, 7, 303, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 303, DateTimeKind.Local).AddTicks(9994), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(11), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(15), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(18), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(40), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(44), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(46), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(49), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(55), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(58), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(61), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(64), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(67), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(70), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(73), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(4003), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5939), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5947), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5950), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5960), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5962), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5963), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5965), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5968), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5969), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5971), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5973), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5974), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5978), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5980), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5982), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5984), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5986), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5987), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5988), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5990), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5991), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5992), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5994), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5996), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5997), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5999), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6000), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6001), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6003), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6004), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6005), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6008), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6027), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6029), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6030), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6032), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6033), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6035), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6036), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6037), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6039), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6040), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6041), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6042), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6044), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6046), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6048), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6049), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6050), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6052), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6053), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6054), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6055), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6057), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6058), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6059), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6061), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6062), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6064), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6066), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6067), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6068), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6069), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6072), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6074), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6075), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6077), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6078), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6079), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6080), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6082), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6083), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6084), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6086), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6087), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6089), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6090), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6092), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6093), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6094), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6095), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6097), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6098), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6100), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6101), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6102), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6104), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6105), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6115), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6116), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6117), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6119), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6120), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6122), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6123), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6125), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6126), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6127), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6129), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6130), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6131), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6133), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6135), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6136), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6137), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6139), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6140), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6141), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6144), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6145), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6146), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6148), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6149), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6150), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6153), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6155), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6156), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6157), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6158), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6160), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6161), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6163), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6164), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6165), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6168), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6169), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6170), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6174), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6178), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6179), new DateTime(2026, 3, 31, 0, 24, 7, 304, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 30, 19, 24, 7, 305, DateTimeKind.Utc).AddTicks(4600), new DateTime(2026, 3, 31, 0, 24, 7, 305, DateTimeKind.Local).AddTicks(2592) });
        }
    }
}
