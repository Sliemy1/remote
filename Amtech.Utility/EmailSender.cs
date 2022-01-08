using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amtech.Utility
{
    public class EmailSender : IEmailSender
    {
        public string SendGridSecret { get; set; }

        public EmailSender(IConfiguration _config)
        {
            SendGridSecret = _config.GetValue<string>("SendGrid:SecretKey");

        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //var emailTosend = new MimeMessage();
            //emailTosend.From.Add(MailboxAddress.Parse("hello@alciuswendy.com"));
            //emailTosend.To.Add(MailboxAddress.Parse(email));
            //emailTosend.Subject = subject;
            //emailTosend.Body= new TextPart(MimeKit.Text.TextFormat.Html){ Text=htmlMessage};

            ////send email
            //using(var emailClient = new SmtpClient())
            //{
            //    emailClient.Connect("smtp.gmail.com",587,MailKit.Security.SecureSocketOptions.StartTls);
            //    emailClient.Authenticate("alciuswendy@gmail.com", "WendyGmail1");
            //    emailClient.Send(emailTosend);
            //    emailClient.Disconnect(true);
            //}

            //return Task.CompletedTask;

            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress("wendyalcius@warvetech.com", "Amtech");
            var to = new EmailAddress(email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            return client.SendEmailAsync(msg);

        }
    }
}
