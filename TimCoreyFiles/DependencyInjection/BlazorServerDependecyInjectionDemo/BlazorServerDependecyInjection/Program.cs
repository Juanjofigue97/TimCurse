using BlazorServerDependecyInjection.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container Basic Temple.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Custom Temple - Sample
builder.Services.AddSingleton<WeatherForecastService>();

// We create a new instance every time we call it

//builder.Services.AddTransient<Demo>();
//builder.Services.AddTransient<ProcessDemo>();

// Same instance

//builder.Services.AddSingleton<Demo>();
//builder.Services.AddSingleton<ProcessDemo>();

// Different instance by User (Browser)

//builder.Services.AddScoped<Demo>();
//builder.Services.AddScoped<ProcessDemo>();

// Using Interface
// - Why?
// 

builder.Services.AddTransient<IDemo,Demo>();
builder.Services.AddTransient<IDemo,UtcDemo>();
builder.Services.AddTransient<ProcessDemo>();


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
