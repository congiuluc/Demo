var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = WebApplication.Create();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapGet("/", () => "hello word");

app.Run();
