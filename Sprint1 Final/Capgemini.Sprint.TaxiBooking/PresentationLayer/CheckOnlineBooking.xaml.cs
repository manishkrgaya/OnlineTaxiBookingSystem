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
    /// Interaction logic for CheckOnlineBooking.xaml
    /// </summary>
    public partial class CheckOnlineBooking : Window
    {
        public CheckOnlineBooking()
        {
            InitializeComponent();
        }

        //private void Click_Roaster(object sender, SelectionChangedEventArgs e)
        //{
        //    EmployeeBLL bll = new EmployeeBLL();
        //    var emproaster = bll.GetEmployeeRoasters();
        //    RoasterGrid.ItemsSource = emproaster;

        //}

        //private void Click_Booking(object sender, SelectionChangedEventArgs e)
        //{
        //    EmployeeBLL bll = new EmployeeBLL();
        //    var ebooking = bll.GetAllBookingStatus();
        //    BookingGrid.ItemsSource = ebooking;


        //}
        EmployeeBLL bll = new EmployeeBLL();

        //public string BookingID { get; private set; }
        //public string TripDate { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // DateTime tripdate = Convert.ToDateTime( DateTime.ParseExact(TxtTripDate.Text.ToString().Trim(),"dd/mm/yyyy",CultureInfoIetfLanguageTagConverter.).Date;

           // var ebooking = bll.GetAllBookingStatus(tripdate);
           // BookingGrid.ItemsSource = ebooking;
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var emproaster = bll.GetEmployeeRoasters();
        //    RoasterGrid.ItemsSource = emproaster;


        //}
    }
}
