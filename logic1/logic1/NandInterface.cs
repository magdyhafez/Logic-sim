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
    public partial class NandInterface : UserControl
    {
        private Point MouseDownLocation;
        public NandInterface()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked && checkBox2.Checked))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked && checkBox2.Checked))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }



        private void NandInterface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void NandInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;

            }
        }

        private void NandInterface_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NandInterface_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void NandInterface_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
