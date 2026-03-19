using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class AddSystemSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReplacmentRecords");

            migrationBuilder.AlterColumn<long>(
                name: "ClaimRequestId",
                table: "ItemsHandOverRecords",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "AdminNotes",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "AuctionRecordId",
                table: "ItemsHandOverRecords",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HandoverType",
                table: "ItemsHandOverRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "ItemsHandOverRecords",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverCnic",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "ItemsHandOverRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "ReplacementRecordId",
                table: "ItemsHandOverRecords",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReplacementRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: true),
                    RequestReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DesiredSpecifications = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AdminNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DecisionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CnicImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PersonImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
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
                    table.PrimaryKey("PK_ReplacementRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplacementRecords_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementRecords_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementRecords_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementRecords_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacementRecords_Items_LostItemId",
                        column: x => x.LostItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingKey = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_SystemSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemSettings_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSettings_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemSettings_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "SystemSettings",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Description", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "SettingKey", "SettingValue" },
                values: new object[] { 1L, 1, new DateTime(2026, 3, 17, 15, 25, 3, 71, DateTimeKind.Utc).AddTicks(9503), null, null, "Number of days a lost item remains missing before replacement eligibility opens.", true, false, null, new DateTime(2026, 3, 17, 20, 25, 3, 71, DateTimeKind.Local).AddTicks(7803), "ReplacementThresholdDays", "90" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_AuctionRecordId",
                table: "ItemsHandOverRecords",
                column: "AuctionRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_ItemId",
                table: "ItemsHandOverRecords",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_ReplacementRecordId",
                table: "ItemsHandOverRecords",
                column: "ReplacementRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementRecords_CreatedBy",
                table: "ReplacementRecords",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementRecords_DeletedBy",
                table: "ReplacementRecords",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementRecords_FoundItemId",
                table: "ReplacementRecords",
                column: "FoundItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementRecords_LastModifiedBy",
                table: "ReplacementRecords",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacementRecords_LostItemId",
                table: "ReplacementRecords",
                column: "LostItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_CreatedBy",
                table: "SystemSettings",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_DeletedBy",
                table: "SystemSettings",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SystemSettings_LastModifiedBy",
                table: "SystemSettings",
                column: "LastModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsHandOverRecords_AuctionRecords_AuctionRecordId",
                table: "ItemsHandOverRecords",
                column: "AuctionRecordId",
                principalTable: "AuctionRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsHandOverRecords_Items_ItemId",
                table: "ItemsHandOverRecords",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsHandOverRecords_ReplacementRecords_ReplacementRecordId",
                table: "ItemsHandOverRecords",
                column: "ReplacementRecordId",
                principalTable: "ReplacementRecords",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsHandOverRecords_AuctionRecords_AuctionRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsHandOverRecords_Items_ItemId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsHandOverRecords_ReplacementRecords_ReplacementRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropTable(
                name: "ReplacementRecords");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropIndex(
                name: "IX_ItemsHandOverRecords_AuctionRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropIndex(
                name: "IX_ItemsHandOverRecords_ItemId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropIndex(
                name: "IX_ItemsHandOverRecords_ReplacementRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "AdminNotes",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "AuctionRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "HandoverType",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "ReceiverCnic",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "ReplacementRecordId",
                table: "ItemsHandOverRecords");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Items");

            migrationBuilder.AlterColumn<long>(
                name: "ClaimRequestId",
                table: "ItemsHandOverRecords",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ReplacmentRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: true),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
                    CnicImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonImagePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplacmentRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReplacmentRecords_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacmentRecords_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacmentRecords_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacmentRecords_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReplacmentRecords_Items_LostItemId",
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
                name: "IX_ReplacmentRecords_CreatedBy",
                table: "ReplacmentRecords",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacmentRecords_DeletedBy",
                table: "ReplacmentRecords",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacmentRecords_FoundItemId",
                table: "ReplacmentRecords",
                column: "FoundItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacmentRecords_LastModifiedBy",
                table: "ReplacmentRecords",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReplacmentRecords_LostItemId",
                table: "ReplacmentRecords",
                column: "LostItemId");
        }
    }
}
