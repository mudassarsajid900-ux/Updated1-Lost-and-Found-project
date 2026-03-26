using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GAC.Application.Interfaces.Shared;
using GAC.Core.Entities.Auction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GAC.Application.Services.Auction
{
    public class AuctionBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<AuctionBackgroundService> _logger;

        public AuctionBackgroundService(IServiceProvider serviceProvider, ILogger<AuctionBackgroundService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Auction Background Service is starting.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await ProcessExpiredAuctionsAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred executing process in AuctionBackgroundService.");
                }

                // Check every 1 minute
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }

        private async Task ProcessExpiredAuctionsAsync()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var auctionRepo = scope.ServiceProvider.GetRequiredService<IGenericRepository<AuctionRecord>>();

                var now = DateTime.UtcNow;

                var expiredAuctions = await auctionRepo.AsQueryable()
                    .Where(a => a.IsActive && now >= a.EndDate)
                    .ToListAsync();

                if (expiredAuctions.Any())
                {
                    _logger.LogInformation($"Found {expiredAuctions.Count} expired auctions to close automatically.");
                    foreach (var auction in expiredAuctions)
                    {
                        auction.IsActive = false;
                        await auctionRepo.UpdateAsync(auction);
                        _logger.LogInformation($"Closed Auction ID: {auction.Id}");
                    }
                }
            }
        }
    }
}
