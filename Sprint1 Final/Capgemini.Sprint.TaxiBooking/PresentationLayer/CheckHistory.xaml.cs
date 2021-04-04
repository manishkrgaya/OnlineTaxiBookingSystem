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
using TaxiEntities;
using BLL;
using System.Globalization;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for CheckHistory.xaml
    /// </summary>
    public partial class CheckHistory : Window
    {
        
        public CheckHistory()
        {
            InitializeComponent();
        }

        private void BtnSearchEmployee_Click(object sender, RoutedEventArgs e)
        {
            DateTime bookingDate = BookingDate.SelectedDate.Value;
            var bDate = Convert.ToDateTime(bookingDate);
            //BDate = Convert.ToDateTime(DateTime.ParseExact(BDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

            CustomerBLL bLL = new CustomerBLL();
            var emp = bLL.GetAllEmployee(bDate, ApplicationLogin.CustomerID);
            GridEmployeeDetails.ItemsSource = emp.DefaultView;
        }
    }
}
