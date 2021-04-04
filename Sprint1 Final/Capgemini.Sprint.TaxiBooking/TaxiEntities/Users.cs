using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiEntities
{
   public class Users
    {
        public string  LoginID { get; set; }

        public  string Password { get; set; }

        public  int? EmployeeId { get; set; }

        public  int? CustomerID { get; set; }

        public  string Role { get; set; }
    }
}
