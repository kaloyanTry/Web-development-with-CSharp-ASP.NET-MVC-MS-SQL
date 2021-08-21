using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormInterface : Form
    {
        public FormInterface()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();
            dell.GetLaptops();
            dell.GetMark();

            string textValue = "Name: " + dell.Name + Environment.NewLine;
            textValue += "Price: " + dell.Price + Environment.NewLine;
            textValue += "Mark: " + dell.Mark + Environment.NewLine;

            txtShow.Text = textValue;
        }
    }
}
