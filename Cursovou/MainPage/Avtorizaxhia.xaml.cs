using Cursovou.ApplicationData;
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

namespace Cursovou.MainPage
{
    /// <summary>
    /// Логика взаимодействия для Avtorizaxhia.xaml
    /// </summary>
    public partial class Avtorizaxhia : Page
    {
        public Avtorizaxhia()
        {
            InitializeComponent();
        }

        private void Registracia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vxod_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.model0db.Klient.FirstOrDefault(x => x.Login == txtLogin.Text && x.Password == txtPass.Password);
                if (userObj == null)
                {
                    MessageBox.Show(" Такого пользователя не существует! ", " Ошибка авторизации! ",
                        MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {
                    switch (userObj.IDKlient)
                    {
                        case 1:
                            MessageBox.Show(" Здравствуйте, Администратор " + userObj.Name + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Manager.MainFrame.Content = null;
                            break;
                        case 2:
                            MessageBox.Show(" Здравствуйте, Пользователь " + userObj.Name + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Manager.MainFrame.Content = null;
                            break;
                    }

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка приложения! ",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
