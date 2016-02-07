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
    public partial class NotInterface : UserControl
    {
        private Point MouseDownLocation;
        public NotInterface()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked))
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }
        private void NotInterface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void NotInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;

            }
        }

        private void NotInterface_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NotInterface_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void NotInterface_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void NotInterface_Load_1(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
