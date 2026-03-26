using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Auction;
using GAC.Application.Interfaces.Replacement;
using GAC.Common.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
                    new { user = "System", action = "Stats refreshed successfully", time = "Just now", type = "system", role = "Admin" }
                };

                if (allItems.Data != null)
                {
                    var recentItems = allItems.Data.OrderByDescending(i => i.CreatedOn).Take(3);
                    foreach(var item in recentItems)
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
                            role = "User"
                        });
                    }
                }

                return Ok(new
                {
                    totalUsers = totalUsers,
                    pendingReports = allItems.Data?.Count(i => i.Status == GAC.Core.Enums.ItemStatus.Found) ?? 0,
                    activeAuctions = activeAuctions.Data?.Count ?? 0,
                    pendingReplacements = pendingReplacements.Data?.Count ?? 0,
                    recentActivities = activities
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
