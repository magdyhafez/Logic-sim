namespace logic1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.XNOR = new System.Windows.Forms.Button();
            this.NOR = new System.Windows.Forms.Button();
            this.NAND = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NOT);
            this.panel1.Controls.Add(this.AND);
            this.panel1.Controls.Add(this.XNOR);
            this.panel1.Controls.Add(this.NOR);
            this.panel1.Controls.Add(this.NAND);
            this.panel1.Controls.Add(this.XOR);
            this.panel1.Controls.Add(this.OR);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 379);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "pointer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOT
            // 
            this.NOT.BackgroundImage = global::logic1.Properties.Resources.Not_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOT.Location = new System.Drawing.Point(3, 267);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(70, 35);
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
            this.AND.Size = new System.Drawing.Size(70, 39);
            this.AND.TabIndex = 0;
            this.AND.Text = "AND";
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.AND_Click);
            // 
            // XNOR
            // 
            this.XNOR.BackgroundImage = global::logic1.Properties.Resources.Xnor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.XNOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XNOR.Location = new System.Drawing.Point(3, 221);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(70, 40);
            this.XNOR.TabIndex = 5;
            this.XNOR.Text = "XNOR";
            this.XNOR.UseVisualStyleBackColor = true;
            this.XNOR.Click += new System.EventHandler(this.XNOR_Click);
            // 
            // NOR
            // 
            this.NOR.BackgroundImage = global::logic1.Properties.Resources.Nor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOR.Location = new System.Drawing.Point(3, 179);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(70, 36);
            this.NOR.TabIndex = 4;
            this.NOR.Text = "NOR";
            this.NOR.UseVisualStyleBackColor = true;
            this.NOR.Click += new System.EventHandler(this.NOR_Click);
            // 
            // NAND
            // 
            this.NAND.BackgroundImage = global::logic1.Properties.Resources.Nand_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.NAND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAND.Location = new System.Drawing.Point(3, 136);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(70, 37);
            this.NAND.TabIndex = 3;
            this.NAND.Text = "NAND";
            this.NAND.UseVisualStyleBackColor = true;
            this.NAND.Click += new System.EventHandler(this.NAND_Click);
            // 
            // XOR
            // 
            this.XOR.BackgroundImage = global::logic1.Properties.Resources.Xor_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.XOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XOR.Location = new System.Drawing.Point(3, 88);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(70, 42);
            this.XOR.TabIndex = 2;
            this.XOR.Text = "XOR";
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.XOR_Click);
            // 
            // OR
            // 
            this.OR.BackgroundImage = global::logic1.Properties.Resources.Or_Logic_Functions_Digital_Electronics_clip_art_medium;
            this.OR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OR.Location = new System.Drawing.Point(3, 48);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(70, 34);
            this.OR.TabIndex = 1;
            this.OR.Text = "OR";
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.OR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 377);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "logic gates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

