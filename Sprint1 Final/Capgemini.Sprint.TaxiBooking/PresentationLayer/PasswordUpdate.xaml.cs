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
    /// Interaction logic for PasswordUpdate.xaml
    /// </summary>
    public partial class PasswordUpdate : Window
    {
        public PasswordUpdate()
        {
            InitializeComponent();
        }

        private void Btn_UpdatePassword_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            AdminValidations validate = new AdminValidations();
            if (!validate.ValidatePassword(Txt_Password.Text))
            {
                Lbl_UpdatePassword.Content = "Password must contain minimum 3 characters and maximum 40 characters";
                return;
            }

            EmployeeBLL employeeBLL = new EmployeeBLL();
            result = employeeBLL.ChangeUsersPassword(Txt_LoginID.Text, Txt_Password.Text);

            if (result > 0)
            {
                Lbl_UpdatePassword.Foreground = new SolidColorBrush(Colors.Blue);
                Lbl_UpdatePassword.Content = "Password Updated";
            }

            else
            {
                Lbl_UpdatePassword.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_UpdatePassword.Content = "This Login ID doesn't exist";
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            EmployeeRegistration obj = new EmployeeRegistration();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            RosterManangement obj = new RosterManangement();
            this.Close();
            obj.Show();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            UserDetails obj = new UserDetails();
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
