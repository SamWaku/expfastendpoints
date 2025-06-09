using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class Equity : BaseEntity
{
    public OrderType OrderType { get; set; }
    public string? Company { get; set; }
    public double Quantity { get; set; }
    public double SharePrice { get; set; }
}

[PostgresEnum]
public enum OrderType
{
    Sell,
    Buy
}