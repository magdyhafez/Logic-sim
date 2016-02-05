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
        int x = 0, y = 0;
        string drawinglocation ;
        public Form1()
        {
            InitializeComponent();
            bool x;
        }
       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void AND_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "False";
            Panel AndPanel = new Panel();
            x = 1;
            AndPanel.Size = AND.Size;
            AndPanel.BackgroundImage = AND.BackgroundImage;
            AndPanel.BackgroundImageLayout = AND.BackgroundImageLayout;
            AndPanel.Location = new Point(150, 150);
            Controls.Add(AndPanel);
            


           


            
            

           

        }
        private Point MouseDownLocation;
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

        private void NAND_Click(object sender, EventArgs e)
        {
            drawinglocation = "NAND";
        }

        private void NOT_Click(object sender, EventArgs e)
        {
            drawinglocation = "NOT";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && x == 1)
                textBox1.Text = "True";
            else
                textBox1.Text = "False"; 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && x == 1)
                textBox1.Text = "True";
            else
                textBox1.Text = "False";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel1.Left = e.X + panel1.Left - MouseDownLocation.X;
                panel1.Top = e.Y + panel1.Top - MouseDownLocation.Y;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
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
            else if (drawinglocation == "NOT")
            {
                x += 115;
                Point[] pts = new Point[3];
                pts[0].X = x + 35;
                pts[0].Y = y;
                pts[1].X = x - 35;
                pts[1].Y = y - 20;
                pts[2].X = x - 35;
                pts[2].Y = y + 20;
                g.DrawPolygon(p, pts);
                g.DrawLine(p, x - 35, y, x - 70, y);
                g.DrawEllipse(p, x + 35, y - 5, 10, 10);
                g.DrawLine(p, x + 45, y, x + 90, y);
                p.Dispose();
            }
        }

        

      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}
