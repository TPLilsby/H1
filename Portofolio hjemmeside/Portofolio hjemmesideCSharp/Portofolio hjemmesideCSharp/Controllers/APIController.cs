using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Portofolio_hjemmesideCSharp;
using MailKit.Security;
using MailKit.Net.Smtp;

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

        [HttpGet(Name = "GetTechnology")]
        public IEnumerable<Technology> GetTechnology()
        {
            return _database.GetTechnology();
        }

        [HttpPost(Name = "SubmitContact")]
        public void SubmitContact(ContactInfo info)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(info.Email));
            email.To.Add(MailboxAddress.Parse("ttlilsby@gmail.com"));
            email.Subject = "Mail fra Portofolio side";
            email.Body = new TextPart(TextFormat.Plain) { Text = $" First Name: {info.FirstName}" +
                $"\n Last Name: {info.LastName}" +
                $"\n Email: {info.Email}" +
                $"\n Text: {info.Text}" };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("ttlilsby@gmail.com", "ellribhxraqntizj");
            smtp.Send(email);
            smtp.Disconnect(true);

        }
    }
}