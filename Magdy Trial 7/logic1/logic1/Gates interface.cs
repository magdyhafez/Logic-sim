using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logic1
{
    public partial class AndInterface : UserControl
    {
        public AndInterface()
        {
            InitializeComponent();
        }

        private void Gates_interface_Load(object sender, EventArgs e)
        {
            
              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
               radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }
    }
}
