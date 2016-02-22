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
    public partial class input : UserControl
    {
        private Point MouseDownLocation;
        bool firstclick = true;
        public input()
        {
            InitializeComponent();
        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            if (firstclick)
            {
                ovalShape1.FillColor = Color.Yellow;
                firstclick = false;
            }
            else
            {
                ovalShape1.FillColor = Color.Gray;
                firstclick = true;
            }
        }
        
        private void input_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void input_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void input_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void input_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;

            }
        }

    }
}
