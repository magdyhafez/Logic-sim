﻿using System;
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
        }

        private Point MouseDownLocation;
       private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void AND_Click(object sender, EventArgs e)
        {
            Button AND2 = new Button();
            /* AND2.Visible = true;
             AND2.Location = new Point(150, 150);
             AND2.Height = 40;
             AND2.Width = 300;*/
           AND2.Location = new Point(120, 100);
            AND2.Text = AND.Text;
            AND2.Size = AND.Size;
            AND2.BackgroundImage = AND.BackgroundImage;
            AND2.BackgroundImageLayout = AND.BackgroundImageLayout;
            Controls.Add(AND2); // Add the new button to the form
        }

        private void OR_Click(object sender, EventArgs e)
        {
            Button OR2 = new Button();
            OR2.Location= new Point(200, 200);
            OR2.Text = OR.Text;
            OR2.Size = OR.Size;
            OR2.BackgroundImage = OR.BackgroundImage;
            OR2.BackgroundImageLayout = OR.BackgroundImageLayout;
            Controls.Add(OR2);
            ;
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
        }

      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}