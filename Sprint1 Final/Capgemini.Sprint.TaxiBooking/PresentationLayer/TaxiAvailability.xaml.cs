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
    /// Interaction logic for TaxiAvailability.xaml
    /// </summary>
    public partial class TaxiAvailability : Window
    {
        public TaxiAvailability()
        {
            InitializeComponent();
        }

        EmployeeBLL bll = new EmployeeBLL();
        private void TaxiBookingWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var ebooking = bll.GetAllBookingAvailableDetails();
            BookingGrid.ItemsSource = ebooking;

            var etaxies = bll.GetTaxiDetails();
            TaxiGrid.ItemsSource = etaxies;
        }

        private void ButtonUpdateForBooking_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            EmployeeValidation val = new EmployeeValidation();
            if ((val.ValidateEmployeeID(TxtEmployeeID.Text)) && (val.ValidateTaxiBookingBookingID(TxtBookingID.Text)) && (val.ValidateTaxiBookingTaxiID(TxtTaxiID.Text)))
            {

                try
                {
                    result = bll.UpdateBooking(int.Parse(TxtEmployeeID.Text), int.Parse(TxtTaxiID.Text), int.Parse(TxtBookingID.Text));
                    if (result > 0)
                    {
                        LblMessage.Content = "Booked Sucessfully";
                    }
                    else
                    {
                        throw new TaxiBookingException("Booking Unsuccessful!");
                    }

                }
                catch (TaxiBookingException ex)
                {
                    LblMessage.Content = ex.Message;
                }
                catch (Exception ex)
                {
                    LblMessage.Content = ex.Message;
                }
            }
            else
            {
                LblMessage1.Content = "Field Can't Be Empty!";
            }
        }
    }
}
