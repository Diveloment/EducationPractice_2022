using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Providers.pages
{
    /// <summary>
    /// Логика взаимодействия для ProvidersViewPage.xaml
    /// </summary>
    public partial class ProvidersViewPage : Page
    {
        private string searchStr = "";
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        public ProvidersViewPage()
        {
            InitializeComponent();
            orderSelect.ItemsSource = new List<string>() { "По активности", "По обратной активности" };
            orderSelect.SelectedIndex = 0;
        }

        private void updateListView(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private void searchBarInput(object sender, TextChangedEventArgs e)
        {
            searchStr = searchBar.Text.Trim();
            UpdateList();
        }

        private void orderChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    {
                        sortDirection = ListSortDirection.Ascending;
                        UpdateList();
                        break;
                    }
                case 1:
                    {
                        sortDirection = ListSortDirection.Descending;
                        UpdateList();
                        break;
                    }
            }
        }

        public void UpdateList()
        {
            var view = CollectionViewSource.GetDefaultView(App.Context.Providers.ToList());
            view.Filter = i => ((entities.Providers)i).Provider_name.Contains(searchStr) || ((entities.Providers)i).Provider_subname.ToLower().Contains(searchStr.ToLower());
            listView.ItemsSource = view;
            SortDescription sd = new SortDescription("Provider_relationshipType", sortDirection);
            listView.Items.SortDescriptions.Clear();
            listView.Items.SortDescriptions.Add(sd);
            listView.Items.Refresh();
        }
    }
}
