using System.Net;

namespace DisplayWeatherCS;

public class BxWeatherService
{
    private HttpClient _httpClient;
    
    public BxWeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async void GetForecast()
    {

        string apiKey = "???";
        Uri weatherAPIUri = new Uri($"http://api.weatherapi.com/v1/forecast.json?key={apiKey}&q=-37.716512,144.91903&days=3&aqi=no&alerts=no");

        //var response = await _httpClient.GetAsync(weatherAPIUri);
        var bxWeatherApiForecastResponse = await _httpClient.GetFromJsonAsync<BxWeatherAPIForecastResponse>(weatherAPIUri, CancellationToken.None);

        var loc = bxWeatherApiForecastResponse.Location;

        var current = bxWeatherApiForecastResponse.CurrentConditions;

        var iconView = current.CurrentConditions.ConditionIcon;

        var Forecasts = bxWeatherApiForecastResponse.Forecasts;

        var numberOfDays = Forecasts.ForecastDays.Length;

        var Day1Condition = Forecasts.ForecastDays[0].Details.Condition;

        var Day1LooksLike = Day1Condition.Condition;
        var Day1Icon = Day1Condition.ConditionIcon;
    }
    
}