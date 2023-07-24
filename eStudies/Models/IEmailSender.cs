using System.Net.Mail;
using System.Net;

namespace eStudies.Models
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var sc = new SmtpClient("smtp.office365.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ammaransari7016@hotmail.com", password: "2lG83FB5")
            };

            return sc.SendMailAsync(new MailMessage(from: "ammaransari7016@hotmail.com", to: email, subject, message));

        }
    }
}