using MailSender_MVVM_And_Entity_;
using MailSender_MVVM_And_Entity_.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MailSenderMVVMAndEntity.ViewModel
{
  public class ViewMod
  {
       static DataStructContainer _db = new DataStructContainer();
        
        public ObservableCollection<SmtpServer> SmtpServers { get; set; } = DataBaseSmtp.GetSmtp();
        public ObservableCollection<MailAdr> mailAdrs { get; set; } = DataBaseAdr.GetDataBase();

        public string MailContent { get; set; } = "Писать здесь";
        public string MailTopic { get; set; } = "Писать здесь";
        public string MailAdr { get; set; } = "";
        public static string FromAdresses { get; set; } = "";
        public string Server { get; set; } = "";
        public int QuantityMail { get; set; } = 0;


        public static void Add()
        {

        }
        public string GetSmtp
        {
            get { foreach (var smtp in SmtpServers) return smtp.smtp; return ""; }

        }
        public ICommand SendCommand
        {
            get
            {
                return new Comand(Send, CanSend);
            }
        }
        public bool CanSend(object obj)
        {
            if (MailAdr != "" && Server != "" && QuantityMail != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Send(object obj)
        {
            try
            {
                for (int i = 0; i < QuantityMail; i++)
                {
                    SendMail.Send(MailTopic, MailContent, MailAdr, Server);
                }
                MessageBox.Show("Сообщение отправлено");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Упс :) произошла ошибка");
            }
            

        }
    }
}
