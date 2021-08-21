using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    public class Employee : Human
    {
        protected string Position { get; set; }

        public double Salary { get; set; }

        public void SetValues()
        {
            Name = "Kaloyan";
            ID = 1001;
            Gender = 'M';
            Age = 43;
        }
    }
}
