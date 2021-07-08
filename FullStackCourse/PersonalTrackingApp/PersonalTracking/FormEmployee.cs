using BLL;
using DAL;
using DAL.DTO;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        EmployeeDTO dto = new EmployeeDTO();

        public EmployeeDetailDTO detail = new EmployeeDetailDTO();
        public bool isUpdate = false;
        string imagepath = "";
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetAll();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            if (isUpdate)
            {
                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                txtUserNo.Text = detail.UserNo.ToString();
                txtPass.Text = detail.Password;
                chAdmin.Checked = Convert.ToBoolean(detail.isAdmin);
                txtAddress.Text = detail.Address;
                dateTimePicker1.Value = Convert.ToDateTime(detail.BirthDay);
                cmbDepartment.SelectedValue = detail.DepartmentID;
                cmbPosition.SelectedValue = detail.PositionID;
                txtSalary.Text = detail.Salary.ToString();
                imagepath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                pictureBox1.ImageLocation = imagepath;
                if (!UserStatic.isAdmin)
                {
                    chAdmin.Enabled = false;
                    txtUserNo.Enabled = false;
                    txtSalary.Enabled = false;
                    cmbDepartment.Enabled = false;
                    cmbPosition.Enabled = false;
                }
            }
        }

        bool combofull = false;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }
        string fileName = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = "";
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
                MessageBox.Show("User no is Empty");
            else if (txtPass.Text.Trim() == "")
                MessageBox.Show("Password is Empty");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("Name is Empty");
            else if (txtSurname.Text.Trim() == "")
                MessageBox.Show("Surname is Empty");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is Empty");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Select a department");
            else if (cmbPosition.SelectedIndex == -1)
                MessageBox.Show("Select a position");
            else
            {
                if (!isUpdate)
                {
                    if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                        MessageBox.Show("This user no is used by another employee please change ");
                    else
                    {
                        Employee employee = new Employee();
                        employee.UserNumber = Convert.ToInt32(txtUserNo.Text);
                        employee.Password = txtPass.Text;
                        employee.isAdmin = chAdmin.Checked;
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Address = txtAddress.Text;
                        employee.BirthDay = dateTimePicker1.Value;
                        employee.ImagePath = fileName;
                        EmployeeBLL.AddEmployee(employee);
                        File.Copy(txtImagePath.Text, @"images\\" + fileName);
                        MessageBox.Show("Employee was added");
                        txtUserNo.Clear();
                        txtPass.Clear();
                        chAdmin.Checked = false;
                        txtName.Clear();
                        txtSurname.Clear();
                        txtSalary.Clear();
                        txtAddress.Clear();
                        txtImagePath.Clear();
                        pictureBox1.Image = null;
                        combofull = false;
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.Positions;
                        cmbPosition.SelectedIndex = -1;
                        combofull = true;
                        dateTimePicker1.Value = DateTime.Today;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("are you sure?", "Warning", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Employee employee = new Employee();
                        if (txtImagePath.Text != imagepath)
                        {
                            if (File.Exists(@"images\\" + detail.ImagePath))
                                File.Delete(@"images\\" + detail.ImagePath);
                            File.Copy(txtImagePath.Text, @"images\\" + fileName);
                            employee.ImagePath = fileName;
                        }
                        else
                            employee.ImagePath = detail.ImagePath;

                        employee.ID = detail.EmployeeID;
                        employee.UserNumber = Convert.ToInt32(txtUserNo.Text);
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.isAdmin = chAdmin.Checked;
                        employee.Password = txtPass.Text;
                        employee.Address = txtAddress.Text;
                        employee.BirthDay = dateTimePicker1.Value;
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        EmployeeBLL.UpdateEmployee(employee);
                        MessageBox.Show("Employee was updated");
                        this.Close();
                    }
                }
            }
        }


        private bool isUnique = false;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
            {
                MessageBox.Show("UserNo is Empty");
            }
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));

                if (!isUnique)
                {
                    MessageBox.Show("This UserNo is used by another employee, please change it.");
                }
                else
                {
                    MessageBox.Show("This UserNo is usable");
                }
            }
        }
    }
}
