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
using UserException;


namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Window
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void Btn_SignUp_Click(object sender, RoutedEventArgs e)
        {

            int result = 0;
            string strLogin = string.Empty;
            string strPassword = string.Empty;
            AdminBLL cust = new AdminBLL();

            CustomerValidation val = new CustomerValidation();
            //Name
            if (val.ValidateName(Txt_Login.Text))
            {
                strLogin = Txt_Login.Text.ToString().Trim();
            }
            else
            {
                MessageBox.Show("Please provide a valid Login ID");
                return;
            }
            //Phone Number
            if (val.ValidateName(Txt_Password.Password))
                strPassword = Txt_Password.Password.ToString().Trim();
            else
            {
                MessageBox.Show("Please provide a valid Password");
                return;
            }

            try
            {
                result = cust.AddNewUser(strLogin, strPassword, "CUSTOMER");
            }
            
            catch (TaxiBookingException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (result > 0)
            {
                //Set Role and LoginID
                ApplicationLogin.Role = "CUSTOMER";
                ApplicationLogin.LoginID = Txt_Login.Text.ToString().Trim();

                // Customer Homepage
                CustomerRoleButton obj = new CustomerRoleButton();
                this.Close();
                obj.Show();

            }
            else if (result == -1)
            {
                MessageBox.Show("User already exists, please choose another login name to register. ");
            }
            else
            {
                MessageBox.Show("Error occur");

            }


        }
       
    }
}
