using GAC.Application.Services.Identity.Dtos.Shared;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Storage;

namespace GAC.Application.Interfaces.Shared
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // Single Entity Operations
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task<TEntity> GetByIdAsync(long id);
        Task<TEntity> GetByDynamicColumnsAsync(Dictionary<string, object> columnFiltersEqual, Dictionary<string, object> columnFiltersContains, bool asNoTracking = false, bool asSplitQuery = false, bool checkIsActive = false,
               Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null);
        Task<int> CountAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(long id);
        Task<bool> DeleteListAsync(List<TEntity> entities);

        // Batch Operations
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);

        // Retrieval Operations Include not support
        Task<IEnumerable<TEntity>> GetAllAsync(bool asNoTracking = false, bool includeInactive = false);
        // Retrieval Operations Include not support
        Task<IEnumerable<TEntity>> GetAllDataAsync(Expression<Func<TEntity, bool>>? predicate = null, bool asNoTracking = false, bool includeInactive = false);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);


        // Queryable Accessors
        IQueryable<TEntity> AsQueryable();
        IQueryable<TEntity> AsNoTracking();
        Task<(IEnumerable<TEntity> Data, int TotalCount)> GetPagedAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> filter = null, string orderByColumn = null, bool isAscending = true, string includeProperties = "", bool checkIsActive = false);

        Task<IEnumerable<TEntity>> GetPagedAsyncNew(
            Dictionary<string, object> columnFiltersEqual,
            Dictionary<string, object> columnFiltersContains,
            string sortDirection,
            string sortColumn,
            int pageNumber,
            int pageSize,
            bool asNoTracking = false,
            bool asSplitQuery = false,
            bool checkIsActive = false,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null);
        Task<IEnumerable<TEntity>> GetWithOutPagedAsync(
        Dictionary<string, object> columnFiltersEqual,
        Dictionary<string, object> columnFiltersContains,
        string sortDirection,
        string sortColumn,
        int pageNumber,
        int pageSize,
        bool asNoTracking = false,
        bool asSplitQuery = false,
        bool checkIsActive = false,
        Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null);



        Task<IEnumerable<TEntity>> GetByDynamicColumnNameAsync(string columnName, object id, bool asNoTracking = false, bool asSplitQuery = false, bool checkIsActive = false,
      Func<IQueryable<TEntity>, IQueryable<TEntity>> includeExpression = null);
    }
}
