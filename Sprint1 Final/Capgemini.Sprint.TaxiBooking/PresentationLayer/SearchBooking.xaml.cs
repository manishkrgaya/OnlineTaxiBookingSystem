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
using UserException;
using BLL;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for SearchBooking.xaml
    /// </summary>
    public partial class SearchBooking : Window
    {
        public SearchBooking()
        {
            InitializeComponent();
        }

        EmployeeBLL bll = new EmployeeBLL();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookingGrid.ItemsSource = "";
            LblMessage.Content = "";
            try
            {
                if (dtTripDate.SelectedDate == null)
                {
                    throw new TaxiBookingException("Please Select a Date!");
                }
                if ((bll.GetAllBookingStatus(dtTripDate.SelectedDate.Value) == null))
                {
                    throw new TaxiBookingException("No Bookings Available");
                }
                else
                {

                    var ebooking = bll.GetAllBookingStatus(dtTripDate.SelectedDate.Value);
                    LblMessage.Content = "Booking is Available!";
                    BookingGrid.ItemsSource = ebooking;
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

        private void EmployeeSearchBooking_Loaded(object sender, RoutedEventArgs e)
        {
            dtTripDate.DisplayDateStart = DateTime.Now;
            dtTripDate.DisplayDateEnd = DateTime.Now.AddMonths(1);
        }
    }
}
