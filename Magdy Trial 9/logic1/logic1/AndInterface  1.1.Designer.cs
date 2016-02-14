namespace logic1
{
    partial class AndInterface__1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.node3 = new logic1.Node();
            this.node1 = new logic1.Node();
            this.node2 = new logic1.Node();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::logic1.Properties.Resources.And_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(34, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 147);
            this.panel1.TabIndex = 4;
            // 
            // node3
            // 
            this.node3.BackColor = System.Drawing.Color.Silver;
            this.node3.Location = new System.Drawing.Point(176, 92);
            this.node3.Name = "node3";
            this.node3.Size = new System.Drawing.Size(10, 11);
            this.node3.TabIndex = 10;
            // 
            // node1
            // 
            this.node1.BackColor = System.Drawing.Color.Silver;
            this.node1.Location = new System.Drawing.Point(3, 143);
            this.node1.Name = "node1";
            this.node1.Size = new System.Drawing.Size(10, 11);
            this.node1.TabIndex = 9;
            // 
            // node2
            // 
            this.node2.BackColor = System.Drawing.Color.Silver;
            this.node2.Location = new System.Drawing.Point(3, 7);
            this.node2.Name = "node2";
            this.node2.Size = new System.Drawing.Size(10, 11);
            this.node2.TabIndex = 8;
            // 
            // AndInterface__1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.node3);
            this.Controls.Add(this.node1);
            this.Controls.Add(this.node2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Name = "AndInterface__1";
            this.Size = new System.Drawing.Size(195, 154);
            this.Load += new System.EventHandler(this.AndInterface__1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Node node2;
        private Node node1;
        private Node node3;
    }
}
