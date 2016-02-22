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
    public partial class XnorInterface : GateInterface
    {
        private Point MouseDownLocation;
        public XnorInterface()
        {
            InitializeComponent();
        }
        public override void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!((!(checkBox1.Checked) && (checkBox2.Checked)) || (!(checkBox2.Checked) && (checkBox1.Checked))))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }

        public override void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!((!(checkBox1.Checked) && (checkBox2.Checked)) || (!(checkBox2.Checked) && (checkBox1.Checked))))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }



        private void XnorInterface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void XnorInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;

            }
        }
        private void XnorInterface_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void XnorInterface_Load_1(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
