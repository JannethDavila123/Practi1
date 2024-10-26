var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola buenos dias desplegar proyecto 1");

app.Run();

