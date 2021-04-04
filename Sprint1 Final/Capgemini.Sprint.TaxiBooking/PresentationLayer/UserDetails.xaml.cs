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
    /// Interaction logic for UserDetails.xaml
    /// </summary>
    public partial class UserDetails : Window
    {
        public UserDetails()
        {
            InitializeComponent();
        }

       

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            EmployeeRegistration obj = new EmployeeRegistration();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            PasswordUpdate obj = new PasswordUpdate();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            RosterManangement obj = new RosterManangement();
            this.Close();
            obj.Show();
        }

        private void UserDetails1_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            var custDetails = customerBLL.GetCustomersDetails();
            CustomerGrid.ItemsSource = custDetails;

            EmployeeBLL employeeBLL = new EmployeeBLL();
            var empDetails = employeeBLL.GetEmployeesDetails();
            EmployeeGrid.ItemsSource = empDetails;
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            ReportWindow obj = new ReportWindow();
            this.Close();
            obj.Show();
        }
    }
}
