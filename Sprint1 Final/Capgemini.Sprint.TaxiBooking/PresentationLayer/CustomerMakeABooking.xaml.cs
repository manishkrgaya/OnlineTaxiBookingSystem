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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaxiEntities;
using BLL;
using UserException;
using System.Globalization;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for CustomerMakeABooking.xaml
    /// </summary>
    public partial class CustomerMakeABooking : Window
    {
        public CustomerMakeABooking()
        {
            InitializeComponent();
        }
        private void BtnBook_Click(object sender, RoutedEventArgs e)
        {
            DateTime tripDate;
            string startTime, endTime;
            int result = 0;
            string strAddress = string.Empty;
            string valTime = string.Empty;


            if (string.IsNullOrEmpty(TxtTripDate.SelectedDate.ToString()))
            {
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "Please choose your Trip Date";
                return;
            }
            else
            {
                tripDate = Convert.ToDateTime(TxtTripDate.SelectedDate.Value);

            }
            ComboBoxItem typeItem = (ComboBoxItem)StartTimeSelection.SelectedItem;

            if (typeItem == null)
            {
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "Please choose your Trip Start Time";
                return;
            }
            else
            {
                startTime = typeItem.Content.ToString();
            }

            ComboBoxItem typeItemendTime = (ComboBoxItem)EndTimeSelection.SelectedItem;

            if (typeItemendTime == null)
            {
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "Please choose your Trip End Time";
                return;
            }
            else
            {
                endTime = typeItemendTime.Content.ToString();
            }
            CustomerValidation utility = new CustomerValidation();
            var fare = utility.CalculateFare(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime));

            CustomerValidation val = new CustomerValidation();

            if (val.ValidateName(TxtSourceAddress.Text))
                strAddress = TxtSourceAddress.Text.ToString().Trim();
            else
            {
                // MessageBox.Show("Please provide a valid address");
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "Please provide a valid Address";
                return;
            }
            if (val.ValidateName(TxtDestinationAddress.Text))
                strAddress = TxtDestinationAddress.Text.ToString().Trim();
            else
            {
                // MessageBox.Show("Please provide a valid address");
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "Please provide a valid Address";
                return;
            }



            CustomerBLL cust = new CustomerBLL();
            try
            {
                result = cust.AddNewBooking(ApplicationLogin.CustomerID, tripDate, Convert.ToDateTime(startTime), Convert.ToDateTime(endTime), TxtSourceAddress.Text, TxtDestinationAddress.Text, fare);
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
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Green);
                Lbl_CustomerRegistered.Content = "REGISTERED SUCCESSFULLY!!!!!";
            }
            else
            {
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "ERROR OCCUR REGEISTER AGAIN";
            }

        }

        private void bookaridewindow_Loaded(object sender, RoutedEventArgs e)
        {
            lblFare.Content = "";
        }

        private void EndTimeSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)StartTimeSelection.SelectedItem;
            string startTime = typeItem.Content.ToString();

            ComboBoxItem typeItemendTime = (ComboBoxItem)EndTimeSelection.SelectedItem;
            string endTime = typeItemendTime.Content.ToString();

            CustomerValidation utility = new CustomerValidation();
            if (!utility.ValidateTime(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime)))
            {
                Lbl_CustomerRegistered.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerRegistered.Content = "End time should be greater than start time";
                return;
            }

            var fare = utility.CalculateFare(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime));

            lblFare.Content = fare + " INR ";
        }

        private void WindowBooking_Loaded(object sender, RoutedEventArgs e)
        {
            TxtTripDate.DisplayDateStart = DateTime.Now;
            TxtTripDate.DisplayDateEnd = DateTime.Now.AddMonths(1);
        }
    }
}
