using System.Windows.Input;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;
using ICommand = FastEndpoints.ICommand;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Commands;

public class GetUserCommand : ICommand<EmptyResponse>
{
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public DateTime SendTime { get; set; }
    public string? OriginatorId { get; set; }
    public InactivityBand InactivityBand { get; set; }
    public required string Text { get; set; }
    public required string Msisdn { get; set; }
}

public class GetUserCommandHandler : ICommandHandler<GetUserCommand, EmptyResponse>
{
    public Task<EmptyResponse> ExecuteAsync(GetUserCommand command, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}