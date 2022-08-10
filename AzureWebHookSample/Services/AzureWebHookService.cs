using AzureWebHookSample.Modals;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebHookSample.Services
{
    public class AzureWebHookService : IAzureWebHookService
    {
        public string SendMail(string request)
        {
            var email = new MimeMessage();


            email.From.Add(MailboxAddress.Parse("FromAdress"));


            email.To.Add(MailboxAddress.Parse("metehanyetkin12@gmail.com"));


            var builder = new BodyBuilder();

            email.Subject = "Azure Web Hooks Request Value";
            email.Body = new TextPart("plain")
            {
                Text = request
            };


            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("mailServer", 366, SecureSocketOptions.None);
                    smtpClient.Authenticate("Username", "password");
                    smtpClient.Send(email);
                    smtpClient.Disconnect(true);
                }
            }

            catch (Exception ex)
            {
                return ex.Message;


            }
            return "İşlem Başarılı";
        }

        public string SendMailWithModal(AzureResponseModals request)
        {
            var email = new MimeMessage();
            var textBody = request.Resource.workItemId.ToString();

            email.From.Add(MailboxAddress.Parse("FromAdress"));


            email.To.Add(MailboxAddress.Parse("metehanyetkin12@gmail.com"));


            var builder = new BodyBuilder();

            email.Subject = "Azure Web Hooks Request Value";
            email.Body = new TextPart("plain")
            {
                Text = textBody
            };


            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    smtpClient.Connect("mailServer", 366, SecureSocketOptions.None);
                    smtpClient.Authenticate("Username", "password");
                    smtpClient.Send(email);
                    smtpClient.Disconnect(true);
                }
            }

            catch (Exception ex)
            {
                return ex.Message;


            }
            return "İşlem Başarılı";
        }
    }
}
