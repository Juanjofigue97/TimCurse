using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Inject]
        public ILogger<CounterBase> Log { get; set; }
        protected void IncrementCount()
        {
            currentCount += 2;
            Log.LogInformation("The new value is{CounterValue}", currentCount);
        }
    }
}
