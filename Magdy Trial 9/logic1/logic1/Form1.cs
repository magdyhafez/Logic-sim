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
        Dictionary<int, AndInterface> Gates = new Dictionary<int,AndInterface>(); 
        int j=0;
        private Point MouseDownLocation;
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
                // temp is the instance
                AndInterface temp = (AndInterface)e.Data.GetData(typeof(AndInterface)); 
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);
                temp.i = j; 
                this.Controls.Add(temp);
                 Gates.Add(temp.i, temp);
                  j++;
            }
            else if (e.Data.GetData(typeof(NandInterface)) is NandInterface)
            {
                // temp is the instance
                NandInterface temp = (NandInterface)e.Data.GetData(typeof(NandInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(OrInterface)) is OrInterface)
            {
                // temp is the instance
                OrInterface temp = (OrInterface)e.Data.GetData(typeof(OrInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(NorInterface)) is NorInterface)
            {
                // temp is the instance
                NorInterface temp = (NorInterface)e.Data.GetData(typeof(NorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(XorInterface)) is XorInterface)
            {
                // temp is the instance
                XorInterface temp = (XorInterface)e.Data.GetData(typeof(XorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(XnorInterface)) is XnorInterface)
            {
                // temp is the instance
                XnorInterface temp = (XnorInterface)e.Data.GetData(typeof(XnorInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(NotInterface)) is NotInterface)
            {
                // temp is the instance
                NotInterface temp = (NotInterface)e.Data.GetData(typeof(NotInterface));
                temp.Location = new Point(e.X - this.Location.X - temp.Width / 2, e.Y - this.Location.Y - temp.Height / 2);

                this.Controls.Add(temp);
            }
            else if (e.Data.GetData(typeof(input)) is input)
            {
                // temp is the instance
                input temp = (input)e.Data.GetData(typeof(input));
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
        }

        private void OR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new OrInterface(), DragDropEffects.Copy);
            }
        }

        private void XOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new XorInterface(), DragDropEffects.Copy);
            }
        }

        private void NAND_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NandInterface(), DragDropEffects.Copy);
            }
        }

        private void NOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NorInterface(), DragDropEffects.Copy);
            }
        }

        private void XNOR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new XnorInterface(), DragDropEffects.Copy);
            }
        }

        private void NOT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new NotInterface(), DragDropEffects.Copy);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DoDragDrop(new input(), DragDropEffects.Copy);
            }
        }

        private void AND_Click(object sender, EventArgs e)
        {

        }
    }
}
