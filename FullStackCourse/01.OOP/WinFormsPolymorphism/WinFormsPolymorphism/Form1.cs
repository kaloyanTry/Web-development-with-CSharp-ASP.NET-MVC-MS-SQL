using System;
using System.Windows.Forms;

namespace WinFormsPolymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);

            string messageText = teacher.GetValues();
            txt1Parameter.Text = messageText;
        }

        private void btn2Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(2, "Kaloyan");

            string messageText = teacher.GetValues();
            txt1Parameter.Text = messageText;
        }

        private void btn3Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(3, "Kaloyan", 1340);

            string messageText = teacher.GetValues();
            txt1Parameter.Text = messageText;
        }

        private void btn4Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(4, "Kaloyan", 1340, "teacher");

            string messageText = teacher.GetValues();
            txt1Parameter.Text = messageText;
        }

        private void btnVirtual_Click(object sender, EventArgs e)
        {
            EmployeeOverRiding employee = new EmployeeOverRiding();
            string messageText = employee.SetValues(5, "Kaloyan", 1340);
            txt1Parameter.Text = messageText;
        }

        private void btnOverRiding_Click(object sender, EventArgs e)
        {
            TeacherOverRiding teacher = new TeacherOverRiding();
            string messageText = teacher.SetValues(5, "Kaloyan", 1340);
            txt1Parameter.Text = messageText;
        }
    }
}
