using Cursovou.ApplicationData;
using Cursovou.MainPage;
using Microsoft.SqlServer.Server;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Market = Cursovou.ApplicationData.Market;

namespace Cursovou
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new BarberShopEntities1();
            Manager.MainFrame = MainFrame;
            Manager.FrFrame = FrFrame;

            Manager.MainFrame.Navigate(new Avtorizaxhia());
        }

        private void barber_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrFrame.Navigate(new barberi());
        }

        private void Yslygi_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrFrame.Navigate(new Yslygi());
        }

        private void Produchia_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrFrame.Navigate(new Market());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void klient_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrFrame.Navigate(new klient());
        }

        private void Zapisi_Click(object sender, RoutedEventArgs e)
        {
            Manager.FrFrame.Navigate(new Zapisi());
        }
    }
}
