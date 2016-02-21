namespace logic1
{
    partial class GateInterface
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.node3 = new logic1.Node();
            this.node2 = new logic1.Node();
            this.node1 = new logic1.Node();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // node3
            // 
            this.node3.BackColor = System.Drawing.Color.Silver;
            this.node3.Location = new System.Drawing.Point(114, 44);
            this.node3.Name = "node3";
            this.node3.Size = new System.Drawing.Size(10, 11);
            this.node3.TabIndex = 12;
            this.node3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.node3_MouseClick);
            this.node3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.node3_MouseDown);
            // 
            // node2
            // 
            this.node2.BackColor = System.Drawing.Color.Silver;
            this.node2.Location = new System.Drawing.Point(3, 106);
            this.node2.Name = "node2";
            this.node2.Size = new System.Drawing.Size(10, 11);
            this.node2.TabIndex = 11;
            this.node2.Load += new System.EventHandler(this.node2_Load);
            this.node2.DoubleClick += new System.EventHandler(this.node2_DoubleClick);
            this.node2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.node2_MouseClick);
            // 
            // node1
            // 
            this.node1.BackColor = System.Drawing.Color.Silver;
            this.node1.Location = new System.Drawing.Point(0, 0);
            this.node1.Name = "node1";
            this.node1.Size = new System.Drawing.Size(10, 11);
            this.node1.TabIndex = 10;
            this.node1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.node1_MouseDoubleClick);
            this.node1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.node1_MouseDown);
            // 
            // GateInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.node3);
            this.Controls.Add(this.node2);
            this.Controls.Add(this.node1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "GateInterface";
            this.Size = new System.Drawing.Size(141, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        protected System.Windows.Forms.RadioButton radioButton1;
        private Node node1;
        private Node node2;
        private Node node3;
    }
}
