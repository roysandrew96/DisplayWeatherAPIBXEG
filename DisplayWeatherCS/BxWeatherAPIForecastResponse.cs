using System.Text.Json.Serialization;

namespace DisplayWeatherCS;

public class BxWeatherAPIForecastResponse
{
    [JsonPropertyName("location")]
    public BxWeatherAPILocation Location { get; set; }
    
    [JsonPropertyName("current")]
    public BxWeatherAPIObservations CurrentConditions { get; set; }
    
    [JsonPropertyName("forecast")]
    public BxWeatherAPIForecast Forecasts { get; set; }
}

public class BxWeatherAPILocation
{
    [JsonPropertyName("name")]
    public string LocationName { get; set; }
    [JsonPropertyName("region")]
    public string LocationRegion { get; set; }
    [JsonPropertyName("country")]
    public string LocationCountry { get; set; }
    [JsonPropertyName("lat")]
    public decimal Latitude { get; set; }
    [JsonPropertyName("lon")]
    public decimal Longitude { get; set; }
    [JsonPropertyName("tz_id")]
    public string Timezone { get; set; }
    [JsonPropertyName("localtime_epoch")]
    public int TimeOfCall_Local_Epoch { get; set; }
    [JsonPropertyName("localtime")]
    public string TimeOfCall_Local { get; set; }
}

public class BxWeatherAPICondition
{
    [JsonPropertyName("text")]
    public string Condition { get; set; }
    [JsonPropertyName("icon")]
    public string ConditionIcon { get; set; }
    [JsonPropertyName("code")]
    public int ConditionCode { get; set; }
}

public class BxWeatherAPIObservations
{
    [JsonPropertyName("last_updated_epoch")]
    public int LastUpdatedEpoch { get; set; }
    [JsonPropertyName("last_updated")]
    public string LastUpdated { get; set; }
    [JsonPropertyName("temp_c")]
    public decimal CurrentTemperatureC { get; set; }
    [JsonPropertyName("temp_f")]
    public decimal CurrentTemperatureF { get; set; }
    [JsonPropertyName("is_day")]
    public int CurrentDay { get; set; }
    [JsonPropertyName("condition")]
    public BxWeatherAPICondition CurrentConditions { get; set; }
    [JsonPropertyName("wind_mph")]
    public decimal WindSpeedMph { get; set; }
    [JsonPropertyName("wind_kph")]
    public decimal WindSpeedKmh { get; set; }
    [JsonPropertyName("wind_degree")]
    public int WindDegree { get; set; }
    [JsonPropertyName("wind_dir")]
    public string WindDirection { get; set; }
    [JsonPropertyName("pressure_mb")]
    public decimal PressureMB { get; set; }
    [JsonPropertyName("pressure_in")]
    public decimal PressureIN { get; set; }
    [JsonPropertyName("precip_mm")]
    public decimal PrecipitationMM { get; set; }
    [JsonPropertyName("precip_in")]
    public decimal PrecipitationIN { get; set; }
    [JsonPropertyName("humidity")]
    public decimal Humidity { get; set; }
    [JsonPropertyName("feelslike_c")]
    public decimal FeelsLikeTemperatureC { set; get; }
    [JsonPropertyName("feelslike_f")]
    public decimal FeelsLikeTemperatureF { get; set; }
    [JsonPropertyName("vis_km")]
    public decimal VisibilityKilometres { get; set; }
    [JsonPropertyName("vis_miles")]
    public decimal VisibilityMiles { get; set; }
    [JsonPropertyName("uv")]
    public decimal UVRating { get; set; }
    [JsonPropertyName("gust_kmh")]
    public decimal WindGustKmh { get; set; }
    [JsonPropertyName("gust_mph")]
    public decimal WindGustMph { get; set; }
}

public class BxWeatherAPIForecast
{
    [JsonPropertyName("forecastday")]
    public BXWeatherAPIForecastDay[] ForecastDays { get; set; }
}

public class BXWeatherAPIForecastDay
{
    [JsonPropertyName("date")]
    public string ForecastDate { get; set; }
    [JsonPropertyName("date_epoch")]
    public int ForecastDateEpoch { get; set; }
    [JsonPropertyName("day")]
    public BXWeatherAPIForecastDayDetails Details { get; set; }
}

public class BXWeatherAPIForecastDayDetails
{
    [JsonPropertyName("maxtemp_c")]
    public decimal MaximumTemperatureC { get; set; }
    [JsonPropertyName("maxtemp_f")]
    public decimal MaximumTemperatureF { get; set; }
    [JsonPropertyName("mintemp_c")]
    public decimal MinimumTemperatureC { get; set; }
    [JsonPropertyName("mintemp_f")]
    public decimal MinimumTemperatureF { get; set; }
    [JsonPropertyName("avgtemp_c")]
    public decimal AverageTemperatureC { get; set; }
    [JsonPropertyName("avgtemp_f")]
    public decimal AverageTemperatureF { get; set; }
    [JsonPropertyName("maxwind_mph")]
    public decimal MaximumWindSpeedMPH { get; set; }
    [JsonPropertyName("maxwind_kph")]
    public decimal MaximumWindSpeedKPH { get; set; }
    [JsonPropertyName("total_precip_mm")]
    public decimal TotalPrecipMM { get; set; }
    [JsonPropertyName("total_precip_in")]
    public decimal TotalPrecipIN { get; set; }
    [JsonPropertyName("avgvis_km")]
    public decimal AverageVisibilityKM { get; set; }
    [JsonPropertyName("avgvis_miles")]
    public decimal AverageVisibilityMiles { get; set; }
    [JsonPropertyName("avghumidity")]
    public decimal AverageHumidity { get; set; }
    [JsonPropertyName("daily_will_it_rain")]
    public int DailyWillItRain { get; set; }
    [JsonPropertyName(("daily_chance_of_rain"))]
    public decimal DailyChanceOfRain { get; set; }
    [JsonPropertyName("daily_will_it_snow")]
    public int DailyWillItSnow { get; set; }
    [JsonPropertyName("daily_chance_of_snow")]
    public decimal DailyChanceOfSnow { get; set; }
    [JsonPropertyName("condition")]
    public BxWeatherAPICondition Condition { get; set; }
    public decimal UVRating { get; set; }
}