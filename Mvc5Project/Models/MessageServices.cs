using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace Mvc5Project.Models
{
    class MessageServices
    {
        public static void SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var _email = "aurkovec594@gmail.com";
                var _epass = "ElenaOtlivamova1980AnnaYurkovets1997";
                var _dispName = "IT-News";
                MailMessage myMessage = new MailMessage();
                myMessage.To.Add(email);
                myMessage.From = new MailAddress(_email, _dispName);
                myMessage.Subject = subject;
                myMessage.Body = message;
                myMessage.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.EnableSsl = true;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(_email, _epass);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.SendCompleted += (s, e) => { smtp.Dispose(); };
                    smtp.Send(myMessage);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
