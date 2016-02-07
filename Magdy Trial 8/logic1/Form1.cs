using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;  


namespace logic1
{
    
    public partial class Form1 : Form
    {
        private Point MouseDownLocation;
        bool conn=false;
        int x1 ,x2 ,y1,y2;//used for connecting
        int x = 0, y = 0;
        string drawinglocation ;
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

        private void NAND_Click(object sender, EventArgs e)
        {
            drawinglocation = "NAND";
        }

        private void NOT_Click(object sender, EventArgs e)
        {
            drawinglocation = "NOT";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

           

            base.OnMouseMove(e);
            x = e.X  ;
            y = e.Y ;
            // Determining the point last clicked 
            /*textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();*/
            if (conn == false)
            {
                 x1 = e.X;
                 y1 = e.Y;
            }
            // Connecting two gates 
            if (conn==true)
            {
                 x2 = e.X;
                 y2 = e.Y;
                ShapeContainer canavas = new ShapeContainer();
                LineShape ConnLine = new LineShape();
                canavas.Parent = this;
                ConnLine.Parent = canavas;
                ConnLine.StartPoint = new System.Drawing.Point(x1, y1);
                ConnLine.EndPoint = new System.Drawing.Point(x2, y2);
                ConnLine.BringToFront(); 
                conn = false; 
                


            }
            
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue);
            if (drawinglocation == "AND")
            {
                 AndInterface AndPanel = new AndInterface();
                AndPanel.Location = new Point(x,y);
                 Controls.Add(AndPanel);
            }
            else if (drawinglocation == "OR")
            {
                OrInterface AndPanel = new OrInterface();
                AndPanel.Location = new Point(x, y);
                Controls.Add(AndPanel);
            }
            else if (drawinglocation == "NAND")
            {
                NandInterface AndPanel = new NandInterface();
                AndPanel.Location = new Point(x, y);
                Controls.Add(AndPanel);
            }
            else if (drawinglocation == "NOR")
            {
                NorInterface NORPanel = new NorInterface();
                NORPanel.Location = new Point(x, y);
                Controls.Add(NORPanel);
            }
            else if (drawinglocation == "XOR")
            {
                XorInterface XORPanel = new XorInterface();
                XORPanel.Location = new Point(x, y);
                Controls.Add(XORPanel);
            }
            else if (drawinglocation == "XNOR")
            {
                XnorInterface XNORPanel = new XnorInterface();
                XNORPanel.Location = new Point(x, y);
                Controls.Add(XNORPanel);
            }
            else if (drawinglocation == "NOT")
            {
                NotInterface NOTPanel = new NotInterface();
                NOTPanel.Location = new Point(x, y);
                Controls.Add(NOTPanel);
            }
            else if (drawinglocation == "switch")
            {
                input Addswitch = new input();
                Addswitch.Location = new Point(x, y);
                Controls.Add(Addswitch);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawinglocation = "none";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawinglocation = "switch";
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

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            conn = true;

            /*ShapeContainer canvas = new ShapeContainer();
            LineShape theline = new LineShape();
            canvas.Parent = this;
            theline.Parent = canvas;
            theline.StartPoint = new System.Drawing.Point(0, 0);
            theline.EndPoint = new System.Drawing.Point(640, 480);
            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}
