using System;
using System.Net.Http;
using Newtonsoft.Json;

public class WeatherData
{
    public string Location { get; set; }
    public string Conditions { get; set; }
    public string Temperature { get; set; }
    public string Humidity { get; set; }
    public string WindSpeed { get; set; }
}

public class WeatherFetcher
{
    private HttpClient httpClient;

    public WeatherFetcher()
    {
        httpClient = new HttpClient();
    }

    public WeatherData getWeatherInfo(string city)
    {
        try
        {
            string apiUrl = $"https://goweather.herokuapp.com/weather/{city}";
            var response = httpClient.GetStringAsync(apiUrl).Result;

            var weatherData = JsonConvert.DeserializeObject<WeatherData>(response);

            weatherData.Location = city;

            return weatherData;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oops! An error occurred while fecthing weather information for {city}: {ex.Message}");
            return null;
        }
    }
}

public class WeatherReporter
{
    public static void DisplayWeatherInfo(WeatherData weatherData)
    {
        if (weatherData != null)
        {
            Console.WriteLine($"Location: {weatherData.Location}");
            Console.WriteLine($"Conditions: {weatherData.Conditions}");
            Console.WriteLine($"Temperature: {weatherData.Temperature}");
            Console.WriteLine($"Humidity: {weatherData.Humidity}");
            Console.WriteLine($"Wind Speed: {weatherData.WindSpeed}");
            Console.WriteLine();
        }
    }
}

class WeatherProgram
{
    static void Main()
    {
        WeatherFetcher weatherFetcher = new WeatherFetcher();

        string[] cities = { "istanbul", "izmir", "ankara" };
        foreach (var city in cities)
        {
            WeatherData weatherData = weatherFetcher.getWeatherInfo(city);
            WeatherReporter.DisplayWeatherInfo(weatherData);
        }
    }
}
