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
    /// Interaction logic for CustomerRoleButton.xaml
    /// </summary>
    public partial class CustomerRoleButton : Window
    {
        public CustomerRoleButton()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            AdminBLL objAdmin = new AdminBLL();
            var user = objAdmin.GetAllUser(ApplicationLogin.LoginID, ApplicationLogin.Password, ApplicationLogin.Role);

            if ((user != null) && (user.Count > 0))
            {
                foreach (var item in user)
                {
                   if((int)item.CustomerID > 0)
                    {
                        MessageBox.Show("You are already register. Thank You.");
                    }
                   else
                    {
                        CustomerRegistrations cust = new CustomerRegistrations();
                        cust.Show();
                    }
                    
                }
            }

           
            
        }

        private void CustomerRoleButton1_Loaded(object sender, RoutedEventArgs e)
        {
            lblUser.Content = "Welcome " + ApplicationLogin.LoginID.ToString() + " !!";
            if (ApplicationLogin.Role == "CUSTOMER")
            {
                lblRole.Background = Brushes.CornflowerBlue;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckHistory cust = new CheckHistory();
            cust.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerMakeABooking booking = new CustomerMakeABooking();
            booking.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CustomerCheckBookingStatus check = new CustomerCheckBookingStatus();
            check.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ApplicationLogin obj = new ApplicationLogin();
            this.Close();
            obj.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AvailableTaxi obj = new AvailableTaxi();
            obj.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CustomerCalculateFare obj = new CustomerCalculateFare();
            obj.Show();
        }
    }
}
