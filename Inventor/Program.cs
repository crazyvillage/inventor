using CrazyVillage.Inventor.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();
builder.Services.AddDbContext<HelloWorldContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("HelloWorldContext"))
        .UseSnakeCaseNamingConvention());

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseOpenApi();
app.UseReDoc(options =>
{
    options.Path = "/redoc";
});

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
