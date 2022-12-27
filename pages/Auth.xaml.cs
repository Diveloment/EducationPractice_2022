using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Providers.pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void auth_Button(object sender, RoutedEventArgs e)
        {
            App.authUser = App.Context.Users.FirstOrDefault(i => i.User_login == loginField.Text && i.User_password == passwordField.Password);
            if (App.authUser != null)
            {
                NavigationService.Navigate(new pages.Products());
            }
            else
            {
                MessageBox.Show("Вы ввели неправельный логин/пароль");
            }
        }
    }
}
