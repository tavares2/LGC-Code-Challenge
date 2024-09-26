var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var mergeConflict = 7;


app.MapGet("/", () => "Hello World!");

app.Run();
