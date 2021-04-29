using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_MVVM_And_Entity_.Model
{
    
        public class SmtpServer
        {
            public string smtp { get; set; }
            public SmtpServer(string server)
            {
                smtp = server;

            }
            public override string ToString()
            {
                return smtp;

            }
        }
        public class DataBaseSmtp
        {
            public static ObservableCollection<SmtpServer> GetSmtp()
            {
                var smtp = new ObservableCollection<SmtpServer>
            {
                new SmtpServer("smtp.mail.ru"),
                new SmtpServer("smtp.gmail.com"),
            };
                return smtp;
            }
        }
    
}
