namespace ExpFastEnpoints.ExpFastEndpoints.Core.Common.Pagination;

public interface IPaginatedResponse<T>
{
    int Page { get; set; }
    int PageSize { get; set; }
    int Total { get; set; }
    int TotalPages { get; set; }
    List<T> Data { get; set; }
}

public class PaginatedResponse<T> : IPaginatedResponse<T>
{
    public required int Page { get; set; }
    public required int PageSize { get; set; }
    public required int Total { get; set; }
    public required int TotalPages { get; set; }
    public required List<T> Data { get; set; } = [];
}