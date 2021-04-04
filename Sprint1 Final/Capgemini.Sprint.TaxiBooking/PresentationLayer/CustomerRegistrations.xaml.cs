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
using UserException;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for CustomerRegistrations.xaml
    /// </summary>
    public partial class CustomerRegistrations : Window
    {
        public CustomerRegistrations()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            #region VARIABLES DECLARATION
            int result = 0;
            string strName = string.Empty;
            string strPhoneNumber = string.Empty;
            string strEmailID = string.Empty;
            string strAddress = string.Empty;
            #endregion

            #region VALIDATION
            //Validation
            CustomerBLL cust = new CustomerBLL();
            CustomerValidation val = new CustomerValidation();
            //Name
            if (val.ValidateName(TxtName.Text))
            {
                strName = TxtName.Text.ToString().Trim();
            }
            else
            {
                Lbl_Validation.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Validation.Content = "Please provide a valid Name";
                return;
            }
            //Phone Number
            if (val.ValidateMobileNo(TxtPhoneNumber.Text))
                strPhoneNumber = TxtPhoneNumber.Text.ToString().Trim();
            else
            {
                Lbl_Validation.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Validation.Content = "Please provide a valid Phone Number";
                return;
            }
            //EMailID
            if (val.ValidateEmail(TxtEmailId.Text))
                strEmailID = TxtEmailId.Text.ToString().Trim();
            else
            {
                Lbl_Validation.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Validation.Content = "Please provide a valid Email ID";
                return;
            }
            //Address
            if (val.ValidateName(TxtAddress.Text))
                strAddress = TxtAddress.Text.ToString().Trim();
            else
            {
                Lbl_Validation.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_Validation.Content = "Please provide a valid address";
                return;
            }
            #endregion

            #region ADD NEW CUSTOMER
            try
            {
                result = cust.AddNewCustomer(strName, strPhoneNumber, strEmailID, strAddress, ApplicationLogin.LoginID);
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
                // MessageBox.Show("Result created");
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Green);
                Lbl_CustomerRegistered.Content = "REGISTERED SUCCESSFULLY!!!!!";
            }
            else
            {
                // MessageBox.Show("Error occur");
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "ERROR OCCUR REGEISTER AGAIN";
               
            }

            #endregion

        }

        private void CustomerRegistration_Closed(object sender, EventArgs e)
        {
            //CustomerRoleButton obj = new CustomerRoleButton();
            //obj.Show();
        }
    }
}
