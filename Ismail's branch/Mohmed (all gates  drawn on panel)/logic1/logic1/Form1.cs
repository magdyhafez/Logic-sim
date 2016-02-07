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
        //Panel AndPanel = new Panel();
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
        /*
        // we need a first point 
        private Point firstpoint = new Point();
        public void INIT()
        {
            AndPanel.MouseDown+= (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstpoint = Control.MousePosition;
                }
            };

            AndPanel.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    // create a temp point
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstpoint.X - temp.X, firstpoint.Y - temp.Y);
                    // apply value to object
                    AndPanel.Location = new Point(AndPanel.Location.X - res.X, AndPanel.Location.Y - res.Y);
                    // update first point
                    firstpoint = temp;

                }
            };
        }
        */
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
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue);
            if (drawinglocation == "AND")
            {
                Panel AndPanel = new Panel();
                AndPanel.Size = AND.Size;
                AndPanel.BackgroundImage = AND.BackgroundImage;
                AndPanel.BackgroundImageLayout = AND.BackgroundImageLayout;
                AndPanel.Location = new Point(x, y);
                Controls.Add(AndPanel);
                
            }
            else if (drawinglocation == "OR")
            {

                Panel ORPanel = new Panel();
                ORPanel.Size = OR.Size;
                ORPanel.BackgroundImage = OR.BackgroundImage;
                ORPanel.BackgroundImageLayout = OR.BackgroundImageLayout;
                ORPanel.Location = new Point(x, y);
                Controls.Add(ORPanel);
            }
            else if (drawinglocation == "NAND")
            {
                Panel NAndPanel = new Panel();
                NAndPanel.Size = NAND.Size;
                NAndPanel.BackgroundImage = NAND.BackgroundImage;
                NAndPanel.BackgroundImageLayout = NAND.BackgroundImageLayout;
                NAndPanel.Location = new Point(x, y);
                Controls.Add(NAndPanel);
            }
            else if (drawinglocation == "NOR")
            {

                Panel NORPanel = new Panel();
                NORPanel.Size = NOR.Size;
                NORPanel.BackgroundImage = NOR.BackgroundImage;
                NORPanel.BackgroundImageLayout = NOR.BackgroundImageLayout;
                NORPanel.Location = new Point(x, y);
                Controls.Add(NORPanel);
            }
            else if (drawinglocation == "XOR")
            {

                Panel XORPanel = new Panel();
                XORPanel.Size = XOR.Size;
                XORPanel.BackgroundImage = XOR.BackgroundImage;
                XORPanel.BackgroundImageLayout = XOR.BackgroundImageLayout;
                XORPanel.Location = new Point(x, y);
                Controls.Add(XORPanel);
            }
            else if (drawinglocation == "XNOR")
            {
                Panel XNORPanel = new Panel();
                XNORPanel.Size = XNOR.Size;
                XNORPanel.BackgroundImage = XNOR.BackgroundImage;
                XNORPanel.BackgroundImageLayout = XNOR.BackgroundImageLayout;
                XNORPanel.Location = new Point(x, y);
                Controls.Add(XNORPanel);
            }
            else if (drawinglocation == "NOT")
            {
                Panel NOTPanel = new Panel();
                NOTPanel.Size = NOT.Size;
                NOTPanel.BackgroundImage = NOT.BackgroundImage;
                NOTPanel.BackgroundImageLayout = NOT.BackgroundImageLayout;
                NOTPanel.Location = new Point(x, y);
                Controls.Add(NOTPanel);
            }
        }

        

      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}
