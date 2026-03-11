using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "e0a6d2ab-a443-42fd-8569-eff118d7e675", "AQAAAAIAAYagAAAAEOsjyF96EDjLpKh7F7WOv5HEhETA3S0o6787M4OtuVPDxl6usR0i+dHraPBtG+M7xw==", new DateTime(2025, 3, 6, 10, 49, 20, 71, DateTimeKind.Utc).AddTicks(6702), "d58cd652-0a7a-46eb-a723-f8e78163bae4" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(8962), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1017), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1067), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1070), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1072), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1075), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1077), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1080), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1081), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1084), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1086), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1088), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1090), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1092), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1094), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1095), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1098), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1099), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1102), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1104), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1106), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1108), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1110), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1112), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1114), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1116), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1118), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1120), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1122), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1124), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1126), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1128), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1130), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1132), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1134), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1136), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1138), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1140), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1142), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1144), new DateTime(2026, 3, 6, 15, 49, 20, 245, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(909), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2523), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2533), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2536), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2539), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2541), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2544), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2547), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2550), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2553), new DateTime(2026, 3, 6, 15, 49, 20, 244, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 236, DateTimeKind.Local).AddTicks(816), new DateTime(2026, 3, 6, 15, 49, 20, 238, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(416), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(918), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(945), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(951), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(971), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(979), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1003), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1013), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1019), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1045), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1050), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1057), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4121), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4202), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4219), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4224), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4246), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4253), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4258), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4262), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4266), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4270), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4279), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4283), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4295), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4298), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4300), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4303), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4305), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4307), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4309), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4311), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4313), new DateTime(2026, 3, 6, 15, 49, 20, 239, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(8474), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9608), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9620), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9622), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9638), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9640), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9740), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9745), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9752), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9754), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9779), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9781), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9783), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9785), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9787), new DateTime(2026, 3, 6, 15, 49, 20, 247, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(3028), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4694), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4702), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4703), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4705), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4711), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4713), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4714), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4716), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4719), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4721), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4722), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4724), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4742), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4748), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4750), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4752), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4754), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4756), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4757), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4759), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4760), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4762), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4763), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4765), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4766), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4768), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4770), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4772), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4774), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4775), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4777), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4778), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4781), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4782), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4784), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4785), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4788), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4790), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4792), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4793), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4795), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4796), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4798), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4799), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4801), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4802), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4805), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4809), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4810), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4812), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4813), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4815), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4816), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4818), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4819), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4821), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4822), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4824), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4825), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4828), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4830), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4832), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4833), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4835), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4845), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4847), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4848), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4851), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4853), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4855), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4856), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4858), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4859), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4861), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4862), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4864), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4867), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4869), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4870), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4872), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4873), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4875), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4876), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4877), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4881), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4885), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4886), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4888), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4890), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4892), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4895), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4896), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4898), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4899), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4902), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4904), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4906), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4907), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4909), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4910), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4912), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4914), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4915), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4918), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4920), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4921), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4923), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4924), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4926), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4928), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4929), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4931), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4933), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4934), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4936), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4938), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4940), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4941), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4943), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4944), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4946), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4948), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4949), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4951), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4952), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4954), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4965), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4967), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4970), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4972), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4973), new DateTime(2026, 3, 6, 15, 49, 20, 248, DateTimeKind.Local).AddTicks(4974) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Items");

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
    }
}
