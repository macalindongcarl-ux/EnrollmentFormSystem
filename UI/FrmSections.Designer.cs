namespace UI
{
    partial class FrmSections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DASHBOARD = new Label();
            lblWelcome = new Label();
            pnlGradeLevels = new Panel();
            lblGradeLevelHeader = new Label();
            lblGradeLevelName = new Label();
            txtGradeLevelName = new TextBox();
            lblGradeTuitionFee = new Label();
            txtGradeTuitionFee = new TextBox();
            lblGradeMiscFee = new Label();
            txtGradeMiscFee = new TextBox();
            btnAddGradeLevel = new Button();
            btnUpdateGradeLevel = new Button();
            btnDeleteGradeLevel = new Button();
            btnClearGradeLevel = new Button();
            dgvGradeLevels = new DataGridView();
            pnlSections = new Panel();
            lblSectionsHeader = new Label();
            lblSectionGradeLevel = new Label();
            cboGradeLevel = new ComboBox();
            lblSectionName = new Label();
            txtSectionName = new TextBox();
            lblSchoolYear = new Label();
            txtSchoolYear = new TextBox();
            lblAdviser = new Label();
            txtAdviser = new TextBox();
            lblMaxCapacity = new Label();
            numMaxCapacity = new NumericUpDown();
            btnAddSection = new Button();
            btnUpdateSection = new Button();
            btnDeleteSection = new Button();
            btnClearSection = new Button();
            dgvSections = new DataGridView();
            pnlGradeLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevels).BeginInit();
            pnlSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSections).BeginInit();
            SuspendLayout();
            // 
            // DASHBOARD
            // 
            DASHBOARD.AutoSize = true;
            DASHBOARD.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DASHBOARD.Location = new Point(24, 18);
            DASHBOARD.Name = "DASHBOARD";
            DASHBOARD.Size = new Size(441, 54);
            DASHBOARD.TabIndex = 0;
            DASHBOARD.Text = "GRADE LEVELS & SECTIONS";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.DimGray;
            lblWelcome.Location = new Point(26, 74);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(478, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Manage grade levels, default fee rates, and class sections.";
            // 
            // pnlGradeLevels
            // 
            pnlGradeLevels.BackColor = Color.White;
            pnlGradeLevels.BorderStyle = BorderStyle.FixedSingle;
            pnlGradeLevels.Controls.Add(dgvGradeLevels);
            pnlGradeLevels.Controls.Add(btnClearGradeLevel);
            pnlGradeLevels.Controls.Add(btnDeleteGradeLevel);
            pnlGradeLevels.Controls.Add(btnUpdateGradeLevel);
            pnlGradeLevels.Controls.Add(btnAddGradeLevel);
            pnlGradeLevels.Controls.Add(txtGradeMiscFee);
            pnlGradeLevels.Controls.Add(lblGradeMiscFee);
            pnlGradeLevels.Controls.Add(txtGradeTuitionFee);
            pnlGradeLevels.Controls.Add(lblGradeTuitionFee);
            pnlGradeLevels.Controls.Add(txtGradeLevelName);
            pnlGradeLevels.Controls.Add(lblGradeLevelName);
            pnlGradeLevels.Controls.Add(lblGradeLevelHeader);
            pnlGradeLevels.Location = new Point(24, 122);
            pnlGradeLevels.Name = "pnlGradeLevels";
            pnlGradeLevels.Size = new Size(520, 930);
            pnlGradeLevels.TabIndex = 2;
            // 
            // lblGradeLevelHeader
            // 
            lblGradeLevelHeader.AutoSize = true;
            lblGradeLevelHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradeLevelHeader.Location = new Point(20, 18);
            lblGradeLevelHeader.Name = "lblGradeLevelHeader";
            lblGradeLevelHeader.Size = new Size(171, 37);
            lblGradeLevelHeader.TabIndex = 0;
            lblGradeLevelHeader.Text = "Grade Levels";
            // 
            // lblGradeLevelName
            // 
            lblGradeLevelName.AutoSize = true;
            lblGradeLevelName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeLevelName.Location = new Point(20, 70);
            lblGradeLevelName.Name = "lblGradeLevelName";
            lblGradeLevelName.Size = new Size(153, 25);
            lblGradeLevelName.TabIndex = 1;
            lblGradeLevelName.Text = "Grade Level Name";
            // 
            // txtGradeLevelName
            // 
            txtGradeLevelName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeLevelName.Location = new Point(20, 97);
            txtGradeLevelName.Name = "txtGradeLevelName";
            txtGradeLevelName.PlaceholderText = "e.g., Grade 7";
            txtGradeLevelName.Size = new Size(476, 33);
            txtGradeLevelName.TabIndex = 2;
            // 
            // lblGradeTuitionFee
            // 
            lblGradeTuitionFee.AutoSize = true;
            lblGradeTuitionFee.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeTuitionFee.Location = new Point(20, 142);
            lblGradeTuitionFee.Name = "lblGradeTuitionFee";
            lblGradeTuitionFee.Size = new Size(165, 25);
            lblGradeTuitionFee.TabIndex = 3;
            lblGradeTuitionFee.Text = "Default Tuition (₱)";
            // 
            // txtGradeTuitionFee
            // 
            txtGradeTuitionFee.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeTuitionFee.Location = new Point(20, 169);
            txtGradeTuitionFee.Name = "txtGradeTuitionFee";
            txtGradeTuitionFee.Size = new Size(228, 33);
            txtGradeTuitionFee.TabIndex = 4;
            txtGradeTuitionFee.Text = "0.00";
            txtGradeTuitionFee.TextAlign = HorizontalAlignment.Right;
            // 
            // lblGradeMiscFee
            // 
            lblGradeMiscFee.AutoSize = true;
            lblGradeMiscFee.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGradeMiscFee.Location = new Point(268, 142);
            lblGradeMiscFee.Name = "lblGradeMiscFee";
            lblGradeMiscFee.Size = new Size(147, 25);
            lblGradeMiscFee.TabIndex = 5;
            lblGradeMiscFee.Text = "Default Misc (₱)";
            // 
            // txtGradeMiscFee
            // 
            txtGradeMiscFee.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGradeMiscFee.Location = new Point(268, 169);
            txtGradeMiscFee.Name = "txtGradeMiscFee";
            txtGradeMiscFee.Size = new Size(228, 33);
            txtGradeMiscFee.TabIndex = 6;
            txtGradeMiscFee.Text = "0.00";
            txtGradeMiscFee.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAddGradeLevel
            // 
            btnAddGradeLevel.BackColor = Color.FromArgb(52, 118, 184);
            btnAddGradeLevel.FlatAppearance.BorderSize = 0;
            btnAddGradeLevel.FlatStyle = FlatStyle.Flat;
            btnAddGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGradeLevel.ForeColor = Color.White;
            btnAddGradeLevel.Location = new Point(20, 220);
            btnAddGradeLevel.Name = "btnAddGradeLevel";
            btnAddGradeLevel.Size = new Size(112, 40);
            btnAddGradeLevel.TabIndex = 7;
            btnAddGradeLevel.Text = "Add";
            btnAddGradeLevel.UseVisualStyleBackColor = false;
            btnAddGradeLevel.Click += btnAddGradeLevel_Click;
            // 
            // btnUpdateGradeLevel
            // 
            btnUpdateGradeLevel.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateGradeLevel.FlatAppearance.BorderSize = 0;
            btnUpdateGradeLevel.FlatStyle = FlatStyle.Flat;
            btnUpdateGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateGradeLevel.ForeColor = Color.White;
            btnUpdateGradeLevel.Location = new Point(141, 220);
            btnUpdateGradeLevel.Name = "btnUpdateGradeLevel";
            btnUpdateGradeLevel.Size = new Size(112, 40);
            btnUpdateGradeLevel.TabIndex = 8;
            btnUpdateGradeLevel.Text = "Update";
            btnUpdateGradeLevel.UseVisualStyleBackColor = false;
            btnUpdateGradeLevel.Click += btnUpdateGradeLevel_Click;
            // 
            // btnDeleteGradeLevel
            // 
            btnDeleteGradeLevel.BackColor = Color.FromArgb(200, 60, 60);
            btnDeleteGradeLevel.FlatAppearance.BorderSize = 0;
            btnDeleteGradeLevel.FlatStyle = FlatStyle.Flat;
            btnDeleteGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteGradeLevel.ForeColor = Color.White;
            btnDeleteGradeLevel.Location = new Point(262, 220);
            btnDeleteGradeLevel.Name = "btnDeleteGradeLevel";
            btnDeleteGradeLevel.Size = new Size(112, 40);
            btnDeleteGradeLevel.TabIndex = 9;
            btnDeleteGradeLevel.Text = "Delete";
            btnDeleteGradeLevel.UseVisualStyleBackColor = false;
            btnDeleteGradeLevel.Click += btnDeleteGradeLevel_Click;
            // 
            // btnClearGradeLevel
            // 
            btnClearGradeLevel.BackColor = Color.Gray;
            btnClearGradeLevel.FlatAppearance.BorderSize = 0;
            btnClearGradeLevel.FlatStyle = FlatStyle.Flat;
            btnClearGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearGradeLevel.ForeColor = Color.White;
            btnClearGradeLevel.Location = new Point(384, 220);
            btnClearGradeLevel.Name = "btnClearGradeLevel";
            btnClearGradeLevel.Size = new Size(112, 40);
            btnClearGradeLevel.TabIndex = 10;
            btnClearGradeLevel.Text = "Clear";
            btnClearGradeLevel.UseVisualStyleBackColor = false;
            btnClearGradeLevel.Click += btnClearGradeLevel_Click;
            // 
            // dgvGradeLevels
            // 
            dgvGradeLevels.AllowUserToAddRows = false;
            dgvGradeLevels.AllowUserToDeleteRows = false;
            dgvGradeLevels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGradeLevels.BackgroundColor = Color.White;
            dgvGradeLevels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradeLevels.Location = new Point(20, 280);
            dgvGradeLevels.MultiSelect = false;
            dgvGradeLevels.Name = "dgvGradeLevels";
            dgvGradeLevels.ReadOnly = true;
            dgvGradeLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradeLevels.Size = new Size(476, 626);
            dgvGradeLevels.TabIndex = 11;
            dgvGradeLevels.CellClick += dgvGradeLevels_CellClick;
            // 
            // pnlSections
            // 
            pnlSections.BackColor = Color.White;
            pnlSections.BorderStyle = BorderStyle.FixedSingle;
            pnlSections.Controls.Add(dgvSections);
            pnlSections.Controls.Add(btnClearSection);
            pnlSections.Controls.Add(btnDeleteSection);
            pnlSections.Controls.Add(btnUpdateSection);
            pnlSections.Controls.Add(btnAddSection);
            pnlSections.Controls.Add(numMaxCapacity);
            pnlSections.Controls.Add(lblMaxCapacity);
            pnlSections.Controls.Add(txtAdviser);
            pnlSections.Controls.Add(lblAdviser);
            pnlSections.Controls.Add(txtSchoolYear);
            pnlSections.Controls.Add(lblSchoolYear);
            pnlSections.Controls.Add(txtSectionName);
            pnlSections.Controls.Add(lblSectionName);
            pnlSections.Controls.Add(cboGradeLevel);
            pnlSections.Controls.Add(lblSectionGradeLevel);
            pnlSections.Controls.Add(lblSectionsHeader);
            pnlSections.Location = new Point(568, 122);
            pnlSections.Name = "pnlSections";
            pnlSections.Size = new Size(988, 930);
            pnlSections.TabIndex = 3;
            // 
            // lblSectionsHeader
            // 
            lblSectionsHeader.AutoSize = true;
            lblSectionsHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionsHeader.Location = new Point(24, 18);
            lblSectionsHeader.Name = "lblSectionsHeader";
            lblSectionsHeader.Size = new Size(118, 37);
            lblSectionsHeader.TabIndex = 0;
            lblSectionsHeader.Text = "Sections";
            // 
            // lblSectionGradeLevel
            // 
            lblSectionGradeLevel.AutoSize = true;
            lblSectionGradeLevel.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionGradeLevel.Location = new Point(24, 70);
            lblSectionGradeLevel.Name = "lblSectionGradeLevel";
            lblSectionGradeLevel.Size = new Size(104, 25);
            lblSectionGradeLevel.TabIndex = 1;
            lblSectionGradeLevel.Text = "Grade Level";
            // 
            // cboGradeLevel
            // 
            cboGradeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGradeLevel.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGradeLevel.FormattingEnabled = true;
            cboGradeLevel.Location = new Point(24, 97);
            cboGradeLevel.Name = "cboGradeLevel";
            cboGradeLevel.Size = new Size(300, 34);
            cboGradeLevel.TabIndex = 2;
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionName.Location = new Point(348, 70);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(121, 25);
            lblSectionName.TabIndex = 3;
            lblSectionName.Text = "Section Name";
            // 
            // txtSectionName
            // 
            txtSectionName.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSectionName.Location = new Point(348, 97);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.PlaceholderText = "e.g., Rizal / Section A";
            txtSectionName.Size = new Size(310, 33);
            txtSectionName.TabIndex = 4;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.AutoSize = true;
            lblSchoolYear.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchoolYear.Location = new Point(682, 70);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(105, 25);
            lblSchoolYear.TabIndex = 5;
            lblSchoolYear.Text = "School Year";
            // 
            // txtSchoolYear
            // 
            txtSchoolYear.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchoolYear.Location = new Point(682, 97);
            txtSchoolYear.Name = "txtSchoolYear";
            txtSchoolYear.PlaceholderText = "e.g., 2026-2027";
            txtSchoolYear.Size = new Size(280, 33);
            txtSchoolYear.TabIndex = 6;
            txtSchoolYear.Text = "2026-2027";
            // 
            // lblAdviser
            // 
            lblAdviser.AutoSize = true;
            lblAdviser.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdviser.Location = new Point(24, 150);
            lblAdviser.Name = "lblAdviser";
            lblAdviser.Size = new Size(153, 25);
            lblAdviser.TabIndex = 7;
            lblAdviser.Text = "Adviser (Optional)";
            // 
            // txtAdviser
            // 
            txtAdviser.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdviser.Location = new Point(24, 177);
            txtAdviser.Name = "txtAdviser";
            txtAdviser.PlaceholderText = "e.g., Ms. Maria Santos";
            txtAdviser.Size = new Size(634, 33);
            txtAdviser.TabIndex = 8;
            // 
            // lblMaxCapacity
            // 
            lblMaxCapacity.AutoSize = true;
            lblMaxCapacity.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaxCapacity.Location = new Point(682, 150);
            lblMaxCapacity.Name = "lblMaxCapacity";
            lblMaxCapacity.Size = new Size(243, 25);
            lblMaxCapacity.TabIndex = 9;
            lblMaxCapacity.Text = "Max Capacity (0 = No Limit)";
            // 
            // numMaxCapacity
            // 
            numMaxCapacity.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numMaxCapacity.Location = new Point(682, 177);
            numMaxCapacity.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numMaxCapacity.Name = "numMaxCapacity";
            numMaxCapacity.Size = new Size(280, 33);
            numMaxCapacity.TabIndex = 10;
            numMaxCapacity.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // btnAddSection
            // 
            btnAddSection.BackColor = Color.FromArgb(52, 118, 184);
            btnAddSection.FlatAppearance.BorderSize = 0;
            btnAddSection.FlatStyle = FlatStyle.Flat;
            btnAddSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSection.ForeColor = Color.White;
            btnAddSection.Location = new Point(24, 232);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new Size(165, 42);
            btnAddSection.TabIndex = 11;
            btnAddSection.Text = "Add Section";
            btnAddSection.UseVisualStyleBackColor = false;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // btnUpdateSection
            // 
            btnUpdateSection.BackColor = Color.FromArgb(46, 139, 87);
            btnUpdateSection.FlatAppearance.BorderSize = 0;
            btnUpdateSection.FlatStyle = FlatStyle.Flat;
            btnUpdateSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSection.ForeColor = Color.White;
            btnUpdateSection.Location = new Point(205, 232);
            btnUpdateSection.Name = "btnUpdateSection";
            btnUpdateSection.Size = new Size(165, 42);
            btnUpdateSection.TabIndex = 12;
            btnUpdateSection.Text = "Update";
            btnUpdateSection.UseVisualStyleBackColor = false;
            btnUpdateSection.Click += btnUpdateSection_Click;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.BackColor = Color.FromArgb(200, 60, 60);
            btnDeleteSection.FlatAppearance.BorderSize = 0;
            btnDeleteSection.FlatStyle = FlatStyle.Flat;
            btnDeleteSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSection.ForeColor = Color.White;
            btnDeleteSection.Location = new Point(386, 232);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Size = new Size(165, 42);
            btnDeleteSection.TabIndex = 13;
            btnDeleteSection.Text = "Delete";
            btnDeleteSection.UseVisualStyleBackColor = false;
            btnDeleteSection.Click += btnDeleteSection_Click;
            // 
            // btnClearSection
            // 
            btnClearSection.BackColor = Color.Gray;
            btnClearSection.FlatAppearance.BorderSize = 0;
            btnClearSection.FlatStyle = FlatStyle.Flat;
            btnClearSection.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearSection.ForeColor = Color.White;
            btnClearSection.Location = new Point(567, 232);
            btnClearSection.Name = "btnClearSection";
            btnClearSection.Size = new Size(165, 42);
            btnClearSection.TabIndex = 14;
            btnClearSection.Text = "Clear";
            btnClearSection.UseVisualStyleBackColor = false;
            btnClearSection.Click += btnClearSection_Click;
            // 
            // dgvSections
            // 
            dgvSections.AllowUserToAddRows = false;
            dgvSections.AllowUserToDeleteRows = false;
            dgvSections.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSections.BackgroundColor = Color.White;
            dgvSections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSections.Location = new Point(24, 294);
            dgvSections.MultiSelect = false;
            dgvSections.Name = "dgvSections";
            dgvSections.ReadOnly = true;
            dgvSections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSections.Size = new Size(938, 612);
            dgvSections.TabIndex = 15;
            dgvSections.CellClick += dgvSections_CellClick;
            // 
            // FrmSections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 247);
            ClientSize = new Size(1580, 1080);
            Controls.Add(pnlSections);
            Controls.Add(pnlGradeLevels);
            Controls.Add(DASHBOARD);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSections";
            Text = "FrmSections";
            Load += FrmSections_Load;
            pnlGradeLevels.ResumeLayout(false);
            pnlGradeLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradeLevels).EndInit();
            pnlSections.ResumeLayout(false);
            pnlSections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DASHBOARD;
        private Label lblWelcome;
        private Panel pnlGradeLevels;
        private Label lblGradeLevelHeader;
        private Label lblGradeLevelName;
        private TextBox txtGradeLevelName;
        private Label lblGradeTuitionFee;
        private TextBox txtGradeTuitionFee;
        private Label lblGradeMiscFee;
        private TextBox txtGradeMiscFee;
        private Button btnAddGradeLevel;
        private Button btnUpdateGradeLevel;
        private Button btnDeleteGradeLevel;
        private Button btnClearGradeLevel;
        private DataGridView dgvGradeLevels;
        private Panel pnlSections;
        private Label lblSectionsHeader;
        private Label lblSectionGradeLevel;
        private ComboBox cboGradeLevel;
        private Label lblSectionName;
        private TextBox txtSectionName;
        private Label lblSchoolYear;
        private TextBox txtSchoolYear;
        private Label lblAdviser;
        private TextBox txtAdviser;
        private Label lblMaxCapacity;
        private NumericUpDown numMaxCapacity;
        private Button btnAddSection;
        private Button btnUpdateSection;
        private Button btnDeleteSection;
        private Button btnClearSection;
        private DataGridView dgvSections;
    }
}