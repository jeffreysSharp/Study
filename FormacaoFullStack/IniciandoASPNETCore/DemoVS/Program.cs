// Configura��o do ApplicationBuilder 
var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipe Line

// Middlewares
// Services

// Configura��o da App
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Isso � um teste");

app.Run();
