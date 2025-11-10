using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.utility
{
    public class EmailSender: IEmailSender
    {
        //public string SendGridSecret { get; set; }

        //public EmailSender(IConfiguration _config)
        //{
        //    SendGridSecret =_config.GetValue<string>("SendGrid:SecretKey");
        //}
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //var client = new SendGridClient(SendGridSecret);
            //var from = new EmailAddress("hello@bulky.com", "bulky book");
            //var to = new EmailAddress(email);
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            //return client.SendEmailAsync(message);

            return Task.CompletedTask;
        }
    }
    
}
