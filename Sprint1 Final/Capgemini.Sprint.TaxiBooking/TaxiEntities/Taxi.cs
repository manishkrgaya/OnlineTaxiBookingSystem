﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiEntities
{
    public class Taxi
    {
        public int TaxiID { get; set; }

        public string TaxiModel { get; set; }

        public string Color { get; set; }

        public string RegistrationNumber { get; set; }

        public string TaxiType { get; set; }
    }
}
