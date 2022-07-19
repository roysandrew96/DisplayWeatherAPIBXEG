namespace DisplayWeatherCS;

public interface IBxWeatherForecast
{
    public DateOnly ForecastDate { get; set; }
    public string ForecastDateEpoch { get; set; }
    public string Condition { get; set; }
    public string ConditionIcon { get; set; }
    public string ConditionCode { get; set; }
    public decimal MaxTempC { get; set; }
    public decimal MaxTempF { get; set; }
    public decimal MinTempC { get; set; }
    public decimal MinTempF { get; set; }
    public decimal AvgTempC { get; set; }
    public decimal AvgTempF { get; set; }
    public decimal MaxWindKph { get; set; }
    public decimal MaxWindMph { get; set; }
    public decimal TotalPrecipMillimetres { get; set; }
    public decimal TotalPrecipInches { get; set; }
    public decimal AvgVisKm { get; set; }
    public decimal AvgKVisMiles { get; set; }
    public decimal AvgHumidity { get; set; }
    public bool DailyWillItRain { get; set; }
    public decimal ChanceOfRain { get; set; }
    public bool DailyWillItSnow { get; set; }
    public decimal ChanceOfSnow { get; set; }
    public decimal UVRating { get; set; }
}