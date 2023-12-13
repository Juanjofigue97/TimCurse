using DIDemoLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var build = new HostBuilder()
                .ConfigureServices((_,services) =>
                {
                    services.AddTransient<IMessages, Messages>();
                    services.AddTransient<Form1>();
                });
            var host = build.Build();
            using var scope = host.Services.CreateScope();

            try
            {
                var services = scope.ServiceProvider;
                ApplicationConfiguration.Initialize();

                var frm = services.GetRequiredService<Form1>();

                Application.Run(frm);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }


            
        }
    }
}