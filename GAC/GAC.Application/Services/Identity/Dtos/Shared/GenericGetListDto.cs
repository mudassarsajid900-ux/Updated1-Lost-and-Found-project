using System.Linq.Expressions;

namespace GAC.Application.Services.Identity.Dtos.Shared
{
    public class GenericGetListDto<TEntity>
    {
        public Dictionary<string, object> ColumnFiltersEqual { get; set; } = new();
        public Dictionary<string, object> ColumnFiltersContains { get; set; } = new();
        public string SortDirection { get; set; } = "ASC"; // Default to ASC
        public string SortColumn { get; set; }
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public bool AsNoTracking { get; set; } = false;
        public bool AsSplitQuery { get; set; } = false;
        public bool CheckIsActive { get; set; } = false;
        public Func<IQueryable<TEntity>, IQueryable<TEntity>> IncludeExpression { get; set; }
    }

    public class QueryOptions<T> where T : class
    {
        public bool AsNoTracking { get; set; } = false;
        public bool AsSplitQuery { get; set; } = false;
        public List<FilterCondition<T>>? AndFilters { get; set; } = new();
        public List<FilterCondition<T>>? OrFilters { get; set; } = new();
        public Func<IQueryable<T>, IQueryable<T>>? Includes { get; set; }
        public Expression<Func<T, bool>>? Where { get; set; }
        // Sorting
        public string? SortColumn { get; set; }
        public string? SortDirection { get; set; }

        // Pagination
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
    }

    public class FilterCondition<T>
    {
        public Expression<Func<T, object>> Property { get; set; } = null!;
        public object Value { get; set; } = null!;
        public FilterOperator Operator { get; set; } = FilterOperator.Equals;
    }

    public class FilterConditionMapView<T>
    {
        public LambdaExpression Property { get; set; } = default!;
        public object? Value { get; set; }
        public FilterOperator Operator { get; set; }
    }

    public enum FilterOperator
    {
        Equals,
        Contains,
        In,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual
    }
}
