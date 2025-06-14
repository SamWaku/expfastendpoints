﻿using System.Linq.Expressions;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Common.Extensions;

public static class CollectionExtensions
{
    public static IQueryable<T> ConditionalWhere<T>(this IQueryable<T> queryable, bool condition,
        Expression<Func<T, bool>> predicate)
    {
        if (condition)
        {
            queryable = queryable.Where(predicate);
        }
    
        return queryable;
    }
    
    public static PaginatedResponse<T> ToPagedResponse<T>(this IEnumerable<T> data, int total,
        PaginationFilter filter)
    {
        return new PaginatedResponse<T>
        {
            Page = filter.PageNumber,
            PageSize = filter.PageSize,
            Total = total,
            TotalPages = (int) Math.Ceiling((double) total / filter.PageSize),
            Data = data.ToList() 
        };
    }
    
    public static IQueryable<T> OrderAndPaginate<T>(this IQueryable<T> data, PaginationFilter filter)
        where T : BaseEntity
    {
        var pagedResponse = data
            .OrderByDescending(x => x.Id)
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize);
        return pagedResponse;
    }
}