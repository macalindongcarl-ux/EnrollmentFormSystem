using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmSections : Form
    {
        private readonly UserModel _currentUser;
        private readonly GradeLevelController _gradeLevelController;
        private readonly SectionController _sectionController;

        private int _selectedGradeLevelId = 0;
        private int _selectedSectionId = 0;

        private bool IsAdmin =>
            _currentUser != null &&
            _currentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);

        public FrmSections(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _gradeLevelController = new GradeLevelController();
            _sectionController = new SectionController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Manage grade levels, default fee rates, and class sections.";
        }

        private void FrmSections_Load(object sender, EventArgs e)
        {
            ConfigureRolePermissions();
            StyleDataGridView(dgvGradeLevels);
            StyleDataGridView(dgvSections);
            LoadGradeLevels();
            LoadSections();
        }

        private void ConfigureRolePermissions()
        {
            // Only Admin can add, update, or delete Grade Levels and Sections
            // Registrar has read-only view access
            bool canManage = IsAdmin;

            // Grade Level inputs & buttons
            txtGradeLevelName.ReadOnly = !canManage;
            txtGradeTuitionFee.ReadOnly = !canManage;
            txtGradeMiscFee.ReadOnly = !canManage;

            btnAddGradeLevel.Visible = canManage;
            btnUpdateGradeLevel.Visible = canManage;
            btnDeleteGradeLevel.Visible = canManage;
            btnClearGradeLevel.Visible = canManage;

            // Section inputs & buttons
            cboGradeLevel.Enabled = canManage;
            txtSectionName.ReadOnly = !canManage;
            txtSchoolYear.ReadOnly = !canManage;
            txtAdviser.ReadOnly = !canManage;
            numMaxCapacity.Enabled = canManage;

            btnAddSection.Visible = canManage;
            btnUpdateSection.Visible = canManage;
            btnDeleteSection.Visible = canManage;
            btnClearSection.Visible = canManage;

            if (!canManage)
            {
                lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! View grade levels, default fee rates, and class sections (Read-Only).";
            }
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

        private void LoadGradeLevels()
        {
            List<GradeLevelModel> allGrades = _gradeLevelController.GetAll(includeInactive: IsAdmin);
            dgvGradeLevels.DataSource = null;
            dgvGradeLevels.DataSource = allGrades;

            string[] hiddenColumns = { "GradeLevelID", "IsActive", "DateCreated" };
            foreach (string colName in hiddenColumns)
            {
                if (dgvGradeLevels.Columns[colName] != null)
                    dgvGradeLevels.Columns[colName].Visible = false;
            }

            if (dgvGradeLevels.Columns["GradeLevelName"] != null)
            {
                dgvGradeLevels.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvGradeLevels.Columns["GradeLevelName"].DisplayIndex = 0;
                dgvGradeLevels.Columns["GradeLevelName"].FillWeight = 34;
            }
            if (dgvGradeLevels.Columns["TuitionFee"] != null)
            {
                dgvGradeLevels.Columns["TuitionFee"].HeaderText = "Tuition (₱)";
                dgvGradeLevels.Columns["TuitionFee"].DisplayIndex = 1;
                dgvGradeLevels.Columns["TuitionFee"].DefaultCellStyle.Format = "N2";
                dgvGradeLevels.Columns["TuitionFee"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGradeLevels.Columns["TuitionFee"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGradeLevels.Columns["TuitionFee"].FillWeight = 33;
            }
            if (dgvGradeLevels.Columns["MiscellaneousFee"] != null)
            {
                dgvGradeLevels.Columns["MiscellaneousFee"].HeaderText = "Misc (₱)";
                dgvGradeLevels.Columns["MiscellaneousFee"].DisplayIndex = 2;
                dgvGradeLevels.Columns["MiscellaneousFee"].DefaultCellStyle.Format = "N2";
                dgvGradeLevels.Columns["MiscellaneousFee"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGradeLevels.Columns["MiscellaneousFee"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGradeLevels.Columns["MiscellaneousFee"].FillWeight = 33;
            }

            HighlightInactiveRows(dgvGradeLevels);

            List<GradeLevelModel> activeGrades = _gradeLevelController.GetAll(includeInactive: false);
            cboGradeLevel.DataSource = null;
            cboGradeLevel.DataSource = activeGrades;
            cboGradeLevel.DisplayMember = "GradeLevelName";
            cboGradeLevel.ValueMember = "GradeLevelID";
        }

        private void LoadSections()
        {
            List<SectionModel> sections = _sectionController.GetAll(includeInactive: IsAdmin);
            dgvSections.DataSource = null;
            dgvSections.DataSource = sections;

            string[] hiddenColumns =
            {
                "SectionID", "GradeLevelID", "IsActive", "DateCreated", "CurrentEnrolled", "DisplayWithCapacity"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvSections.Columns[colName] != null)
                    dgvSections.Columns[colName].Visible = false;
            }

            if (dgvSections.Columns["GradeLevelName"] != null)
            {
                dgvSections.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvSections.Columns["GradeLevelName"].DisplayIndex = 0;
                dgvSections.Columns["GradeLevelName"].FillWeight = 16;
            }
            if (dgvSections.Columns["SectionName"] != null)
            {
                dgvSections.Columns["SectionName"].HeaderText = "Section";
                dgvSections.Columns["SectionName"].DisplayIndex = 1;
                dgvSections.Columns["SectionName"].FillWeight = 18;
            }
            if (dgvSections.Columns["SchoolYear"] != null)
            {
                dgvSections.Columns["SchoolYear"].HeaderText = "School Year";
                dgvSections.Columns["SchoolYear"].DisplayIndex = 2;
                dgvSections.Columns["SchoolYear"].FillWeight = 18;
            }
            if (dgvSections.Columns["Adviser"] != null)
            {
                dgvSections.Columns["Adviser"].HeaderText = "Adviser";
                dgvSections.Columns["Adviser"].DisplayIndex = 3;
                dgvSections.Columns["Adviser"].FillWeight = 34;
            }
            if (dgvSections.Columns["MaxCapacity"] != null)
            {
                dgvSections.Columns["MaxCapacity"].HeaderText = "Capacity";
                dgvSections.Columns["MaxCapacity"].DisplayIndex = 4;
                dgvSections.Columns["MaxCapacity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSections.Columns["MaxCapacity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSections.Columns["MaxCapacity"].FillWeight = 14;
            }

            HighlightInactiveRows(dgvSections);
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

        // --- Grade Level Events ---

        private void btnAddGradeLevel_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (!TryBuildGradeLevelFromInputs(out GradeLevelModel gradeLevel, out string parseError))
            {
                MessageBox.Show(parseError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_gradeLevelController.Add(gradeLevel, out string errorMsg))
            {
                MessageBox.Show("Grade level saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGradeLevelInputs();
                LoadGradeLevels();
            }
            else
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateGradeLevel_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (_selectedGradeLevelId <= 0)
            {
                MessageBox.Show("Please select a grade level from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryBuildGradeLevelFromInputs(out GradeLevelModel gradeLevel, out string parseError))
            {
                MessageBox.Show(parseError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gradeLevel.GradeLevelID = _selectedGradeLevelId;

            if (_gradeLevelController.Update(gradeLevel, out string errorMsg))
            {
                MessageBox.Show("Grade level updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGradeLevelInputs();
                LoadGradeLevels();
                LoadSections();
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteGradeLevel_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (_selectedGradeLevelId <= 0)
            {
                MessageBox.Show("Please select a grade level from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this grade level?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_gradeLevelController.Deactivate(_selectedGradeLevelId, out string errorMsg))
            {
                MessageBox.Show("Grade level deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGradeLevelInputs();
                LoadGradeLevels();
            }
            else
            {
                MessageBox.Show(errorMsg, "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearGradeLevel_Click(object sender, EventArgs e)
        {
            ClearGradeLevelInputs();
        }

        private void dgvGradeLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvGradeLevels.Rows[e.RowIndex];
            _selectedGradeLevelId = Convert.ToInt32(row.Cells["GradeLevelID"].Value);
            txtGradeLevelName.Text = row.Cells["GradeLevelName"].Value?.ToString() ?? string.Empty;
            txtGradeTuitionFee.Text = Convert.ToDecimal(row.Cells["TuitionFee"].Value).ToString("0.00");
            txtGradeMiscFee.Text = Convert.ToDecimal(row.Cells["MiscellaneousFee"].Value).ToString("0.00");
        }

        private bool TryBuildGradeLevelFromInputs(out GradeLevelModel gradeLevel, out string errorMessage)
        {
            gradeLevel = null;
            errorMessage = string.Empty;

            if (!decimal.TryParse(txtGradeTuitionFee.Text, out decimal tuition))
            {
                errorMessage = "Please enter a valid numeric Tuition Fee.";
                return false;
            }

            if (!decimal.TryParse(txtGradeMiscFee.Text, out decimal misc))
            {
                errorMessage = "Please enter a valid numeric Miscellaneous Fee.";
                return false;
            }

            gradeLevel = new GradeLevelModel
            {
                GradeLevelName = txtGradeLevelName.Text,
                TuitionFee = tuition,
                MiscellaneousFee = misc
            };

            return true;
        }

        private void ClearGradeLevelInputs()
        {
            _selectedGradeLevelId = 0;
            txtGradeLevelName.Clear();
            txtGradeTuitionFee.Text = "0.00";
            txtGradeMiscFee.Text = "0.00";
            dgvGradeLevels.ClearSelection();
        }

        // --- Section Events ---

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (cboGradeLevel.SelectedValue == null)
            {
                MessageBox.Show("Please select a Grade Level first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SectionModel section = new SectionModel
            {
                GradeLevelID = Convert.ToInt32(cboGradeLevel.SelectedValue),
                SectionName = txtSectionName.Text,
                SchoolYear = txtSchoolYear.Text,
                Adviser = txtAdviser.Text,
                MaxCapacity = numMaxCapacity.Value > 0 ? (int?)numMaxCapacity.Value : null
            };

            if (_sectionController.Add(section, out string errorMsg))
            {
                MessageBox.Show("Section added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSectionInputs();
                LoadSections();
            }
            else
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateSection_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (_selectedSectionId <= 0)
            {
                MessageBox.Show("Please select a section from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboGradeLevel.SelectedValue == null)
            {
                MessageBox.Show("Please select a Grade Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SectionModel section = new SectionModel
            {
                SectionID = _selectedSectionId,
                GradeLevelID = Convert.ToInt32(cboGradeLevel.SelectedValue),
                SectionName = txtSectionName.Text,
                SchoolYear = txtSchoolYear.Text,
                Adviser = txtAdviser.Text,
                MaxCapacity = numMaxCapacity.Value > 0 ? (int?)numMaxCapacity.Value : null
            };

            if (_sectionController.Update(section, out string errorMsg))
            {
                MessageBox.Show("Section updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSectionInputs();
                LoadSections();
            }
            else
            {
                MessageBox.Show(errorMsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (!IsAdmin) return;

            if (_selectedSectionId <= 0)
            {
                MessageBox.Show("Please select a section from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this section?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            if (_sectionController.Deactivate(_selectedSectionId, out string errorMsg))
            {
                MessageBox.Show("Section deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSectionInputs();
                LoadSections();
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearSection_Click(object sender, EventArgs e)
        {
            ClearSectionInputs();
        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSections.Rows[e.RowIndex];
            _selectedSectionId = Convert.ToInt32(row.Cells["SectionID"].Value);

            if (row.Cells["GradeLevelID"].Value != null)
            {
                cboGradeLevel.SelectedValue = Convert.ToInt32(row.Cells["GradeLevelID"].Value);
            }

            txtSectionName.Text = row.Cells["SectionName"].Value?.ToString() ?? string.Empty;
            txtSchoolYear.Text = row.Cells["SchoolYear"].Value?.ToString() ?? string.Empty;
            txtAdviser.Text = row.Cells["Adviser"].Value?.ToString() ?? string.Empty;

            if (row.Cells["MaxCapacity"].Value != null && int.TryParse(row.Cells["MaxCapacity"].Value.ToString(), out int cap))
            {
                numMaxCapacity.Value = cap;
            }
            else
            {
                numMaxCapacity.Value = 0;
            }
        }

        private void ClearSectionInputs()
        {
            _selectedSectionId = 0;
            txtSectionName.Clear();
            txtSchoolYear.Text = "2026-2027";
            txtAdviser.Clear();
            numMaxCapacity.Value = 40;
            if (cboGradeLevel.Items.Count > 0)
            {
                cboGradeLevel.SelectedIndex = 0;
            }
            dgvSections.ClearSelection();
        }
    }
}