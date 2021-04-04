using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient;
using UserException;
using TaxiEntities;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for RosterManangement.xaml
    /// </summary>
    public partial class RosterManangement : Window
    {
        public RosterManangement()
        {
            InitializeComponent();
        }

        private void RosterManage_Loaded(object sender, RoutedEventArgs e)
        {
            RoasterBLL rbll = new RoasterBLL();
            List<EmployeeEntity> availEmployee = rbll.GetAvailableEmployees();
            Ddl_AvailableEmployees.DisplayMemberPath = "EmployeeName";
            Ddl_AvailableEmployees.SelectedValuePath = "EmployeeID";
            Ddl_AvailableEmployees.ItemsSource = availEmployee;
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
            UserDetails obj = new UserDetails();
            this.Close();
            obj.Show();
        }

        private void Ddl_AvailableEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Txt_Employee.Text = Ddl_AvailableEmployees.SelectedValue.ToString();
            Txt_Employee.IsEnabled = false;
        }

        private void Btn_CreateRoster_Click(object sender, RoutedEventArgs e)
        {

            int result = 0;
            AdminValidations validate = new AdminValidations();
            if (!validate.ValidateInput(Txt_Employee.Text))
            {
                Lbl_RosterValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RosterValidate.Content = "Select EmployeeID from Available Employees";
                return;
            }

            if (!validate.ValidateInput(Dt_FromDate.SelectedDate.ToString()))
            {
                Lbl_RosterValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RosterValidate.Content = "Enter FromDate";
                return;
            }

            if (!validate.ValidateInput(Dt_ToDate.SelectedDate.ToString()))
            {
                Lbl_RosterValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RosterValidate.Content = "Enter ToDate";
                return;
            }

            RoasterBLL bll = new RoasterBLL();
            try
            {
                result = bll.CreateRoster(int.Parse(Txt_Employee.Text), Dt_FromDate.SelectedDate.Value, Dt_ToDate.SelectedDate.Value);
            }

            catch (Exception)
            {
                Lbl_Roster.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Roster.Content = "Please enter the Date fields properly";
                return;
            }

            if (result > 0)
            {
                Lbl_Roster.Foreground = new SolidColorBrush(Colors.Blue);
                Lbl_Roster.Content = "Roster Updated";
            }

            else
            {
                Lbl_Roster.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Roster.Content = "Some Error Occured";
            }

        }

        private void WindowRoster_Loaded(object sender, RoutedEventArgs e)
        {
            Dt_FromDate.DisplayDateStart = DateTime.Now;
            Dt_FromDate.DisplayDateEnd = DateTime.Now.AddMonths(1);
            Dt_ToDate.DisplayDateStart = DateTime.Now.AddDays(1);
            Dt_ToDate.DisplayDateEnd = DateTime.Now.AddMonths(1);
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            ReportWindow obj = new ReportWindow();
            this.Close();
            obj.Show();
        }
    }
}
