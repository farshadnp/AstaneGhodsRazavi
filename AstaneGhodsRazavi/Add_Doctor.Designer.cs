
namespace AstaneGhodsRazavi
{
    partial class Add_Doctor
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DGVDoctor = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorNationCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorTypeOfAssist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorAddressOfOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorOfficeTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelOfOffice = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cBoxSex = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNationID = new System.Windows.Forms.TextBox();
            this.txtAddressOfOffice = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtTypeOfAssist = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(689, 325);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.Location = new System.Drawing.Point(666, 21);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(98, 20);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "جستجو با نام پزشک";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(608, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "بروزرسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // DGVDoctor
            // 
            this.DGVDoctor.AllowUserToAddRows = false;
            this.DGVDoctor.AllowUserToDeleteRows = false;
            this.DGVDoctor.BackgroundColor = System.Drawing.Color.Beige;
            this.DGVDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.DoctorFName,
            this.DoctorLName,
            this.DoctorNationCode,
            this.DoctorGender,
            this.DoctorPhoneNumber,
            this.DoctorBD,
            this.Specialty,
            this.DoctorTypeOfAssist,
            this.DoctorAddressOfOffice,
            this.DoctorOfficeTelephone});
            this.DGVDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVDoctor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVDoctor.Location = new System.Drawing.Point(0, 361);
            this.DGVDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVDoctor.Name = "DGVDoctor";
            this.DGVDoctor.ReadOnly = true;
            this.DGVDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVDoctor.Size = new System.Drawing.Size(784, 200);
            this.DGVDoctor.TabIndex = 23;
            this.DGVDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "ردیف";
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Width = 50;
            // 
            // DoctorFName
            // 
            this.DoctorFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorFName.DataPropertyName = "DoctorFName";
            this.DoctorFName.HeaderText = "نام";
            this.DoctorFName.Name = "DoctorFName";
            this.DoctorFName.ReadOnly = true;
            // 
            // DoctorLName
            // 
            this.DoctorLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorLName.DataPropertyName = "DoctorLName";
            this.DoctorLName.HeaderText = "نام خانوادگی";
            this.DoctorLName.Name = "DoctorLName";
            this.DoctorLName.ReadOnly = true;
            // 
            // DoctorNationCode
            // 
            this.DoctorNationCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorNationCode.DataPropertyName = "DoctorNationCode";
            this.DoctorNationCode.HeaderText = "کدملی";
            this.DoctorNationCode.Name = "DoctorNationCode";
            this.DoctorNationCode.ReadOnly = true;
            // 
            // DoctorGender
            // 
            this.DoctorGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorGender.DataPropertyName = "DoctorGender";
            this.DoctorGender.HeaderText = "جنسیت";
            this.DoctorGender.Name = "DoctorGender";
            this.DoctorGender.ReadOnly = true;
            // 
            // DoctorPhoneNumber
            // 
            this.DoctorPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorPhoneNumber.DataPropertyName = "DoctorPhone";
            this.DoctorPhoneNumber.HeaderText = "تلفن همراه";
            this.DoctorPhoneNumber.Name = "DoctorPhoneNumber";
            this.DoctorPhoneNumber.ReadOnly = true;
            // 
            // DoctorBD
            // 
            this.DoctorBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorBD.DataPropertyName = "DoctorBirthDate";
            this.DoctorBD.HeaderText = "تاریخ تولد";
            this.DoctorBD.Name = "DoctorBD";
            this.DoctorBD.ReadOnly = true;
            // 
            // Specialty
            // 
            this.Specialty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Specialty.DataPropertyName = "DoctorSpecialty";
            this.Specialty.HeaderText = "تخصص پزشکی";
            this.Specialty.Name = "Specialty";
            this.Specialty.ReadOnly = true;
            // 
            // DoctorTypeOfAssist
            // 
            this.DoctorTypeOfAssist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorTypeOfAssist.DataPropertyName = "DoctorTypeOfAssist";
            this.DoctorTypeOfAssist.HeaderText = "نوع کمک رسانی";
            this.DoctorTypeOfAssist.Name = "DoctorTypeOfAssist";
            this.DoctorTypeOfAssist.ReadOnly = true;
            // 
            // DoctorAddressOfOffice
            // 
            this.DoctorAddressOfOffice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorAddressOfOffice.DataPropertyName = "DoctorOfficeAddress";
            this.DoctorAddressOfOffice.HeaderText = "آدرس مطب";
            this.DoctorAddressOfOffice.Name = "DoctorAddressOfOffice";
            this.DoctorAddressOfOffice.ReadOnly = true;
            // 
            // DoctorOfficeTelephone
            // 
            this.DoctorOfficeTelephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoctorOfficeTelephone.DataPropertyName = "DoctorOfficeTelephone";
            this.DoctorOfficeTelephone.HeaderText = "تلفن مطب";
            this.DoctorOfficeTelephone.Name = "DoctorOfficeTelephone";
            this.DoctorOfficeTelephone.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Blue;
            this.txtSearch.Location = new System.Drawing.Point(537, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(122, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(527, 325);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "حذف رکورد";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelOfOffice);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cBoxSex);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSpecialty);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtNationID);
            this.groupBox1.Controls.Add(this.txtAddressOfOffice);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.txtTypeOfAssist);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("IRAN Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(148, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(616, 257);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت اطلاعات پزشک";
            // 
            // txtTelOfOffice
            // 
            this.txtTelOfOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelOfOffice.ForeColor = System.Drawing.Color.Blue;
            this.txtTelOfOffice.Location = new System.Drawing.Point(144, 137);
            this.txtTelOfOffice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelOfOffice.Name = "txtTelOfOffice";
            this.txtTelOfOffice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTelOfOffice.Size = new System.Drawing.Size(146, 22);
            this.txtTelOfOffice.TabIndex = 72;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(502, 186);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 22);
            this.textBox3.TabIndex = 69;
            // 
            // cBoxSex
            // 
            this.cBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSex.ForeColor = System.Drawing.Color.Blue;
            this.cBoxSex.FormattingEnabled = true;
            this.cBoxSex.Items.AddRange(new object[] {
            "مرد",
            "زن"});
            this.cBoxSex.Location = new System.Drawing.Point(477, 124);
            this.cBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBoxSex.Name = "cBoxSex";
            this.cBoxSex.Size = new System.Drawing.Size(58, 24);
            this.cBoxSex.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Blue;
            this.textBox2.Location = new System.Drawing.Point(463, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 22);
            this.textBox2.TabIndex = 70;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(389, 186);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 22);
            this.textBox1.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(542, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "تاریخ تولد";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.ForeColor = System.Drawing.Color.Blue;
            this.txtSpecialty.Location = new System.Drawing.Point(389, 222);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(146, 22);
            this.txtSpecialty.TabIndex = 65;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Blue;
            this.txtPhone.Location = new System.Drawing.Point(389, 156);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 22);
            this.txtPhone.TabIndex = 64;
            // 
            // txtNationID
            // 
            this.txtNationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationID.ForeColor = System.Drawing.Color.Blue;
            this.txtNationID.Location = new System.Drawing.Point(389, 94);
            this.txtNationID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationID.Name = "txtNationID";
            this.txtNationID.Size = new System.Drawing.Size(146, 22);
            this.txtNationID.TabIndex = 62;
            // 
            // txtAddressOfOffice
            // 
            this.txtAddressOfOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressOfOffice.ForeColor = System.Drawing.Color.Blue;
            this.txtAddressOfOffice.Location = new System.Drawing.Point(56, 64);
            this.txtAddressOfOffice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddressOfOffice.Multiline = true;
            this.txtAddressOfOffice.Name = "txtAddressOfOffice";
            this.txtAddressOfOffice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddressOfOffice.Size = new System.Drawing.Size(234, 65);
            this.txtAddressOfOffice.TabIndex = 67;
            // 
            // txtFamily
            // 
            this.txtFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamily.ForeColor = System.Drawing.Color.Blue;
            this.txtFamily.Location = new System.Drawing.Point(389, 64);
            this.txtFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFamily.Size = new System.Drawing.Size(146, 22);
            this.txtFamily.TabIndex = 61;
            // 
            // txtTypeOfAssist
            // 
            this.txtTypeOfAssist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfAssist.ForeColor = System.Drawing.Color.Blue;
            this.txtTypeOfAssist.Location = new System.Drawing.Point(238, 34);
            this.txtTypeOfAssist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeOfAssist.Name = "txtTypeOfAssist";
            this.txtTypeOfAssist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTypeOfAssist.Size = new System.Drawing.Size(52, 22);
            this.txtTypeOfAssist.TabIndex = 66;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Blue;
            this.txtName.Location = new System.Drawing.Point(389, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(146, 22);
            this.txtName.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(542, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "شماره تلفن";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(542, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "تخصص";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(542, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "جنسیت";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(542, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "کد ملی";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(297, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 54;
            this.label12.Text = "شماره مطب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(296, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "آدرس مطب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(297, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "نوع همکاری";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(542, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRAN Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(542, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "نام";
            // 
            // Add_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.DGVDoctor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("IRAN Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن پزشک";
            this.Load += new System.EventHandler(this.Add_Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDoctor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView DGVDoctor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorNationCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorTypeOfAssist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorAddressOfOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorOfficeTelephone;
        private System.Windows.Forms.TextBox txtTelOfOffice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cBoxSex;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtNationID;
        private System.Windows.Forms.TextBox txtAddressOfOffice;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtTypeOfAssist;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}