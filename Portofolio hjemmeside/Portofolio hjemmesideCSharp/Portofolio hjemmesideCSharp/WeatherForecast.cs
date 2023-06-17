using Portofolio_hjemmesideCSharp;


    public class WeatherForecast
    {
        public int Id { get; set; }
        public int Year { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string? Summary { get; set; }

        public WeatherForecast(int id, int year, int temperatureC, int temperatureF, string summary)
        {
            Id = id;
            Year = year;
            TemperatureC = temperatureC;
            TemperatureF = temperatureF;
            Summary = summary;
        }
    }