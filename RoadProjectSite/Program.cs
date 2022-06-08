var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов
#region Services

var services = builder.Services;
services.AddMvc();

#endregion

// Построение приложения
var app = builder.Build();

// Настройка приложения и маршрутизации
#region App

if (app.Environment.IsDevelopment())
{
    //app.Urls.Add("http://+:80");
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapDefaultControllerRoute();

#endregion



// Файл конфигурации
var appCfg = app.Configuration;
app.MapGet("/debug", () => appCfg["CompanyName"]);

app.Run();
