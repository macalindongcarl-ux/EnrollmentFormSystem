using EnrollmentFormSystem.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace EnrollmentFormSystem
{
    public partial class frmstudents : Form
    {
       private readonly Businesslogic studentBL = new Businesslogic();

            public frmstudents()
            {
                InitializeComponent();
                LoadComboBoxes();
            }



            private void LoadComboBoxes()
            {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbGradeLevel.Items.Clear();
            cmbGradeLevel.Items.Add("Grade 7");
            cmbGradeLevel.Items.Add("Grade 8");
            cmbGradeLevel.Items.Add("Grade 9");
            cmbGradeLevel.Items.Add("Grade 10");
          

            cmbSection.Items.Clear();
            cmbSection.Items.Add("Section A");
            cmbSection.Items.Add("Section B");
            cmbSection.Items.Add("Section C");
        }
            

                

            private Student GetStudentFromForm()
            {
           
            return new Student
            {
                StudentID = txtstudid.Text.Trim(),
                FirstName = txtFiirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dateTimePicker1.Value,
                Gender = cmbGender.Text,
                Address = txtAddress.Text.Trim(),
                ContactNumber = TxtContactNo.Text.Trim(),
                GuardianName = txtGuardian.Text.Trim(),
                GuardianNo = txtGuardianNO.Text.Trim(),
                GradeLevel = cmbGradeLevel.Text,
                Section = cmbSection.Text
            };
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = GetStudentFromForm();

                if (studentBL.UpdateStudent(student))
                {
                    MessageBox.Show(
                        "Student updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Update Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                Student student = GetStudentFromForm();

                if (studentBL.AddStudent(student))
                {
                    MessageBox.Show(
                        "Student added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadStudents();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Add Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtstudid.Text))
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (studentBL.DeleteStudent(txtstudid.Text))
                    {
                        MessageBox.Show(
                            "Student deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadStudents();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string keyword = txtSearch.Text.Trim();
                dgvStudents.DataSource = null;
                DataTable results = studentBL.SearchStudents(keyword);
                dgvStudents.DataSource = results;

                if (results.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No matching student found.",
                        "Search Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
         
            ClearFields();
        }

        private void ClearFields()
        {
            txtstudid.Clear();
            txtFiirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            TxtContactNo.Clear();
            txtGuardian.Clear();
            txtGuardianNO.Clear();

            cmbGender.SelectedIndex = -1;
            cmbGradeLevel.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;

            dateTimePicker1.Value = DateTime.Today;

            txtstudid.Enabled = true;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvStudents.Rows.Count)
                return;

            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            if (row.IsNewRow) return;

            // Safe accessor by column name or fallback to index position
            string GetValue(string colName, int fallbackIndex)
            {
                if (dgvStudents.Columns.Contains(colName) && row.Cells[colName].Value != null && row.Cells[colName].Value != DBNull.Value)
                {
                    return row.Cells[colName].Value.ToString();
                }
                if (fallbackIndex < row.Cells.Count && row.Cells[fallbackIndex].Value != null && row.Cells[fallbackIndex].Value != DBNull.Value)
                {
                    return row.Cells[fallbackIndex].Value.ToString();
                }
                return string.Empty;
            }

            txtstudid.Text = GetValue("StudentID", 0);
            txtFiirstName.Text = GetValue("FirstName", 1);
            txtMiddleName.Text = GetValue("MiddleName", 2);
            txtLastName.Text = GetValue("LastName", 3);

            string dobStr = GetValue("DateOfBirth", 4);
            if (!string.IsNullOrEmpty(dobStr) && DateTime.TryParse(dobStr, out DateTime dob))
            {
                dateTimePicker1.Value = dob;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Today;
            }

            cmbGender.Text = GetValue("Gender", 5);
            txtAddress.Text = GetValue("Address", 6);
            TxtContactNo.Text = GetValue("ContactNumber", 7);
            txtGuardian.Text = GetValue("GuardianName", 8);
            txtGuardianNO.Text = GetValue("GuardianContact", 9);
            cmbGradeLevel.Text = GetValue("GradeLevel", 10);
            cmbSection.Text = GetValue("Section", 11);

            txtstudid.Enabled = false;
        }
    

        private void frmstudents_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(235, 245, 255);

            // Labels
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = Color.FromArgb(20, 40, 70);
                }
            }

            // Buttons
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.ForeColor = Color.White;

            btnUpdate.BackColor = Color.Blue;
            btnUpdate.ForeColor = Color.White;

            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;

            btnClear.BackColor = Color.DarkOrange;
            btnClear.ForeColor = Color.White;

            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.ForeColor = Color.White;
        
            dgvStudents.AutoGenerateColumns = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;

            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                dgvStudents.DataSource = null;
                DataTable dt = studentBL.GetStudents();
                dgvStudents.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error Loading Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    }

        

    


    

    
    