namespace UI
{
    partial class FrmAccountSearch
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
            pnlCardAssessed = new Panel();
            lblCardAssessedTitle = new Label();
            lblCardAssessedValue = new Label();
            pnlCardCollected = new Panel();
            lblCardCollectedTitle = new Label();
            lblCardCollectedValue = new Label();
            pnlCardBalance = new Panel();
            lblCardBalanceTitle = new Label();
            lblCardBalanceValue = new Label();
            pnlCardAccounts = new Panel();
            lblCardAccountsTitle = new Label();
            lblCardAccountsValue = new Label();
            pnlAccountList = new Panel();
            lblAccountListHeader = new Label();
            lblStatusFilter = new Label();
            cboStatusFilter = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnClearFilter = new Button();
            dgvAccounts = new DataGridView();
            pnlCardAssessed.SuspendLayout();
            pnlCardCollected.SuspendLayout();
            pnlCardBalance.SuspendLayout();
            pnlCardAccounts.SuspendLayout();
            pnlAccountList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(344, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "ACCOUNT SEARCH";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(574, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Look up student billing statements, total payments made, and remaining balances.";
            // 
            // pnlCardAssessed
            // 
            pnlCardAssessed.BackColor = Color.White;
            pnlCardAssessed.BorderStyle = BorderStyle.FixedSingle;
            pnlCardAssessed.Controls.Add(lblCardAssessedValue);
            pnlCardAssessed.Controls.Add(lblCardAssessedTitle);
            pnlCardAssessed.Location = new Point(24, 118);
            pnlCardAssessed.Name = "pnlCardAssessed";
            pnlCardAssessed.Size = new Size(368, 105);
            pnlCardAssessed.TabIndex = 2;
            // 
            // lblCardAssessedTitle
            // 
            lblCardAssessedTitle.AutoSize = true;
            lblCardAssessedTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAssessedTitle.ForeColor = Color.DimGray;
            lblCardAssessedTitle.Location = new Point(18, 14);
            lblCardAssessedTitle.Name = "lblCardAssessedTitle";
            lblCardAssessedTitle.Size = new Size(156, 25);
            lblCardAssessedTitle.TabIndex = 0;
            lblCardAssessedTitle.Text = "TOTAL ASSESSED";
            // 
            // lblCardAssessedValue
            // 
            lblCardAssessedValue.AutoSize = true;
            lblCardAssessedValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAssessedValue.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardAssessedValue.Location = new Point(16, 46);
            lblCardAssessedValue.Name = "lblCardAssessedValue";
            lblCardAssessedValue.Size = new Size(118, 46);
            lblCardAssessedValue.TabIndex = 1;
            lblCardAssessedValue.Text = "₱0.00";
            // 
            // pnlCardCollected
            // 
            pnlCardCollected.BackColor = Color.White;
            pnlCardCollected.BorderStyle = BorderStyle.FixedSingle;
            pnlCardCollected.Controls.Add(lblCardCollectedValue);
            pnlCardCollected.Controls.Add(lblCardCollectedTitle);
            pnlCardCollected.Location = new Point(412, 118);
            pnlCardCollected.Name = "pnlCardCollected";
            pnlCardCollected.Size = new Size(368, 105);
            pnlCardCollected.TabIndex = 3;
            // 
            // lblCardCollectedTitle
            // 
            lblCardCollectedTitle.AutoSize = true;
            lblCardCollectedTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCollectedTitle.ForeColor = Color.DimGray;
            lblCardCollectedTitle.Location = new Point(18, 14);
            lblCardCollectedTitle.Name = "lblCardCollectedTitle";
            lblCardCollectedTitle.Size = new Size(165, 25);
            lblCardCollectedTitle.TabIndex = 0;
            lblCardCollectedTitle.Text = "TOTAL COLLECTED";
            // 
            // lblCardCollectedValue
            // 
            lblCardCollectedValue.AutoSize = true;
            lblCardCollectedValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCollectedValue.ForeColor = Color.FromArgb(22, 101, 52);
            lblCardCollectedValue.Location = new Point(16, 46);
            lblCardCollectedValue.Name = "lblCardCollectedValue";
            lblCardCollectedValue.Size = new Size(118, 46);
            lblCardCollectedValue.TabIndex = 1;
            lblCardCollectedValue.Text = "₱0.00";
            // 
            // pnlCardBalance
            // 
            pnlCardBalance.BackColor = Color.White;
            pnlCardBalance.BorderStyle = BorderStyle.FixedSingle;
            pnlCardBalance.Controls.Add(lblCardBalanceValue);
            pnlCardBalance.Controls.Add(lblCardBalanceTitle);
            pnlCardBalance.Location = new Point(800, 118);
            pnlCardBalance.Name = "pnlCardBalance";
            pnlCardBalance.Size = new Size(368, 105);
            pnlCardBalance.TabIndex = 4;
            // 
            // lblCardBalanceTitle
            // 
            lblCardBalanceTitle.AutoSize = true;
            lblCardBalanceTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardBalanceTitle.ForeColor = Color.DimGray;
            lblCardBalanceTitle.Location = new Point(18, 14);
            lblCardBalanceTitle.Name = "lblCardBalanceTitle";
            lblCardBalanceTitle.Size = new Size(216, 25);
            lblCardBalanceTitle.TabIndex = 0;
            lblCardBalanceTitle.Text = "OUTSTANDING BALANCE";
            // 
            // lblCardBalanceValue
            // 
            lblCardBalanceValue.AutoSize = true;
            lblCardBalanceValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardBalanceValue.ForeColor = Color.FromArgb(185, 28, 28);
            lblCardBalanceValue.Location = new Point(16, 46);
            lblCardBalanceValue.Name = "lblCardBalanceValue";
            lblCardBalanceValue.Size = new Size(118, 46);
            lblCardBalanceValue.TabIndex = 1;
            lblCardBalanceValue.Text = "₱0.00";
            // 
            // pnlCardAccounts
            // 
            pnlCardAccounts.BackColor = Color.White;
            pnlCardAccounts.BorderStyle = BorderStyle.FixedSingle;
            pnlCardAccounts.Controls.Add(lblCardAccountsValue);
            pnlCardAccounts.Controls.Add(lblCardAccountsTitle);
            pnlCardAccounts.Location = new Point(1188, 118);
            pnlCardAccounts.Name = "pnlCardAccounts";
            pnlCardAccounts.Size = new Size(368, 105);
            pnlCardAccounts.TabIndex = 5;
            // 
            // lblCardAccountsTitle
            // 
            lblCardAccountsTitle.AutoSize = true;
            lblCardAccountsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAccountsTitle.ForeColor = Color.DimGray;
            lblCardAccountsTitle.Location = new Point(18, 14);
            lblCardAccountsTitle.Name = "lblCardAccountsTitle";
            lblCardAccountsTitle.Size = new Size(192, 25);
            lblCardAccountsTitle.TabIndex = 0;
            lblCardAccountsTitle.Text = "ASSESSED ACCOUNTS";
            // 
            // lblCardAccountsValue
            // 
            lblCardAccountsValue.AutoSize = true;
            lblCardAccountsValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAccountsValue.ForeColor = Color.FromArgb(30, 58, 138);
            lblCardAccountsValue.Location = new Point(16, 46);
            lblCardAccountsValue.Name = "lblCardAccountsValue";
            lblCardAccountsValue.Size = new Size(38, 46);
            lblCardAccountsValue.TabIndex = 1;
            lblCardAccountsValue.Text = "0";
            // 
            // pnlAccountList
            // 
            pnlAccountList.BackColor = Color.White;
            pnlAccountList.BorderStyle = BorderStyle.FixedSingle;
            pnlAccountList.Controls.Add(dgvAccounts);
            pnlAccountList.Controls.Add(btnClearFilter);
            pnlAccountList.Controls.Add(txtSearch);
            pnlAccountList.Controls.Add(lblSearch);
            pnlAccountList.Controls.Add(cboStatusFilter);
            pnlAccountList.Controls.Add(lblStatusFilter);
            pnlAccountList.Controls.Add(lblAccountListHeader);
            pnlAccountList.Location = new Point(24, 243);
            pnlAccountList.Name = "pnlAccountList";
            pnlAccountList.Size = new Size(1532, 813);
            pnlAccountList.TabIndex = 6;
            // 
            // lblAccountListHeader
            // 
            lblAccountListHeader.AutoSize = true;
            lblAccountListHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountListHeader.Location = new Point(24, 24);
            lblAccountListHeader.Name = "lblAccountListHeader";
            lblAccountListHeader.Size = new Size(277, 37);
            lblAccountListHeader.TabIndex = 0;
            lblAccountListHeader.Text = "Student Account Balances";
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusFilter.Location = new Point(774, 14);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(134, 25);
            lblStatusFilter.TabIndex = 1;
            lblStatusFilter.Text = "Account Status";
            // 
            // cboStatusFilter
            // 
            cboStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatusFilter.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStatusFilter.FormattingEnabled = true;
            cboStatusFilter.Items.AddRange(new object[] { "All", "Unpaid", "Partial", "Paid" });
            cboStatusFilter.Location = new Point(774, 40);
            cboStatusFilter.Name = "cboStatusFilter";
            cboStatusFilter.Size = new Size(210, 34);
            cboStatusFilter.TabIndex = 2;
            cboStatusFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(1004, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(275, 25);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search by Student, Grade, or Section";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1004, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type LRN, name, grade, or section...";
            txtSearch.Size = new Size(370, 33);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += FilterChanged;
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = Color.FromArgb(100, 116, 139);
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(1386, 39);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(120, 35);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Reset";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // dgvAccounts
            // 
            dgvAccounts.AllowUserToAddRows = false;
            dgvAccounts.AllowUserToDeleteRows = false;
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.BackgroundColor = Color.White;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(24, 92);
            dgvAccounts.MultiSelect = false;
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(1482, 697);
            dgvAccounts.TabIndex = 6;
            dgvAccounts.CellClick += dgvAccounts_CellClick;
            // 
            // FrmAccountSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlAccountList);
            Controls.Add(pnlCardAccounts);
            Controls.Add(pnlCardBalance);
            Controls.Add(pnlCardCollected);
            Controls.Add(pnlCardAssessed);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAccountSearch";
            Text = "FrmAccountSearch";
            Load += FrmAccountSearch_Load;
            pnlCardAssessed.ResumeLayout(false);
            pnlCardAssessed.PerformLayout();
            pnlCardCollected.ResumeLayout(false);
            pnlCardCollected.PerformLayout();
            pnlCardBalance.ResumeLayout(false);
            pnlCardBalance.PerformLayout();
            pnlCardAccounts.ResumeLayout(false);
            pnlCardAccounts.PerformLayout();
            pnlAccountList.ResumeLayout(false);
            pnlAccountList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlCardAssessed;
        private Label lblCardAssessedTitle;
        private Label lblCardAssessedValue;
        private Panel pnlCardCollected;
        private Label lblCardCollectedTitle;
        private Label lblCardCollectedValue;
        private Panel pnlCardBalance;
        private Label lblCardBalanceTitle;
        private Label lblCardBalanceValue;
        private Panel pnlCardAccounts;
        private Label lblCardAccountsTitle;
        private Label lblCardAccountsValue;
        private Panel pnlAccountList;
        private Label lblAccountListHeader;
        private Label lblStatusFilter;
        private ComboBox cboStatusFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnClearFilter;
        private DataGridView dgvAccounts;
    }
}