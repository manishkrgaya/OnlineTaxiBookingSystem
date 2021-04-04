using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for CustomerCheckBookingStatus.xaml
    /// </summary>
    public partial class CustomerCheckBookingStatus : Window
    {
        public CustomerCheckBookingStatus()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime sDate = StartDate.SelectedDate.Value;
            //startDate = Convert.ToDateTime(DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
            var startDate = Convert.ToDateTime(sDate);
            DateTime eDate = EndDate.SelectedDate.Value;
            //endDate = Convert.ToDateTime(DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
            var endDate = Convert.ToDateTime(eDate);
            CustomerBLL bLL = new CustomerBLL();
            try
            {
                var emp = bLL.GetBookings(startDate, endDate, ApplicationLogin.CustomerID);
                bookingGrid.ItemsSource = emp;
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

        }
    }
}
