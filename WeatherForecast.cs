namespace CSharkGithubActions;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public Weather Weather { get; set; }
}

public enum Weather
{
    Cloudy,
    Rainy,
    Sunny,
    Snowy
}