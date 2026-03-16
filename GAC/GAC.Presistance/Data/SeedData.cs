using GAC.Core.Entities.Identity;
using GAC.Core.Entities.ItemTypes;
using GAC.Core.Entities.Locations;
using GAC.Core.Entities.SystemSettings;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GAC.Infrastructure.Data
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedRoles(builder);
            //SeedMenus(builder);
            //SeedRoleMenus(builder);
            SeedUsers(builder);
            SeedUserRoles(builder);
            SeedLocations(builder);
            SeedItemTypes(builder);
            SeedMobileModels(builder);
            SeedSystemSettings(builder);
        }

        private static void SeedSystemSettings(ModelBuilder builder)
        {
            builder.Entity<SystemSetting>().HasData(
                new SystemSetting
                {
                    Id = 1,
                    SettingKey = "ReplacementThresholdDays",
                    SettingValue = "90",
                    Description = "Number of days a lost item remains missing before replacement eligibility opens.",
                    CreatedBy = 1,
                    CreatedOn = DateTime.UtcNow
                }
            );
        }

        public static List<Location> GetSeededLocations()
        {
            var locations = new List<Location>();

            // LT1 – LT13
            locations.AddRange(
                Enumerable.Range(1, 13).Select(i => new Location
                {
                    Id = i,
                    Name = $"LT{i}",
                    Description = $"LT {i}",
                    CreatedBy = 1
                })
            );

            // LAB-1 – LAB-12 (starting from Id 14)
            locations.AddRange(
                Enumerable.Range(1, 12).Select(i => new Location
                {
                    Id = 13 + i,
                    Name = $"LAB-{i}",
                    Description = $"Lab {i}",
                    CreatedBy = 1
                })
            );

            // Fixed locations
            locations.AddRange(new[]
            {
                new Location { Id = 26, Name = "Parking",          Description = "Parking Area",            CreatedBy = 1 },
                new Location { Id = 27, Name = "Corridor Ground",  Description = "Ground Floor Corridor",  CreatedBy = 1 },
                new Location { Id = 28, Name = "Corridor First",   Description = "First Floor Corridor",   CreatedBy = 1 },
                new Location { Id = 29, Name = "Corridor Second",  Description = "Second Floor Corridor",  CreatedBy = 1 },
                new Location { Id = 30, Name = "Corridor Third",   Description = "Third Floor Corridor",   CreatedBy = 1 },
                new Location { Id = 31, Name = "Stairs Ground",    Description = "Stairs – Ground Floor",    CreatedBy = 1 },
                new Location { Id = 32, Name = "Stairs First",     Description = "Stairs – First Floor",     CreatedBy = 1 },
                new Location { Id = 33, Name = "Stairs Second",    Description = "Stairs – Second Floor",    CreatedBy = 1 },
                new Location { Id = 34, Name = "Stairs Third",     Description = "Stairs – Third Floor",     CreatedBy = 1 },
            });
            
            return locations;
        }

        public static void SeedLocations(ModelBuilder builder)
        {
            var locations = GetSeededLocations();
            builder.Entity<Location>().HasData(locations);
        }


        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "Full system access",
                    ConcurrencyStamp = "STATIC-ROLE-2026"
                },
                new ApplicationRole
                {
                    Id = 2,
                    Name = "User",
                    NormalizedName = "USER",
                    Description = "User Portal Access",
                    ConcurrencyStamp = "STATIC-ROLE-2026"
                });
        }
        public static void SeedItemTypes(ModelBuilder builder)
        {
            builder.Entity<ItemType>().HasData(
         new ItemType { Id = 1, Name = "Mobile Phone", CreatedBy = 1 },
         new ItemType { Id = 2, Name = "Wallet", CreatedBy = 1 },
         new ItemType { Id = 3, Name = "Laptop", CreatedBy = 1 },
         new ItemType { Id = 4, Name = "Keys", CreatedBy = 1 },
         new ItemType { Id = 5, Name = "Bag / Backpack", CreatedBy = 1 },
         new ItemType { Id = 6, Name = "Watch", CreatedBy = 1 },
         new ItemType { Id = 7, Name = "Passport / ID Card", CreatedBy = 1 },
         new ItemType { Id = 8, Name = "Jewelry", CreatedBy = 1 },
         new ItemType { Id = 9, Name = "Earphones / Headphones", CreatedBy = 1 },
         new ItemType { Id = 10, Name = "Other", CreatedBy = 1 }
     );

            builder.Entity<Fields>().HasData(

                // Mobile Phone
                new Fields { Id = 1, ItemTypeId = 1, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 2, ItemTypeId = 1, FieldName = "Model", CreatedBy = 1 },
                new Fields { Id = 3, ItemTypeId = 1, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 4, ItemTypeId = 1, FieldName = "IMEI (last 4 digits)", CreatedBy = 1 },
                new Fields { Id = 5, ItemTypeId = 1, FieldName = "Has Case", CreatedBy = 1 },

                // Wallet
                new Fields { Id = 10, ItemTypeId = 2, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 11, ItemTypeId = 2, FieldName = "Material", CreatedBy = 1 },    
                new Fields { Id = 12, ItemTypeId = 2, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 13, ItemTypeId = 2, FieldName = "Contains Cards/ID", CreatedBy = 1 },

                // Laptop
                new Fields { Id = 20, ItemTypeId = 3, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 21, ItemTypeId = 3, FieldName = "Model", CreatedBy = 1 },
                new Fields { Id = 22, ItemTypeId = 3, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 23, ItemTypeId = 3, FieldName = "Screen Size", CreatedBy = 1 },
                new Fields { Id = 24, ItemTypeId = 3, FieldName = "Has Sticker(s)", CreatedBy = 1 },

                // Keys
                new Fields { Id = 30, ItemTypeId = 4, FieldName = "Number of Keys", CreatedBy = 1 },
                new Fields { Id = 31, ItemTypeId = 4, FieldName = "Key Type", CreatedBy = 1 },      
                new Fields { Id = 32, ItemTypeId = 4, FieldName = "Has Keychain", CreatedBy = 1 },
                new Fields { Id = 33, ItemTypeId = 4, FieldName = "Color of Keychain", CreatedBy = 1 },

                // Bag / Backpack
                new Fields { Id = 40, ItemTypeId = 5, FieldName = "Type", CreatedBy = 1 },  
                new Fields { Id = 41, ItemTypeId = 5, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 42, ItemTypeId = 5, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 43, ItemTypeId = 5, FieldName = "Has Logo", CreatedBy = 1 },

                // Watch
                new Fields { Id = 50, ItemTypeId = 6, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 51, ItemTypeId = 6, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 52, ItemTypeId = 6, FieldName = "Strap Material", CreatedBy = 1 },
                new Fields { Id = 53, ItemTypeId = 6, FieldName = "Has Date Display", CreatedBy = 1 },

                // Passport / ID Card
                new Fields { Id = 60, ItemTypeId = 7, FieldName = "Document Type", CreatedBy = 1 }, 
                new Fields { Id = 61, ItemTypeId = 7, FieldName = "Issuing Country", CreatedBy = 1 },
                new Fields { Id = 62, ItemTypeId = 7, FieldName = "Color of Cover", CreatedBy = 1 },

                // Jewelry
                new Fields { Id = 70, ItemTypeId = 8, FieldName = "Type", CreatedBy = 1 },         
                new Fields { Id = 71, ItemTypeId = 8, FieldName = "Material", CreatedBy = 1 },     
                new Fields { Id = 72, ItemTypeId = 8, FieldName = "Color", CreatedBy = 1 },

                // Earphones / Headphones
                new Fields { Id = 80, ItemTypeId = 9, FieldName = "Brand", CreatedBy = 1 },
                new Fields { Id = 81, ItemTypeId = 9, FieldName = "Type", CreatedBy = 1 },         
                new Fields { Id = 82, ItemTypeId = 9, FieldName = "Color", CreatedBy = 1 },
                new Fields { Id = 83, ItemTypeId = 9, FieldName = "Has Case", CreatedBy = 1 },

                // Other (very generic fields)
                new Fields { Id = 90, ItemTypeId = 10, FieldName = "Main Color", CreatedBy = 1 },
                new Fields { Id = 91, ItemTypeId = 10, FieldName = "Secondary Color", CreatedBy = 1 },
                new Fields { Id = 92, ItemTypeId = 10, FieldName = "Size / Dimensions", CreatedBy = 1 },
                new Fields { Id = 93, ItemTypeId = 10, FieldName = "Brand / Logo", CreatedBy = 1 }
            );
        }

        public static void SeedMobileModels(ModelBuilder builder)
        {
            var companies = new List<MobileCompany>
            {
                new MobileCompany { Id = 1,  Name = "Samsung", CreatedBy = 1 },
                new MobileCompany { Id = 2,  Name = "Apple",   CreatedBy = 1 },
                new MobileCompany { Id = 3,  Name = "Oppo",    CreatedBy = 1 },
                new MobileCompany { Id = 4,  Name = "Redmi",   CreatedBy = 1 },
                new MobileCompany { Id = 5,  Name = "Infinix", CreatedBy = 1 },
                new MobileCompany { Id = 6,  Name = "Realme",  CreatedBy = 1 },
                new MobileCompany { Id = 7,  Name = "Vivo",    CreatedBy = 1 },
                new MobileCompany { Id = 8,  Name = "Xiaomi",  CreatedBy = 1 },
                new MobileCompany { Id = 9,  Name = "Google",  CreatedBy = 1 },
                new MobileCompany { Id = 10, Name = "OnePlus", CreatedBy = 1 },
                new MobileCompany { Id = 11, Name = "Tecno",   CreatedBy = 1 },
                new MobileCompany { Id = 12, Name = "Huawei",  CreatedBy = 1 },
                new MobileCompany { Id = 13, Name = "Itel",    CreatedBy = 1 },
                new MobileCompany { Id = 14, Name = "Sparx",   CreatedBy = 1 },
                new MobileCompany { Id = 15, Name = "VgoTel",  CreatedBy = 1 },
                new MobileCompany { Id = 16, Name = "Nokia",   CreatedBy = 1 }
            };

            builder.Entity<MobileCompany>().HasData(companies);

            var models = new List<MobileModel>();
            long modelId = 1;

            var companyModels = new Dictionary<long, List<string>>
            {
                { 1, new List<string> { "S24 Ultra", "S23 Ultra", "S22 Ultra", "A54", "A34", "A24", "A14", "A05s", "A05", "A04", "M54", "M34", "M14", "Grand Prime Plus" } },
                { 2, new List<string> { "iPhone 15 Pro Max", "iPhone 15 Pro", "iPhone 14 Pro Max", "iPhone 14", "iPhone 13 Pro Max", "iPhone 13", "iPhone 12 Pro Max", "iPhone 12", "iPhone 11 Pro Max", "iPhone 11", "iPhone X", "iPhone 8 Plus", "iPhone 7 Plus" } },
                { 3, new List<string> { "Reno 11", "Reno 10", "A78", "A58", "A38", "A18", "A17", "A16", "F21 Pro", "F19 Pro" } },
                { 4, new List<string> { "Note 13 Pro", "Note 13", "Note 12", "Note 11", "Note 10", "13C", "12C", "10C", "A2+", "A3" } },
                { 5, new List<string> { "Note 40 Pro", "Note 30 Pro", "Note 30", "Note 12", "Hot 40 Pro", "Hot 40i", "Hot 30", "Hot 30i", "Hot 20", "Hot 12", "Smart 8", "Smart 7", "Smart 6" } },
                { 6, new List<string> { "12 Pro", "11 Pro", "C67", "C53", "C51", "C35", "C33", "Note 50" } },
                { 7, new List<string> { "V30", "V29", "V27e", "V23e", "Y100", "Y36", "Y27", "Y17s", "Y02s" } },
                { 8, new List<string> { "14 Pro", "13T", "12T", "Mi 11", "Poco X6 Pro", "Poco F5", "Poco X3 Pro", "Poco M3" } },
                { 9, new List<string> { "Pixel 8 Pro", "Pixel 7 Pro", "Pixel 6 Pro", "Pixel 6a", "Pixel 4 XL" } },
                { 10, new List<string> { "OnePlus 12", "OnePlus 11", "OnePlus 10 Pro", "Nord CE 3 Lite", "OnePlus 8T" } },
                { 11, new List<string> { "Phantom V Fold", "Camon 20", "Camon 19 Neo", "Spark 20 Pro", "Spark 10 Pro", "Spark 9", "Spark 8C", "Pova 5", "Pop 7" } },
                { 12, new List<string> { "Mate 60", "P60", "Nova 11", "Nova 9", "Y9a", "Y7p" } },
                { 13, new List<string> { "S23+", "P40", "A70", "A60", "Vision 5", "Vision 3" } },
                { 14, new List<string> { "Neo 7 Ultra", "Neo 7", "Note 20", "S9", "S3" } },
                { 15, new List<string> { "New 7", "New 5", "Note 24", "S12", "i850" } },
                { 16, new List<string> { "Nokia 3.4", "Nokia 2.4", "G20", "G10", "105 (Feature Phone)", "210 (Feature Phone)" } }
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

            var adminUser = new ApplicationUser
            {
                Id = 1,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Admin",
                IsActive = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            adminUser.PasswordHash = hasher.HashPassword(adminUser, "Admin@123");

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