using MailSenderMVVMAndEntity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MailSender_MVVM_And_Entity_
{
    class SendMail
    {
        public static void Send(string topic, string body, string toadress, string server)
        {
            var fromAddress = new MailAddress(ViewMod.FromAdresses, "Danila");
            var toAddress = new MailAddress($"{toadress}", null);
            var smtp = new SmtpClient
            {
                Host = server,
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ViewMod.FromAdresses, "123Danil2"),
            };
            using (var message = new MailMessage(Convert.ToString(fromAddress), Convert.ToString
                (toAddress))
            {
                Subject = topic,
                Body = body

            })
            {
               
                    smtp.Send(message);
                
               
            }
            

        }
    }
}
