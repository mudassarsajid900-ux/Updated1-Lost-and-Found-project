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

        public StatsController(
            IItemService itemService, 
            IUserManagementService userService,
            IAuctionService auctionService,
            IReplacementService replacementService)
        {
            _itemService = itemService;
            _userService = userService;
            _auctionService = auctionService;
            _replacementService = replacementService;
        }

        [HttpGet("dashboard")]
        public async Task<IActionResult> GetDashboardStats()
        {
            try 
            {
                // Fetch real data from services
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

                var activities = new List<object>
                {
                    new { user = "System", action = "Stats refreshed successfully", time = "Just now", type = "system", role = ApplicationConstants.AdministratorRole }
                };

                if (allItems.IsSucceeded && allItems.Data?.Items != null)
                {
                    foreach (var item in allItems.Data.Items.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        var timeSpan = DateTime.UtcNow - item.CreatedOn;
                        string timeStr = timeSpan.TotalMinutes < 1 ? "Just now" :
                                         timeSpan.TotalMinutes < 60 ? $"{(int)timeSpan.TotalMinutes} mins ago" :
                                         timeSpan.TotalHours < 24 ? $"{(int)timeSpan.TotalHours} hours ago" :
                                         $"{(int)timeSpan.TotalDays} days ago";

                        activities.Add(new {
                            user = string.IsNullOrEmpty(item.ReporterName) ? "A user" : item.ReporterName,
                            action = $"reported a {item.ReportType.ToString().ToLower()} {item.Type}",
                            time = timeStr,
                            type = item.ReportType.ToString().ToLower(),
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                if (pendingReplacements.IsSucceeded && pendingReplacements.Data != null)
                {
                    foreach (var rep in pendingReplacements.Data.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        var timeSpan = DateTime.UtcNow - rep.CreatedOn;
                        string timeStr = timeSpan.TotalMinutes < 1 ? "Just now" :
                                         timeSpan.TotalMinutes < 60 ? $"{(int)timeSpan.TotalMinutes} mins ago" :
                                         timeSpan.TotalHours < 24 ? $"{(int)timeSpan.TotalHours} hours ago" :
                                         $"{(int)timeSpan.TotalDays} days ago";

                        activities.Add(new {
                            user = rep.ReporterName ?? "Student",
                            action = $"requested replacement for {rep.LostItemTitle}",
                            time = timeStr,
                            type = "replacement",
                            role = ApplicationConstants.UserRole
                        });
                    }
                }

                if (activeAuctions.IsSucceeded && activeAuctions.Data != null)
                {
                    foreach (var auc in activeAuctions.Data.OrderByDescending(x => x.CreatedOn).Take(5))
                    {
                        var timeStr = "Live";
                        activities.Add(new {
                            user = "System",
                            action = $"launched Auction for {auc.ItemTitle}",
                            time = timeStr,
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
                    recentActivities = activities.OrderByDescending(x => x.GetType().GetProperty("time")?.GetValue(x)?.ToString() == "Just now" ? 0 : 1).Take(10)
                });
            }
            catch (Exception ex)
            {
                // Return a safe default if some service fails during startup/audit
                return Ok(new { totalUsers = 0, pendingReports = 0, activeAuctions = 0, pendingReplacements = 0 });
            }
        }
    }
}
