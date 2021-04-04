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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void ReportWindows_Loaded(object sender, RoutedEventArgs e)
        {
            dtFromDate.DisplayDateStart = DateTime.Now;
            dtToDate.DisplayDateStart = DateTime.Now.AddDays(1);
            dtFromDate.IsEnabled = false;
            dtToDate.IsEnabled = false;
            Gobtn.IsEnabled = false;
        }

         BookingBLL bll = new BookingBLL();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ebookingg = bll.GetWeelkyOrMonthluReport(dtFromDate.SelectedDate.Value, dtToDate.SelectedDate.Value);
                if (ebookingg == null)
                {
                    throw new TaxiBookingException("No Bookings Are Done on This Date!");
                }

                else
                {
                    ReportGrid.ItemsSource = ebookingg;
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

        private void RadioWeeklyOrMonthly_Checked_1(object sender, RoutedEventArgs e)
        {
            LblMessage.Content = "";
            dtFromDate.IsEnabled = true;
            dtToDate.IsEnabled = true;
            Gobtn.IsEnabled = true;
            ReportGrid.ItemsSource = "";
        }

        private void RadioDaily_Checked_1(object sender, RoutedEventArgs e)
        {
            dtFromDate.IsEnabled = false;
            dtToDate.IsEnabled = false;
            Gobtn.IsEnabled = false;
            ReportGrid.ItemsSource = "";
            LblMessage.Content = "";
            try
            {
                var ebooking = bll.GetDailyReport();
                ReportGrid.ItemsSource = ebooking;
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
    }
}
