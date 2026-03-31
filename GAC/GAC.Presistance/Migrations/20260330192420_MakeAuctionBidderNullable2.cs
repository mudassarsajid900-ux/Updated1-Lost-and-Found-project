using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class MakeAuctionBidderNullable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "HighestBidderId",
                table: "AuctionRecords",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PersonImagePath",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CnicImagePath",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HighestBidderId",
                table: "AuctionRecords",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
