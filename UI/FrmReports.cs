using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class FrmReports : Form
    {
        private readonly UserModel _currentUser;
        private readonly EnrollmentController _enrollmentController;
        private readonly GradeLevelController _gradeLevelController;
        private readonly SectionController _sectionController;

        private List<EnrollmentModel> _allEnrollments = new List<EnrollmentModel>();
        private List<GradeLevelModel> _gradeLevels = new List<GradeLevelModel>();
        private List<SectionModel> _sections = new List<SectionModel>();
        private List<EnrollmentModel> _filteredRoster = new List<EnrollmentModel>();

        private bool _isInitializing = true;
        private int _printRowIndex = 0;

        public FrmReports(UserModel userModel)
        {
            InitializeComponent();
            _currentUser = userModel;
            _enrollmentController = new EnrollmentController();
            _gradeLevelController = new GradeLevelController();
            _sectionController = new SectionController();

            lblWelcome.Text = $"Welcome, {_currentUser.Username} ({_currentUser.Role})! Generate, print, and export student enrollment rosters by Grade Level and Section.";
            cboStatusFilter.SelectedIndex = 0;
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            StyleDataGridView(dgvReports);
            LoadFilterData();
            _isInitializing = false;
            ApplyFilters();
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

        private void LoadFilterData()
        {
            _allEnrollments = _enrollmentController.GetAll(includeInactive: false);
            _gradeLevels = _gradeLevelController.GetAll(includeInactive: false);
            _sections = _sectionController.GetAll(includeInactive: false);

            // Populate School Years
            var schoolYears = _allEnrollments
                .Select(e => e.SchoolYear)
                .Where(sy => !string.IsNullOrWhiteSpace(sy))
                .Distinct()
                .OrderByDescending(sy => sy)
                .ToList();

            cboSchoolYearFilter.Items.Clear();
            cboSchoolYearFilter.Items.Add("All School Years");
            foreach (string sy in schoolYears)
            {
                cboSchoolYearFilter.Items.Add(sy);
            }
            cboSchoolYearFilter.SelectedIndex = 0;

            // Populate Grade Levels
            var gradeOptions = new List<GradeLevelModel>
            {
                new GradeLevelModel { GradeLevelID = 0, GradeLevelName = "All Grade Levels" }
            };
            gradeOptions.AddRange(_gradeLevels);

            cboGradeLevelFilter.DataSource = null;
            cboGradeLevelFilter.DataSource = gradeOptions;
            cboGradeLevelFilter.DisplayMember = "GradeLevelName";
            cboGradeLevelFilter.ValueMember = "GradeLevelID";
            cboGradeLevelFilter.SelectedIndex = 0;

            PopulateSectionsByGrade(0);
        }

        private void PopulateSectionsByGrade(int gradeLevelId)
        {
            var sectionOptions = new List<SectionModel>
            {
                new SectionModel { SectionID = 0, SectionName = "All Sections" }
            };

            IEnumerable<SectionModel> matchingSections = _sections;
            if (gradeLevelId > 0)
            {
                matchingSections = matchingSections.Where(s => s.GradeLevelID == gradeLevelId);
            }

            sectionOptions.AddRange(matchingSections);

            cboSectionFilter.DataSource = null;
            cboSectionFilter.DataSource = sectionOptions;
            cboSectionFilter.DisplayMember = "SectionName";
            cboSectionFilter.ValueMember = "SectionID";
            cboSectionFilter.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            string selectedSchoolYear = cboSchoolYearFilter.SelectedItem?.ToString() ?? "All School Years";
            int selectedGradeId = cboGradeLevelFilter.SelectedValue is int gId ? gId : 0;
            int selectedSectionId = cboSectionFilter.SelectedValue is int sId ? sId : 0;
            string selectedStatus = cboStatusFilter.SelectedItem?.ToString() ?? "Enrolled";
            string query = txtSearch.Text.Trim();

            IEnumerable<EnrollmentModel> filtered = _allEnrollments;

            if (!selectedSchoolYear.Equals("All School Years", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(e =>
                    e.SchoolYear.Equals(selectedSchoolYear, StringComparison.OrdinalIgnoreCase));
            }

            if (selectedGradeId > 0)
            {
                filtered = filtered.Where(e => e.GradeLevelID == selectedGradeId);
            }

            if (selectedSectionId > 0)
            {
                filtered = filtered.Where(e => e.SectionID == selectedSectionId);
            }

            if (!selectedStatus.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(e =>
                    e.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(query))
            {
                filtered = filtered.Where(e =>
                    e.StudentNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    e.StudentName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            _filteredRoster = filtered
                .OrderBy(e => e.GradeLevelID)
                .ThenBy(e => e.SectionName)
                .ThenBy(e => e.StudentName)
                .ToList();

            BindGrid(_filteredRoster);
            UpdateSummaryCards(_filteredRoster);
        }

        private void BindGrid(List<EnrollmentModel> roster)
        {
            dgvReports.DataSource = null;
            dgvReports.DataSource = roster;

            string[] hiddenColumns =
            {
                "EnrollmentID",
                "StudentID",
                "GradeLevelID",
                "SectionID",
                "IsActive",
                "DateCreated"
            };

            foreach (string colName in hiddenColumns)
            {
                if (dgvReports.Columns[colName] != null)
                    dgvReports.Columns[colName].Visible = false;
            }

            if (dgvReports.Columns["StudentNumber"] != null)
            {
                dgvReports.Columns["StudentNumber"].HeaderText = "Student Number";
                dgvReports.Columns["StudentNumber"].DisplayIndex = 0;
                dgvReports.Columns["StudentNumber"].FillWeight = 15;
            }
            if (dgvReports.Columns["StudentName"] != null)
            {
                dgvReports.Columns["StudentName"].HeaderText = "Student Name";
                dgvReports.Columns["StudentName"].DisplayIndex = 1;
                dgvReports.Columns["StudentName"].FillWeight = 29;
            }
            if (dgvReports.Columns["GradeLevelName"] != null)
            {
                dgvReports.Columns["GradeLevelName"].HeaderText = "Grade Level";
                dgvReports.Columns["GradeLevelName"].DisplayIndex = 2;
                dgvReports.Columns["GradeLevelName"].FillWeight = 13;
            }
            if (dgvReports.Columns["SectionName"] != null)
            {
                dgvReports.Columns["SectionName"].HeaderText = "Section";
                dgvReports.Columns["SectionName"].DisplayIndex = 3;
                dgvReports.Columns["SectionName"].FillWeight = 14;
            }
            if (dgvReports.Columns["SchoolYear"] != null)
            {
                dgvReports.Columns["SchoolYear"].HeaderText = "School Year";
                dgvReports.Columns["SchoolYear"].DisplayIndex = 4;
                dgvReports.Columns["SchoolYear"].FillWeight = 11;
            }
            if (dgvReports.Columns["Status"] != null)
            {
                dgvReports.Columns["Status"].HeaderText = "Status";
                dgvReports.Columns["Status"].DisplayIndex = 5;
                dgvReports.Columns["Status"].DefaultCellStyle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                dgvReports.Columns["Status"].FillWeight = 9;
            }
            if (dgvReports.Columns["EnrollmentDate"] != null)
            {
                dgvReports.Columns["EnrollmentDate"].HeaderText = "Date Enrolled";
                dgvReports.Columns["EnrollmentDate"].DisplayIndex = 6;
                dgvReports.Columns["EnrollmentDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvReports.Columns["EnrollmentDate"].FillWeight = 9;
            }
        }

        private void UpdateSummaryCards(List<EnrollmentModel> roster)
        {
            int totalCount = roster.Count;
            int enrolledCount = roster.Count(e => e.Status.Equals("Enrolled", StringComparison.OrdinalIgnoreCase));
            int otherCount = totalCount - enrolledCount;
            int sectionsCount = roster.Select(e => e.SectionID).Distinct().Count();

            lblCardTotalValue.Text = totalCount.ToString();
            lblCardEnrolledValue.Text = enrolledCount.ToString();
            lblCardOtherValue.Text = otherCount.ToString();
            lblCardSectionsValue.Text = sectionsCount.ToString();
        }

        // --- Filter Events ---

        private void cboGradeLevelFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            _isInitializing = true;
            int selectedGradeId = cboGradeLevelFilter.SelectedValue is int gId ? gId : 0;
            PopulateSectionsByGrade(selectedGradeId);
            _isInitializing = false;

            ApplyFilters();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            ApplyFilters();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            _isInitializing = true;
            cboSchoolYearFilter.SelectedIndex = 0;
            cboGradeLevelFilter.SelectedIndex = 0;
            PopulateSectionsByGrade(0);
            cboStatusFilter.SelectedIndex = 0;
            txtSearch.Clear();
            _isInitializing = false;

            ApplyFilters();
        }

        // --- Export CSV ---

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (_filteredRoster.Count == 0)
            {
                MessageBox.Show("There are no records in the current report view to export.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = $"Student_Roster_Report_{DateTime.Now:yyyyMMdd_HHmm}.csv",
                Title = "Export Student Information Report"
            };

            if (saveDialog.ShowDialog(this) != DialogResult.OK) return;

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Student Number,Student Name,Grade Level,Section,School Year,Status,Date Enrolled");

                foreach (EnrollmentModel item in _filteredRoster)
                {
                    sb.AppendLine(string.Join(",",
                        EscapeCsv(item.StudentNumber),
                        EscapeCsv(item.StudentName),
                        EscapeCsv(item.GradeLevelName),
                        EscapeCsv(item.SectionName),
                        EscapeCsv(item.SchoolYear),
                        EscapeCsv(item.Status),
                        EscapeCsv(item.EnrollmentDate.ToString("MM/dd/yyyy"))));
                }

                File.WriteAllText(saveDialog.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show($"Report exported successfully to:\n{saveDialog.FileName}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to export report: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value)) return "\"\"";
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }

        // --- Print Preview ---

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            if (_filteredRoster.Count == 0)
            {
                MessageBox.Show("There are no records in the current report view to print.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _printRowIndex = 0;

            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Student_Information_Report";
            printDoc.PrintPage += PrintDoc_PrintPage;

            using PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 1000,
                Height = 750,
                StartPosition = FormStartPosition.CenterParent
            };

            previewDialog.ShowDialog(this);
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
            using Font subTitleFont = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            using Font headerFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            using Font rowFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            using Pen linePen = new Pen(Color.FromArgb(30, 41, 59), 1.5f);
            using Pen gridPen = new Pen(Color.LightGray, 0.75f);

            int left = e.MarginBounds.Left;
            int right = e.MarginBounds.Right;
            int y = e.MarginBounds.Top;

            string gradeText = cboGradeLevelFilter.Text;
            string sectionText = cboSectionFilter.Text;
            string syText = cboSchoolYearFilter.Text;

            g.DrawString("STUDENT INFORMATION & ENROLLMENT REPORT", titleFont, Brushes.Black, left, y);
            y += 30;
            g.DrawString($"Filter: {syText}  |  {gradeText}  |  {sectionText}  |  Status: {cboStatusFilter.Text}", subTitleFont, Brushes.DimGray, left, y);
            y += 22;
            g.DrawString($"Generated by: {_currentUser.Username} on {DateTime.Now:MMMM dd, yyyy hh:mm tt}", subTitleFont, Brushes.DimGray, left, y);
            y += 28;

            g.DrawLine(linePen, left, y, right, y);
            y += 8;

            // Column X offsets
            int colNo = left;
            int colLrn = left + 40;
            int colName = left + 155;
            int colGrade = left + 365;
            int colSection = left + 455;
            int colStatus = left + 560;

            g.DrawString("#", headerFont, Brushes.Black, colNo, y);
            g.DrawString("Student No.", headerFont, Brushes.Black, colLrn, y);
            g.DrawString("Student Name", headerFont, Brushes.Black, colName, y);
            g.DrawString("Grade", headerFont, Brushes.Black, colGrade, y);
            g.DrawString("Section", headerFont, Brushes.Black, colSection, y);
            g.DrawString("Status", headerFont, Brushes.Black, colStatus, y);

            y += 24;
            g.DrawLine(linePen, left, y, right, y);
            y += 8;

            while (_printRowIndex < _filteredRoster.Count)
            {
                if (y + 26 > e.MarginBounds.Bottom - 30)
                {
                    e.HasMorePages = true;
                    return;
                }

                EnrollmentModel item = _filteredRoster[_printRowIndex];

                g.DrawString((_printRowIndex + 1).ToString(), rowFont, Brushes.Black, colNo, y);
                g.DrawString(item.StudentNumber, rowFont, Brushes.Black, colLrn, y);
                g.DrawString(item.StudentName, rowFont, Brushes.Black, colName, y);
                g.DrawString(item.GradeLevelName, rowFont, Brushes.Black, colGrade, y);
                g.DrawString(item.SectionName, rowFont, Brushes.Black, colSection, y);
                g.DrawString(item.Status, rowFont, Brushes.Black, colStatus, y);

                y += 22;
                g.DrawLine(gridPen, left, y, right, y);
                y += 4;

                _printRowIndex++;
            }

            y += 10;
            g.DrawString($"Total Students Listed: {_filteredRoster.Count}", headerFont, Brushes.Black, left, y);
            e.HasMorePages = false;
        }
    }
}