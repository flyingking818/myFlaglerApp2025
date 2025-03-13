namespace myFlaglerApp2025
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
            this.grpPersonnel = new System.Windows.Forms.GroupBox();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoProfessor = new System.Windows.Forms.RadioButton();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProfessor = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.chkTerminalDegree = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResearchArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.dtpEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdMajor = new System.Windows.Forms.ComboBox();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.chkAdministrative = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDisplayProfile = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPersonnel.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            this.grpProfessor.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonnel
            // 
            this.grpPersonnel.Controls.Add(this.rdoStaff);
            this.grpPersonnel.Controls.Add(this.rdoStudent);
            this.grpPersonnel.Controls.Add(this.rdoProfessor);
            this.grpPersonnel.Location = new System.Drawing.Point(48, 36);
            this.grpPersonnel.Name = "grpPersonnel";
            this.grpPersonnel.Size = new System.Drawing.Size(585, 111);
            this.grpPersonnel.TabIndex = 0;
            this.grpPersonnel.TabStop = false;
            this.grpPersonnel.Text = "Personnel";
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Location = new System.Drawing.Point(376, 47);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(87, 29);
            this.rdoStaff.TabIndex = 2;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Staff";
            this.rdoStaff.UseVisualStyleBackColor = true;
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(217, 47);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(117, 29);
            this.rdoStudent.TabIndex = 1;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoProfessor
            // 
            this.rdoProfessor.AutoSize = true;
            this.rdoProfessor.Location = new System.Drawing.Point(32, 47);
            this.rdoProfessor.Name = "rdoProfessor";
            this.rdoProfessor.Size = new System.Drawing.Size(135, 29);
            this.rdoProfessor.TabIndex = 0;
            this.rdoProfessor.TabStop = true;
            this.rdoProfessor.Text = "Professor";
            this.rdoProfessor.UseVisualStyleBackColor = true;
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.Controls.Add(this.txtEmail);
            this.grpBasicInfo.Controls.Add(this.label3);
            this.grpBasicInfo.Controls.Add(this.txtID);
            this.grpBasicInfo.Controls.Add(this.label2);
            this.grpBasicInfo.Controls.Add(this.txtName);
            this.grpBasicInfo.Controls.Add(this.label1);
            this.grpBasicInfo.Location = new System.Drawing.Point(80, 170);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(704, 242);
            this.grpBasicInfo.TabIndex = 1;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Information";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(433, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(211, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(433, 31);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(433, 31);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grpProfessor
            // 
            this.grpProfessor.Controls.Add(this.cmbDepartment);
            this.grpProfessor.Controls.Add(this.chkTerminalDegree);
            this.grpProfessor.Controls.Add(this.textBox1);
            this.grpProfessor.Controls.Add(this.label4);
            this.grpProfessor.Controls.Add(this.txtResearchArea);
            this.grpProfessor.Controls.Add(this.label5);
            this.grpProfessor.Controls.Add(this.label6);
            this.grpProfessor.Location = new System.Drawing.Point(80, 453);
            this.grpProfessor.Name = "grpProfessor";
            this.grpProfessor.Size = new System.Drawing.Size(704, 242);
            this.grpProfessor.TabIndex = 6;
            this.grpProfessor.TabStop = false;
            this.grpProfessor.Text = "Professor Information";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Math and Technology",
            "Sports Management",
            "Business Administration",
            "Fine Arts",
            "Psychology",
            "Other"});
            this.cmbDepartment.Location = new System.Drawing.Point(211, 60);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(433, 33);
            this.cmbDepartment.TabIndex = 7;
            // 
            // chkTerminalDegree
            // 
            this.chkTerminalDegree.AutoSize = true;
            this.chkTerminalDegree.Location = new System.Drawing.Point(37, 181);
            this.chkTerminalDegree.Name = "chkTerminalDegree";
            this.chkTerminalDegree.Size = new System.Drawing.Size(324, 29);
            this.chkTerminalDegree.TabIndex = 6;
            this.chkTerminalDegree.Text = "Terminal Degree (e.g., PhD)?";
            this.chkTerminalDegree.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, -102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 31);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 4;
            // 
            // txtResearchArea
            // 
            this.txtResearchArea.Location = new System.Drawing.Point(211, 118);
            this.txtResearchArea.Name = "txtResearchArea";
            this.txtResearchArea.Size = new System.Drawing.Size(433, 31);
            this.txtResearchArea.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Research Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department:";
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.dtpEnrollmentDate);
            this.grpStudent.Controls.Add(this.label10);
            this.grpStudent.Controls.Add(this.cmdMajor);
            this.grpStudent.Controls.Add(this.chkFullTime);
            this.grpStudent.Controls.Add(this.textBox2);
            this.grpStudent.Controls.Add(this.label7);
            this.grpStudent.Controls.Add(this.txtGPA);
            this.grpStudent.Controls.Add(this.label8);
            this.grpStudent.Controls.Add(this.label9);
            this.grpStudent.Location = new System.Drawing.Point(813, 453);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(704, 242);
            this.grpStudent.TabIndex = 8;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Information";
            // 
            // dtpEnrollmentDate
            // 
            this.dtpEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnrollmentDate.Location = new System.Drawing.Point(211, 181);
            this.dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            this.dtpEnrollmentDate.Size = new System.Drawing.Size(217, 31);
            this.dtpEnrollmentDate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Enrollment Date:";
            // 
            // cmdMajor
            // 
            this.cmdMajor.FormattingEnabled = true;
            this.cmdMajor.Items.AddRange(new object[] {
            "Computer Information Systems",
            "Data Science",
            "Business Administration",
            "Accounting",
            "Finance",
            "English",
            "Education",
            "Other"});
            this.cmdMajor.Location = new System.Drawing.Point(211, 60);
            this.cmdMajor.Name = "cmdMajor";
            this.cmdMajor.Size = new System.Drawing.Size(433, 33);
            this.cmdMajor.TabIndex = 7;
            // 
            // chkFullTime
            // 
            this.chkFullTime.AutoSize = true;
            this.chkFullTime.Location = new System.Drawing.Point(498, 185);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(146, 29);
            this.chkFullTime.TabIndex = 6;
            this.chkFullTime.Text = "Is fulltime?";
            this.chkFullTime.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, -102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 31);
            this.textBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 4;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(211, 118);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(152, 31);
            this.txtGPA.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "GPA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Major:";
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.txtPosition);
            this.grpStaff.Controls.Add(this.chkAdministrative);
            this.grpStaff.Controls.Add(this.textBox3);
            this.grpStaff.Controls.Add(this.label12);
            this.grpStaff.Controls.Add(this.txtDivision);
            this.grpStaff.Controls.Add(this.label13);
            this.grpStaff.Controls.Add(this.label14);
            this.grpStaff.Location = new System.Drawing.Point(1549, 453);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(704, 242);
            this.grpStaff.TabIndex = 10;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Staff Information";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(211, 63);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(433, 31);
            this.txtPosition.TabIndex = 8;
            // 
            // chkAdministrative
            // 
            this.chkAdministrative.AutoSize = true;
            this.chkAdministrative.Location = new System.Drawing.Point(37, 185);
            this.chkAdministrative.Name = "chkAdministrative";
            this.chkAdministrative.Size = new System.Drawing.Size(211, 29);
            this.chkAdministrative.TabIndex = 6;
            this.chkAdministrative.Text = "Is administrative?";
            this.chkAdministrative.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, -102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 31);
            this.textBox3.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 4;
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(211, 118);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(433, 31);
            this.txtDivision.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Division:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Position:";
            // 
            // btnDisplayProfile
            // 
            this.btnDisplayProfile.Location = new System.Drawing.Point(80, 760);
            this.btnDisplayProfile.Name = "btnDisplayProfile";
            this.btnDisplayProfile.Size = new System.Drawing.Size(284, 42);
            this.btnDisplayProfile.TabIndex = 11;
            this.btnDisplayProfile.Text = "Display Profile";
            this.btnDisplayProfile.UseVisualStyleBackColor = true;
            this.btnDisplayProfile.Click += new System.EventHandler(this.btnDisplayProfile_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(429, 769);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 25);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "label11";
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(816, 27);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(405, 385);
            this.picProfile.TabIndex = 13;
            this.picProfile.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(1311, 323);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(244, 74);
            this.btnUploadImage.TabIndex = 14;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Location = new System.Drawing.Point(80, 823);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersWidth = 82;
            this.dgvPeople.RowTemplate.Height = 33;
            this.dgvPeople.Size = new System.Drawing.Size(2162, 424);
            this.dgvPeople.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1687, 758);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 43);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Profile";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2285, 1259);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDisplayProfile);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.grpStudent);
            this.Controls.Add(this.grpProfessor);
            this.Controls.Add(this.grpBasicInfo);
            this.Controls.Add(this.grpPersonnel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.grpPersonnel.ResumeLayout(false);
            this.grpPersonnel.PerformLayout();
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.grpProfessor.ResumeLayout(false);
            this.grpProfessor.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonnel;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoProfessor;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpProfessor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResearchArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkTerminalDegree;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.ComboBox cmdMajor;
        private System.Windows.Forms.CheckBox chkFullTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEnrollmentDate;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.CheckBox chkAdministrative;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnDisplayProfile;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btnAdd;
    }
}

