using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectone;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
builder.Services.AddSqlServer<TareasContext>("Data source");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async([FromServices] TareasContext dbContext) => 
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Basde de datos en memoria: " + dbContext.Database.IsInMemory());
}   
);

app.Run();
