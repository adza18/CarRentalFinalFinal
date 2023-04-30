using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystem.Application.Common.Services;

namespace CarRentalSystem.Infrastructure.Services
{
    public class EmailSenderCustom: IEmailSenderCustom
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {


            string fromMail = "adrizaacharya4@gmail.com";
            string fromPassword = "gihfhnnidwyxoxoh";


            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body><h2>hello</h2><p> " + htmlMessage + "</p> </body></html>";

            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };


            smtpClient.Send(message);



        }
    }
}
