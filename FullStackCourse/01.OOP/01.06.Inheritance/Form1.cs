using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues();
            teacher.SetValuesTeacher();
            teacher.FindSalary();

            string allValues = "";
            allValues += teacher.Name + Environment.NewLine;
            allValues += teacher.Gender + Environment.NewLine;
            allValues += teacher.Age + Environment.NewLine;
            allValues += teacher.Branch + Environment.NewLine;
            allValues += teacher.Salary + Environment.NewLine;

            txtGetAll.Text = allValues;

        }
    }
}
