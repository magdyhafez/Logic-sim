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
        bool Drawc = false;
        int x = 0, y = 0;
        string drawinglocation ;
        public Form1()
        {
            InitializeComponent();
        }
        class line
        {
            public Point From, To;
        }
        List<line> lstlines = new List<line>();
        Point ptFrom, ptTo;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (line ln in lstlines)
            g.DrawLine(Pens.Red, ln.From, ln.To);
        }

        private void AND_Click(object sender, EventArgs e)
        {
            drawinglocation = "AND";
        }

        private void OR_Click(object sender, EventArgs e)
        {
            drawinglocation = "OR";
        }

        private void NOR_Click(object sender, EventArgs e)
        {
             drawinglocation = "NOR";
        }

        private void XOR_Click(object sender, EventArgs e)
        {
           drawinglocation = "XOR";
        }

        private void XNOR_Click(object sender, EventArgs e)
        {
            drawinglocation = "XNOR";
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            Drawc = !Drawc;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left)&&  Drawc)
            {
                ptFrom = e.Location;
                line ln = new line();
                ln.From = ptFrom;
                ln.To = ptTo;
                lstlines.Add(ln);
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Red, ptFrom, ptTo);
                g.Dispose();

                
            }
        }

        private void NAND_Click(object sender, EventArgs e)
        {
            drawinglocation = "NAND";
        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ptTo = e.Location;

            }
            base.OnMouseMove(e);
            x = e.X - 80 ;
            y = e.Y ;
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue);
            if (drawinglocation == "AND")
            {
                x += 30;
                g.DrawArc(p, x, y, 100, 80, -90, 180);
                g.DrawLine(p, x + 50, y, x + 50, y + 80);
                g.DrawLine(p, x, y + 20, x + 50, y + 20);
                g.DrawLine(p, x, y + 60, x + 50, y + 60);
                g.DrawLine(p, x + 100, y + 40, x + 120, y + 40);

                p.Dispose();
            }
            else if (drawinglocation == "OR")
            {
                
                g.DrawArc(p, x, y, 160, 70, -90, 180);
                g.DrawArc(p, x + 40, y, 80, 70, -90, 180);
                g.DrawLine(p, x + 63, y + 15, x + 113, y + 15);
                g.DrawLine(p, x + 63, y + 55, x + 113, y + 55);
                g.DrawLine(p, x + 160, y + 35, x + 190, y + 35);
                p.Dispose();
            }
            else if (drawinglocation == "NAND")
            {
                x += 30;
                g.DrawArc(p, x, y, 100, 80, -90, 180);
                g.DrawLine(p, x + 50, y, x + 50, y + 80);
                g.DrawLine(p, x, y + 20, x + 50, y + 20);
                g.DrawLine(p, x, y + 60, x + 50, y + 60);
                g.DrawEllipse(Pens.Blue, x + 100, y + 35, 10, 10);
                g.DrawLine(p, x + 110, y+ 40, x + 150, y + 40);
                p.Dispose();
            }
            else if (drawinglocation == "NOR")
            {
                
                g.DrawArc(p, x, y, 160, 70, -90, 180);
                g.DrawArc(p, x + 40, y, 80, 70, -90, 180);
                g.DrawLine(p, x + 63, y + 15, x + 113, y + 15);
                g.DrawLine(p, x + 63, y + 55, x + 113, y + 55);
                g.DrawEllipse(Pens.Blue, x + 160, y + 30, 10, 10);
                g.DrawLine(p, x + 170, y + 35, x + 190, y + 35);
                p.Dispose();
            }
            else if (drawinglocation == "XOR")
            {
                
                g.DrawArc(p, x, y, 160, 70, -90, 180);
                g.DrawArc(p, x + 40, y, 80, 70, -90, 180);
                g.DrawArc(p, x + 25, y, 80, 70, -90, 180);
                g.DrawLine(p, x + 40, y + 15, x + 97, y + 15);
                g.DrawLine(p, x + 40, y + 55, x + 97, y + 55);
                g.DrawLine(p, x + 160, y + 35, x + 190, y + 35);
                p.Dispose();
            }
            else if (drawinglocation == "XNOR")
            {
                g.DrawArc(p, x, y, 160, 70, -90, 180);
                g.DrawArc(p, x + 40, y, 80, 70, -90, 180);
                g.DrawArc(p, x + 25, y, 80, 70, -90, 180);
                g.DrawLine(p,  x + 40, y + 15, x + 97, y + 15);
                g.DrawLine(p, x + 40, y+ 55,x + 97, y + 55);
                g.DrawEllipse(Pens.Blue, x + 160, y + 30, 10, 10);
                g.DrawLine(p, x + 170, y + 35, x + 190, y + 35);
                p.Dispose();
            }
        }

      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}
