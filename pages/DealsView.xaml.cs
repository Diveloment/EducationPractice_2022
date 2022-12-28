﻿using System;
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
    /// Логика взаимодействия для DealsView.xaml
    /// </summary>
    public partial class DealsView : Page
    {
        private int fltStatus = 1;
        private int fltTypeStatus = 1;
        private string searchStr = "";
        private ListSortDirection sortDirection = ListSortDirection.Ascending;
        public DealsView()
        {
            InitializeComponent();
            var statuses = App.Context.DealStatuses.ToList();
            for (int i = 0; i < statuses.Count(); i++)
            {
                filterSelect.Items.Add(statuses[i]);
            }
            filterSelect.SelectedIndex = 0;

            orderSelect.ItemsSource = new List<string>() { "По дате", "По дате обратно" };
            orderSelect.SelectedIndex = 0;

            filterTypeSelect.ItemsSource = App.Context.DealTypes.ToList();
            filterTypeSelect.SelectedIndex = 0;
        }

        private void updateListView(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private void filter1Changed(object sender, SelectionChangedEventArgs e)
        {
            fltStatus = (filterSelect.SelectedItem as entities.DealStatuses).DealStatus_id;
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
            var view = CollectionViewSource.GetDefaultView(App.Context.Deals.ToList());
            view.Filter = i => (((entities.Deals)i).Deal_status == fltStatus || fltStatus == 0) && (((entities.Deals)i).Deal_type == fltTypeStatus || fltTypeStatus == 0) && ((entities.Deals)i).Deal_name.ToLower().Contains(searchStr.ToLower());
            listView.ItemsSource = view;
            SortDescription sd = new SortDescription("Deal_date", sortDirection);
            listView.Items.SortDescriptions.Clear();
            listView.Items.SortDescriptions.Add(sd);
            listView.Items.Refresh();
        }

        private void filter2Changed(object sender, SelectionChangedEventArgs e)
        {
            fltTypeStatus = (filterTypeSelect.SelectedItem as entities.DealTypes).DealType_id;
            UpdateList();
        }

        private void dealAddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pages.AddDeal());
        }
    }
}
