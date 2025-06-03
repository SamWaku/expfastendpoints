using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();
builder.Services.AddCors();
builder.Services.AddDbContext(builder.Configuration);


var app = builder.Build();

app.UseFastEndpoints();
app.UseCors("DefaultPolicy");
app.UseSwaggerGen();
app.Run();
