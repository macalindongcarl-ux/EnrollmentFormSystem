using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmPayment : Form
    {
        private readonly UserModel _currentUser;
        private readonly PaymentController _paymentController;

        private List<AssessedAccountModel> _assessedAccounts = new List<AssessedAccountModel>();
        private int _selectedAssessmentId = 0;
        private int _selectedPaymentId = 0;
        private decimal _currentRemainingBalance = 0m;
        private bool _isSelectingStudent = false;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmPayment(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _paymentController = new PaymentController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Process full or partial student payments and issue official receipts.";
            cboPaymentMethod.SelectedIndex = 0;
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            ConfigureRolePermissions();
            StyleDataGridView(dgvPayments);
            LoadAssessedAccountsLookup();
            LoadPayments();
        }

        private void ConfigureRolePermissions()
        {
            // Only Admin can void/soft-delete an already recorded payment
            btnVoidPayment.Visible = IsAdmin;
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

        private void LoadAssessedAccountsLookup()
        {
            _assessedAccounts = _paymentController.GetAssessedAccounts();
        }

        private void LoadPayments(string searchTerm = null)
        {
            List<PaymentModel> payments = _paymentController.GetAll(includeInactive: IsAdmin, searchTerm: searchTerm);
            dgvPayments.DataSource = null;
            dgvPayments.DataSource = payments;

            string[] hiddenColumns =
            {
        "PaymentID",
        "AssessmentID",
        "ReceiptNumber",
        "ReferenceNumber",
        "PaymentDate",
        "ProcessedByUserID",
        "IsActive",
        "DateCreated"
    };

            foreach (string colName in hiddenColumns)
            {
                if (dgvPayments.Columns[colName] != null)
                    dgvPayments.Columns[colName].Visible = false;
            }

            if (dgvPayments.Columns["StudentNumber"] != null)
            {
                dgvPayments.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvPayments.Columns["StudentNumber"].DisplayIndex = 0;
                dgvPayments.Columns["StudentNumber"].FillWeight = 13;
            }
            if (dgvPayments.Columns["StudentName"] != null)
            {
                dgvPayments.Columns["StudentName"].HeaderText = "Student Name";
                dgvPayments.Columns["StudentName"].DisplayIndex = 1;
                dgvPayments.Columns["StudentName"].FillWeight = 23;
            }
            if (dgvPayments.Columns["GradeLevelName"] != null)
            {
                dgvPayments.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvPayments.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvPayments.Columns["GradeLevelName"].FillWeight = 11;
            }
            if (dgvPayments.Columns["SectionName"] != null)
            {
                dgvPayments.Columns["SectionName"].HeaderText = "Section";
                dgvPayments.Columns["SectionName"].DisplayIndex = 3;
                dgvPayments.Columns["SectionName"].FillWeight = 12;
            }
            if (dgvPayments.Columns["SchoolYear"] != null)
            {
                dgvPayments.Columns["SchoolYear"].HeaderText = "School Year";
                dgvPayments.Columns["SchoolYear"].DisplayIndex = 4;
                dgvPayments.Columns["SchoolYear"].FillWeight = 11;
            }
            if (dgvPayments.Columns["AmountPaid"] != null)
            {
                dgvPayments.Columns["AmountPaid"].HeaderText = "Amount Paid";
                dgvPayments.Columns["AmountPaid"].DisplayIndex = 5;
                dgvPayments.Columns["AmountPaid"].DefaultCellStyle.Format = "N2";
                dgvPayments.Columns["AmountPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPayments.Columns["AmountPaid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvPayments.Columns["AmountPaid"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvPayments.Columns["AmountPaid"].FillWeight = 11;
            }
            if (dgvPayments.Columns["PaymentMethod"] != null)
            {
                dgvPayments.Columns["PaymentMethod"].HeaderText = "Method";
                dgvPayments.Columns["PaymentMethod"].DisplayIndex = 6;
                dgvPayments.Columns["PaymentMethod"].FillWeight = 10;
            }
            if (dgvPayments.Columns["ProcessedBy"] != null)
            {
                dgvPayments.Columns["ProcessedBy"].HeaderText = "Cashier";
                dgvPayments.Columns["ProcessedBy"].DisplayIndex = 7;
                dgvPayments.Columns["ProcessedBy"].FillWeight = 9;
            }

            HighlightInactiveRows(dgvPayments);
        }

        private void HighlightInactiveRows(DataGridView grid)
        {
            if (!IsAdmin || grid.Columns["IsActive"] == null)
                return;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["IsActive"].Value is bool isActive && !isActive)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(148, 163, 184);
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
                }
            }
        }

        // --- Assessed Student Lookup Events ---

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isSelectingStudent) return;

            ResetSelectedAccountFields();

            string query = txtStudentSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                lstStudentSuggestions.Visible = false;
                return;
            }

            var exactMatch = _assessedAccounts.FirstOrDefault(a =>
                query.Equals(a.StudentNumber, StringComparison.OrdinalIgnoreCase) ||
                query.Equals(a.DisplayText, StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
            {
                ApplySelectedAccount(exactMatch, hideList: false);
            }

            var matches = _assessedAccounts
                .Where(a =>
                    a.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.StudentName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.GradeLevelName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    a.SectionName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .Take(8)
                .ToList();

            if (matches.Count > 0)
            {
                lstStudentSuggestions.DataSource = matches;
                lstStudentSuggestions.DisplayMember = "DisplayText";
                lstStudentSuggestions.ValueMember = "AssessmentID";
                lstStudentSuggestions.Visible = true;
                lstStudentSuggestions.BringToFront();
            }
            else
            {
                lstStudentSuggestions.Visible = false;
            }
        }

        private void txtStudentSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!lstStudentSuggestions.Visible) return;

            if (e.KeyCode == Keys.Down)
            {
                lstStudentSuggestions.Focus();
                if (lstStudentSuggestions.Items.Count > 0)
                    lstStudentSuggestions.SelectedIndex = 0;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstStudentSuggestions.Visible = false;
                e.Handled = true;
            }
        }

        private void lstStudentSuggestions_Click(object sender, EventArgs e)
        {
            if (lstStudentSuggestions.SelectedItem is AssessedAccountModel selected)
            {
                ApplySelectedAccount(selected, hideList: true);
            }
        }

        private void lstStudentSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lstStudentSuggestions.SelectedItem is AssessedAccountModel selected)
            {
                ApplySelectedAccount(selected, hideList: true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstStudentSuggestions.Visible = false;
                txtStudentSearch.Focus();
                e.Handled = true;
            }
        }

        private void txtStudentSearch_Leave(object sender, EventArgs e)
        {
            if (!lstStudentSuggestions.Focused)
            {
                lstStudentSuggestions.Visible = false;
            }
        }

        private void ApplySelectedAccount(AssessedAccountModel account, bool hideList)
        {
            _isSelectingStudent = true;
            _selectedAssessmentId = account.AssessmentID;
            _currentRemainingBalance = account.RemainingBalance;

            if (hideList)
            {
                txtStudentSearch.Text = $"{account.StudentNumber} - {account.StudentName}";
                lstStudentSuggestions.Visible = false;
            }

            txtGradeSection.Text = $"{account.GradeLevelName} - {account.SectionName}";
            txtSchoolYear.Text = account.SchoolYear;
            txtPaymentStatus.Text = account.PaymentStatus.ToUpperInvariant();
            txtTotalAssessed.Text = account.TotalAssessed.ToString("N2");
            txtTotalPaid.Text = account.TotalPaid.ToString("N2");
            txtRemainingBalance.Text = account.RemainingBalance.ToString("N2");

            UpdateNewBalancePreview();
            _isSelectingStudent = false;
        }

        private void ResetSelectedAccountFields()
        {
            _selectedAssessmentId = 0;
            _currentRemainingBalance = 0m;
            txtGradeSection.Clear();
            txtSchoolYear.Clear();
            txtPaymentStatus.Clear();
            txtTotalAssessed.Text = "0.00";
            txtTotalPaid.Text = "0.00";
            txtRemainingBalance.Text = "0.00";
            txtNewBalance.Text = "0.00";
        }

        // --- Payment Calculation & Method Events ---

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            UpdateNewBalancePreview();
        }

        private void UpdateNewBalancePreview()
        {
            decimal amountPaid = decimal.TryParse(txtAmountPaid.Text, out decimal parsed) ? parsed : 0m;
            decimal newBalance = _currentRemainingBalance - amountPaid;
            txtNewBalance.Text = newBalance.ToString("N2");
            txtNewBalance.ForeColor = newBalance < 0
                ? Color.FromArgb(185, 28, 28)
                : Color.FromArgb(30, 58, 138);
        }

        private void btnPayFull_Click(object sender, EventArgs e)
        {
            if (_selectedAssessmentId <= 0)
            {
                MessageBox.Show("Please select an assessed student first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtAmountPaid.Text = _currentRemainingBalance.ToString("0.00");
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string method = cboPaymentMethod.SelectedItem?.ToString() ?? "Cash";
            bool isNonCash = !method.Equals("Cash", StringComparison.OrdinalIgnoreCase);
            txtReferenceNumber.Enabled = isNonCash;
            if (!isNonCash)
            {
                txtReferenceNumber.Clear();
            }
        }

        // --- CRUD Events ---

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmountPaid.Text, out decimal amountPaid))
            {
                MessageBox.Show("Please enter a valid numeric payment amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentModel payment = new PaymentModel
            {
                AssessmentID = _selectedAssessmentId,
                AmountPaid = amountPaid,
                PaymentMethod = cboPaymentMethod.SelectedItem?.ToString() ?? "Cash",
                ReferenceNumber = txtReferenceNumber.Text,
                PaymentDate = dtpPaymentDate.Value.Date,
                ProcessedByUserID = _currentUser.UserID
            };

            if (_paymentController.ProcessPayment(payment, _currentRemainingBalance, out string receiptNumber, out string errorMsg))
            {
                MessageBox.Show(
                    $"Payment recorded successfully!\n\nOfficial Receipt Number: {receiptNumber}\nAmount Paid: ₱{amountPaid:N2}",
                    "Payment Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearInputs();
                LoadAssessedAccountsLookup();
                LoadPayments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVoidPayment_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (_selectedPaymentId <= 0)
            {
                MessageBox.Show("Please select a payment record from the table to void.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to void this payment? The amount will be restored to the student's remaining balance.",
                "Confirm Void Payment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_paymentController.VoidPayment(_selectedPaymentId, out string errorMsg))
            {
                MessageBox.Show("Payment has been voided.", "Voided", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAssessedAccountsLookup();
                LoadPayments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Void Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearPayment_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text);
        }

        private void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPayments.Rows[e.RowIndex];
            _selectedPaymentId = Convert.ToInt32(row.Cells["PaymentID"].Value);

            if (row.DataBoundItem is PaymentModel payment)
            {
                ShowPaymentDetailsDialog(payment);
            }
        }

        private void ShowPaymentDetailsDialog(PaymentModel payment)
        {
            string referenceText = string.IsNullOrWhiteSpace(payment.ReferenceNumber)
                ? "N/A (Cash)"
                : payment.ReferenceNumber;

            string statusText = payment.IsActive ? "ACTIVE" : "VOIDED";

            string details =
                $"Official Receipt #:   {payment.ReceiptNumber}\n" +
                $"Status:                        {statusText}\n" +
                $"--------------------------------------------------\n" +
                $"Student Number:      {payment.StudentNumber}\n" +
                $"Student Name:          {payment.StudentName}\n" +
                $"Grade & Section:       {payment.GradeLevelName} - {payment.SectionName}\n" +
                $"School Year:              {payment.SchoolYear}\n" +
                $"--------------------------------------------------\n" +
                $"Amount Paid:             ₱{payment.AmountPaid:N2}\n" +
                $"Payment Method:     {payment.PaymentMethod}\n" +
                $"Reference #:              {referenceText}\n" +
                $"Payment Date:          {payment.PaymentDate:MMMM dd, yyyy}\n" +
                $"Processed By:            {payment.ProcessedBy}\n" +
                $"Date Recorded:         {payment.DateCreated:MM/dd/yyyy hh:mm tt}";

            MessageBox.Show(
                details,
                $"Payment Details — {payment.ReceiptNumber}",
                MessageBoxButtons.OK,
                payment.IsActive ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void ClearInputs()
        {
            _selectedPaymentId = 0;

            _isSelectingStudent = true;
            txtStudentSearch.Clear();
            lstStudentSuggestions.Visible = false;
            ResetSelectedAccountFields();
            _isSelectingStudent = false;

            txtAmountPaid.Text = "0.00";
            cboPaymentMethod.SelectedIndex = 0;
            txtReferenceNumber.Clear();
            dtpPaymentDate.Value = DateTime.Today;
            dgvPayments.ClearSelection();
        }
    }
}