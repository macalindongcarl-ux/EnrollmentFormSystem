namespace UI
{
    partial class FrmPaymentHistory
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
            pnlCardTotalCollected = new Panel();
            lblCardTotalTitle = new Label();
            lblCardTotalValue = new Label();
            pnlCardCount = new Panel();
            lblCardCountTitle = new Label();
            lblCardCountValue = new Label();
            pnlCardCash = new Panel();
            lblCardCashTitle = new Label();
            lblCardCashValue = new Label();
            pnlCardNonCash = new Panel();
            lblCardNonCashTitle = new Label();
            lblCardNonCashValue = new Label();
            pnlHistoryContainer = new Panel();
            lblHistoryHeader = new Label();
            chkFilterByDate = new CheckBox();
            lblDateFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpTo = new DateTimePicker();
            lblMethodFilter = new Label();
            cboMethodFilter = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnResetFilters = new Button();
            btnPrintReceipt = new Button();
            dgvHistory = new DataGridView();
            pnlCardTotalCollected.SuspendLayout();
            pnlCardCount.SuspendLayout();
            pnlCardCash.SuspendLayout();
            pnlCardNonCash.SuspendLayout();
            pnlHistoryContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(375, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "PAYMENT HISTORY";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(554, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Review payment transactions, filter collections, and print official receipts.";
            // 
            // pnlCardTotalCollected
            // 
            pnlCardTotalCollected.BackColor = Color.White;
            pnlCardTotalCollected.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotalCollected.Controls.Add(lblCardTotalValue);
            pnlCardTotalCollected.Controls.Add(lblCardTotalTitle);
            pnlCardTotalCollected.Location = new Point(24, 118);
            pnlCardTotalCollected.Name = "pnlCardTotalCollected";
            pnlCardTotalCollected.Size = new Size(368, 105);
            pnlCardTotalCollected.TabIndex = 2;
            // 
            // lblCardTotalTitle
            // 
            lblCardTotalTitle.AutoSize = true;
            lblCardTotalTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalTitle.ForeColor = Color.DimGray;
            lblCardTotalTitle.Location = new Point(18, 14);
            lblCardTotalTitle.Name = "lblCardTotalTitle";
            lblCardTotalTitle.Size = new Size(192, 25);
            lblCardTotalTitle.TabIndex = 0;
            lblCardTotalTitle.Text = "ACTIVE COLLECTIONS";
            // 
            // lblCardTotalValue
            // 
            lblCardTotalValue.AutoSize = true;
            lblCardTotalValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblCardTotalValue.Location = new Point(16, 46);
            lblCardTotalValue.Name = "lblCardTotalValue";
            lblCardTotalValue.Size = new Size(118, 46);
            lblCardTotalValue.TabIndex = 1;
            lblCardTotalValue.Text = "₱0.00";
            // 
            // pnlCardCount
            // 
            pnlCardCount.BackColor = Color.White;
            pnlCardCount.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCount.Controls.Add(lblCardCountValue);
            pnlCardCount.Controls.Add(lblCardCountTitle);
            pnlCardCount.Location = new Point(412, 118);
            pnlCardCount.Name = "pnlCardCount";
            pnlCardCount.Size = new Size(368, 105);
            pnlCardCount.TabIndex = 3;
            // 
            // lblCardCountTitle
            // 
            lblCardCountTitle.AutoSize = true;
            lblCardCountTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCountTitle.ForeColor = Color.DimGray;
            lblCardCountTitle.Location = new Point(18, 14);
            lblCardCountTitle.Name = "lblCardCountTitle";
            lblCardCountTitle.Size = new Size(187, 25);
            lblCardCountTitle.TabIndex = 0;
            lblCardCountTitle.Text = "RECEIPTS ISSUED";
            // 
            // lblCardCountValue
            // 
            lblCardCountValue.AutoSize = true;
            lblCardCountValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCountValue.ForeColor = Color.FromArgb(30, 58, 138);
            lblCardCountValue.Location = new Point(16, 46);
            lblCardCountValue.Name = "lblCardCountValue";
            lblCardCountValue.Size = new Size(38, 46);
            lblCardCountValue.TabIndex = 1;
            lblCardCountValue.Text = "0";
            // 
            // pnlCardCash
            // 
            pnlCardCash.BackColor = Color.White;
            pnlCardCash.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCash.Controls.Add(lblCardCashValue);
            pnlCardCash.Controls.Add(lblCardCashTitle);
            pnlCardCash.Location = new Point(800, 118);
            pnlCardCash.Name = "pnlCardCash";
            pnlCardCash.Size = new Size(368, 105);
            pnlCardCash.TabIndex = 4;
            // 
            // lblCardCashTitle
            // 
            lblCardCashTitle.AutoSize = true;
            lblCardCashTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCashTitle.ForeColor = Color.DimGray;
            lblCardCashTitle.Location = new Point(18, 14);
            lblCardCashTitle.Name = "lblCardCashTitle";
            lblCardCashTitle.Size = new Size(158, 25);
            lblCardCashTitle.TabIndex = 0;
            lblCardCashTitle.Text = "CASH PAYMENTS";
            // 
            // lblCardCashValue
            // 
            lblCardCashValue.AutoSize = true;
            lblCardCashValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCashValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardCashValue.Location = new Point(16, 46);
            lblCardCashValue.Name = "lblCardCashValue";
            lblCardCashValue.Size = new Size(118, 46);
            lblCardCashValue.TabIndex = 1;
            lblCardCashValue.Text = "₱0.00";
            // 
            // pnlCardNonCash
            // 
            pnlCardNonCash.BackColor = Color.White;
            pnlCardNonCash.BorderStyle = BorderStyle.FixedSingle;
            pnlCardNonCash.Controls.Add(lblCardNonCashValue);
            pnlCardNonCash.Controls.Add(lblCardNonCashTitle);
            pnlCardNonCash.Location = new Point(1188, 118);
            pnlCardNonCash.Name = "pnlCardNonCash";
            pnlCardNonCash.Size = new Size(368, 105);
            pnlCardNonCash.TabIndex = 5;
            // 
            // lblCardNonCashTitle
            // 
            lblCardNonCashTitle.AutoSize = true;
            lblCardNonCashTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardNonCashTitle.ForeColor = Color.DimGray;
            lblCardNonCashTitle.Location = new Point(18, 14);
            lblCardNonCashTitle.Name = "lblCardNonCashTitle";
            lblCardNonCashTitle.Size = new Size(216, 25);
            lblCardNonCashTitle.TabIndex = 0;
            lblCardNonCashTitle.Text = "DIGITAL / BANK / CHECK";
            // 
            // lblCardNonCashValue
            // 
            lblCardNonCashValue.AutoSize = true;
            lblCardNonCashValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardNonCashValue.ForeColor = Color.FromArgb(52, 118, 184);
            lblCardNonCashValue.Location = new Point(16, 46);
            lblCardNonCashValue.Name = "lblCardNonCashValue";
            lblCardNonCashValue.Size = new Size(118, 46);
            lblCardNonCashValue.TabIndex = 1;
            lblCardNonCashValue.Text = "₱0.00";
            // 
            // pnlHistoryContainer
            // 
            pnlHistoryContainer.BackColor = Color.White;
            pnlHistoryContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlHistoryContainer.Controls.Add(dgvHistory);
            pnlHistoryContainer.Controls.Add(btnPrintReceipt);
            pnlHistoryContainer.Controls.Add(btnResetFilters);
            pnlHistoryContainer.Controls.Add(txtSearch);
            pnlHistoryContainer.Controls.Add(lblSearch);
            pnlHistoryContainer.Controls.Add(cboMethodFilter);
            pnlHistoryContainer.Controls.Add(lblMethodFilter);
            pnlHistoryContainer.Controls.Add(dtpTo);
            pnlHistoryContainer.Controls.Add(lblDateTo);
            pnlHistoryContainer.Controls.Add(dtpFrom);
            pnlHistoryContainer.Controls.Add(lblDateFrom);
            pnlHistoryContainer.Controls.Add(chkFilterByDate);
            pnlHistoryContainer.Controls.Add(lblHistoryHeader);
            pnlHistoryContainer.Location = new Point(24, 243);
            pnlHistoryContainer.Name = "pnlHistoryContainer";
            pnlHistoryContainer.Size = new Size(1532, 813);
            pnlHistoryContainer.TabIndex = 6;
            // 
            // lblHistoryHeader
            // 
            lblHistoryHeader.AutoSize = true;
            lblHistoryHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryHeader.Location = new Point(24, 24);
            lblHistoryHeader.Name = "lblHistoryHeader";
            lblHistoryHeader.Size = new Size(256, 37);
            lblHistoryHeader.TabIndex = 0;
            lblHistoryHeader.Text = "Transaction History";
            // 
            // chkFilterByDate
            // 
            chkFilterByDate.AutoSize = true;
            chkFilterByDate.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFilterByDate.Location = new Point(310, 44);
            chkFilterByDate.Name = "chkFilterByDate";
            chkFilterByDate.Size = new Size(134, 29);
            chkFilterByDate.TabIndex = 1;
            chkFilterByDate.Text = "Filter by Date";
            chkFilterByDate.UseVisualStyleBackColor = true;
            chkFilterByDate.CheckedChanged += chkFilterByDate_CheckedChanged;
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateFrom.Location = new Point(454, 14);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(49, 23);
            lblDateFrom.TabIndex = 2;
            lblDateFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(454, 40);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(145, 32);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += FilterChanged;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTo.Location = new Point(611, 14);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(29, 23);
            lblDateTo.TabIndex = 4;
            lblDateTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(611, 40);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(145, 32);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += FilterChanged;
            // 
            // lblMethodFilter
            // 
            lblMethodFilter.AutoSize = true;
            lblMethodFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMethodFilter.Location = new Point(772, 14);
            lblMethodFilter.Name = "lblMethodFilter";
            lblMethodFilter.Size = new Size(71, 23);
            lblMethodFilter.TabIndex = 6;
            lblMethodFilter.Text = "Method";
            // 
            // cboMethodFilter
            // 
            cboMethodFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMethodFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMethodFilter.FormattingEnabled = true;
            cboMethodFilter.Items.AddRange(new object[] { "All", "Cash", "GCash", "Bank Transfer", "Check" });
            cboMethodFilter.Location = new Point(772, 40);
            cboMethodFilter.Name = "cboMethodFilter";
            cboMethodFilter.Size = new Size(175, 33);
            cboMethodFilter.TabIndex = 7;
            cboMethodFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(963, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(209, 23);
            lblSearch.TabIndex = 8;
            lblSearch.Text = "Search OR #, Student, or Section";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(963, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "OR #, LRN, name, grade...";
            txtSearch.Size = new Size(265, 32);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += FilterChanged;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.FromArgb(100, 116, 139);
            btnResetFilters.FlatAppearance.BorderSize = 0;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(1240, 39);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(88, 34);
            btnResetFilters.TabIndex = 10;
            btnResetFilters.Text = "Reset";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.FromArgb(52, 118, 184);
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = Color.White;
            btnPrintReceipt.Location = new Point(1338, 39);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(168, 34);
            btnPrintReceipt.TabIndex = 11;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(24, 92);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1482, 697);
            dgvHistory.TabIndex = 12;
            dgvHistory.CellClick += dgvHistory_CellClick;
            dgvHistory.CellDoubleClick += dgvHistory_CellDoubleClick;
            // 
            // FrmPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlHistoryContainer);
            Controls.Add(pnlCardNonCash);
            Controls.Add(pnlCardCash);
            Controls.Add(pnlCardCount);
            Controls.Add(pnlCardTotalCollected);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPaymentHistory";
            Text = "FrmPaymentHistory";
            Load += FrmPaymentHistory_Load;
            pnlCardTotalCollected.ResumeLayout(false);
            pnlCardTotalCollected.PerformLayout();
            pnlCardCount.ResumeLayout(false);
            pnlCardCount.PerformLayout();
            pnlCardCash.ResumeLayout(false);
            pnlCardCash.PerformLayout();
            pnlCardNonCash.ResumeLayout(false);
            pnlCardNonCash.PerformLayout();
            pnlHistoryContainer.ResumeLayout(false);
            pnlHistoryContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlCardTotalCollected;
        private Label lblCardTotalTitle;
        private Label lblCardTotalValue;
        private Panel pnlCardCount;
        private Label lblCardCountTitle;
        private Label lblCardCountValue;
        private Panel pnlCardCash;
        private Label lblCardCashTitle;
        private Label lblCardCashValue;
        private Panel pnlCardNonCash;
        private Label lblCardNonCashTitle;
        private Label lblCardNonCashValue;
        private Panel pnlHistoryContainer;
        private Label lblHistoryHeader;
        private CheckBox chkFilterByDate;
        private Label lblDateFrom;
        private DateTimePicker dtpFrom;
        private Label lblDateTo;
        private DateTimePicker dtpTo;
        private Label lblMethodFilter;
        private ComboBox cboMethodFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnResetFilters;
        private Button btnPrintReceipt;
        private DataGridView dgvHistory;
    }
}