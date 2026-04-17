// ========================================== //
// SECTION: DATA ARCHITECTURE SEEDING
// DESCRIPTION: Initial provisioning for GAC System Roles, Locations, and Dynamic Categories.
// ========================================== //
using GAC.Core.Entities.Identity;
using GAC.Core.Entities.ItemTypes;
using GAC.Core.Entities.Locations;
using GAC.Core.Entities.SystemSettings;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GAC.Infrastructure.Data
{
    /// <summary>
    /// Orchestrates the initial state of the GAC database.
    /// Implements standard university assets, verified campus locations, and system-wide thresholds.
    /// </summary>
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedRoles(builder);
            SeedUsers(builder);
            SeedUserRoles(builder);
            SeedLocations(builder);
            SeedItemTypes(builder);
            SeedMobileModels(builder);
            SeedSystemSettings(builder);
        }

        /// <summary>
        /// Provisioning of System Tuning Thresholds.
        /// These values control the lifecycle of lost and found assets across the campus.
        /// </summary>
        private static void SeedSystemSettings(ModelBuilder builder)
        {
            builder.Entity<SystemSetting>().HasData(
                new SystemSetting
                {
                    Id = 1,
                    SettingKey = "ReplacementEligibilityThreshold",
                    SettingValue = "90",
                    Description = "Mandatory wait period (days) before a lost report can initiate a replacement claim.",
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow
                },
                new SystemSetting
                {
                    Id = 2,
                    SettingKey = "FoundToReplacementThreshold",
                    SettingValue = "20",
                    Description = "Retention period (days) before an unclaimed found item enters the user-facing replacement pool.",
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow
                },
                new SystemSetting
                {
                    Id = 3,
                    SettingKey = "ReplacementToAuctionThreshold",
                    SettingValue = "40",
                    Description = "Time limit (days) for items in the replacement pool before liquidation via internal auction.",
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow
                }
            );
        }

        public static List<Location> GetSeededLocations()
        {
            var locations = new List<Location>();
            var timestamp = DateTime.UtcNow;

            // Provision Lecture Theatres (LT1 – LT13)
            locations.AddRange(
                Enumerable.Range(1, 13).Select(i => new Location
                {
                    Id = i,
                    Name = $"LT{i}",
                    Description = $"Lecture Theatre {i}",
                    CreatedBy = 1,
                    CreatedOn = timestamp
                })
            );

            // Provision Laboratories (LAB-1 – LAB-12)
            locations.AddRange(
                Enumerable.Range(1, 12).Select(i => new Location
                {
                    Id = 13 + i,
                    Name = $"LAB-{i}",
                    Description = $"Computer/Science Laboratory {i}",
                    CreatedBy = 1,
                    CreatedOn = timestamp
                })
            );

            // Provision General Campus High-Traffic Zones
            locations.AddRange(new[]
            {
                new Location { Id = 26, Name = "Parking Central",    Description = "Central Parking Wing",          CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 27, Name = "Corridor (GF)",      Description = "Ground Floor Main Corridor",    CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 28, Name = "Corridor (FF)",      Description = "First Floor Academic Wing",     CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 29, Name = "Corridor (SF)",      Description = "Second Floor Department Wing",  CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 30, Name = "Corridor (TF)",      Description = "Third Floor Research Wing",     CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 31, Name = "Stairwell (GF-FF)",  Description = "Ground to First Floor Access",  CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 32, Name = "Stairwell (FF-SF)",  Description = "First to Second Floor Access",  CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 33, Name = "Stairwell (SF-TF)",  Description = "Second to Third Floor Access",  CreatedBy = 1, CreatedOn = timestamp },
                new Location { Id = 34, Name = "Admin Office",       Description = "Central Lost & Found Repository", CreatedBy = 1, CreatedOn = timestamp },
            });
            
            return locations;
        }

        public static void SeedLocations(ModelBuilder builder)
        {
            builder.Entity<Location>().HasData(GetSeededLocations());
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "Full Administrative & Financial System Governance",
                    ConcurrencyStamp = "STATIC-UID-2026-ADMIN"
                },
                new ApplicationRole
                {
                    Id = 2,
                    Name = "User",
                    NormalizedName = "USER",
                    Description = "Standard Academic Portal Access (Student/Staff)",
                    ConcurrencyStamp = "STATIC-UID-2026-USER"
                });
        }

        /// <summary>
        /// Provisioning of Item Archetypes and Forensic Attributes.
        /// These fields drive the Intelligent Matching Engine.
        /// </summary>
        public static void SeedItemTypes(ModelBuilder builder)
        {
            builder.Entity<ItemType>().HasData(
                new ItemType { Id = 1, Name = "Mobile Device", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 2, Name = "Personal Wallet", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 3, Name = "Computing Hardware (Laptop)", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 4, Name = "Security Keys", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 5, Name = "Personal Bag / Luggage", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 6, Name = "Timepiece (Watch)", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 7, Name = "Official Documentation (ID/Pass)", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 8, Name = "Jewelry & Valuables", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 9, Name = "Audio Accessory (Earphones)", CreatedBy = 1, CreatedOn = DateTime.UtcNow },
                new ItemType { Id = 10, Name = "Miscellaneous Asset", CreatedBy = 1, CreatedOn = DateTime.UtcNow }
            );

            builder.Entity<Fields>().HasData(
                // Mobile Device Forensic Data
                new Fields { Id = 1, ItemTypeId = 1, FieldName = "Manufacturer Brand", CreatedBy = 1 },
                new Fields { Id = 2, ItemTypeId = 1, FieldName = "Hardware Model", CreatedBy = 1 },
                new Fields { Id = 3, ItemTypeId = 1, FieldName = "Exterior Color", CreatedBy = 1 },
                new Fields { Id = 4, ItemTypeId = 1, FieldName = "IMEI indexing (Last 4)", CreatedBy = 1 },
                new Fields { Id = 5, ItemTypeId = 1, FieldName = "Physical Condition", CreatedBy = 1 },
                new Fields { Id = 6, ItemTypeId = 1, FieldName = "Screen Status (Locked)", CreatedBy = 1 },

                // Personal Wallet Forensic Data
                new Fields { Id = 10, ItemTypeId = 2, FieldName = "Primary Color", CreatedBy = 1 },
                new Fields { Id = 11, ItemTypeId = 2, FieldName = "Material Construction", CreatedBy = 1 },    
                new Fields { Id = 12, ItemTypeId = 2, FieldName = "Personal ID Inclusion", CreatedBy = 1 },
                new Fields { Id = 13, ItemTypeId = 2, FieldName = "Currency Content Audit", CreatedBy = 1 },

                // Laptop Hardware Forensic Data
                new Fields { Id = 20, ItemTypeId = 3, FieldName = "OEM Brand", CreatedBy = 1 },
                new Fields { Id = 21, ItemTypeId = 3, FieldName = "Display Specification", CreatedBy = 1 },
                new Fields { Id = 22, ItemTypeId = 3, FieldName = "Chassis Color", CreatedBy = 1 },
                new Fields { Id = 23, ItemTypeId = 3, FieldName = "Visual Customizations (Stickers)", CreatedBy = 1 },
                new Fields { Id = 24, ItemTypeId = 3, FieldName = "OS Security State", CreatedBy = 1 },

                // Personal Bag / Luggage
                new Fields { Id = 30, ItemTypeId = 5, FieldName = "Bag Type (Backpack/Handbag)", CreatedBy = 1 },
                new Fields { Id = 31, ItemTypeId = 5, FieldName = "Brand Name", CreatedBy = 1 },
                new Fields { Id = 32, ItemTypeId = 5, FieldName = "Main Color", CreatedBy = 1 },

                // Timepiece (Watch)
                new Fields { Id = 40, ItemTypeId = 6, FieldName = "Watch Brand", CreatedBy = 1 },
                new Fields { Id = 41, ItemTypeId = 6, FieldName = "Strap Material (Leather/Metal)", CreatedBy = 1 },
                new Fields { Id = 42, ItemTypeId = 6, FieldName = "Dial Color", CreatedBy = 1 },

                // Audio Accessory
                new Fields { Id = 50, ItemTypeId = 9, FieldName = "Accessory Brand", CreatedBy = 1 },
                new Fields { Id = 51, ItemTypeId = 9, FieldName = "Connection Type (Wired/BT)", CreatedBy = 1 },
                new Fields { Id = 52, ItemTypeId = 9, FieldName = "Case Color", CreatedBy = 1 },

                // Academic/Personal Documentation
                new Fields { Id = 60, ItemTypeId = 7, FieldName = "Document Classification", CreatedBy = 1 }, 
                new Fields { Id = 61, ItemTypeId = 7, FieldName = "Legal Name on Document", CreatedBy = 1 },
                new Fields { Id = 62, ItemTypeId = 7, FieldName = "Document Identifier (Partial)", CreatedBy = 1 }
            );
        }

        public static void SeedMobileModels(ModelBuilder builder)
        {
            var companies = new List<MobileCompany>
            {
                new MobileCompany { Id = 1,  Name = "Samsung", CreatedBy = 1 },
                new MobileCompany { Id = 2,  Name = "Apple",   CreatedBy = 1 },
                new MobileCompany { Id = 3,  Name = "Oppo",    CreatedBy = 1 },
                new MobileCompany { Id = 4,  Name = "Xiaomi / Redmi",   CreatedBy = 1 },
                new MobileCompany { Id = 5,  Name = "Infinix", CreatedBy = 1 },
                new MobileCompany { Id = 6,  Name = "Realme",  CreatedBy = 1 },
                new MobileCompany { Id = 7,  Name = "Vivo",    CreatedBy = 1 },
                new MobileCompany { Id = 9,  Name = "Google",  CreatedBy = 1 }
            };

            builder.Entity<MobileCompany>().HasData(companies);

            var models = new List<MobileModel>();
            long modelId = 1;

            var companyModels = new Dictionary<long, List<string>>
            {
                { 1, new List<string> { "S24 Ultra", "S23 Ultra", "A54", "A14", "Grand Prime+" } },
                { 2, new List<string> { "iPhone 15 Pro", "iPhone 14 Pro", "iPhone 13", "iPhone 12", "iPhone 11", "iPhone X" } },
                { 3, new List<string> { "Reno 11", "A78", "F21 Pro" } },
                { 4, new List<string> { "Note 13 Pro", "Note 12", "Redmi 12C" } },
                { 5, new List<string> { "Note 40 Pro", "Hot 40i", "Smart 8" } },
                { 9, new List<string> { "Pixel 8 Pro", "Pixel 7a", "Pixel 6" } }
            };

            foreach (var kvp in companyModels)
            {
                foreach (var modelName in kvp.Value)
                {
                    models.Add(new MobileModel { Id = modelId++, Name = modelName, MobileCompanyId = kvp.Key, CreatedBy = 1 });
                }
            }

            builder.Entity<MobileModel>().HasData(models);
        }

        private static void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            // SECURITY HARDRESET: Default password is now sourced from environment for protection.
            // If the environment variable GAC_ADMIN_PASSWORD is not set, a placeholder is used.
            // WARNING: Do not use the placeholder in a production environment.
            string envPassword = Environment.GetEnvironmentVariable("GAC_ADMIN_PASSWORD") ?? "SecureAdmin@GAC2026!";

            var adminUser = new ApplicationUser
            {
                Id = 1,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gac-system.com",
                NormalizedEmail = "ADMIN@GAC-SYSTEM.COM",
                EmailConfirmed = true,
                FirstName = "System",
                LastName = "Administrator",
                IsActive = true,
                SecurityStamp = "GAC-VERIFIED-AUTH-STAMP",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            adminUser.PasswordHash = hasher.HashPassword(adminUser, envPassword);

            builder.Entity<ApplicationUser>().HasData(adminUser);
        }

        private static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                });
        }
    }
}