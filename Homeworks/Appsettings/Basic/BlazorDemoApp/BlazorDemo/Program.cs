using BlazorDemo.Data;
using BlazorDemo.Options;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.Configure<EmailSettingsOptions>(builder.Configuration.GetSection("EmailSettings"));

var env = builder.Environment.EnvironmentName;

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true);

var memCollection = new Dictionary<string, string>
{
    { "MainSetting:SubSetting", "Sub setting from dictionary" }
};


if (env == "Development")
{
    builder.Configuration.AddUserSecrets<Program>();
}
builder.Configuration.AddEnvironmentVariables();
builder.Configuration.AddCommandLine(args);
builder.Configuration.AddJsonFile("custom.json", optional: true, reloadOnChange: true);
builder.Configuration.AddXmlFile("custom.xml", optional: true, reloadOnChange:true) ;
builder.Configuration.AddIniFile("custom.ini", optional: true, reloadOnChange: true);
builder.Configuration.AddInMemoryCollection(memCollection);
//builder.Services.AddOptions<MyOptions>().BindConfiguration("MyConfig");

//builder.Services.AddHostedService<MyWorker>();

builder.WebHost.UseWebRoot("wwwroot").UseStaticWebAssets();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
