using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmEnrollment : Form
    {
        private readonly UserModel _currentUser;
        private readonly EnrollmentController _enrollmentController;
        private readonly StudentController _studentController;
        private readonly GradeLevelController _gradeLevelController;

        private List<StudentModel> _activeStudents = new List<StudentModel>();
        private int _selectedEnrollmentId = 0;
        private int _selectedStudentId = 0;
        private bool _isSelectingStudent = false;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        private class StudentLookupItem
        {
            public int StudentID { get; set; }
            public string DisplayText { get; set; }
            public override string ToString() => DisplayText;
        }

        public FrmEnrollment(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _enrollmentController = new EnrollmentController();
            _studentController = new StudentController();
            _gradeLevelController = new GradeLevelController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Enroll students and manage section assignments.";
            cboStatus.SelectedIndex = 0;
        }

        private void FrmEnrollment_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvEnrollments);
            LoadStudentsLookup();
            LoadGradeLevelsDropdown();
            LoadEnrollments();
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

        private void LoadStudentsLookup()
        {
            _activeStudents = _studentController.GetAll(includeInactive: false);
        }

        private void LoadGradeLevelsDropdown()
        {
            List<GradeLevelModel> activeGrades = _gradeLevelController.GetAll(includeInactive: false);
            cboGradeLevel.DataSource = activeGrades;
            cboGradeLevel.DisplayMember = "GradeLevelName";
            cboGradeLevel.ValueMember = "GradeLevelID";

            LoadSectionsDropdown();
        }

        private void LoadSectionsDropdown()
        {
            if (cboGradeLevel.SelectedValue == null || !(cboGradeLevel.SelectedValue is int gradeLevelId))
            {
                cboSection.DataSource = null;
                return;
            }

            string schoolYear = txtSchoolYear.Text.Trim();
            List<SectionCapacityModel> sections = _enrollmentController.GetSectionsByGradeAndSY(gradeLevelId, schoolYear);

            cboSection.DataSource = null;
            cboSection.DataSource = sections;
            cboSection.DisplayMember = "DisplayLabel";
            cboSection.ValueMember = "SectionID";
        }

        private void LoadEnrollments(string searchTerm = null)
        {
            List<EnrollmentModel> enrollments = _enrollmentController.GetAll(includeInactive: IsAdmin, searchTerm: searchTerm);
            dgvEnrollments.DataSource = null;
            dgvEnrollments.DataSource = enrollments;

            string[] hiddenColumns =
            {
                "EnrollmentID", "StudentID", "GradeLevelID", "SectionID", "IsActive", "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvEnrollments.Columns[colName] != null)
                    dgvEnrollments.Columns[colName].Visible = false;
            }

            if (dgvEnrollments.Columns["StudentNumber"] != null)
            {
                dgvEnrollments.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvEnrollments.Columns["StudentNumber"].DisplayIndex = 0;
                dgvEnrollments.Columns["StudentNumber"].FillWeight = 15;
            }
            if (dgvEnrollments.Columns["StudentName"] != null)
            {
                dgvEnrollments.Columns["StudentName"].HeaderText = "Student Name";
                dgvEnrollments.Columns["StudentName"].DisplayIndex = 1;
                dgvEnrollments.Columns["StudentName"].FillWeight = 25;
            }
            if (dgvEnrollments.Columns["GradeLevelName"] != null)
            {
                dgvEnrollments.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvEnrollments.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvEnrollments.Columns["GradeLevelName"].FillWeight = 14;
            }
            if (dgvEnrollments.Columns["SectionName"] != null)
            {
                dgvEnrollments.Columns["SectionName"].HeaderText = "Section";
                dgvEnrollments.Columns["SectionName"].DisplayIndex = 3;
                dgvEnrollments.Columns["SectionName"].FillWeight = 14;
            }
            if (dgvEnrollments.Columns["SchoolYear"] != null)
            {
                dgvEnrollments.Columns["SchoolYear"].HeaderText = "School Year";
                dgvEnrollments.Columns["SchoolYear"].DisplayIndex = 4;
                dgvEnrollments.Columns["SchoolYear"].FillWeight = 12;
            }
            if (dgvEnrollments.Columns["EnrollmentDate"] != null)
            {
                dgvEnrollments.Columns["EnrollmentDate"].HeaderText = "Date Enrolled";
                dgvEnrollments.Columns["EnrollmentDate"].DisplayIndex = 5;
                dgvEnrollments.Columns["EnrollmentDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvEnrollments.Columns["EnrollmentDate"].FillWeight = 11;
            }
            if (dgvEnrollments.Columns["Status"] != null)
            {
                dgvEnrollments.Columns["Status"].HeaderText = "Status";
                dgvEnrollments.Columns["Status"].DisplayIndex = 6;
                dgvEnrollments.Columns["Status"].FillWeight = 9;
            }

            HighlightInactiveRows(dgvEnrollments);
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

        // --- Student Search Lookup Events ---

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            if (_isSelectingStudent) return;

            _selectedStudentId = 0;
            string query = txtStudent.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                lstStudentSuggestions.Visible = false;
                return;
            }

            var exactMatch = _activeStudents.FirstOrDefault(s =>
                query.Equals(s.StudentNumber, StringComparison.OrdinalIgnoreCase) ||
                query.Equals($"{s.StudentNumber} - {s.FullName}", StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
            {
                _selectedStudentId = exactMatch.StudentID;
            }

            var matches = _activeStudents
                .Where(s =>
                    s.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.FullName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.FirstName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    s.LastName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .Take(8)
                .Select(s => new StudentLookupItem
                {
                    StudentID = s.StudentID,
                    DisplayText = $"{s.StudentNumber} - {s.FullName}"
                })
                .ToList();

            if (matches.Count > 0)
            {
                lstStudentSuggestions.DataSource = matches;
                lstStudentSuggestions.DisplayMember = "DisplayText";
                lstStudentSuggestions.ValueMember = "StudentID";
                lstStudentSuggestions.Visible = true;
                lstStudentSuggestions.BringToFront();
            }
            else
            {
                lstStudentSuggestions.Visible = false;
            }
        }

        private void txtStudent_KeyDown(object sender, KeyEventArgs e)
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
            SelectStudentFromSuggestion();
        }

        private void lstStudentSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectStudentFromSuggestion();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstStudentSuggestions.Visible = false;
                txtStudent.Focus();
                e.Handled = true;
            }
        }

        private void txtStudent_Leave(object sender, EventArgs e)
        {
            if (!lstStudentSuggestions.Focused)
            {
                lstStudentSuggestions.Visible = false;
            }
        }

        private void SelectStudentFromSuggestion()
        {
            if (lstStudentSuggestions.SelectedItem is StudentLookupItem selected)
            {
                _isSelectingStudent = true;
                _selectedStudentId = selected.StudentID;
                txtStudent.Text = selected.DisplayText;
                lstStudentSuggestions.Visible = false;
                _isSelectingStudent = false;
            }
        }

        // --- Section & CRUD Events ---

        private void cboGradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSectionsDropdown();
        }

        private void txtSchoolYear_TextChanged(object sender, EventArgs e)
        {
            LoadSectionsDropdown();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            EnrollmentModel enrollment = BuildEnrollmentFromInputs();

            if (_enrollmentController.Add(enrollment, out string errorMsg))
            {
                MessageBox.Show("Student enrolled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadSectionsDropdown();
                LoadEnrollments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            if (_selectedEnrollmentId <= 0)
            {
                MessageBox.Show("Please select an enrollment record from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnrollmentModel enrollment = BuildEnrollmentFromInputs();
            enrollment.EnrollmentID = _selectedEnrollmentId;

            if (_enrollmentController.Update(enrollment, out string errorMsg))
            {
                MessageBox.Show("Enrollment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadSectionsDropdown();
                LoadEnrollments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            if (_selectedEnrollmentId <= 0)
            {
                MessageBox.Show("Please select an enrollment record from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this enrollment record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_enrollmentController.Deactivate(_selectedEnrollmentId, out string errorMsg))
            {
                MessageBox.Show("Enrollment record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadSectionsDropdown();
                LoadEnrollments(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearEnrollment_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadEnrollments(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEnrollments(txtSearch.Text);
        }

        private void dgvEnrollments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvEnrollments.Rows[e.RowIndex];
            _selectedEnrollmentId = Convert.ToInt32(row.Cells["EnrollmentID"].Value);

            _isSelectingStudent = true;
            _selectedStudentId = row.Cells["StudentID"].Value != null
                ? Convert.ToInt32(row.Cells["StudentID"].Value)
                : 0;
            string studentNumber = row.Cells["StudentNumber"].Value?.ToString() ?? string.Empty;
            string studentName = row.Cells["StudentName"].Value?.ToString() ?? string.Empty;
            txtStudent.Text = $"{studentNumber} - {studentName}";
            lstStudentSuggestions.Visible = false;
            _isSelectingStudent = false;

            txtSchoolYear.Text = row.Cells["SchoolYear"].Value?.ToString() ?? "2026-2027";

            if (row.Cells["GradeLevelID"].Value != null)
            {
                cboGradeLevel.SelectedValue = Convert.ToInt32(row.Cells["GradeLevelID"].Value);
                LoadSectionsDropdown();
            }

            if (row.Cells["SectionID"].Value != null)
            {
                cboSection.SelectedValue = Convert.ToInt32(row.Cells["SectionID"].Value);
            }

            if (row.Cells["EnrollmentDate"].Value != null && DateTime.TryParse(row.Cells["EnrollmentDate"].Value.ToString(), out DateTime enrollDate))
            {
                dtpEnrollmentDate.Value = enrollDate;
            }

            string status = row.Cells["Status"].Value?.ToString() ?? "Enrolled";
            cboStatus.SelectedItem = status;
        }

        private EnrollmentModel BuildEnrollmentFromInputs()
        {
            int gradeLevelId = 0;
            if (cboGradeLevel.SelectedValue is int selectedGradeId)
            {
                gradeLevelId = selectedGradeId;
            }

            int sectionId = 0;
            if (cboSection.SelectedValue is int selectedSectionId)
            {
                sectionId = selectedSectionId;
            }

            return new EnrollmentModel
            {
                StudentID = _selectedStudentId,
                SchoolYear = txtSchoolYear.Text,
                GradeLevelID = gradeLevelId,
                SectionID = sectionId,
                EnrollmentDate = dtpEnrollmentDate.Value.Date,
                Status = cboStatus.SelectedItem?.ToString() ?? "Enrolled"
            };
        }

        private void ClearInputs()
        {
            _selectedEnrollmentId = 0;

            _isSelectingStudent = true;
            _selectedStudentId = 0;
            txtStudent.Clear();
            lstStudentSuggestions.Visible = false;
            _isSelectingStudent = false;

            txtSchoolYear.Text = "2026-2027";
            if (cboGradeLevel.Items.Count > 0)
            {
                cboGradeLevel.SelectedIndex = 0;
            }
            LoadSectionsDropdown();
            dtpEnrollmentDate.Value = DateTime.Today;
            cboStatus.SelectedIndex = 0;
            dgvEnrollments.ClearSelection();
        }
    }
}