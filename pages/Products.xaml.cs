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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        private float fltStart = 0f;
        private float fltEnd = 100f;
        private string searchStr = "";
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        public Products()
        {
            InitializeComponent();
            filterSelect.ItemsSource = new List<string>() { "Все диапазоны", "0 - 2000 руб", "2001 - 4000 руб", ">4001 руб" };
            filterSelect.SelectedIndex = 0;

            orderSelect.ItemsSource = new List<string>() { "По возрастанию цены", "По убыванию цены" };
            orderSelect.SelectedIndex = 0;
        }

        private void updateListView(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private void filterChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as ComboBox).SelectedIndex)
            {
                case 0:
                    {
                        fltStart = 0f;
                        fltEnd = 10000000f;
                        break;
                    }
                case 1:
                    {
                        fltStart = 0f;
                        fltEnd = 2000f;
                        break;
                    }
                case 2:
                    {
                        fltStart = 2001f;
                        fltEnd = 4000f;
                        break;
                    }
                case 3:
                    {
                        fltStart = 4001f;
                        fltEnd = 10000000f;
                        break;
                    }
            }
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
            var view = CollectionViewSource.GetDefaultView(App.Context.Products.ToList());
            view.Filter = i => ((entities.Products)i).Product_cost < fltEnd && ((entities.Products)i).Product_cost > fltStart && ((entities.Products)i).Product_name.ToLower().Contains(searchStr.ToLower());
            listView.ItemsSource = view;
            SortDescription sd = new SortDescription("Product_cost", sortDirection);
            listView.Items.SortDescriptions.Clear();
            listView.Items.SortDescriptions.Add(sd);
            listView.Items.Refresh();
        }
    }
}
