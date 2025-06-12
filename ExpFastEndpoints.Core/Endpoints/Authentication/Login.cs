using ExpFastEnpoints.ExpFastEndpoints.Core.Database;
using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Authentication;

public class Login(PostgresDatabase database) : Endpoint<LoginRequest>
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
        // var jwtToken = JwtBearer.CreateToken(t =>
        // {
        //     t.SigningKey = "BQBrydjA6p5XGL6JMzZrYueUCIt6yzepLbYqrryFxo2eLtocY6__1_Dl1r1wcD2TCrlkGH6KpqD4l-j6FXhhQwX4sjoy6i35UNxRKmHaNWPvtXjJFzIyL82l-8PlipCdKW1FA9CDf0t6NqB0Pps6YggoJteyNsLyBwJJMRojulsNT4Pue3II1mtR-jt-CRyb4MMHSQOrMNw9xtG0Bec_iHHYrLYnk0d0mJPBs63yPVeiWiGER_2qKzvKHsakXD3rGyfDuf-HZabXJRdaJddErjznjmdstGls3guZqp5kxH6y2a0ywnUqVllYJEK8cYVjaJDo";
        //     t.ExpireAt = DateTime.Now.AddDays(1);
        //     t.User.Roles.Add("Admin", "Manager");
        //     t.User.Claims.Add(("Name", req.Name));
        //     t.User["UserId"] = "001"; 
        // });

        var matchPassword = await database.User.FirstOrDefaultAsync(x => x.Email == req.Email && x.Password == req.Password, cancellationToken: ct);
        if (matchPassword is null)
            ThrowError("Could not log you in", StatusCodes.Status401Unauthorized);
            
        await SendOkAsync(new
        {
            Message = "You are now logged in",
        }, cancellation: ct);
    }
}