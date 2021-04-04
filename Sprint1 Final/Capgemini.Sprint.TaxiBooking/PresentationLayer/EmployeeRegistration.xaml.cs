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
    /// Interaction logic for EmployeeRegistration.xaml
    /// </summary>
    public partial class EmployeeRegistration : Window
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }
        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            EmployeeBLL employeeBLL = new EmployeeBLL();
            AdminValidations validate = new AdminValidations();
            if (!validate.ValidateName(Txt_EmployeeName.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "EmployeeName must have minimum 3 Characters";
                return;
            }


            if (!validate.ValidateMobileNo(Txt_PhoneNumber.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "Insert a correct 10 digit Phone Number";
                return;
            }

            if (!validate.ValidateEmail(Txt_EmailID.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "Insert a correct Email ID";
                return;
            }

            if (!validate.ValidateInput(Txt_Address.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "Insert Address";
                return;
            }

            if (!validate.ValidateLicenceNumber(Txt_DrivingLicenceNumber.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "Insert a Correct Licence Number";
                return;
            }

            if (!validate.ValidatePassword(Txt_EmployeePassword.Text))
            {
                Lbl_RegistrationValidate.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_RegistrationValidate.Content = "EmployeePassword must have minimum 3 Characters";
                return;
            }

            result = employeeBLL.AddNewEmployee(Txt_EmployeeName.Text, Txt_PhoneNumber.Text, Txt_EmailID.Text, Txt_Address.Text, Txt_DrivingLicenceNumber.Text, Txt_EmployeeLogIn.Text, Txt_EmployeePassword.Text);

            if (result > 0)
            {
                Lbl_Register.Foreground = new SolidColorBrush(Colors.Blue);
                Lbl_Register.Content = "Employee Registered";
            }

            else
            {
                Lbl_Register.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Register.Content = "Enter Correct Details";
            }
        }

        private void Btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            Txt_EmployeeName.Clear();
            Txt_PhoneNumber.Clear();
            Txt_EmailID.Clear();
            Txt_Address.Clear();
            Txt_DrivingLicenceNumber.Clear();
            Txt_EmployeeLogIn.Clear();
            Txt_EmployeePassword.Clear();
            Txt_EmployeeName.Focus();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            PasswordUpdate obj = new PasswordUpdate();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            UserDetails obj = new UserDetails();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            RosterManangement obj = new RosterManangement();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            ReportWindow obj = new ReportWindow();
            this.Close();
            obj.Show();
        }
    }
}
