using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmAccountSearch : Form
    {
        private readonly UserModel _currentUser; 
        private readonly PaymentController _paymentController;
        private List<AssessedAccountModel> _allAccounts = new List<AssessedAccountModel>();
        private bool _isInitializing = true;

        public FrmAccountSearch(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _paymentController = new PaymentController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Look up student billing statements, payments made, and remaining balances.";
            cboStatusFilter.SelectedIndex = 0;
            _isInitializing = false;
        }

        private void FrmAccountSearch_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvAccounts);
            LoadAccounts();
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

            // Header styling
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 42;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);

            // Row styling
            grid.RowTemplate.Height = 38;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            // Alternating row color
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
        }

        private void LoadAccounts()
        {
            _allAccounts = _paymentController.GetAssessedAccounts();
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string selectedStatus = cboStatusFilter.SelectedItem?.ToString() ?? "All";
            string query = txtSearch.Text.Trim();

            IEnumerable<AssessedAccountModel> filtered = _allAccounts;

            if (!selectedStatus.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(a =>
                    a.PaymentStatus.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(query))
            {
                filtered = filtered.Where(a =>
                    a.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.StudentName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.GradeLevelName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.SectionName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.SchoolYear.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            List<AssessedAccountModel> resultList = filtered.ToList();
            BindGrid(resultList);
            UpdateSummaryCards(resultList);
        }

        private void BindGrid(List<AssessedAccountModel> accounts)
        {
            dgvAccounts.DataSource = null;
            dgvAccounts.DataSource = accounts;

            string[] hiddenColumns =
            {
                "AssessmentID",
                "EnrollmentID",
                "StudentID",
                "TuitionFee",
                "MiscellaneousFee",
                "OtherFees",
                "DiscountAmount",
                "PaymentStatus",
                "DisplayText"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvAccounts.Columns[colName] != null)
                    dgvAccounts.Columns[colName].Visible = false;
            }

            if (dgvAccounts.Columns["StudentNumber"] != null)
            {
                dgvAccounts.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvAccounts.Columns["StudentNumber"].DisplayIndex = 0;
                dgvAccounts.Columns["StudentNumber"].FillWeight = 13;
            }
            if (dgvAccounts.Columns["StudentName"] != null)
            {
                dgvAccounts.Columns["StudentName"].HeaderText = "Student Name";
                dgvAccounts.Columns["StudentName"].DisplayIndex = 1;
                dgvAccounts.Columns["StudentName"].FillWeight = 23;
            }
            if (dgvAccounts.Columns["GradeLevelName"] != null)
            {
                dgvAccounts.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvAccounts.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvAccounts.Columns["GradeLevelName"].FillWeight = 11;
            }
            if (dgvAccounts.Columns["SectionName"] != null)
            {
                dgvAccounts.Columns["SectionName"].HeaderText = "Section";
                dgvAccounts.Columns["SectionName"].DisplayIndex = 3;
                dgvAccounts.Columns["SectionName"].FillWeight = 12;
            }
            if (dgvAccounts.Columns["SchoolYear"] != null)
            {
                dgvAccounts.Columns["SchoolYear"].HeaderText = "School Year";
                dgvAccounts.Columns["SchoolYear"].DisplayIndex = 4;
                dgvAccounts.Columns["SchoolYear"].FillWeight = 10;
            }
            if (dgvAccounts.Columns["TotalAssessed"] != null)
            {
                dgvAccounts.Columns["TotalAssessed"].HeaderText = "Total Assessed";
                dgvAccounts.Columns["TotalAssessed"].DisplayIndex = 5;
                dgvAccounts.Columns["TotalAssessed"].DefaultCellStyle.Format = "N2";
                dgvAccounts.Columns["TotalAssessed"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["TotalAssessed"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["TotalAssessed"].FillWeight = 10;
            }
            if (dgvAccounts.Columns["TotalPaid"] != null)
            {
                dgvAccounts.Columns["TotalPaid"].HeaderText = "Total Paid";
                dgvAccounts.Columns["TotalPaid"].DisplayIndex = 6;
                dgvAccounts.Columns["TotalPaid"].DefaultCellStyle.Format = "N2";
                dgvAccounts.Columns["TotalPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["TotalPaid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["TotalPaid"].DefaultCellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                dgvAccounts.Columns["TotalPaid"].FillWeight = 10;
            }
            if (dgvAccounts.Columns["RemainingBalance"] != null)
            {
                dgvAccounts.Columns["RemainingBalance"].HeaderText = "Remaining Balance";
                dgvAccounts.Columns["RemainingBalance"].DisplayIndex = 7;
                dgvAccounts.Columns["RemainingBalance"].DefaultCellStyle.Format = "N2";
                dgvAccounts.Columns["RemainingBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["RemainingBalance"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvAccounts.Columns["RemainingBalance"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvAccounts.Columns["RemainingBalance"].FillWeight = 11;
            }

            StyleBalanceCells();
        }

        private void StyleBalanceCells()
        {
            if (dgvAccounts.Columns["RemainingBalance"] == null) return;

            foreach (DataGridViewRow row in dgvAccounts.Rows)
            {
                if (row.DataBoundItem is AssessedAccountModel account)
                {
                    if (account.RemainingBalance <= 0)
                    {
                        row.Cells["RemainingBalance"].Style.ForeColor = Color.FromArgb(22, 101, 52);
                    }
                    else if (account.TotalPaid > 0)
                    {
                        row.Cells["RemainingBalance"].Style.ForeColor = Color.FromArgb(180, 83, 9);
                    }
                    else
                    {
                        row.Cells["RemainingBalance"].Style.ForeColor = Color.FromArgb(185, 28, 28);
                    }
                }
            }
        }

        private void UpdateSummaryCards(List<AssessedAccountModel> accounts)
        {
            decimal totalAssessed = accounts.Sum(a => a.TotalAssessed);
            decimal totalCollected = accounts.Sum(a => a.TotalPaid);
            decimal totalBalance = accounts.Sum(a => a.RemainingBalance);

            lblCardAssessedValue.Text = $"₱{totalAssessed:N2}";
            lblCardCollectedValue.Text = $"₱{totalCollected:N2}";
            lblCardBalanceValue.Text = $"₱{totalBalance:N2}";
            lblCardAccountsValue.Text = accounts.Count.ToString();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            ApplyFilters();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            _isInitializing = true;
            cboStatusFilter.SelectedIndex = 0;
            txtSearch.Clear();
            _isInitializing = false;
            ApplyFilters();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvAccounts.Rows[e.RowIndex].DataBoundItem is AssessedAccountModel account)
            {
                ShowAccountStatementDialog(account);
            }
        }

        private void ShowAccountStatementDialog(AssessedAccountModel account)
        {
            decimal grossFees = account.TuitionFee + account.MiscellaneousFee + account.OtherFees;

            string statement =
                $"Student Number:          {account.StudentNumber}\n" +
                $"Student Name:              {account.StudentName}\n" +
                $"Grade & Section:           {account.GradeLevelName} - {account.SectionName}\n" +
                $"School Year:                  {account.SchoolYear}\n" +
                $"Account Status:            {account.PaymentStatus.ToUpperInvariant()}\n" +
                $"------------------------------------------------------\n" +
                $"Tuition Fee:                    ₱{account.TuitionFee:N2}\n" +
                $"Miscellaneous Fee:        ₱{account.MiscellaneousFee:N2}\n" +
                $"Other Fees:                     ₱{account.OtherFees:N2}\n" +
                $"Gross Total:                    ₱{grossFees:N2}\n" +
                $"Less Discount:               -₱{account.DiscountAmount:N2}\n" +
                $"Net Total Assessed:      ₱{account.TotalAssessed:N2}\n" +
                $"------------------------------------------------------\n" +
                $"Total Payments Made:   ₱{account.TotalPaid:N2}\n" +
                $"Remaining Balance:      ₱{account.RemainingBalance:N2}";

            MessageBox.Show(
                statement,
                $"Student Account Statement — {account.StudentNumber}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}