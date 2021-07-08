using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormDepartmentList : Form
    {
        public FormDepartmentList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormDepartment frm = new FormDepartment();
            Hide();
            frm.ShowDialog();
            Visible = true;
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ID == 0)
                MessageBox.Show("Please select a department from table");
            else
            {
                FormDepartment frm = new FormDepartment();
                frm.isUpdate = true;
                frm.detail = detail;
                Hide();
                frm.ShowDialog();
                Visible = true;
                list = DepartmentBLL.GetDepartments();
                dataGridView1.DataSource = list;
            }
        }

        List<Department> list = new List<Department>();
        public Department detail = new Department();

        private void FormDepartmentList_Load(object sender, EventArgs e)
        {
            list = DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.DepartmentName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this Department", "Warning!!", MessageBoxButtons.YesNo);
            if(DialogResult.Yes==result)
            {
                DepartmentBLL.DeleteDepartment(detail.ID);
                MessageBox.Show("Department was Deleted");

                list = DepartmentBLL.GetDepartments();
                dataGridView1.DataSource = list;
            }
        }
    }
}
