using System.Text.Json;
using System.Text.Json.Serialization;
using FastEndpoints;
using FastEndpoints.Swagger;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;
using FastEndpoints.Security;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
builder.Services.AddCors();
builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddAuthenticationJwtBearer(s => s.SigningKey = "SomeKey");
builder.Services.AddAuthorization();


var app = builder.Build();

app.UseFastEndpoints(c =>
{
    c.Serializer.Options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
    c.Serializer.Options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;;
});
app.UseCors("DefaultPolicy");
app.UseSwaggerGen();
app.Run();
