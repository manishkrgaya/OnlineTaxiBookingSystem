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
using TaxiEntities;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for ApplicationLogin.xaml
    /// </summary>
    public partial class ApplicationLogin : Window
    {
        public static string Role = string.Empty;
        public static string LoginID = string.Empty;
        public static string Password = string.Empty;
        public static int EmployeeID = 0;
        public static int CustomerID = 0;

        string UserInput_LoginID = string.Empty;
        string UserInput_Password = string.Empty;
        string UserInput_Role = string.Empty;
        public ApplicationLogin()
        {
            InitializeComponent();
        }

        private void Btn_SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (Txt_Login.Text == "Admin" && Txt_Password.Password.ToString().Trim() == "admin1234" && Role == "ADMIN")
            {
                Role = "ADMIN";
                LoginID = "Admin";
                AdminRoleButton obj = new AdminRoleButton();
                this.Close();
                obj.Show();
            }

            else if (Ddl_RoleSelection.SelectedValue.ToString() == "EMPLOYEE")
            {
                //Check the LoginID and Password Exists from the Users Table --> Allow Employee to Proceed further
               
                UserInput_LoginID = Txt_Login.Text.ToString().Trim();
                UserInput_Password = Txt_Password.Password.ToString().Trim();
                UserInput_Role = Ddl_RoleSelection.SelectedValue.ToString();
                AdminBLL objAdmin = new AdminBLL();
                var user = objAdmin.GetAllUser(UserInput_LoginID, UserInput_Password, UserInput_Role);

                if (user.Count > 0)
                {
                    foreach (var item in user)
                    {
                        LoginID = item.LoginID.ToString();
                        Role = item.Role.ToString();
                        EmployeeID = (int)item.EmployeeId;
                        Password = item.Password.ToString();

                        if (EmployeeID >= 0)
                        {
                            // Check Login Details and Open Employee Controls
                            EmployeeRoleButton obj = new EmployeeRoleButton();
                            this.Close();
                            obj.Show();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please verify your Log in details");
                }
                                
            }

            else
            {             
                UserInput_LoginID = Txt_Login.Text.ToString().Trim();
                UserInput_Password = Txt_Password.Password.ToString().Trim();
                UserInput_Role = Ddl_RoleSelection.SelectedValue.ToString();
                AdminBLL objAdmin = new AdminBLL();
                var user = objAdmin.GetAllUser(UserInput_LoginID, UserInput_Password, UserInput_Role);
                
                if ((user != null) && (user.Count > 0))
                {
                    foreach (var item in user)
                    {
                        LoginID = item.LoginID.ToString();
                        Role = item.Role.ToString();
                        CustomerID = (int)item.CustomerID;
                        Password = item.Password.ToString();

                        if (CustomerID >= 0)
                        {
                            // Customer Homepage
                            CustomerRoleButton obj = new CustomerRoleButton();
                            this.Close();
                            obj.Show();
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Please verify your Log in details");
                }
                
            }
        }

        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterUser obj = new RegisterUser();
            this.Close();
            obj.Show();
        }

        private void Ddl_RoleSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Ddl_RoleSelection.SelectedValue.ToString() == "ADMIN")
            {
                Role = "ADMIN";
                LoginID = "ADMIN";

                Txt_Login.Text = "Admin";
                Txt_Password.Password = "admin1234";
                Txt_Login.IsEnabled = false;
                Txt_Password.IsEnabled = false;
            }
            else if (Ddl_RoleSelection.SelectedValue.ToString() == "EMPLOYEE")
            {
                Role = "EMPLOYEE";
                Txt_Login.Focus();
                Txt_Login.IsEnabled = true;
                Txt_Password.IsEnabled = true;
            }
            else {
                Role = "CUSTOMER";
                Txt_Login.Focus();
                Txt_Login.IsEnabled = true;
                Txt_Password.IsEnabled = true;
            }
        }
    }
}
