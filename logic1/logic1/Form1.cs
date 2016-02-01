using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logic1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void AND_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);
            g.DrawArc(p, w / 2 , h / 2 , 100, 80, -90, 180);
            g.DrawLine(p, w / 2 + 50, h / 2  , w/2 +50 , h/2 +80);
            g.DrawLine(p, w / 2 , h / 2 +20, w / 2 + 50, h / 2 + 20);
            g.DrawLine(p, w / 2 , h / 2+60, w / 2 + 50, h / 2 + 60);
            g.DrawLine(p, w / 2 + 100, h / 2 +40, w / 2 + 120, h / 2 + 40);
            
            
        }

        private void OR_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);
  
            g.DrawArc(p, w / 2, h / 2, 160, 70, -90, 180);
            g.DrawArc(p, w / 2+40, h / 2, 80, 70, -90, 180);
            g.DrawLine(p, w / 2 +63, h / 2 + 15, w / 2 + 113, h / 2 + 15);
            g.DrawLine(p, w / 2+63, h / 2 + 55, w / 2 + 113, h / 2 + 55);
            g.DrawLine(p, w / 2 +160, h / 2 +35, w / 2 +190, h / 2+35 );
            p.Dispose();
        }

        private void NOR_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);

            g.DrawArc(p, w / 2, h / 2, 160, 70, -90, 180);
            g.DrawArc(p, w / 2 + 40, h / 2, 80, 70, -90, 180);
            g.DrawLine(p, w / 2 + 63, h / 2 + 15, w / 2 + 113, h / 2 + 15);
            g.DrawLine(p, w / 2 + 63, h / 2 + 55, w / 2 + 113, h / 2 + 55);
            g.DrawEllipse(Pens.Blue, w / 2 + 160, h / 2 + 30, 10, 10);
            g.DrawLine(p, w / 2 + 170, h / 2 + 35, w / 2 + 190, h / 2 + 35);
            p.Dispose();
        }

        private void XOR_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);

            g.DrawArc(p, w / 2, h / 2, 160, 70, -90, 180);
            g.DrawArc(p, w / 2 + 40, h / 2, 80, 70, -90, 180);
            g.DrawArc(p, w / 2 + 25, h / 2, 80, 70, -90, 180);
            g.DrawLine(p, w / 2 + 40, h / 2 + 15, w / 2 + 97, h / 2 + 15);
            g.DrawLine(p, w / 2 + 40, h / 2 + 55, w / 2 + 97, h / 2 + 55);
            g.DrawLine(p, w / 2 + 160, h / 2 + 35, w / 2 + 190, h / 2 + 35);
            p.Dispose();
        }

        private void XNOR_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);

            g.DrawArc(p, w / 2, h / 2, 160, 70, -90, 180);
            g.DrawArc(p, w / 2 + 40, h / 2, 80, 70, -90, 180);
            g.DrawArc(p, w / 2 + 25, h / 2, 80, 70, -90, 180);
            g.DrawLine(p, w / 2 + 40, h / 2 + 15, w / 2 + 97, h / 2 + 15);
            g.DrawLine(p, w / 2 + 40, h / 2 + 55, w / 2 + 97, h / 2 + 55);
            g.DrawEllipse(Pens.Blue, w / 2 + 160, h / 2 + 30, 10, 10);
            g.DrawLine(p, w / 2 + 170, h / 2 + 35, w / 2 + 190, h / 2 + 35);            
            p.Dispose();
        }

        private void NAND_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);
            g.DrawArc(p, w / 2, h / 2, 100, 80, -90, 180);
            g.DrawLine(p, w / 2 + 50, h / 2, w / 2 + 50, h / 2 + 80);
            g.DrawLine(p, w / 2, h / 2 + 20, w / 2 + 50, h / 2 + 20);
            g.DrawLine(p, w / 2, h / 2 + 60, w / 2 + 50, h / 2 + 60);

            g.DrawEllipse(Pens.Blue, w / 2 + 100, h / 2 + 35, 10, 10);
            g.DrawLine(p, w / 2 + 110, h / 2 + 40, w / 2 + 150, h / 2 + 40);
            //g.DrawLine(p, w / 2 + 100, h / 2 + 40, w / 2 + 120, h / 2 + 40);

            p.Dispose();
        }

        private void NOT_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;
            Pen p = new Pen(Color.DarkBlue);
            Point[] pts = new Point[3];
            pts[0].X = w / 2 + 50;
            pts[0].Y = h / 2;
            pts[1].X = w / 2 - 50;
            pts[1].Y = h / 2 - 30;
            pts[2].X = w / 2 - 50;
            pts[2].Y = h / 2 + 30;
            g.DrawPolygon(p, pts);
            //g.DrawLine(p, w / 2 - 50, h / 2 - 15, w / 2 -100, h / 2 - 15);
            g.DrawLine(p, w / 2 - 50, h / 2 , w / 2 - 100, h / 2 );
            g.DrawEllipse(p,w/2+50,h/2-5,10,10);
            g.DrawLine(p, w / 2 + 60, h / 2, w / 2 + 90, h / 2);
            p.Dispose();

        }
    }
}
