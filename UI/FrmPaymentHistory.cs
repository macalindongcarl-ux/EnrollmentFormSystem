using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmPaymentHistory : Form
    {
        private readonly UserModel _currentUser;
        private readonly PaymentController _paymentController;

        private List<PaymentModel> _allPayments = new List<PaymentModel>();
        private PaymentModel _selectedPayment;
        private bool _isInitializing = true;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmPaymentHistory(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _paymentController = new PaymentController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Review payment transactions, filter collections, and print official receipts.";
            cboMethodFilter.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            _isInitializing = false;
        }

        private void FrmPaymentHistory_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvHistory);
            LoadPaymentHistory();
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

        private void LoadPaymentHistory()
        {
            _allPayments = _paymentController.GetAll(includeInactive: IsAdmin);
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string selectedMethod = cboMethodFilter.SelectedItem?.ToString() ?? "All";
            string query = txtSearch.Text.Trim();

            IEnumerable<PaymentModel> filtered = _allPayments;

            if (chkFilterByDate.Checked)
            {
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date;
                filtered = filtered.Where(p => p.PaymentDate.Date >= fromDate && p.PaymentDate.Date <= toDate);
            }

            if (!selectedMethod.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(p =>
                    p.PaymentMethod.Equals(selectedMethod, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(query))
            {
                filtered = filtered.Where(p =>
                    p.ReceiptNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.StudentName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.GradeLevelName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.SectionName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            List<PaymentModel> resultList = filtered.ToList();
            _selectedPayment = resultList.FirstOrDefault();
            BindGrid(resultList);
            UpdateSummaryCards(resultList);
        }

        private void BindGrid(List<PaymentModel> payments)
        {
            dgvHistory.DataSource = null;
            dgvHistory.DataSource = payments;

            string[] hiddenColumns =
            {
                "PaymentID",
                "AssessmentID",
                "SchoolYear",
                "ReferenceNumber",
                "ProcessedByUserID",
                "IsActive",
                "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvHistory.Columns[colName] != null)
                    dgvHistory.Columns[colName].Visible = false;
            }

            if (dgvHistory.Columns["ReceiptNumber"] != null)
            {
                dgvHistory.Columns["ReceiptNumber"].HeaderText = "OR Number";
                dgvHistory.Columns["ReceiptNumber"].DisplayIndex = 0;
                dgvHistory.Columns["ReceiptNumber"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvHistory.Columns["ReceiptNumber"].FillWeight = 13;
            }
            if (dgvHistory.Columns["StudentNumber"] != null)
            {
                dgvHistory.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvHistory.Columns["StudentNumber"].DisplayIndex = 1;
                dgvHistory.Columns["StudentNumber"].FillWeight = 13;
            }
            if (dgvHistory.Columns["StudentName"] != null)
            {
                dgvHistory.Columns["StudentName"].HeaderText = "Student Name";
                dgvHistory.Columns["StudentName"].DisplayIndex = 2;
                dgvHistory.Columns["StudentName"].FillWeight = 22;
            }
            if (dgvHistory.Columns["GradeLevelName"] != null)
            {
                dgvHistory.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvHistory.Columns["GradeLevelName"].DisplayIndex = 3;
                dgvHistory.Columns["GradeLevelName"].FillWeight = 10;
            }
            if (dgvHistory.Columns["SectionName"] != null)
            {
                dgvHistory.Columns["SectionName"].HeaderText = "Section";
                dgvHistory.Columns["SectionName"].DisplayIndex = 4;
                dgvHistory.Columns["SectionName"].FillWeight = 11;
            }
            if (dgvHistory.Columns["AmountPaid"] != null)
            {
                dgvHistory.Columns["AmountPaid"].HeaderText = "Amount Paid";
                dgvHistory.Columns["AmountPaid"].DisplayIndex = 5;
                dgvHistory.Columns["AmountPaid"].DefaultCellStyle.Format = "N2";
                dgvHistory.Columns["AmountPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvHistory.Columns["AmountPaid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvHistory.Columns["AmountPaid"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvHistory.Columns["AmountPaid"].FillWeight = 11;
            }
            if (dgvHistory.Columns["PaymentMethod"] != null)
            {
                dgvHistory.Columns["PaymentMethod"].HeaderText = "Method";
                dgvHistory.Columns["PaymentMethod"].DisplayIndex = 6;
                dgvHistory.Columns["PaymentMethod"].FillWeight = 10;
            }
            if (dgvHistory.Columns["PaymentDate"] != null)
            {
                dgvHistory.Columns["PaymentDate"].HeaderText = "Payment Date";
                dgvHistory.Columns["PaymentDate"].DisplayIndex = 7;
                dgvHistory.Columns["PaymentDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvHistory.Columns["PaymentDate"].FillWeight = 10;
            }
            if (dgvHistory.Columns["ProcessedBy"] != null)
            {
                dgvHistory.Columns["ProcessedBy"].HeaderText = "Cashier";
                dgvHistory.Columns["ProcessedBy"].DisplayIndex = 8;
                dgvHistory.Columns["ProcessedBy"].FillWeight = 10;
            }

            HighlightInactiveRows(dgvHistory);
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

        private void UpdateSummaryCards(List<PaymentModel> payments)
        {
            var activePayments = payments.Where(p => p.IsActive).ToList();

            decimal totalCollected = activePayments.Sum(p => p.AmountPaid);
            decimal cashTotal = activePayments
                .Where(p => p.PaymentMethod.Equals("Cash", StringComparison.OrdinalIgnoreCase))
                .Sum(p => p.AmountPaid);
            decimal nonCashTotal = totalCollected - cashTotal;

            lblCardTotalValue.Text = $"₱{totalCollected:N2}";
            lblCardCountValue.Text = activePayments.Count.ToString();
            lblCardCashValue.Text = $"₱{cashTotal:N2}";
            lblCardNonCashValue.Text = $"₱{nonCashTotal:N2}";
        }

        // --- Filter Events ---

        private void chkFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = chkFilterByDate.Checked;
            dtpTo.Enabled = chkFilterByDate.Checked;
            if (!_isInitializing) ApplyFilters();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            ApplyFilters();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            _isInitializing = true;
            chkFilterByDate.Checked = false;
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            cboMethodFilter.SelectedIndex = 0;
            txtSearch.Clear();
            _isInitializing = false;
            ApplyFilters();
        }

        // --- Grid Selection & Receipt Printing ---

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvHistory.Rows[e.RowIndex].DataBoundItem is PaymentModel payment)
            {
                _selectedPayment = payment;
            }
        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvHistory.Rows[e.RowIndex].DataBoundItem is PaymentModel payment)
            {
                _selectedPayment = payment;
                OpenReceiptPrintPreview(payment);
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (_selectedPayment == null)
            {
                MessageBox.Show("Please select a payment record from the table to preview or print its receipt.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenReceiptPrintPreview(_selectedPayment);
        }

        private void OpenReceiptPrintPreview(PaymentModel payment)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = $"Receipt_{payment.ReceiptNumber}";
            printDoc.PrintPage += (s, ev) => DrawOfficialReceipt(ev.Graphics, payment);

            using PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent
            };

            previewDialog.ShowDialog(this);
        }

        private void DrawOfficialReceipt(Graphics g, PaymentModel payment)
        {
            using Font titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
            using Font subTitleFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using Font labelFont = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            using Font valueFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            using Font amountFont = new Font("Segoe UI", 14, FontStyle.Bold);
            using Pen borderPen = new Pen(Color.FromArgb(30, 41, 59), 1.5f);
            using Pen linePen = new Pen(Color.LightGray, 1f);

            int left = 70;
            int right = 730;
            int y = 70;

            g.DrawRectangle(borderPen, left - 20, y - 20, (right - left) + 40, 520);

            g.DrawString("SCHOOL ENROLLMENT & CASHIERING SYSTEM", titleFont, Brushes.Black, left, y);
            y += 34;
            g.DrawString("OFFICIAL PAYMENT RECEIPT", subTitleFont, Brushes.DimGray, left, y);

            if (!payment.IsActive)
            {
                g.DrawString("[ VOIDED RECEIPT ]", subTitleFont, Brushes.Red, right - 180, y);
            }

            y += 38;
            g.DrawLine(borderPen, left, y, right, y);
            y += 18;

            DrawReceiptRow(g, "Official Receipt #:", payment.ReceiptNumber, left, y, labelFont, labelFont);
            y += 30;
            DrawReceiptRow(g, "Payment Date:", payment.PaymentDate.ToString("MMMM dd, yyyy"), left, y, labelFont, valueFont);
            y += 30;
            DrawReceiptRow(g, "Student Number:", payment.StudentNumber, left, y, labelFont, valueFont);
            y += 30;
            DrawReceiptRow(g, "Student Name:", payment.StudentName, left, y, labelFont, valueFont);
            y += 30;
            DrawReceiptRow(g, "Grade & Section:", $"{payment.GradeLevelName} - {payment.SectionName}", left, y, labelFont, valueFont);
            y += 30;
            DrawReceiptRow(g, "School Year:", payment.SchoolYear, left, y, labelFont, valueFont);
            y += 36;

            g.DrawLine(linePen, left, y, right, y);
            y += 18;

            DrawReceiptRow(g, "Payment Method:", payment.PaymentMethod, left, y, labelFont, valueFont);
            y += 30;
            string refNo = string.IsNullOrWhiteSpace(payment.ReferenceNumber) ? "N/A (Cash)" : payment.ReferenceNumber;
            DrawReceiptRow(g, "Reference Number:", refNo, left, y, labelFont, valueFont);
            y += 36;

            g.DrawLine(borderPen, left, y, right, y);
            y += 18;

            g.DrawString("AMOUNT PAID:", amountFont, Brushes.Black, left, y);
            g.DrawString($"₱{payment.AmountPaid:N2}", amountFont, Brushes.DarkGreen, left + 220, y);
            y += 48;

            g.DrawLine(linePen, left, y, right, y);
            y += 18;

            DrawReceiptRow(g, "Processed By:", payment.ProcessedBy, left, y, labelFont, valueFont);
            y += 28;
            DrawReceiptRow(g, "Timestamp:", payment.DateCreated.ToString("MM/dd/yyyy hh:mm tt"), left, y, labelFont, valueFont);
        }

        private void DrawReceiptRow(Graphics g, string label, string value, int x, int y, Font labelFont, Font valueFont)
        {
            g.DrawString(label, labelFont, Brushes.Black, x, y);
            g.DrawString(value, valueFont, Brushes.Black, x + 220, y);
        }
    }
}