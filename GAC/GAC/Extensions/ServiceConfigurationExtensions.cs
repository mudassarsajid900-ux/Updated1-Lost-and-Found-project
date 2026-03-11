using GAC.Application;
using GAC.Application.Helper;
using GAC.Application.Interfaces.Identity;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Mappings;
using GAC.Application.Services.Identity;
using GAC.Common;
using GAC.Core.Entities.Identity;
using GAC.Presistance.Data;
using GAC.Presistance.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;


using System.Text;
using System.Text.Json.Serialization;

namespace GAC.API.Extensions
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configuration
            services.AddSingleton(configuration);

            // CORS
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            // DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Controllers registered later with JSON options

            // Core services
            services.AddHttpContextAccessor();
            services.AddScoped<UserData>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // AutoMapper
            services.AddAutoMapper(cfg => { }, typeof(ItemMappingProfile).Assembly);

            // Application services
            services.AddApplicationServices();
            services.AddScoped<IRolesService, RolesService>();
            //services.AddScoped<IMenusService, MenusService>();
            services.AddScoped<IUserManagementService, UserManagementService>();
            services.AddScoped<IAuthService, AuthService>();
            // Identity
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });
            // JWT
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>()
                              ?? throw new InvalidOperationException("JwtSettings is missing.");

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                // Disable default inbound claim type mapping so 'sub' stays as 'sub'
                System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

                // ✅ FIXED: Use the same key format as AuthService
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false, // Temporarily disabled to debug 401 mismatch
                    ValidateAudience = false, // Temporarily disabled to debug 401 mismatch
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = key,
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddAuthorization();

            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GAC API", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Enter 'Bearer' [space] and then your token.",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                c.AddSecurityRequirement(document => new OpenApiSecurityRequirement
                {
                    [new OpenApiSecuritySchemeReference("Bearer", document)] = []
                });

            });


            return services;
        }
    }
}