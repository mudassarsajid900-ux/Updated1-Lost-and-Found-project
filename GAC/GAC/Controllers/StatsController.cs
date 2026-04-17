/**
 * @file StatsController.cs
 * @description Dashboard Intelligence Hub.
 * Aggregates real-time metrics and activity streams from multiple domain services
 * (Items, Auctions, Replacements, Users) to provide a unified administrative 10,000ft view.
 */
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Auction;
using GAC.Application.Interfaces.Replacement;
using GAC.Common.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GAC.Common.Constants;

namespace GAC.API.Controllers
{
    [Authorize]
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
        /// Synthesizes high-level system metrics and recent audit trails.
        /// Returns counts for users, reports, and active matches, plus a sorted 
        /// activity stream for the dashboard feed.
        /// </summary>
        [HttpGet("dashboard")]
        public async Task<IActionResult> GetDashboardStats()
        {
            try 
            {
                // Parallel-like fetch of system state from dedicated domain services
                var (users, totalUsers) = await _userService.GetUsersAsync(new DataTableRequest 
                { 
                    Start = 0, 
                    Length = 1,
                    Order = new List<Order> { new Order { Column = 0, Dir = "asc" } },
                    Columns = new List<Column> { new Column { Data = "Id" } }
                });
                var allItems = await _itemService.GetAllAsync();
                var activeAuctions = await _auctionService.GetAllActiveAuctionsAsync();
                var pendingReplacements = await _replacementService.GetAllPendingRequestsAsync();

                // Build a unified Activity Stream (Chronological Audit Trail)
                var activities = new List<object>
                {
                    new { user = "System", action = "Stats refreshed successfully", time = "Just now", type = "system", role = ApplicationConstants.AdministratorRole }
                };

                // Stream Layer 1: Item Reports (Lost/Found)
                if (allItems.IsSucceeded && allItems.Data?.Items != null)
                {
                    foreach (var item in allItems.Data.Items.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        var timeSpan = DateTime.UtcNow - item.CreatedOn;
                        string timeStr = CalculateTimeAgo(timeSpan);

                        activities.Add(new {
                            user = string.IsNullOrEmpty(item.ReporterName) ? "A user" : item.ReporterName,
                            action = $"reported a {item.ReportType.ToString().ToLower()} {item.Type}",
                            time = timeStr,
                            type = item.ReportType.ToString().ToLower(),
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                // Stream Layer 2: Replacement Requests
                if (pendingReplacements.IsSucceeded && pendingReplacements.Data != null)
                {
                    foreach (var rep in pendingReplacements.Data.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        var timeSpan = DateTime.UtcNow - rep.CreatedOn;
                        string timeStr = CalculateTimeAgo(timeSpan);

                        activities.Add(new {
                            user = rep.ReporterName ?? "Student",
                            action = $"requested replacement for {rep.LostItemTitle}",
                            time = timeStr,
                            type = "replacement",
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                // Stream Layer 3: Auction Starts
                if (activeAuctions.IsSucceeded && activeAuctions.Data != null)
                {
                    foreach (var auc in activeAuctions.Data.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        activities.Add(new {
                            user = "System",
                            action = $"launched Auction for {auc.ItemTitle}",
                            time = "Live",
                            type = "auction",
                            role = ApplicationConstants.AdministratorRole
                        });
                    }
                }

                return Ok(new
                {
                    totalUsers = totalUsers,
                    pendingReports = allItems.Data?.FoundCount ?? 0,
                    pendingMatches = allItems.Data?.MatchCount ?? 0,
                    activeAuctions = activeAuctions.Data?.Count ?? 0,
                    pendingReplacements = pendingReplacements.Data?.Count ?? 0,
                    recentActivities = activities.OrderByDescending(x => 
                        x.GetType().GetProperty("time")?.GetValue(x)?.ToString() == "Just now" ? 0 : 
                        x.GetType().GetProperty("time")?.GetValue(x)?.ToString() == "Live" ? 1 : 2).Take(10)
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "StatsController.GetDashboardStats failed.");
                return StatusCode(500, new { error = "Failed to load dashboard statistics. Please try again.", totalUsers = 0, pendingReports = 0, activeAuctions = 0, pendingReplacements = 0 });
            }
        }

        private string CalculateTimeAgo(TimeSpan timeSpan)
        {
            if (timeSpan.TotalMinutes < 1) return "Just now";
            if (timeSpan.TotalMinutes < 60) return $"{(int)timeSpan.TotalMinutes} mins ago";
            if (timeSpan.TotalHours < 24) return $"{(int)timeSpan.TotalHours} hours ago";
            return $"{(int)timeSpan.TotalDays} days ago";
        }
    }
}
