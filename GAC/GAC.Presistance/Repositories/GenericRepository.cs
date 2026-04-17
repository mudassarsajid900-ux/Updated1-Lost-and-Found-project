using GAC.Application.Helper;
using GAC.Application.Interfaces.Shared;
using GAC.Application.Services.Identity.Dtos.Shared;
using GAC.Common.Constants;
using GAC.Core.Entities;
using GAC.Core.Entities.ExceptionLogs;
using GAC.Core.Enums;
using GAC.Presistance.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;

namespace GAC.Presistance.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly UserData _userData;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IServiceProvider _serviceProvider;

        public GenericRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, UserData userData, IServiceProvider serviceProvider)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _httpContextAccessor = httpContextAccessor;
            _userData = userData;
            _serviceProvider = serviceProvider;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        private bool HasModelProperty(string propertyName)
        {
            var entityType = _context.Model.FindEntityType(typeof(TEntity));
            return entityType != null && entityType.FindProperty(propertyName) != null;
        }

        public async Task<TEntity?> GetByIdAsync(long id)
        {
            var entityType = _context.Model.FindEntityType(typeof(TEntity));
            var primaryKey = entityType?.FindPrimaryKey();
            if (primaryKey == null || !primaryKey.Properties.Any())
            {
                return await _dbSet.FindAsync(id);
            }

            var keyType = primaryKey.Properties[0].ClrType;
            if (keyType == typeof(int))
            {
                return await _dbSet.FindAsync((int)id);
            }
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> CountAsync() => await _dbSet.CountAsync();

        public async Task<TEntity> GetByDynamicColumnsAsync(
            Dictionary<string, object> columnFiltersEqual,
            Dictionary<string, object> columnFiltersContains,
            bool asNoTracking = false,
            bool asSplitQuery = false,
            bool checkIsActive = false,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (asNoTracking) query = query.AsNoTracking();
            if (asSplitQuery) query = query.AsSplitQuery();
            if (includeExpression != null) query = includeExpression(query);

            query = ApplyEqualFilters(query, columnFiltersEqual);
            query = ApplyContainsFilters(query, columnFiltersContains);

            if (checkIsActive && HasModelProperty(EntityFieldConstant.IsActive))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive));
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetByDynamicColumnNameAsync(
            string columnName, object id,
            bool asNoTracking = false, bool asSplitQuery = false, bool checkIsActive = false,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (asNoTracking) query = query.AsNoTracking();
            if (asSplitQuery) query = query.AsSplitQuery();
            if (includeExpression != null) query = includeExpression(query);

            query = query.Where(e => EF.Property<object>(e, columnName).Equals(id));

            if (checkIsActive && HasModelProperty(EntityFieldConstant.IsActive))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive));
            }

            return await query.ToListAsync();
        }

        private IQueryable<TEntity> ApplyEqualFilters(IQueryable<TEntity> query, Dictionary<string, object> filters)
        {
            if (filters == null || filters.Count == 0) return query;
            foreach (var filter in filters)
            {
                query = query.Where(e => EF.Property<object>(e, filter.Key).Equals(filter.Value));
            }
            return query;
        }

        private IQueryable<TEntity> ApplyContainsFilters(IQueryable<TEntity> query, Dictionary<string, object> filters)
        {
            if (filters == null || filters.Count == 0) return query;

            ParameterExpression parameter = Expression.Parameter(typeof(TEntity), "e");
            Expression? finalExpression = null;

            foreach (var filter in filters)
            {
                var property = Expression.Property(parameter, filter.Key);
                var constant = Expression.Constant(filter.Value.ToString(), typeof(string));
                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                
                if (containsMethod != null)
                {
                    var containsExpression = Expression.Call(property, containsMethod, constant);
                    finalExpression = finalExpression == null
                        ? containsExpression
                        : Expression.OrElse(finalExpression, containsExpression);
                }
            }

            if (finalExpression != null)
            {
                var lambda = Expression.Lambda<Func<TEntity, bool>>(finalExpression, parameter);
                query = query.Where(lambda);
            }
            return query;
        }

        // CRUD Operations with Audit Logging
        public async Task AddAsync(TEntity entity)
        {
            try
            {
                var userId = _userData?.UserId ?? 0;
                if (userId == 0) userId = 1; // System/Admin Fallback
                var now = DateTime.Now;

                // 1. ADD first so EF Core begins tracking the entire object graph
                await _dbSet.AddAsync(entity);

                // 2. Intercept and enrich all nested tracking entries
                foreach (var entry in _context.ChangeTracker.Entries<BaseEntity>())
                {
                    if (entry.State == EntityState.Added)
                    {
                        if (entry.Entity.CreatedBy == 0) entry.Entity.CreatedBy = userId;
                        entry.Entity.LastModifiedBy = userId;
                        if (entry.Entity.CreatedOn == default) entry.Entity.CreatedOn = now;
                        entry.Entity.LastModifiedOn = now;
                        entry.Entity.IsDeleted = false;
                        entry.Entity.IsActive = true; 
                    }
                }
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.CREATE, entity);
            }
            catch (Exception ex)
            {
                await LogError(ex, "AddAsync", entity);
                throw;
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            try
            {
                var currentUserId = _userData?.UserId ?? 0;
                if (currentUserId == 0) currentUserId = 1;
                var currentTime = DateTime.Now;

                // 1. UPDATE first so EF Core begins tracking the entire object graph
                _dbSet.Update(entity);

                // 2. Intercept and enrich all nested tracking entries
                foreach (var entry in _context.ChangeTracker.Entries<BaseEntity>())
                {
                    if (entry.State == EntityState.Added)
                    {
                        if (entry.Entity.CreatedBy == 0) entry.Entity.CreatedBy = currentUserId;
                        entry.Entity.LastModifiedBy = currentUserId;
                        if (entry.Entity.CreatedOn == default) entry.Entity.CreatedOn = currentTime;
                        entry.Entity.LastModifiedOn = currentTime;
                        entry.Entity.IsDeleted = false;
                        entry.Entity.IsActive = true;
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        entry.Entity.LastModifiedBy = currentUserId;
                        entry.Entity.LastModifiedOn = currentTime;
                        // Prevent accidental modification of CreatedBy/CreatedOn if omitted in DTO mapping
                        entry.Property(x => x.CreatedBy).IsModified = false;
                        entry.Property(x => x.CreatedOn).IsModified = false;
                    }
                }
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.UPDATE, entity);
            }
            catch (Exception ex)
            {
                await LogError(ex, "UpdateAsync", entity);
                throw;
            }
        }

        public async Task DeleteAsync(long id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                if (entity != null)
                {
                    if (entity is BaseEntity b)
                    {
                        // Optimization: Perform Soft Delete instead of hard delete
                        // to prevent Foreign Key constraint conflicts.
                        var userId = _userData?.UserId ?? 0;
                        b.IsDeleted = true;
                        b.IsActive = false;
                        b.DeletedOn = DateTime.Now;
                        b.DeletedBy = userId;
                        _dbSet.Update(entity);
                    }
                    else
                    {
                        _dbSet.Remove(entity);
                    }

                    await _context.SaveChangesAsync();

                    // Save audit log after successful save (separate transaction)
                    await SaveAuditLogs(EntityAction.DELETE, entity);
                }
            }
            catch (Exception ex)
            {
                await LogError(ex, "DeleteAsync", new { Id = id });
                throw;
            }
        }

        public async Task<bool> DeleteListAsync(List<TEntity> entities)
        {
            try
            {
                var userId = _userData?.UserId ?? 0;
                var now = DateTime.Now;

                foreach (var entity in entities)
                {
                    if (entity is BaseEntity b)
                    {
                        // Soft delete — consistent with DeleteAsync(long id)
                        b.IsDeleted = true;
                        b.IsActive = false;
                        b.DeletedOn = now;
                        b.DeletedBy = userId;
                        _dbSet.Update(entity);
                    }
                    else
                    {
                        _dbSet.Remove(entity);
                    }
                }

                var result = await _context.SaveChangesAsync() > 0;

                // Save audit log after successful save (separate transaction)
                if (result)
                {
                    await SaveAuditLogs(EntityAction.DELETE, entities);
                }
                return result;
            }
            catch (Exception ex)
            {
                await LogError(ex, "DeleteListAsync", entities);
                throw;
            }
        }

        // Batch Operations with Audit Logging
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                await _dbSet.AddRangeAsync(entities);
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.CREATE, entities);
            }
            catch (Exception ex)
            {
                await LogError(ex, "AddRangeAsync", entities);
                throw;
            }
        }

        public async Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                _dbSet.UpdateRange(entities);
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.UPDATE, entities);
            }
            catch (Exception ex)
            {
                await LogError(ex, "UpdateRangeAsync", entities);
                throw;
            }
        }

        public async Task RemoveAsync(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.DELETE, entity);
            }
            catch (Exception ex)
            {
                await LogError(ex, "RemoveAsync", entity);
                throw;
            }
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                _dbSet.RemoveRange(entities);
                await _context.SaveChangesAsync();

                // Save audit log after successful save (separate transaction)
                await SaveAuditLogs(EntityAction.DELETE, entities);
            }
            catch (Exception ex)
            {
                await LogError(ex, "RemoveRangeAsync", entities);
                throw;
            }
        }

        // Audit Logging Implementation
        private async Task SaveAuditLogs(EntityAction action, object data)
        {
            try
            {
                // Skip audit logging for AuditLogs and ExceptionLogs entities to prevent recursion
                if (typeof(TEntity) == typeof(AuditLogs) || typeof(TEntity) == typeof(ExceptionLogs))
                {
                    return;
                }

                string details = SerializeAuditData(data);
                var path = _httpContextAccessor.HttpContext?.Request?.Path.Value?.ToLower();
                var applicationName = path != null && path.Contains("/api/") ? "API" : "CMS";

                var auditLog = new AuditLogs
                {
                    Action = action.ToString(),
                    EntityName = typeof(TEntity).Name,
                    Details = details?.Length > 2000 ? details.Substring(0, 2000) : details,
                    UserId = GetCurrentUserIdAsInt(),
                    UserName = GetCurrentUserName()?.Length > 100 ? GetCurrentUserName().Substring(0, 100) : GetCurrentUserName(),
                    ApplicationName = applicationName?.Length > 100 ? applicationName.Substring(0, 100) : applicationName,
                    Timestamp = DateTime.Now
                };

                // Create a new scope and context for logging
                using (var scope = _serviceProvider.CreateScope())
                {
                    var scopedContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    await scopedContext.Set<AuditLogs>().AddAsync(auditLog);
                    await scopedContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log error but don't throw - audit logging should not break main operation
                Console.WriteLine($"Audit logging failed: {ex.Message}");
            }
        }

        private string SerializeAuditData(object data)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    MaxDepth = 3,
                    NullValueHandling = NullValueHandling.Ignore
                };

                if (data is IEnumerable<object> collection && !(data is string))
                {
                    var items = collection.ToList();
                    return JsonConvert.SerializeObject(new
                    {
                        Count = items.Count,
                        Items = items.Take(10) // Limit to first 10 items for performance
                    }, settings);
                }

                return JsonConvert.SerializeObject(data, settings);
            }
            catch
            {
                return $"{{\"EntityType\":\"{typeof(TEntity).Name}\",\"SerializationFailed\":true}}";
            }
        }

        // Error Logging Implementation
        private async Task LogError(Exception exception, string methodName, object data)
        {
            try
            {
                var exceptionLog = new ExceptionLogs
                {
                    LogLevel = GetExceptionSeverity(exception),
                    Message = exception.Message?.Length > 4000 ? exception.Message.Substring(0, 4000) : exception.Message,
                    Exception = exception.ToString()?.Length > 4000 ? exception.ToString().Substring(0, 4000) : exception.ToString(),
                    StackTrace = exception.StackTrace?.Length > 4000 ? exception.StackTrace.Substring(0, 4000) : exception.StackTrace,
                    RequestUrl = (_httpContextAccessor.HttpContext?.Request?.Path.Value)?.Length > 1000
                        ? _httpContextAccessor.HttpContext?.Request?.Path.Value.Substring(0, 1000)
                        : _httpContextAccessor.HttpContext?.Request?.Path.Value,
                    RequestMethod = _httpContextAccessor.HttpContext?.Request?.Method?.Length > 100
                        ? _httpContextAccessor.HttpContext?.Request?.Method.Substring(0, 100)
                        : _httpContextAccessor.HttpContext?.Request?.Method,
                    IPAddress = GetClientIpAddress()?.Length > 100 ? GetClientIpAddress().Substring(0, 100) : GetClientIpAddress(),
                    ApplicationName = ($"{typeof(TEntity).Name}.{methodName}")?.Length > 100
                        ? ($"{typeof(TEntity).Name}.{methodName}").Substring(0, 100)
                        : $"{typeof(TEntity).Name}.{methodName}",
                    UserId = GetCurrentUserIdAsInt(),
                    UserName = GetCurrentUserName()?.Length > 100 ? GetCurrentUserName().Substring(0, 100) : GetCurrentUserName(),
                    CreatedAt = DateTime.Now
                };

                // Create a new scope and context for logging
                using (var scope = _serviceProvider.CreateScope())
                {
                    var scopedContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    await scopedContext.Set<ExceptionLogs>().AddAsync(exceptionLog);
                    await scopedContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Last resort - log to console if database logging fails
                Console.WriteLine($"Error logging failed: {ex.Message}");
                Console.WriteLine($"Original error: {exception.Message}");
            }
        }

        private string GetExceptionSeverity(Exception exception)
        {
            var severity = exception switch
            {
                DbUpdateException => "Critical",
                ArgumentNullException => "Warning",
                InvalidOperationException => "Error",
                UnauthorizedAccessException => "Warning",
                _ => "Error"
            };
            return severity.Length > 100 ? severity.Substring(0, 100) : severity;
        }

        // Helper Methods
        private int GetCurrentUserIdAsInt()
        {
            if (_userData != null && _userData.UserId != 0)
            {
                return _userData.UserId;
            }

            var user = _httpContextAccessor.HttpContext?.User;
            var claim = user?.Claims?.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub);

            if (claim != null && int.TryParse(claim.Value, out var claimInt))
                return claimInt;

            return 0;
        }

        private string GetCurrentUserId()
        {
            if (_userData != null && _userData.UserId != 0)
                return _userData.UserId.ToString();

            var user = _httpContextAccessor.HttpContext?.User;
            var claim = user?.Claims?.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub);
            return claim?.Value ?? "System";
        }

        private string GetCurrentUserName()
        {
            if (!string.IsNullOrEmpty(_userData?.UserFullNameEn))
                return _userData.UserFullNameEn;

            var user = _httpContextAccessor.HttpContext?.User;
            var claim = user?.Claims?.FirstOrDefault(c => c.Type == "name");
            return claim?.Value ?? "Unknown";
        }

        private string GetClientIpAddress()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null) return "Unknown";

            var ipAddress = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(ipAddress))
            {
                ipAddress = context.Connection.RemoteIpAddress?.ToString();
            }
            return ipAddress ?? "Unknown";
        }

        private string GetUserAgent()
        {
            var context = _httpContextAccessor.HttpContext;
            return context?.Request.Headers["User-Agent"].FirstOrDefault() ?? "Unknown";
        }

        // Retrieval Operations
        public async Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking = false, bool includeInactive = false)
        {
            var query = asNoTracking ? _dbSet.AsNoTracking() : _dbSet;
            if (!includeInactive && HasModelProperty(EntityFieldConstant.IsActive))
            {
                query = query.Where(e => EF.Property<bool>(e, "IsActive"));
            }
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllDataAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            bool asNoTracking = false,
            bool includeInactive = false)
        {
            IQueryable<TEntity> query = _dbSet;
            if (asNoTracking) query = query.AsNoTracking();
            if (!includeInactive && HasModelProperty(EntityFieldConstant.IsActive))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive));
            }
            if (predicate != null) query = query.Where(predicate);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate) =>
            await _dbSet.Where(predicate).ToListAsync();

        public IQueryable<TEntity> AsQueryable()
        {
            IQueryable<TEntity> query = _dbSet;
            if (HasModelProperty(EntityFieldConstant.IsDeleted))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsDeleted) == false);
            }
            return query;
        }

        public IQueryable<TEntity> AsNoTracking()
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            if (HasModelProperty(EntityFieldConstant.IsDeleted))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsDeleted) == false);
            }
            return query;
        }

        public async Task<(IEnumerable<TEntity> Data, int TotalCount)> GetPagedAsync(
            int pageNumber, int pageSize,
            Expression<Func<TEntity, bool>> filter = null,
            string orderByColumn = null,
            bool isAscending = true,
            string includeProperties = "",
            bool checkIsActive = false)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null) query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (!string.IsNullOrEmpty(orderByColumn))
            {
                var parameter = Expression.Parameter(typeof(TEntity), "p");
                var property = Expression.Property(parameter, orderByColumn);
                var lambda = Expression.Lambda(property, parameter);
                var methodName = isAscending ? "OrderBy" : "OrderByDescending";
                query = (IOrderedQueryable<TEntity>)typeof(Queryable)
                    .GetMethods()
                    .First(m => m.Name == methodName && m.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(TEntity), property.Type)
                    .Invoke(null, new object[] { query, lambda })!;
            }

            if (checkIsActive && HasModelProperty(EntityFieldConstant.IsActive))
            {
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive) &&
                                        EF.Property<DateTime?>(e, EntityFieldConstant.DeletedOn) == null);
            }

            var totalCount = await query.CountAsync();
            var data = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return (data, totalCount);
        }

        public async Task<IEnumerable<TEntity>> GetPagedAsyncNew(
            Dictionary<string, object> columnFiltersEqual,
            Dictionary<string, object> columnFiltersContains,
            string sortDirection,
            string sortColumn,
            int pageNumber,
            int pageSize,
            bool asNoTracking = false,
            bool asSplitQuery = false,
            bool checkIsActive = false,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (asNoTracking) query = query.AsNoTracking();
            if (asSplitQuery) query = query.AsSplitQuery();
            if (includeExpression != null) query = includeExpression(query);
            if (checkIsActive && HasModelProperty(EntityFieldConstant.IsActive))
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive));

            query = ApplyEqualFilters(query, columnFiltersEqual);
            query = ApplyContainsFilters(query, columnFiltersContains);

            if (!string.IsNullOrWhiteSpace(sortColumn))
            {
                query = sortDirection.Equals("ASC", StringComparison.OrdinalIgnoreCase)
                    ? query.OrderBy(r => EF.Property<object>(r, sortColumn))
                    : query.OrderByDescending(r => EF.Property<object>(r, sortColumn));
            }

            return await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetWithOutPagedAsync(
            Dictionary<string, object> columnFiltersEqual,
            Dictionary<string, object> columnFiltersContains,
            string sortDirection,
            string sortColumn,
            int pageNumber,
            int pageSize,
            bool asNoTracking = false,
            bool asSplitQuery = false,
            bool checkIsActive = false,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (asNoTracking) query = query.AsNoTracking();
            if (asSplitQuery) query = query.AsSplitQuery();
            if (includeExpression != null) query = includeExpression(query);
            if (checkIsActive && HasModelProperty(EntityFieldConstant.IsActive))
                query = query.Where(e => EF.Property<bool>(e, EntityFieldConstant.IsActive));

            query = ApplyEqualFilters(query, columnFiltersEqual);
            query = ApplyContainsFilters(query, columnFiltersContains);

            if (!string.IsNullOrWhiteSpace(sortColumn))
            {
                query = sortDirection.Equals("ASC", StringComparison.OrdinalIgnoreCase)
                    ? query.OrderBy(r => EF.Property<object>(r, sortColumn))
                    : query.OrderByDescending(r => EF.Property<object>(r, sortColumn));
            }

            return await query.ToListAsync();
        }





        private static IQueryable<TEntity> ApplySorting(IQueryable<TEntity> query, string sortDirection, string sortColumn)
        {
            if (!string.IsNullOrWhiteSpace(sortDirection) && !string.IsNullOrWhiteSpace(sortColumn))
            {
                return sortDirection.Equals("ASC", StringComparison.OrdinalIgnoreCase)
                    ? query.OrderBy(r => EF.Property<object>(r, sortColumn))
                    : query.OrderByDescending(r => EF.Property<object>(r, sortColumn));
            }
            return (IQueryable<TEntity>)query.OrderByDescending(r => EF.Property<object>(r, "Id"));
        }

        private static Expression<Func<TEntity, bool>> BuildMixedExpression(
            List<FilterCondition<TEntity>>? andFilters,
            List<FilterCondition<TEntity>>? orFilters)
        {
            var parameter = Expression.Parameter(typeof(TEntity), "x");
            Expression? combinedAnd = null;
            Expression? combinedOr = null;

            if (andFilters?.Any() == true)
                combinedAnd = andFilters.Select(f => BuildConditionExpression(parameter, f)).Aggregate(Expression.AndAlso);
            if (orFilters?.Any() == true)
                combinedOr = orFilters.Select(f => BuildConditionExpression(parameter, f)).Aggregate(Expression.OrElse);

            Expression? finalExpression = combinedAnd switch
            {
                not null when combinedOr != null => Expression.AndAlso(combinedAnd, combinedOr),
                not null => combinedAnd,
                _ => combinedOr
            };

            return Expression.Lambda<Func<TEntity, bool>>(finalExpression!, parameter);
        }

        private static Expression BuildConditionExpression(ParameterExpression parameter, FilterCondition<TEntity> filter)
        {
            var property = Expression.Invoke(filter.Property, parameter);
            var constant = Expression.Constant(filter.Value);

            return filter.Operator switch
            {
                FilterOperator.Equals => Expression.Equal(property, Expression.Convert(constant, property.Type)),
                FilterOperator.Contains => BuildContainsExpression(property, constant),
                FilterOperator.In => BuildInExpression(property, constant),
                FilterOperator.GreaterThan => Expression.GreaterThan(property, Expression.Convert(constant, property.Type)),
                FilterOperator.LessThan => Expression.LessThan(property, Expression.Convert(constant, property.Type)),
                FilterOperator.GreaterThanOrEqual => Expression.GreaterThanOrEqual(property, Expression.Convert(constant, property.Type)),
                FilterOperator.LessThanOrEqual => Expression.LessThanOrEqual(property, Expression.Convert(constant, property.Type)),
                _ => throw new NotSupportedException("Unsupported filter operator.")
            };
        }

        private static Expression BuildContainsExpression(Expression property, Expression constant)
        {
            var toStringMethod = typeof(object).GetMethod("ToString", Type.EmptyTypes)!;
            var propertyAsString = Expression.Call(property, toStringMethod);
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) })!;
            return Expression.Call(propertyAsString, containsMethod, constant);
        }

        private static Expression BuildInExpression(Expression property, Expression constant)
        {
            var valueType = constant.Type.GetGenericArguments().FirstOrDefault() ?? constant.Type.GetElementType();
            var containsMethod = typeof(Enumerable)
                .GetMethods()
                .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                .MakeGenericMethod(valueType!);
            return Expression.Call(containsMethod, constant, Expression.Convert(property, valueType!));
        }
    }
}