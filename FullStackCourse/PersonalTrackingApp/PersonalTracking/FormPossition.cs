using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FormPossition : Form
    {
        public FormPossition()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Department> departmentList = new List<Department>();

        private void FormPossition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDepartment.DataSource = departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPossition.Text.Trim() == "")
            {
                MessageBox.Show("Please, fill the possition name!");
            }
            else if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select a department!");
            }
            else
            {
                Position position = new Position();
                position.PositionName = txtPossition.Text;
                position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added.");
                txtPossition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }
    }
}
