using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Please, fill the username and password!");
            }
            else
            {
                List<Employee> employeeList = EmployeeBLL.GetEmployees(Convert.ToInt32(txtUserNo.Text), txtPass.Text);

                if (employeeList.Count == 0)
                {
                    MessageBox.Show("Please, control your information");
                }
                else
                {
                    Employee employee = new Employee();
                    employee = employeeList.First();
                    UserStatic.EmployeeID = employee.ID;
                    UserStatic.UserNo = employee.UserNumber;
                    UserStatic.isAdmin = Convert.ToBoolean(employee.isAdmin);

                    FormMain frm = new FormMain();
                    Hide();
                    frm.ShowDialog();
                }
            }
        }
    }
}
