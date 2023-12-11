namespace BlazorServerDependecyInjection.Data;

public class Demo : IDemo, ILocalDemo
{
    public DateTime StartupTime { get; set; }

    public Demo()
    {
        StartupTime = DateTime.Now;
    }
}
