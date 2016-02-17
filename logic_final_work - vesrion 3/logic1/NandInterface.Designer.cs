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
            // NandInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DoubleBuffered = true;
            this.Name = "NandInterface";
            this.Size = new System.Drawing.Size(147, 70);
            this.Load += new System.EventHandler(this.NandInterface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
