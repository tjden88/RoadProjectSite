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
app.MapGet("/debug", () => appCfg["CompanyName"]);


// Настройка приложения и маршрутизации
#region App

if (app.Environment.IsDevelopment())
{
    //app.Urls.Add("http://+:80");
    app.UseDeveloperExceptionPage();
}


//app.Use(async (context, next) => // 404 страница для всех неверных адресов
//{
//    await next();
//    if (appCfg["SiteIsNotAvaliable"] == "True")
//    {
//        context.Request.Path = "/Home/NotFoundPage";
//        await next();
//    }
//});

app.UseStatusCodePagesWithRedirects("/Error/{0}"); // 404 страница для всех неверных адресов вариант 2

app.UseStaticFiles();
app.UseRouting();

app.MapDefaultControllerRoute();

#endregion




app.Run();
