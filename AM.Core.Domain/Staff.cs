﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public float Salary { get; set; }

        public override string GetPassengerType()
        {
            return base.GetPassengerType() + ", I'm a Staff ";
        }

    }
}
