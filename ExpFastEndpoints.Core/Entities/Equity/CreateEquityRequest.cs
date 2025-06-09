using System.Text.Json.Serialization;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Equity;

public class CreateEquityRequest
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public OrderType OrderType { get; set; }
    public string? Company { get; set; }
    public double Quantity { get; set; }
    public double SharePrice { get; set; }
}
