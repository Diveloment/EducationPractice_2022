﻿using System;
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

namespace Providers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new pages.Products());
        }

        private void productViewBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new pages.Products());
        }

        private void providersViewBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new pages.ProvidersViewPage());
        }

        private void dealsViewBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new pages.DealsView());
        }

        private void personViewBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new pages.PersonsView());
        }
    }
}
