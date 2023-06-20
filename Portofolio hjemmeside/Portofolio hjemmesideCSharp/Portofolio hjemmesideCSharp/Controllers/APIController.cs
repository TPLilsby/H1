using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Portofolio_hjemmesideCSharp;
using MailKit.Security;
using MailKit.Net.Smtp;

namespace Portofolio_hjemmesideCSharp.Controllers
{
    // Attribute to mark the class as an API controller
    [ApiController]

    //Attribute to specify the base route for action methods
    [Route("[action]")]

    //APIController class
    public class APIController : ControllerBase
    {
        //Private variable logger instance for logging purposes
        private readonly ILogger<APIController> _logger;

        //Private variable to store database manager instance
        private readonly DALManager _database;

        //Constructor for the APIController class
        public APIController(ILogger<APIController> logger, DALManager database)
        {
            // Assigning the provided ILogger instance to _logger
            _logger = logger;

            // Assigning the provided DALManager instance to _database
            _database = database;
        }

        //HTTP POST action method with the name GetCv
        [HttpGet(Name = "GetCv")]

        //Retrieve a list of Cv objects
        public IEnumerable<Cv> GetCv()
        {
            //Call the corresponding method in the _database instance to fetch the cv data
            return _database.GetCv();

        }

        //HTTP POST action method with the name GetProject
        [HttpGet(Name = "GetProject")]

        //Retrieve a list of Project objects
        public IEnumerable<Project> GetProject()
        {
            //Call the corresponding method in the _database instance to fetch the project data
            return _database.GetProject();

        }

        // HTTP POST action method with the name GetTechnology
        [HttpGet(Name = "GetTechnology")]

        //Retrieve a list of Technology objects
        public IEnumerable<Technology> GetTechnology()
        {
            //Call the corresponding method in the _database instance to fetch the technology data
            return _database.GetTechnology();
        }

        //HTTP POST action method with the name SubmitContact
        [HttpPost(Name = "SubmitContact")]

        //Void method for Submitcontact and makes an object
        public void SubmitContact(ContactInfo info)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(info.Email));
            email.To.Add(MailboxAddress.Parse("ttlilsby@gmail.com"));

            //Email subject content
            email.Subject = "Mail fra Portofolio side";

            //Email body content
            email.Body = new TextPart(TextFormat.Plain) { Text = $" First Name: {info.FirstName}" +
                $"\n Last Name: {info.LastName}" +
                $"\n Email: {info.Email}" +
                $"\n Text: {info.Text}" };

            //Create and connect to an SMTP client
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

            //Authenticate with the SMTP server using the email credentials
            smtp.Authenticate("ttlilsby@gmail.com", "ellribhxraqntizj");

            //Send the email
            smtp.Send(email);

            //Discinnect the SMTP server
            smtp.Disconnect(true);

        }
    }
}