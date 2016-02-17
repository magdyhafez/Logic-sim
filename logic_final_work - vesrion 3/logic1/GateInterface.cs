using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logic1
{
    public  partial class GateInterface : UserControl
    {
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
    }
}
