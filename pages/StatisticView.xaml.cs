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
    /// Логика взаимодействия для StatisticView.xaml
    /// </summary>
    public partial class StatisticView : Page
    {
        public StatisticView()
        {
            InitializeComponent();
            var deals = App.Context.Deals.ToList();
            var users = App.Context.Users.ToList();

            var completeDeals = deals.FindAll(i => i.Deal_status == 1);
            var sumCompleteDeals = 0f;
            for (int i = 0; i < completeDeals.Count; i++)
            {
                sumCompleteDeals += (completeDeals[i].Products.Product_cost + completeDeals[i].Deal_cost) * completeDeals[i].Deal_col;
            }

            var activeDeals = deals.FindAll(i => i.Deal_status == 2);
            var sumActiveDeals = 0f;
            for (int i = 0; i < activeDeals.Count; i++)
            {
                sumActiveDeals += (activeDeals[i].Products.Product_cost + activeDeals[i].Deal_cost) * activeDeals[i].Deal_col;
            }

            dealsTotalComp.Text = completeDeals.Count.ToString();
            sumDealsComp.Text = sumCompleteDeals.ToString() + " руб.";

            dealsTotal.Text = activeDeals.Count.ToString();
            sumDeals.Text = sumActiveDeals.ToString() + " руб.";

            var totalProd = 0f;
            for (int i = 0; i < deals.Count; i++)
            {
                totalProd += deals[i].Deal_col;
            }
            prodTotal.Text = totalProd.ToString() + " шт";

            var totalAdm = 0;
            var totalEmp = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].User_role == 1)
                {
                    totalAdm += 1;
                }
                else
                {
                    totalEmp += 1;
                }
            }
            adminsText.Text = "админы: " + totalAdm.ToString();
            employeeText.Text = "сотрудники: " + totalEmp.ToString();
        }
    }
}
