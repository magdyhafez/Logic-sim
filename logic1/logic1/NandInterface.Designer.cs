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
            this.node1 = new logic1.Node();
            this.node2 = new logic1.Node();
            this.node4 = new logic1.Node();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // node1
            // 
            this.node1.BackColor = System.Drawing.Color.Silver;
            this.node1.Location = new System.Drawing.Point(4, 4);
            this.node1.Name = "node1";
            this.node1.Size = new System.Drawing.Size(10, 11);
            this.node1.TabIndex = 0;
            // 
            // node2
            // 
            this.node2.BackColor = System.Drawing.Color.Silver;
            this.node2.Location = new System.Drawing.Point(4, 136);
            this.node2.Name = "node2";
            this.node2.Size = new System.Drawing.Size(10, 11);
            this.node2.TabIndex = 1;
            // 
            // node4
            // 
            this.node4.BackColor = System.Drawing.Color.Silver;
            this.node4.Location = new System.Drawing.Point(165, 50);
            this.node4.Name = "node4";
            this.node4.Size = new System.Drawing.Size(10, 11);
            this.node4.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(165, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::logic1.Properties.Resources.Nand_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 100);
            this.panel1.TabIndex = 7;
            // 
            // NandInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.node4);
            this.Controls.Add(this.node2);
            this.Controls.Add(this.node1);
            this.Name = "NandInterface";
            this.Size = new System.Drawing.Size(178, 150);
            this.Load += new System.EventHandler(this.NandInterface_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseDown);
            this.MouseEnter += new System.EventHandler(this.NandInterface_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NandInterface_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NandInterface_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Node node1;
        private Node node2;
        private Node node4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
    }
}
