class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string eventTitle, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }
}