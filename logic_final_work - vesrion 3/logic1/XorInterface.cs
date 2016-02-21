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
    public partial class XorInterface :GateInterface
    {
        private Point MouseDownLocation;
        public XorInterface()
        {
            InitializeComponent();
        }
        public override void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((!(checkBox1.Checked) && (checkBox2.Checked)) || (!(checkBox2.Checked) && (checkBox1.Checked)))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }

        public override void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((!(checkBox1.Checked) && (checkBox2.Checked)) || (!(checkBox2.Checked) && (checkBox1.Checked)))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }



        private void XorInterface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void XorInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;

            }
        }

        private void XorInterface_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
                 
    }
}
