using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DalManager _database;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DalManager database)
        {
            _logger = logger;
            _database = database;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
           return _database.GetWeatherForecast();
           
        }
    }
}