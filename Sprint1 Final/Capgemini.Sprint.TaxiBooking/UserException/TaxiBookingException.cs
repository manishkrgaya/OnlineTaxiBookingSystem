using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserException
{
    public class TaxiBookingException : Exception
    {
        public TaxiBookingException() : base() { }
        public TaxiBookingException(string message) : base(message) { }
        public TaxiBookingException(string message, Exception exception) : base(message, exception) { }
    }
}
