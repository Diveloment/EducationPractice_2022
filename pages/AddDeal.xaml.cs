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

namespace Providers.pages
{
    /// <summary>
    /// Логика взаимодействия для AddDeal.xaml
    /// </summary>
    public partial class AddDeal : Page
    {
        public AddDeal()
        {
            InitializeComponent();
            comboStatus.ItemsSource = App.Context.DealStatuses.ToList();
            comboStatus.DisplayMemberPath = "DealStatus_name";

            comboProduct.ItemsSource = App.Context.Products.ToList();
            comboProduct.DisplayMemberPath = "Product_name";

            comboProvider.ItemsSource = App.Context.Providers.ToList();
            comboProvider.DisplayMemberPath = "Provider_name";
            comboProvider.SelectedIndex = 0;

            UpdateList();

            comboSuperviser.ItemsSource = App.Context.Users.ToList();
            comboSuperviser.DisplayMemberPath = "User_login";

            comboType.ItemsSource = App.Context.DealTypes.ToList();
            comboType.DisplayMemberPath = "DealType_name";

            textDate.Text = DateTime.Today.ToString();
        }

        public void UpdateList()
        {
            var people = App.Context.Persons.ToList();

            comboContact.ItemsSource = people.FindAll(item => item.Person_provider == (comboProvider.SelectedItem as entities.Providers).Provider_id);
            comboContact.DisplayMemberPath = "Person_name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                entities.Deals deal = new entities.Deals()
                {
                    Deal_status = (comboStatus.SelectedItem as entities.DealStatuses).DealStatus_id,
                    Deal_contactPerson = (comboContact.SelectedItem as entities.Persons).Person_id,
                    Deal_product = (comboProduct.SelectedItem as entities.Products).Product_article,
                    Deal_provider = (comboProvider.SelectedItem as entities.Providers).Provider_id,
                    Deal_supervisor = (comboSuperviser.SelectedItem as entities.Users).User_id,
                    Deal_type = (comboType.SelectedItem as entities.DealTypes).DealType_id,
                    Deal_col = Convert.ToInt32(textCol.Text),
                    Deal_cost = Convert.ToInt32(textCost.Text),
                    Deal_name = textName.Text,
                    Deal_date = Convert.ToDateTime(textDate.Text),
                };

                App.Context.Deals.Add(deal);
                App.Context.SaveChanges();

                NavigationService.Navigate(new pages.DealsView());
            }
            catch
            {
                MessageBox.Show("Непредвиденная ошибка");
            }
        }

        private void providerChange(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }
    }
}
