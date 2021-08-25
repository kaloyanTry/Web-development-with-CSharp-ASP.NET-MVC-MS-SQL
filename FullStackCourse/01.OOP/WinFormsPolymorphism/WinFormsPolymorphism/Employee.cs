namespace WinFormsPolymorphism
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double EmplyeeSalary { get; set; }

        public void SetValues(int ID)
        {
            EmployeeID = ID;
        }

        public void SetValues(int ID, string employeeName)
        {
            EmployeeID = ID;
            EmployeeName = employeeName;
        }

        public void SetValues(int ID, string employeeName, double employeeSalary)
        {
            EmployeeID = ID;
            EmployeeName = employeeName;
            EmplyeeSalary = employeeSalary;
        }
    }
}
