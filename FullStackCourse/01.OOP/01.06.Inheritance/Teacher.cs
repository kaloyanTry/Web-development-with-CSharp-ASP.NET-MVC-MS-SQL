using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    public class Teacher : Employee
    {
        public string Branch { get; set; }

        public void FindSalary()
        {
            Salary = 2000;
        }

        public void SetValuesTeacher()
        {
            Position = "Teacher";
            Branch = "Logic";
        }
    }
}