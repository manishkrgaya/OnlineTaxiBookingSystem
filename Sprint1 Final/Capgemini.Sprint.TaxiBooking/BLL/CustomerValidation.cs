using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class CustomerValidation
    {
        public bool ValidateMobileNo(string mobileNo)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(mobileNo))
            {
                Regex regex = new Regex(@"^[6-9]\d{9}$");
                result = regex.IsMatch(mobileNo);
            }
            return result;
        }
        public bool ValidateName(string name)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(name))
            {
                Regex regex = new Regex(@"^[a-zA-Z]{3,30}");
                result = regex.IsMatch(name);

            }
            return result;
        }
        public bool ValidateEmail(string email)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                result = regex.IsMatch(email);

            }
            return result;
        }

        public double CalculateFare(DateTime TripStartDateTime, DateTime TripEndDateTime)
        {
            double fare = 100;

            TimeSpan ts = TripEndDateTime - TripStartDateTime;
            fare = (ts.TotalHours) * 100;

            return fare;
        }
        public bool ValidateTime(DateTime StartTime, DateTime EndTime)
        {
            bool result = true;
            if (EndTime < StartTime)
            {
                result = false;

            }
            return result;
        }
    }
}
