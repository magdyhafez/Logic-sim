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
    public partial class switch_input : UserControl
    {
        bool firstclick = true;
        public switch_input()
        {
            InitializeComponent();
            INIT();
        }
        private void ovalShape1_Click(object sender, EventArgs e)
        {
            if (firstclick)
            {
                ovalShape1.BackColor = Color.Yellow;
                firstclick = false;
            }
            else
            {
                ovalShape1.FillColor = Color.DimGray;
                firstclick = true;
            }
        }
        // we need a first point 
        private Point firstpoint = new Point();
        public void INIT()
        {
            ovalShape1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstpoint = Control.MousePosition;
                }
            };

            ovalShape1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    // create a temp point
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstpoint.X - temp.X, firstpoint.Y - temp.Y);
                    // apply value to object
                    ovalShape1.Location = new Point(ovalShape1.Location.X - res.X, ovalShape1.Location.Y - res.Y);
                    // update first point
                    firstpoint = temp;

                }
            };
        }

        private void switch_input_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void switch_input_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        
     
    }
}
