using DependecyLibrary;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IDemoDependecy, DemoDependecy2>();

await builder.Build().RunAsync();
