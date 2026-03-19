using Microsoft.EntityFrameworkCore;

namespace GAC.API.Extensions
{
    public static class MiddlewareConfigurationExtensions
    {
        public static async Task<WebApplication> UseApiPipeline(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "GAC API V1");
                    options.RoutePrefix = "swagger";
                });
            }

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<Presistance.Data.ApplicationDbContext>();
                    context.Database.Migrate(); // Ensure DB is created and all migrations are applied
                    if (!context.Locations.Any())
                    {
                        Console.WriteLine("Seeding Locations...");
                        var locations = Infrastructure.Data.SeedData.GetSeededLocations();
                        foreach (var loc in locations)
                        {
                            loc.Id = 0; // Clear ID to let DB generate it at runtime
                        }
                        context.Locations.AddRange(locations);
                        context.SaveChanges();
                        Console.WriteLine("Locations seeded successfully.");
                    }

                    // ✅ FIXED: Ensure IsDeleted data is correctly initialized to false (not NULL) for all tables
                    // (prevents rows from 'disappearing' on refresh if they were NULL due to old data)
                    await context.Database.ExecuteSqlRawAsync("IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Items' AND COLUMN_NAME = 'IsDeleted') UPDATE [Items] SET [IsDeleted] = 0 WHERE [IsDeleted] IS NULL");
                    await context.Database.ExecuteSqlRawAsync("IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ItemMatches' AND COLUMN_NAME = 'IsDeleted') UPDATE [ItemMatches] SET [IsDeleted] = 0 WHERE [IsDeleted] IS NULL");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during seeding: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    }
                }
            }

            app.UseCors("AllowAll");

            if (!app.Environment.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.MapControllers();

            return app;
        }
    }
}
