using ExpFastEnpoints.ExpFastEndpoints.Core.Entities.Auth;
using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Identity.Data;

namespace ExpFastEnpoints.ExpFastEndpoints.Core.Endpoints.Authentication;

public class Login : Endpoint<CustomLoginRequest>
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

    public override async Task HandleAsync(CustomLoginRequest req, CancellationToken ct)
    {
        var jwtToken = JwtBearer.CreateToken(t =>
        {
            t.SigningKey = "BQBrydjA6p5XGL6JMzZrYueUCIt6yzepLbYqrryFxo2eLtocY6__1_Dl1r1wcD2TCrlkGH6KpqD4l-j6FXhhQwX4sjoy6i35UNxRKmHaNWPvtXjJFzIyL82l-8PlipCdKW1FA9CDf0t6NqB0Pps6YggoJteyNsLyBwJJMRojulsNT4Pue3II1mtR-jt-CRyb4MMHSQOrMNw9xtG0Bec_iHHYrLYnk0d0mJPBs63yPVeiWiGER_2qKzvKHsakXD3rGyfDuf-HZabXJRdaJddErjznjmdstGls3guZqp5kxH6y2a0ywnUqVllYJEK8cYVjaJDo";
            t.ExpireAt = DateTime.Now.AddDays(1);
            t.User.Roles.Add("Admin", "Manager");
            t.User.Claims.Add(("Name", req.Name));
            t.User["UserId"] = "001"; 
        });

        await SendOkAsync(new
        {
            Token = jwtToken
        }, cancellation: ct);
    }
}