var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! \nThis is a test for a .net core Web API.");

app.Run();