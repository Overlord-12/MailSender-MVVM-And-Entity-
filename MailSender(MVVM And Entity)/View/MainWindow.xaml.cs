using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using MailSender_MVVM_And_Entity_.Model;

namespace MailSender_MVVM_And_Entity_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataStructContainer db = new DataStructContainer();
        
        
        public MainWindow()
        {
            InitializeComponent();
            db.EmailAdresses.Load();
            MailGrid.ItemsSource = db.EmailAdresses.Local;
            СbRepcient.ItemsSource = db.EmailAdresses.Local;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void BtDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MailGrid.SelectedItem != null)
            {
                int id = (MailGrid.SelectedItem as EmailAdresses).Id;
                EmailAdresses emailAdresses = db.EmailAdresses.Where(i => i.Id == id).FirstOrDefault();
                db.EmailAdresses.Remove(emailAdresses);
                db.SaveChanges();
            }
        }
    }
}
