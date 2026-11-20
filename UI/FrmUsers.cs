using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmUsers : Form
    {
        private readonly UserModel _currentUser;
        private readonly UserController _userController;

        private List<UserModel> _allUsers = new List<UserModel>();
        private int _selectedUserId = 0;
        private bool _isInitializing = true;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmUsers(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _userController = new UserController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Create and manage Admin, Registrar, and Cashier staff accounts.";
            cboRole.SelectedIndex = 0;
            cboRoleFilter.SelectedIndex = 0;
            _isInitializing = false;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                MessageBox.Show("Access Denied. Only Administrators can manage system user accounts.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            ApplyModernCardStyling();
            StyleDataGridView(dgvUsers);
            LoadUsers();
        }

        private void ApplyModernCardStyling()
        {
            StyleAccentCard(pnlCardTotal, Color.FromArgb(30, 58, 138));
            StyleAccentCard(pnlCardAdmins, Color.FromArgb(79, 70, 229));
            StyleAccentCard(pnlCardRegistrars, Color.FromArgb(22, 163, 74));
            StyleAccentCard(pnlCardCashiers, Color.FromArgb(13, 148, 136));

            StyleContainerPanel(pnlUserForm);
            StyleContainerPanel(pnlUserList);
        }

        private void StyleAccentCard(Panel card, Color accentColor)
        {
            card.BorderStyle = BorderStyle.None;
            card.BackColor = Color.White;
            card.Paint += (s, e) =>
            {
                using SolidBrush accentBrush = new SolidBrush(accentColor);
                using Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1f);
                e.Graphics.FillRectangle(accentBrush, 0, 0, card.Width, 4);
                e.Graphics.DrawRectangle(borderPen, 0, 0, card.Width - 1, card.Height - 1);
            };
        }

        private void StyleContainerPanel(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.White;
            panel.Paint += (s, e) =>
            {
                using Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1f);
                e.Graphics.DrawRectangle(borderPen, 0, 0, panel.Width - 1, panel.Height - 1);
            };
        }

        private void StyleDataGridView(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(230, 234, 240);
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);

            grid.RowTemplate.Height = 40;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        private void LoadUsers()
        {
            _allUsers = _userController.GetAll(includeInactive: true);
            UpdateSummaryCards(_allUsers);
            ApplyFilters();
        }

        private void UpdateSummaryCards(List<UserModel> users)
        {
            lblCardTotalValue.Text = users.Count.ToString();
            lblCardAdminsValue.Text = users.Count(u => u.IsActive && u.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase)).ToString();
            lblCardRegistrarsValue.Text = users.Count(u => u.IsActive && u.Role.Equals("Registrar", StringComparison.OrdinalIgnoreCase)).ToString();
            lblCardCashiersValue.Text = users.Count(u => u.IsActive && u.Role.Equals("Cashier", StringComparison.OrdinalIgnoreCase)).ToString();
        }

        private void ApplyFilters()
        {
            string selectedRole = cboRoleFilter.SelectedItem?.ToString() ?? "All Roles";
            string query = txtSearch.Text.Trim();

            IEnumerable<UserModel> filtered = _allUsers;

            if (!selectedRole.Equals("All Roles", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(u => u.Role.Equals(selectedRole, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(query))
            {
                filtered = filtered.Where(u => u.Username.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            BindGrid(filtered.ToList());
        }

        private void BindGrid(List<UserModel> users)
        {
            var rows = users.Select(u => new
            {
                u.UserID,
                u.Username,
                Password = u.Password,
                Role = u.Role,
                Status = u.IsActive ? "Active" : "Inactive",
                DateCreated = u.DateCreated.ToString("MMM dd, yyyy"),
                IsActive = u.IsActive
            }).ToList();

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = rows;

            if (dgvUsers.Columns["UserID"] != null)
                dgvUsers.Columns["UserID"].Visible = false;

            if (dgvUsers.Columns["IsActive"] != null)
                dgvUsers.Columns["IsActive"].Visible = false;

            if (dgvUsers.Columns["Username"] != null)
            {
                dgvUsers.Columns["Username"].HeaderText = "Username";
                dgvUsers.Columns["Username"].DisplayIndex = 0;
                dgvUsers.Columns["Username"].FillWeight = 110;
                dgvUsers.Columns["Username"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            }

            if (dgvUsers.Columns["Password"] != null)
            {
                dgvUsers.Columns["Password"].HeaderText = "Password";
                dgvUsers.Columns["Password"].DisplayIndex = 1;
                dgvUsers.Columns["Password"].FillWeight = 110;
            }

            if (dgvUsers.Columns["Role"] != null)
            {
                dgvUsers.Columns["Role"].HeaderText = "Role";
                dgvUsers.Columns["Role"].DisplayIndex = 2;
                dgvUsers.Columns["Role"].FillWeight = 85;
            }

            if (dgvUsers.Columns["Status"] != null)
            {
                dgvUsers.Columns["Status"].HeaderText = "Status";
                dgvUsers.Columns["Status"].DisplayIndex = 3;
                dgvUsers.Columns["Status"].FillWeight = 75;
                dgvUsers.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }

            if (dgvUsers.Columns["DateCreated"] != null)
            {
                dgvUsers.Columns["DateCreated"].HeaderText = "Created On";
                dgvUsers.Columns["DateCreated"].DisplayIndex = 4;
                dgvUsers.Columns["DateCreated"].FillWeight = 100;
            }

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                bool isActive = row.Cells["IsActive"]?.Value is bool active && active;
                if (row.Cells["Status"] != null)
                {
                    row.Cells["Status"].Style.ForeColor = isActive
                        ? Color.FromArgb(22, 163, 74)
                        : Color.FromArgb(148, 163, 184);
                }

                if (!isActive)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
                }
            }

            dgvUsers.ClearSelection();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string role = cboRole.SelectedItem?.ToString() ?? "Registrar";

            if (_userController.Add(username, password, confirm, role, out string errorMsg))
            {
                MessageBox.Show($"User account '{username.Trim()}' created successfully.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadUsers();
            }
            else
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string role = cboRole.SelectedItem?.ToString() ?? "Registrar";
            bool isActive = chkIsActive.Checked;

            if (_userController.Update(_selectedUserId, _currentUser.UserID, username, newPassword, confirm, role, isActive, out string errorMsg))
            {
                MessageBox.Show("User account updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadUsers();
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                MessageBox.Show("Please select a user account from the table to deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to deactivate '{txtUsername.Text}'? They will no longer be able to log in.",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_userController.Deactivate(_selectedUserId, _currentUser.UserID, out string errorMsg))
            {
                MessageBox.Show("User account deactivated.", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadUsers();
            }
            else
            {
                MessageBox.Show(errorMsg, "Action Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            char mask = chkShowPassword.Checked ? '\0' : '●';
            txtPassword.PasswordChar = mask;
            txtConfirmPassword.PasswordChar = mask;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            ApplyFilters();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvUsers.Rows.Count) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            _selectedUserId = row.Cells["UserID"]?.Value != null ? Convert.ToInt32(row.Cells["UserID"].Value) : 0;
            txtUsername.Text = row.Cells["Username"]?.Value?.ToString() ?? string.Empty;
            cboRole.SelectedItem = row.Cells["Role"]?.Value?.ToString() ?? "Registrar";
            chkIsActive.Checked = row.Cells["IsActive"]?.Value is bool active && active;

            string existingPassword = row.Cells["Password"]?.Value?.ToString() ?? string.Empty;
            txtPassword.Text = existingPassword;
            txtConfirmPassword.Text = existingPassword;
        }

        private void ClearInputs()
        {
            _selectedUserId = 0;
            txtUsername.Clear();
            cboRole.SelectedIndex = 0;
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkShowPassword.Checked = false;
            chkIsActive.Checked = true;
            dgvUsers.ClearSelection();
        }
    }
}