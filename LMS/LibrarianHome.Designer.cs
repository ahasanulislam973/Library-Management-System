namespace LMS
{
    partial class LibrarianHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoticeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteNoticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bookListToolStripMenuItem,
            this.addNoticeToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.fileToolStripMenuItem.Text = "Add Books";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // bookListToolStripMenuItem
            // 
            this.bookListToolStripMenuItem.Name = "bookListToolStripMenuItem";
            this.bookListToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.bookListToolStripMenuItem.Text = "BookList";
            this.bookListToolStripMenuItem.Click += new System.EventHandler(this.bookListToolStripMenuItem_Click);
            // 
            // addNoticeToolStripMenuItem
            // 
            this.addNoticeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoticeToolStripMenuItem1,
            this.updateDeleteNoticeToolStripMenuItem});
            this.addNoticeToolStripMenuItem.Name = "addNoticeToolStripMenuItem";
            this.addNoticeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.addNoticeToolStripMenuItem.Text = "Notice";
            this.addNoticeToolStripMenuItem.Click += new System.EventHandler(this.addNoticeToolStripMenuItem_Click);
            // 
            // addNoticeToolStripMenuItem1
            // 
            this.addNoticeToolStripMenuItem1.Name = "addNoticeToolStripMenuItem1";
            this.addNoticeToolStripMenuItem1.Size = new System.Drawing.Size(258, 26);
            this.addNoticeToolStripMenuItem1.Text = "Add Notice";
            this.addNoticeToolStripMenuItem1.Click += new System.EventHandler(this.addNoticeToolStripMenuItem1_Click);
            // 
            // updateDeleteNoticeToolStripMenuItem
            // 
            this.updateDeleteNoticeToolStripMenuItem.Name = "updateDeleteNoticeToolStripMenuItem";
            this.updateDeleteNoticeToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.updateDeleteNoticeToolStripMenuItem.Text = "Update and Delete Notice";
            this.updateDeleteNoticeToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteNoticeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1090, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // LibrarianHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.Library1;
            this.ClientSize = new System.Drawing.Size(1177, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibrarianHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianHome";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookListToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem addNoticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoticeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteNoticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;

    }
}