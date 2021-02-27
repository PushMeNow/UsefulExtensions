using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using UsefulExtensions.Strings;

namespace UsefulExtensions.Collections
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> DynamicSort<T, TKey>(this IQueryable<T> query, string sortExpression, Expression<Func<T,TKey>> defaultSort = null)
        {
            if(sortExpression.IsNullOrWhiteSpace() && defaultSort != null)
            {
                query = query.OrderBy(defaultSort);
            }
            else
            {
                query = query.OrderBy(sortExpression);
            }

            return query;
        }

        public static IQueryable<T> SkipAndTake<T>(this IQueryable<T> query, int page, int pageSize)
        {
            if (pageSize > 0)
            {
                query = query.Skip(pageSize * page)
                    .Take(pageSize);
            }

            return query;
        }

        public static IQueryable<T> SortAndTake<T, TKey>(this IQueryable<T> query, string sortExpression, int page, int pageSize, Expression<Func<T, TKey>> defaultSort = null)
        {
            return query.DynamicSort(sortExpression, defaultSort)
                .SkipAndTake(page, pageSize);
        }
    }
}