using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Auction;
using GAC.Application.Interfaces.Replacement;
using GAC.Common.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GAC.Common.Constants;
using Microsoft.Extensions.Logging;

namespace GAC.API.Controllers
{
    /// <summary>
    /// StatsController serves the Administrator Control Panel with real-time analytics.
    /// It aggregates data from multiple domain services to provide a high-level system healthy snapshot.
    /// </summary>
    [Authorize(Roles = "Admin")] // Dashboard metrics are restricted to Administrators
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IUserManagementService _userService;
        private readonly IAuctionService _auctionService;
        private readonly IReplacementService _replacementService;
        private readonly ILogger<StatsController> _logger;

        public StatsController(
            IItemService itemService, 
            IUserManagementService userService,
            IAuctionService auctionService,
            IReplacementService replacementService,
            ILogger<StatsController> logger)
        {
            _itemService = itemService;
            _userService = userService;
            _auctionService = auctionService;
            _replacementService = replacementService;
            _logger = logger;
        }

        /// <summary>
        /// Aggregates system-wide statistics and recent activity logs for the admin dashboard.
        /// Performs cross-service data fetching and formats it for the frontend 'Activity Feed'.
        /// </summary>
        [HttpGet("dashboard")]
        public async Task<IActionResult> GetDashboardStats()
        {
            try 
            {
                // 1. Cross-Domain Data Extraction
                var (_, totalUsers) = await _userService.GetUsersAsync(new DataTableRequest 
                { 
                    Start = 0, 
                    Length = 1,
                    Order = new List<Order> { new Order { Column = 0, Dir = "asc" } },
                    Columns = new List<Column> { new Column { Data = "Id" } }
                });

                var allItems = await _itemService.GetAllAsync();
                var activeAuctions = await _auctionService.GetAllActiveAuctionsAsync();
                var pendingReplacements = await _replacementService.GetAllPendingRequestsAsync();

                // 2. Activity Feed Synthesis
                var activities = new List<object>
                {
                    new { user = "System", action = "Diagnostic audit complete", time = "Just now", type = "system", role = ApplicationConstants.AdministratorRole }
                };

                // Inject Recent Reports into Feed
                if (allItems.IsSucceeded && allItems.Data?.Items != null)
                {
                    foreach (var item in allItems.Data.Items.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        activities.Add(new {
                            user = string.IsNullOrEmpty(item.ReporterName) ? "A user" : item.ReporterName,
                            action = $"reported a {item.ReportType.ToString().ToLower()} {item.Type}",
                            time = FormatTimeAgo(item.CreatedOn),
                            type = item.ReportType.ToString().ToLower(),
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                // Inject Recent Replacement Requests into Feed
                if (pendingReplacements.IsSucceeded && pendingReplacements.Data != null)
                {
                    foreach (var rep in pendingReplacements.Data.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        activities.Add(new {
                            user = rep.ReporterName ?? "Student",
                            action = $"requested replacement for {rep.LostItemTitle}",
                            time = FormatTimeAgo(rep.CreatedOn),
                            type = "replacement",
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                // 3. Payload Assembly
                var stats = new
                {
                    totalUsers = totalUsers,
                    pendingReports = allItems.Data?.FoundCount ?? 0,
                    pendingMatches = allItems.Data?.MatchCount ?? 0,
                    activeAuctions = activeAuctions.Data?.Count ?? 0,
                    pendingReplacements = pendingReplacements.Data?.Count ?? 0,
                    recentActivities = activities.Take(10) // Dashboard UI handles further sorting/rendering
                };

                return Ok(stats);
            }
            catch (Exception ex)
            {
                // ✅ FIXED: Log error and return failure instead of swallowing (returning fake zeros)
                _logger.LogError(ex, "Failed to retrieve dashboard statistics.");
                return StatusCode(500, new { message = "System statistics are temporarily unavailable." });
            }
        }

        /// <summary>
        /// Utility to convert timestamps into human-readable relative strings.
        /// </summary>
        private string FormatTimeAgo(DateTime dateTime)
        {
            var span = DateTime.UtcNow - dateTime;
            if (span.TotalMinutes < 1) return "Just now";
            if (span.TotalMinutes < 60) return $"{(int)span.TotalMinutes} mins ago";
            if (span.TotalHours < 24) return $"{(int)span.TotalHours} hours ago";
            return $"{(int)span.TotalDays} days ago";
        }
    }
}
