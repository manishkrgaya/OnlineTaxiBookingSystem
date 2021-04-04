using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiEntities
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int? EmployeeID { get; set; }

        public int CustomerID { get; set; }

        public int? TaxiID { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime TripDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string SourceAddress { get; set; }

        public string DestinationAddress { get; set; }

        public double Fare { get; set; }
    }
}
