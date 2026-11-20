namespace UI
{
    partial class FrmPayment
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
            pnlPaymentDetails = new Panel();
            lblPaymentDetailsHeader = new Label();
            lblStudentSearch = new Label();
            txtStudentSearch = new TextBox();
            lstStudentSuggestions = new ListBox();
            lblGradeSection = new Label();
            txtGradeSection = new TextBox();
            lblSchoolYear = new Label();
            txtSchoolYear = new TextBox();
            lblPaymentStatus = new Label();
            txtPaymentStatus = new TextBox();
            lblTotalAssessed = new Label();
            txtTotalAssessed = new TextBox();
            lblTotalPaid = new Label();
            txtTotalPaid = new TextBox();
            lblRemainingBalance = new Label();
            txtRemainingBalance = new TextBox();
            lblNewBalance = new Label();
            txtNewBalance = new TextBox();
            lblAmountPaid = new Label();
            txtAmountPaid = new TextBox();
            btnPayFull = new Button();
            lblPaymentMethod = new Label();
            cboPaymentMethod = new ComboBox();
            lblReferenceNumber = new Label();
            txtReferenceNumber = new TextBox();
            lblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            btnProcessPayment = new Button();
            btnVoidPayment = new Button();
            btnClearPayment = new Button();
            pnlPaymentRecords = new Panel();
            lblPaymentRecordsHeader = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvPayments = new DataGridView();
            pnlPaymentDetails.SuspendLayout();
            pnlPaymentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(219, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "PAYMENTS";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(498, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Process full or partial student payments and issue official receipts.";
            // 
            // pnlPaymentDetails
            // 
            pnlPaymentDetails.BackColor = Color.White;
            pnlPaymentDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentDetails.Controls.Add(lstStudentSuggestions);
            pnlPaymentDetails.Controls.Add(btnClearPayment);
            pnlPaymentDetails.Controls.Add(btnVoidPayment);
            pnlPaymentDetails.Controls.Add(btnProcessPayment);
            pnlPaymentDetails.Controls.Add(dtpPaymentDate);
            pnlPaymentDetails.Controls.Add(lblPaymentDate);
            pnlPaymentDetails.Controls.Add(txtReferenceNumber);
            pnlPaymentDetails.Controls.Add(lblReferenceNumber);
            pnlPaymentDetails.Controls.Add(cboPaymentMethod);
            pnlPaymentDetails.Controls.Add(lblPaymentMethod);
            pnlPaymentDetails.Controls.Add(btnPayFull);
            pnlPaymentDetails.Controls.Add(txtAmountPaid);
            pnlPaymentDetails.Controls.Add(lblAmountPaid);
            pnlPaymentDetails.Controls.Add(txtNewBalance);
            pnlPaymentDetails.Controls.Add(lblNewBalance);
            pnlPaymentDetails.Controls.Add(txtRemainingBalance);
            pnlPaymentDetails.Controls.Add(lblRemainingBalance);
            pnlPaymentDetails.Controls.Add(txtTotalPaid);
            pnlPaymentDetails.Controls.Add(lblTotalPaid);
            pnlPaymentDetails.Controls.Add(txtTotalAssessed);
            pnlPaymentDetails.Controls.Add(lblTotalAssessed);
            pnlPaymentDetails.Controls.Add(txtPaymentStatus);
            pnlPaymentDetails.Controls.Add(lblPaymentStatus);
            pnlPaymentDetails.Controls.Add(txtSchoolYear);
            pnlPaymentDetails.Controls.Add(lblSchoolYear);
            pnlPaymentDetails.Controls.Add(txtGradeSection);
            pnlPaymentDetails.Controls.Add(lblGradeSection);
            pnlPaymentDetails.Controls.Add(txtStudentSearch);
            pnlPaymentDetails.Controls.Add(lblStudentSearch);
            pnlPaymentDetails.Controls.Add(lblPaymentDetailsHeader);
            pnlPaymentDetails.Location = new Point(24, 118);
            pnlPaymentDetails.Name = "pnlPaymentDetails";
            pnlPaymentDetails.Size = new Size(1532, 395);
            pnlPaymentDetails.TabIndex = 2;
            // 
            // lblPaymentDetailsHeader
            // 
            lblPaymentDetailsHeader.AutoSize = true;
            lblPaymentDetailsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentDetailsHeader.Location = new Point(24, 16);
            lblPaymentDetailsHeader.Name = "lblPaymentDetailsHeader";
            lblPaymentDetailsHeader.Size = new Size(216, 37);
            lblPaymentDetailsHeader.TabIndex = 0;
            lblPaymentDetailsHeader.Text = "Cashier Payment";
            // 
            // lblStudentSearch
            // 
            lblStudentSearch.AutoSize = true;
            lblStudentSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentSearch.Location = new Point(24, 65);
            lblStudentSearch.Name = "lblStudentSearch";
            lblStudentSearch.Size = new Size(154, 25);
            lblStudentSearch.TabIndex = 1;
            lblStudentSearch.Text = "Assessed Student";
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentSearch.Location = new Point(24, 92);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.PlaceholderText = "Search assessed LRN or Student Name...";
            txtStudentSearch.Size = new Size(560, 33);
            txtStudentSearch.TabIndex = 2;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            txtStudentSearch.KeyDown += txtStudentSearch_KeyDown;
            txtStudentSearch.Leave += txtStudentSearch_Leave;
            // 
            // lstStudentSuggestions
            // 
            lstStudentSuggestions.BorderStyle = BorderStyle.FixedSingle;
            lstStudentSuggestions.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstStudentSuggestions.FormattingEnabled = true;
            lstStudentSuggestions.ItemHeight = 24;
            lstStudentSuggestions.Location = new Point(24, 125);
            lstStudentSuggestions.Name = "lstStudentSuggestions";
            lstStudentSuggestions.Size = new Size(560, 120);
            lstStudentSuggestions.TabIndex = 27;
            lstStudentSuggestions.Visible = false;
            lstStudentSuggestions.Click += lstStudentSuggestions_Click;
            lstStudentSuggestions.KeyDown += lstStudentSuggestions_KeyDown;
            // 
            // lblGradeSection
            // 
            lblGradeSection.AutoSize = true;
            lblGradeSection.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeSection.Location = new Point(604, 65);
            lblGradeSection.Name = "lblGradeSection";
            lblGradeSection.Size = new Size(192, 25);
            lblGradeSection.TabIndex = 3;
            lblGradeSection.Text = "Grade Level && Section";
            // 
            // txtGradeSection
            // 
            txtGradeSection.BackColor = Color.FromArgb(241, 245, 249);
            txtGradeSection.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeSection.Location = new Point(604, 92);
            txtGradeSection.Name = "txtGradeSection";
            txtGradeSection.ReadOnly = true;
            txtGradeSection.Size = new Size(340, 33);
            txtGradeSection.TabIndex = 4;
            txtGradeSection.TabStop = false;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.Location = new Point(964, 65);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(105, 25);
            lblSchoolYear.TabIndex = 5;
            lblSchoolYear.Text = "School Year";
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.BackColor = Color.FromArgb(241, 245, 249);
            txtSchoolYear.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(964, 92);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.ReadOnly = true;
            txtSchoolYear.Size = new Size(250, 33);
            txtSchoolYear.TabIndex = 6;
            txtSchoolYear.TabStop = false;
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentStatus.Location = new Point(1234, 65);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(134, 25);
            lblPaymentStatus.TabIndex = 7;
            lblPaymentStatus.Text = "Account Status";
            // 
            // txtPaymentStatus
            // 
            txtPaymentStatus.BackColor = Color.FromArgb(241, 245, 249);
            txtPaymentStatus.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPaymentStatus.Location = new Point(1234, 92);
            txtPaymentStatus.Name = "txtPaymentStatus";
            txtPaymentStatus.ReadOnly = true;
            txtPaymentStatus.Size = new Size(272, 33);
            txtPaymentStatus.TabIndex = 8;
            txtPaymentStatus.TabStop = false;
            txtPaymentStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTotalAssessed
            // 
            lblTotalAssessed.AutoSize = true;
            lblTotalAssessed.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAssessed.Location = new Point(24, 142);
            lblTotalAssessed.Name = "lblTotalAssessed";
            lblTotalAssessed.Size = new Size(165, 25);
            lblTotalAssessed.TabIndex = 9;
            lblTotalAssessed.Text = "Total Assessment (₱)";
            // 
            // txtTotalAssessed
            // 
            txtTotalAssessed.BackColor = Color.FromArgb(241, 245, 249);
            txtTotalAssessed.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAssessed.Location = new Point(24, 169);
            txtTotalAssessed.Name = "txtTotalAssessed";
            txtTotalAssessed.ReadOnly = true;
            txtTotalAssessed.Size = new Size(345, 33);
            txtTotalAssessed.TabIndex = 10;
            txtTotalAssessed.TabStop = false;
            txtTotalAssessed.Text = "0.00";
            txtTotalAssessed.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPaid.Location = new Point(389, 142);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(116, 25);
            lblTotalPaid.TabIndex = 11;
            lblTotalPaid.Text = "Total Paid (₱)";
            // 
            // txtTotalPaid
            // 
            txtTotalPaid.BackColor = Color.FromArgb(241, 245, 249);
            txtTotalPaid.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPaid.ForeColor = Color.FromArgb(22, 101, 52);
            txtTotalPaid.Location = new Point(389, 169);
            txtTotalPaid.Name = "txtTotalPaid";
            txtTotalPaid.ReadOnly = true;
            txtTotalPaid.Size = new Size(345, 33);
            txtTotalPaid.TabIndex = 12;
            txtTotalPaid.TabStop = false;
            txtTotalPaid.Text = "0.00";
            txtTotalPaid.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.AutoSize = true;
            lblRemainingBalance.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemainingBalance.Location = new Point(754, 142);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(192, 25);
            lblRemainingBalance.TabIndex = 13;
            lblRemainingBalance.Text = "Remaining Balance (₱)";
            // 
            // txtRemainingBalance
            // 
            txtRemainingBalance.BackColor = Color.FromArgb(241, 245, 249);
            txtRemainingBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemainingBalance.ForeColor = Color.FromArgb(185, 28, 28);
            txtRemainingBalance.Location = new Point(754, 169);
            txtRemainingBalance.Name = "txtRemainingBalance";
            txtRemainingBalance.ReadOnly = true;
            txtRemainingBalance.Size = new Size(365, 34);
            txtRemainingBalance.TabIndex = 14;
            txtRemainingBalance.TabStop = false;
            txtRemainingBalance.Text = "0.00";
            txtRemainingBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNewBalance
            // 
            lblNewBalance.AutoSize = true;
            lblNewBalance.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewBalance.Location = new Point(1139, 142);
            lblNewBalance.Name = "lblNewBalance";
            lblNewBalance.Size = new Size(216, 25);
            lblNewBalance.TabIndex = 15;
            lblNewBalance.Text = "Balance After Payment (₱)";
            // 
            // txtNewBalance
            // 
            txtNewBalance.BackColor = Color.FromArgb(241, 245, 249);
            txtNewBalance.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewBalance.ForeColor = Color.FromArgb(30, 58, 138);
            txtNewBalance.Location = new Point(1139, 169);
            txtNewBalance.Name = "txtNewBalance";
            txtNewBalance.ReadOnly = true;
            txtNewBalance.Size = new Size(367, 33);
            txtNewBalance.TabIndex = 16;
            txtNewBalance.TabStop = false;
            txtNewBalance.Text = "0.00";
            txtNewBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(24, 218);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(144, 25);
            lblAmountPaid.TabIndex = 17;
            lblAmountPaid.Text = "Amount Paid (₱)";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmountPaid.Location = new Point(24, 245);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(245, 34);
            txtAmountPaid.TabIndex = 18;
            txtAmountPaid.Text = "0.00";
            txtAmountPaid.TextAlign = HorizontalAlignment.Right;
            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            // 
            // btnPayFull
            // 
            btnPayFull.BackColor = Color.FromArgb(71, 85, 105);
            btnPayFull.FlatAppearance.BorderSize = 0;
            btnPayFull.FlatStyle = FlatStyle.Flat;
            btnPayFull.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayFull.ForeColor = Color.White;
            btnPayFull.Location = new Point(277, 245);
            btnPayFull.Name = "btnPayFull";
            btnPayFull.Size = new Size(92, 34);
            btnPayFull.TabIndex = 19;
            btnPayFull.Text = "Pay Full";
            btnPayFull.UseVisualStyleBackColor = false;
            btnPayFull.Click += btnPayFull_Click;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(389, 218);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(146, 25);
            lblPaymentMethod.TabIndex = 20;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaymentMethod.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Bank Transfer", "Check" });
            cboPaymentMethod.Location = new Point(389, 245);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(345, 34);
            cboPaymentMethod.TabIndex = 21;
            cboPaymentMethod.SelectedIndexChanged += cboPaymentMethod_SelectedIndexChanged;
            // 
            // lblReferenceNumber
            // 
            lblReferenceNumber.AutoSize = true;
            lblReferenceNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReferenceNumber.Location = new Point(754, 218);
            lblReferenceNumber.Name = "lblReferenceNumber";
            lblReferenceNumber.Size = new Size(233, 25);
            lblReferenceNumber.TabIndex = 22;
            lblReferenceNumber.Text = "Reference No. (Non-Cash)";
            // 
            // txtReferenceNumber
            // 
            txtReferenceNumber.Enabled = false;
            txtReferenceNumber.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReferenceNumber.Location = new Point(754, 245);
            txtReferenceNumber.Name = "txtReferenceNumber";
            txtReferenceNumber.PlaceholderText = "e.g., GCash / Bank Ref #";
            txtReferenceNumber.Size = new Size(365, 33);
            txtReferenceNumber.TabIndex = 23;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentDate.Location = new Point(1139, 218);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(118, 25);
            lblPaymentDate.TabIndex = 24;
            lblPaymentDate.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(1139, 245);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(367, 33);
            dtpPaymentDate.TabIndex = 25;
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.BackColor = Color.FromArgb(46, 139, 87);
            btnProcessPayment.FlatAppearance.BorderSize = 0;
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcessPayment.ForeColor = Color.White;
            btnProcessPayment.Location = new Point(24, 312);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(195, 44);
            btnProcessPayment.TabIndex = 26;
            btnProcessPayment.Text = "Record Payment";
            btnProcessPayment.UseVisualStyleBackColor = false;
            btnProcessPayment.Click += btnProcessPayment_Click;
            // 
            // btnVoidPayment
            // 
            btnVoidPayment.BackColor = Color.FromArgb(200, 60, 60);
            btnVoidPayment.FlatAppearance.BorderSize = 0;
            btnVoidPayment.FlatStyle = FlatStyle.Flat;
            btnVoidPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoidPayment.ForeColor = Color.White;
            btnVoidPayment.Location = new Point(235, 312);
            btnVoidPayment.Name = "btnVoidPayment";
            btnVoidPayment.Size = new Size(175, 44);
            btnVoidPayment.TabIndex = 28;
            btnVoidPayment.Text = "Void Payment";
            btnVoidPayment.UseVisualStyleBackColor = false;
            btnVoidPayment.Click += btnVoidPayment_Click;
            // 
            // btnClearPayment
            // 
            btnClearPayment.BackColor = Color.Gray;
            btnClearPayment.FlatAppearance.BorderSize = 0;
            btnClearPayment.FlatStyle = FlatStyle.Flat;
            btnClearPayment.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearPayment.ForeColor = Color.White;
            btnClearPayment.Location = new Point(426, 312);
            btnClearPayment.Name = "btnClearPayment";
            btnClearPayment.Size = new Size(158, 44);
            btnClearPayment.TabIndex = 29;
            btnClearPayment.Text = "Clear";
            btnClearPayment.UseVisualStyleBackColor = false;
            btnClearPayment.Click += btnClearPayment_Click;
            // 
            // pnlPaymentRecords
            // 
            pnlPaymentRecords.BackColor = Color.White;
            pnlPaymentRecords.BorderStyle = BorderStyle.FixedSingle;
            pnlPaymentRecords.Controls.Add(dgvPayments);
            pnlPaymentRecords.Controls.Add(btnSearch);
            pnlPaymentRecords.Controls.Add(txtSearch);
            pnlPaymentRecords.Controls.Add(lblSearch);
            pnlPaymentRecords.Controls.Add(lblPaymentRecordsHeader);
            pnlPaymentRecords.Location = new Point(24, 533);
            pnlPaymentRecords.Name = "pnlPaymentRecords";
            pnlPaymentRecords.Size = new Size(1532, 523);
            pnlPaymentRecords.TabIndex = 3;
            // 
            // lblPaymentRecordsHeader
            // 
            lblPaymentRecordsHeader.AutoSize = true;
            lblPaymentRecordsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentRecordsHeader.Location = new Point(24, 22);
            lblPaymentRecordsHeader.Name = "lblPaymentRecordsHeader";
            lblPaymentRecordsHeader.Size = new Size(277, 37);
            lblPaymentRecordsHeader.TabIndex = 0;
            lblPaymentRecordsHeader.Text = "Recent Payment Records";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1064, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(288, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search by OR #, Student, or Method";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1064, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type OR #, LRN, name, or method...";
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
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(24, 92);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1482, 407);
            dgvPayments.TabIndex = 4;
            dgvPayments.CellClick += dgvPayments_CellClick;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlPaymentRecords);
            Controls.Add(pnlPaymentDetails);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPayment";
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            pnlPaymentDetails.ResumeLayout(false);
            pnlPaymentDetails.PerformLayout();
            pnlPaymentRecords.ResumeLayout(false);
            pnlPaymentRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlPaymentDetails;
        private Label lblPaymentDetailsHeader;
        private Label lblStudentSearch;
        private TextBox txtStudentSearch;
        private ListBox lstStudentSuggestions;
        private Label lblGradeSection;
        private TextBox txtGradeSection;
        private Label lblSchoolYear;
        private TextBox txtSchoolYear;
        private Label lblPaymentStatus;
        private TextBox txtPaymentStatus;
        private Label lblTotalAssessed;
        private TextBox txtTotalAssessed;
        private Label lblTotalPaid;
        private TextBox txtTotalPaid;
        private Label lblRemainingBalance;
        private TextBox txtRemainingBalance;
        private Label lblNewBalance;
        private TextBox txtNewBalance;
        private Label lblAmountPaid;
        private TextBox txtAmountPaid;
        private Button btnPayFull;
        private Label lblPaymentMethod;
        private ComboBox cboPaymentMethod;
        private Label lblReferenceNumber;
        private TextBox txtReferenceNumber;
        private Label lblPaymentDate;
        private DateTimePicker dtpPaymentDate;
        private Button btnProcessPayment;
        private Button btnVoidPayment;
        private Button btnClearPayment;
        private Panel pnlPaymentRecords;
        private Label lblPaymentRecordsHeader;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvPayments;
    }
}