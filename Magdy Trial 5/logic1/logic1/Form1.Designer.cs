﻿namespace logic1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NOT = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.XNOR = new System.Windows.Forms.Button();
            this.NOR = new System.Windows.Forms.Button();
            this.NAND = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NOT);
            this.panel1.Controls.Add(this.AND);
            this.panel1.Controls.Add(this.XNOR);
            this.panel1.Controls.Add(this.NOR);
            this.panel1.Controls.Add(this.NAND);
            this.panel1.Controls.Add(this.XOR);
            this.panel1.Controls.Add(this.OR);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 358);
            this.panel1.TabIndex = 0;
            // 
            // NOT
            // 
            this.NOT.BackgroundImage = global::logic1.Properties.Resources.Not_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOT.Location = new System.Drawing.Point(3, 314);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(88, 32);
            this.NOT.TabIndex = 6;
            this.NOT.Text = "NOT";
            this.NOT.UseVisualStyleBackColor = true;
            this.NOT.Click += new System.EventHandler(this.NOT_Click);
            // 
            // AND
            // 
            this.AND.BackgroundImage = global::logic1.Properties.Resources.And_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.AND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AND.Location = new System.Drawing.Point(3, 3);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(88, 51);
            this.AND.TabIndex = 0;
            this.AND.Text = "AND";
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // XNOR
            // 
            this.XNOR.BackgroundImage = global::logic1.Properties.Resources.Xnor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.XNOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XNOR.Location = new System.Drawing.Point(3, 268);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(88, 40);
            this.XNOR.TabIndex = 5;
            this.XNOR.Text = "XNOR";
            this.XNOR.UseVisualStyleBackColor = true;
            this.XNOR.Click += new System.EventHandler(this.XNOR_Click);
            // 
            // NOR
            // 
            this.NOR.BackgroundImage = global::logic1.Properties.Resources.Nor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOR.Location = new System.Drawing.Point(3, 215);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(88, 47);
            this.NOR.TabIndex = 4;
            this.NOR.Text = "NOR";
            this.NOR.UseVisualStyleBackColor = true;
            this.NOR.Click += new System.EventHandler(this.NOR_Click);
            // 
            // NAND
            // 
            this.NAND.BackgroundImage = global::logic1.Properties.Resources.Nand_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NAND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAND.Location = new System.Drawing.Point(3, 167);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(88, 42);
            this.NAND.TabIndex = 3;
            this.NAND.Text = "NAND";
            this.NAND.UseVisualStyleBackColor = true;
            this.NAND.Click += new System.EventHandler(this.NAND_Click);
            // 
            // XOR
            // 
            this.XOR.BackgroundImage = global::logic1.Properties.Resources.Xor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.XOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XOR.Location = new System.Drawing.Point(3, 119);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(88, 42);
            this.XOR.TabIndex = 2;
            this.XOR.Text = "XOR";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // OR
            // 
            this.OR.BackgroundImage = global::logic1.Properties.Resources.Or_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.OR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OR.Location = new System.Drawing.Point(3, 67);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(88, 46);
            this.OR.TabIndex = 1;
            this.OR.Text = "OR";
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(130, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(169, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "logic gates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Button NOT;
        private System.Windows.Forms.Button XNOR;
        private System.Windows.Forms.Button NOR;
        private System.Windows.Forms.Button NAND;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

