using BLL;
using DAL;
using System;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please, fill the name field!");
            }
            else
            {
                Department department = new Department();

                if (!isUpdate)
                {
                    department.DepartmentName = txtDepartment.Text;
                    DepartmentBLL.AddDepartment(department);
                    MessageBox.Show("Department was added successfully!");
                    txtDepartment.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!!", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        department.ID = detail.ID;
                        department.DepartmentName = txtDepartment.Text;
                        DepartmentBLL.UpdateDepartment(department);
                        MessageBox.Show("Department was updated");
                        this.Close();

                    }
                }
            }
        }

        public bool isUpdate = false;
        public Department detail = new Department();

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtDepartment.Text = detail.DepartmentName;
            }
        }
    }
}
