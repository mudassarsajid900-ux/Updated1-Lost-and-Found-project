using System.Linq.Expressions;

namespace QatarFreeZone.Application.Extensions;

public static class QueryableExtension
{
    private static IQueryable<TSource> ApplySorting<TSource, TKey>(this IQueryable<TSource> query, Expression<Func<TSource, TKey>> keySelector, bool isDescending = false)
    {
        return isDescending ? query.OrderByDescending(keySelector) : query.OrderBy(keySelector);
    }

    public static IQueryable<TSource> OrderByIf<TSource, TKey>(this IQueryable<TSource> query, bool condition, Expression<Func<TSource, TKey>> keySelector, bool isDescending = true)
    {
        return condition ? query.ApplySorting(keySelector, isDescending) : query;
    }

    public static IQueryable<TSource> PageBy<TSource>(this IQueryable<TSource> query, int pageNumber, int pageSize)
    {
        return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
    }

    public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> query, bool condition, Expression<Func<TSource, bool>> predicate)
    {
        return condition ? query.Where(predicate) : query;
    }
}
