using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsPolymorphism
{
    public class EmployeeOverRiding
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double EmplyeeSalary { get; set; }
        public string EmployeePosition { get; set; }

        public virtual string SetValues(int ID, string employeeName, double employeeSalary)
        {
            EmployeeID = ID;
            EmployeeName = employeeName;
            EmplyeeSalary = employeeSalary;

            string textValues = "Employee ID: " + EmployeeID + Environment.NewLine;
            textValues += "Employee Name: " + EmployeeName + Environment.NewLine;
            textValues += "Employee Salary: " + EmplyeeSalary + Environment.NewLine;

            return textValues;
        }
    }
}
