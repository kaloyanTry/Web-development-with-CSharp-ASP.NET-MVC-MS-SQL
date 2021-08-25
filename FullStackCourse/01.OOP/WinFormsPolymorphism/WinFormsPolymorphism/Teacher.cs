using System;

namespace WinFormsPolymorphism
{
    public class Teacher : Employee
    {
        public string EmployeePosition { get; set; }

        public void SetValues(int ID, string employeeName, double employeeSalary, string employeePosition)
        {
            EmployeeID = ID;
            EmployeeName = employeeName;
            EmplyeeSalary = employeeSalary;
            EmployeePosition = employeePosition;
        }

        public string GetValues()
        {
            string textValues = "Employee ID: " + EmployeeID + Environment.NewLine;
            textValues += "Employee Name: " + EmployeeName + Environment.NewLine;
            textValues += "Employee Salary: " + EmplyeeSalary + Environment.NewLine;
            textValues += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return textValues;
        }
    }
}
