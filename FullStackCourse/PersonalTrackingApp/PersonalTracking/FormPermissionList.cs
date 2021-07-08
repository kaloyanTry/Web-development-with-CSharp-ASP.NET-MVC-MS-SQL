using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FormPermissionList : Form
    {
        public FormPermissionList()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void txtDayAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormPermission frm = new FormPermission();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormPermission frm = new FormPermission();
            Hide();
            frm.ShowDialog();
            Visible = true;
        }
    }
}
