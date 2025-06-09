using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;

public class EquitiesRequest : PaginationFilter
{
    public int? Id { get; set; }
    public string? SearchQuery { get; set; }
}