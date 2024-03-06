using Microsoft.AspNetCore.Components;

namespace KeyConcepts.Client.Pages;

public partial class Demo
{
    //[Inject]
    //protected IConfiguration config { get; set; } = default!;
    private string? GetConnectionInfo()
    {
        return config.GetConnectionString("Default");
    }
}