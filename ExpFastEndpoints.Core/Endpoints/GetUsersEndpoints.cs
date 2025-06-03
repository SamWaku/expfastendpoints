using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints;

public class GetUsersEndpoints : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("hello/users");
        Summary(s =>
        {
            s.Summary = "Summary";
        });
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendOkAsync(cancellation: ct);
    }
}