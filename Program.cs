using System.Text.Json;
using System.Text.Json.Serialization;
using FastEndpoints;
using FastEndpoints.Swagger;
using ExpFastEnpoints.ExpFastEndpoints.Core.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
builder.Services.AddCors();
builder.Services.AddDbContext(builder.Configuration);


var app = builder.Build();

app.UseFastEndpoints(c =>
{
    c.Serializer.Options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
    c.Serializer.Options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;;
});
app.UseCors("DefaultPolicy");
app.UseSwaggerGen();
app.Run();
