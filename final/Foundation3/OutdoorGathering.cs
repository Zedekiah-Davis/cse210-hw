public class OutdoorGathering : Event
{
    public string WeatherForecast { get; set; }

    public OutdoorGathering(string eventTitle, string description, DateTime date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails() + $"\nWeather Forecast: {WeatherForecast}";
    }
}