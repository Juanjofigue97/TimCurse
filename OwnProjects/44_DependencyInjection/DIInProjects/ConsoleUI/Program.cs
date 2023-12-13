using ConsoleUI;
using DIDemoLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddTransient<IMessages, Messages>();
builder.Services.AddTransient<App>();
using IHost host = builder.Build();
using var scope = host.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
	services.GetRequiredService<App>().Run();
    
}
catch (Exception ex)
{
    Console.WriteLine($"An error has occurred: { ex.Message }");
    Console.ReadLine();
}
