using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DataConnection
    {

        public static string GetConnectionString()
        {
            
            return "Data Source=DESKTOP-9C3UBU4; Initial Catalog=TaxiSvs; Integrated Security=true";

        }
    }
}
