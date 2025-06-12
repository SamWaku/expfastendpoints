using ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.CommercialPaper;

public class CommercialPaperRequest : PaginationFilter
{
    public int? Id { get; set; }
    public string? SearchQuery { get; set; }
}