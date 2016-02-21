using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
namespace logic1
{
    
    public partial class Form1 : Form
    {


        int i = 0;
    

       
        //int x1, y1;//used for connecting
        int x = 0, y = 0;
        bool connect_clk = false;
        private Point MouseDownLocation;
        List<line> lstlines = new List<line>();
        public Form1()
        {
            InitializeComponent();

        }
        class line
        {
            public Point From, To;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(AndInterface)) is AndInterface)
            {
                AndInterface temp = (AndInterface)e.Data.GetData(typeof(AndInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);
                this.Controls.Add(temp);
                
            }
            else if (e.Data.GetData(typeof(NandInterface)) is NandInterface)
            {
                NandInterface temp = (NandInterface)e.Data.GetData(typeof(NandInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(OrInterface)) is OrInterface)
            {
                OrInterface temp = (OrInterface)e.Data.GetData(typeof(OrInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(NorInterface)) is NorInterface)
            {
                NorInterface temp = (NorInterface)e.Data.GetData(typeof(NorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(XorInterface)) is XorInterface)
            {
                XorInterface temp = (XorInterface)e.Data.GetData(typeof(XorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(XnorInterface)) is XnorInterface)
            {
                XnorInterface temp = (XnorInterface)e.Data.GetData(typeof(XnorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(NotInterface)) is NotInterface)
            {
                NotInterface temp = (NotInterface)e.Data.GetData(typeof(NotInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void AND_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new AndInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void OR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new OrInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void XOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new XorInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void NAND_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NandInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void NOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NorInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void XNOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new XnorInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        private void NOT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NotInterface(), DragDropEffects.Copy);
            }
            connect_clk = false;
        }

        Point ptTo, ptFrom;
        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(panel1);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            y = e.Y;
            if (e.Button == MouseButtons.Left && connect_clk == true)
            {
                ptTo = e.Location;
                //x1 = x;
                //y1 = y;

            }
             //if (e.Button == MouseButtons.Left )
             //   {
             //           ptTo = e.Location;
             //   }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
           
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.X;
            y = e.Y;
            if (e.Button == MouseButtons.Left && connect_clk == true)
            {

                ptFrom = e.Location;
                line ln = new line();
                ln.From = ptFrom;
                ln.To = ptTo;
                lstlines.Add(ln);
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Black, ptFrom, ptTo);
                g.Dispose();
                //ShapeContainer canavas = new ShapeContainer();
                //LineShape ConnLine = new LineShape();
                //canavas.Parent = this;
                //ConnLine.Parent = canavas;
                //ConnLine.StartPoint = new System.Drawing.Point(x1, y1);
                //ConnLine.EndPoint = new System.Drawing.Point(x, y);
                //ConnLine.BringToFront();

            }
            //if (e.Button == MouseButtons.Left )
            //{
            //    ptFrom = e.Location;
            //    line ln = new line();
            //    ln.From = ptFrom;
            //    ln.To = ptTo;
            //    lstlines.Add(ln);
            //    Graphics g = this.CreateGraphics();
            //    g.DrawLine(Pens.Red, ptFrom, ptTo);
            //    g.Dispose();

            //    Invalidate();
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?","Logic Gates",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                 Application.Exit();
            }
            else 
            {
                e.Cancel = true;
            }
        }
}
}
