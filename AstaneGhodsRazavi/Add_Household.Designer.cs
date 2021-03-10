
namespace AstaneGhodsRazavi
{
    partial class Add_Household
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBoxSex = new System.Windows.Forms.ComboBox();
            this.cBoxServiceType = new System.Windows.Forms.ComboBox();
            this.cBoxRentStatus = new System.Windows.Forms.ComboBox();
            this.cBoxChildeCount = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNationID = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRequestDoctor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(649, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBoxSex);
            this.panel1.Controls.Add(this.cBoxServiceType);
            this.panel1.Controls.Add(this.cBoxRentStatus);
            this.panel1.Controls.Add(this.cBoxChildeCount);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtNationID);
            this.panel1.Controls.Add(this.txtFatherName);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtFamily);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(227, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 234);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cBoxSex
            // 
            this.cBoxSex.ForeColor = System.Drawing.Color.Blue;
            this.cBoxSex.FormattingEnabled = true;
            this.cBoxSex.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cBoxSex.Location = new System.Drawing.Point(584, 149);
            this.cBoxSex.Name = "cBoxSex";
            this.cBoxSex.Size = new System.Drawing.Size(58, 28);
            this.cBoxSex.TabIndex = 5;
            // 
            // cBoxServiceType
            // 
            this.cBoxServiceType.ForeColor = System.Drawing.Color.Blue;
            this.cBoxServiceType.FormattingEnabled = true;
            this.cBoxServiceType.Items.AddRange(new object[] {
            "درمانی",
            "مالی",
            "ارزاق",
            "پوشاک"});
            this.cBoxServiceType.Location = new System.Drawing.Point(163, 184);
            this.cBoxServiceType.Name = "cBoxServiceType";
            this.cBoxServiceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBoxServiceType.Size = new System.Drawing.Size(234, 28);
            this.cBoxServiceType.TabIndex = 11;
            // 
            // cBoxRentStatus
            // 
            this.cBoxRentStatus.ForeColor = System.Drawing.Color.Blue;
            this.cBoxRentStatus.FormattingEnabled = true;
            this.cBoxRentStatus.Items.AddRange(new object[] {
            "مالک",
            "اجاره",
            "رهن",
            "اجاره + رهن"});
            this.cBoxRentStatus.Location = new System.Drawing.Point(253, 150);
            this.cBoxRentStatus.Name = "cBoxRentStatus";
            this.cBoxRentStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBoxRentStatus.Size = new System.Drawing.Size(144, 28);
            this.cBoxRentStatus.TabIndex = 10;
            // 
            // cBoxChildeCount
            // 
            this.cBoxChildeCount.ForeColor = System.Drawing.Color.Blue;
            this.cBoxChildeCount.FormattingEnabled = true;
            this.cBoxChildeCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cBoxChildeCount.Location = new System.Drawing.Point(337, 116);
            this.cBoxChildeCount.Name = "cBoxChildeCount";
            this.cBoxChildeCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBoxChildeCount.Size = new System.Drawing.Size(60, 28);
            this.cBoxChildeCount.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.Color.Blue;
            this.txtPhone.Location = new System.Drawing.Point(496, 182);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // txtNationID
            // 
            this.txtNationID.ForeColor = System.Drawing.Color.Blue;
            this.txtNationID.Location = new System.Drawing.Point(496, 116);
            this.txtNationID.Name = "txtNationID";
            this.txtNationID.Size = new System.Drawing.Size(146, 27);
            this.txtNationID.TabIndex = 4;
            // 
            // txtFatherName
            // 
            this.txtFatherName.ForeColor = System.Drawing.Color.Blue;
            this.txtFatherName.Location = new System.Drawing.Point(496, 83);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFatherName.Size = new System.Drawing.Size(146, 27);
            this.txtFatherName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Blue;
            this.txtAddress.Location = new System.Drawing.Point(163, 47);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(234, 63);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFamily
            // 
            this.txtFamily.ForeColor = System.Drawing.Color.Blue;
            this.txtFamily.Location = new System.Drawing.Point(496, 50);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFamily.Size = new System.Drawing.Size(146, 27);
            this.txtFamily.TabIndex = 2;
            this.txtFamily.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.ForeColor = System.Drawing.Color.Blue;
            this.txtAge.Location = new System.Drawing.Point(345, 14);
            this.txtAge.Name = "txtAge";
            this.txtAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAge.Size = new System.Drawing.Size(52, 27);
            this.txtAge.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(496, 17);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(649, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "شماره تلفن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(649, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "جنسیت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(649, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "کد ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(649, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام پدر";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(404, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "نوع خدمات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(404, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "وضعیت سکونت";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(404, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "تعداد فرزندان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(404, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "آدرس";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(404, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "سن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(649, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام خانوادگی";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(853, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "جستجو با کدملی";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Blue;
            this.txtSearch.Location = new System.Drawing.Point(723, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(100, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(875, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(794, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "بروزرسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(938, 255);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "حذف رکورد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 60);
            this.label13.TabIndex = 16;
            this.label13.Text = "برنامه نویس: فرشاد نعمت پور\r\nدر صورت وجود مشکل با این شماره تماس بگیرید\r\n09167856" +
    "911";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRequestDoctor
            // 
            this.btnRequestDoctor.ForeColor = System.Drawing.Color.Brown;
            this.btnRequestDoctor.Location = new System.Drawing.Point(601, 282);
            this.btnRequestDoctor.Name = "btnRequestDoctor";
            this.btnRequestDoctor.Size = new System.Drawing.Size(106, 34);
            this.btnRequestDoctor.TabIndex = 17;
            this.btnRequestDoctor.Text = "درخواست پزشکی";
            this.btnRequestDoctor.UseVisualStyleBackColor = true;
            this.btnRequestDoctor.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Add_Household
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 592);
            this.Controls.Add(this.btnRequestDoctor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Add_Household";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم خدمت رسانی به نیازمندان آستان قدس رضوی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNationID;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxChildeCount;
        private System.Windows.Forms.ComboBox cBoxRentStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cBoxSex;
        private System.Windows.Forms.ComboBox cBoxServiceType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRequestDoctor;
    }
}

