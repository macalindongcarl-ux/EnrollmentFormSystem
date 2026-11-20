using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmDashboard : Form
    {
        private readonly UserModel _currentUser;
        private readonly StudentController _studentController;
        private readonly EnrollmentController _enrollmentController;
        private readonly SectionController _sectionController;
        private readonly PaymentController _paymentController;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        private bool IsRegistrar =>
            _currentUser != null &&
            _currentUser.Role.Equals("Registrar", StringComparison.OrdinalIgnoreCase);

        private bool IsCashier =>
            _currentUser != null &&
            _currentUser.Role.Equals("Cashier", StringComparison.OrdinalIgnoreCase);

        public FrmDashboard(UserModel loggedInUser)
        {
            InitializeComponent();
            _currentUser = loggedInUser;
            _studentController = new StudentController();
            _enrollmentController = new EnrollmentController();
            _sectionController = new SectionController();
            _paymentController = new PaymentController();

            lblWelcome.Text = $"Welcome back, {_currentUser.Username} ({_currentUser.Role}) — Here is your live overview for today, {DateTime.Now:MMMM dd, yyyy}.";
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            ApplyModernCardStyling();
            ConfigureRoleLayout();
            StyleDataGridView(dgvRecentEnrollments);
            StyleDataGridView(dgvRecentPayments);
            LoadDashboardData();
        }

        private void ApplyModernCardStyling()
        {
            StyleAccentCard(pnlCardStudents, Color.FromArgb(79, 70, 229));   
            StyleAccentCard(pnlCardEnrolled, Color.FromArgb(22, 163, 74));   
            StyleAccentCard(pnlCardSections, Color.FromArgb(2, 132, 199));   
            StyleAccentCard(pnlCardAssessed, Color.FromArgb(51, 65, 85));    
            StyleAccentCard(pnlCardCollected, Color.FromArgb(13, 148, 136)); 
            StyleAccentCard(pnlCardBalance, Color.FromArgb(225, 29, 72));    

            lblCardAssessedSub.Text = "Net billed tuition && fees";

            StyleContainerPanel(pnlRecentEnrollments);
            StyleContainerPanel(pnlRecentPayments);

            btnRefresh.BackColor = Color.FromArgb(30, 41, 59);
            btnRefresh.Cursor = Cursors.Hand;
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

        private void ConfigureRoleLayout()
        {
            if (IsRegistrar)
            {
                pnlCardAssessed.Visible = false;
                pnlCardCollected.Visible = false;
                pnlCardBalance.Visible = false;
                pnlRecentPayments.Visible = false;

                pnlRecentEnrollments.Location = new Point(24, 272);
                pnlRecentEnrollments.Size = new Size(1532, 784);
                dgvRecentEnrollments.Size = new Size(1486, 686);
            }
            else if (IsCashier)
            {
                pnlCardStudents.Visible = false;
                pnlCardEnrolled.Visible = false;
                pnlCardSections.Visible = false;
                pnlRecentEnrollments.Visible = false;

                pnlCardAssessed.Location = new Point(24, 122);
                pnlCardCollected.Location = new Point(543, 122);
                pnlCardBalance.Location = new Point(1062, 122);

                pnlRecentPayments.Location = new Point(24, 272);
                pnlRecentPayments.Size = new Size(1532, 784);
                dgvRecentPayments.Size = new Size(1486, 686);
            }
        }

        private void StyleDataGridView(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(241, 245, 249);
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToResizeColumns = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;

            // Keep headers single-line and crisp
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(71, 85, 105);

            // Clean row styling
            grid.RowTemplate.Height = 42;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(49, 46, 129);
        }

        private void LoadDashboardData()
        {
            if (IsAdmin || IsRegistrar)
            {
                List<StudentModel> activeStudents = _studentController.GetAll(includeInactive: false);
                List<EnrollmentModel> activeEnrollments = _enrollmentController.GetAll(includeInactive: false);
                List<SectionModel> activeSections = _sectionController.GetAll(includeInactive: false);

                int enrolledCount = activeEnrollments.Count(e =>
                    e.Status.Equals("Enrolled", StringComparison.OrdinalIgnoreCase));

                lblCardStudentsValue.Text = activeStudents.Count.ToString("N0");
                lblCardEnrolledValue.Text = enrolledCount.ToString("N0");
                lblCardSectionsValue.Text = activeSections.Count.ToString("N0");

                BindRecentEnrollments(activeEnrollments.Take(12).ToList());
            }

            if (IsAdmin || IsCashier)
            {
                List<AssessedAccountModel> accounts = _paymentController.GetAssessedAccounts();
                List<PaymentModel> recentPayments = _paymentController.GetAll(includeInactive: false);

                decimal totalAssessed = accounts.Sum(a => a.TotalAssessed);
                decimal totalCollected = accounts.Sum(a => a.TotalPaid);
                decimal totalBalance = accounts.Sum(a => a.RemainingBalance);

                lblCardAssessedValue.Text = $"₱{totalAssessed:N2}";
                lblCardCollectedValue.Text = $"₱{totalCollected:N2}";
                lblCardBalanceValue.Text = $"₱{totalBalance:N2}";

                BindRecentPayments(recentPayments.Take(12).ToList());
            }
        }

        private void BindRecentEnrollments(List<EnrollmentModel> enrollments)
        {
            dgvRecentEnrollments.DataSource = null;
            dgvRecentEnrollments.DataSource = enrollments;

            string[] hiddenColumns =
            {
                "EnrollmentID", "StudentID", "GradeLevelID", "SectionID",
                "SchoolYear", "EnrollmentDate", "IsActive", "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvRecentEnrollments.Columns[colName] != null)
                    dgvRecentEnrollments.Columns[colName].Visible = false;
            }

            if (dgvRecentEnrollments.Columns["StudentNumber"] != null)
            {
                dgvRecentEnrollments.Columns["StudentNumber"].HeaderText = "Student No.";
                dgvRecentEnrollments.Columns["StudentNumber"].DisplayIndex = 0;
                dgvRecentEnrollments.Columns["StudentNumber"].FillWeight = 20;
            }
            if (dgvRecentEnrollments.Columns["StudentName"] != null)
            {
                dgvRecentEnrollments.Columns["StudentName"].HeaderText = "Student Name";
                dgvRecentEnrollments.Columns["StudentName"].DisplayIndex = 1;
                dgvRecentEnrollments.Columns["StudentName"].FillWeight = 30;
            }
            if (dgvRecentEnrollments.Columns["GradeLevelName"] != null)
            {
                dgvRecentEnrollments.Columns["GradeLevelName"].HeaderText = "Grade";
                dgvRecentEnrollments.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvRecentEnrollments.Columns["GradeLevelName"].FillWeight = 16;
            }
            if (dgvRecentEnrollments.Columns["SectionName"] != null)
            {
                dgvRecentEnrollments.Columns["SectionName"].HeaderText = "Section";
                dgvRecentEnrollments.Columns["SectionName"].DisplayIndex = 3;
                dgvRecentEnrollments.Columns["SectionName"].FillWeight = 18;
            }
            if (dgvRecentEnrollments.Columns["Status"] != null)
            {
                dgvRecentEnrollments.Columns["Status"].HeaderText = "Status";
                dgvRecentEnrollments.Columns["Status"].DisplayIndex = 4;
                dgvRecentEnrollments.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                dgvRecentEnrollments.Columns["Status"].FillWeight = 16;
            }

            foreach (DataGridViewRow row in dgvRecentEnrollments.Rows)
            {
                string status = row.Cells["Status"]?.Value?.ToString() ?? string.Empty;
                if (status.Equals("Enrolled", StringComparison.OrdinalIgnoreCase))
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(22, 163, 74);
                else if (status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(217, 119, 6);
                else
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(225, 29, 72);
            }

            dgvRecentEnrollments.ClearSelection();
        }

        private void BindRecentPayments(List<PaymentModel> payments)
        {
            dgvRecentPayments.DataSource = null;
            dgvRecentPayments.DataSource = payments;

            string[] hiddenColumns =
            {
                "PaymentID", "AssessmentID", "StudentNumber", "GradeLevelName",
                "SectionName", "SchoolYear", "ReferenceNumber", "PaymentDate",
                "ProcessedByUserID", "ProcessedBy", "IsActive", "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvRecentPayments.Columns[colName] != null)
                    dgvRecentPayments.Columns[colName].Visible = false;
            }

            if (dgvRecentPayments.Columns["ReceiptNumber"] != null)
            {
                dgvRecentPayments.Columns["ReceiptNumber"].HeaderText = "OR Number";
                dgvRecentPayments.Columns["ReceiptNumber"].DisplayIndex = 0;
                dgvRecentPayments.Columns["ReceiptNumber"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvRecentPayments.Columns["ReceiptNumber"].FillWeight = 24;
            }
            if (dgvRecentPayments.Columns["StudentName"] != null)
            {
                dgvRecentPayments.Columns["StudentName"].HeaderText = "Student Name";
                dgvRecentPayments.Columns["StudentName"].DisplayIndex = 1;
                dgvRecentPayments.Columns["StudentName"].FillWeight = 36;
            }
            if (dgvRecentPayments.Columns["AmountPaid"] != null)
            {
                dgvRecentPayments.Columns["AmountPaid"].HeaderText = "Amount Paid";
                dgvRecentPayments.Columns["AmountPaid"].DisplayIndex = 2;
                dgvRecentPayments.Columns["AmountPaid"].DefaultCellStyle.Format = "N2";
                dgvRecentPayments.Columns["AmountPaid"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRecentPayments.Columns["AmountPaid"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvRecentPayments.Columns["AmountPaid"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvRecentPayments.Columns["AmountPaid"].DefaultCellStyle.ForeColor = Color.FromArgb(22, 163, 74);
                dgvRecentPayments.Columns["AmountPaid"].FillWeight = 22;
            }
            if (dgvRecentPayments.Columns["PaymentMethod"] != null)
            {
                dgvRecentPayments.Columns["PaymentMethod"].HeaderText = "Method";
                dgvRecentPayments.Columns["PaymentMethod"].DisplayIndex = 3;
                dgvRecentPayments.Columns["PaymentMethod"].FillWeight = 18;
            }

            dgvRecentPayments.ClearSelection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
    }
}