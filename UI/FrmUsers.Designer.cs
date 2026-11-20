namespace UI
{
    partial class FrmUsers
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
            pnlCardTotal = new Panel();
            lblCardTotalTitle = new Label();
            lblCardTotalValue = new Label();
            pnlCardAdmins = new Panel();
            lblCardAdminsTitle = new Label();
            lblCardAdminsValue = new Label();
            pnlCardRegistrars = new Panel();
            lblCardRegistrarsTitle = new Label();
            lblCardRegistrarsValue = new Label();
            pnlCardCashiers = new Panel();
            lblCardCashiersTitle = new Label();
            lblCardCashiersValue = new Label();
            pnlUserForm = new Panel();
            lblUserFormHeader = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            chkIsActive = new CheckBox();
            btnAddUser = new Button();
            btnUpdateUser = new Button();
            btnDeactivateUser = new Button();
            btnClearUser = new Button();
            pnlUserList = new Panel();
            lblUserListHeader = new Label();
            lblRoleFilter = new Label();
            cboRoleFilter = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvUsers = new DataGridView();
            pnlCardTotal.SuspendLayout();
            pnlCardAdmins.SuspendLayout();
            pnlCardRegistrars.SuspendLayout();
            pnlCardCashiers.SuspendLayout();
            pnlUserForm.SuspendLayout();
            pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
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
            DASHBOARD.Text = "USER MANAGEMENT";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(572, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Create and manage Admin, Registrar, and Cashier staff accounts.";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.White;
            pnlCardTotal.Controls.Add(lblCardTotalValue);
            pnlCardTotal.Controls.Add(lblCardTotalTitle);
            pnlCardTotal.Location = new Point(24, 118);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(368, 100);
            pnlCardTotal.TabIndex = 2;
            // 
            // lblCardTotalTitle
            // 
            lblCardTotalTitle.AutoSize = true;
            lblCardTotalTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalTitle.ForeColor = Color.DimGray;
            lblCardTotalTitle.Location = new Point(18, 14);
            lblCardTotalTitle.Name = "lblCardTotalTitle";
            lblCardTotalTitle.Size = new Size(125, 23);
            lblCardTotalTitle.TabIndex = 0;
            lblCardTotalTitle.Text = "TOTAL USERS";
            // 
            // lblCardTotalValue
            // 
            lblCardTotalValue.AutoSize = true;
            lblCardTotalValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardTotalValue.ForeColor = Color.FromArgb(30, 58, 138);
            lblCardTotalValue.Location = new Point(16, 42);
            lblCardTotalValue.Name = "lblCardTotalValue";
            lblCardTotalValue.Size = new Size(42, 50);
            lblCardTotalValue.TabIndex = 1;
            lblCardTotalValue.Text = "0";
            // 
            // pnlCardAdmins
            // 
            pnlCardAdmins.BackColor = Color.White;
            pnlCardAdmins.Controls.Add(lblCardAdminsValue);
            pnlCardAdmins.Controls.Add(lblCardAdminsTitle);
            pnlCardAdmins.Location = new Point(412, 118);
            pnlCardAdmins.Name = "pnlCardAdmins";
            pnlCardAdmins.Size = new Size(368, 100);
            pnlCardAdmins.TabIndex = 3;
            // 
            // lblCardAdminsTitle
            // 
            lblCardAdminsTitle.AutoSize = true;
            lblCardAdminsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAdminsTitle.ForeColor = Color.DimGray;
            lblCardAdminsTitle.Location = new Point(18, 14);
            lblCardAdminsTitle.Name = "lblCardAdminsTitle";
            lblCardAdminsTitle.Size = new Size(141, 23);
            lblCardAdminsTitle.TabIndex = 0;
            lblCardAdminsTitle.Text = "ACTIVE ADMINS";
            // 
            // lblCardAdminsValue
            // 
            lblCardAdminsValue.AutoSize = true;
            lblCardAdminsValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardAdminsValue.ForeColor = Color.FromArgb(79, 70, 229);
            lblCardAdminsValue.Location = new Point(16, 42);
            lblCardAdminsValue.Name = "lblCardAdminsValue";
            lblCardAdminsValue.Size = new Size(42, 50);
            lblCardAdminsValue.TabIndex = 1;
            lblCardAdminsValue.Text = "0";
            // 
            // pnlCardRegistrars
            // 
            pnlCardRegistrars.BackColor = Color.White;
            pnlCardRegistrars.Controls.Add(lblCardRegistrarsValue);
            pnlCardRegistrars.Controls.Add(lblCardRegistrarsTitle);
            pnlCardRegistrars.Location = new Point(800, 118);
            pnlCardRegistrars.Name = "pnlCardRegistrars";
            pnlCardRegistrars.Size = new Size(368, 100);
            pnlCardRegistrars.TabIndex = 4;
            // 
            // lblCardRegistrarsTitle
            // 
            lblCardRegistrarsTitle.AutoSize = true;
            lblCardRegistrarsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardRegistrarsTitle.ForeColor = Color.DimGray;
            lblCardRegistrarsTitle.Location = new Point(18, 14);
            lblCardRegistrarsTitle.Name = "lblCardRegistrarsTitle";
            lblCardRegistrarsTitle.Size = new Size(175, 23);
            lblCardRegistrarsTitle.TabIndex = 0;
            lblCardRegistrarsTitle.Text = "ACTIVE REGISTRARS";
            // 
            // lblCardRegistrarsValue
            // 
            lblCardRegistrarsValue.AutoSize = true;
            lblCardRegistrarsValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardRegistrarsValue.ForeColor = Color.FromArgb(22, 163, 74);
            lblCardRegistrarsValue.Location = new Point(16, 42);
            lblCardRegistrarsValue.Name = "lblCardRegistrarsValue";
            lblCardRegistrarsValue.Size = new Size(42, 50);
            lblCardRegistrarsValue.TabIndex = 1;
            lblCardRegistrarsValue.Text = "0";
            // 
            // pnlCardCashiers
            // 
            pnlCardCashiers.BackColor = Color.White;
            pnlCardCashiers.Controls.Add(lblCardCashiersValue);
            pnlCardCashiers.Controls.Add(lblCardCashiersTitle);
            pnlCardCashiers.Location = new Point(1188, 118);
            pnlCardCashiers.Name = "pnlCardCashiers";
            pnlCardCashiers.Size = new Size(368, 100);
            pnlCardCashiers.TabIndex = 5;
            // 
            // lblCardCashiersTitle
            // 
            lblCardCashiersTitle.AutoSize = true;
            lblCardCashiersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCashiersTitle.ForeColor = Color.DimGray;
            lblCardCashiersTitle.Location = new Point(18, 14);
            lblCardCashiersTitle.Name = "lblCardCashiersTitle";
            lblCardCashiersTitle.Size = new Size(155, 23);
            lblCardCashiersTitle.TabIndex = 0;
            lblCardCashiersTitle.Text = "ACTIVE CASHIERS";
            // 
            // lblCardCashiersValue
            // 
            lblCardCashiersValue.AutoSize = true;
            lblCardCashiersValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardCashiersValue.ForeColor = Color.FromArgb(13, 148, 136);
            lblCardCashiersValue.Location = new Point(16, 42);
            lblCardCashiersValue.Name = "lblCardCashiersValue";
            lblCardCashiersValue.Size = new Size(42, 50);
            lblCardCashiersValue.TabIndex = 1;
            lblCardCashiersValue.Text = "0";
            // 
            // pnlUserForm
            // 
            pnlUserForm.BackColor = Color.White;
            pnlUserForm.Controls.Add(btnClearUser);
            pnlUserForm.Controls.Add(btnDeactivateUser);
            pnlUserForm.Controls.Add(btnUpdateUser);
            pnlUserForm.Controls.Add(btnAddUser);
            pnlUserForm.Controls.Add(chkIsActive);
            pnlUserForm.Controls.Add(chkShowPassword);
            pnlUserForm.Controls.Add(txtConfirmPassword);
            pnlUserForm.Controls.Add(lblConfirmPassword);
            pnlUserForm.Controls.Add(txtPassword);
            pnlUserForm.Controls.Add(lblPassword);
            pnlUserForm.Controls.Add(cboRole);
            pnlUserForm.Controls.Add(lblRole);
            pnlUserForm.Controls.Add(txtUsername);
            pnlUserForm.Controls.Add(lblUsername);
            pnlUserForm.Controls.Add(lblUserFormHeader);
            pnlUserForm.Location = new Point(24, 238);
            pnlUserForm.Name = "pnlUserForm";
            pnlUserForm.Size = new Size(510, 818);
            pnlUserForm.TabIndex = 6;
            // 
            // lblUserFormHeader
            // 
            lblUserFormHeader.AutoSize = true;
            lblUserFormHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserFormHeader.Location = new Point(24, 20);
            lblUserFormHeader.Name = "lblUserFormHeader";
            lblUserFormHeader.Size = new Size(192, 37);
            lblUserFormHeader.TabIndex = 0;
            lblUserFormHeader.Text = "Account Details";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(24, 78);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(24, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "e.g., registrar.santos";
            txtUsername.Size = new Size(460, 33);
            txtUsername.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(24, 158);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(106, 25);
            lblRole.TabIndex = 3;
            lblRole.Text = "System Role";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Registrar", "Cashier", "Admin" });
            cboRole.Location = new Point(24, 186);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(460, 34);
            cboRole.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(24, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(272, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password (blank = keep on edit)";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(24, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(460, 33);
            txtPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(24, 320);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(154, 25);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(24, 348);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(460, 33);
            txtConfirmPassword.TabIndex = 8;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(24, 395);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(146, 27);
            chkShowPassword.TabIndex = 9;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsActive.ForeColor = Color.FromArgb(22, 101, 52);
            chkIsActive.Location = new Point(260, 394);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(156, 29);
            chkIsActive.TabIndex = 10;
            chkIsActive.Text = "Account Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(52, 118, 184);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(24, 452);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(222, 44);
            btnAddUser.TabIndex = 11;
            btnAddUser.Text = "Create Account";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(262, 452);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(222, 44);
            btnUpdateUser.TabIndex = 12;
            btnUpdateUser.Text = "Save Changes";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeactivateUser
            // 
            btnDeactivateUser.BackColor = Color.FromArgb(200, 60, 60);
            btnDeactivateUser.FlatAppearance.BorderSize = 0;
            btnDeactivateUser.FlatStyle = FlatStyle.Flat;
            btnDeactivateUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivateUser.ForeColor = Color.White;
            btnDeactivateUser.Location = new Point(24, 512);
            btnDeactivateUser.Name = "btnDeactivateUser";
            btnDeactivateUser.Size = new Size(222, 44);
            btnDeactivateUser.TabIndex = 13;
            btnDeactivateUser.Text = "Deactivate";
            btnDeactivateUser.UseVisualStyleBackColor = false;
            btnDeactivateUser.Click += btnDeactivateUser_Click;
            // 
            // btnClearUser
            // 
            btnClearUser.BackColor = Color.Gray;
            btnClearUser.FlatAppearance.BorderSize = 0;
            btnClearUser.FlatStyle = FlatStyle.Flat;
            btnClearUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearUser.ForeColor = Color.White;
            btnClearUser.Location = new Point(262, 512);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(222, 44);
            btnClearUser.TabIndex = 14;
            btnClearUser.Text = "Clear Form";
            btnClearUser.UseVisualStyleBackColor = false;
            btnClearUser.Click += btnClearUser_Click;
            // 
            // pnlUserList
            // 
            pnlUserList.BackColor = Color.White;
            pnlUserList.Controls.Add(dgvUsers);
            pnlUserList.Controls.Add(txtSearch);
            pnlUserList.Controls.Add(lblSearch);
            pnlUserList.Controls.Add(cboRoleFilter);
            pnlUserList.Controls.Add(lblRoleFilter);
            pnlUserList.Controls.Add(lblUserListHeader);
            pnlUserList.Location = new Point(554, 238);
            pnlUserList.Name = "pnlUserList";
            pnlUserList.Size = new Size(1002, 818);
            pnlUserList.TabIndex = 7;
            // 
            // lblUserListHeader
            // 
            lblUserListHeader.AutoSize = true;
            lblUserListHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserListHeader.Location = new Point(24, 20);
            lblUserListHeader.Name = "lblUserListHeader";
            lblUserListHeader.Size = new Size(176, 37);
            lblUserListHeader.TabIndex = 0;
            lblUserListHeader.Text = "Staff Accounts";
            // 
            // lblRoleFilter
            // 
            lblRoleFilter.AutoSize = true;
            lblRoleFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoleFilter.Location = new Point(470, 14);
            lblRoleFilter.Name = "lblRoleFilter";
            lblRoleFilter.Size = new Size(116, 23);
            lblRoleFilter.TabIndex = 1;
            lblRoleFilter.Text = "Filter by Role";
            // 
            // cboRoleFilter
            // 
            cboRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoleFilter.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoleFilter.FormattingEnabled = true;
            cboRoleFilter.Items.AddRange(new object[] { "All Roles", "Admin", "Registrar", "Cashier" });
            cboRoleFilter.Location = new Point(470, 40);
            cboRoleFilter.Name = "cboRoleFilter";
            cboRoleFilter.Size = new Size(190, 33);
            cboRoleFilter.TabIndex = 2;
            cboRoleFilter.SelectedIndexChanged += FilterChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(676, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(146, 23);
            lblSearch.TabIndex = 3;
            lblSearch.Text = "Search Username";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(676, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type username...";
            txtSearch.Size = new Size(302, 32);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += FilterChanged;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(24, 92);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(954, 702);
            dgvUsers.TabIndex = 5;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlUserList);
            Controls.Add(pnlUserForm);
            Controls.Add(pnlCardCashiers);
            Controls.Add(pnlCardRegistrars);
            Controls.Add(pnlCardAdmins);
            Controls.Add(pnlCardTotal);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsers";
            Text = "FrmUsers";
            Load += FrmUsers_Load;
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            pnlCardAdmins.ResumeLayout(false);
            pnlCardAdmins.PerformLayout();
            pnlCardRegistrars.ResumeLayout(false);
            pnlCardRegistrars.PerformLayout();
            pnlCardCashiers.ResumeLayout(false);
            pnlCardCashiers.PerformLayout();
            pnlUserForm.ResumeLayout(false);
            pnlUserForm.PerformLayout();
            pnlUserList.ResumeLayout(false);
            pnlUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlCardTotal;
        private Label lblCardTotalTitle;
        private Label lblCardTotalValue;
        private Panel pnlCardAdmins;
        private Label lblCardAdminsTitle;
        private Label lblCardAdminsValue;
        private Panel pnlCardRegistrars;
        private Label lblCardRegistrarsTitle;
        private Label lblCardRegistrarsValue;
        private Panel pnlCardCashiers;
        private Label lblCardCashiersTitle;
        private Label lblCardCashiersValue;
        private Panel pnlUserForm;
        private Label lblUserFormHeader;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblRole;
        private ComboBox cboRole;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkShowPassword;
        private CheckBox chkIsActive;
        private Button btnAddUser;
        private Button btnUpdateUser;
        private Button btnDeactivateUser;
        private Button btnClearUser;
        private Panel pnlUserList;
        private Label lblUserListHeader;
        private Label lblRoleFilter;
        private ComboBox cboRoleFilter;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvUsers;
    }
}