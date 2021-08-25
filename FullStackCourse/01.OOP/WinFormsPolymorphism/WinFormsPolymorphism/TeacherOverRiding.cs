using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsPolymorphism
{
    public class TeacherOverRiding : EmployeeOverRiding
    {
        override public string SetValues(int ID, string employeeName, double employeeSalary)
        {
            EmployeeID = ID;
            EmployeeName = employeeName;
            EmplyeeSalary = employeeSalary;
            EmployeePosition = "teacher";

            string textValues = "Employee ID: " + EmployeeID + Environment.NewLine;
            textValues += "Employee Name: " + EmployeeName + Environment.NewLine;
            textValues += "Employee Salary: " + EmplyeeSalary + Environment.NewLine;
            textValues += "Employee Position: " + EmployeePosition + Environment.NewLine;

            return textValues;
        }
    }
}
