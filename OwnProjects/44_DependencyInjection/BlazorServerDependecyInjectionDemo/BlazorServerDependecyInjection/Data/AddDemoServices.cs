namespace BlazorServerDependecyInjection.Data
{
    public static class AddDemoServices
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IDemo, UtcDemo>();
            services.AddTransient<ProcessDemo>();

            return services;
        }
    }
}
