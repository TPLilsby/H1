using Microsoft.AspNetCore.Mvc;
using Portofolio_hjemmesideCSharp;

namespace Portofolio_hjemmesideCSharp.Controllers
{
    [ApiController]
    [Route("[action]")]
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
        public IEnumerable<WeatherForecast> GetWFC()
        {
            return _database.GetWeatherForecast();

        }

        [HttpGet(Name = "GetCv")]
        public IEnumerable<Cv> GetCv()
        {
            return _database.GetCv();

        }

        [HttpGet(Name = "GetProject")]
        public IEnumerable<Project> GetProject()
        {
            return _database.GetProject();

        }

        [HttpGet(Name = "GetContact")]
        public IEnumerable<Contact> GetContact()
        {
            return _database.GetContact();

        }

        [HttpPost(Name = "SubmitContact")]
        public void SubmitContact(ContactInfo info)
        {
            Console.WriteLine(info.FirstName);

        }
    }
}