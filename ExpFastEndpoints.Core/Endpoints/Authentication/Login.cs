using System.Security.Claims;
using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;


namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Authentication;

public class Login(PostgresDatabase database, IConfiguration configuration) : Endpoint<LoginRequest>
{
    public override void Configure()
    {
        Post("auth/login");
        Summary(s =>
        {
            s.Summary = "Login User";
        });
        AllowAnonymous();
    }

    public override async Task HandleAsync(LoginRequest req, CancellationToken ct)
    {
        var matchPassword = await database.User.FirstOrDefaultAsync(x => x.Email == req.Email && x.Password == req.Password, cancellationToken: ct);
        var jwtToken = JwtBearer.CreateToken(t =>
        {
            t.SigningKey = configuration.GetConnectionString("JwtKey");
            t.ExpireAt = DateTime.Now.AddDays(1);
            t.User.Claims.Add(new Claim(JwtRegisteredClaimNames.Email, matchPassword.Email));
            t.User.Roles.Add(matchPassword.Role);
            t.User["UserId"] = matchPassword?.Id.ToString(); 
        });

        if (matchPassword is null)
            ThrowError("Could not log you in", StatusCodes.Status401Unauthorized);
            
        await SendOkAsync(new
        {
            JWTToken = jwtToken,
            Message = "You are now logged in",
        }, cancellation: ct);
    }
}