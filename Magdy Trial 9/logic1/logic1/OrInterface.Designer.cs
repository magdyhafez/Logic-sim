﻿namespace logic1
{
    partial class OrInterface
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
            this.node1 = new logic1.Node();
            this.node2 = new logic1.Node();
            this.node3 = new logic1.Node();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // node1
            // 
            this.node1.BackColor = System.Drawing.Color.Silver;
            this.node1.Location = new System.Drawing.Point(0, 0);
            this.node1.Name = "node1";
            this.node1.Size = new System.Drawing.Size(10, 11);
            this.node1.TabIndex = 2;
            // 
            // node2
            // 
            this.node2.BackColor = System.Drawing.Color.Silver;
            this.node2.Location = new System.Drawing.Point(0, 138);
            this.node2.Name = "node2";
            this.node2.Size = new System.Drawing.Size(10, 11);
            this.node2.TabIndex = 3;
            // 
            // node3
            // 
            this.node3.BackColor = System.Drawing.Color.Silver;
            this.node3.Location = new System.Drawing.Point(143, 50);
            this.node3.Name = "node3";
            this.node3.Size = new System.Drawing.Size(10, 11);
            this.node3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::logic1.Properties.Resources.Or_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(23, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 111);
            this.panel1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(143, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OrInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.node3);
            this.Controls.Add(this.node2);
            this.Controls.Add(this.node1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "OrInterface";
            this.Size = new System.Drawing.Size(158, 148);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrInterface_MouseDown);
            this.MouseEnter += new System.EventHandler(this.OrInterface_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.OrInterface_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrInterface_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private Node node1;
        private Node node2;
        private Node node3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
