namespace logic1
{
    partial class NotInterface
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.node2 = new logic1.Node();
            this.node3 = new logic1.Node();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(156, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::logic1.Properties.Resources.Not_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(20, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 107);
            this.panel1.TabIndex = 3;
            // 
            // node2
            // 
            this.node2.BackColor = System.Drawing.Color.Silver;
            this.node2.Location = new System.Drawing.Point(4, 71);
            this.node2.Name = "node2";
            this.node2.Size = new System.Drawing.Size(10, 11);
            this.node2.TabIndex = 5;
            // 
            // node3
            // 
            this.node3.BackColor = System.Drawing.Color.Silver;
            this.node3.Location = new System.Drawing.Point(156, 31);
            this.node3.Name = "node3";
            this.node3.Size = new System.Drawing.Size(10, 11);
            this.node3.TabIndex = 6;
            // 
            // NotInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.node3);
            this.Controls.Add(this.node2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Name = "NotInterface";
            this.Size = new System.Drawing.Size(173, 116);
            this.Load += new System.EventHandler(this.NotInterface_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotInterface_MouseDown);
            this.MouseEnter += new System.EventHandler(this.NotInterface_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NotInterface_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotInterface_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private Node node2;
        private Node node3;
    }
}
