namespace UI
{
    partial class FrmReports
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
            pnlCardTotalStudents = new Panel();
            lblCardTotalTitle = new Label();
            lblCardTotalValue = new Label();
            pnlCardEnrolled = new Panel();
            lblCardEnrolledTitle = new Label();
            lblCardEnrolledValue = new Label();
            pnlCardOtherStatus = new Panel();
            lblCardOtherTitle = new Label();
            lblCardOtherValue = new Label();
            pnlCardSections = new Panel();
            lblCardSectionsTitle = new Label();
            lblCardSectionsValue = new Label();
            pnlReportsContainer = new Panel();
            lblReportsHeader = new Label();
            lblSchoolYearFilter = new Label();
            cboSchoolYearFilter = new ComboBox();
            lblGradeLevelFilter = new Label();
            cboGradeLevelFilter = new ComboBox();
            lblSectionFilter = new Label();
            cboSectionFilter = new ComboBox();
            lblStatusFilter = new Label();
            cboStatusFilter = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnResetFilters = new Button();
            btnExportCsv = new Button();
            btnPrintReport = new Button();
            dgvReports = new DataGridView();
            pnlCardTotalStudents.SuspendLayout();
            pnlCardEnrolled.SuspendLayout();
            pnlCardOtherStatus.SuspendLayout();
            pnlCardSections.SuspendLayout();
            pnlReportsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(424, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "STUDENT REPORTS";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(635, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Generate, filter, print, and export student enrollment rosters by Grade Level and Section.";
            // 
            // pnlCardTotalStudents
            // 
            pnlCardTotalStudents.BackColor = Color.White;
            pnlCardTotalStudents.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotalStudents.Controls.Add(lblCardTotalValue);
            pnlCardTotalStudents.Controls.Add(lblCardTotalTitle);
            pnlCardTotalStudents.Location = new Point(24, 118);
            pnlCardTotalStudents.Name = "pnlCardTotalStudents";
            pnlCardTotalStudents.Size = new Size(368, 105);
            pnlCardTotalStudents.TabIndex = 2;
            // 
            // lblCardTotalTitle
            // 
            lblCardTotalTitle.AutoSize = true;
            lblCardTotalTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalTitle.ForeColor = Color.DimGray;
            lblCardTotalTitle.Location = new Point(18, 14);
            lblCardTotalTitle.Name = "lblCardTotalTitle";
            lblCardTotalTitle.Size = new Size(209, 25);
            lblCardTotalTitle.TabIndex = 0;
            lblCardTotalTitle.Text = "FILTERED STUDENTS";
            // 
            // lblCardTotalValue
            // 
            lblCardTotalValue.AutoSize = true;
            lblCardTotalValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalValue.ForeColor = Color.FromArgb(30, 58, 138);
            lblCardTotalValue.Location = new Point(16, 46);
            lblCardTotalValue.Name = "lblCardTotalValue";
            lblCardTotalValue.Size = new Size(38, 46);
            lblCardTotalValue.TabIndex = 1;
            lblCardTotalValue.Text = "0";
            // 
            // pnlCardEnrolled
            // 
            pnlCardEnrolled.BackColor = Color.White;
            pnlCardEnrolled.BorderStyle = BorderStyle.FixedSingle;
            pnlCardEnrolled.Controls.Add(lblCardEnrolledValue);
            pnlCardEnrolled.Controls.Add(lblCardEnrolledTitle);
            pnlCardEnrolled.Location = new Point(412, 118);
            pnlCardEnrolled.Name = "pnlCardEnrolled";
            pnlCardEnrolled.Size = new Size(368, 105);
            pnlCardEnrolled.TabIndex = 3;
            // 
            // lblCardEnrolledTitle
            // 
            lblCardEnrolledTitle.AutoSize = true;
            lblCardEnrolledTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardEnrolledTitle.ForeColor = Color.DimGray;
            lblCardEnrolledTitle.Location = new Point(18, 14);
            lblCardEnrolledTitle.Name = "lblCardEnrolledTitle";
            lblCardEnrolledTitle.Size = new Size(192, 25);
            lblCardEnrolledTitle.TabIndex = 0;
            lblCardEnrolledTitle.Text = "OFFICIALLY ENROLLED";
            // 
            // lblCardEnrolledValue
            // 
            lblCardEnrolledValue.AutoSize = true;
            lblCardEnrolledValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardEnrolledValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblCardEnrolledValue.Location = new Point(16, 46);
            lblCardEnrolledValue.Name = "lblCardEnrolledValue";
            lblCardEnrolledValue.Size = new Size(38, 46);
            lblCardEnrolledValue.TabIndex = 1;
            lblCardEnrolledValue.Text = "0";
            // 
            // pnlCardOtherStatus
            // 
            pnlCardOtherStatus.BackColor = Color.White;
            pnlCardOtherStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlCardOtherStatus.Controls.Add(lblCardOtherValue);
            pnlCardOtherStatus.Controls.Add(lblCardOtherTitle);
            pnlCardOtherStatus.Location = new Point(800, 118);
            pnlCardOtherStatus.Name = "pnlCardOtherStatus";
            pnlCardOtherStatus.Size = new Size(368, 105);
            pnlCardOtherStatus.TabIndex = 4;
            // 
            // lblCardOtherTitle
            // 
            lblCardOtherTitle.AutoSize = true;
            lblCardOtherTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardOtherTitle.ForeColor = Color.DimGray;
            lblCardOtherTitle.Location = new Point(18, 14);
            lblCardOtherTitle.Name = "lblCardOtherTitle";
            lblCardOtherTitle.Size = new Size(203, 25);
            lblCardOtherTitle.TabIndex = 0;
            lblCardOtherTitle.Text = "PENDING / DROPPED";
            // 
            // lblCardOtherValue
            // 
            lblCardOtherValue.AutoSize = true;
            lblCardOtherValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardOtherValue.ForeColor = Color.FromArgb(180, 83, 9);
            lblCardOtherValue.Location = new Point(16, 46);
            lblCardOtherValue.Name = "lblCardOtherValue";
            lblCardOtherValue.Size = new Size(38, 46);
            lblCardOtherValue.TabIndex = 1;
            lblCardOtherValue.Text = "0";
            // 
            // pnlCardSections
            // 
            pnlCardSections.BackColor = Color.White;
            pnlCardSections.BorderStyle = BorderStyle.FixedSingle;
            pnlCardSections.Controls.Add(lblCardSectionsValue);
            pnlCardSections.Controls.Add(lblCardSectionsTitle);
            pnlCardSections.Location = new Point(1188, 118);
            pnlCardSections.Name = "pnlCardSections";
            pnlCardSections.Size = new Size(368, 105);
            pnlCardSections.TabIndex = 5;
            // 
            // lblCardSectionsTitle
            // 
            lblCardSectionsTitle.AutoSize = true;
            lblCardSectionsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardSectionsTitle.ForeColor = Color.DimGray;
            lblCardSectionsTitle.Location = new Point(18, 14);
            lblCardSectionsTitle.Name = "lblCardSectionsTitle";
            lblCardSectionsTitle.Size = new Size(197, 25);
            lblCardSectionsTitle.TabIndex = 0;
            lblCardSectionsTitle.Text = "SECTIONS COVERED";
            // 
            // lblCardSectionsValue
            // 
            lblCardSectionsValue.AutoSize = true;
            lblCardSectionsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardSectionsValue.ForeColor = Color.FromArgb(52, 118, 184);
            lblCardSectionsValue.Location = new Point(16, 46);
            lblCardSectionsValue.Name = "lblCardSectionsValue";
            lblCardSectionsValue.Size = new Size(38, 46);
            lblCardSectionsValue.TabIndex = 1;
            lblCardSectionsValue.Text = "0";
            // 
            // pnlReportsContainer
            // 
            pnlReportsContainer.BackColor = Color.White;
            pnlReportsContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlReportsContainer.Controls.Add(dgvReports);
            pnlReportsContainer.Controls.Add(btnPrintReport);
            pnlReportsContainer.Controls.Add(btnExportCsv);
            pnlReportsContainer.Controls.Add(btnResetFilters);
            pnlReportsContainer.Controls.Add(txtSearch);
            pnlReportsContainer.Controls.Add(lblSearch);
            pnlReportsContainer.Controls.Add(cboStatusFilter);
            pnlReportsContainer.Controls.Add(lblStatusFilter);
            pnlReportsContainer.Controls.Add(cboSectionFilter);
            pnlReportsContainer.Controls.Add(lblSectionFilter);
            pnlReportsContainer.Controls.Add(cboGradeLevelFilter);
            pnlReportsContainer.Controls.Add(lblGradeLevelFilter);
            pnlReportsContainer.Controls.Add(cboSchoolYearFilter);
            pnlReportsContainer.Controls.Add(lblSchoolYearFilter);
            pnlReportsContainer.Controls.Add(lblReportsHeader);
            pnlReportsContainer.Location = new Point(24, 243);
            pnlReportsContainer.Name = "pnlReportsContainer";
            pnlReportsContainer.Size = new Size(1532, 813);
            pnlReportsContainer.TabIndex = 6;
            // 
            // lblReportsHeader
            // 
            lblReportsHeader.AutoSize = true;
            lblReportsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportsHeader.Location = new Point(24, 20);
            lblReportsHeader.Name = "lblReportsHeader";
            lblReportsHeader.Size = new Size(286, 37);
            lblReportsHeader.TabIndex = 0;
            lblReportsHeader.Text = "Student Roster Report";
            // 
            // lblSchoolYearFilter
            // 
            lblSchoolYearFilter.AutoSize = true;
            lblSchoolYearFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYearFilter.Location = new Point(24, 68);
            lblSchoolYearFilter.Name = "lblSchoolYearFilter";
            lblSchoolYearFilter.Size = new Size(99, 23);
            lblSchoolYearFilter.TabIndex = 1;
            lblSchoolYearFilter.Text = "School Year";
            // 
            // cboSchoolYearFilter
            // 
            cboSchoolYearFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSchoolYearFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSchoolYearFilter.FormattingEnabled = true;
            cboSchoolYearFilter.Location = new Point(24, 94);
            cboSchoolYearFilter.Name = "cboSchoolYearFilter";
            cboSchoolYearFilter.Size = new Size(195, 33);
            cboSchoolYearFilter.TabIndex = 2;
            cboSchoolYearFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblGradeLevelFilter
            // 
            lblGradeLevelFilter.AutoSize = true;
            lblGradeLevelFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevelFilter.Location = new Point(235, 68);
            lblGradeLevelFilter.Name = "lblGradeLevelFilter";
            lblGradeLevelFilter.Size = new Size(99, 23);
            lblGradeLevelFilter.TabIndex = 3;
            lblGradeLevelFilter.Text = "Grade Level";
            // 
            // cboGradeLevelFilter
            // 
            cboGradeLevelFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGradeLevelFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGradeLevelFilter.FormattingEnabled = true;
            cboGradeLevelFilter.Location = new Point(235, 94);
            cboGradeLevelFilter.Name = "cboGradeLevelFilter";
            cboGradeLevelFilter.Size = new Size(215, 33);
            cboGradeLevelFilter.TabIndex = 4;
            cboGradeLevelFilter.SelectedIndexChanged += cboGradeLevelFilter_SelectedIndexChanged;
            // 
            // lblSectionFilter
            // 
            lblSectionFilter.AutoSize = true;
            lblSectionFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionFilter.Location = new Point(466, 68);
            lblSectionFilter.Name = "lblSectionFilter";
            lblSectionFilter.Size = new Size(65, 23);
            lblSectionFilter.TabIndex = 5;
            lblSectionFilter.Text = "Section";
            // 
            // cboSectionFilter
            // 
            cboSectionFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSectionFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSectionFilter.FormattingEnabled = true;
            cboSectionFilter.Location = new Point(466, 94);
            cboSectionFilter.Name = "cboSectionFilter";
            cboSectionFilter.Size = new Size(215, 33);
            cboSectionFilter.TabIndex = 6;
            cboSectionFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusFilter.Location = new Point(697, 68);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(57, 23);
            lblStatusFilter.TabIndex = 7;
            lblStatusFilter.Text = "Status";
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Items.AddRange(new object[] { "Enrolled", "All", "Pending", "Dropped" });
            cboStatusFilter.Location = new Point(697, 94);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(165, 33);
            cboStatusFilter.TabIndex = 8;
            cboStatusFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(878, 68);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(171, 23);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search LRN or Student";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(878, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type LRN or name...";
            txtSearch.Size = new Size(255, 32);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += FilterChanged;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.FromArgb(100, 116, 139);
            btnResetFilters.FlatAppearance.BorderSize = 0;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(1145, 93);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(88, 34);
            btnResetFilters.TabIndex = 11;
            btnResetFilters.Text = "Reset";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.BackColor = Color.FromArgb(46, 139, 87);
            btnExportCsv.FlatAppearance.BorderSize = 0;
            btnExportCsv.FlatStyle = FlatStyle.Flat;
            btnExportCsv.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCsv.ForeColor = Color.White;
            btnExportCsv.Location = new Point(1243, 93);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(125, 34);
            btnExportCsv.TabIndex = 12;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = false;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = Color.FromArgb(52, 118, 184);
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReport.ForeColor = Color.White;
            btnPrintReport.Location = new Point(1378, 93);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(128, 34);
            btnPrintReport.TabIndex = 13;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(24, 146);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(1482, 643);
            dgvReports.TabIndex = 14;
            // 
            // FrmReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlReportsContainer);
            Controls.Add(pnlCardSections);
            Controls.Add(pnlCardOtherStatus);
            Controls.Add(pnlCardEnrolled);
            Controls.Add(pnlCardTotalStudents);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReports";
            Text = "FrmReports";
            Load += FrmReports_Load;
            pnlCardTotalStudents.ResumeLayout(false);
            pnlCardTotalStudents.PerformLayout();
            pnlCardEnrolled.ResumeLayout(false);
            pnlCardEnrolled.PerformLayout();
            pnlCardOtherStatus.ResumeLayout(false);
            pnlCardOtherStatus.PerformLayout();
            pnlCardSections.ResumeLayout(false);
            pnlCardSections.PerformLayout();
            pnlReportsContainer.ResumeLayout(false);
            pnlReportsContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlCardTotalStudents;
        private Label lblCardTotalTitle;
        private Label lblCardTotalValue;
        private Panel pnlCardEnrolled;
        private Label lblCardEnrolledTitle;
        private Label lblCardEnrolledValue;
        private Panel pnlCardOtherStatus;
        private Label lblCardOtherTitle;
        private Label lblCardOtherValue;
        private Panel pnlCardSections;
        private Label lblCardSectionsTitle;
        private Label lblCardSectionsValue;
        private Panel pnlReportsContainer;
        private Label lblReportsHeader;
        private Label lblSchoolYearFilter;
        private ComboBox cboSchoolYearFilter;
        private Label lblGradeLevelFilter;
        private ComboBox cboGradeLevelFilter;
        private Label lblSectionFilter;
        private ComboBox cboSectionFilter;
        private Label lblStatusFilter;
        private ComboBox cboStatusFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnResetFilters;
        private Button btnExportCsv;
        private Button btnPrintReport;
        private DataGridView dgvReports;
    }
}