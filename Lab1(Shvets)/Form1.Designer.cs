namespace Lab1_Shvets_
{
    partial class frmParent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретическиеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.практическиеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ответыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вопросыToolStripMenuItem,
            this.ответыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вопросыToolStripMenuItem
            // 
            this.вопросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теоретическиеВопросыToolStripMenuItem,
            this.практическиеВопросыToolStripMenuItem});
            this.вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            this.вопросыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // теоретическиеВопросыToolStripMenuItem
            // 
            this.теоретическиеВопросыToolStripMenuItem.Name = "теоретическиеВопросыToolStripMenuItem";
            this.теоретическиеВопросыToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.теоретическиеВопросыToolStripMenuItem.Text = "Теоретические вопросы";
            this.теоретическиеВопросыToolStripMenuItem.Click += new System.EventHandler(this.теоретическиеВопросыToolStripMenuItem_Click);
            // 
            // практическиеВопросыToolStripMenuItem
            // 
            this.практическиеВопросыToolStripMenuItem.Name = "практическиеВопросыToolStripMenuItem";
            this.практическиеВопросыToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.практическиеВопросыToolStripMenuItem.Text = "Практические вопросы";
            this.практическиеВопросыToolStripMenuItem.Click += new System.EventHandler(this.практическиеВопросыToolStripMenuItem_Click);
            // 
            // ответыToolStripMenuItem
            // 
            this.ответыToolStripMenuItem.Name = "ответыToolStripMenuItem";
            this.ответыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ответыToolStripMenuItem.Text = "Ответы";
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 596);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmParent";
            this.Text = "Зачет по теоретической механике";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоретическиеВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem практическиеВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ответыToolStripMenuItem;
    }
}

