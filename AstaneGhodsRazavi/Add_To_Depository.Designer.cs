
namespace AstaneGhodsRazavi
{
    partial class Add_To_Depository
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_AddToDepository = new System.Windows.Forms.TabPage();
            this.TP_Food = new System.Windows.Forms.TabPage();
            this.TP_Clothing = new System.Windows.Forms.TabPage();
            this.TP_Tottal = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_AddToDepository);
            this.tabControl1.Controls.Add(this.TP_Food);
            this.tabControl1.Controls.Add(this.TP_Clothing);
            this.tabControl1.Controls.Add(this.TP_Tottal);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // TP_AddToDepository
            // 
            this.TP_AddToDepository.BackColor = System.Drawing.Color.Transparent;
            this.TP_AddToDepository.Location = new System.Drawing.Point(4, 29);
            this.TP_AddToDepository.Name = "TP_AddToDepository";
            this.TP_AddToDepository.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TP_AddToDepository.Size = new System.Drawing.Size(793, 337);
            this.TP_AddToDepository.TabIndex = 3;
            this.TP_AddToDepository.Text = "اضافه کردن به انبار";
            this.TP_AddToDepository.Click += new System.EventHandler(this.TP_AddToDepository_Click);
            // 
            // TP_Food
            // 
            this.TP_Food.BackColor = System.Drawing.Color.Transparent;
            this.TP_Food.Location = new System.Drawing.Point(4, 29);
            this.TP_Food.Name = "TP_Food";
            this.TP_Food.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Food.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TP_Food.Size = new System.Drawing.Size(793, 337);
            this.TP_Food.TabIndex = 1;
            this.TP_Food.Text = "خوراکی";
            this.TP_Food.Click += new System.EventHandler(this.TP_Food_Click);
            // 
            // TP_Clothing
            // 
            this.TP_Clothing.BackColor = System.Drawing.Color.Transparent;
            this.TP_Clothing.Location = new System.Drawing.Point(4, 29);
            this.TP_Clothing.Name = "TP_Clothing";
            this.TP_Clothing.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Clothing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TP_Clothing.Size = new System.Drawing.Size(793, 337);
            this.TP_Clothing.TabIndex = 2;
            this.TP_Clothing.Text = "پوشاک";
            // 
            // TP_Tottal
            // 
            this.TP_Tottal.BackColor = System.Drawing.Color.Transparent;
            this.TP_Tottal.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TP_Tottal.ForeColor = System.Drawing.Color.DarkRed;
            this.TP_Tottal.Location = new System.Drawing.Point(4, 29);
            this.TP_Tottal.Name = "TP_Tottal";
            this.TP_Tottal.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Tottal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TP_Tottal.Size = new System.Drawing.Size(793, 337);
            this.TP_Tottal.TabIndex = 0;
            this.TP_Tottal.Text = "کل موجودی";
            // 
            // Add_To_Depository
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 394);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_To_Depository";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Add_To_Depository";
            this.Load += new System.EventHandler(this.Add_To_Depository_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_Tottal;
        private System.Windows.Forms.TabPage TP_Food;
        private System.Windows.Forms.TabPage TP_Clothing;
        private System.Windows.Forms.TabPage TP_AddToDepository;
    }
}