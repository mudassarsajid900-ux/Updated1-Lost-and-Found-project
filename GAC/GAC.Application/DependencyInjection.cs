using GAC.Application.Interfaces.Auction;
using GAC.Application.Interfaces.ClaimRequests;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Item;
using GAC.Application.Interfaces.Locations;
using GAC.Application.Interfaces.Replacement;
using GAC.Application.Interfaces.Handover;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Auction;
using GAC.Application.Services.BackgroundJobs;
using GAC.Application.Services.ClaimRequests;
using GAC.Application.Services.Identity;
using GAC.Application.Services.Item;
using GAC.Application.Services.Locations;
using GAC.Application.Services.Logs;
using GAC.Application.Services.Replacement;
using GAC.Application.Services.Handover;
using Microsoft.Extensions.DependencyInjection;

namespace GAC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRolesService, RolesService>();
            services.AddScoped<IUserManagementService, UserManagementService>();
            services.AddScoped<IExceptionLogService, LogService>();
            services.AddScoped<IErrorLogsService, ErrorLogsService>();
            services.AddScoped<IJwtTokenService, JwtTokenService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IItemTypeService, ItemTypeService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IClaimService, ClaimService>();
            services.AddScoped<IAuctionService, AuctionService>();
            services.AddScoped<IReplacementService, ReplacementService>();
            services.AddScoped<IMobileModelService, MobileModelService>();
            services.AddScoped<IHandoverService, HandoverService>();

            // Background Service: Automatically moves items through the lifecycle
            // Found → Replacement → Auction based on Admin-defined thresholds
            services.AddHostedService<ItemLifecycleService>();

            return services;
        }
    }
}
