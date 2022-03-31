namespace Lab1_Shvets_
{
    partial class Form2
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioT3 = new System.Windows.Forms.RadioButton();
            this.radioT2 = new System.Windows.Forms.RadioButton();
            this.radioT1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioC6 = new System.Windows.Forms.RadioButton();
            this.radioB5 = new System.Windows.Forms.RadioButton();
            this.radioA4 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Lab1_Shvets_.Properties.Resources.save__v1;
            this.pictureBox3.Location = new System.Drawing.Point(83, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab1_Shvets_.Properties.Resources.новый;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioT3);
            this.groupBox1.Controls.Add(this.radioT2);
            this.groupBox1.Controls.Add(this.radioT1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вопрос №1";
            // 
            // radioT3
            // 
            this.radioT3.AutoSize = true;
            this.radioT3.Location = new System.Drawing.Point(472, 72);
            this.radioT3.Name = "radioT3";
            this.radioT3.Size = new System.Drawing.Size(229, 72);
            this.radioT3.TabIndex = 3;
            this.radioT3.Text = "траектории всех точек тела\r\nнаходятся вне плоскости,\r\nперепендикулярно некоторой\r" +
    "\nнеподв. плоскости.\r\n";
            this.radioT3.UseVisualStyleBackColor = true;
            this.radioT3.CheckedChanged += new System.EventHandler(this.radioT1_CheckedChanged);
            // 
            // radioT2
            // 
            this.radioT2.AutoSize = true;
            this.radioT2.Location = new System.Drawing.Point(240, 72);
            this.radioT2.Name = "radioT2";
            this.radioT2.Size = new System.Drawing.Size(219, 72);
            this.radioT2.TabIndex = 2;
            this.radioT2.Text = "траектории всех точек тела \r\nне остаются в плоскостях,\r\nпаралелльных некоторой \r\n" +
    "неподв. плоскости.";
            this.radioT2.UseVisualStyleBackColor = true;
            this.radioT2.CheckedChanged += new System.EventHandler(this.radioT1_CheckedChanged);
            // 
            // radioT1
            // 
            this.radioT1.AutoSize = true;
            this.radioT1.Location = new System.Drawing.Point(6, 72);
            this.radioT1.Name = "radioT1";
            this.radioT1.Size = new System.Drawing.Size(219, 72);
            this.radioT1.TabIndex = 1;
            this.radioT1.Text = "траектории всех точек тела \r\nостаются в плоскостях, \r\nпараллельных некоторой\r\nнеп" +
    "одв. плоскости.";
            this.radioT1.UseVisualStyleBackColor = true;
            this.radioT1.CheckedChanged += new System.EventHandler(this.radioT1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(699, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Плоско-параллельным движением тела называют такое движение, при котором...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioC6);
            this.groupBox2.Controls.Add(this.radioB5);
            this.groupBox2.Controls.Add(this.radioA4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(1, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вопрос №2";
            // 
            // radioC6
            // 
            this.radioC6.AutoSize = true;
            this.radioC6.Location = new System.Drawing.Point(600, 211);
            this.radioC6.Name = "radioC6";
            this.radioC6.Size = new System.Drawing.Size(36, 21);
            this.radioC6.TabIndex = 3;
            this.radioC6.Text = "c";
            this.radioC6.UseVisualStyleBackColor = true;
            this.radioC6.CheckedChanged += new System.EventHandler(this.radioT2_CheckedChanged);
            // 
            // radioB5
            // 
            this.radioB5.AutoSize = true;
            this.radioB5.Location = new System.Drawing.Point(317, 211);
            this.radioB5.Name = "radioB5";
            this.radioB5.Size = new System.Drawing.Size(37, 21);
            this.radioB5.TabIndex = 2;
            this.radioB5.Text = "b";
            this.radioB5.UseVisualStyleBackColor = true;
            this.radioB5.CheckedChanged += new System.EventHandler(this.radioT2_CheckedChanged);
            // 
            // radioA4
            // 
            this.radioA4.AutoSize = true;
            this.radioA4.Location = new System.Drawing.Point(68, 211);
            this.radioA4.Name = "radioA4";
            this.radioA4.Size = new System.Drawing.Size(37, 21);
            this.radioA4.TabIndex = 1;
            this.radioA4.Text = "a";
            this.radioA4.UseVisualStyleBackColor = true;
            this.radioA4.CheckedChanged += new System.EventHandler(this.radioT2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(688, 141);
            this.textBox2.TabIndex = 0;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Скорость любой точки М плоской фигуры может быть определена следующим образом\r\n\r\n" +
    "a) vM =vA +-vMA \r\n\r\nb) vM =vω +ω x rM A\r\n\r\nc) vM =vA^2 +-vMA ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioT3;
        private System.Windows.Forms.RadioButton radioT2;
        private System.Windows.Forms.RadioButton radioT1;
        private System.Windows.Forms.RadioButton radioC6;
        private System.Windows.Forms.RadioButton radioB5;
        private System.Windows.Forms.RadioButton radioA4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}