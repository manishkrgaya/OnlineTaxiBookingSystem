using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiEntities
{
    public class EmployeeRoaster
    {
        public int RosterID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime InTime { get; set; }

        public DateTime OutTime { get; set; }
    }
}
