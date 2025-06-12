using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;
using ExpFastEnpoints.ExpFastEndpoints.Core.Models;
using FastEndpoints;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Authentication;

public class Signup(PostgresDatabase database) : Endpoint<RegisterRequest, RegisterResponse>
{
    public override void Configure()
    {
        Post("auth/signup");
        Summary(s =>
        {
            s.Summary = "Register User";
        });
        AllowAnonymous();
    }

    public override async Task<RegisterResponse> ExecuteAsync(RegisterRequest req, CancellationToken ct)
    {
        var newUser = new User
        {
            Name = req.Name,
            Email = req.Email,
            Password = req.Password
        };
        database.User.Add(newUser);
        await database.SaveChangesAsync(cancellationToken: ct);
        return new RegisterResponse
        {
            Message = "User created",
        };
    }
}