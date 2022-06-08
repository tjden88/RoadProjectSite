var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Файл конфигурации
var appCfg = app.Configuration;

app.MapGet("/", () => appCfg["CompanyName"]);

app.Run();
