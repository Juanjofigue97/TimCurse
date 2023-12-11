namespace BlazorServerDependecyInjection.Data
{
    public class UtcDemo : IDemo,IUtcDemo
    {
        public DateTime StartupTime { get; set; }

        public UtcDemo()
        {
            StartupTime = DateTime.UtcNow;
        }
    }
}
