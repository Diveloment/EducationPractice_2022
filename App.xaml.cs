using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Providers
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static entities.ProvidersDataEntities Context = new entities.ProvidersDataEntities();
        public static entities.Users authUser = null;
    }
}
