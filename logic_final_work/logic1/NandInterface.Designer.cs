namespace logic1
{
    partial class NandInterface
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NandInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(3, 43);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(3, 14);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(132, 29);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(24, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 63);
            this.panel1.TabIndex = 7;
            // 
            // NandInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NandInterface";
            this.Size = new System.Drawing.Size(147, 70);
            this.Load += new System.EventHandler(this.NandInterface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseDown);
            this.MouseEnter += new System.EventHandler(this.NandInterface_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NandInterface_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseMove);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}
