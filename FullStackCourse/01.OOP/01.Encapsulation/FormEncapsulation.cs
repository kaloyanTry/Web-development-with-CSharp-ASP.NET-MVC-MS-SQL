using System;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class FormEncapsulation : Form
    {
        public FormEncapsulation()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();

            employeeDetails.EmployeeName = txtEmployeeName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employeeDetails.EmployeePosition = txtEmployeePosition.Text;

            FormEmployeeDetails form = new FormEmployeeDetails();

            form.labelName.Text = employeeDetails.EmployeeName;
            form.labelAge.Text = employeeDetails.EmployeeAge.ToString();
            form.labelPosition.Text = employeeDetails.EmployeePosition;

            form.ShowDialog();
        }
    }
}
