using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace mail_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("andre93@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("andre93@ethereal.email"));
            email.Subject = "Test email subject";
            email.Body = new TextPart(TextFormat.Plain) { Text = body };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("andre93@ethereal.email", "rTwTtxCmH3yZghYxyF");
            smtp.Send(email);
            smtp.Disconnect(true);

            return Ok();
        }
    }
}
