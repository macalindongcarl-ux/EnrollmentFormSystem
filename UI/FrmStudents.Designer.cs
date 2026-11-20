namespace UI
{
    partial class FrmStudents
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
            DASHBOARD = new Label();
            lblWelcome = new Label();
            pnlStudentInfo = new Panel();
            lblStudentInfoHeader = new Label();
            lblStudentNumber = new Label();
            txtStudentNumber = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContactNumber = new Label();
            txtContactNumber = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGuardianName = new Label();
            txtGuardianName = new TextBox();
            lblGuardianContact = new Label();
            txtGuardianContact = new TextBox();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteStudent = new Button();
            btnClearStudent = new Button();
            pnlStudentRecords = new Panel();
            lblStudentRecordsHeader = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvStudents = new DataGridView();
            pnlStudentInfo.SuspendLayout();
            pnlStudentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(203, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "STUDENTS";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(462, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Manage, register, and update student records in the system.";
            // 
            // pnlStudentInfo
            // 
            pnlStudentInfo.BackColor = Color.White;
            pnlStudentInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlStudentInfo.Controls.Add(btnClearStudent);
            pnlStudentInfo.Controls.Add(btnDeleteStudent);
            pnlStudentInfo.Controls.Add(btnUpdateStudent);
            pnlStudentInfo.Controls.Add(btnAddStudent);
            pnlStudentInfo.Controls.Add(txtGuardianContact);
            pnlStudentInfo.Controls.Add(lblGuardianContact);
            pnlStudentInfo.Controls.Add(txtGuardianName);
            pnlStudentInfo.Controls.Add(lblGuardianName);
            pnlStudentInfo.Controls.Add(txtEmail);
            pnlStudentInfo.Controls.Add(lblEmail);
            pnlStudentInfo.Controls.Add(txtContactNumber);
            pnlStudentInfo.Controls.Add(lblContactNumber);
            pnlStudentInfo.Controls.Add(txtAddress);
            pnlStudentInfo.Controls.Add(lblAddress);
            pnlStudentInfo.Controls.Add(cboGender);
            pnlStudentInfo.Controls.Add(lblGender);
            pnlStudentInfo.Controls.Add(dtpDateOfBirth);
            pnlStudentInfo.Controls.Add(lblDateOfBirth);
            pnlStudentInfo.Controls.Add(txtLastName);
            pnlStudentInfo.Controls.Add(lblLastName);
            pnlStudentInfo.Controls.Add(txtMiddleName);
            pnlStudentInfo.Controls.Add(lblMiddleName);
            pnlStudentInfo.Controls.Add(txtFirstName);
            pnlStudentInfo.Controls.Add(lblFirstName);
            pnlStudentInfo.Controls.Add(txtStudentNumber);
            pnlStudentInfo.Controls.Add(lblStudentNumber);
            pnlStudentInfo.Controls.Add(lblStudentInfoHeader);
            pnlStudentInfo.Location = new Point(24, 118);
            pnlStudentInfo.Name = "pnlStudentInfo";
            pnlStudentInfo.Size = new Size(1532, 330);
            pnlStudentInfo.TabIndex = 2;
            // 
            // lblStudentInfoHeader
            // 
            lblStudentInfoHeader.AutoSize = true;
            lblStudentInfoHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentInfoHeader.Location = new Point(24, 16);
            lblStudentInfoHeader.Name = "lblStudentInfoHeader";
            lblStudentInfoHeader.Size = new Size(256, 37);
            lblStudentInfoHeader.TabIndex = 0;
            lblStudentInfoHeader.Text = "Student Information";
            // 
            // lblStudentNumber
            // 
            lblStudentNumber.AutoSize = true;
            lblStudentNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentNumber.Location = new Point(24, 65);
            lblStudentNumber.Name = "lblStudentNumber";
            lblStudentNumber.Size = new Size(182, 25);
            lblStudentNumber.TabIndex = 1;
            lblStudentNumber.Text = "Student Number / LRN";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentNumber.Location = new Point(24, 92);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.PlaceholderText = "e.g., 2026-0051";
            txtStudentNumber.Size = new Size(235, 33);
            txtStudentNumber.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(279, 65);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(94, 25);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(279, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(245, 33);
            txtFirstName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(544, 65);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(192, 25);
            lblMiddleName.TabIndex = 5;
            lblMiddleName.Text = "Middle Name (Optional)";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(544, 92);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.PlaceholderText = "Middle Name";
            txtMiddleName.Size = new Size(235, 33);
            txtMiddleName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(799, 65);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(92, 25);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(799, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(245, 33);
            txtLastName.TabIndex = 8;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.Location = new Point(1064, 65);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(109, 25);
            lblDateOfBirth.TabIndex = 9;
            lblDateOfBirth.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(1064, 92);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(220, 33);
            dtpDateOfBirth.TabIndex = 10;
            dtpDateOfBirth.Value = new DateTime(2012, 1, 1, 0, 0, 0, 0);
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(1304, 65);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 25);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(1304, 92);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(202, 34);
            cboGender.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(24, 142);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(73, 25);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(24, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Street, Barangay, Municipality / City, Province";
            txtAddress.Size = new Size(500, 33);
            txtAddress.TabIndex = 14;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(544, 142);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(218, 25);
            lblContactNumber.TabIndex = 15;
            lblContactNumber.Text = "Contact Number (Optional)";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNumber.Location = new Point(544, 169);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PlaceholderText = "e.g., 09171234567";
            txtContactNumber.Size = new Size(235, 33);
            txtContactNumber.TabIndex = 16;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(799, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(127, 25);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email (Optional)";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(799, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "student@email.com";
            txtEmail.Size = new Size(245, 33);
            txtEmail.TabIndex = 18;
            // 
            // lblGuardianName
            // 
            lblGuardianName.AutoSize = true;
            lblGuardianName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuardianName.Location = new Point(1064, 142);
            lblGuardianName.Name = "lblGuardianName";
            lblGuardianName.Size = new Size(134, 25);
            lblGuardianName.TabIndex = 19;
            lblGuardianName.Text = "Guardian Name";
            // 
            // txtGuardianName
            // 
            txtGuardianName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianName.Location = new Point(1064, 169);
            txtGuardianName.Name = "txtGuardianName";
            txtGuardianName.PlaceholderText = "Parent / Guardian Full Name";
            txtGuardianName.Size = new Size(220, 33);
            txtGuardianName.TabIndex = 20;
            // 
            // lblGuardianContact
            // 
            lblGuardianContact.AutoSize = true;
            lblGuardianContact.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuardianContact.Location = new Point(1304, 142);
            lblGuardianContact.Name = "lblGuardianContact";
            lblGuardianContact.Size = new Size(149, 25);
            lblGuardianContact.TabIndex = 21;
            lblGuardianContact.Text = "Guardian Contact";
            // 
            // txtGuardianContact
            // 
            txtGuardianContact.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianContact.Location = new Point(1304, 169);
            txtGuardianContact.Name = "txtGuardianContact";
            txtGuardianContact.PlaceholderText = "09181234567";
            txtGuardianContact.Size = new Size(202, 33);
            txtGuardianContact.TabIndex = 22;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(52, 118, 184);
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(24, 232);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(165, 42);
            btnAddStudent.TabIndex = 23;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateStudent.FlatAppearance.BorderSize = 0;
            btnUpdateStudent.FlatStyle = FlatStyle.Flat;
            btnUpdateStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(205, 232);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(165, 42);
            btnUpdateStudent.TabIndex = 24;
            btnUpdateStudent.Text = "Update";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.FromArgb(200, 60, 60);
            btnDeleteStudent.FlatAppearance.BorderSize = 0;
            btnDeleteStudent.FlatStyle = FlatStyle.Flat;
            btnDeleteStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudent.ForeColor = Color.White;
            btnDeleteStudent.Location = new Point(386, 232);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(165, 42);
            btnDeleteStudent.TabIndex = 25;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnClearStudent
            // 
            btnClearStudent.BackColor = Color.Gray;
            btnClearStudent.FlatAppearance.BorderSize = 0;
            btnClearStudent.FlatStyle = FlatStyle.Flat;
            btnClearStudent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearStudent.ForeColor = Color.White;
            btnClearStudent.Location = new Point(567, 232);
            btnClearStudent.Name = "btnClearStudent";
            btnClearStudent.Size = new Size(165, 42);
            btnClearStudent.TabIndex = 26;
            btnClearStudent.Text = "Clear";
            btnClearStudent.UseVisualStyleBackColor = false;
            btnClearStudent.Click += btnClearStudent_Click;
            // 
            // pnlStudentRecords
            // 
            pnlStudentRecords.BackColor = Color.White;
            pnlStudentRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlStudentRecords.Controls.Add(dgvStudents);
            pnlStudentRecords.Controls.Add(btnSearch);
            pnlStudentRecords.Controls.Add(txtSearch);
            pnlStudentRecords.Controls.Add(lblSearch);
            pnlStudentRecords.Controls.Add(lblStudentRecordsHeader);
            pnlStudentRecords.Location = new Point(24, 468);
            pnlStudentRecords.Name = "pnlStudentRecords";
            pnlStudentRecords.Size = new Size(1532, 588);
            pnlStudentRecords.TabIndex = 3;
            // 
            // lblStudentRecordsHeader
            // 
            lblStudentRecordsHeader.AutoSize = true;
            lblStudentRecordsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentRecordsHeader.Location = new Point(24, 22);
            lblStudentRecordsHeader.Name = "lblStudentRecordsHeader";
            lblStudentRecordsHeader.Size = new Size(216, 37);
            lblStudentRecordsHeader.TabIndex = 0;
            lblStudentRecordsHeader.Text = "Student Records";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1064, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(210, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by ID or Name";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1064, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type student number or name...";
            txtSearch.Size = new Size(310, 33);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(100, 116, 139);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1386, 39);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(24, 92);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(1482, 472);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlStudentRecords);
            Controls.Add(pnlStudentInfo);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmStudents";
            Text = "FrmStudents";
            Load += FrmStudents_Load;
            pnlStudentInfo.ResumeLayout(false);
            pnlStudentInfo.PerformLayout();
            pnlStudentRecords.ResumeLayout(false);
            pnlStudentRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlStudentInfo;
        private Label lblStudentInfoHeader;
        private Label lblStudentNumber;
        private TextBox txtStudentNumber;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblGender;
        private ComboBox cboGender;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContactNumber;
        private TextBox txtContactNumber;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblGuardianName;
        private TextBox txtGuardianName;
        private Label lblGuardianContact;
        private TextBox txtGuardianContact;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteStudent;
        private Button btnClearStudent;
        private Panel pnlStudentRecords;
        private Label lblStudentRecordsHeader;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvStudents;
    }
}