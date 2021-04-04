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
    /// Interaction logic for CustomerCalculateFare.xaml
    /// </summary>
    public partial class CustomerCalculateFare : Window
    {
        public CustomerCalculateFare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            lblFare.Content = "";
            Lbl_CustomerCalculateFare.Content = "";
            string tripDate = string.Empty;
            string startTime = string.Empty;
            string endTime = string.Empty;

            if (string.IsNullOrEmpty(TxtTripDate.SelectedDate.ToString()))
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip Date";
                return;
            }
            else
            {
                tripDate = TxtTripDate.SelectedDate.Value.Date.ToShortDateString();

            }
            ComboBoxItem typeItem = (ComboBoxItem)StartTimeSelection.SelectedItem;
            if (typeItem == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip Start Time";
                return;
            }
            else
            {
                startTime = typeItem.Content.ToString();
            }

            ComboBoxItem typeItemendTime = (ComboBoxItem)EndTimeSelection.SelectedItem;

            if (typeItemendTime == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip End Time";
                return;
            }
            else
            {
                endTime = typeItemendTime.Content.ToString();
            }

            CustomerValidation utility = new CustomerValidation();
            if (!utility.ValidateTime(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime)))
            {
                // MessageBox.Show("Please provide a valid address");
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "End time should be greater than start time";
                return;
            }
            else
            {
                var fare = utility.CalculateFare(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime));
                lblFare.Content = fare + " INR ";
            }

        }

        private void EndTimeSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblFare.Content = "";
            Lbl_CustomerCalculateFare.Content = "";
            string startTime = string.Empty;
            string endTime = string.Empty;

            ComboBoxItem typeItem = (ComboBoxItem)StartTimeSelection.SelectedItem;
            if (typeItem == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip Start Time";
                return;
            }
            else
            {
                startTime = typeItem.Content.ToString();
            }

            ComboBoxItem typeItemendTime = (ComboBoxItem)EndTimeSelection.SelectedItem;

            if (typeItemendTime == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip End Time";
                return;
            }
            else
            {
                endTime = typeItemendTime.Content.ToString();
            }

            CustomerValidation utility = new CustomerValidation();
            if (!utility.ValidateTime(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime)))
            {
                // MessageBox.Show("Please provide a valid address");
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "End time should be greater than start time";
                return;
            }


        }

        private void StartTimeSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblFare.Content = "";
            Lbl_CustomerCalculateFare.Content = "";
            string startTime = string.Empty;
            string endTime = string.Empty;

            ComboBoxItem typeItem = (ComboBoxItem)StartTimeSelection.SelectedItem;
            if (typeItem == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip Start Time";
                return;
            }
            else
            {
                startTime = typeItem.Content.ToString();
            }

            ComboBoxItem typeItemendTime = (ComboBoxItem)EndTimeSelection.SelectedItem;

            if (typeItemendTime == null)
            {
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Please choose your Trip End Time";
                return;
            }
            else
            {
                endTime = typeItemendTime.Content.ToString();
            }

            CustomerValidation utility = new CustomerValidation();
            if (!utility.ValidateTime(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime)))
            {
                // MessageBox.Show("Please provide a valid address");
                Lbl_CustomerCalculateFare.Foreground = new SolidColorBrush(Colors.Red);
                Lbl_CustomerCalculateFare.Content = "Start time should be smaller than end time";
                return;
            }
        }
    }
}
