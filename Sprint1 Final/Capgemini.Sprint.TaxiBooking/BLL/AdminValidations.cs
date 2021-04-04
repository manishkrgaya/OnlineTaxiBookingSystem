using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiEntities;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class AdminValidations
    {

        public bool ValidateInput(string input)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(input))
            {
                result = true;
            }
            return result;
        }
        public bool ValidateName(string name)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(name))
            {
                Regex reg = new Regex(@"^[a-zA-Z]{3,40}$");
                result = reg.IsMatch(name);
            }
            return result;
        }

        public bool ValidatePassword(string password)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(password))
            {
                Regex regex = new Regex(@"^[a-zA-Z]{3,30}");
                result = regex.IsMatch(password);

            }
            return result;
        }

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

        public bool ValidateLicenceNumber(string licence)
        {
            bool result = false;
            if (!string.IsNullOrWhiteSpace(licence))
            {
                Regex regex = new Regex(@"^[A-Z]{2}[0-9]{13}$");
                result = regex.IsMatch(licence);
            }
            return result;
        }
    }
}
