using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;

namespace PersonalTracking
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if(!UserStatic.isAdmin)
            {
                EmployeeDTO dto = EmployeeBLL.GetAll();
                EmployeeDetailDTO detail = dto.Employees.First(x => x.EmployeeID == UserStatic.EmployeeID);
                FormEmployee frm = new FormEmployee();
                frm.detail = detail;
                frm.isUpdate = true;
                Hide();
                frm.ShowDialog();
                Visible = true;
            }
            else
            {
                FormEmployeeList frm = new FormEmployeeList();
                Hide();
                frm.ShowDialog();
                Visible = true;
            }
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            FormTaskList frm = new FormTaskList();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            FormSalaryList frm = new FormSalaryList();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            FormPermissionList frm = new FormPermissionList();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            FormDepartmentList frm = new FormDepartmentList();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            FormPossitionList frm = new FormPossitionList();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            Hide();
            frm.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                btnDepartment.Visible = false;
                btnPosition.Visible = false;
                btnLogOut.Location = new Point(160, 140);
                btnExit.Location = new Point(310, 140);
            }

        }
    }
}
