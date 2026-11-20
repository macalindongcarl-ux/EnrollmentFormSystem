namespace UI
{
    partial class FrmAssesment
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
            pnlAssessmentDetails = new Panel();
            lstStudentSuggestions = new ListBox();
            btnClearAssessment = new Button();
            btnDeleteAssessment = new Button();
            btnUpdateAssessment = new Button();
            btnAddAssessment = new Button();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            txtOtherFees = new TextBox();
            lblOtherFees = new Label();
            txtMiscFee = new TextBox();
            lblMiscFee = new Label();
            txtTuitionFee = new TextBox();
            lblTuitionFee = new Label();
            dtpAssessmentDate = new DateTimePicker();
            lblAssessmentDate = new Label();
            txtSchoolYear = new TextBox();
            lblSchoolYear = new Label();
            txtGradeSection = new TextBox();
            lblGradeSection = new Label();
            txtStudentSearch = new TextBox();
            lblStudentSearch = new Label();
            lblAssessmentDetailsHeader = new Label();
            pnlAssessmentRecords = new Panel();
            dgvAssessments = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblAssessmentRecordsHeader = new Label();
            pnlAssessmentDetails.SuspendLayout();
            pnlAssessmentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssessments).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(274, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "ASSESSMENT";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(647, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Calculate and manage student tuition and miscellaneous fee assessments.";
            // 
            // pnlAssessmentDetails
            // 
            pnlAssessmentDetails.BackColor = Color.White;
            pnlAssessmentDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlAssessmentDetails.Controls.Add(lstStudentSuggestions);
            pnlAssessmentDetails.Controls.Add(btnClearAssessment);
            pnlAssessmentDetails.Controls.Add(btnDeleteAssessment);
            pnlAssessmentDetails.Controls.Add(btnUpdateAssessment);
            pnlAssessmentDetails.Controls.Add(btnAddAssessment);
            pnlAssessmentDetails.Controls.Add(txtTotalAmount);
            pnlAssessmentDetails.Controls.Add(lblTotalAmount);
            pnlAssessmentDetails.Controls.Add(txtDiscount);
            pnlAssessmentDetails.Controls.Add(lblDiscount);
            pnlAssessmentDetails.Controls.Add(txtOtherFees);
            pnlAssessmentDetails.Controls.Add(lblOtherFees);
            pnlAssessmentDetails.Controls.Add(txtMiscFee);
            pnlAssessmentDetails.Controls.Add(lblMiscFee);
            pnlAssessmentDetails.Controls.Add(txtTuitionFee);
            pnlAssessmentDetails.Controls.Add(lblTuitionFee);
            pnlAssessmentDetails.Controls.Add(dtpAssessmentDate);
            pnlAssessmentDetails.Controls.Add(lblAssessmentDate);
            pnlAssessmentDetails.Controls.Add(txtSchoolYear);
            pnlAssessmentDetails.Controls.Add(lblSchoolYear);
            pnlAssessmentDetails.Controls.Add(txtGradeSection);
            pnlAssessmentDetails.Controls.Add(lblGradeSection);
            pnlAssessmentDetails.Controls.Add(txtStudentSearch);
            pnlAssessmentDetails.Controls.Add(lblStudentSearch);
            pnlAssessmentDetails.Controls.Add(lblAssessmentDetailsHeader);
            pnlAssessmentDetails.Location = new Point(24, 118);
            pnlAssessmentDetails.Name = "pnlAssessmentDetails";
            pnlAssessmentDetails.Size = new Size(1532, 330);
            pnlAssessmentDetails.TabIndex = 2;
            // 
            // lstStudentSuggestions
            // 
            lstStudentSuggestions.BorderStyle = BorderStyle.FixedSingle;
            lstStudentSuggestions.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstStudentSuggestions.FormattingEnabled = true;
            lstStudentSuggestions.Location = new Point(24, 124);
            lstStudentSuggestions.Name = "lstStudentSuggestions";
            lstStudentSuggestions.Size = new Size(555, 94);
            lstStudentSuggestions.TabIndex = 21;
            lstStudentSuggestions.Visible = false;
            lstStudentSuggestions.Click += lstStudentSuggestions_Click;
            lstStudentSuggestions.KeyDown += lstStudentSuggestions_KeyDown;
            // 
            // btnClearAssessment
            // 
            btnClearAssessment.BackColor = Color.Gray;
            btnClearAssessment.FlatAppearance.BorderSize = 0;
            btnClearAssessment.FlatStyle = FlatStyle.Flat;
            btnClearAssessment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearAssessment.ForeColor = Color.White;
            btnClearAssessment.Location = new Point(587, 234);
            btnClearAssessment.Name = "btnClearAssessment";
            btnClearAssessment.Size = new Size(165, 42);
            btnClearAssessment.TabIndex = 22;
            btnClearAssessment.Text = "Clear";
            btnClearAssessment.UseVisualStyleBackColor = false;
            btnClearAssessment.Click += btnClearAssessment_Click;
            // 
            // btnDeleteAssessment
            // 
            btnDeleteAssessment.BackColor = Color.FromArgb(200, 60, 60);
            btnDeleteAssessment.FlatAppearance.BorderSize = 0;
            btnDeleteAssessment.FlatStyle = FlatStyle.Flat;
            btnDeleteAssessment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAssessment.ForeColor = Color.White;
            btnDeleteAssessment.Location = new Point(406, 234);
            btnDeleteAssessment.Name = "btnDeleteAssessment";
            btnDeleteAssessment.Size = new Size(165, 42);
            btnDeleteAssessment.TabIndex = 21;
            btnDeleteAssessment.Text = "Delete";
            btnDeleteAssessment.UseVisualStyleBackColor = false;
            btnDeleteAssessment.Click += btnDeleteAssessment_Click;
            // 
            // btnUpdateAssessment
            // 
            btnUpdateAssessment.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateAssessment.FlatAppearance.BorderSize = 0;
            btnUpdateAssessment.FlatStyle = FlatStyle.Flat;
            btnUpdateAssessment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAssessment.ForeColor = Color.White;
            btnUpdateAssessment.Location = new Point(225, 234);
            btnUpdateAssessment.Name = "btnUpdateAssessment";
            btnUpdateAssessment.Size = new Size(165, 42);
            btnUpdateAssessment.TabIndex = 20;
            btnUpdateAssessment.Text = "Update";
            btnUpdateAssessment.UseVisualStyleBackColor = false;
            btnUpdateAssessment.Click += btnUpdateAssessment_Click;
            // 
            // btnAddAssessment
            // 
            btnAddAssessment.BackColor = Color.FromArgb(52, 118, 184);
            btnAddAssessment.FlatAppearance.BorderSize = 0;
            btnAddAssessment.FlatStyle = FlatStyle.Flat;
            btnAddAssessment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAssessment.ForeColor = Color.White;
            btnAddAssessment.Location = new Point(24, 234);
            btnAddAssessment.Name = "btnAddAssessment";
            btnAddAssessment.Size = new Size(184, 42);
            btnAddAssessment.TabIndex = 19;
            btnAddAssessment.Text = "Save Assessment";
            btnAddAssessment.UseVisualStyleBackColor = false;
            btnAddAssessment.Click += btnAddAssessment_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.FromArgb(241, 245, 249);
            txtTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalAmount.ForeColor = Color.FromArgb(30, 58, 138);
            txtTotalAmount.Location = new Point(1179, 169);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(327, 34);
            txtTotalAmount.TabIndex = 18;
            txtTotalAmount.Text = "0.00";
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(1179, 142);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(189, 25);
            lblTotalAmount.TabIndex = 17;
            lblTotalAmount.Text = "Total Assessment (₱)";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(889, 169);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(270, 33);
            txtDiscount.TabIndex = 16;
            txtDiscount.Text = "0.00";
            txtDiscount.TextAlign = HorizontalAlignment.Right;
            txtDiscount.TextChanged += FeeInput_TextChanged;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(889, 142);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(108, 25);
            lblDiscount.TabIndex = 15;
            lblDiscount.Text = "Discount (₱)";
            // 
            // txtOtherFees
            // 
            txtOtherFees.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtherFees.Location = new Point(599, 169);
            txtOtherFees.Name = "txtOtherFees";
            txtOtherFees.Size = new Size(270, 33);
            txtOtherFees.TabIndex = 14;
            txtOtherFees.Text = "0.00";
            txtOtherFees.TextAlign = HorizontalAlignment.Right;
            txtOtherFees.TextChanged += FeeInput_TextChanged;
            // 
            // lblOtherFees
            // 
            lblOtherFees.AutoSize = true;
            lblOtherFees.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOtherFees.Location = new Point(599, 142);
            lblOtherFees.Name = "lblOtherFees";
            lblOtherFees.Size = new Size(123, 25);
            lblOtherFees.TabIndex = 13;
            lblOtherFees.Text = "Other Fees (₱)";
            // 
            // txtMiscFee
            // 
            txtMiscFee.BackColor = Color.FromArgb(241, 245, 249);
            txtMiscFee.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiscFee.Location = new Point(309, 169);
            txtMiscFee.Name = "txtMiscFee";
            txtMiscFee.ReadOnly = true;
            txtMiscFee.Size = new Size(270, 33);
            txtMiscFee.TabIndex = 12;
            txtMiscFee.TabStop = false;
            txtMiscFee.Text = "0.00";
            txtMiscFee.TextAlign = HorizontalAlignment.Right;
            txtMiscFee.TextChanged += FeeInput_TextChanged;
            // 
            // lblMiscFee
            // 
            lblMiscFee.AutoSize = true;
            lblMiscFee.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMiscFee.Location = new Point(309, 142);
            lblMiscFee.Name = "lblMiscFee";
            lblMiscFee.Size = new Size(180, 25);
            lblMiscFee.TabIndex = 11;
            lblMiscFee.Text = "Miscellaneous Fee (₱)";
            // 
            // txtTuitionFee
            // 
            txtTuitionFee.BackColor = Color.FromArgb(241, 245, 249);
            txtTuitionFee.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTuitionFee.Location = new Point(24, 169);
            txtTuitionFee.Name = "txtTuitionFee";
            txtTuitionFee.ReadOnly = true;
            txtTuitionFee.Size = new Size(265, 33);
            txtTuitionFee.TabIndex = 10;
            txtTuitionFee.TabStop = false;
            txtTuitionFee.Text = "0.00";
            txtTuitionFee.TextAlign = HorizontalAlignment.Right;
            txtTuitionFee.TextChanged += FeeInput_TextChanged;
            // 
            // lblTuitionFee
            // 
            lblTuitionFee.AutoSize = true;
            lblTuitionFee.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuitionFee.Location = new Point(24, 142);
            lblTuitionFee.Name = "lblTuitionFee";
            lblTuitionFee.Size = new Size(124, 25);
            lblTuitionFee.TabIndex = 9;
            lblTuitionFee.Text = "Tuition Fee (₱)";
            // 
            // dtpAssessmentDate
            // 
            dtpAssessmentDate.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAssessmentDate.Format = DateTimePickerFormat.Short;
            dtpAssessmentDate.Location = new Point(1224, 92);
            dtpAssessmentDate.Name = "dtpAssessmentDate";
            dtpAssessmentDate.Size = new Size(282, 33);
            dtpAssessmentDate.TabIndex = 8;
            // 
            // lblAssessmentDate
            // 
            lblAssessmentDate.AutoSize = true;
            lblAssessmentDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssessmentDate.Location = new Point(1224, 65);
            lblAssessmentDate.Name = "lblAssessmentDate";
            lblAssessmentDate.Size = new Size(148, 25);
            lblAssessmentDate.TabIndex = 7;
            lblAssessmentDate.Text = "Assessment Date";
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.BackColor = Color.FromArgb(241, 245, 249);
            txtSchoolYear.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(959, 92);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.ReadOnly = true;
            txtSchoolYear.Size = new Size(245, 33);
            txtSchoolYear.TabIndex = 6;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.Location = new Point(959, 65);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(103, 25);
            lblSchoolYear.TabIndex = 5;
            lblSchoolYear.Text = "School Year";
            // 
            // txtGradeSection
            // 
            txtGradeSection.BackColor = Color.FromArgb(241, 245, 249);
            txtGradeSection.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeSection.Location = new Point(599, 92);
            txtGradeSection.Name = "txtGradeSection";
            txtGradeSection.ReadOnly = true;
            txtGradeSection.Size = new Size(340, 33);
            txtGradeSection.TabIndex = 4;
            // 
            // lblGradeSection
            // 
            lblGradeSection.AutoSize = true;
            lblGradeSection.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeSection.Location = new Point(599, 65);
            lblGradeSection.Name = "lblGradeSection";
            lblGradeSection.Size = new Size(185, 25);
            lblGradeSection.TabIndex = 3;
            lblGradeSection.Text = "Grade Level && Section";
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentSearch.Location = new Point(24, 92);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.PlaceholderText = "Search enrolled LRN or Student Name...";
            txtStudentSearch.Size = new Size(555, 33);
            txtStudentSearch.TabIndex = 2;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            txtStudentSearch.KeyDown += txtStudentSearch_KeyDown;
            txtStudentSearch.Leave += txtStudentSearch_Leave;
            // 
            // lblStudentSearch
            // 
            lblStudentSearch.AutoSize = true;
            lblStudentSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentSearch.Location = new Point(24, 65);
            lblStudentSearch.Name = "lblStudentSearch";
            lblStudentSearch.Size = new Size(142, 25);
            lblStudentSearch.TabIndex = 1;
            lblStudentSearch.Text = "Enrolled Student";
            // 
            // lblAssessmentDetailsHeader
            // 
            lblAssessmentDetailsHeader.AutoSize = true;
            lblAssessmentDetailsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssessmentDetailsHeader.Location = new Point(24, 16);
            lblAssessmentDetailsHeader.Name = "lblAssessmentDetailsHeader";
            lblAssessmentDetailsHeader.Size = new Size(262, 37);
            lblAssessmentDetailsHeader.TabIndex = 0;
            lblAssessmentDetailsHeader.Text = "Assessment Details";
            // 
            // pnlAssessmentRecords
            // 
            pnlAssessmentRecords.BackColor = Color.White;
            pnlAssessmentRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlAssessmentRecords.Controls.Add(dgvAssessments);
            pnlAssessmentRecords.Controls.Add(btnSearch);
            pnlAssessmentRecords.Controls.Add(txtSearch);
            pnlAssessmentRecords.Controls.Add(lblSearch);
            pnlAssessmentRecords.Controls.Add(lblAssessmentRecordsHeader);
            pnlAssessmentRecords.Location = new Point(24, 468);
            pnlAssessmentRecords.Name = "pnlAssessmentRecords";
            pnlAssessmentRecords.Size = new Size(1532, 588);
            pnlAssessmentRecords.TabIndex = 3;
            // 
            // dgvAssessments
            // 
            dgvAssessments.AllowUserToAddRows = false;
            dgvAssessments.AllowUserToDeleteRows = false;
            dgvAssessments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssessments.BackgroundColor = Color.White;
            dgvAssessments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssessments.Location = new Point(24, 92);
            dgvAssessments.MultiSelect = false;
            dgvAssessments.Name = "dgvAssessments";
            dgvAssessments.ReadOnly = true;
            dgvAssessments.RowHeadersWidth = 51;
            dgvAssessments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssessments.Size = new Size(1482, 472);
            dgvAssessments.TabIndex = 4;
            dgvAssessments.CellClick += dgvAssessments_CellClick;
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
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1064, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(300, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by Student, Grade, or Section";
            // 
            // lblAssessmentRecordsHeader
            // 
            lblAssessmentRecordsHeader.AutoSize = true;
            lblAssessmentRecordsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssessmentRecordsHeader.Location = new Point(24, 22);
            lblAssessmentRecordsHeader.Name = "lblAssessmentRecordsHeader";
            lblAssessmentRecordsHeader.Size = new Size(275, 37);
            lblAssessmentRecordsHeader.TabIndex = 0;
            lblAssessmentRecordsHeader.Text = "Assessment Records";
            // 
            // FrmAssesment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlAssessmentRecords);
            Controls.Add(pnlAssessmentDetails);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAssesment";
            Text = "FrmAssesment";
            Load += FrmAssesment_Load;
            pnlAssessmentDetails.ResumeLayout(false);
            pnlAssessmentDetails.PerformLayout();
            pnlAssessmentRecords.ResumeLayout(false);
            pnlAssessmentRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssessments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlAssessmentDetails;
        private Label lblAssessmentDetailsHeader;
        private Label lblStudentSearch;
        private TextBox txtStudentSearch;
        private ListBox lstStudentSuggestions;
        private Label lblGradeSection;
        private TextBox txtGradeSection;
        private Label lblSchoolYear;
        private TextBox txtSchoolYear;
        private Label lblAssessmentDate;
        private DateTimePicker dtpAssessmentDate;
        private Label lblTuitionFee;
        private TextBox txtTuitionFee;
        private Label lblMiscFee;
        private TextBox txtMiscFee;
        private Label lblOtherFees;
        private TextBox txtOtherFees;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Button btnAddAssessment;
        private Button btnUpdateAssessment;
        private Button btnDeleteAssessment;
        private Button btnClearAssessment;
        private Panel pnlAssessmentRecords;
        private Label lblAssessmentRecordsHeader;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvAssessments;
    }
}