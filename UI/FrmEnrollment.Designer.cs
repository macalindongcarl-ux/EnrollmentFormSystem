namespace UI
{
    partial class FrmEnrollment
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
            pnlEnrollmentDetails = new Panel();
            lblEnrollmentDetailsHeader = new Label();
            lblStudent = new Label();
            txtStudent = new TextBox();
            lstStudentSuggestions = new ListBox();
            lblSchoolYear = new Label();
            txtSchoolYear = new TextBox();
            lblGradeLevel = new Label();
            cboGradeLevel = new ComboBox();
            lblSection = new Label();
            cboSection = new ComboBox();
            lblEnrollmentDate = new Label();
            dtpEnrollmentDate = new DateTimePicker();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            btnEnroll = new Button();
            btnUpdateEnrollment = new Button();
            btnDeleteEnrollment = new Button();
            btnClearEnrollment = new Button();
            pnlEnrollmentRecords = new Panel();
            lblEnrollmentRecordsHeader = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvEnrollments = new DataGridView();
            pnlEnrollmentDetails.SuspendLayout();
            pnlEnrollmentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(268, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "ENROLLMENT";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(465, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Enroll students and manage section assignments and statuses.";
            // 
            // pnlEnrollmentDetails
            // 
            pnlEnrollmentDetails.BackColor = Color.White;
            pnlEnrollmentDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlEnrollmentDetails.Controls.Add(lstStudentSuggestions);
            pnlEnrollmentDetails.Controls.Add(btnClearEnrollment);
            pnlEnrollmentDetails.Controls.Add(btnDeleteEnrollment);
            pnlEnrollmentDetails.Controls.Add(btnUpdateEnrollment);
            pnlEnrollmentDetails.Controls.Add(btnEnroll);
            pnlEnrollmentDetails.Controls.Add(cboStatus);
            pnlEnrollmentDetails.Controls.Add(lblStatus);
            pnlEnrollmentDetails.Controls.Add(dtpEnrollmentDate);
            pnlEnrollmentDetails.Controls.Add(lblEnrollmentDate);
            pnlEnrollmentDetails.Controls.Add(cboSection);
            pnlEnrollmentDetails.Controls.Add(lblSection);
            pnlEnrollmentDetails.Controls.Add(cboGradeLevel);
            pnlEnrollmentDetails.Controls.Add(lblGradeLevel);
            pnlEnrollmentDetails.Controls.Add(txtSchoolYear);
            pnlEnrollmentDetails.Controls.Add(lblSchoolYear);
            pnlEnrollmentDetails.Controls.Add(txtStudent);
            pnlEnrollmentDetails.Controls.Add(lblStudent);
            pnlEnrollmentDetails.Controls.Add(lblEnrollmentDetailsHeader);
            pnlEnrollmentDetails.Location = new Point(24, 118);
            pnlEnrollmentDetails.Name = "pnlEnrollmentDetails";
            pnlEnrollmentDetails.Size = new Size(1532, 245);
            pnlEnrollmentDetails.TabIndex = 2;
            // 
            // lblEnrollmentDetailsHeader
            // 
            lblEnrollmentDetailsHeader.AutoSize = true;
            lblEnrollmentDetailsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnrollmentDetailsHeader.Location = new Point(24, 16);
            lblEnrollmentDetailsHeader.Name = "lblEnrollmentDetailsHeader";
            lblEnrollmentDetailsHeader.Size = new Size(243, 37);
            lblEnrollmentDetailsHeader.TabIndex = 0;
            lblEnrollmentDetailsHeader.Text = "Enrollment Details";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(24, 68);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(73, 25);
            lblStudent.TabIndex = 1;
            lblStudent.Text = "Student";
            // 
            // txtStudent
            // 
            txtStudent.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudent.Location = new Point(24, 95);
            txtStudent.Name = "txtStudent";
            txtStudent.PlaceholderText = "Search LRN (e.g., 2026-0001) or Student Name...";
            txtStudent.Size = new Size(360, 33);
            txtStudent.TabIndex = 2;
            txtStudent.TextChanged += txtStudent_TextChanged;
            txtStudent.KeyDown += txtStudent_KeyDown;
            txtStudent.Leave += txtStudent_Leave;
            // 
            // lstStudentSuggestions
            // 
            lstStudentSuggestions.BorderStyle = BorderStyle.FixedSingle;
            lstStudentSuggestions.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstStudentSuggestions.FormattingEnabled = true;
            lstStudentSuggestions.ItemHeight = 24;
            lstStudentSuggestions.Location = new Point(24, 128);
            lstStudentSuggestions.Name = "lstStudentSuggestions";
            lstStudentSuggestions.Size = new Size(360, 100);
            lstStudentSuggestions.TabIndex = 17;
            lstStudentSuggestions.Visible = false;
            lstStudentSuggestions.Click += lstStudentSuggestions_Click;
            lstStudentSuggestions.KeyDown += lstStudentSuggestions_KeyDown;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.Location = new Point(404, 68);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(105, 25);
            lblSchoolYear.TabIndex = 3;
            lblSchoolYear.Text = "School Year";
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(404, 95);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.PlaceholderText = "e.g., 2026-2027";
            txtSchoolYear.Size = new Size(175, 33);
            txtSchoolYear.TabIndex = 4;
            txtSchoolYear.Text = "2026-2027";
            txtSchoolYear.TextChanged += txtSchoolYear_TextChanged;
            // 
            // lblGradeLevel
            // 
            lblGradeLevel.AutoSize = true;
            lblGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevel.Location = new Point(599, 68);
            lblGradeLevel.Name = "lblGradeLevel";
            lblGradeLevel.Size = new Size(104, 25);
            lblGradeLevel.TabIndex = 5;
            lblGradeLevel.Text = "Grade Level";
            // 
            // cboGradeLevel
            // 
            cboGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGradeLevel.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGradeLevel.FormattingEnabled = true;
            cboGradeLevel.Location = new Point(599, 95);
            cboGradeLevel.Name = "cboGradeLevel";
            cboGradeLevel.Size = new Size(200, 34);
            cboGradeLevel.TabIndex = 6;
            cboGradeLevel.SelectedIndexChanged += cboGradeLevel_SelectedIndexChanged;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(819, 68);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(68, 25);
            lblSection.TabIndex = 7;
            lblSection.Text = "Section";
            // 
            // cboSection
            // 
            cboSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSection.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSection.FormattingEnabled = true;
            cboSection.Location = new Point(819, 95);
            cboSection.Name = "cboSection";
            cboSection.Size = new Size(255, 34);
            cboSection.TabIndex = 8;
            // 
            // lblEnrollmentDate
            // 
            lblEnrollmentDate.AutoSize = true;
            lblEnrollmentDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollmentDate.Location = new Point(1094, 68);
            lblEnrollmentDate.Name = "lblEnrollmentDate";
            lblEnrollmentDate.Size = new Size(141, 25);
            lblEnrollmentDate.TabIndex = 9;
            lblEnrollmentDate.Text = "Enrollment Date";
            // 
            // dtpEnrollmentDate
            // 
            dtpEnrollmentDate.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollmentDate.Format = DateTimePickerFormat.Short;
            dtpEnrollmentDate.Location = new Point(1094, 95);
            dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            dtpEnrollmentDate.Size = new Size(205, 33);
            dtpEnrollmentDate.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1319, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Enrolled", "Dropped" });
            cboStatus.Location = new Point(1319, 95);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(187, 34);
            cboStatus.TabIndex = 12;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.FromArgb(52, 118, 184);
            btnEnroll.FlatAppearance.BorderSize = 0;
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnroll.ForeColor = Color.White;
            btnEnroll.Location = new Point(24, 162);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(165, 42);
            btnEnroll.TabIndex = 13;
            btnEnroll.Text = "Enroll";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnUpdateEnrollment
            // 
            btnUpdateEnrollment.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateEnrollment.FlatAppearance.BorderSize = 0;
            btnUpdateEnrollment.FlatStyle = FlatStyle.Flat;
            btnUpdateEnrollment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEnrollment.ForeColor = Color.White;
            btnUpdateEnrollment.Location = new Point(205, 162);
            btnUpdateEnrollment.Name = "btnUpdateEnrollment";
            btnUpdateEnrollment.Size = new Size(165, 42);
            btnUpdateEnrollment.TabIndex = 14;
            btnUpdateEnrollment.Text = "Update";
            btnUpdateEnrollment.UseVisualStyleBackColor = false;
            btnUpdateEnrollment.Click += btnUpdateEnrollment_Click;
            // 
            // btnDeleteEnrollment
            // 
            btnDeleteEnrollment.BackColor = Color.FromArgb(200, 60, 60);
            btnDeleteEnrollment.FlatAppearance.BorderSize = 0;
            btnDeleteEnrollment.FlatStyle = FlatStyle.Flat;
            btnDeleteEnrollment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteEnrollment.ForeColor = Color.White;
            btnDeleteEnrollment.Location = new Point(386, 162);
            btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            btnDeleteEnrollment.Size = new Size(165, 42);
            btnDeleteEnrollment.TabIndex = 15;
            btnDeleteEnrollment.Text = "Delete";
            btnDeleteEnrollment.UseVisualStyleBackColor = false;
            btnDeleteEnrollment.Click += btnDeleteEnrollment_Click;
            // 
            // btnClearEnrollment
            // 
            btnClearEnrollment.BackColor = Color.Gray;
            btnClearEnrollment.FlatAppearance.BorderSize = 0;
            btnClearEnrollment.FlatStyle = FlatStyle.Flat;
            btnClearEnrollment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearEnrollment.ForeColor = Color.White;
            btnClearEnrollment.Location = new Point(567, 162);
            btnClearEnrollment.Name = "btnClearEnrollment";
            btnClearEnrollment.Size = new Size(165, 42);
            btnClearEnrollment.TabIndex = 16;
            btnClearEnrollment.Text = "Clear";
            btnClearEnrollment.UseVisualStyleBackColor = false;
            btnClearEnrollment.Click += btnClearEnrollment_Click;
            // 
            // pnlEnrollmentRecords
            // 
            pnlEnrollmentRecords.BackColor = Color.White;
            pnlEnrollmentRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlEnrollmentRecords.Controls.Add(dgvEnrollments);
            pnlEnrollmentRecords.Controls.Add(btnSearch);
            pnlEnrollmentRecords.Controls.Add(txtSearch);
            pnlEnrollmentRecords.Controls.Add(lblSearch);
            pnlEnrollmentRecords.Controls.Add(lblEnrollmentRecordsHeader);
            pnlEnrollmentRecords.Location = new Point(24, 383);
            pnlEnrollmentRecords.Name = "pnlEnrollmentRecords";
            pnlEnrollmentRecords.Size = new Size(1532, 673);
            pnlEnrollmentRecords.TabIndex = 3;
            // 
            // lblEnrollmentRecordsHeader
            // 
            lblEnrollmentRecordsHeader.AutoSize = true;
            lblEnrollmentRecordsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnrollmentRecordsHeader.Location = new Point(24, 22);
            lblEnrollmentRecordsHeader.Name = "lblEnrollmentRecordsHeader";
            lblEnrollmentRecordsHeader.Size = new Size(256, 37);
            lblEnrollmentRecordsHeader.TabIndex = 0;
            lblEnrollmentRecordsHeader.Text = "Enrollment Records";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1064, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(275, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by Student, Grade, or Section";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1064, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type LRN, name, grade, or section...";
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
            // dgvEnrollments
            // 
            dgvEnrollments.AllowUserToAddRows = false;
            dgvEnrollments.AllowUserToDeleteRows = false;
            dgvEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEnrollments.BackgroundColor = Color.White;
            dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollments.Location = new Point(24, 92);
            dgvEnrollments.MultiSelect = false;
            dgvEnrollments.Name = "dgvEnrollments";
            dgvEnrollments.ReadOnly = true;
            dgvEnrollments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrollments.Size = new Size(1482, 557);
            dgvEnrollments.TabIndex = 4;
            dgvEnrollments.CellClick += dgvEnrollments_CellClick;
            // 
            // FrmEnrollment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlEnrollmentRecords);
            Controls.Add(pnlEnrollmentDetails);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEnrollment";
            Text = "FrmEnrollment";
            Load += FrmEnrollment_Load;
            pnlEnrollmentDetails.ResumeLayout(false);
            pnlEnrollmentDetails.PerformLayout();
            pnlEnrollmentRecords.ResumeLayout(false);
            pnlEnrollmentRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlEnrollmentDetails;
        private Label lblEnrollmentDetailsHeader;
        private Label lblStudent;
        private TextBox txtStudent;
        private ListBox lstStudentSuggestions;
        private Label lblSchoolYear;
        private TextBox txtSchoolYear;
        private Label lblGradeLevel;
        private ComboBox cboGradeLevel;
        private Label lblSection;
        private ComboBox cboSection;
        private Label lblEnrollmentDate;
        private DateTimePicker dtpEnrollmentDate;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Button btnEnroll;
        private Button btnUpdateEnrollment;
        private Button btnDeleteEnrollment;
        private Button btnClearEnrollment;
        private Panel pnlEnrollmentRecords;
        private Label lblEnrollmentRecordsHeader;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvEnrollments;
    }
}