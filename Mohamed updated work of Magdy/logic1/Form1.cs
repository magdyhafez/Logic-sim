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
  /*     public interface IDragAndDropItem
{
    Vector2 Position { get; set; }
    bool IsSelected {  set; }
    bool IsMouseOver { set; }
    bool Contains(Vector2 pointToCheck);
    Rectangle Border { get; }
}*/
    public partial class Form1 : Form
    {
       // int firsttime = 1;
        int x = 0, y = 0;
        string drawinglocation ;
        int posMouseFormX, posMouseFormY;
        int posMouseButtonX, posMouseButtonY;
        int posActbuttonX, posActbuttonY;
        bool buttonpressed = false;
        //List<Button> AND2 = new List<Button>();
        //Button AND2 = new Button();
        //Button AND3 = new Button();
        //Button AND4 = new Button();
        //Button AND5 = new Button();
        //Button OR2 = new Button();
        //Button NOR2 = new Button();
        //Button NAND2 = new Button();
        //Button XOR2 = new Button();
        //Button XNOR2 = new Button();
        /*
          code taken from internet to drag and drop
         */ 
        //declare the controller somewhere on your Game class
  /*       private DragAndDropController<Item> _dragDropController;
 
       //instantiate the controller somewhere
       _dragDropController =  new DragAndDropController<Item>(this, _spriteBatch);
//and add it to the Game class' Components
        Components.Add(_dragDropController);
 
//add the items you want drag-and-drop enabled to the controller
        _dragDropController.Add(item);

    */ 
          public Form1()
        {
            InitializeComponent();
         //   this.AND2.Click += new System.EventHandler(this.AND2_Click);
            //this.OR2.Click += new System.EventHandler(this.OR2_Click);
            //this.NOR2.Click += new System.EventHandler(this.NOR2_Click);
            //this.NAND2.Click += new System.EventHandler(this.NAND2_Click);
            //this.XOR2.Click += new System.EventHandler(this.XOR2_Click);
            //this.XNOR2.Click += new System.EventHandler(this.XNOR2_Click);
           // posActbuttonX = AND2.Location.X;
            ///posActbuttonY = AND2.Location.Y;
            this.AutoScroll = true;
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
            drawinglocation = "AND";
        }
        private void AND_MouseDown(object sender, MouseEventArgs e)
        {
            //posMouseButtonX = e.Location.X;
            //posMouseButtonY = e.Location.Y;
        }
        private void AND2_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseButtonX = e.Location.X;
            posMouseButtonY = e.Location.Y;
            buttonpressed = true;
        }
        private void AND3_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseButtonX = e.Location.X;
            posMouseButtonY = e.Location.Y;
            buttonpressed = true;
        }
        private void AND4_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseButtonX = e.Location.X;
            posMouseButtonY = e.Location.Y;
            buttonpressed = true;
        }
        private void AND5_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseButtonX = e.Location.X;
            posMouseButtonY = e.Location.Y;
            buttonpressed = true;
        }
        /*private void AND_MouseMove(object sender, MouseEventArgs e)
        {
            //posMouseFormX = posActbuttonX + e.Location.X;
            //posMouseFormY = posActbuttonY + e.Location.Y;
        }
        private void AND2_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActbuttonX + e.Location.X;
            posMouseFormY = posActbuttonY + e.Location.Y;
            if (buttonpressed == true) movingButton2();
        }
        private void AND3_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActbuttonX + e.Location.X;
            posMouseFormY = posActbuttonY + e.Location.Y;
            if (buttonpressed == true) movingButton3();
        }
        private void AND4_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActbuttonX + e.Location.X;
            posMouseFormY = posActbuttonY + e.Location.Y;
            if (buttonpressed == true) movingButton4();
        }
        private void AND5_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActbuttonX + e.Location.X;
            posMouseFormY = posActbuttonY + e.Location.Y;
            if (buttonpressed == true) movingButton5();
        }*/
        private void AND2_Click(object sender, EventArgs e)
        {
            
        }
        private void AND_MouseUp(object sender, MouseEventArgs e)
        {

        }
        /*private void AND2_MouseUp(object sender, MouseEventArgs e)
        {
            buttonpressed = false;
        }
        private void AND3_MouseUp(object sender, MouseEventArgs e)
        {
            buttonpressed = false;
        }
        private void AND4_MouseUp(object sender, MouseEventArgs e)
        {
            buttonpressed = false;
        }
        private void AND5_MouseUp(object sender, MouseEventArgs e)
        {
            buttonpressed = false;
        }
        */
        private void OR_Click(object sender, EventArgs e)
        {
            drawinglocation = "OR";
        }

        //private void OR2_Click(object sender, EventArgs e)
        //{

        //}

        private void NOR_Click(object sender, EventArgs e)
        {
             drawinglocation = "NOR";
        }

        //private void NOR2_Click(object sender, EventArgs e)
        //{

        //}

        private void XOR_Click(object sender, EventArgs e)
        {
           drawinglocation = "XOR";
        }

        //private void XOR2_Click(object sender, EventArgs e)
        //{

        //}

        private void XNOR_Click(object sender, EventArgs e)
        {
            drawinglocation = "XNOR";
        }

        //private void XNOR2_Click(object sender, EventArgs e)
        //{

        //}

        private void NAND_Click(object sender, EventArgs e)
        {
            drawinglocation = "NAND";
        }

        //private void NAND2_Click(object sender, EventArgs e)
        //{

        //}

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
            x = e.X  ;
            y = e.Y ;
            posMouseFormX = e.Location.X;
            posMouseFormY = e.Location.Y;
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DarkBlue);
            
            if (drawinglocation == "AND")
            {
                //if (firsttime == 0)
                Button AND2 = new Button();
               // firsttime = 0;
                AND2.Location = new Point(x,y);
                AND2.Text = AND.Text;
                AND2.Size = AND.Size;
                AND2.BackgroundImage = AND.BackgroundImage;
                AND2.BackgroundImageLayout = AND.BackgroundImageLayout;
                Controls.Add(AND2);
            }
            else if (drawinglocation == "OR")
            {

                Button OR2 = new Button();
                OR2.Location = new Point(x, y);
                OR2.Text = OR.Text;
                OR2.Size = OR.Size;
                OR2.BackgroundImage = OR.BackgroundImage;
                OR2.BackgroundImageLayout = OR.BackgroundImageLayout;
                Controls.Add(OR2);
            
            }
            else if (drawinglocation == "NAND")
            {
                Button NAND2 = new Button();
                NAND2.Location = new Point(x, y);
                NAND2.Text = NAND.Text;
                NAND2.Size = NAND.Size;
                NAND2.BackgroundImage = NAND.BackgroundImage;
                NAND2.BackgroundImageLayout = NAND.BackgroundImageLayout;
                Controls.Add(NAND2);
            }
            else if (drawinglocation == "NOR")
            {
                Button NOR2 = new Button();
                NOR2.Location = new Point(x, y);
                NOR2.Text = OR.Text;
                NOR2.Size = OR.Size;
                NOR2.BackgroundImage = OR.BackgroundImage;
                NOR2.BackgroundImageLayout = OR.BackgroundImageLayout;
                Controls.Add(NOR2);

            }
            else if (drawinglocation == "XOR")
            {

                Button XOR2 = new Button();
                XOR2.Location = new Point(x, y);
                XOR2.Text = XOR.Text;
                XOR2.Size = XOR.Size;
                XOR2.BackgroundImage = XOR.BackgroundImage;
                XOR2.BackgroundImageLayout = XOR.BackgroundImageLayout;
                Controls.Add(XOR2);
            }
            else if (drawinglocation == "XNOR")
            {
                Button XNOR2 = new Button();
                XNOR2.Location = new Point(x, y);
                XNOR2.Text = XNOR.Text;
                XNOR2.Size = XNOR.Size;
                XNOR2.BackgroundImage = XNOR.BackgroundImage;
                XNOR2.BackgroundImageLayout = XNOR.BackgroundImageLayout;
                Controls.Add(XNOR2);
            }
            //drawinglocation = "none";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActbuttonX ;//+ e.Location.X;
            posMouseFormY = posActbuttonY;//+ e.Location.Y;
        }
        /*private void movingButton2()
        {
            AND2.Location = new System.Drawing.Point(posMouseFormX,posMouseFormY);
        }

        private void movingButton3()
        {
            AND3.Location = new System.Drawing.Point(posMouseFormX, posMouseFormY);
        }

        private void movingButton4()
        {
            AND4.Location = new System.Drawing.Point(posMouseFormX, posMouseFormY);
        }

        private void movingButton5()
        {
            AND5.Location = new System.Drawing.Point(posMouseFormX, posMouseFormY);
        }

       */

        
      
        

      
        
        
        


        
        

      

        

        

        
       

    
    }
}
