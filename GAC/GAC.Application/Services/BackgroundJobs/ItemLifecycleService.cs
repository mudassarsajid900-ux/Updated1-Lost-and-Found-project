using GAC.Application.Interfaces.Shared;
using GAC.Core.Entities.Auction;
using GAC.Core.Entities.Item;
using GAC.Core.Entities.SystemSettings;
using GAC.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GAC.Application.Services.BackgroundJobs
{
    /// <summary>
    /// Background Service that runs automatically every 24 hours.
    /// It performs the following automated tasks:
    /// 
    /// 1. Found → Replacement:
    ///    If a Found item (Status = 1) has been unclaimed for more than
    ///    "ReplacementThresholdDays" (Admin-defined), its status is changed
    ///    to Replacement (Status = 2).
    ///
    /// 2. Replacement → Auction:
    ///    If a Replacement item (Status = 2) has stayed in the Replacement pool
    ///    for more than "AuctionThresholdDays" (Admin-defined) without being used,
    ///    its status is changed to Auction (Status = 3) and an AuctionRecord is
    ///    automatically created for it.
    /// </summary>
    public class ItemLifecycleService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ItemLifecycleService> _logger;

        // How often this background job runs (every 1 minute for responsive testing)
        private readonly TimeSpan _checkInterval = TimeSpan.FromMinutes(1);

        public ItemLifecycleService(
            IServiceProvider serviceProvider,
            ILogger<ItemLifecycleService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("ItemLifecycleService started. Will check items every {Hours} hours.", _checkInterval.TotalHours);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await ProcessItemLifecycleAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while processing item lifecycle.");
                }

                // Wait 24 hours before running again
                await Task.Delay(_checkInterval, stoppingToken);
            }
        }

        /// <summary>
        /// Main processing method that handles both transitions:
        /// Found → Replacement and Replacement → Auction
        /// </summary>
        private async Task ProcessItemLifecycleAsync()
        {
            // We need a new scope because BackgroundService is a Singleton,
            // but our repositories are Scoped services
            using var scope = _serviceProvider.CreateScope();

            var itemRepo = scope.ServiceProvider.GetRequiredService<IGenericRepository<Items>>();
            var settingsRepo = scope.ServiceProvider.GetRequiredService<IGenericRepository<SystemSetting>>();
            var auctionRepo = scope.ServiceProvider.GetRequiredService<IGenericRepository<AuctionRecord>>();

            // ============================================================
            // STEP 1: Read Admin-defined thresholds from SystemSettings
            // ============================================================
            var foundToReplacementDays = await GetSettingValueAsync(settingsRepo, "FoundToReplacementThreshold", 20);
            var replacementToAuctionDays = await GetSettingValueAsync(settingsRepo, "ReplacementToAuctionThreshold", 40);

            _logger.LogInformation(
                "Running lifecycle check. FoundToReplacement={FoundToReplacementDays} days, ReplacementToAuction={ReplacementToAuctionDays} days.",
                foundToReplacementDays, replacementToAuctionDays);

            // ============================================================
            // STEP 2: Found → Replacement
            // Find all Found items older than FoundToReplacementThreshold
            // ============================================================
            var replacementCutoff = DateTime.UtcNow.AddDays(-foundToReplacementDays);

            var foundItemsToMove = await itemRepo.AsQueryable()
                .Where(x => x.ReportType == ReportType.Found &&
                           x.Status == ItemStatus.Found &&
                           x.CreatedOn <= replacementCutoff)
                .ToListAsync();

            foreach (var item in foundItemsToMove)
            {
                item.Status = ItemStatus.Replacement;
                item.LastModifiedOn = DateTime.UtcNow;
                await itemRepo.UpdateAsync(item);
            }

            if (foundItemsToMove.Count > 0)
            {
                _logger.LogInformation(
                    "Moved {Count} unclaimed Found items to Replacement pool (older than {Days} days).",
                    foundItemsToMove.Count, foundToReplacementDays);
            }

            // ============================================================
            // STEP 3: Replacement → Auction
            // Find all Replacement items older than ReplacementToAuctionThreshold
            // ============================================================
            var auctionCutoff = DateTime.UtcNow.AddDays(-replacementToAuctionDays);

            var replacementItemsToAuction = await itemRepo.AsQueryable()
                .Where(x => x.ReportType == ReportType.Found &&
                           x.Status == ItemStatus.Replacement &&
                           x.LastModifiedOn <= auctionCutoff)
                .ToListAsync();

            foreach (var item in replacementItemsToAuction)
            {
                // Check if an AuctionRecord already exists for this item
                var existingAuction = await auctionRepo.AsQueryable()
                    .FirstOrDefaultAsync(a => a.FoundItemId == item.Id);

                if (existingAuction == null)
                {
                    // Auto-create an AuctionRecord
                    var auctionRecord = new AuctionRecord
                    {
                        FoundItemId = item.Id,
                        HighestBid = 0,
                        HighestBidderId = 0,
                        IsActive = true,
                        CreatedBy = item.CreatedBy,  // Use the original reporter
                        CreatedOn = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddDays(7) // Setting a default 7-day auction duration
                    };
                    await auctionRepo.AddAsync(auctionRecord);
                }

                // Update item status to Auction
                item.Status = ItemStatus.Auction;
                item.LastModifiedOn = DateTime.UtcNow;
                await itemRepo.UpdateAsync(item);
            }

            if (replacementItemsToAuction.Count > 0)
            {
                _logger.LogInformation(
                    "Moved {Count} unused Replacement items to Auction (older than {Days} days in Replacement pool).",
                    replacementItemsToAuction.Count, replacementToAuctionDays);
            }
        }

        /// <summary>
        /// Helper method to read a setting value from the SystemSettings table.
        /// Returns the default value if the setting does not exist.
        /// </summary>
        private async Task<int> GetSettingValueAsync(
            IGenericRepository<SystemSetting> settingsRepo,
            string key,
            int defaultValue)
        {
            var setting = await settingsRepo.AsQueryable()
                .OrderByDescending(x => x.CreatedOn)
                .FirstOrDefaultAsync(x => x.SettingKey == key);

            if (setting != null && int.TryParse(setting.SettingValue, out int value))
                return value;

            return defaultValue;
        }
    }
}
