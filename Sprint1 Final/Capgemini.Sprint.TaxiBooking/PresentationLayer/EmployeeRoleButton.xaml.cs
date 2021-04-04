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
using System.Windows.Shapes;
using BLL;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for EmployeeRoleButton.xaml
    /// </summary>
    public partial class EmployeeRoleButton : Window
    {
        public EmployeeRoleButton()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblUser.Content = "Welcome " + ApplicationLogin.LoginID.ToString() + " !!";
            if (ApplicationLogin.Role == "EMPLOYEE")
            {
                lblRole.Background = Brushes.GreenYellow;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationLogin obj = new ApplicationLogin();
            this.Close();
            obj.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SearchBooking obj = new SearchBooking();
         
            obj.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RosterDetail obj = new RosterDetail();
           
            obj.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TaxiAvailability obj = new TaxiAvailability();
            
            obj.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AvailableTaxi obj = new AvailableTaxi();
            obj.Show();
        }
    }
}
