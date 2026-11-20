using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmAssesment : Form
    {
        private readonly UserModel _currentUser;
        private readonly AssessmentController _assessmentController;

        private List<EnrolledStudentLookupModel> _enrolledStudents = new List<EnrolledStudentLookupModel>();
        private int _selectedAssessmentId = 0;
        private int _selectedEnrollmentId = 0;
        private bool _isSelectingStudent = false;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmAssesment(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _assessmentController = new AssessmentController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Calculate and manage student fee assessments.";
        }

        private void FrmAssesment_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvAssessments);
            LoadEnrolledStudentsLookup();
            LoadAssessments();
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

        private void LoadEnrolledStudentsLookup()
        {
            _enrolledStudents = _assessmentController.GetEnrolledStudents();
        }

        private void LoadAssessments(string searchTerm = null)
        {
            List<AssessmentModel> assessments = _assessmentController.GetAll(includeInactive: IsAdmin, searchTerm: searchTerm);
            dgvAssessments.DataSource = null;
            dgvAssessments.DataSource = assessments;

            string[] hiddenColumns =
            {
        "AssessmentID",
        "EnrollmentID",
        "StudentID",
        "TuitionFee",
        "MiscellaneousFee",
        "OtherFees",
        "DiscountAmount",
        "TotalAmount",
        "IsActive",
        "DateCreated"
    };

            foreach (string colName in hiddenColumns)
            {
                if (dgvAssessments.Columns[colName] != null)
                    dgvAssessments.Columns[colName].Visible = false;
            }

            if (dgvAssessments.Columns["StudentNumber"] != null)
            {
                dgvAssessments.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvAssessments.Columns["StudentNumber"].DisplayIndex = 0;
                dgvAssessments.Columns["StudentNumber"].FillWeight = 16;
            }
            if (dgvAssessments.Columns["StudentName"] != null)
            {
                dgvAssessments.Columns["StudentName"].HeaderText = "Student Name";
                dgvAssessments.Columns["StudentName"].DisplayIndex = 1;
                dgvAssessments.Columns["StudentName"].FillWeight = 28;
            }
            if (dgvAssessments.Columns["GradeLevelName"] != null)
            {
                dgvAssessments.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvAssessments.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvAssessments.Columns["GradeLevelName"].FillWeight = 15;
            }
            if (dgvAssessments.Columns["SectionName"] != null)
            {
                dgvAssessments.Columns["SectionName"].HeaderText = "Section";
                dgvAssessments.Columns["SectionName"].DisplayIndex = 3;
                dgvAssessments.Columns["SectionName"].FillWeight = 15;
            }
            if (dgvAssessments.Columns["SchoolYear"] != null)
            {
                dgvAssessments.Columns["SchoolYear"].HeaderText = "School Year";
                dgvAssessments.Columns["SchoolYear"].DisplayIndex = 4;
                dgvAssessments.Columns["SchoolYear"].FillWeight = 13;
            }
            if (dgvAssessments.Columns["AssessmentDate"] != null)
            {
                dgvAssessments.Columns["AssessmentDate"].HeaderText = "Date Assessed";
                dgvAssessments.Columns["AssessmentDate"].DisplayIndex = 5;
                dgvAssessments.Columns["AssessmentDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvAssessments.Columns["AssessmentDate"].FillWeight = 13;
            }

            HighlightInactiveRows(dgvAssessments);
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


        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isSelectingStudent) return;

            _selectedEnrollmentId = 0;
            txtGradeSection.Clear();
            txtSchoolYear.Clear();

            string query = txtStudentSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                lstStudentSuggestions.Visible = false;
                return;
            }

            var exactMatch = _enrolledStudents.FirstOrDefault(s =>
                query.Equals(s.StudentNumber, StringComparison.OrdinalIgnoreCase) ||
                query.Equals(s.DisplayText, StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
            {
                ApplySelectedEnrolledStudent(exactMatch, hideList: false);
            }

            var matches = _enrolledStudents
                .Where(s =>
                    s.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.StudentName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.GradeLevelName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.SectionName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .Take(8)
                .ToList();

            if (matches.Count > 0)
            {
                lstStudentSuggestions.DataSource = matches;
                lstStudentSuggestions.DisplayMember = "DisplayText";
                lstStudentSuggestions.ValueMember = "EnrollmentID";
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
            if (lstStudentSuggestions.SelectedItem is EnrolledStudentLookupModel selected)
            {
                ApplySelectedEnrolledStudent(selected, hideList: true);
            }
        }

        private void lstStudentSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lstStudentSuggestions.SelectedItem is EnrolledStudentLookupModel selected)
            {
                ApplySelectedEnrolledStudent(selected, hideList: true);
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

        private void ApplySelectedEnrolledStudent(EnrolledStudentLookupModel selected, bool hideList)
        {
            _isSelectingStudent = true;
            _selectedEnrollmentId = selected.EnrollmentID;
            if (hideList)
            {
                txtStudentSearch.Text = $"{selected.StudentNumber} - {selected.StudentName}";
                lstStudentSuggestions.Visible = false;
            }
            txtGradeSection.Text = $"{selected.GradeLevelName} - {selected.SectionName}";
            txtSchoolYear.Text = selected.SchoolYear;
             
            txtTuitionFee.Text = selected.DefaultTuitionFee.ToString("0.00");
            txtMiscFee.Text = selected.DefaultMiscellaneousFee.ToString("0.00");

            _isSelectingStudent = false;
        }


        private void FeeInput_TextChanged(object sender, EventArgs e)
        {
            decimal tuition = ParseDecimal(txtTuitionFee.Text);
            decimal misc = ParseDecimal(txtMiscFee.Text);
            decimal other = ParseDecimal(txtOtherFees.Text);
            decimal discount = ParseDecimal(txtDiscount.Text);

            decimal total = (tuition + misc + other) - discount;
            txtTotalAmount.Text = total.ToString("N2");
        }

        private decimal ParseDecimal(string text)
        {
            return decimal.TryParse(text, out decimal value) ? value : 0m;
        }

        // --- CRUD Events ---

        private void btnAddAssessment_Click(object sender, EventArgs e)
        {
            if (!TryBuildAssessmentFromInputs(out AssessmentModel assessment, out string parseError))
            {
                MessageBox.Show(parseError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_assessmentController.Add(assessment, out string errorMsg))
            {
                MessageBox.Show("Assessment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAssessments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Assessment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateAssessment_Click(object sender, EventArgs e)
        {
            if (_selectedAssessmentId <= 0)
            {
                MessageBox.Show("Please select an assessment record from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryBuildAssessmentFromInputs(out AssessmentModel assessment, out string parseError))
            {
                MessageBox.Show(parseError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            assessment.AssessmentID = _selectedAssessmentId;

            if (_assessmentController.Update(assessment, out string errorMsg))
            {
                MessageBox.Show("Assessment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAssessments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            if (_selectedAssessmentId <= 0)
            {
                MessageBox.Show("Please select an assessment record from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this assessment record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_assessmentController.Deactivate(_selectedAssessmentId, out string errorMsg))
            {
                MessageBox.Show("Assessment record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadAssessments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearAssessment_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAssessments(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAssessments(txtSearch.Text);
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAssessments.Rows[e.RowIndex];
            _selectedAssessmentId = Convert.ToInt32(row.Cells["AssessmentID"].Value);

            _isSelectingStudent = true;
            _selectedEnrollmentId = row.Cells["EnrollmentID"].Value != null
                ? Convert.ToInt32(row.Cells["EnrollmentID"].Value)
                : 0;

            string studentNumber = row.Cells["StudentNumber"].Value?.ToString() ?? string.Empty;
            string studentName = row.Cells["StudentName"].Value?.ToString() ?? string.Empty;
            string gradeLevel = row.Cells["GradeLevelName"].Value?.ToString() ?? string.Empty;
            string section = row.Cells["SectionName"].Value?.ToString() ?? string.Empty;
            string schoolYear = row.Cells["SchoolYear"].Value?.ToString() ?? string.Empty;

            txtStudentSearch.Text = $"{studentNumber} - {studentName}";
            txtGradeSection.Text = $"{gradeLevel} - {section}";
            txtSchoolYear.Text = schoolYear;
            lstStudentSuggestions.Visible = false;
            _isSelectingStudent = false;

            if (row.Cells["AssessmentDate"].Value != null && DateTime.TryParse(row.Cells["AssessmentDate"].Value.ToString(), out DateTime assessDate))
            {
                dtpAssessmentDate.Value = assessDate;
            }

            txtTuitionFee.Text = Convert.ToDecimal(row.Cells["TuitionFee"].Value).ToString("0.00");
            txtMiscFee.Text = Convert.ToDecimal(row.Cells["MiscellaneousFee"].Value).ToString("0.00");
            txtOtherFees.Text = Convert.ToDecimal(row.Cells["OtherFees"].Value).ToString("0.00");
            txtDiscount.Text = Convert.ToDecimal(row.Cells["DiscountAmount"].Value).ToString("0.00");
            txtTotalAmount.Text = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("N2");
        }

        private bool TryBuildAssessmentFromInputs(out AssessmentModel assessment, out string errorMessage)
        {
            assessment = null;
            errorMessage = string.Empty;

            if (!decimal.TryParse(txtTuitionFee.Text, out decimal tuition))
            {
                errorMessage = "Please enter a valid numeric Tuition Fee.";
                return false;
            }
            if (!decimal.TryParse(txtMiscFee.Text, out decimal misc))
            {
                errorMessage = "Please enter a valid numeric Miscellaneous Fee.";
                return false;
            }
            if (!decimal.TryParse(txtOtherFees.Text, out decimal other))
            {
                errorMessage = "Please enter a valid numeric Other Fees amount.";
                return false;
            }
            if (!decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                errorMessage = "Please enter a valid numeric Discount amount.";
                return false;
            }

            assessment = new AssessmentModel
            {
                EnrollmentID = _selectedEnrollmentId,
                TuitionFee = tuition,
                MiscellaneousFee = misc,
                OtherFees = other,
                DiscountAmount = discount,
                AssessmentDate = dtpAssessmentDate.Value.Date
            };

            return true;
        }

        private void ClearInputs()
        {
            _selectedAssessmentId = 0;

            _isSelectingStudent = true;
            _selectedEnrollmentId = 0;
            txtStudentSearch.Clear();
            txtGradeSection.Clear();
            txtSchoolYear.Clear();
            lstStudentSuggestions.Visible = false;
            _isSelectingStudent = false;

            dtpAssessmentDate.Value = DateTime.Today;
            txtTuitionFee.Text = "0.00";
            txtMiscFee.Text = "0.00";
            txtOtherFees.Text = "0.00";
            txtDiscount.Text = "0.00";
            txtTotalAmount.Text = "0.00";
            dgvAssessments.ClearSelection();
        }
    }
}