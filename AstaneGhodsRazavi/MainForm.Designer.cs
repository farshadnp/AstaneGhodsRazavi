
namespace AstaneGhodsRazavi
{
    partial class MainForm
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکردنخانوارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکردنپزشکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهکردنکانونToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تماسباپشتیبانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهکردنخانوارToolStripMenuItem,
            this.اضافهکردنپزشکToolStripMenuItem,
            this.اضافهکردنکانونToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 21);
            this.toolStripMenuItem1.Text = "اضافه کردن";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // اضافهکردنخانوارToolStripMenuItem
            // 
            this.اضافهکردنخانوارToolStripMenuItem.Name = "اضافهکردنخانوارToolStripMenuItem";
            this.اضافهکردنخانوارToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.اضافهکردنخانوارToolStripMenuItem.Text = "اضافه کردن خانوار";
            this.اضافهکردنخانوارToolStripMenuItem.Click += new System.EventHandler(this.اضافهکردنخانوارToolStripMenuItem_Click);
            // 
            // اضافهکردنپزشکToolStripMenuItem
            // 
            this.اضافهکردنپزشکToolStripMenuItem.Name = "اضافهکردنپزشکToolStripMenuItem";
            this.اضافهکردنپزشکToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.اضافهکردنپزشکToolStripMenuItem.Text = "اضافه کردن پزشک";
            this.اضافهکردنپزشکToolStripMenuItem.Click += new System.EventHandler(this.اضافهکردنپزشکToolStripMenuItem_Click);
            // 
            // اضافهکردنکانونToolStripMenuItem
            // 
            this.اضافهکردنکانونToolStripMenuItem.Name = "اضافهکردنکانونToolStripMenuItem";
            this.اضافهکردنکانونToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.اضافهکردنکانونToolStripMenuItem.Text = "اضافه کردن کانون";
            // 
            // انبارToolStripMenuItem
            // 
            this.انبارToolStripMenuItem.Name = "انبارToolStripMenuItem";
            this.انبارToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.انبارToolStripMenuItem.Text = "انبار";
            this.انبارToolStripMenuItem.Click += new System.EventHandler(this.انبارToolStripMenuItem_Click);
            // 
            // تماسباپشتیبانToolStripMenuItem
            // 
            this.تماسباپشتیبانToolStripMenuItem.Name = "تماسباپشتیبانToolStripMenuItem";
            this.تماسباپشتیبانToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.تماسباپشتیبانToolStripMenuItem.Text = "تماس با پشتیبان";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.انبارToolStripMenuItem,
            this.تماسباپشتیبانToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1281, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PanelMain
            // 
            this.PanelMain.AutoSize = true;
            this.PanelMain.Location = new System.Drawing.Point(12, 30);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1257, 667);
            this.PanelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 709);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اضافهکردنخانوارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهکردنپزشکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهکردنکانونToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تماسباپشتیبانToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PanelMain;
    }
}