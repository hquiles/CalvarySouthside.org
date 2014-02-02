using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Net;
using System.Net.Mail;

namespace Core.Communication
{
    internal static class EmailCore
    {
        internal static void SendEmail(string to, string from, string cc, string subject, string message)
        {
            NameValueCollection emailSettings = ConfigurationManager.GetSection("EmailSettings") as NameValueCollection;

            foreach (var key in emailSettings)
                Console.WriteLine("{0} {1}", key, emailSettings[key.ToString()]);

            MailMessage mail = new MailMessage();
            mail.To.Add(new MailAddress(to));
            mail.From = new MailAddress(from);
            mail.Subject = subject;
            mail.Body = message;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(emailSettings["smtpUsername"], emailSettings["smtpPassword"]);
            client.Host = emailSettings["smtpServer"];
            client.Port = int.Parse(emailSettings["smtpPort"]);
            client.EnableSsl = bool.Parse(emailSettings["smtpEnableSsl"]);

            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: log exception
            }
        }
    }
}