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
    public partial class AndInterface : GateInterface
    {
        private Point MouseDownLocation;
        public AndInterface()
        {
            InitializeComponent();
        }
         public override void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }

        public override void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
                radioButton1.Checked = true;
            else
                radioButton1.Checked = false;
        }

     

        private void AndInterface_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void AndInterface_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void AndInterface_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
            panel1.BackColor = Color.PaleGoldenrod;
        }

        private void AndInterface_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
            panel1.BackColor = Color.Transparent;

        }

        private void AndInterface_Load(object sender, EventArgs e)
        {

        }




        public Color Image { get; set; }
    }
}
