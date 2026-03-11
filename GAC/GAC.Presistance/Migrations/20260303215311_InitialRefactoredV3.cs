using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GAC.Presistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialRefactoredV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogLevel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    RequestUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RequestMethod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemTypes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemTypes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemTypes_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Locations_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MobileCompanies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_MobileCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobileCompanies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobileCompanies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobileCompanies_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTypeId = table.Column<long>(type: "bigint", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fields_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    ItemTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MobileModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MobileCompanyId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_MobileModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobileModels_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobileModels_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobileModels_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MobileModels_MobileCompanies_MobileCompanyId",
                        column: x => x.MobileCompanyId,
                        principalTable: "MobileCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuctionRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    HighestBid = table.Column<long>(type: "bigint", nullable: false),
                    HighestBidderId = table.Column<int>(type: "int", nullable: false),
                    CnicImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_AuctionRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuctionRecords_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionRecords_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionRecords_AspNetUsers_HighestBidderId",
                        column: x => x.HighestBidderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionRecords_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuctionRecords_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    BidderId = table.Column<int>(type: "int", nullable: false),
                    BidAmount = table.Column<long>(type: "bigint", nullable: false),
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Bids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_BidderId",
                        column: x => x.BidderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClaimRequest",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    Score = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ClaimRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClaimRequest_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimRequest_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimRequest_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimRequest_Items_FoundItemId",
                        column: x => x.FoundItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClaimRequest_Items_LostItemId",
                        column: x => x.LostItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemAttributes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FieldValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_ItemAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAttributes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemAttributes_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemAttributes_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemAttributes_Items_LostItemId",
                        column: x => x.LostItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReplacmentRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoundItemId = table.Column<long>(type: "bigint", nullable: false),
                    LostItemId = table.Column<long>(type: "bigint", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ItemsHandOverRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimRequestId = table.Column<long>(type: "bigint", nullable: false),
                    CnicImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ItemsHandOverRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsHandOverRecords_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsHandOverRecords_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsHandOverRecords_AspNetUsers_LastModifiedBy",
                        column: x => x.LastModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemsHandOverRecords_ClaimRequest_ClaimRequestId",
                        column: x => x.ClaimRequestId,
                        principalTable: "ClaimRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "STATIC-ROLE-2026", "Full system access", "Admin", "ADMIN" },
                    { 2, "STATIC-ROLE-2026", "User Portal Access", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "d4dafc79-9856-448c-ba33-d625ae31826f", "admin@gmail.com", true, "Admin", true, "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEJK/v1R5erMNIE3b0YsoyoEO7yba0M5onYT7DaGUFbL4r4MzpkYQt/vIawMr1LGkrw==", null, false, null, "", new DateTime(2025, 3, 3, 21, 53, 9, 330, DateTimeKind.Utc).AddTicks(1097), "0293b5c7-e130-4758-8551-c94856720532", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(1137), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(1143), "Mobile Phone" },
                    { 2L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2060), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2065), "Wallet" },
                    { 3L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2069), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2069), "Laptop" },
                    { 4L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2071), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2071), "Keys" },
                    { 5L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2072), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2073), "Bag / Backpack" },
                    { 6L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2074), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2075), "Watch" },
                    { 7L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2076), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2076), "Passport / ID Card" },
                    { 8L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2077), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2078), "Jewelry" },
                    { 9L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2079), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2079), "Earphones / Headphones" },
                    { 10L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2153), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(2154), "Other" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Description", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 452, DateTimeKind.Local).AddTicks(9401), null, null, "LT 1", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 454, DateTimeKind.Local).AddTicks(6601), "LT1" },
                    { 2L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(344), null, null, "LT 2", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(348), "LT2" },
                    { 3L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(534), null, null, "LT 3", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(536), "LT3" },
                    { 4L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(542), null, null, "LT 4", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(543), "LT4" },
                    { 5L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(548), null, null, "LT 5", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(548), "LT5" },
                    { 6L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(567), null, null, "LT 6", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(568), "LT6" },
                    { 7L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(576), null, null, "LT 7", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(576), "LT7" },
                    { 8L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(592), null, null, "LT 8", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(592), "LT8" },
                    { 9L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(603), null, null, "LT 9", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(604), "LT9" },
                    { 10L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(610), null, null, "LT 10", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(610), "LT10" },
                    { 11L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(625), null, null, "LT 11", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(625), "LT11" },
                    { 12L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(630), null, null, "LT 12", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(630), "LT12" },
                    { 13L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(635), null, null, "LT 13", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(636), "LT13" },
                    { 14L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2648), null, null, "Lab 1", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2653), "LAB-1" },
                    { 15L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2705), null, null, "Lab 2", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2705), "LAB-2" },
                    { 16L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2712), null, null, "Lab 3", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2712), "LAB-3" },
                    { 17L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2716), null, null, "Lab 4", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2717), "LAB-4" },
                    { 18L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2734), null, null, "Lab 5", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2735), "LAB-5" },
                    { 19L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2739), null, null, "Lab 6", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2739), "LAB-6" },
                    { 20L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2743), null, null, "Lab 7", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2743), "LAB-7" },
                    { 21L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2747), null, null, "Lab 8", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2747), "LAB-8" },
                    { 22L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2751), null, null, "Lab 9", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2751), "LAB-9" },
                    { 23L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2754), null, null, "Lab 10", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2755), "LAB-10" },
                    { 24L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2764), null, null, "Lab 11", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2765), "LAB-11" },
                    { 25L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2769), null, null, "Lab 12", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2769), "LAB-12" },
                    { 26L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2776), null, null, "Parking Area", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2776), "Parking" },
                    { 27L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2778), null, null, "Ground Floor Corridor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2779), "Corridor Ground" },
                    { 28L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2780), null, null, "First Floor Corridor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2780), "Corridor First" },
                    { 29L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2782), null, null, "Second Floor Corridor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2782), "Corridor Second" },
                    { 30L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2783), null, null, "Third Floor Corridor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2784), "Corridor Third" },
                    { 31L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2785), null, null, "Stairs – Ground Floor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2785), "Stairs Ground" },
                    { 32L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2787), null, null, "Stairs – First Floor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2787), "Stairs First" },
                    { 33L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2789), null, null, "Stairs – Second Floor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2789), "Stairs Second" },
                    { 34L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2790), null, null, "Stairs – Third Floor", true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 455, DateTimeKind.Local).AddTicks(2791), "Stairs Third" }
                });

            migrationBuilder.InsertData(
                table: "MobileCompanies",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 458, DateTimeKind.Local).AddTicks(9646), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 458, DateTimeKind.Local).AddTicks(9652), "Samsung" },
                    { 2L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(388), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(391), "Apple" },
                    { 3L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(396), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(397), "Oppo" },
                    { 4L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(398), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(399), "Redmi" },
                    { 5L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(401), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(401), "Infinix" },
                    { 6L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(412), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(412), "Realme" }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "FieldName", "IsActive", "IsDeleted", "ItemTypeId", "LastModifiedBy", "LastModifiedOn" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(3373), null, null, "Brand", true, false, 1L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(3376) },
                    { 2L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4552), null, null, "Model", true, false, 1L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4556) },
                    { 3L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4559), null, null, "Color", true, false, 1L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4559) },
                    { 4L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4561), null, null, "IMEI (last 4 digits)", true, false, 1L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4561) },
                    { 5L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4563), null, null, "Has Case", true, false, 1L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4563) },
                    { 10L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4564), null, null, "Color", true, false, 2L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4565) },
                    { 11L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4566), null, null, "Material", true, false, 2L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4567) },
                    { 12L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4568), null, null, "Brand", true, false, 2L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4568) },
                    { 13L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4570), null, null, "Contains Cards/ID", true, false, 2L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4570) },
                    { 20L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4571), null, null, "Brand", true, false, 3L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4572) },
                    { 21L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4573), null, null, "Model", true, false, 3L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4573) },
                    { 22L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4575), null, null, "Color", true, false, 3L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4575) },
                    { 23L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4576), null, null, "Screen Size", true, false, 3L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4577) },
                    { 24L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4578), null, null, "Has Sticker(s)", true, false, 3L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4579) },
                    { 30L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4580), null, null, "Number of Keys", true, false, 4L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4580) },
                    { 31L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4582), null, null, "Key Type", true, false, 4L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4582) },
                    { 32L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4583), null, null, "Has Keychain", true, false, 4L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4584) },
                    { 33L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4585), null, null, "Color of Keychain", true, false, 4L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4585) },
                    { 40L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4587), null, null, "Type", true, false, 5L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4587) },
                    { 41L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4589), null, null, "Color", true, false, 5L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4589) },
                    { 42L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4590), null, null, "Brand", true, false, 5L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4591) },
                    { 43L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4592), null, null, "Has Logo", true, false, 5L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4593) },
                    { 50L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4594), null, null, "Brand", true, false, 6L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4595) },
                    { 51L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4596), null, null, "Color", true, false, 6L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4596) },
                    { 52L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4597), null, null, "Strap Material", true, false, 6L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4598) },
                    { 53L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4599), null, null, "Has Date Display", true, false, 6L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4600) },
                    { 60L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4601), null, null, "Document Type", true, false, 7L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4601) },
                    { 61L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4603), null, null, "Issuing Country", true, false, 7L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4603) },
                    { 62L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4604), null, null, "Color of Cover", true, false, 7L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4605) },
                    { 70L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4606), null, null, "Type", true, false, 8L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4607) },
                    { 71L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4608), null, null, "Material", true, false, 8L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4608) },
                    { 72L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4609), null, null, "Color", true, false, 8L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4610) },
                    { 80L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4611), null, null, "Brand", true, false, 9L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4612) },
                    { 81L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4613), null, null, "Type", true, false, 9L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4613) },
                    { 82L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4615), null, null, "Color", true, false, 9L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4615) },
                    { 83L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4616), null, null, "Has Case", true, false, 9L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4617) },
                    { 90L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4618), null, null, "Main Color", true, false, 10L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4619) },
                    { 91L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4620), null, null, "Secondary Color", true, false, 10L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4620) },
                    { 92L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4621), null, null, "Size / Dimensions", true, false, 10L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4622) },
                    { 93L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4623), null, null, "Brand / Logo", true, false, 10L, null, new DateTime(2026, 3, 4, 2, 53, 9, 457, DateTimeKind.Local).AddTicks(4624) }
                });

            migrationBuilder.InsertData(
                table: "MobileModels",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "MobileCompanyId", "Name" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(2767), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(2770), 1L, "S24 Ultra" },
                    { 2L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4028), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4030), 1L, "S24+" },
                    { 3L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4034), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4034), 1L, "S24" },
                    { 4L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4035), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4036), 1L, "S23 Ultra" },
                    { 5L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4037), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4037), 1L, "S23+" },
                    { 6L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4044), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4044), 1L, "S23" },
                    { 7L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4045), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4045), 1L, "S22 Ultra" },
                    { 8L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4046), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4047), 1L, "S22+" },
                    { 9L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4048), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4048), 1L, "S22" },
                    { 10L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4050), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4051), 1L, "S21 Ultra" },
                    { 11L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4051), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4052), 1L, "S21 FE" },
                    { 12L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4053), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4053), 1L, "S21" },
                    { 13L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4054), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4054), 1L, "Z Fold 5" },
                    { 14L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4055), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4056), 1L, "Z Flip 5" },
                    { 15L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4056), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4057), 1L, "A54" },
                    { 16L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4058), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4058), 1L, "A34" },
                    { 17L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4059), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4059), 1L, "A24" },
                    { 18L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4061), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4062), 1L, "A14" },
                    { 19L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4065), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4065), 2L, "iPhone 15 Pro Max" },
                    { 20L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4066), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4067), 2L, "iPhone 15 Pro" },
                    { 21L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4068), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4068), 2L, "iPhone 15 Plus" },
                    { 22L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4094), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4094), 2L, "iPhone 15" },
                    { 23L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4095), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4096), 2L, "iPhone 14 Pro Max" },
                    { 24L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4097), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4097), 2L, "iPhone 14 Pro" },
                    { 25L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4098), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4098), 2L, "iPhone 14 Plus" },
                    { 26L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4100), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4100), 2L, "iPhone 14" },
                    { 27L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4101), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4102), 2L, "iPhone 13 Pro Max" },
                    { 28L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4102), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4103), 2L, "iPhone 13 Pro" },
                    { 29L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4104), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4104), 2L, "iPhone 13" },
                    { 30L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4105), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4105), 2L, "iPhone 13 mini" },
                    { 31L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4106), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4107), 2L, "iPhone 12" },
                    { 32L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4107), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4108), 2L, "iPhone SE (3rd gen)" },
                    { 33L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4109), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4110), 3L, "Find N3" },
                    { 34L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4112), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4112), 3L, "Find N3 Flip" },
                    { 35L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4113), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4114), 3L, "Find X6 Pro" },
                    { 36L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4114), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4115), 3L, "Find X6" },
                    { 37L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4116), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4116), 3L, "Reno 10 Pro+" },
                    { 38L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4117), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4118), 3L, "Reno 10 Pro" },
                    { 39L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4118), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4119), 3L, "Reno 10" },
                    { 40L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4120), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4120), 3L, "A98" },
                    { 41L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4121), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4121), 3L, "A78" },
                    { 42L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4122), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4123), 3L, "A58" },
                    { 43L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4123), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4124), 3L, "A38" },
                    { 44L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4125), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4126), 4L, "Note 13 Pro+" },
                    { 45L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4126), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4127), 4L, "Note 13 Pro" },
                    { 46L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4128), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4128), 4L, "Note 13" },
                    { 47L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4129), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4129), 4L, "Note 12 Pro+" },
                    { 48L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4130), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4131), 4L, "Note 12 Pro" },
                    { 49L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4131), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4132), 4L, "Note 12" },
                    { 50L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4133), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4133), 4L, "13C" },
                    { 51L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4134), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4134), 4L, "12C" },
                    { 52L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4135), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4136), 4L, "A2" },
                    { 53L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4136), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4137), 4L, "K60 Ultra" },
                    { 54L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4138), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4139), 5L, "Zero 30" },
                    { 55L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4139), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4140), 5L, "Zero Ultra" },
                    { 56L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4141), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4141), 5L, "Note 30 Pro" },
                    { 57L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4142), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4142), 5L, "Note 30" },
                    { 58L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4143), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4144), 5L, "Hot 40 Pro" },
                    { 59L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4145), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4145), 5L, "Hot 40" },
                    { 60L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4146), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4146), 5L, "Hot 30" },
                    { 61L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4147), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4148), 5L, "Smart 8" },
                    { 62L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4149), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4149), 5L, "Smart 7" },
                    { 63L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4150), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4151), 6L, "GT 5 Pro" },
                    { 64L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4151), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4152), 6L, "GT 5" },
                    { 65L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4153), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4154), 6L, "11 Pro+" },
                    { 66L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4156), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4156), 6L, "11 Pro" },
                    { 67L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4157), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4158), 6L, "11" },
                    { 68L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4159), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4159), 6L, "C67" },
                    { 69L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4160), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4160), 6L, "C55" },
                    { 70L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4161), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4161), 6L, "C53" },
                    { 71L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4162), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4163), 6L, "C51" },
                    { 72L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4164), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4164), 6L, "Narzo 60 Pro" },
                    { 73L, 1, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4165), null, null, true, false, null, new DateTime(2026, 3, 4, 2, 53, 9, 459, DateTimeKind.Local).AddTicks(4165), 6L, "Narzo 60" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionRecords_CreatedBy",
                table: "AuctionRecords",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionRecords_DeletedBy",
                table: "AuctionRecords",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionRecords_FoundItemId",
                table: "AuctionRecords",
                column: "FoundItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionRecords_HighestBidderId",
                table: "AuctionRecords",
                column: "HighestBidderId");

            migrationBuilder.CreateIndex(
                name: "IX_AuctionRecords_LastModifiedBy",
                table: "AuctionRecords",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_BidderId",
                table: "Bids",
                column: "BidderId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_CreatedBy",
                table: "Bids",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_DeletedBy",
                table: "Bids",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_FoundItemId",
                table: "Bids",
                column: "FoundItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_LastModifiedBy",
                table: "Bids",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimRequest_CreatedBy",
                table: "ClaimRequest",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimRequest_DeletedBy",
                table: "ClaimRequest",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimRequest_FoundItemId",
                table: "ClaimRequest",
                column: "FoundItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimRequest_LastModifiedBy",
                table: "ClaimRequest",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ClaimRequest_LostItemId",
                table: "ClaimRequest",
                column: "LostItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_CreatedBy",
                table: "Fields",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_DeletedBy",
                table: "Fields",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_ItemType_FieldName_Unique",
                table: "Fields",
                columns: new[] { "ItemTypeId", "FieldName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fields_LastModifiedBy",
                table: "Fields",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributes_CreatedBy",
                table: "ItemAttributes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributes_DeletedBy",
                table: "ItemAttributes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributes_LastModifiedBy",
                table: "ItemAttributes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAttributes_LostItemId",
                table: "ItemAttributes",
                column: "LostItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CreatedBy",
                table: "Items",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Items_DeletedBy",
                table: "Items",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeId",
                table: "Items",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_LastModifiedBy",
                table: "Items",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Items_LocationId",
                table: "Items",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_ClaimRequestId",
                table: "ItemsHandOverRecords",
                column: "ClaimRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_CreatedBy",
                table: "ItemsHandOverRecords",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_DeletedBy",
                table: "ItemsHandOverRecords",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsHandOverRecords_LastModifiedBy",
                table: "ItemsHandOverRecords",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_CreatedBy",
                table: "ItemTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_DeletedBy",
                table: "ItemTypes",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_LastModifiedBy",
                table: "ItemTypes",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CreatedBy",
                table: "Locations",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DeletedBy",
                table: "Locations",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LastModifiedBy",
                table: "Locations",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileCompanies_CreatedBy",
                table: "MobileCompanies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileCompanies_DeletedBy",
                table: "MobileCompanies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileCompanies_LastModifiedBy",
                table: "MobileCompanies",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileModels_CreatedBy",
                table: "MobileModels",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileModels_DeletedBy",
                table: "MobileModels",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileModels_LastModifiedBy",
                table: "MobileModels",
                column: "LastModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MobileModels_MobileCompanyId",
                table: "MobileModels",
                column: "MobileCompanyId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuctionRecords");

            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "ExceptionLogs");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "ItemAttributes");

            migrationBuilder.DropTable(
                name: "ItemsHandOverRecords");

            migrationBuilder.DropTable(
                name: "MobileModels");

            migrationBuilder.DropTable(
                name: "ReplacmentRecords");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ClaimRequest");

            migrationBuilder.DropTable(
                name: "MobileCompanies");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
