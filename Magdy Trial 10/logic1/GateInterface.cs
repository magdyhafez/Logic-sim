using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace logic1
{
    public  partial class GateInterface : UserControl
    {
        static int x1, x2, y1, y2;
        static bool value;
        public GateInterface()
        {
            InitializeComponent();
        }

        virtual public  void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = true; 
        
        }
         
           

        virtual public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void node1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void node3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void node3_MouseClick(object sender, MouseEventArgs e)
        {
            value = radioButton1.Checked;
            x1 = radioButton1.Location.X+this.Location.X;
            y1 = radioButton1.Location.Y+this.Location.Y;
            //radioButton1.Visible = false; 
        }

        private void node1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = value;
            x2 = checkBox1.Location.X+this.Location.X;
            y2 = checkBox1.Location.Y+this.Location.Y;
            ShapeContainer canavas = new ShapeContainer();
            LineShape ConnLine = new LineShape();
            canavas.Parent = this.Parent;
            ConnLine.Parent = canavas;
            ConnLine.StartPoint = new System.Drawing.Point(x1, y1);
            ConnLine.EndPoint = new System.Drawing.Point(x2, y2);
            ConnLine.BringToFront();
           // checkBox1.Visible = false;          

        }

        private void node3_Load(object sender, EventArgs e)
        {

        }

        private void GateInterface_Load(object sender, EventArgs e)
        {

        }

        private void node2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void node2_DoubleClick(object sender, EventArgs e)
        {
            checkBox2.Checked = value;
            x2 = checkBox2.Location.X + this.Location.X;
            y2 = checkBox2.Location.Y + this.Location.Y;
            ShapeContainer canavas = new ShapeContainer();
            LineShape ConnLine = new LineShape();
            canavas.Parent = this.Parent;
            ConnLine.Parent = canavas;
            ConnLine.StartPoint = new System.Drawing.Point(x1, y1);
            ConnLine.EndPoint = new System.Drawing.Point(x2, y2);
            ConnLine.BringToFront();
         //   checkBox2.Visible = false;

        }

        private void node2_Load(object sender, EventArgs e)
        {

        }
    }
}
