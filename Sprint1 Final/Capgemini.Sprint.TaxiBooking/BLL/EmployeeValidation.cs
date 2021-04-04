using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeValidation
    {
        public bool ValidateEmployeeID(string EmployeeID)
        {

            if (!string.IsNullOrWhiteSpace((EmployeeID)))
            {
                return true;
            }
            return false;
        }

        public bool ValidateEmployeeID(int EmployeeID)
        {

            if (!string.IsNullOrWhiteSpace((EmployeeID.ToString())))
            {
                return true;
            }
            return false;
        }


        public bool ValidateTaxiBookingTaxiID(string TaxiID)
        {
            if (!string.IsNullOrWhiteSpace(TaxiID))
            {
                return true;
            }
            return false;
        }

        public bool ValidateTaxiBookingBookingID(string BookingID)
        {

            if (!string.IsNullOrWhiteSpace(BookingID))
            {
                return true;
            }
            return false;
        }
    }
}
