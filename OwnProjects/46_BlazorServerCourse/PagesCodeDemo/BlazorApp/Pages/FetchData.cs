using BlazorApp.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[]? forecasts;
        [Inject]
        public WeatherForecastService ForecastService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateOnly.FromDateTime(DateTime.Now));
        }
    }
}
