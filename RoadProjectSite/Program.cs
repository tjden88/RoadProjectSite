var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов
#region Services

var services = builder.Services;
services.AddMvc();

#endregion

// Построение приложения
var app = builder.Build();

// Файл конфигурации
var appCfg = app.Configuration;


// Настройка приложения и маршрутизации
#region App

if (app.Environment.IsDevelopment())
{
    //app.Urls.Add("http://+:80");
    app.UseDeveloperExceptionPage();
}


app.UseStaticFiles();

app.Use(async (context, next) => // Заглушка недоступного сайта
{
    if (appCfg["SiteIsNotAvaliable"] == "True")
    {
        context.Request.Path = "/Home/SiteNotAvaliable";
    }
    await next();
});

app.UseStatusCodePagesWithRedirects("/Error/{0}"); // 404 страница для всех неверных адресов

app.UseRouting();

app.MapDefaultControllerRoute();


#endregion


app.Run();
