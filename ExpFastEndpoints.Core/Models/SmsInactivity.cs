using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Models;

public class SmsInactivity
{
    public string? Id { get; set; }
    public string? Text { get; set; }
    public string? Msisdn { get; set; }
    public InactivityBand Band { get; set; }
    public DateTime CreatedAt { get; set; }
}

[PostgresEnum]
public enum InactivityBand
{
    SevenDays,
    FourteenDays,
    ThirtyDays,
    ThirtyOneToSixtyDays,
    SixtyOneToNinetyDays,
    NinetyOneToOneTwentyDays,
    OneTwentyOneToOneEightyDays,
    OneEightyOneToThreeSixtyFiveDays
}