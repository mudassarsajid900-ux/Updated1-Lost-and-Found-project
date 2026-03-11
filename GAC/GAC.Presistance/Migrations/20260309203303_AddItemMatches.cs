using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddItemMatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Bids");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "AuctionRecords");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ItemMatches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    MatchConfidenceScore = table.Column<double>(type: "float", nullable: false),
                    IsMatchResolved = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemMatches_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatches_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatches_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatches_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatches_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemMatches_Items_LostItemId",
                        column: x => x.LostItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RefreshTokenExpiryTime", "SecurityStamp" },
                values: new object[] { "034cc62c-3685-4c41-b88a-fe7cd6ae7a5f", "AQAAAAIAAYagAAAAEJPc2NVIuTqBUjr33jfFDrm29yvwVp8M8zFs6ictgEmNSXc/cnaVor9FKjIIdetyGA==", new DateTime(2025, 3, 9, 20, 32, 57, 983, DateTimeKind.Utc).AddTicks(6522), "90c94ebf-55ee-4c7d-b913-0777ce5b4b7b" });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(641), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2576), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2585), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2692), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2700), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2704), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2707), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2710), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2713), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2716), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2719), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2722), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2725), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2728), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2730), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2733), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2736), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2738), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2741), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2744), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2747), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2750), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2752), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2755), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2758), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2760), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2763), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2766), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2769), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2772), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2775), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2779), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2782), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2785), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2788), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2791), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2794), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2797), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2800), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2802), new DateTime(2026, 3, 10, 1, 32, 58, 125, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(7785), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8830), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8836), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8839), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8842), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8845), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8848), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8851), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8854), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8856), new DateTime(2026, 3, 10, 1, 32, 58, 124, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 119, DateTimeKind.Local).AddTicks(1993), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(4761), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5016), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5024), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5028), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5047), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5052), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5056), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5060), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5065), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5072), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5076), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5080), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7316), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7355), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7359), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7363), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7377), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7381), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7385), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7389), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7393), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7397), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7402), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7406), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7413), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7415), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7417), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7419), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7421), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7423), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7425), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7426), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7429), new DateTime(2026, 3, 10, 1, 32, 58, 121, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(1409), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2578), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2594), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2598), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2601), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2617), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2620), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2623), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2627), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2632), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2635), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2762), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2766), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2769), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2772), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "MobileCompanies",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2776), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(7019), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9114), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9129), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9132), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9135), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9146), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9149), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9151), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9154), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9159), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9162), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9164), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9166), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9168), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9175), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9178), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9180), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9186), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9188), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9190), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9193), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9196), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9198), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9201), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9203), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9205), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9207), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9211), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9214), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9216), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9218), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9221), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9224), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9228), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9231), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9233), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9236), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9240), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9242), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9245), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9247), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9250), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9252), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9256), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9258), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9261), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9263), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9269), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9271), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9273), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9301), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9305), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9307), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9310), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9313), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9315), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9318), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9320), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9323), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9326), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9329), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9332), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9334), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9337), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9339), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9344), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9347), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9349), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9353), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9355), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9358), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9360), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9363), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9365), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9368), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9371), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9373), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9377), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9380), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9383), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9385), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9388), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9390), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9393), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9395), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9400), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9402), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9404), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9407), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9410), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9413), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9416), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9419), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9421), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9424), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9428), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9430), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9433), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9436), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9438), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9441), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9444), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9447), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9449), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9453), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9455), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9470), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9473), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9476), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9478), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9483), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9486), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9488), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9491), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9493), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9496), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9500), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9502), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9505), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9508), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9510), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9514), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9517), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9519), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9522), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9524), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9528), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9531), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9533), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9541), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9543), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "MobileModels",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9546), new DateTime(2026, 3, 10, 1, 32, 58, 129, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_CreatedBy",
                table: "ItemMatches",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_DeletedBy",
                table: "ItemMatches",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_FoundItemId",
                table: "ItemMatches",
                column: "FoundItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_LastModifiedBy",
                table: "ItemMatches",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_LostItemId",
                table: "ItemMatches",
                column: "LostItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemMatches_UserId",
                table: "ItemMatches",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemMatches");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "Bids",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "AuctionRecords",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
    }
}
