using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using TaxiEntities;

namespace BLL
{
    public class BookingBLL
    {
        public List<Booking> GetDailyReport()
        {
            AdminDAL edal = new AdminDAL();
            var bookingss = edal.GetDailyReport();
            return bookingss;
        }

        public List<Booking> GetWeelkyOrMonthluReport(DateTime FromDate, DateTime ToDate)
        {
            AdminDAL edal = new AdminDAL();
            var bookingss = edal.GetWeelkyOrMonthlyReport(FromDate, ToDate);
            return bookingss;
        }
    }
}
