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
    /// Логика взаимодействия для PersonsView.xaml
    /// </summary>
    public partial class PersonsView : Page
    {
        private float fltStart = 0f;
        private float fltEnd = 100f;
        private float fltStatus = 1;
        private string searchStr = "";
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        public PersonsView()
        {
            InitializeComponent();
            filterSelect.Items.Add("Все диапазоны");
            var statuses = App.Context.PersonStatuses.ToList();
            for (int i = 0; i < statuses.Count(); i++)
            {
                filterSelect.Items.Add(statuses[i]);
            }
            filterSelect.SelectedIndex = 0;

            orderSelect.ItemsSource = new List<string>() { "По дате", "По дате обратно" };
            orderSelect.SelectedIndex = 0;
        }

        private void updateListView(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private void filter1Changed(object sender, SelectionChangedEventArgs e)
        {
            fltStatus = filterSelect.SelectedIndex;
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
            var view = CollectionViewSource.GetDefaultView(App.Context.Persons.ToList());
            view.Filter = i => (((entities.Persons)i).Person_status == fltStatus || fltStatus == 0) && ((entities.Persons)i).Person_name.ToLower().Contains(searchStr.ToLower());
            listView.ItemsSource = view;
            SortDescription sd = new SortDescription("Person_name", sortDirection);
            listView.Items.SortDescriptions.Clear();
            listView.Items.SortDescriptions.Add(sd);
            listView.Items.Refresh();
        }
    }
}
