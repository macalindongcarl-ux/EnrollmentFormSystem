using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmStudents : Form
    {
        private readonly UserModel _currentUser;
        private readonly StudentController _studentController;
        private int _selectedStudentId = 0;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmStudents(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _studentController = new StudentController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Manage, register, and update student records.";
            cboGender.SelectedIndex = 0;
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvStudents);
            LoadStudents();

            txtStudentNumber.ReadOnly = true;
            txtStudentNumber.BackColor = Color.FromArgb(241, 245, 249);
            txtStudentNumber.Text = "Auto-Generated";
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

        private void LoadStudents(string searchTerm = null)
        {
            List<StudentModel> students = _studentController.GetAll(includeInactive: IsAdmin, searchTerm: searchTerm);
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;

            // Hide raw/extra columns (still accessible via row.Cells[...] when clicked)
            string[] hiddenColumns =
            {
                "StudentID", "FirstName", "MiddleName", "LastName",
                "Address", "Email", "GuardianContact", "IsActive", "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvStudents.Columns[colName] != null)
                    dgvStudents.Columns[colName].Visible = false;
            }

            // Configure clean visible columns matching the mockup
            if (dgvStudents.Columns["StudentNumber"] != null)
            {
                dgvStudents.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvStudents.Columns["StudentNumber"].DisplayIndex = 0;
                dgvStudents.Columns["StudentNumber"].FillWeight = 15;
            }
            if (dgvStudents.Columns["FullName"] != null)
            {
                dgvStudents.Columns["FullName"].HeaderText = "Full Name";
                dgvStudents.Columns["FullName"].DisplayIndex = 1;
                dgvStudents.Columns["FullName"].FillWeight = 25;
            }
            if (dgvStudents.Columns["Gender"] != null)
            {
                dgvStudents.Columns["Gender"].HeaderText = "Gender";
                dgvStudents.Columns["Gender"].DisplayIndex = 2;
                dgvStudents.Columns["Gender"].FillWeight = 11;
            }
            if (dgvStudents.Columns["DateOfBirth"] != null)
            {
                dgvStudents.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                dgvStudents.Columns["DateOfBirth"].DisplayIndex = 3;
                dgvStudents.Columns["DateOfBirth"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvStudents.Columns["DateOfBirth"].FillWeight = 14;
            }
            if (dgvStudents.Columns["ContactNumber"] != null)
            {
                dgvStudents.Columns["ContactNumber"].HeaderText = "Contact Number";
                dgvStudents.Columns["ContactNumber"].DisplayIndex = 4;
                dgvStudents.Columns["ContactNumber"].FillWeight = 15;
            }
            if (dgvStudents.Columns["GuardianName"] != null)
            {
                dgvStudents.Columns["GuardianName"].HeaderText = "Guardian Name";
                dgvStudents.Columns["GuardianName"].DisplayIndex = 5;
                dgvStudents.Columns["GuardianName"].FillWeight = 20;
            }

            HighlightInactiveRows(dgvStudents);
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentModel student = BuildStudentFromInputs();

            if (_studentController.Add(student, out string errorMsg))
            {
                MessageBox.Show("Student registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadStudents(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId <= 0)
            {
                MessageBox.Show("Please select a student record from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentModel student = BuildStudentFromInputs();
            student.StudentID = _selectedStudentId;

            if (_studentController.Update(student, out string errorMsg))
            {
                MessageBox.Show("Student record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadStudents(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId <= 0)
            {
                MessageBox.Show("Please select a student record from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this student record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_studentController.Deactivate(_selectedStudentId, out string errorMsg))
            {
                MessageBox.Show("Student record deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadStudents(txtSearch.Text);
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudents(txtSearch.Text);
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
            _selectedStudentId = Convert.ToInt32(row.Cells["StudentID"].Value);

            txtStudentNumber.Text = row.Cells["StudentNumber"].Value?.ToString() ?? string.Empty;
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? string.Empty;
            txtMiddleName.Text = row.Cells["MiddleName"].Value?.ToString() ?? string.Empty;
            txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? string.Empty;

            if (row.Cells["DateOfBirth"].Value != null && DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob))
            {
                dtpDateOfBirth.Value = dob;
            }

            string gender = row.Cells["Gender"].Value?.ToString() ?? "Male";
            cboGender.SelectedItem = gender;

            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty;
            txtContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString() ?? string.Empty;
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
            txtGuardianName.Text = row.Cells["GuardianName"].Value?.ToString() ?? string.Empty;
            txtGuardianContact.Text = row.Cells["GuardianContact"].Value?.ToString() ?? string.Empty;
        }

        private StudentModel BuildStudentFromInputs()
        {
            return new StudentModel
            {
                StudentNumber = txtStudentNumber.Text,
                FirstName = txtFirstName.Text,
                MiddleName = txtMiddleName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = dtpDateOfBirth.Value.Date,
                Gender = cboGender.SelectedItem?.ToString() ?? "Male",
                Address = txtAddress.Text,
                ContactNumber = txtContactNumber.Text,
                Email = txtEmail.Text,
                GuardianName = txtGuardianName.Text,
                GuardianContact = txtGuardianContact.Text
            };
        }

        private void ClearInputs()
        {
            _selectedStudentId = 0;
            txtStudentNumber.Text = "Auto-Generated";
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = new DateTime(2012, 1, 1);
            cboGender.SelectedIndex = 0;
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtGuardianName.Clear();
            txtGuardianContact.Clear();
            dgvStudents.ClearSelection();
        }
    }
}