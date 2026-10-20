namespace лаб_43
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.масивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірнийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масивToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // масивToolStripMenuItem
            // 
            this.масивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірнийToolStripMenuItem,
            this.двовимірнийToolStripMenuItem});
            this.масивToolStripMenuItem.Name = "масивToolStripMenuItem";
            this.масивToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.масивToolStripMenuItem.Text = "Масив";
            // 
            // одновимірнийToolStripMenuItem
            // 
            this.одновимірнийToolStripMenuItem.Name = "одновимірнийToolStripMenuItem";
            this.одновимірнийToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.одновимірнийToolStripMenuItem.Text = "Одновимірний";
            this.одновимірнийToolStripMenuItem.Click += new System.EventHandler(this.одновимірнийToolStripMenuItem_Click);
            // 
            // двовимірнийToolStripMenuItem
            // 
            this.двовимірнийToolStripMenuItem.Name = "двовимірнийToolStripMenuItem";
            this.двовимірнийToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.двовимірнийToolStripMenuItem.Text = "Двовимірний";
            this.двовимірнийToolStripMenuItem.Click += new System.EventHandler(this.двовимірнийToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem масивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірнийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірнийToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

