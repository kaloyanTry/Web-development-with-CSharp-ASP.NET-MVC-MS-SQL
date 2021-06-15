using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Employee
    {
        protected int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int EmployeeAge { get; set; }

        public string EmployeePosition { get; set; }
    }
}
