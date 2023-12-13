using DIDemoLibrary;
using WorkerService;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddTransient<IMessages,Messages>();

var host = builder.Build();
host.Run();
