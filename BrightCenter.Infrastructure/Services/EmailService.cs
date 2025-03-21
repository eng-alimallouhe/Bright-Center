using BrightCenter.Infrastructure.Interfaces;
using System.Net.Mail;

namespace BrightCenter.Infrastructure.Services
{
    public class EmailService: IEmailService
    {
        private readonly SmtpClient _smtpClient;
        private readonly string _fromEmail;

        public EmailService(
            SmtpClient smtpClient, 
            string fromEmail
            )
        {
            this._smtpClient = smtpClient;
            this._fromEmail = fromEmail;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_fromEmail),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            mailMessage.To.Add(email);
            
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
