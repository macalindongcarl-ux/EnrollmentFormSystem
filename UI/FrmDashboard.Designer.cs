namespace UI
{
    partial class FrmDashboard
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
            panel1 = new Panel();
            DASHBOARD = new Label();
            lblWelcome = new Label();
            btnRefresh = new Button();
            pnlCardStudents = new Panel();
            lblCardStudentsTitle = new Label();
            lblCardStudentsValue = new Label();
            lblCardStudentsSub = new Label();
            pnlCardEnrolled = new Panel();
            lblCardEnrolledTitle = new Label();
            lblCardEnrolledValue = new Label();
            lblCardEnrolledSub = new Label();
            pnlCardSections = new Panel();
            lblCardSectionsTitle = new Label();
            lblCardSectionsValue = new Label();
            lblCardSectionsSub = new Label();
            pnlCardAssessed = new Panel();
            lblCardAssessedTitle = new Label();
            lblCardAssessedValue = new Label();
            lblCardAssessedSub = new Label();
            pnlCardCollected = new Panel();
            lblCardCollectedTitle = new Label();
            lblCardCollectedValue = new Label();
            lblCardCollectedSub = new Label();
            pnlCardBalance = new Panel();
            lblCardBalanceTitle = new Label();
            lblCardBalanceValue = new Label();
            lblCardBalanceSub = new Label();
            pnlRecentEnrollments = new Panel();
            lblRecentEnrollmentsHeader = new Label();
            dgvRecentEnrollments = new DataGridView();
            pnlRecentPayments = new Panel();
            lblRecentPaymentsHeader = new Label();
            dgvRecentPayments = new DataGridView();
            panel1.SuspendLayout();
            pnlCardStudents.SuspendLayout();
            pnlCardEnrolled.SuspendLayout();
            pnlCardSections.SuspendLayout();
            pnlCardAssessed.SuspendLayout();
            pnlCardCollected.SuspendLayout();
            pnlCardBalance.SuspendLayout();
            pnlRecentEnrollments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentEnrollments).BeginInit();
            pnlRecentPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 244, 247);
            panel1.Controls.Add(pnlRecentPayments);
            panel1.Controls.Add(pnlRecentEnrollments);
            panel1.Controls.Add(pnlCardBalance);
            panel1.Controls.Add(pnlCardCollected);
            panel1.Controls.Add(pnlCardAssessed);
            panel1.Controls.Add(pnlCardSections);
            panel1.Controls.Add(pnlCardEnrolled);
            panel1.Controls.Add(pnlCardStudents);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(lblWelcome);
            panel1.Controls.Add(DASHBOARD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1580, 1080);
            panel1.TabIndex = 0;
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(258, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "DASHBOARD";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(492, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome! Here is an overview of enrollment and billing activity.";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 118, 184);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1406, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 42);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh Data";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlCardStudents
            // 
            pnlCardStudents.BackColor = Color.White;
            pnlCardStudents.BorderStyle = BorderStyle.FixedSingle;
            pnlCardStudents.Controls.Add(lblCardStudentsSub);
            pnlCardStudents.Controls.Add(lblCardStudentsValue);
            pnlCardStudents.Controls.Add(lblCardStudentsTitle);
            pnlCardStudents.Location = new Point(24, 122);
            pnlCardStudents.Name = "pnlCardStudents";
            pnlCardStudents.Size = new Size(494, 130);
            pnlCardStudents.TabIndex = 3;
            // 
            // lblCardStudentsTitle
            // 
            lblCardStudentsTitle.AutoSize = true;
            lblCardStudentsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardStudentsTitle.ForeColor = Color.DimGray;
            lblCardStudentsTitle.Location = new Point(22, 16);
            lblCardStudentsTitle.Name = "lblCardStudentsTitle";
            lblCardStudentsTitle.Size = new Size(176, 25);
            lblCardStudentsTitle.TabIndex = 0;
            lblCardStudentsTitle.Text = "ACTIVE STUDENTS";
            // 
            // lblCardStudentsValue
            // 
            lblCardStudentsValue.AutoSize = true;
            lblCardStudentsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardStudentsValue.ForeColor = Color.FromArgb(30, 58, 138);
            lblCardStudentsValue.Location = new Point(20, 44);
            lblCardStudentsValue.Name = "lblCardStudentsValue";
            lblCardStudentsValue.Size = new Size(46, 54);
            lblCardStudentsValue.TabIndex = 1;
            lblCardStudentsValue.Text = "0";
            // 
            // lblCardStudentsSub
            // 
            lblCardStudentsSub.AutoSize = true;
            lblCardStudentsSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardStudentsSub.ForeColor = Color.Gray;
            lblCardStudentsSub.Location = new Point(22, 98);
            lblCardStudentsSub.Name = "lblCardStudentsSub";
            lblCardStudentsSub.Size = new Size(216, 21);
            lblCardStudentsSub.TabIndex = 2;
            lblCardStudentsSub.Text = "Registered in student masterlist";
            // 
            // pnlCardEnrolled
            // 
            pnlCardEnrolled.BackColor = Color.White;
            pnlCardEnrolled.BorderStyle = BorderStyle.FixedSingle;
            pnlCardEnrolled.Controls.Add(lblCardEnrolledSub);
            pnlCardEnrolled.Controls.Add(lblCardEnrolledValue);
            pnlCardEnrolled.Controls.Add(lblCardEnrolledTitle);
            pnlCardEnrolled.Location = new Point(543, 122);
            pnlCardEnrolled.Name = "pnlCardEnrolled";
            pnlCardEnrolled.Size = new Size(494, 130);
            pnlCardEnrolled.TabIndex = 4;
            // 
            // lblCardEnrolledTitle
            // 
            lblCardEnrolledTitle.AutoSize = true;
            lblCardEnrolledTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardEnrolledTitle.ForeColor = Color.DimGray;
            lblCardEnrolledTitle.Location = new Point(22, 16);
            lblCardEnrolledTitle.Name = "lblCardEnrolledTitle";
            lblCardEnrolledTitle.Size = new Size(192, 25);
            lblCardEnrolledTitle.TabIndex = 0;
            lblCardEnrolledTitle.Text = "OFFICIALLY ENROLLED";
            // 
            // lblCardEnrolledValue
            // 
            lblCardEnrolledValue.AutoSize = true;
            lblCardEnrolledValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardEnrolledValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblCardEnrolledValue.Location = new Point(20, 44);
            lblCardEnrolledValue.Name = "lblCardEnrolledValue";
            lblCardEnrolledValue.Size = new Size(46, 54);
            lblCardEnrolledValue.TabIndex = 1;
            lblCardEnrolledValue.Text = "0";
            // 
            // lblCardEnrolledSub
            // 
            lblCardEnrolledSub.AutoSize = true;
            lblCardEnrolledSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardEnrolledSub.ForeColor = Color.Gray;
            lblCardEnrolledSub.Location = new Point(22, 98);
            lblCardEnrolledSub.Name = "lblCardEnrolledSub";
            lblCardEnrolledSub.Size = new Size(216, 21);
            lblCardEnrolledSub.TabIndex = 2;
            lblCardEnrolledSub.Text = "Active section assignments";
            // 
            // pnlCardSections
            // 
            pnlCardSections.BackColor = Color.White;
            pnlCardSections.BorderStyle = BorderStyle.FixedSingle;
            pnlCardSections.Controls.Add(lblCardSectionsSub);
            pnlCardSections.Controls.Add(lblCardSectionsValue);
            pnlCardSections.Controls.Add(lblCardSectionsTitle);
            pnlCardSections.Location = new Point(1062, 122);
            pnlCardSections.Name = "pnlCardSections";
            pnlCardSections.Size = new Size(494, 130);
            pnlCardSections.TabIndex = 5;
            // 
            // lblCardSectionsTitle
            // 
            lblCardSectionsTitle.AutoSize = true;
            lblCardSectionsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardSectionsTitle.ForeColor = Color.DimGray;
            lblCardSectionsTitle.Location = new Point(22, 16);
            lblCardSectionsTitle.Name = "lblCardSectionsTitle";
            lblCardSectionsTitle.Size = new Size(165, 25);
            lblCardSectionsTitle.TabIndex = 0;
            lblCardSectionsTitle.Text = "ACTIVE SECTIONS";
            // 
            // lblCardSectionsValue
            // 
            lblCardSectionsValue.AutoSize = true;
            lblCardSectionsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardSectionsValue.ForeColor = Color.FromArgb(52, 118, 184);
            lblCardSectionsValue.Location = new Point(20, 44);
            lblCardSectionsValue.Name = "lblCardSectionsValue";
            lblCardSectionsValue.Size = new Size(46, 54);
            lblCardSectionsValue.TabIndex = 1;
            lblCardSectionsValue.Text = "0";
            // 
            // lblCardSectionsSub
            // 
            lblCardSectionsSub.AutoSize = true;
            lblCardSectionsSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardSectionsSub.ForeColor = Color.Gray;
            lblCardSectionsSub.Location = new Point(22, 98);
            lblCardSectionsSub.Name = "lblCardSectionsSub";
            lblCardSectionsSub.Size = new Size(192, 21);
            lblCardSectionsSub.TabIndex = 2;
            lblCardSectionsSub.Text = "Across all active grade levels";
            // 
            // pnlCardAssessed
            // 
            pnlCardAssessed.BackColor = Color.White;
            pnlCardAssessed.BorderStyle = BorderStyle.FixedSingle;
            pnlCardAssessed.Controls.Add(lblCardAssessedSub);
            pnlCardAssessed.Controls.Add(lblCardAssessedValue);
            pnlCardAssessed.Controls.Add(lblCardAssessedTitle);
            pnlCardAssessed.Location = new Point(24, 272);
            pnlCardAssessed.Name = "pnlCardAssessed";
            pnlCardAssessed.Size = new Size(494, 130);
            pnlCardAssessed.TabIndex = 6;
            // 
            // lblCardAssessedTitle
            // 
            lblCardAssessedTitle.AutoSize = true;
            lblCardAssessedTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAssessedTitle.ForeColor = Color.DimGray;
            lblCardAssessedTitle.Location = new Point(22, 16);
            lblCardAssessedTitle.Name = "lblCardAssessedTitle";
            lblCardAssessedTitle.Size = new Size(156, 25);
            lblCardAssessedTitle.TabIndex = 0;
            lblCardAssessedTitle.Text = "TOTAL ASSESSED";
            // 
            // lblCardAssessedValue
            // 
            lblCardAssessedValue.AutoSize = true;
            lblCardAssessedValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAssessedValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardAssessedValue.Location = new Point(20, 44);
            lblCardAssessedValue.Name = "lblCardAssessedValue";
            lblCardAssessedValue.Size = new Size(138, 54);
            lblCardAssessedValue.TabIndex = 1;
            lblCardAssessedValue.Text = "₱0.00";
            // 
            // lblCardAssessedSub
            // 
            lblCardAssessedSub.AutoSize = true;
            lblCardAssessedSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardAssessedSub.ForeColor = Color.Gray;
            lblCardAssessedSub.Location = new Point(22, 98);
            lblCardAssessedSub.Name = "lblCardAssessedSub";
            lblCardAssessedSub.Size = new Size(216, 21);
            lblCardAssessedSub.TabIndex = 2;
            lblCardAssessedSub.Text = "Net billed tuition & fees";
            // 
            // pnlCardCollected
            // 
            pnlCardCollected.BackColor = Color.White;
            pnlCardCollected.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCollected.Controls.Add(lblCardCollectedSub);
            pnlCardCollected.Controls.Add(lblCardCollectedValue);
            pnlCardCollected.Controls.Add(lblCardCollectedTitle);
            pnlCardCollected.Location = new Point(543, 272);
            pnlCardCollected.Name = "pnlCardCollected";
            pnlCardCollected.Size = new Size(494, 130);
            pnlCardCollected.TabIndex = 7;
            // 
            // lblCardCollectedTitle
            // 
            lblCardCollectedTitle.AutoSize = true;
            lblCardCollectedTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCollectedTitle.ForeColor = Color.DimGray;
            lblCardCollectedTitle.Location = new Point(22, 16);
            lblCardCollectedTitle.Name = "lblCardCollectedTitle";
            lblCardCollectedTitle.Size = new Size(165, 25);
            lblCardCollectedTitle.TabIndex = 0;
            lblCardCollectedTitle.Text = "TOTAL COLLECTED";
            // 
            // lblCardCollectedValue
            // 
            lblCardCollectedValue.AutoSize = true;
            lblCardCollectedValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCollectedValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblCardCollectedValue.Location = new Point(20, 44);
            lblCardCollectedValue.Name = "lblCardCollectedValue";
            lblCardCollectedValue.Size = new Size(138, 54);
            lblCardCollectedValue.TabIndex = 1;
            lblCardCollectedValue.Text = "₱0.00";
            // 
            // lblCardCollectedSub
            // 
            lblCardCollectedSub.AutoSize = true;
            lblCardCollectedSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardCollectedSub.ForeColor = Color.Gray;
            lblCardCollectedSub.Location = new Point(22, 98);
            lblCardCollectedSub.Name = "lblCardCollectedSub";
            lblCardCollectedSub.Size = new Size(216, 21);
            lblCardCollectedSub.TabIndex = 2;
            lblCardCollectedSub.Text = "Verified active cashier receipts";
            // 
            // pnlCardBalance
            // 
            pnlCardBalance.BackColor = Color.White;
            pnlCardBalance.BorderStyle = BorderStyle.FixedSingle;
            pnlCardBalance.Controls.Add(lblCardBalanceSub);
            pnlCardBalance.Controls.Add(lblCardBalanceValue);
            pnlCardBalance.Controls.Add(lblCardBalanceTitle);
            pnlCardBalance.Location = new Point(1062, 272);
            pnlCardBalance.Name = "pnlCardBalance";
            pnlCardBalance.Size = new Size(494, 130);
            pnlCardBalance.TabIndex = 8;
            // 
            // lblCardBalanceTitle
            // 
            lblCardBalanceTitle.AutoSize = true;
            lblCardBalanceTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardBalanceTitle.ForeColor = Color.DimGray;
            lblCardBalanceTitle.Location = new Point(22, 16);
            lblCardBalanceTitle.Name = "lblCardBalanceTitle";
            lblCardBalanceTitle.Size = new Size(216, 25);
            lblCardBalanceTitle.TabIndex = 0;
            lblCardBalanceTitle.Text = "OUTSTANDING BALANCE";
            // 
            // lblCardBalanceValue
            // 
            lblCardBalanceValue.AutoSize = true;
            lblCardBalanceValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardBalanceValue.ForeColor = Color.FromArgb(185, 28, 28);
            lblCardBalanceValue.Location = new Point(20, 44);
            lblCardBalanceValue.Name = "lblCardBalanceValue";
            lblCardBalanceValue.Size = new Size(138, 54);
            lblCardBalanceValue.TabIndex = 1;
            lblCardBalanceValue.Text = "₱0.00";
            // 
            // lblCardBalanceSub
            // 
            lblCardBalanceSub.AutoSize = true;
            lblCardBalanceSub.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardBalanceSub.ForeColor = Color.Gray;
            lblCardBalanceSub.Location = new Point(22, 98);
            lblCardBalanceSub.Name = "lblCardBalanceSub";
            lblCardBalanceSub.Size = new Size(216, 21);
            lblCardBalanceSub.TabIndex = 2;
            lblCardBalanceSub.Text = "Remaining collectible balance";
            // 
            // pnlRecentEnrollments
            // 
            pnlRecentEnrollments.BackColor = Color.White;
            pnlRecentEnrollments.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentEnrollments.Controls.Add(dgvRecentEnrollments);
            pnlRecentEnrollments.Controls.Add(lblRecentEnrollmentsHeader);
            pnlRecentEnrollments.Location = new Point(24, 422);
            pnlRecentEnrollments.Name = "pnlRecentEnrollments";
            pnlRecentEnrollments.Size = new Size(754, 634);
            pnlRecentEnrollments.TabIndex = 9;
            // 
            // lblRecentEnrollmentsHeader
            // 
            lblRecentEnrollmentsHeader.AutoSize = true;
            lblRecentEnrollmentsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentEnrollmentsHeader.Location = new Point(22, 20);
            lblRecentEnrollmentsHeader.Name = "lblRecentEnrollmentsHeader";
            lblRecentEnrollmentsHeader.Size = new Size(253, 37);
            lblRecentEnrollmentsHeader.TabIndex = 0;
            lblRecentEnrollmentsHeader.Text = "Recent Enrollments";
            // 
            // dgvRecentEnrollments
            // 
            dgvRecentEnrollments.AllowUserToAddRows = false;
            dgvRecentEnrollments.AllowUserToDeleteRows = false;
            dgvRecentEnrollments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentEnrollments.BackgroundColor = Color.White;
            dgvRecentEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentEnrollments.Location = new Point(22, 74);
            dgvRecentEnrollments.MultiSelect = false;
            dgvRecentEnrollments.Name = "dgvRecentEnrollments";
            dgvRecentEnrollments.ReadOnly = true;
            dgvRecentEnrollments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentEnrollments.Size = new Size(708, 536);
            dgvRecentEnrollments.TabIndex = 1;
            // 
            // pnlRecentPayments
            // 
            pnlRecentPayments.BackColor = Color.White;
            pnlRecentPayments.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentPayments.Controls.Add(dgvRecentPayments);
            pnlRecentPayments.Controls.Add(lblRecentPaymentsHeader);
            pnlRecentPayments.Location = new Point(802, 422);
            pnlRecentPayments.Name = "pnlRecentPayments";
            pnlRecentPayments.Size = new Size(754, 634);
            pnlRecentPayments.TabIndex = 10;
            // 
            // lblRecentPaymentsHeader
            // 
            lblRecentPaymentsHeader.AutoSize = true;
            lblRecentPaymentsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentPaymentsHeader.Location = new Point(22, 20);
            lblRecentPaymentsHeader.Name = "lblRecentPaymentsHeader";
            lblRecentPaymentsHeader.Size = new Size(227, 37);
            lblRecentPaymentsHeader.TabIndex = 0;
            lblRecentPaymentsHeader.Text = "Recent Payments";
            // 
            // dgvRecentPayments
            // 
            dgvRecentPayments.AllowUserToAddRows = false;
            dgvRecentPayments.AllowUserToDeleteRows = false;
            dgvRecentPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentPayments.BackgroundColor = Color.White;
            dgvRecentPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentPayments.Location = new Point(22, 74);
            dgvRecentPayments.MultiSelect = false;
            dgvRecentPayments.Name = "dgvRecentPayments";
            dgvRecentPayments.ReadOnly = true;
            dgvRecentPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentPayments.Size = new Size(708, 536);
            dgvRecentPayments.TabIndex = 1;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 1080);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCardStudents.ResumeLayout(false);
            pnlCardStudents.PerformLayout();
            pnlCardEnrolled.ResumeLayout(false);
            pnlCardEnrolled.PerformLayout();
            pnlCardSections.ResumeLayout(false);
            pnlCardSections.PerformLayout();
            pnlCardAssessed.ResumeLayout(false);
            pnlCardAssessed.PerformLayout();
            pnlCardCollected.ResumeLayout(false);
            pnlCardCollected.PerformLayout();
            pnlCardBalance.ResumeLayout(false);
            pnlCardBalance.PerformLayout();
            pnlRecentEnrollments.ResumeLayout(false);
            pnlRecentEnrollments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentEnrollments).EndInit();
            pnlRecentPayments.ResumeLayout(false);
            pnlRecentPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label DASHBOARD;
        private Label lblWelcome;
        private Button btnRefresh;
        private Panel pnlCardStudents;
        private Label lblCardStudentsTitle;
        private Label lblCardStudentsValue;
        private Label lblCardStudentsSub;
        private Panel pnlCardEnrolled;
        private Label lblCardEnrolledTitle;
        private Label lblCardEnrolledValue;
        private Label lblCardEnrolledSub;
        private Panel pnlCardSections;
        private Label lblCardSectionsTitle;
        private Label lblCardSectionsValue;
        private Label lblCardSectionsSub;
        private Panel pnlCardAssessed;
        private Label lblCardAssessedTitle;
        private Label lblCardAssessedValue;
        private Label lblCardAssessedSub;
        private Panel pnlCardCollected;
        private Label lblCardCollectedTitle;
        private Label lblCardCollectedValue;
        private Label lblCardCollectedSub;
        private Panel pnlCardBalance;
        private Label lblCardBalanceTitle;
        private Label lblCardBalanceValue;
        private Label lblCardBalanceSub;
        private Panel pnlRecentEnrollments;
        private Label lblRecentEnrollmentsHeader;
        private DataGridView dgvRecentEnrollments;
        private Panel pnlRecentPayments;
        private Label lblRecentPaymentsHeader;
        private DataGridView dgvRecentPayments;
    }
}