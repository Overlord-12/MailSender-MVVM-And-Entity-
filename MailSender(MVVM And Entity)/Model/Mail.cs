using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender_MVVM_And_Entity_.Model
{
    public class MailAdr
    {
        public string Name { get; set; }

        public string Adress { get; set; }
        public string Password { get; set; }


        public MailAdr(string name, string adress, string password)
        {
            Name = name;
            Adress = adress;
            Password = password;

        }

        public override string ToString()
        {
            return this.Adress;
        }
    }
    public class DataBaseAdr
    {
        public static ObservableCollection<MailAdr> GetDataBase()
        {
            var smtp = new ObservableCollection<MailAdr>
            {
                new MailAdr("Danila","danya.argastsev.02@mail.ru","123Danil2"),
            };
            return smtp;
        }
    }

}
