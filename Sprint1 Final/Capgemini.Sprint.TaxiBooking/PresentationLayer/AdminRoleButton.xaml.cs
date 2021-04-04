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

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for AdminRoleButton.xaml
    /// </summary>
    public partial class AdminRoleButton : Window
    {
        public AdminRoleButton()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            lblUser.Content = "Welcome " + ApplicationLogin.LoginID.ToString() + " !!";
            if (ApplicationLogin.Role == "ADMIN")
            {
                lblRole.Background = Brushes.OrangeRed;
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
            EmployeeRegistration obj = new EmployeeRegistration();
            this.Close();
            obj.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PasswordUpdate obj = new PasswordUpdate();
            this.Close();
            obj.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RosterManangement obj = new RosterManangement();
            this.Close();
            obj.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UserDetails obj = new UserDetails();
            this.Close();
            obj.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AvailableTaxi obj = new AvailableTaxi();
            obj.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ReportWindow obj = new ReportWindow();
            this.Close();
            obj.Show();
        }
    }
}
