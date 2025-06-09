namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;

public class CreateEquityRequest
{
    public OrderType OrderType { get; set; }
    public string? Company { get; set; }
    public double Quantity { get; set; }
    public double SharePrice { get; set; }
}

public enum OrderType
{
    Sell,
    Buy
}
