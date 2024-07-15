// Configuração do ApplicationBuilder 
var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipe Line

// Middlewares
// Services

// Configuração da App
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Isso é um teste");

app.Run();
