using GAC.Core.Entities;
using GAC.Core.Entities.Auction;
using GAC.Core.Entities.Claims;
using GAC.Core.Entities.ExceptionLogs;
using GAC.Core.Entities.Identity;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.ItemTypes;
using GAC.Core.Entities.Locations;
using GAC.Core.Entities.LostItems;
using GAC.Core.Entities.Replacement;
using GAC.Core.Entities.SystemSettings;
using GAC.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Linq.Expressions;

namespace GAC.Presistance.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser, ApplicationRole, int,
        IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //public DbSet<Menu> Menus => Set<Menu>();
        //public DbSet<RoleMenu> RoleMenus => Set<RoleMenu>();
        public DbSet<AuditLogs> AuditLogs => Set<AuditLogs>();
        public DbSet<ExceptionLogs> ExceptionLogs => Set<ExceptionLogs>();
        //public DbSet<RoleMenuPermission> RoleMenuPermission => Set<RoleMenuPermission>();
        public DbSet<ItemType> ItemTypes => Set<ItemType>();
        public DbSet<Items> Items => Set<Items>();
        public DbSet<ItemMatch> ItemMatches => Set<ItemMatch>();
        public DbSet<ItemAttribute> ItemAttributes => Set<ItemAttribute>();
        public DbSet<ItemsHandOverRecord> ItemsHandOverRecords => Set<ItemsHandOverRecord>();
        public DbSet<Location> Locations => Set<Location>();    
        public DbSet<ReplacementRecord> ReplacementRecords => Set<ReplacementRecord>();
        public DbSet<SystemSetting> SystemSettings => Set<SystemSetting>();
        public DbSet<Bid> Bids => Set<Bid>();
        public DbSet<AuctionRecord> AuctionRecords => Set<AuctionRecord>();
        public DbSet<ClaimRequest> ClaimRequest => Set<ClaimRequest>();
        //public DbSet<Questions> Questions => Set<Questions>();
        public DbSet<MobileCompany> MobileCompanies => Set<MobileCompany>();
        public DbSet<MobileModel> MobileModels => Set<MobileModel>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Temporarily suppress the warning to allow migration creation
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var deletedCheck = Expression.Equal(
                        Expression.Property(parameter, nameof(BaseEntity.IsDeleted)),
                        Expression.Constant(false));

                    var lambda = Expression.Lambda(deletedCheck, parameter);
                    builder.Entity(entityType.ClrType).HasQueryFilter(lambda);

                    // Explicitly set Restrict for audit fields to avoid cycles/multiple cascade paths in SQL Server
                    builder.Entity(entityType.ClrType)
                        .HasOne(nameof(BaseEntity.CreatedByUser))
                        .WithMany()
                        .HasForeignKey(nameof(BaseEntity.CreatedBy))
                        .OnDelete(DeleteBehavior.Restrict);

                    builder.Entity(entityType.ClrType)
                        .HasOne(nameof(BaseEntity.ModifiedByUser))
                        .WithMany()
                        .HasForeignKey(nameof(BaseEntity.LastModifiedBy))
                        .OnDelete(DeleteBehavior.Restrict);

                    builder.Entity(entityType.ClrType)
                        .HasOne(nameof(BaseEntity.DeletedByUser))
                        .WithMany()
                        .HasForeignKey(nameof(BaseEntity.DeletedBy))
                        .OnDelete(DeleteBehavior.Restrict);
                }
            }

            // Relationship for ItemsHandOverRecord
            builder.Entity<ItemsHandOverRecord>()
                .HasOne(h => h.ClaimRequest)
                .WithMany()
                .HasForeignKey(h => h.ClaimRequestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AuctionRecord>()
        .HasOne(ar => ar.FoundItem)
        .WithOne()                          
        .HasForeignKey<AuctionRecord>(ar => ar.FoundItemId)
        .OnDelete(DeleteBehavior.Restrict); 

            // 2. AuctionRecord → HighestBidder
            builder.Entity<AuctionRecord>()
                .HasOne(ar => ar.HighestBidder)
                .WithMany()
                .HasForeignKey(ar => ar.HighestBidderId)
                .OnDelete(DeleteBehavior.Restrict);

            // 3. Bid → FoundItem (many bids per found item)
            builder.Entity<Bid>()
                .HasOne(b => b.FoundItem)
                .WithMany()
                .HasForeignKey(b => b.FoundItemId)
                .OnDelete(DeleteBehavior.Restrict);   

            // 4. Bid → Bidder (ApplicationUser)
            builder.Entity<Bid>()
                .HasOne(b => b.Bidder)
                .WithMany()
                .HasForeignKey(b => b.BidderId)
                .OnDelete(DeleteBehavior.Restrict);

            // 5. ClaimRequest → LostItem
            builder.Entity<ClaimRequest>()
                .HasOne(cr => cr.LostItem)
                .WithMany()
                .HasForeignKey(cr => cr.LostItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // 6. ClaimRequest → FoundItem
            builder.Entity<ClaimRequest>()
                .HasOne(cr => cr.FoundItem)
                .WithMany()
                .HasForeignKey(cr => cr.FoundItemId)
                .OnDelete(DeleteBehavior.Restrict);


            // 8. ReplacementRecord → FoundItem
            builder.Entity<ReplacementRecord>()
                .HasOne(rr => rr.FoundItem)
                .WithMany()
                .HasForeignKey(rr => rr.FoundItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // 9. ReplacementRecord → LostItem
            builder.Entity<ReplacementRecord>()
                .HasOne(rr => rr.LostItem)
                .WithMany()
                .HasForeignKey(rr => rr.LostItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // 10. LostItem → Location
            builder.Entity<Items>()
                .HasOne(li => li.Location)
                .WithMany()
                .HasForeignKey(li => li.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // 11. LostItem → ItemType
            builder.Entity<Items>()
                .HasOne(li => li.ItemType)
                .WithMany()
                .HasForeignKey(li => li.ItemTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // ItemMatch mappings
            builder.Entity<ItemMatch>()
                .HasOne(im => im.LostItem)
                .WithMany()
                .HasForeignKey(im => im.LostItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ItemMatch>()
                .HasOne(im => im.FoundItem)
                .WithMany()
                .HasForeignKey(im => im.FoundItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ItemMatch>()
                .HasOne(im => im.User)
                .WithMany()
                .HasForeignKey(im => im.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // 13. ItemAttribute → LostItem (many attributes per lost item)
            builder.Entity<ItemAttribute>()
                .HasOne(ia => ia.LostItem)
                .WithMany(li => li.Attributes)
                .HasForeignKey(ia => ia.LostItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // ───────────────────────────────────────────────
            // 14. Fields → ItemType  (corrected – this is the template fields per item type)
            // ───────────────────────────────────────────────
            builder.Entity<Fields>()
                .HasOne(f => f.ItemType)
                .WithMany(it => it.Fields)
                .HasForeignKey(f => f.ItemTypeId)
                .OnDelete(DeleteBehavior.Restrict);   // Changed from Cascade to Restrict to avoid SQL Server cycles

            // Optional but very useful: unique index on field name per item type
            builder.Entity<Fields>()
                .HasIndex(f => new { f.ItemTypeId, f.FieldName })
                .IsUnique()
                .HasDatabaseName("IX_Fields_ItemType_FieldName_Unique");

            builder.Entity<AuctionRecord>()
                .HasIndex(ar => ar.FoundItemId)
                .IsUnique();

            builder.Entity<MobileModel>()
                .HasOne(m => m.MobileCompany)
                .WithMany(c => c.Models)
                .HasForeignKey(m => m.MobileCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            SeedData.Seed(builder);
        }

    }
}