public class Outdoor:Event
{
    private string _weatherForecast = "25C - Bright Skies";

    public Outdoor()
    {
        SetEventType("Outdoor");
    }

    private string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine($"Weather Forecast: {GetWeatherForecast()}\n");
        DisplayStandardDetails();
    }
}