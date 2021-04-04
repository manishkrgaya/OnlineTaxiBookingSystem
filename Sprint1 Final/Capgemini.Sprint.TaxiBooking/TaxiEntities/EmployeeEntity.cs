using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiEntities
{
    public class EmployeeEntity
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string Designation { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailID { get; set; }

        public string Address { get; set; }

        public string DrivingLicenseNumber { get; set; }
    }
}
