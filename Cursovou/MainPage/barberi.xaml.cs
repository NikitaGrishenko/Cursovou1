﻿using Cursovou.ApplicationData;
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
    /// Логика взаимодействия для barberi.xaml
    /// </summary>
    public partial class barberi : Page
    {
        public barberi()
        {
            InitializeComponent();
            DtGridBarber.ItemsSource = BarberShopEntities1.GetContext().Barber.ToList();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
